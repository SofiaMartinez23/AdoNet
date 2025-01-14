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
    public partial class Form07DepartamentosEmpleados : Form
    {

        RepositoryDepartamentosEmpleados repo;
        public Form07DepartamentosEmpleados()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosEmpleados();
            this.LoadDepartamentos();
            this.LoadEmpleados();
        }

        private async void LoadDepartamentos()
        {
            List<string> departamentos = await this.repo.GetDepartamentosAsync();
            foreach(string nombre in departamentos)
            {
                this.lstDepartamentos.Items.Add(nombre);
            }
        }
        private async void LoadEmpleados()
        {
            List<string> empleados = await this.repo.GetEmpleadosAsync();
            foreach(string nombre in empleados)
            {
                this.lstEmpleados.Items.Add(nombre);
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            string nombre = this.lstEmpleados.SelectedItem.ToString(); 
            await this.repo.EliminarNombreEmpleado(nombre);

            this.lstEmpleados.Items.Clear();
            this.LoadEmpleados();

            MessageBox.Show("Empleado eliminados: " + nombre);
        }
    }
}
