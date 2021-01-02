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
    public partial class AdManagePrisoner : Form
    {
        public AdManagePrisoner()
        {
            InitializeComponent();
        }

        private void AdManagePrisoner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//ADD
        {
            Supad S = new Supad();
            S.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//DELETE
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            connection.Open();
            string q = "Delete  from Prisoners where PrisonerID='" + textBox4.Text + "' ";
            SqlCommand command = new SqlCommand(q, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)//update
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            string query = "Update dbo.Prisoners set " + comboBox1.Text + " ='" + textBox1.Text + "' where PrisonerID = '" + textBox2.Text + "'";
            SqlCommand command = new SqlCommand(query, c);
            command.ExecuteNonQuery();
            c.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
                c.Open();
                //Form1 f = new Form1();

                string query = "Select * from Prisoners where PrisonerID ='" + textBox3.Text + "'";
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
                textBox3.Text = null;
            }
            else if (radioButton2.Checked)
            {
                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
                c.Open();
                //Form1 f = new Form1();

                string query = "Select * from Prisoners where CellNo='" + comboBox2.Text + "'";
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
                //textBox1.Text = null;
            }
            else
            {
                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
                c.Open();
                //Form1 f = new Form1();

                string query = "Select * from Prisoners ";
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
                //textBox1.Text = null;
            }
        }
    }
}
