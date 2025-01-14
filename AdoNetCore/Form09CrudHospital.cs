using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form09CrudHospital : Form
    {
        RepositoryHospitales repo;

        public Form09CrudHospital()
        {
            InitializeComponent();
            this.repo = new RepositoryHospitales();
        }

        private async void LoadHospitales()
        {
            List<string> hospitales = await this.repo.GetHospitalesAsync();
            foreach (string hospital in hospitales)
            {
                this.lstHospitales.Items.Add(hospital);
            } 
        }

        private async void btnInsertar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            this.repo.InsertarHospitales(id, nombre, direccion, telefono, camas);
            this.LoadHospitales();
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            string nombre = this.txtNombre.Text;
            string direccion = this.txtDireccion.Text;
            string telefono = this.txtTelefono.Text;
            int camas = int.Parse(this.txtCamas.Text);
            this.repo.InsertarHospitales(id, nombre, direccion, telefono, camas);
            this.LoadHospitales();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.txtId.Text);
            await this.repo.EliminarHospitalAsync(id);
            this.LoadHospitales();
        }
    }
}
