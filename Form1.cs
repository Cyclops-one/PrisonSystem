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

namespace Prisoner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["prisoner"].ConnectionString);
            connection.Open();
            string gen = null;
            if (txtmale.Checked)
            {
                gen = txtmale.Text;
            }
            else
            {
                gen = txtfemale.Text;
            }
            string sql = "INSERT INTO Prisoners(Name,PriosnerId,Gender,DateofBirth,CrimeDescription,Punishment,CellNo,BloodGroup,Address)" +
                " VALUES('"+txtname.Text+"','"+txtprisonerid.Text+"','"+gen+"','"+dob.Text+"','"+txtcrimedescription.Text+"','"+txtpunishment.Text+"','"+txtcellno.Text+"','"+txtbloodgroup.Text+"','"+txtaddress.Text+"','"+txtCounselor+"')";
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
           connection.Close();
            MessageBox.Show("Prisoner Added successfully!");
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
    }
}
