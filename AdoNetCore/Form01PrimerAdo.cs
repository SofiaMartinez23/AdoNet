using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AdoNetCore
{
    public partial class Form01PrimerAdo : Form
    {
        SqlConnection cn;
        SqlCommand com;
        SqlDataReader reader;
        string connectionString;

        public Form01PrimerAdo()
        {
            InitializeComponent();
            this.connectionString = @"Data Source=LOCALHOST\SQLEXPRESS01;Initial Catalog=HOSPITAL;Persist Security Info=True;User ID=sa;";
            this.cn = new SqlConnection(this.connectionString);
            this.com = new SqlCommand();
            this.cn.StateChange += Cn_StateChange;
        }

        private void Cn_StateChange(object sender, StateChangeEventArgs e)
        {
            this.lblMensaje.Text = "La conexion esta pasando de "
                + e.OriginalState + "a" + e.CurrentState; 
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try {

                if (this.cn.State == ConnectionState.Closed)
                {
                    this.cn.Open();
                }
                this.lblMensaje.BackColor = Color.LightBlue;
            }catch (SqlException ex)
            {
                this.lblMensaje.Text = ex.ToString();
            }

        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            this.cn.Close();
            this.lblMensaje.BackColor = Color.LightCoral;
        }

        private void btnLeerDatos_Click(object sender, EventArgs e)
        {
            //Consulta a realizar
            string sql = "SELECT * FROM EMP";
            //Consiguramos nuestro command
            //indicamos la conexion del command
            this.com.Connection = this.cn;
            //Tipo de consulta a realizar
            this.com.CommandType = CommandType.Text;
            //La propia consulta 
            this.com.CommandText = sql;
            //Aqui deberiamos abrir la conexion
            //Es una consulta de seleccion por lo que debemos
            //usar el metodo ExecuteReader() que nos devuelve
            //un DataReader
            this.reader = this.com.ExecuteReader();
            //Ya podemos leer los datos
            //leemos la priora columna
            /*string columna = this.reader.GetName(0);
            string tipoDato = this.reader.GetDataTypeName(0);
            this.lstColumnas.Items.Add(columna);
            this.lstTipoDato.Items.Add(tipoDato);*/


            //Leemos la primero columna
            for (int i = 0; i < this.reader.FieldCount; i++)
            {
                string columna = this.reader.GetName(i);
                string tipoDato = this.reader.GetDataTypeName(0);
                this.lstColumnas.Items.Add(columna);
                this.lstTipoDato.Items.Add(tipoDato);
            }
            //Leemos el primer registro
            //par aleer datos debemos utlizar el metodo Read()
            //Del lector
            while(this.reader.Read()){

                this.reader.Read();
                string apellido = this.reader["APELLIDO"].ToString();
                this.lstApellidos.Items.Add(apellido);
            }
            //Siempre debemos cerrar todo para poder reutilizarlo
            this.reader.Close();
        }
    }
}
