using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUSL2019_Information_Management_and_Retrieval_
{
    class DBConnect
    {
        private string con;
        public string myConnection()
        {
            con = @"Data Source=Navodya_Theshan\SQLEXPRESS;Initial Catalog=DBsuperMarketPOS;Integrated Security=True;";
            return con;
        }
    }
}
