using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace bodega_cristo_pobre
{
    class Varpublic
    {
        public static SqlConnection cadconex = new SqlConnection("Data Source = 192.168.1.36,1433; Network Library = DBMSSOCN; Initial Catalog = BDTienditaCP; User ID = Eduardo; Password=949401534eduar;");
    }
}
