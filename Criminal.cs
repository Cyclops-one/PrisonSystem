using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prisoner
{
    class Criminal
    {
        Access ac;
        string S = AdManagePrisoner.Cell;
        string I = AdManagePrisoner.Id;
        //String Iden = Guard.strr;
        string Cou = Login.Councelor;
        string Cid = AdminPanel.Pid;
        public Criminal()
        {
            this.ac = new Access();
        }
        
        //String s = "textBox3.Text";
        public string Name { get; set; }
        public int PrisonerID { get; set; }
        public string Gender { get; set; }
        public string DateofBirth { get; set; }
        public string CrimeDescription { get; set; }
        public string Punishment { get; set; }
        public string CellNo { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string Counselor { get; set; }

        public string[] thread = { "802B73C8658l4", "502B73C847C5" };
      


       
        public List<Criminal> Listbyidg()
        {

            return Criminals("Select * from Prisoners where PrisonerID ='" + Guard.strr + "'");
        }
        public List<Criminal> Listbyid()
          {

              return Criminals("Select * from Prisoners where PrisonerID ='" + I + "'");
          }
        public List<Criminal> Listbyida()
        {

            return Criminals("Select * from Prisoners where PrisonerID ='" + Cid + "'");
        }
        public List<Criminal> Listbycell()
          {

              return Criminals("Select * from Prisoners where CellNo='" + S + "'");
          }
        public List<Criminal> Listbycounselor()
        {

            return Criminals("Select * from Prisoners where Counselor='" + Cou + "'");
        }
        public List<Criminal> Criminals(string sql)
        {
           // string sql ="Select * from Prisoners";

            SqlDataReader reader = this.ac.Receive(sql);
            List<Criminal> Boga = new List<Criminal>();
            
            while (reader.Read())
            {
                Criminal p = new Criminal();
                p.Name = reader["Name"].ToString();
                p.PrisonerID = (int)reader["PrisonerID"];
                p.Gender = reader["Gender"].ToString();
                p.DateofBirth = reader["DateofBirth"].ToString();
                p.CrimeDescription = reader["CrimeDescription"].ToString();
                p.Punishment = reader["Punishment"].ToString();
                p.CellNo = reader["CellNo"].ToString();
                p.BloodGroup = reader["BloodGroup"].ToString();
                p.Address = reader["Address"].ToString();
                p.Counselor = reader["Counselor"].ToString();
                Boga.Add(p);

            }

            reader.Close();

            return Boga;
            
        }
        public List<Criminal> Alllist()
        {

            return Criminals("Select * from Prisoners");
        }
    }


}
