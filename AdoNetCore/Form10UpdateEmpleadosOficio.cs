using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdoNetCore.Models;
using AdoNetCore.Repositories;

namespace AdoNetCore
{
    public partial class Form10UpdateEmpleadosOficio : Form
    {
        RepositoryUpdateEmpleados repo;
        public Form10UpdateEmpleadosOficio()
        {
            InitializeComponent();
            this.repo = new RepositoryUpdateEmpleados();
            this.LoadOficios();
        }

        private async Task LoadOficios()
        {
            List<string> oficios = await this.repo.GetOficiosAsync();
            this.lstOficios.Items.Clear();
            foreach (string ofi in oficios)
            {
                this.lstOficios.Items.Add(ofi);
            }
        }

        private async Task LoadEmpleados(string oficio)
        {
            // Obtener la lista de empleados para el oficio seleccionado
            List<string> empleados = await this.repo.GetEmpleadosOficiosAsync(oficio);
            this.lstEmpleados.Items.Clear();
            foreach (string ape in empleados)
            {
                this.lstEmpleados.Items.Add(ape);
            }
        }


        private async void btnIncrementoSalario_Click(object sender, EventArgs e)
        {
            int incremento = int.Parse(this.txtIncremento.Text);
            string oldOficio = this.lstOficios.SelectedItem.ToString();
            string newOficio = this.txtOficio.Text;

            int modificados = await this.repo.UpdateSalarioEmpleadosOficio(oldOficio, incremento, newOficio);

            MessageBox.Show("Salarios modificados " + modificados);
            await this.LoadOficios();

            DatosEmpleadosOficio datos = await this.repo.GetSalariosOficioAsync(oldOficio);
            this.lblSumaSalarial.Text = "Suma " + datos.SumaSalarial;
            this.lblMediaSalarial.Text = "Media " + datos.MediaSalarial;
            this.lblMaximoSalario.Text = "Maximo " + datos.MaximoSalarial;
        }

        private async void lstOficios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lstOficios.SelectedIndex != -1)
            {
                string oficio = this.lstOficios.SelectedItem.ToString();

                DatosEmpleadosOficio datos = await this.repo.GetSalariosOficioAsync(oficio);
                this.lblSumaSalarial.Text = "Suma " + datos.SumaSalarial;
                this.lblMediaSalarial.Text = "Media " + datos.MediaSalarial;
                this.lblMaximoSalario.Text = "Maximo " + datos.MaximoSalarial;

                await this.LoadEmpleados(oficio);

            }
        }



    }
}
