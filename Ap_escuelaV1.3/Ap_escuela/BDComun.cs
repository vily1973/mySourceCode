using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace Ap_escuela
{
   public class BDComun
    {
       public static SqlConnection ObtnerCOnexion()
       {
            string appSettingValue = ConfigurationSettings.AppSettings["SqlPath"];
            SqlConnection Conn = null;

            try
            {
                Conn = new SqlConnection("Data Source=" + appSettingValue + ";Initial Catalog=Escuela;Integrated Security=True");
                Conn.Open();
            }
            catch
            {
                Conn = null;
            }

           return Conn;

       }


    }
}
