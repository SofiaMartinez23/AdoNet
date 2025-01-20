using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

#region

//alter procedure SP_ALL_DEPARTAMENTOS 
//as 
//select * from DEPT
//go 


//alter procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50)) 
//as 
//insert into DEPT values (@numero, @nombre, @localidad) 
//go



//alter procedure SP_INSERT_DEPARTAMENTO
//(@numero int, @nombre nvarchar(50), @localidad nvarchar(50)) 
//as 
//	if (@localidad = 'TERUEL')
//	begin
//		print 'TERUEL NO EXISTE'
//	end
//	else
//	begin
//		insert into DEPT values (@numero, @nombre, @localidad) 
//	end
//go

#endregion

namespace AdoNetCore
{
    public partial class Form12MensajesServidor : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public Form12MensajesServidor()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            //RECUPERAMOS EL EVENTO DE MENSAJES DE LA CONEXION
            this.cn.InfoMessage += Cn_InfoMenssage;
            this.LoadDepartamento();
        }

        private void Cn_InfoMenssage(object sender, SqlInfoMessageEventArgs e)
        {
           this.lblMensaje.Text = e.Message;
        }

        public async Task LoadDepartamento()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstDepartamentos.Items.Clear();

            while (await this.reader.ReadAsync())
            {
                string id = this.reader["DEPT_NO"].ToString();
                string nombre = this.reader["DNOMBRE"].ToString();
                string localidad = this.reader["LOC"].ToString();
                this.lstDepartamentos.Items.Add(id + "-" + nombre + "-" + localidad);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private  void btnInsertar_Click(object sender, EventArgs e)
        {
            this.lblMensaje.Text = "";
            int id = int.Parse(this.txtNumero.Text);
            string nombre = this.txtNombre.Text;
            string localidad = this.txtLoc.Text;
            string sql = "SP_INSERT_DEPARTAMENTO";
            this.com.Parameters.AddWithValue("@numero", id);
            this.com.Parameters.AddWithValue("@nombre", nombre);
            this.com.Parameters.AddWithValue("@localidad", localidad);
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;
            this.cn.Open();
            int afectados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            //await this.LoadDepartamentos(); 
            MessageBox.Show("Insertados " + afectados);
        }
    }
}
