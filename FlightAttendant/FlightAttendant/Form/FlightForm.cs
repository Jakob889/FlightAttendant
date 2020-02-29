using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using Timer = System.Windows.Forms.Timer;
using FlightAttendant.Book;
using FlightAttendant.Staging;

namespace FlightAttendant
{
    public partial class FlightForm : Form
    {
        private string FormLocation = null;
        private DateTime FormDepart;
        private bool Backflights = false;

        public FlightForm(string destination, DateTime arriveDate, DateTime departDate)
        {
            InitializeComponent();

            FormLocation = destination;
            FormDepart = departDate;

            BindArrive(FormLocation, arriveDate);
         }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    bindDepart(location, depart);
        //}

        public void BindDepart(string valueLocation, DateTime valueDepart)
        {
            dataGridView_flights.Columns.Clear();
            dataGridView_flights.DataSource = DBLoad.GetDepartingFlights(valueLocation, valueDepart);

            Button();

            Autosize();
        }

        public void BindArrive(string valueLocation, DateTime arriveDate)
        {
            dataGridView_flights.Columns.Clear();

            dataGridView_flights.DataSource = DBLoad.GetArrivingFlights(valueLocation, arriveDate);

            Button();
            Autosize();
        }

        public void Button()
        {
            var button = new DataGridViewButtonColumn();
            dataGridView_flights.Columns.Add(button);
            button.Text = "Book";
            button.Name = "book";
            button.UseColumnTextForButtonValue = true;

            dataGridView_flights.CellClick += new DataGridViewCellEventHandler(DataGridFlight);
            this.dataGridView_flights.DefaultCellStyle.Font = new Font("Tahoma", 11);
            this.dataGridView_flights.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

        }

        public void Autosize()
        {
            //set autosize mode
            dataGridView_flights.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_flights.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView_flights.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dataGridView_flights.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dataGridView_flights.Columns[i].Width;
                //remove autosizing
                dataGridView_flights.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dataGridView_flights.Columns[i].Width = colw;
            }
        }

        private void DataGridFlight(object sender, DataGridViewCellEventArgs e)
        {
 

            if (dataGridView_flights.Columns.Contains("book") && e.ColumnIndex == dataGridView_flights.Columns["book"].Index)//Specify which column contains Button in DGV
            {
                var currentRow = e.RowIndex;
                var flightColumnIndex = dataGridView_flights.Columns["FlightNr"].Index;
                var departColumnIndex = dataGridView_flights.Columns["Depart"].Index;
                var arriveColumnIndex = dataGridView_flights.Columns["Arrive"].Index;

                var row = dataGridView_flights.Rows[currentRow];
                var valueFlight = (string)row.Cells[flightColumnIndex].Value;
                var valueDepart = (DateTime)row.Cells[departColumnIndex].Value;
                var valueArrive = (DateTime)row.Cells[arriveColumnIndex].Value;

                //var mainbook = get MainForm.Booking
                //MainForm.Booking.BookFlightDown(valuehotel, valueLocation, valueArrive, valueDepart);

                if (Backflights == false)
                {
                    BindDepart(FormLocation, FormDepart);
                    Booked.MyBooking.BookFlightDown(valueFlight, valueDepart, valueArrive);
                    Booked.MyBooking.Checkin = valueArrive;
                    Backflights = true;
                }
                else
                {
                    Booked.MyBooking.BookFlightBack(valueFlight, valueDepart, valueArrive);
                    var confForm = new ConfirmationForm();
                    Booked.MyBooking.Checkout = valueDepart;
                    confForm.ShowDialog();
                    Close();
                }
            }
        }
    }
}
