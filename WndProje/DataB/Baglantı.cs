using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WndProje.DataB
{
     public class Baglantı
    {
        public static SqlConnection GetirBaglantı()
        {
            
            return new SqlConnection(ConfigurationManager.ConnectionStrings["BankaKayıtConnStr"].ConnectionString);
            
        }
    }
}
