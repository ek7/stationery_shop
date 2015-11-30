using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shop.Forms
{
    public partial class filterForm : Form
    {
        public filterForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (ProductName.Text != "")
                Temp.name = ProductName.Text;
            if(min.Text!="")
                Temp.minPrice = Convert.ToInt32(min.Text);
            if (max.Text != "")
                Temp.maxPrice = Convert.ToInt32(max.Text);
            if (Manufacturer.Text != "")
                Temp.manufacturer = Manufacturer.Text;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
