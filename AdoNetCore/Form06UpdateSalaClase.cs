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
    public partial class Form06UpdateSalaClase : Form
    {
        RepositorySalas repo;
        public Form06UpdateSalaClase()
        {
            InitializeComponent();
            this.repo = new RepositorySalas();
            this.LoadSalas();
        }

        private async void LoadSalas()
        {
            List<string> salas = await this.repo.GetNombresSalaAsync();
            this.lstSalas.Items.Clear();
            foreach (string nombre in salas)
            {
                this.lstSalas.Items.Add(nombre);
            }
        }

        private async void btnModificarSala_Click(object sender, EventArgs e)
        {
            string oldName = this.lstSalas.SelectedItem.ToString();
            string newName = this.txtSala.Text;

            await this.repo.UpdateNombreSalaAsyn(oldName, newName);
            this.LoadSalas();
        }
    }
}
