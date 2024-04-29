using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSqlApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            this.loginField.Text = "Введите логин";
            this.passwordField.Text = "Введите пароль";

            this.passwordField.UseSystemPasswordChar = false;
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Подтверждение", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            DB db = new DB();
  
            try
            {
                String login = this.loginField.Text;
                String password = this.passwordField.Text;

                if (login == "Введите логин")
                {
                    MessageBox.Show("Введите логин");
                    return;
                }    

                if (password == "Введите пароль")
                {
                    MessageBox.Show("Введите пароль");
                    return;
                }

                if (isLoginUserExist(login))
                {
                    return;
                }

                db.openConnection();

                MySqlCommand command = new MySqlCommand("INSERT INTO `users` (login, password) VALUES (@login, @password)", db.getConnection());
                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
                command.Parameters.Add("@password", MySqlDbType.VarChar).Value = password;

                if (command.ExecuteNonQuery() == 1)
                {
                    this.Hide();

                    WelcomeForm form = new WelcomeForm();
                    form.Show();
                }
                else
                {
                    MessageBox.Show("Произошла ошибка");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
            finally
            {
                db.closeConnection();
            }
        }

        private Boolean isLoginUserExist(String login)
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT*FROM `users` WHERE login = @login;", db.getConnection());
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь с логином " + login + " уже существует");
                return true;
            }

            
          
            return false;
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (this.loginField.Text == "Введите логин")
            {
                this.loginField.Text = "";
            }
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (this.loginField.Text == "")
            {
                this.loginField.Text = "Введите логин";
            }
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (this.passwordField.Text == "Введите пароль")
            {
                this.passwordField.UseSystemPasswordChar = true;
                this.passwordField.Text = "";
            }
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (this.passwordField.Text == "")
            {
                this.passwordField.UseSystemPasswordChar = false;
                this.passwordField.Text = "Введите пароль";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void open_log_Click(object sender, EventArgs e)
        {
            this.Hide();

            LoginForm form = new LoginForm();
            form.Show();
        }
    }
}
