using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_Database
{
    public partial class LoginForm : Form
    {
        Database database = new Database();

        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;


            password_field.UseSystemPasswordChar = true;
            login_field.MaxLength = 50;
            password_field.MaxLength = 50;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void show_register_Click(object sender, EventArgs e)
        {
            String loginUser = login_field.Text;
            String passwordUser = password_field.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String querySql = $"SELECT id_user, login_user, password_user FROM register WHERE login_user = '{loginUser}' AND password_user = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querySql, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли", "Успешно", MessageBoxButtons.OK);
                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void password_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_field_TextChanged(object sender, EventArgs e)
        {

        }

        private void show_password_Click(object sender, EventArgs e)
        {
            password_field.UseSystemPasswordChar = !password_field.UseSystemPasswordChar;
            show_password.Text = "Скрыть";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();

            this.Hide();
            form.ShowDialog();
            
        }
    }
}
