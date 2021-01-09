using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisoner
{
    class Grd
    {
        Access sa;
        
        public Grd()
        {
            this.sa = new Access();
        }
        public string Name { get; set; }
        public int GuardID { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string InService { get; set; }
        public string EndService { get; set; }
        public string Address { get; set; }
        public string ControlBlock { get; set; }
        public string Counselor { get; set; }
        public List<Grd> Allgrd(string sql)
        {

            SqlDataReader reader = this.sa.Receive(sql);
            List<Grd> gards = new List<Grd>();
           
            while (reader.Read())
            {
                Grd p = new Grd();
                p.Name = reader["Name"].ToString();
                p.GuardID = (int)reader["GuardID"];
                p.Gender = reader["Gender"].ToString();
                p.BloodGroup = reader["BloodGroup"].ToString();
                p.InService = reader["InService"].ToString();
                p.EndService = reader["EndService"].ToString();
                p.Address = reader["Address"].ToString();
                p.ControlBlock = reader["ControlBlock"].ToString();
                p.Counselor = reader["Counselor"].ToString();
                gards.Add(p);
            }
            reader.Close();
            return gards;

        }
        public List<string> Entities()
        {
            SqlDataReader reader = this.sa.Receive("Select * from Guards");
            List<string> Cols = new List<string>();
            while (reader.Read())
            {
                Grd p = new Grd();
               
                Cols.Add(p.Counselor=reader["Counselor"].ToString());
            }
            reader.Close();
            return Cols;
            
        }
      
        public List<string> ColNames()
        {
            return Entities();
        }
        public List<Grd> Grdlist()
        {
            return Allgrd("Select * from Guards");
            
        }
        public List<Grd> Grdlistbyid()
        {
            return Allgrd("Select * from Guards where GuardID='"+ AdminPanel.Gid + "'");
            
        }
    }
}
