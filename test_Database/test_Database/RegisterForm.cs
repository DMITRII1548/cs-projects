using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace test_Database
{
    public partial class RegisterForm : Form
    {
        Database database = new Database();
        public RegisterForm()
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

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void show_register_Click(object sender, EventArgs e)
        {
            String login = login_field.Text;
            String password = password_field.Text;

            if (checkUser())
            {
                return;  
            }

            String sqlQuery = $"INSERT INTO register (login_user, password_user) VALUES ('{login}', '{password}');";
            SqlCommand command = new SqlCommand(sqlQuery, database.getConnection());

            database.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт создан");

                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Произошла неизвестная ошибка");
            }

            database.closeConnection();
        }

        private Boolean checkUser()
        {
            String login = login_field.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            String sqlQuery = $"SELECT*FROM register WHERE login_user = '{login}';";
            SqlCommand command = new SqlCommand(sqlQuery, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count >= 1) 
            {
                MessageBox.Show("Аккаунт с таким логином уже существует");
                return true;
            }

            return false;
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

        private void show_password_Click(object sender, EventArgs e)
        {

        }

        private void login_field_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
