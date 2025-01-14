using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentosEmpleados
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamentosEmpleados()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SELECT DISTINCT DNOMBRE FROM DEPT";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> departamentos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["DNOMBRE"].ToString();
                departamentos.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return departamentos;
        }

        public async Task<List<string>> GetEmpleadosAsync()
        {
            string sql = "SELECT DISTINCT APELLIDO FROM EMP";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> empleados = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string nombre = this.reader["APELLIDO"].ToString();
                empleados.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return empleados;
        }

        public async Task EliminarNombreEmpleado(string apellido)
        {
            string sql = "DELETE FROM EMP WHERE APELLIDO = @apellido";
            SqlParameter pamApellido = new SqlParameter("@apellido", apellido);
            this.com.Parameters.Add(pamApellido);

            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            await this.com.ExecuteNonQueryAsync();

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
