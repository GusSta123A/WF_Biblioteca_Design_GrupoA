using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_GurpoA.Modelo
{
    internal class DBOContext
    {
        public static DBOContext singleton = new DBOContext();
        public DBOContext()
        {

        }

        public DB_CustomerTestDBEntities ObtenerConexion()
        {
            return new DB_CustomerTestDBEntities();
        }
    }
}
