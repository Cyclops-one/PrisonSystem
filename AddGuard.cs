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
    public partial class AddGuard : Form
    {
        public AddGuard()
        {
            InitializeComponent();
        }

        private void AddGuard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
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
            string activity = null;
            if (checkBox1.Checked) 
            {
                activity= "Present";
            }
            else
            {
                activity = dateTimePicker2.Text;
            }
            string sql = "INSERT INTO Guards(Name,GuardID,Gender,BloodGroup,InService,EndService,Address,ControlBlock,Counselor)" +
                " VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + gen + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "','" + activity + "','"+textBox3.Text+"','"+textBox4.Text+"','"+textBox5.Text+"')";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Guard Added successfully!");

            string path = @"C: \Users\Satanic\Desktop\Empty\a.txt";
            FileInfo info = new FileInfo(path);
            string text = "ser";
            File.WriteAllText(path, text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminPanel ad = new AdminPanel();
            ad.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Underscore ControlBlock followed by Firstname");
        }
    }
}
