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
using System.Timers;
using Timer = System.Windows.Forms.Timer;

namespace FlightAttendant
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = DBLoad.GetFlights();
            Dropdown_Destination.DataSource = DBLoad.GetDestinations();
        }


    }
}
