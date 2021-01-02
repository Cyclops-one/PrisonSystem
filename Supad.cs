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
    public partial class Supad : Form
    {
        public Supad()
        {
            InitializeComponent();
        }

        private void Supad_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)//add
        {
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            connection.Open();
            string gen = null;
            if (radioButton1.Checked)
            {
                gen = radioButton1.Text;
            }
            else
            {
                gen = radioButton2.Text;
            }
            string sql = "INSERT INTO Prisoners(Name,PrisonerID,Gender,DateofBirth,CrimeDescription,Punishment,CellNo,BloodGroup,Address,Counselor)" +
                " VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + gen + "','" + dateTimePicker1.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Prisoner Added successfully!");
        }

        private void button2_Click(object sender, EventArgs e)//goback
        {
            AdManagePrisoner adm = new AdManagePrisoner();
            this.Hide();
            adm.Show();
        }
    }
}
