using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Staging.Model
{
    public class Flight
    {
        [Key]
        public string FlightNr { get; private set; }

        public string From { get; set; }

        public string To { get; set; }

        public int Seats { get; set; }

        //public Flight()
        //{
        //    ArticleId = DateTime.Now.Ticks;
        //    Prices = new List<Price>();
        //}

        //public virtual ICollection<OrderArticle> OrderArticles { get; set; } = new List<OrderArticle>();
    }
}