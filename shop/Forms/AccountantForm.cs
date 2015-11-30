using System;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Data;
using System.Drawing.Printing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Net.Mail;
using System.Net;

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
            string currentMonth = DateTime.Now.Month.ToString(),year = DateTime.Now.Year.ToString();
             label.Text = "Отчет за 01."+currentMonth+"."+year+" - "+DateTime.DaysInMonth(Convert.ToInt32(year)
                 , Convert.ToInt32(currentMonth)) + "." + currentMonth + "." + year;
            MySqlCommand conCommand = new MySqlCommand("SELECT name,number_of_saled,account_sales.price,sale_date FROM account_sales,` stationery` WHERE ` stationery`.id_product=account_sales.id_product AND sale_date LIKE '%." + currentMonth + ".%'", con);
            MySqlDataAdapter ad = new MySqlDataAdapter();
            DataSet ds = new DataSet();
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
            ad.SelectCommand = conCommand;
            ad.Fill(ds);
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
            label.Text = "Отчет за текущий " + currentYear + " год";
            MySqlCommand conCommand = new MySqlCommand("SELECT name,number_of_saled,account_sales.price,sale_date FROM account_sales,` stationery` WHERE ` stationery`.id_product=account_sales.id_product AND sale_date LIKE '%." + currentYear + "%'", con);
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

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDocument printDoc = new PrintDocument();
           
            if (printDialog.ShowDialog() == DialogResult.OK) 
            {
                printDoc.Print();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("F:\\otchet.txt");
            sw.WriteLine(label.Text);
            sw.WriteLine(" ____________________________________________________________________________________");
            for (int i = 0; i < dataGridView1.RowCount-1; i++) 
            {
                sw.WriteLine("| Name: " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " | Price: " 
                    + dataGridView1.Rows[i].Cells[1].Value.ToString()
                    + " | Number of: " + dataGridView1.Rows[i].Cells[2].Value.ToString()
                    + " | Date: " + dataGridView1.Rows[i].Cells[3].Value.ToString() + " |");
                sw.WriteLine(" ____________________________________________________________________________________");
            }
            sw.WriteLine(label1.Text + " "+SeledCount.Text);
            sw.WriteLine(label2.Text + " " + PriceCount.Text);
            sw.Close();
         }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp="";
            for(int i=0;i<dataGridView1.RowCount-1;i++)
            {
              temp+=  "| Name: " + dataGridView1.Rows[i].Cells[0].Value.ToString() + " | Price: " 
                    + dataGridView1.Rows[i].Cells[1].Value.ToString()
                    + " | Number of: " + dataGridView1.Rows[i].Cells[2].Value.ToString()
                    + " | Date: " + dataGridView1.Rows[i].Cells[3].Value.ToString() + " |\n\n";
            }
            temp += label1.Text + " " + SeledCount.Text + "\n" + label2.Text + " " + PriceCount.Text;
            MailMessage mail = new MailMessage("cool.grade2012@yandex.ru", "b.sparrow@yandex.ru",label.Text,temp);
            SmtpClient client = new SmtpClient("smtp.yandex.ru");
            client.Port = 587;
            client.Credentials = new NetworkCredential("cool.grade2012","1123581321graderoxas");
            client.EnableSsl = true;
            client.Send(mail);
            MessageBox.Show("Сообщение отправлено!");
        }
    }
}
