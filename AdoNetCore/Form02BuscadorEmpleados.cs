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
    public partial class Form02BuscadorEmpleados : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form02BuscadorEmpleados()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        private void btnBuscarEmpleados_Click(object sender, EventArgs e)
        {
            string salario = this.txtSalario.Text;
            string sql = "SELECT * FROM EMP WHERE SALARIO >= " + salario;
            //CONEXIO
            this.com.Connection = this.cn;
            //TIPO DE CONSULTA
            this.com.CommandType = CommandType.Text;
            //LA CONSULTA
            this.com.CommandText = sql;
            //ABRIMOS LA CONEXION
            //ENTRAR Y SALIR 
            this.cn.Open();
            this.reader = this.com.ExecuteReader();
            //DIBUJAMOS LOS DATOS
            this.lstEmpleados.Items.Clear();
            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salarioEmpleado = this.reader["SALARIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + salarioEmpleado);
            }
            //LIBERAMOS TODOS LOS RECURSOS UTILIZADOS
            this.reader.Close();
            this.cn.Close();
        }

        private void btnOficio_Click(object sender, EventArgs e)
        {
            string oficio = this.txtOficio.Text;
            string sql = "SELECT * FROM EMP WHERE OFICIO = '" + oficio + "'";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            this.cn.Open();

            this.reader = this.com.ExecuteReader();
            this.lstEmpleados.Items.Clear();

            while (this.reader.Read())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string oficioEmpleado = this.reader["OFICIO"].ToString();
                this.lstEmpleados.Items.Add(apellido + " - " + oficioEmpleado);
            }
            this.reader.Close();
            this.cn.Close();
        }
    }
}
