using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prisoner
{
    public partial class Outform : Form
    {
        public Outform()
        {
            InitializeComponent();
        }

        

        private void Outform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void Outform_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            string query;         
            con.Open();
            query = "Select * from Prisoners";

            SqlCommand command = new SqlCommand(query, con);

            //ad.SelectCommand = new SqlCommand(query, con);
            SqlDataReader reader=command.ExecuteReader();
            //dataGridView1.DataSource = reader;
            
            List<Criminal> list = new List<Criminal>();
            while (reader.Read())
            {
                Criminal c = new Criminal();
                c.Name = reader["Name"].ToString();
                c.PrisonerID = (int)reader["PrisonerID"];
                c.Gender = reader["Gender"].ToString();
                c.DateofBirth = reader["DateofBirth"].ToString();
                c.CrimeDescription = reader["CrimeDescription"].ToString();
                c.Punishment = reader["Punishment"].ToString();
                c.CellNo = reader["CellNo"].ToString();
                c.BloodGroup = reader["BloodGroup"].ToString();
                c.Address = reader["Address"].ToString();
                c.Counselor = reader["Counselor"].ToString();
                list.Add(c);
            }
            con.Close();
            dataGridView1.DataSource = list;
            reader.Close();

        }
    }
}
