using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurso
{
    public class classFunciones : classConectar
    {
        // Objeto DataTable para almacenar los datos
        public DataTable datos;

        // Método ConsultarRegistro
        public void ConsultarRegistro()
        {
            Form1 form = new Form1();
            // Pedir al usuario que ingrese el id del registro a buscar
            int id;
            // Intentar convertir el texto del control textBox a entero
            bool exito = int.TryParse(form.textBox.Text, out id);
            // Verificar si la conversión se realizó correctamente
            if (exito)
            {
                
            }
            else
            {
                // Mostrar un mensaje de error al usuario
             }

            // Crear el comando usando el sqlCommand y el id
            SqlCommand comando = new SqlCommand(sqlCommand, conexion);
            comando.Parameters.AddWithValue("@id", id);

            // Crear el lector de datos usando el comando
            SqlDataReader lector = comando.ExecuteReader();

            // Crear el objeto DataTable
            datos = new DataTable();

            // Llenar el DataTable con los datos del lector
            datos.Load(lector);

            // Cerrar el lector
            lector.Close();
        }
    }
}
