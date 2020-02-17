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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            DataTable dt = new DataTable("flights");
            dt.Clear();
            dt.Columns.Add("FlightNumber");
            dt.Columns.Add("From");
            dt.Columns.Add("To");
            dt.Columns.Add("Steats");
            //dt.Columns.Add("DepartDay");
            //dt.Columns.Add("DepartTime");
            //dt.Columns.Add("TravelTime");
            //dt.Columns.Add("SeatsFirst");
            //dt.Columns.Add("SeatsBusiness");
            //dt.Columns.Add("SeatsEconomy");

            using (var ctx = new FlightAttendantEntities())
            {
                var dbflights = ctx.Flights;

                dataGridView1.DataSource = dt;
                dataGridView1.DataSource = dbflights.ToList();
            }
        }


    }
}
