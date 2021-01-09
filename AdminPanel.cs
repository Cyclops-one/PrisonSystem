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
        Criminal c = new Criminal();
       public static string Pid;
        public static string Gid;
        public AdminPanel()
        {
            InitializeComponent();

            this.a = new Access();
           
            string fileName = @"C: \Users\Satanic\Desktop\Empty\S.text";
            if (File.Exists(fileName))
            {
                //File.Delete(fileName);
                string path = @"C: \Users\Satanic\Desktop\Empty\S.txt";
                FileInfo info = new FileInfo(path);
                string text = "ser";
                File.WriteAllText(path, text);
            }
            else
            {
                File.Create(fileName);
                string pat = @"C: \Users\Satanic\Desktop\Empty\S.txt";
                FileInfo info = new FileInfo(pat);
                string text = "ser";
                File.WriteAllText(pat, text);
            }

        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AdminPanel_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = g.Grdlist();
            comboBox2.DataSource = g.ColNames();
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

            AdminPanel_Load(sender,e);
            
            
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
           
            
            a.Execute("Delete  from Guards where GuardID='" + textBox1.Text + "' ");
            a.Cclose();
        }

        private void button6_Click(object sender, EventArgs e)//update
        {
            
            a.Execute("Update dbo.Guards set " + comboBox1.Text + " ='" + textBox3.Text + "' where GuardID = '" + textBox2.Text + "'");
            a.Cclose();
        }

        private void button3_Click(object sender, EventArgs e)//search
        {
            
           
            if (radioButton1.Checked)

            { 
                    Pid = textBox4.Text;
                    dataGridView2.DataSource = c.Listbyida();
                    a.Cclose();
                textBox4.Text = null;
                radioButton1.Checked = false;
                }
                
                
            
            else if(radioButton2.Checked)
            
              
                {
                    
                    Gid = textBox4.Text;
                   dataGridView2.DataSource= g.Grdlistbyid();
                    a.Cclose();
                textBox4.Text = null;
                radioButton2.Checked = false;
            }
               

               
            
            else
            {
                dataGridView2.DataSource = g.Grdlist();
                a.Cclose();
                
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

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = g.Grdlist();
        }
    }
}
