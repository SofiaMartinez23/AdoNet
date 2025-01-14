using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositorySalas
    {
        private SqlConnection cn;
        private SqlCommand com;
        private SqlDataReader reader;

        public RepositorySalas()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetNombresSalaAsync()
        {
            string sql = "SELECT DISTINCT NOMBRE FROM SALA";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.Text;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            //NECESITAMSO CREAR EL OBJETO QUE VAYAMOS A DEVOLVER
            List<string> salas = new List<string>();
            while(await this.reader.ReadAsync())
            {
                string nombre = this.reader["Nombre"].ToString();
                salas.Add(nombre);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();

            return salas;
        }

        public async Task UpdateNombreSalaAsyn(string oldName, string newName)
        {
            string sql = "UPDATE SALA SET NOMBRE= @nuevoNombre " +" WHERE NOMBRE = @antiguoNombre";
            SqlParameter pamNewName = new SqlParameter("@nuevoNombre", newName);
            this.com.Parameters.Add(pamNewName);

            SqlParameter pamOldName = new SqlParameter("@antiguoNombre", oldName);
            this.com.Parameters.Add(pamOldName);

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
