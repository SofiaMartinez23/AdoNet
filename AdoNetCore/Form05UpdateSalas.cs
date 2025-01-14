using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace AdoNetCore
{
    public partial class Form05UpdateSalas : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form05UpdateSalas()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.cargarSalas();
        }

        private async void cargarSalas()
        {
            string sql = "SELECT DISTINCT NOMBRE FROM SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();

            this.reader = await this.com.ExecuteReaderAsync();
            this.lstSalas.Items.Clear();

            while (await this.reader.ReadAsync())
            {
                string salaNombre = this.reader["NOMBRE"].ToString();
                this.lstSalas.Items.Add(salaNombre);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnModificarSala_Click(object sender, EventArgs e)
        {
            // Actualiza la sala en la base de datos
            string sql = "UPDATE SALA SET NOMBRE = @nuevoNombre WHERE NOMBRE = @antiguoNombre";
            string nuevoNombre = this.txtSala.Text;
            string antiguoNombre = this.lstSalas.SelectedItem.ToString();

            SqlParameter pamOld = new SqlParameter("@antiguoNombre", antiguoNombre);
            SqlParameter pamNew = new SqlParameter("@nuevoNombre", nuevoNombre);

            this.com.Parameters.Add(pamOld);
            this.com.Parameters.Add(pamNew);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();


            int afectados = await this.com.ExecuteNonQueryAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            this.cargarSalas();
            MessageBox.Show("Salas modificadas: " + afectados);

        }
    }
}
