using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ukk_oop2
{
    class connection
    {
        public static MySqlConnection getConnection()
        {
            MySqlConnection koneksi = null;
            try
            {
                string sConnstring = "server = localhost;database= zeamart;uid=root;password=;";
                koneksi = new MySqlConnection(sConnstring);
            }
            catch (MySqlException sqlex)
            {
                throw new Exception(sqlex.Message.ToString());
            }
            return koneksi;
        }
    }
}
