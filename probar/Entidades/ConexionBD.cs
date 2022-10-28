using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace probar
{
    public class ConexionBD
    {
        string cadenaConexion = System.Configuration.ConfigurationManager.AppSettings["CadenaBD"];
        SqlCommand cmd = new SqlCommand();
        SqlConnection cn = new SqlConnection();

        
        private void Conectar()
        {
            cn.ConnectionString = cadenaConexion;
            cn.Open();


            cmd.Connection = cn;

            cmd.CommandType = CommandType.Text;
        }

        private void Desconectar()
        {
            cn.Close();
        }



    
    }
}
