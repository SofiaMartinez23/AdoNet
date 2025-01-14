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
    public partial class Form04EliminarPlantilla : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form04EliminarPlantilla()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.CargarPlatilla();
        }

        private void CargarPlatilla()
        {
            string sql = "SELECT * FROM PLANTILLA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string idEmpleado = this.reader["EMPLEADO_NO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + idEmpleado);
            }

            this.reader.Close();
            this.cn.Close();

        }

        private void btnEliminarPlantilla_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM PLANTILLA WHERE EMPLEADO_NO =" + this.txtIdEmpleado.Text;
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            int eliminados = this.com.ExecuteNonQuery();
            this.cn.Close();
            this.CargarPlatilla();
            MessageBox.Show("Enfermos eliminados: " + eliminados);


        }

    }
}
