using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recurso
{
    public class classVariables
    {
        public static string connectionString = "Data Source=DESKTOP-LQ8QGJ1\\SQLEXPRESS; Initial Catalog=PRUEBASQ;integrated Security=True";

        public string sqlCommand = "SELECT * FROM empleados WHERE id = @id";
        public int id;
    }


}
