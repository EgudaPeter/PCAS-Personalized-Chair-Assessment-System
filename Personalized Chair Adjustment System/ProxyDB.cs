using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalized_Chair_Adjustment_System
{
    class ProxyDB
    {
        public static DataTable execQuery(string query, params SqlParameter[] sqlparams)
        {
            SqlCommand cmd = new SqlCommand(query, new SqlConnection(Settings.connectionText));
            foreach (SqlParameter param in sqlparams)
            {
                cmd.Parameters.Add(param);
            }
            DataTable Table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(Table);
            return Table;
        }
    }
}
