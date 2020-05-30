using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {

        /// <summary>
        /// Unique identifier for the team.
        /// </summary>
        public int Id { get; set; }
        public string TeamName { get; set; }
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();


    }
}
