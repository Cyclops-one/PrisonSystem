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
    public partial class Outform : Form
    {
        public Outform()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["Random"].ConnectionString);
                string query;
                SqlCommand SqlCommand;
                SqlDataReader reader;
                SqlDataAdapter ad = new SqlDataAdapter();
                con.Open();
                query = "Select * from Criminals";

                SqlCommand = new SqlCommand(query, con);

                ad.SelectCommand = new SqlCommand(query, con);
                reader = SqlCommand.ExecuteReader();

                dataGridView1.DataSource = reader;
                dataGridView1.DataBindings();
  }

            catch

            {

                MessageBox.Show("No Record Found");

            }

        }
    }
}
