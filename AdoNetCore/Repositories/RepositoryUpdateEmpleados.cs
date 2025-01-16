using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace AdoNetCore.Repositories
{
    public class RepositoryUpdateEmpleados
    {

        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositoryUpdateEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
        }

        public async Task<List<string>> GetOficiosAsync()
        {
            string sql = "SELECT DISTINCT OFICIO FROM EMP";
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            List<string> oficios = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string oficio = this.reader["OFICIO"].ToString();
                oficios.Add(oficio);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return oficios;
        }

        public async Task<List<string>> GetEmpleadosOficiosAsync(string oficio)
        {
            string sql = "SELECT APELLIDO FROM EMP WHERE OFICIO = @oficio";
            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> empleados = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string empleado = this.reader["APELLIDO"].ToString();
                empleados.Add(empleado);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return empleados;
        }

        public async Task<int> UpdateSalarioEmpleadosOficio(string oldOficio, int incremento, string newOficio)
        {
            string sql = "UPDATE EMP SET SALARIO = SALARIO + @incremento, OFICIO = @newOficio WHERE OFICIO = @oficio ";
            this.com.Parameters.AddWithValue("@incremento", incremento);
            this.com.Parameters.AddWithValue("@newOficio", newOficio);
            this.com.Parameters.AddWithValue("@oldOficio", oldOficio);

            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            int afectados = await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return afectados;
        }


        public async Task<DatosEmpleadosOficio> GetSalariosOficioAsync(string oficio)
        {

            string sql = "SELECT SUM(SALARIO) AS SUMA " 
                + " ,AVG(SALARIO) AS MEDIA,  MAX(SALARIO) AS MAXIMA " 
                + "FROM EMP WHERE OFICIO = @oficio GROUP BY OFICIO";

            this.com.Parameters.AddWithValue("@oficio", oficio);
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;
            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            DatosEmpleadosOficio datos = new DatosEmpleadosOficio();
            await this.reader.ReadAsync();
            datos.SumaSalarial = int.Parse(this.reader["SUMA"].ToString());
            datos.MediaSalarial = int.Parse(this.reader["MEDIA"].ToString());
            datos.MaximoSalarial = int.Parse(this.reader["MAXIMA"].ToString());

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            return datos;
        }


    }
}
