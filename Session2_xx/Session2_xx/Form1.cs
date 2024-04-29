using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Session2_xx
{
    public partial class Form1 : Form
    {
        Database database = new Database();

        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Fill combo box
            String sqlComboBox = $"SELECT DISTINCT IATACode FROM Airports";
            FillComboBox(from_combo_box, sqlComboBox);
            FillComboBox(to_combo_box, sqlComboBox);

            sort_by_time_combo_box.Items.Add("Early");
            sort_by_time_combo_box.Items.Add("Latest");

            // fill data grid view
            CreateColumns();

            String sql = "SELECT Schedules.ID, Schedules.Date, Schedules.Time, Schedules.EconomyPrice, Schedules.FlightNumber, Aircrafts.TotalSeats, DepartureAirport.IATACode, ArrivalAirport.IATACode, Schedules.Confirmed FROM Schedules " +
                "JOIN Aircrafts ON Schedules.AircraftID = Aircrafts.ID " +

                "JOIN Routes ON Schedules.RouteID = Routes.ID " +
                "JOIN Airports AS DepartureAirport ON Routes.DepartureAirportID = DepartureAirport.ID " +
                "JOIN Airports AS ArrivalAirport ON Routes.ArrivalAirportID = ArrivalAirport.ID";
            MySqlCommand command = new MySqlCommand(sql, database.getConnection());

            database.openConnection();
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                drawSingleRow(dataGridView2, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void FillComboBox(ComboBox box, String sqlQuery)
        {
            MySqlCommand command = new MySqlCommand(sqlQuery, database.getConnection());

            database.openConnection();

            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                box.Items.Add(reader.GetValue(0));
            }

            reader.Close();
            database.closeConnection();
        }

        private void CreateColumns()
        {
            dataGridView2.Columns.Add("ID", "ID");
            dataGridView2.Columns.Add("Date", "Date");
            dataGridView2.Columns.Add("Time", "Time");
            dataGridView2.Columns.Add("EconomyPrice", "Economy Price");
            dataGridView2.Columns.Add("BusinessPrice", "Business Price");
            dataGridView2.Columns.Add("First Class Price", "First Class Price");
            dataGridView2.Columns.Add("FlightNumber", "FlightNumber");
            dataGridView2.Columns.Add("Aircraft", "Aircraft");
            dataGridView2.Columns.Add("From", "From");
            dataGridView2.Columns.Add("To", "To");

            dataGridView2.Columns["ID"].Visible = false;
        }

        private void drawSingleRow(DataGridView dgv, IDataReader record)
        {
            Int32 index = dgv.Rows.Add(
                record.GetInt32(0),
                Convert.ToDateTime(record.GetDateTime(1)).ToString("yyyy-mm-dd"),
                record.GetValue(2),
                "$" + Convert.ToString(record.GetInt32(3)),
                "$" + Convert.ToString(
                    Math.Round(
                        record.GetInt32(3) * 0.3 + record.GetInt32(3)
                    )
                ),
                "$" + Convert.ToString(
                    Math.Round(
                        record.GetInt32(3) * 0.35 + (record.GetInt32(3) * 0.3 + record.GetInt32(3))
                    )
                ),
                record.GetInt32(4),
                record.GetInt32(5),
                record.GetString(6),
                record.GetString(7)
            );

            if (record.GetInt32(8) == 0)
                dataGridView2.Rows[index].DefaultCellStyle.BackColor = Color.Red;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void apply_btn_Click(object sender, EventArgs e)
        {
            String from = from_combo_box.GetItemText(from_combo_box.SelectedItem);
            String to = to_combo_box.GetItemText(to_combo_box.SelectedItem);
            Int32 flightNumber = Convert.ToInt32(flight_number_filed.Value);
            var date = Convert.ToString(date_field.Value);
            String sorfByTime = sort_by_time_combo_box.GetItemText(sort_by_time_combo_box.SelectedItem);
 
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();

            String sql = "SELECT Schedules.ID, Schedules.Date, Schedules.Time, Schedules.EconomyPrice, Schedules.FlightNumber, Aircrafts.TotalSeats, DepartureAirport.IATACode, ArrivalAirport.IATACode, Schedules.Confirmed FROM Schedules " +
                "JOIN Aircrafts ON Schedules.AircraftID = Aircrafts.ID " +

                "JOIN Routes ON Schedules.RouteID = Routes.ID " +
                "JOIN Airports AS DepartureAirport ON Routes.DepartureAirportID = DepartureAirport.ID " +
                "JOIN Airports AS ArrivalAirport ON Routes.ArrivalAirportID = ArrivalAirport.ID";

            Boolean IsOneWhereExists = false;

            if (flightNumber != 0)
            {
                sql += $" WHERE Schedules.FlightNumber = {flightNumber}";
                IsOneWhereExists = true;
            }

            if (from != "")
            {
                sql += IsOneWhereExists ? " AND" : " WHERE";
                sql += $" DepartureAirport.IATACode = '{from}'";
                IsOneWhereExists = true;
            }

            if (to != "")
            {
                sql += IsOneWhereExists ? " AND" : "WHERE";
                sql += $" ArrivalAirport.IATACode = '{to}'";
                IsOneWhereExists = true;
            }

            if (date != "01.01.1997 0:00:00")
            {
                string formattedDate = Convert.ToDateTime(date).ToString("yyyy-MM-dd HH:mm:ss");
                sql += IsOneWhereExists ? " AND" : " WHERE";
                sql += $" Schedules.Date = STR_TO_DATE('{formattedDate}', '%Y-%m-%d %H:%i:%s')";
            }

            if (sorfByTime == "Early")
            {
                sql += " ORDER BY Schedules.Date ASC";
            }

            if (sorfByTime == "Latest")
            {
                sql += " ORDER BY Schedules.Date DESC";
            }


            database.openConnection();
            MySqlCommand command = new MySqlCommand(sql, database.getConnection());
            MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                drawSingleRow(dataGridView2, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to cancel this flight?", "Confirmation", MessageBoxButtons.YesNo);

            if (
                result == DialogResult.Yes
                && dataGridView2.SelectedRows.Count > 0
                )
            {
                var cellId = dataGridView2.SelectedRows[0].Cells[0].Value;

                Int32 id = Convert.ToInt32(cellId);

                String sql = $"UPDATE Schedules SET Confirmed = 0 WHERE ID = {id}";
                
                MySqlCommand command = new MySqlCommand(sql, database.getConnection());
                database.openConnection();

                command.ExecuteNonQuery();

                database.closeConnection();


                dataGridView2.Rows.Clear();
                redragDataGridView();
            }
        }

        private void redragDataGridView()
        {
            CreateColumns();

            String sql2 = "SELECT Schedules.ID, Schedules.Date, Schedules.Time, Schedules.EconomyPrice, Schedules.FlightNumber, Aircrafts.TotalSeats, DepartureAirport.IATACode, ArrivalAirport.IATACode, Schedules.Confirmed FROM Schedules " +
                "JOIN Aircrafts ON Schedules.AircraftID = Aircrafts.ID " +

                "JOIN Routes ON Schedules.RouteID = Routes.ID " +
                "JOIN Airports AS DepartureAirport ON Routes.DepartureAirportID = DepartureAirport.ID " +
                "JOIN Airports AS ArrivalAirport ON Routes.ArrivalAirportID = ArrivalAirport.ID";
            MySqlCommand command2 = new MySqlCommand(sql2, database.getConnection());

            database.openConnection();
            MySqlDataReader reader = command2.ExecuteReader();

            while (reader.Read())
            {
                drawSingleRow(dataGridView2, reader);
            }

            reader.Close();
            database.closeConnection();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                var cellId = dataGridView2.SelectedRows[0].Cells[0].Value;
                Int32 id = Convert.ToInt32(cellId);

                EditForm form = new EditForm(id);

                form.ShowDialog();
            }
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            redragDataGridView();
        }
    }
}
