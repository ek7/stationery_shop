﻿using System;
using System.Windows.Forms;
namespace shop.Forms
{
    public partial class Admin : Form
    {
        private Mode mode;
        public Admin()
        {
            InitializeComponent();
            this.mode = Mode.stationeryMode;
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.wholesale_orders". При необходимости она может быть перемещена или удалена.
            this.wholesale_ordersTableAdapter.Fill(this.shopdbDataSet.wholesale_orders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.wholesale_buyers". При необходимости она может быть перемещена или удалена.
            this.wholesale_buyersTableAdapter.Fill(this.shopdbDataSet.wholesale_buyers);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.shopdbDataSet.provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.department". При необходимости она может быть перемещена или удалена.
            this.departmentTableAdapter.Fill(this.shopdbDataSet.department);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.autorization". При необходимости она может быть перемещена или удалена.
            this.autorizationTableAdapter.Fill(this.shopdbDataSet.autorization);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet.account_sales". При необходимости она может быть перемещена или удалена.
            this.account_salesTableAdapter.Fill(this.shopdbDataSet.account_sales);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopdbDataSet._stationery". При необходимости она может быть перемещена или удалена.
            this._stationeryTableAdapter.Fill(this.shopdbDataSet._stationery);
            dataView.AutoGenerateColumns = true;

        }

        private void запросКБазеДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form queryform = new QueryForm();
            queryform.ShowDialog();
        }

        private void dataView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private enum Mode
        {
            stationeryMode, salesMode, autorizationMode, departmentMode, providerMode,wholesaleBuyersMode,wholeSaleOrdersMode
        }

        private void канцелярскиеТоварыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = stationeryBindingSource;
            dataView.DataSource = stationeryBindingSource;
            tableLabel.Text = "Канцелярские товары";
            this.mode = Mode.stationeryMode;
        }

        private void учетПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = salesBindingSource;
            dataView.DataSource = salesBindingSource;
            tableLabel.Text = "Учет продаж";
            this.mode = Mode.salesMode;
        }

        private void авторизацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = autorizationBindingSource;
            dataView.DataSource = autorizationBindingSource;
            tableLabel.Text = "Авторизация";
            this.mode = Mode.autorizationMode;
        }

        private void отделToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = departmentBindingSource;
            dataView.DataSource = departmentBindingSource;
            tableLabel.Text = "Отдел";
            this.mode = Mode.departmentMode;
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = providerBindingSource;
            dataView.DataSource = providerBindingSource;
            tableLabel.Text = "Поставщики";
            this.mode = Mode.providerMode;
        }

        private void оптовыеПокупателиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = wholesaleBuyersBindingSource;
            dataView.DataSource = wholesaleBuyersBindingSource;
            tableLabel.Text = "Оптовые покупатели";
            this.mode = Mode.wholesaleBuyersMode;
        }

        private void оптовыеЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = wholeSaleOrdersBindingSource;
            dataView.DataSource = wholeSaleOrdersBindingSource;
            tableLabel.Text = "Оптовые заказы";
            this.mode = Mode.wholeSaleOrdersMode;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            switch (mode)
            {

                case Mode.stationeryMode:
                    {
                        stationeryEditForm ed = new stationeryEditForm();
                        ed.ShowDialog();
                        _stationeryTableAdapter.Fill(shopdbDataSet._stationery);
                        break;
                    }

                case Mode.salesMode:
                    {
                        salesEditForm ed = new salesEditForm();
                        ed.ShowDialog();
                        account_salesTableAdapter.Fill(shopdbDataSet.account_sales);
                        break;
                    }

                case Mode.autorizationMode:
                    {
                        autorizationEditForm ed = new autorizationEditForm();
                        ed.ShowDialog();
                        autorizationTableAdapter.Fill(shopdbDataSet.autorization);
                        break;
                    }
                case Mode.departmentMode:
                    {
                        departmentEditForm ed = new departmentEditForm();
                        ed.ShowDialog();
                        departmentTableAdapter.Fill(shopdbDataSet.department);
                        break;
                    }
                case Mode.providerMode:
                    {
                        providerEditForm ed = new providerEditForm();
                        ed.ShowDialog();
                        providerTableAdapter.Fill(shopdbDataSet.provider);
                        break;
                    }
                case Mode.wholesaleBuyersMode:
                    {
                        wholesaleBuyersEditForm ed = new wholesaleBuyersEditForm();
                        ed.ShowDialog();
                        wholesale_buyersTableAdapter.Fill(shopdbDataSet.wholesale_buyers);
                        break;
                    }
                case Mode.wholeSaleOrdersMode:
                    {
                        wholesaleOrdersEditForm ed = new wholesaleOrdersEditForm();
                        ed.ShowDialog();
                        wholesale_ordersTableAdapter.Fill(shopdbDataSet.wholesale_orders);
                        break;
                    }

                default: break;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch(mode){
                case Mode.stationeryMode:
                    {
                        _stationeryTableAdapter.DeleteQuery(Convert.ToInt32(dataView.SelectedRows[0].Cells[0].Value));
                        _stationeryTableAdapter.Fill(shopdbDataSet._stationery);
                        break;
                    }
                    case Mode.salesMode:
                    {
                        account_salesTableAdapter.DeleteQuery(Convert.ToInt32(dataView.SelectedRows[0].Cells[0].Value));
                        account_salesTableAdapter.Fill(shopdbDataSet.account_sales);
                        break;
                    }       
                case Mode.autorizationMode:
                    {
                        autorizationTableAdapter.DeleteQuery(Convert.ToInt32(dataView.SelectedRows[0].Cells[0].Value));
                        autorizationTableAdapter.Fill(shopdbDataSet.autorization);
                        break;
                    }
                case Mode.departmentMode:
                    {
                        departmentTableAdapter.DeleteQuery(Convert.ToInt32(dataView.SelectedRows[0].Cells[0].Value));
                        departmentTableAdapter.Fill(shopdbDataSet.department);
                        break;
                    }
                case Mode.providerMode:
                    {
                        providerTableAdapter.DeleteQuery(Convert.ToInt32(dataView.SelectedRows[0].Cells[0].Value));
                        providerTableAdapter.Fill(shopdbDataSet.provider);
                        break;
                    }
                case Mode.wholeSaleOrdersMode:
                    {
                        wholesale_ordersTableAdapter.DeleteQuery(Convert.ToInt32(dataView.SelectedRows[0].Cells[0].Value));
                        wholesale_ordersTableAdapter.Fill(shopdbDataSet.wholesale_orders);
                        break;
                    }
                case Mode.wholesaleBuyersMode:
                    {
                        wholesale_buyersTableAdapter.DeleteQuery(Convert.ToInt32(dataView.SelectedRows[0].Cells[0].Value));
                        wholesale_buyersTableAdapter.Fill(shopdbDataSet.wholesale_buyers);
                        break;
                    }
                    default: break;
        }

    }
}