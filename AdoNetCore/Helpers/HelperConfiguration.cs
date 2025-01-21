using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace AdoNetCore.Helpers
{
    public class HelperConfiguration
    {
        public static string GetConnectionString()
        {
            ConfigurationBuilder builder = new ConfigurationBuilder();
            //EN ESTE ENTORNO NO ES NATIVO POR LO QUE DEBEMOS INDICAR
            //DE FORMA EXPLICITA EL NOMBRE DEL FICHERO Y SU UBICACION
            builder.SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", false, true);

            //EL OBJETO PARA RECUPERAR LAS KEYS
            IConfigurationRoot configuration = builder.Build();

            //EXISTEN CLAVES QUE YA VIENEN POR DEFECTO: ConnectionStrings

            string connectionString = configuration.GetConnectionString("SqlTajamar");
            return connectionString;
        }
    }
}
