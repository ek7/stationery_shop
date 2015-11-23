using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using shop.Forms;

namespace shop
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();

        }

        public const string connectionString = "server=localhost;user id=root;password=admin;persistsecurityinfo=True;database=shopdb;charset=utf8";
        MySqlConnection con = new MySqlConnection(connectionString);

        private void реестрацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form registration = new Registration();
            registration.Show();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string login = loginStr.Text;
            string password = passwd.Text;
            int count = 0;
            MySqlCommand conCommand = new MySqlCommand("SELECT Login,Password,Job FROM autorization WHERE Login ='"+login+"'", con);
            con.Open();
            MySqlDataReader dataReader = conCommand.ExecuteReader();           
            while(dataReader.Read())
            {
                if (dataReader["Password"].ToString()==password)
                {
                    switch (dataReader["Job"].ToString()) 
                    {
                        case "Продавец":
                            MessageBox.Show("Вы вошли как продавец");
                            count++;
                            break;
                        case "Менеджер":
                            MessageBox.Show("Вы вошли как менеджер");
                            count++;
                            break;
                        case "Бухгалтер":
                            MessageBox.Show("Вы вошли как бухгалтер");
                            Form accountantform = new AccountantForm();
                            accountantform.Show();
                            count++;
                            break;
                        case "Admin":
                            MessageBox.Show("Вы вошли как admin");
                            Form admin = new Admin();
                            admin.Show();
                            count++;
                            break;
                    }

                }
            }
            if (count == 0) 
            {
               MessageBox.Show("Неверный логин и/или пароль.");
            }
            con.Close();

        }
    }
}
