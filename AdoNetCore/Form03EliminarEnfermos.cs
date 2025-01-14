using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AdoNetCore
{
    public partial class Form03EliminarEnfermos : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form03EliminarEnfermos()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarEnfermos();

        }

        private void CargarEnfermos()
        {    
            string sql = "SELECT * FROM ENFERMO";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            this.lstEnfermos.Items.Clear();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string inscripcion = this.reader["INSCRIPCION"].ToString();
                this.lstEnfermos.Items.Add(apellido + " - " + inscripcion);
            }

            this.reader.Close();
            this.cn.Close();
        }

        private void btnEliminarEnfermo_Click(object sender, EventArgs e)
        {
            int inscripcion = int.Parse(this.txtInscripcion.Text);
            string sql = "DELETE FROM ENFERMO WHERE INSCRIPCION = @inscripcion";
            //CREAMOS EL PARAMETRO PARA LA INSCRIPCION
            SqlParameter prmInscripcion = new SqlParameter("@inscripcion", inscripcion);
            //prmInscripcion.ParameterName = "@inscripcion";
            //Value DEBE SER DEL MISMO TIPO QUE EL PARAMETRO (int)
            //prmInscripcion.Value = inscripcion;
            //prmInscripcion.DbType = DbType.Int32;
            //Direction INDICA SI EL PARAMETRO ES ENTRADA O SALIDA
            //POR DEFECTO ES INPUT
            //prmInscripcion.Direction = ParameterDirection.Input;
            //AÑADIMOS EL PARAMETRO A LA COLECCION DE PARAMETROS DEL COMANDO
            this.com.Parameters.Add(prmInscripcion);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.com.Parameters.Clear();
            this.CargarEnfermos();
            MessageBox.Show("Empleados eliminados: " + eliminados);
        }
    }
}
