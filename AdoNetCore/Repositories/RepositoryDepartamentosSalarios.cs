using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;

namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentosSalarios
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamentosSalarios()
        {
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
        }

        public async Task<List<string>> GetDepartamentosAsync()
        {
            string sql = "SP_ALL_DEPARTAMENTOS";
            this.com.Connection = this.cn;
            this.com.CommandType = CommandType.StoredProcedure;
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

        public async Task GetEmpleadosDepa(string depa)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUT";
            this.com.Parameters.AddWithValue("@nombre", depa);

            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            pamSuma.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamSuma);

            SqlParameter pamMedia = new SqlParameter();
            pamMedia.ParameterName = "@media";
            pamMedia.Value = 0;
            pamMedia.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamMedia);

            SqlParameter pamPersonas = new SqlParameter();
            pamPersonas.ParameterName = "@personas";
            pamPersonas.Value = 0;
            pamPersonas.Direction = ParameterDirection.Output;
            this.com.Parameters.Add(pamPersonas);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            List<string> empleados = new List<string>();

            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                empleados.Add(apellido);
            }

            await this.reader.CloseAsync();

            decimal sumaSalarial = Convert.ToDecimal(this.com.Parameters["@suma"].Value);
            decimal mediaSalarial = Convert.ToDecimal(this.com.Parameters["@media"].Value);
            int cantidadPersonas = Convert.ToInt32(this.com.Parameters["@personas"].Value);

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();

            return new EmpleadoDeptInfo
            {
                Empleados = empleados,
                SumaSalarial = sumaSalarial,
                MediaSalarial = mediaSalarial,
                Personas = cantidadPersonas
            };
        }


    }
}
