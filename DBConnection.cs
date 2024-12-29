using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSL2019_Information_Management_and_Retrieval_
{
    internal class DBConnection
    {

        SqlConnection cn = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        private string con;
        public string myConnection()
        {
            con = @"";
            return con;
        }

        public DataTable GetTable(string qury)
        {
            cn.ConnectionString = myConnection();
            cm = new SqlCommand(qury,cn);
            SqlDataAdapter adapter = new SqlDataAdapter(cm);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
