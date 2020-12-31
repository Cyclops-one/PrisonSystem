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
    public partial class Guard : Form
    {
        public Guard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)//addprisoner
        {
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)//update
        {

        }

        private void Guard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)//search
        {

            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            //Form1 f = new Form1();

            string query = "Select * from Prisoners where PrisonerID='" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(query, c);
            SqlDataReader reader = command.ExecuteReader();
            List<Criminal> list = new List<Criminal>();
            while (reader.Read())
            {
                Criminal p = new Criminal();
                p.Name = reader["Name"].ToString();
               // p.PrisonerID = reader["PrisonerID"].ToString();
                p.Gender = reader["Gender"].ToString();
                p.DateofBirth = reader["DateofBirth"].ToString();
                p.CrimeDescription = reader["CrimeDescription"].ToString();
                p.CellNo = reader["CellNo"].ToString();
                p.BloodGroup = reader["BloodGroup"].ToString();
                p.Address = reader["Address"].ToString();
                p.Counselor = reader["Counselor"].ToString();
                

                list.Add(p);
            }
            c.Close();
            dataGridView1.DataSource = list;
            reader.Close();
        }
    }
}
