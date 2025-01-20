namespace AdoNetCore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form13ParametrosSalida());
            //Application.Run(new Form12MensajesServidor());
            //Application.Run(new Form11UpdatePlantillaProcedures());
            //Application.Run(new Form10UpdateEmpleadosOficio());
            //Application.Run(new Form09CrudHospital());
            //Application.Run(new Form08CrudDepartamentos());
            //Application.Run(new Form07DepartamentosEmpleados());
            //Application.Run(new Form06UpdateSalaClase());
            //Application.Run(new Form05UpdateSalas());
            //Application.Run(new Form04EliminarPlantilla());
            //Application.Run(new Form03EliminarEnfermos());
            //Application.Run(new Form02BuscadorEmpleados());
            //Application.Run(new Form01PrimerAdo());
        }
    }
}