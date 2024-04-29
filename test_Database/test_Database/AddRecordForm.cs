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
    public partial class AddRecordForm : Form
    {
        public AddRecordForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            MainForm form = new MainForm();

            this.Hide();
            form.ShowDialog();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            Database database = new Database();

            try
            {
                // Get data from fields
                String typeOf = type_of_field.Text;
                Int32 price = Convert.ToInt32(price_field.Text);
                String postavka = postavka_field.Text;
                Int32 count = Convert.ToInt32(count_field.Text);

                // Inserting db
                SqlDataAdapter adapter = new SqlDataAdapter();

                database.openConnection();

                String sqlQuery = $"INSERT INTO test_db (type_of, count_of, price, postavka) VALUES ('{typeOf}', '{count}', '{price}', '{postavka}')";
                SqlCommand command = new SqlCommand(sqlQuery, database.getConnection());

                command.ExecuteNonQuery();
                MessageBox.Show("Успешно добавлено!");

                database.closeConnection();

                // Show message and hide form
                MainForm form = new MainForm();

                this.Hide();
                form.ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Произошла ошибка");
                database.closeConnection();
            }
        }
    }
}
