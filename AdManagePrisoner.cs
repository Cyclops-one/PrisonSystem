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

        public static string Cell;
        public static string Id;
        Access a;

        public AdManagePrisoner()
        {
            InitializeComponent();

            this.a = new Access();

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


            a.Execute("Delete  from Prisoners where PrisonerID='" + textBox4.Text + "' ");


        }

        private void button3_Click(object sender, EventArgs e)//update
        {


            a.Execute("Update dbo.Prisoners set " + comboBox1.Text + " ='" + textBox1.Text + "' where PrisonerID = '" + textBox2.Text + "'");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {


                // dataGridView1.DataSource  =a.Alllist("Select * from Prisoners where PrisonerID ='" + textBox3.Text + "'");
                //a.Alllist("Select * from Prisoners where PrisonerID ='" + textBox3.Text + "'");
                //string sql = "Select * from Prisoners where PrisonerID ='" + textBox3.Text + "'";
                Criminal cr = new Criminal();
                Id = txtbox.Text;
                dataGridView1.DataSource = cr.Listbyid();
                a.Cclose();
               

            }

            else if (radioButton2.Checked)
            {


                // dataGridView1.DataSource  =a.Alllist("Select * from Prisoners where CellNo='" + comboBox2.Text + "'");
                // a.Alllist("Select * from Prisoners where CellNo='" + comboBox2.Text + "'");
                txtbox.Text = null;
                Cell = comboBox2.Text;
                Criminal cr = new Criminal();

                dataGridView1.DataSource = cr.Listbycell();
                a.Cclose();
                comboBox2.Text = null;
            }
            else
            {
                // a.Connection();
                //dataGridView1.DataSource  =a.Alllist("Select * from Prisoners");
                Criminal cr = new Criminal();
                dataGridView1.DataSource = cr.Alllist();

                a.Cclose();
                txtbox.Text = null;
                comboBox2.Text = null;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminPanel ad = new AdminPanel();
            ad.Show();
            this.Hide();
        }

        private void AdManagePrisoner_Load(object sender, EventArgs e)
        {
            //a.Connection();
            Criminal cr = new Criminal();
           
            dataGridView1.DataSource = cr.Alllist();
            a.Cclose();

        }
    }
}
