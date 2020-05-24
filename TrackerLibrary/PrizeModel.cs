using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        /// <summary>
        /// Unique identifier for the prize.
        /// </summary>
        public int Id { get; set; }

        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PlaceAmount { get; set; } 
        public double PlacePercentage { get; set; } 

    }
}
