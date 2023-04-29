using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PruebaDesarrollo
{
    internal class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("SERVER=LAPTOP-08L1HOUG\\SQLEXPRESS;DATABASE=DBSYC;integrated security=true;");
            cn.Open();
            return cn;
        }
    }
}
