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

#region
//CREATE PROCEDURE SP_ALL_HOSPITALES
//AS
//	SELECT * FROM HOSPITAL
//GO

//CREATE PROCEDURE SP_UPDATEPLANTILLA_HOSPITAL
//(@NOMBRE NVARCHAR(50), @INCREMENTO INT)
//AS
//	DECLARE @HOSPITALCOD INT
//	SELECT @HOSPITALCOD = HOSPITAL_COD FROM HOSPITAL
//	WHERE NOMBRE = @NOMBRE

//	UPDATE PLANTILLA SET SALARIO = SALARIO + @INCREMENTO
//	WHERE HOSPITAL_COD = @HOSPITALCOD

//	SELECT * FROM PLANTILLA 
//	WHERE HOSPITAL_COD = @HOSPITALCOD
//GO
#endregion

namespace AdoNetCore
{
    public partial class Form11UpdatePlantillaProcedures : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        public Form11UpdatePlantillaProcedures()
        {
            InitializeComponent();
            string connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;Encrypt=True;Trust Server Certificate=True";
            this.cn = new SqlConnection(connectionString);
            this.com = new SqlCommand();
            this.com.Connection = this.cn;
            this.LoadHospitales();
        }

        public async void LoadHospitales()
        {
            string sql = "SP_ALL_HOSPITALES";
            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();
            this.lstPlantilla.Items.Clear();

            while (await this.reader.ReadAsync())
            {
                string hospital = this.reader["NOMBRE"].ToString();
                this.cmbHospital.Items.Add(hospital);
            }
            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
        }

        private async void btnModificarSalario_Click(object sender, EventArgs e)
        {
            string nombre = this.cmbHospital.SelectedItem.ToString();
            int incremento = int .Parse(this.txtIncremento.Text);
            string sql = "SP_UPDATEPLANTILLA_HOSPITAL";
            this.com.Parameters.AddWithValue("@NOMBRE", nombre);
            this.com.Parameters.AddWithValue("@INCREMENTO", incremento);

            this.com.CommandType = CommandType.StoredProcedure;
            this.com.CommandText = sql;

            await this.cn.OpenAsync();
            this.reader = await this.com.ExecuteReaderAsync();

            this.lstPlantilla.Items.Clear();
            while (await this.reader.ReadAsync())
            {
                string apellido = this.reader["APELLIDO"].ToString();
                string salario = this.reader["SALARIO"].ToString();
                this.lstPlantilla.Items.Add(apellido + " " + salario);
            }

            await this.reader.CloseAsync();
            await this.cn.CloseAsync();
            this.com.Parameters.Clear();
        }
    }
}
