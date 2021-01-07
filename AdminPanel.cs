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
using System.Threading;

namespace Prisoner
{
    public partial class AdminPanel : Form
    {

        Grd g = new Grd();
        Access a;
        public AdminPanel()
        {
            InitializeComponent();

            this.a = new Access();

        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = g.Grdlist();
            a.Cclose();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            AdManagePrisoner adm = new AdManagePrisoner();
            this.Hide();
            adm.Show();
        }
      

        private void button1_Click(object sender, EventArgs e)//showall
        {
          /*  SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            string query = "Select * from Guards"; 
            SqlCommand command = new SqlCommand(query, c);
            SqlDataReader reader = command.ExecuteReader();
            List<Grd> list = new List<Grd>();
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
                list.Add(p);
            }
            dataGridView1.DataSource = list;
            reader.Close();
            c.Close();*/

            
            
        }

        private void button4_Click(object sender, EventArgs e)//guard add
        {
            string path = @"C: \Users\Satanic\Desktop\Empty\a.txt";
            FileInfo info = new FileInfo(path);
            DateTime lt = info.LastWriteTime;
            Thread.Sleep(2000);
            MessageBox.Show("Last Added----"+lt.ToString()+"");
            Thread.Sleep(1000);
            AddGuard ag = new AddGuard();
            ag.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)//delete Guard
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            connection.Open();
            string q = "Delete  from Guards where GuardID='" + textBox1.Text + "' ";
            SqlCommand command = new SqlCommand(q, connection);
            command.ExecuteNonQuery();
            connection.Close();

        }

        private void button6_Click(object sender, EventArgs e)//update
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            string query = "Update dbo.Guards set " + comboBox1.Text + " ='" + textBox3.Text + "' where GuardID = '" + textBox2.Text + "'";
            SqlCommand command = new SqlCommand(query, c);
            command.ExecuteNonQuery();
            c.Close();
        }

        private void button3_Click(object sender, EventArgs e)//search
        {
            
            //string choice = null;
            if (radioButton1.Checked)
            {
                //choice = "Prisoners";
                if (textBox4.Text == null)
                {
                    
                    SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
                    c.Open();
                    //Form1 f = new Form1();

                    string query = "Select * from Prisoners";
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
                        p.CellNo = reader["CellNo"].ToString();
                        p.BloodGroup = reader["BloodGroup"].ToString();
                        p.Address = reader["Address"].ToString();
                        p.Counselor = reader["Counselor"].ToString();


                        list.Add(p);
                    }
                    c.Close();
                    dataGridView1.DataSource = list;
                    reader.Close();
                    textBox4.Text = null;
                }
                else
                {
                    SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
                    c.Open();
                    //Form1 f = new Form1();

                    string query = "Select * from Prisoners where PrisonerID ='" + textBox4.Text + "'";
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
                        p.CellNo = reader["CellNo"].ToString();
                        p.BloodGroup = reader["BloodGroup"].ToString();
                        p.Address = reader["Address"].ToString();
                        p.Counselor = reader["Counselor"].ToString();


                        list.Add(p);
                    }
                    c.Close();
                    dataGridView1.DataSource = list;
                    reader.Close();
                    textBox4.Text = null;
                }
            }
            else
            {
                //choice = "Guards";
                if (textBox4.Text ==null)
                {
                    button1_Click(sender,e);
                }
                else
                {
                   
                }
            }













           


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }
    }
}
