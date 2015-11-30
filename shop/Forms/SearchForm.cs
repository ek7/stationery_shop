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
    public partial class SearchForm : Form
    {

        public SearchForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Temp.name = ProductName.Text;
            Temp.manufacturer = Manufacturer.Text;
            Temp.articul = Articul.Text;
            if(Price.Text!="")
            Temp.Price = Convert.ToInt32(Price.Text);
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
