using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DndSheet
{
    internal class Connection
    {
        SqlConnection conn;

        public SqlConnection GetCon()
        {
            conn = new SqlConnection("Data Source=DESKTOP-6G15945\\SQLEXPRESS01;Initial Catalog=myDb;Integrated Security=True");
            return conn;
        }
    }
}
