using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurso
{
    public class classConectar : classVariables
    {
        // Objeto SqlConnection
        public SqlConnection conexion;

        // Constructor
        public classConectar()
        {
            // Crear la conexión usando el connectionString
            conexion = new SqlConnection(connectionString);
            // Abrir la conexión
            conexion.Open();
        }

        // Destructor
       
    }
}
