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
    enum RowState
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class MainForm : Form
    {
        Database database = new Database();

        public MainForm()
        {
            InitializeComponent();
           
        }

        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id", "id");
            dataGridView1.Columns.Add("type_of", "Тип товара");
            dataGridView1.Columns.Add("count_of", "Количество");
            dataGridView1.Columns.Add("postavka", "Поставщик");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }

        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(
                record.GetInt32(0), 
                record.GetString(1), 
                record.GetInt32(2), 
                record.GetString(3), 
                record.GetInt32(4),                 
                RowState.ModifiedNew
            );
        }

        private void RegreshDataGrid(DataGridView dgw)
        {
            dgw.Rows.Clear();

            string sqlQuery = $"SELECT*FROM test_db";

            SqlCommand command = new SqlCommand(sqlQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RegreshDataGrid(dataGridView1);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;

            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                type_of_field.Text = row.Cells[1].Value.ToString();
                count_field.Text = row.Cells[2].Value.ToString();
                postavka_field.Text = row.Cells[3].Value.ToString();
                price_field.Text = row.Cells[4].Value.ToString();

            }
        }

        private void new_record_btn_Click(object sender, EventArgs e)
        {
            AddRecordForm form = new AddRecordForm();

            this.Hide();
            form.ShowDialog();
        }

        private void Search(DataGridView dgv)
        {
            dgv.Rows.Clear();

            String sqlQuery = $"SELECT*FROM test_db WHERE concat (id, type_of, count_of, postavka) LIKE '%" + search_field.Text + "%'";
            SqlCommand command = new SqlCommand(sqlQuery, database.getConnection());

            database.openConnection();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ReadSingleRow(dgv, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows[index].Visible = false;

            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[5].Value = RowState.Deleted;
                return;
            }
        }

        private void search_field_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Update()
        {
            database.openConnection();

            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                MessageBox.Show(Convert.ToString(dataGridView1.Rows[index].Cells[5].Value));
                var rowState = (RowState)dataGridView1.Rows[index].Cells[5].Value;

                if (rowState == RowState.Existed)
                {
                    continue;
                }

                if (rowState == RowState.Deleted)
                {
                    Int32 id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);

                    String sqlQuery = $"DELETE FROM test_db WHERE id = {id}";
                    SqlCommand command = new SqlCommand(sqlQuery, database.getConnection());

                    command.ExecuteNonQuery();
                    MessageBox.Show("Успешно удалено.");
                }
            }

            database.closeConnection();
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
