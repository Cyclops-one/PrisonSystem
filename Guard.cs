using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prisoner
{
    public partial class Guard : Form
    {
        string ID;
        public Guard()
        {
            InitializeComponent();
            ID = Login.Councelor;
        }

        private void button1_Click(object sender, EventArgs e)//addprisoner
        {
            
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)//update
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            string query = "Update dbo.Prisoners set " + comboBox1.Text + " ='" + textBox2.Text + "' where PrisonerID = '" + textBox3.Text + "'";
            SqlCommand command = new SqlCommand(query, c);
            command.ExecuteNonQuery();
            c.Close();
        }

        private void Guard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)//search
        {
            string choice = null;
            if (radioButton1.Checked)
            {
                choice = "PrisonerID";
            }
            else
            {
                choice = "CounSelor";
                textBox1.Text = ID;
               
            }
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            //Form1 f = new Form1();

            string query = "Select * from Prisoners where " + choice + "='" + textBox1.Text + "'";
            SqlCommand command = new SqlCommand(query, c);
            SqlDataReader reader = command.ExecuteReader();
            List<Criminal> list = new List<Criminal>();
            
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


                list.Add(p);
            }
            c.Close();
            dataGridView1.DataSource = list;
            reader.Close();
            textBox1.Text = null;
        }

        private void Guard_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            this.Hide();
            l.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            string path = @"C: \Users\Satanic\Desktop\Empty\b.txt";
            FileInfo info = new FileInfo(path);
            DateTime lt = info.LastWriteTime;
            label5.Text = lt.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Menu m = new Menu();
          
            m.Show();
            this.Hide();
        }
    }
}
