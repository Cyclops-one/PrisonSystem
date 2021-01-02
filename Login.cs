using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prisoner
{
    public partial class Login : Form
    {
        public static string Councelor;
        public string mac;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* Criminal i = new Criminal();
            if (i.thread.Contains(mac))
            {*/
                SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
                c.Open();
                string query = "Select * from Login where AuthorID='" + textBox1.Text + "'and Password='" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(query, c);
                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows)
                {


                    MessageBox.Show("Incorrect Credentials");

                }
                else
                {

                    MessageBox.Show("Login successfull");
                    if (textBox1.Text == "Supervisor")
                    {
                        this.Hide();
                        AdminPanel ad = new AdminPanel();
                        ad.Show();
                    }
                    else
                    {
                    Councelor = textBox1.Text;
                        Guard g = new Guard();
                        this.Hide();
                        g.Show();
                    }




                    reader.Close();
                    c.Close();

                }
            
            /*else
            {
                MessageBox.Show("My nigger you didn't pay for it");
            }*/
        }

        private void Login_Load(object sender, EventArgs e)
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    mac = nic.GetPhysicalAddress().ToString();
                    MessageBox.Show(mac);

                    break;
                }
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guard g = new Guard();
             g.Show();
           
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }
    }
}
     

