using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Represents one team in the matchup 
        /// </summary>
        public List<MatchUpEntryModel> entries { get; set; } = new List<MatchUpEntryModel>();

        /// <summary>
        /// Respresents the score for this particular team
        /// </summary>
        public TeamModel Winner { get; set; }

        public int MatchRound { get; set; }
           
        /// <summary>
        /// 
        /// </summary>
        /// <param name="initialScore"></param>
        public MatchupModel(double initialScore)
        {

        }
    }
}
