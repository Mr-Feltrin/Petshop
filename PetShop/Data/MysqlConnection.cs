using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PetShop.Data
{
    public class MysqlConnection
    {
        private string ConnectionString = Properties.Settings.Default.db_caopanheiroConnectionString;

        public MysqlConnection()
        {
        }

        public void Query(string CommandText)
        {

        }       
    }
}
