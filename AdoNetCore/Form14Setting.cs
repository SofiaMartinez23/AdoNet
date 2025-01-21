using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;

namespace AdoNetCore
{
    public partial class Form14Setting : Form
    {
        public Form14Setting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //EN ESTE ENTORNO NO ES NATIVO POR LO QUE DEBEMOS INDICAR
            //DE FORMA EXPLICITA EL NOMBRE DEL FICHERO Y SU UBICACION
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);

            //EL OBJETO PARA RECUPERAR LAS KEYS
            IConfigurationRoot configuration = builder.Build();

            //EXISTEN CLAVES QUE YA VIENEN POR DEFECTO: ConnectionStrings

            string connectionString = configuration.GetConnectionString("SqlTajamar");
            this.label1.Text = connectionString;

            string imagen1 = configuration.GetSection("Imagenes:imagen1").Value;
            string imagen2 = configuration.GetSection("Imagenes:imagen2").Value;

            string color1 = configuration.GetSection("Colores:fondo").Value;
            string color2 = configuration.GetSection("Colores:letra").Value;


            this.pictureBox1.Load(imagen1);
            this.pictureBox2.Load(imagen2);

            this.button1.BackColor = Color.FromName(color1);
            this.button1.ForeColor = Color.FromName(color2);
        }
    }
}
