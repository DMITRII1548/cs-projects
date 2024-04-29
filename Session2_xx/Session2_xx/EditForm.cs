using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Session2_xx
{
    public partial class EditForm : Form
    {
        private Int32 SchedulteID;
        Database database = new Database();

        public EditForm(Int32 id)
        {
            SchedulteID = id; 
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;

            getScheduleData(SchedulteID);
        }

        private void getScheduleData(int id)
        {
            String sql =
                "SELECT DepartureAirport.IATACode, ArrivalAirport.IATACode, Aircrafts.Name, Schedules.Date, Schedules.Time, Schedules.EconomyPrice FROM Schedules " +
                "JOIN Aircrafts ON Aircrafts.ID = Schedules.AircraftID " +
                "JOIN Routes ON Schedules.RouteID = Routes.ID " +
                "JOIN Airports AS DepartureAirport ON DepartureAirport.ID = Routes.DepartureAirportID " +
                "JOIN Airports AS ArrivalAirport ON ArrivalAirport.ID = Routes.ArrivalAirportID " +
                $"WHERE Schedules.ID = {id}";

            MySqlCommand command = new MySqlCommand(sql, database.getConnection());

            database.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                from_label.Text = reader.GetString(0);
                to_label.Text = reader.GetString(1);
                airctaft_field.Text = reader.GetString(2);

                date_time_field.Value = reader.GetDateTime(3);
                time_field.Text = Convert.ToString(reader.GetValue(4));
                price_field.Value = Convert.ToInt32(reader.GetValue(5));
            }
            reader.Close();
            database.closeConnection();

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            var date = date_time_field.Value.ToString("yyyy-MM-dd");
            var time = Convert.ToString(time_field.Text);
            var price = price_field.Value;

            String sql = $"UPDATE Schedules SET Date='{date}', Time='{time}', EconomyPrice={price} WHERE Schedules.ID = {SchedulteID}";
            MySqlCommand command = new MySqlCommand(sql, database.getConnection());

            database.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Updated successfully!", "Success");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error", "Error");
            }
            database.closeConnection();
        }
    }
}
