using System;
using shop.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace shop.Forms
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            textInput.Clear();
            textInput.Text = "SELECT ";
        }

        private void doSqlBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost;user id=root;password=admin;persistsecurityinfo=True;database=shopdb;charset=utf8");
                con.Open();
                MySqlDataAdapter oda = new MySqlDataAdapter(textInput.Text, con);
                DataTable dt = new DataTable();
                oda.Fill(dt);
                dataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(@"Error: " + ex.Message);
            }

        }

        public string connectionString { get; set; }
    }
}
