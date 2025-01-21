using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdoNetCore.Helpers;
using AdoNetCore.Models;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdoNetCore.Repositories
{
    public class RepositoryDepartamentosSalarios
    {

        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;

        public RepositoryDepartamentosSalarios()
        {
            string connectionString = HelperConfiguration.GetConnectionString();
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

        public async Task<EmpleadoDeptInfo> GetEmpleadosDepa(string depa)
        {
            string sql = "SP_EMPLEADOS_DEPT_OUT";
            this.com.Parameters.AddWithValue("@nombre", depa);
            SqlParameter pamSuma = new SqlParameter();
            pamSuma.ParameterName = "@suma";
            pamSuma.Value = 0;
            //INDICAMOS LA DIRECCION DEL PARAMETRO 
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
            EmpleadoDeptInfo model = new EmpleadoDeptInfo();
            List<string> apellidos = new List<string>();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                apellidos.Add(apellido);
            }
            await this.reader.CloseAsync();
            //GUARDAMOS LOS DATOS EN  NUESTRO MODEL 
            model.Apellidos = apellidos;
            model.SumaSalarial = int.Parse(pamSuma.Value.ToString());
            model.MediaSalarial = int.Parse(pamMedia.Value.ToString());
            model.Personas = int.Parse(pamPersonas.Value.ToString());

            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
            return model;

        }
    }
}
