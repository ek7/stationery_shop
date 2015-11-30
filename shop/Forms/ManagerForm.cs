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
    public partial class ManagerForm : Form
    {
        public const string connectionString = "server=localhost;user id=root;password=admin;persistsecurityinfo=True;database=shopdb;charset=utf8";
        MySqlConnection con = new MySqlConnection(connectionString);
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void оформитьОптовыйЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ManagerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet._stationery". При необходимости она может быть перемещена или удалена.
            this._stationeryTableAdapter.Fill(this.shopdbDataSet._stationery);

        }
        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView2.ColumnCount = 5;
            dataGridView2.Columns[0].Name = "Название товара";
            dataGridView2.Columns[1].Name = "Количество";
            dataGridView2.Columns[2].Name = "Цена";
            dataGridView2.Columns[3].Name = "Производитель";
            dataGridView2.Columns[4].Name = "Артикул";
            try
            {
                OrderAskForm askform = new OrderAskForm(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()),
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[3].Value.ToString()) +
                Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[6].Value.ToString()));
                askform.ShowDialog();
                dataGridView2.Rows.Add(dataGridView1.SelectedRows[0].Cells[0].Value.ToString(), askform.Number,
                    Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[1].Value.ToString()) * askform.Number,
                    dataGridView1.SelectedRows[0].Cells[2].Value.ToString(),
                    dataGridView1.SelectedRows[0].Cells[4].Value.ToString());
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filter = "";
            int count = 0;
            Clear();
            SearchForm serForm = new SearchForm();
            serForm.ShowDialog();
            if (Temp.name != "")
            {
                filter += "name LIKE'" + Temp.name+"'";
                count++;
            }
            if (Temp.manufacturer != "")
            {
                if (count != 0)
                    filter += " and manufacturer LIKE'" + Temp.manufacturer + "'";
                else
                {
                    filter += "manufacturer LIKE'" + Temp.manufacturer + "'";
                    count++;
                }
            }
            if (Temp.Price >=0)
            {
                if (count != 0)
                    filter += " and price =" + Temp.Price;
                else
                {
                    filter += "price =" + Temp.Price;
                    count++;
                }
            }
            if (Temp.articul !="")
            {
                if (count != 0)
                    filter += " and article LIKE'" + Temp.articul+"'";
                else
                {
                    filter += "article LIKE'" + Temp.articul+"'";
                    count++;
                }
            }

            stationeryBindingSource.Filter = filter;
        }

        private void acceptBtn_Click(object sender, EventArgs e)
        {
            for(int i = 0;i<dataGridView2.RowCount-1;i++)
            {
                Temp.ProName[i] = dataGridView2.Rows[i].Cells[0].Value.ToString();
                Temp.ProCount[i] = Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value.ToString());
                Temp.ProPrice[i] = Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value.ToString());
                Temp.ProMan[i] = dataGridView2.Rows[i].Cells[3].Value.ToString();
                Temp.ProArticul[i] = dataGridView2.Rows[i].Cells[4].Value.ToString();
            }
            for (int t = 0; t < Temp.ProName.Length; t++) 
            {
                MessageBox.Show(Temp.ProName[t]);
            }
        }

        private void фильтрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filter = "";
            int count = 0;
            Clear();
            filterForm filForm = new filterForm();
            filForm.ShowDialog();
            if (Temp.name != "")
            {
                filter += "name LIKE'%" + Temp.name + "%'";
                count++;
            }
            if (Temp.manufacturer != "") 
            {
                if (count != 0)
                    filter += " and manufacturer LIKE'%" + Temp.manufacturer + "%'";
                else
                {
                    filter += "manufacturer LIKE'%" + Temp.manufacturer + "%'";
                    count++;
                }
            }
            if (Temp.minPrice >= 0)
            {
                if (count != 0)
                    filter += " and price >" + Temp.minPrice;
                else
                {
                    filter += "price >" + Temp.minPrice;
                    count++;
                }
            }
            if (Temp.maxPrice > 0)
            {
                if (count != 0)
                    filter += " and price <" + Temp.maxPrice;
                else 
                {
                    filter += "price <" + Temp.maxPrice;
                    count++;
                }
            }

            stationeryBindingSource.Filter = filter;
        }
        private void Clear() 
        {
            Temp.manufacturer = "";
            Temp.maxPrice = 10000000;
            Temp.minPrice = 0;
            Temp.name = "";
            Temp.Price = -1;
            Temp.articul = "";
        }

        private void сброситьВсеФильтрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stationeryBindingSource.Filter = null;
            this.Update();
        }

        private void заказТовараToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Add("nameProduct" , "Название товара");
            dataGridView1.Columns.Add("count" ,"Количество");
            dataGridView1.Columns.Add("sell" , "Цена");
            dataGridView1.Columns.Add("manufacturer" , "Производитель");
            dataGridView1.Columns.Add("article", "Артикул");
            MySqlCommand get = new MySqlCommand("SELECT * FROM ` stationery` WHERE quantity_in_stock < 15",con);
            con.Open();
            MySqlDataReader readerData = get.ExecuteReader();
            while (readerData.Read())
            {
                dataGridView1.Rows.Add(readerData["name"].ToString(), readerData["price"].ToString(),
                        readerData["quantity_in_stock"].ToString(), readerData["number_of_in_store"].ToString(),
                        readerData["article"].ToString());

            }
            con.Close();
        }
    }
}
