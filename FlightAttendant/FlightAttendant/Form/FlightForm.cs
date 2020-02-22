using FlightAttendant.Staging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlightAttendant.Book;

namespace FlightAttendant
{
    public partial class FlightForm:Form
    {
        private string location = null;
        private DateTime depart;
        private bool Backflights = false;

        public FlightForm(string destination, DateTime arriveDate, DateTime departDate)
        {
            InitializeComponent();

            location = destination;
            depart = departDate;

            bindArrive(destination, arriveDate);
         }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    bindDepart(location, depart);
        //}

        public void bindDepart(string valueLocation, DateTime valueDepart)
        {
            dataGridView_flights.Columns.Clear();
            dataGridView_flights.DataSource = DBLoad.GetDepartingFlights(valueLocation, valueDepart);

            button();

            autosize();
        }

        public void bindArrive(string valueLocation, DateTime arriveDate)
        {
            dataGridView_flights.Columns.Clear();

            dataGridView_flights.DataSource = DBLoad.GetArrivingFlights(valueLocation, arriveDate);

            button();
            autosize();
        }

        public void button()
        {
            var button = new DataGridViewButtonColumn();
            dataGridView_flights.Columns.Add(button);
            button.Text = "Book";
            button.Name = "book";
            button.UseColumnTextForButtonValue = true;

            dataGridView_flights.CellClick += new DataGridViewCellEventHandler(dataGridCart_CellClick);
            this.dataGridView_flights.DefaultCellStyle.Font = new Font("Tahoma", 11);
            this.dataGridView_flights.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

        }

        public void autosize()
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

        private void dataGridCart_CellClick(object sender, DataGridViewCellEventArgs e)
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
                    bindDepart(location, depart);
                    Booked.MyBook.BookFlightDown(valueFlight, valueDepart, valueArrive);
                    Backflights = true;
                }
                else
                {
                    Booked.MyBook.BookFlightBack(valueFlight, valueDepart, valueArrive);
                    Close();
                }
            }
        }
    }
}
