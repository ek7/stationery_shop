using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace shop.Forms
{
    public partial class AccountantForm : Form
    {
        public const string connectionString = "server=localhost;user id=root;password=admin;persistsecurityinfo=True;database=shopdb;charset=utf8";
        MySqlConnection con = new MySqlConnection(connectionString);

        public AccountantForm()
        {
            InitializeComponent();
        }

        private void продажиЗаПоследнийМесяцToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentMonth = DateTime.Now.Month.ToString();
            MySqlCommand conCommand = new MySqlCommand("SELECT name,number_of_saled,account_sales.price,sale_date FROM account_sales,stationery WHERE stationery.id_product=account_sales.id_product AND sale_date LIKE '%." + currentMonth + ".%'", con);
            
            con.Open();
            MySqlDataReader dataReader = conCommand.ExecuteReader();
          
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Название товара";
            dataGridView1.Columns[1].Name = "Продано шт.";
            dataGridView1.Columns[2].Name = "Цена";
            dataGridView1.Columns[3].Name = "Дата продажи";
            
            while (dataReader.Read()) 
            {  
                dataGridView1.Rows.Add(dataReader["name"].ToString(), dataReader["number_of_saled"].ToString(),
                    dataReader["price"].ToString(), dataReader["sale_date"].ToString());
            }
            con.Close();
            MySqlCommand conComm = new MySqlCommand("SELECT Sum(number_of_saled) AS countedNum,Sum(price) AS countedPrice FROM account_sales WHERE sale_date LIKE '%." + currentMonth + ".%'", con);
            con.Open();
            MySqlDataReader dReader = conComm.ExecuteReader();
            while (dReader.Read())
            {
                PriceCount.Text = dReader["countedPrice"].ToString();
                SeledCount.Text = dReader["countedNum"].ToString();
            }
            con.Close();
        }

        private void продажиЗаГодToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentYear = DateTime.Now.Year.ToString();
            MySqlCommand conCommand = new MySqlCommand("SELECT name,number_of_saled,account_sales.price,sale_date FROM account_sales,stationery WHERE stationery.id_product=account_sales.id_product AND sale_date LIKE '%." + currentYear + "%'", con);
            con.Open();
            MySqlDataReader dataReader = conCommand.ExecuteReader();
            dataGridView1.Columns.Clear();
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "Название товара";
            dataGridView1.Columns[1].Name = "Продано шт.";
            dataGridView1.Columns[2].Name = "Цена";
            dataGridView1.Columns[3].Name = "Дата продажи";

            while (dataReader.Read())
            {
                dataGridView1.Rows.Add(dataReader["name"].ToString(), dataReader["number_of_saled"].ToString(),
                    dataReader["price"].ToString(), dataReader["sale_date"].ToString());
            }
            con.Close();
            MySqlCommand conComm = new MySqlCommand("SELECT Sum(number_of_saled) AS countedNum,Sum(price) AS countedPrice FROM account_sales WHERE sale_date LIKE '%." + currentYear + "%'", con);
            con.Open();
            MySqlDataReader dReader = conComm.ExecuteReader();
            while (dReader.Read())
            {
                PriceCount.Text = dReader["countedPrice"].ToString();
                SeledCount.Text = dReader["countedNum"].ToString();
            }
            con.Close();
        }

    }
}
