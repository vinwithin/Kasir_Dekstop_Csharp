using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Kasir
{
    internal class KoneksiDB
    {
        public MySqlConnection GetConn()
        {
            MySqlConnection Conn = new MySqlConnection();
            Conn.ConnectionString = "server=localhost;port=8888;database=db_kasir;uid=root;pwd=\"\";";
            return Conn;
        }
    }
}
