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


#region
//create procedure SP_EMPLEADOS_DEPT_OUT
//(@nombre nvarchar(50), @suma int out, @media int out, @personas int out)
//as
//	declare @id int
//	select @id = DEPT_NO from DEPT
//	where DNOMBRE = @nombre
//	select * from EMP where DEPT_NO = @id
//	select @suma = SUM(SALARIO), @media = AVG(SALARIO),
//    @personas = COUNT(EMP_NO) from EMP
//	where DEPT_NO = @id
//go
#endregion

namespace AdoNetCore
{
    public partial class Form13ParametrosSalida : Form
    {
        RepositoryDepartamentosSalarios repo;

        public Form13ParametrosSalida()
        {
            InitializeComponent();
            this.repo = new RepositoryDepartamentosSalarios();
        }

        public async Task LoadDepartamentos()
        {
            List<Departamento> departamentos = await this.repo.GetDepartamentosAsync();
            foreach (Departamento dept in departamentos)
            {
                this.cmbDepartamentos.Items.Add(dept.Nombre);
            }
        }

        private async void btnMostrarDatos_Click(object sender, EventArgs e)
        {
            string depa = this.cmbDepartamentos.Text;
            EmpleadoDeptInfo info = await this.repo.GetEmpleadosDepa(depa);

            this.lstEmpleados.Items.Clear();
            foreach (var empleado in info.Empleados)
            {
                this.lstEmpleados.Items.Add(empleado);
            }
            this.txtSumaSalarial.Text = info.SumaSalarial.ToString();
            this.txtMediaSalarial.Text = info.MediaSalarial.ToString();
            this.txtPersona.Text = info.Personas.ToString();
        }
    }
}