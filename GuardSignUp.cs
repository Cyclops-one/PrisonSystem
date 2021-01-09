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
        Access a;
        public GuardSignUp()
        {
            InitializeComponent();
            this.a = new Access();
        }

        private void GuardSignUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void Operation()
        {

            a.Execute("INSERT INTO Login(AuthorID,Password)" + "VALUES('" + textBox1.Text + "','" + textBox2.Text + "')");
            a.Cclose();   
           
            
            MessageBox.Show("User created Successfully!");
            Login f = new Login();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
             c.Open();
             string query = "Select * from Guards where GuardID='" + textBox3.Text + "'";
             SqlCommand command = new SqlCommand(query, c);
             SqlDataReader reader = command.ExecuteReader();*/
            SqlDataReader reader = this.a.Receive("Select * from Guards where GuardID='" + textBox3.Text + "'");
            if (!reader.HasRows) 
            {
                MessageBox.Show("Your information as a guard not validate by Admisnstartor");
            }
            else
            {

                //  SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
                // c.Open();

                reader.Close();
                a.Cclose();
                Operation();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /* SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
             c.Open();
             string query = "Select ControlBlock from Guards where GuardID='" + textBox3.Text + "'";
             SqlCommand command = new SqlCommand(query, c);
             SqlDataReader reader = command.ExecuteReader();*/
            SqlDataReader reader = this.a.Receive("Select ControlBlock from Guards where GuardID='" + textBox3.Text + "'");
            while (reader.Read()) {
                block= reader["ControlBlock"].ToString();
                MessageBox.Show(block);
                    }
            reader.Close();
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
