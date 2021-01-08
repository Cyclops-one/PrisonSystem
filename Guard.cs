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
        Access a;
        public static String strr;
        Criminal cri = new Criminal();
        public Guard()
        {
            InitializeComponent();
            ID = Login.Councelor;
            this.a = new Access();
            string fileName = @"C: \Users\Satanic\Desktop\Empty\" + ID + ".text";
            if (File.Exists(fileName))
            {
                //File.Delete(fileName);
                string path = @"C: \Users\Satanic\Desktop\Empty\" + ID + ".txt";
                FileInfo info = new FileInfo(path);
                string text = "ser";
                File.WriteAllText(path, text);
            }
            else
            {
                File.Create(fileName);
                string pat = @"C: \Users\Satanic\Desktop\Empty\" + ID + ".txt";
                FileInfo info = new FileInfo(pat);
                string text = "ser";
                File.WriteAllText(pat, text);
            }
        }

        private void button1_Click(object sender, EventArgs e)//addprisoner
        {
            
            this.Hide();
            Form1 f = new Form1();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)//update
        {
            
            a.Execute("Update dbo.Prisoners set " + comboBox1.Text + " ='" + textBox2.Text + "' where PrisonerID = '" + textBox3.Text + "'");
            a.Cclose();
        }

        private void Guard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)//search
        {
            //string choice = null;
            if (radioButton1.Checked)
            {
                // choice = "PrisonerID";
                strr = txtbox.Text;

                dataGridView1.DataSource = cri.Listbyidg();
                a.Cclose();

            }
            else
            {
                txtbox.Text = null;
                dataGridView1.DataSource = cri.Listbycounselor();
                a.Cclose();
            }
           

        }

        private void Guard_Load(object sender, EventArgs e)
        {
            /* Criminal cr = new Criminal();

             dataGridView1.DataSource = cr.Alllist();
             a.Cclose();*/
            


           

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

       
    }
}
