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

namespace FlightAttendant
{
    public partial class FlightForm : Form
    {
        string location = null;
        DateTime depart;

        public FlightForm(string destination, DateTime arriveDate, DateTime departDate)
        {
            InitializeComponent();

            location = destination;
            depart = departDate;

            bindArrive(destination, arriveDate);
         }

        private void button1_Click(object sender, EventArgs e)
        {
            bindDepart(location, depart);
        }

        public void bindDepart(string valueLocation, DateTime valueDepart)
        {
            dataGridView_flights.DataSource = DBLoad.GetDepartingFlights(valueLocation, valueDepart);
            autosize();
        }

        public void bindArrive(string valueLocation, DateTime arriveDate)
        {
            dataGridView_flights.DataSource = DBLoad.GetArrivingFlights(valueLocation, arriveDate);
            autosize();
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
    }
}
