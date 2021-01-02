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
    public partial class GuardSignUp : Form
    {
        public string block;
        public GuardSignUp()
        {
            InitializeComponent();
        }

        private void GuardSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        public void Operation()
        {
            SqlConnection co = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            co.Open();
            
                string que = "INSERT INTO Login(AuthorID,Password)" + "VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
            SqlCommand com = new SqlCommand(que, co);
            com.ExecuteNonQuery();
            //  com.Cancel();
           
            co.Close();

            MessageBox.Show("User created Successfully!");
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            string query = "Select * from Guards where GuardID='" + textBox3.Text + "'";
            SqlCommand command = new SqlCommand(query, c);
            SqlDataReader reader = command.ExecuteReader();
            if (!reader.HasRows) 
            {
                MessageBox.Show("Your information as a guard not validate by Admisnstartor");
            }
            else
            {

                //  SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
                // c.Open();

                reader.Close();
                c.Close();
                Operation();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            string query = "Select ControlBlock from Guards where GuardID='" + textBox3.Text + "'";
            SqlCommand command = new SqlCommand(query, c);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) {
                block= reader["ControlBlock"].ToString();
                MessageBox.Show(block);
                    }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void GuardSignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
