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
using FlightAttendant.Book;

namespace FlightAttendant
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            var booking = new Booked();
            InitializeComponent();

            //Dropdown_Destination.DataSource = DBLoad.GetDestinations();
            Dropdown_Destination.DataSource = new BindingSource(DBLoad.GetCountries(), null);
            Dropdown_Destination.DisplayMember = "value";
            Dropdown_Destination.ValueMember = "key";

            
        }

        private void dataGridCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns.Contains("book") && e.ColumnIndex == dataGridView1.Columns["book"].Index)//Specify which column contains Button in DGV
            {
                var currentRow = e.RowIndex;
                var arriveColumnIndex = dataGridView1.Columns["Checkin"].Index;
                var departColumnIndex = dataGridView1.Columns["Checkout"].Index;
                var locationColumnIndex = dataGridView1.Columns["City"].Index;
                var hotelColumnIndex = dataGridView1.Columns["Name"].Index;
                var row = dataGridView1.Rows[currentRow];
                var valueArrive = (DateTime)row.Cells[arriveColumnIndex].Value;
                var valueDepart = (DateTime)row.Cells[departColumnIndex].Value;
                var valueLocation = (string)row.Cells[locationColumnIndex].Value;
                var valuehotel = (string)row.Cells[hotelColumnIndex].Value;

                var flightsForm = new FlightAttendant.FlightForm(valueLocation, valueArrive, valueDepart);
                
                Booked.MyBook.BookHotel(valuehotel, valueLocation, valueArrive, valueDepart);

                flightsForm.ShowDialog();

            }
        }

        private void button_Search_Click(object sender, EventArgs e)
        {

            dataGridView1.Columns.Clear();

            var arrDate = datePicker_arr.Value.Date;
            var depDate = datePicker_dep.Value.Date;
            var selectedDestination = (KeyValuePair<string, string>)Dropdown_Destination.SelectedItem;
            if (arrDate > depDate)
            {
                MessageBox.Show("checkoput date is befor checkin date", "Date ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            dataGridView1.DataSource = DBLoad.GetHotelrooms(selectedDestination.Key, arrDate, depDate);

            var button = new DataGridViewButtonColumn();
            dataGridView1.Columns.Add(button);
            button.Text = "Book";
            button.Name = "book";
            button.UseColumnTextForButtonValue = true;

            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridCart_CellClick);
            this.dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 11);
            this.dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

            //set autosize mode
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            //datagrid has calculated it's widths so we can store them
            for (int i = 0; i <= dataGridView1.Columns.Count - 1; i++)
            {
                //store autosized widths
                int colw = dataGridView1.Columns[i].Width;
                //remove autosizing
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                //set width to calculated by autosize
                dataGridView1.Columns[i].Width = colw;
            }
        }
    }
}
