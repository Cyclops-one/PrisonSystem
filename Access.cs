using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisoner
{
    class Access
    {
      
        SqlConnection con;
        SqlCommand com;
        

        public  Access()
        {

            this.con = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            con.Open();
        }
        public SqlDataReader Receive(string sql)
        {
            this.com = new SqlCommand(sql, this.con);
            SqlDataReader reader = this.com.ExecuteReader();
            // this.con.Close();
            return reader;
            //reader.Close();
        }
        public void Execute(string q)
        {
            this.con.Open();
            this.com = new SqlCommand(q, this.con);
            this.com.ExecuteNonQuery();
            //this.con.Close();
        }
        
        
       

        public void Cclose()
        {
            this.con.Close();
        }






        }
        

    }

