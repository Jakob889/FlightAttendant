using FlightAttendant.Staging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightAttendant
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            FlightServiceReferenceEmirates.FlightServiceClient obj = new FlightServiceReferenceEmirates.FlightServiceClient();
            Console.WriteLine(obj.GetFlights());
            Console.Read();

            //db load
            using (var ctx = new FlightAttendantEntities())
            {
                var flight1 = new Flights() { FlightNr = "FL1", From = "ZRH", To = "DBU", Seats = 4 };
                ctx.Flights.Add(flight1);
                ctx.SaveChanges();
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());







        }
    }
}
