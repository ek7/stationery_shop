using System;
using shop.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace shop
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        public static string connectionString = "server=localhost;user id=root;password=admin;persistsecurityinfo=True;database=shopdb;charset=utf8";
        MySqlConnection con = new MySqlConnection(connectionString);

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (snpStr.Text != "" && jobStr.Text != "" && passportNo.Text != "" && loginStr.Text != "" && passwdStr.Text != "")
            {
                int countIn = 0;
                con.Open();
                MySqlCommand checkComm = new MySqlCommand("SELECT Passport_number,Login FROM autorization", con);
                MySqlCommand insertComm = new MySqlCommand("INSERT INTO autorization(SNP,Job,Passport_number,Login,Password) VALUES ('" + snpStr.Text + "','" + jobStr.Text + "','" + passportNo.Text + "','" + loginStr.Text + "','" + passwdStr.Text + "')", con);
                MySqlDataReader reader = checkComm.ExecuteReader();
                while (reader.Read()) 
                {
                    if (reader["Login"].ToString() == loginStr.Text) 
                    {
                        MessageBox.Show("Такой логин уже зарегистрирован. Пожалуйста, придумайте новый логин.");
                        countIn++;
                        break;
                    }
                    if (reader["Passport_number"].ToString() == passportNo.Text) 
                    {
                        MessageBox.Show("Такой пользователь уже зарегистрирован.");
                        countIn++;
                        break;
                    }
                }
                reader.Close();
                if (countIn == 0)
                {
                    MySqlDataReader dataAd = insertComm.ExecuteReader();
                    while (dataAd.Read()) { }
                    MessageBox.Show("Вы успешно зарегестрированы.");
                    this.Close();
                }
                con.Close();
            }
            else 
            {
                MessageBox.Show("Заполните все поля формы.");
            }
        }
    }
}
