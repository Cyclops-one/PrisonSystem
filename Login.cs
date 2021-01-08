using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prisoner
{
    public partial class Login : Form
    {
        public static string Councelor;
        public string mac;
        Access a = new Access();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*  Criminal i = new Criminal();
              if (i.thread.Contains(mac))
              {*/
            SqlConnection c = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            c.Open();
            string query = "Select * from Login where AuthorID='" + textBox1.Text + "'and Password='" + textBox2.Text + "'";
            SqlCommand command = new SqlCommand(query, c);
            SqlDataReader reader = command.ExecuteReader();
           /* a.Connection();
            a.Execute("Select * from Login where AuthorID='" + textBox1.Text + "'and Password='" + textBox2.Text + "'");*/
            
                if (!reader.HasRows)
                {


                    MessageBox.Show("Incorrect Credentials");

                }
                else
                {

                    MessageBox.Show("Login successfull");
                    if (textBox1.Text == "Supervisor")
                    {
                    string path = @"C: \Users\Satanic\Desktop\Empty\S.txt";
                    FileInfo info = new FileInfo(path);
                    DateTime lt = info.LastWriteTime;
                    MessageBox.Show("Last Signed in"+lt.ToString());

                    this.Hide();

                        AdminPanel ad = new AdminPanel();
                        ad.Show();
                    }
                    else
                    {
                    string path = @"C: \Users\Satanic\Desktop\Empty\" + textBox1.Text + ".txt";
                    FileInfo info = new FileInfo(path);
                    DateTime lt = info.LastWriteTime;
                    //DateTime lt=info.Lastc
                    Thread.Sleep(2000);
                    MessageBox.Show("Last logged in" + lt.ToString());
                    
                    Councelor = textBox1.Text;
                        Guard g = new Guard();
                        this.Hide();
                        g.Show();
                    }




                    reader.Close();
                    c.Close();

                }


                /*{
                    MessageBox.Show("Database Mismatch Exception");
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
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminPanel ap = new AdminPanel();
            ap.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GuardSignUp gs = new GuardSignUp();
            gs.Show();
            this.Hide();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AdManagePrisoner adm = new AdManagePrisoner();
            
            adm.Show();
            this.Hide();


        }
    }
}
     

