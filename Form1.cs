using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Prisoner
{
    public partial class Form1 : Form
    {
       public static string Counselor;
        public Form1()
        {
            InitializeComponent();
            string Counselor = Login.Councelor;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            Access a = new Access();
            string gen = null;
            if (txtmale.Checked)
            {
                gen = txtmale.Text;
            }
            else
            {
                gen = txtfemale.Text;
            }
            a.Execute("INSERT INTO Prisoners(Name,PrisonerID,Gender,DateofBirth,CrimeDescription,Punishment,CellNo,BloodGroup,Address,Counselor)" +
                " VALUES('" + txtname.Text + "','" + txtprisonerid.Text + "','" + gen + "','" + dob.Text + "','" + txtcrimedescription.Text + "','" + txtpunishment.Text + "','" + txtcellno.Text + "','" + txtbloodgroup.Text + "','" + txtaddress.Text + "','" + Counselor + "')");
            MessageBox.Show("Prisoner Added successfully!");

            string path = @"C: \Users\Satanic\Desktop\Empty\b.txt";
            FileInfo info = new FileInfo(path);
            string text = "ser";
            File.WriteAllText(path, text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This field is Auto Generated");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guard g = new Guard();
            g.Show();
            this.Hide();
        }
    }
}
