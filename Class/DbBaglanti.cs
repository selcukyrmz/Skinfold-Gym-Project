using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skinfold_Gym_Project
{
    public class DbBaglanti
    {
        public MySqlConnection baglanti()
        {
            MySqlConnection conn = new MySqlConnection(
            "Server=localhost;Port=3306;Database=selcuksql;Uid=root;Pwd=;");

            return conn;
        }
    }
}
