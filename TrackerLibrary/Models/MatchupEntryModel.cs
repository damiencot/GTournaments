using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// represents the score for this particular team
        /// </summary>
        public double Score { get; set; }

        /// <summary>
        /// represents the matchup that this team came 
        /// from as the the winer
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore"></param>
        public MatchupEntryModel(double initialScore)
        {

        }

    }
}
