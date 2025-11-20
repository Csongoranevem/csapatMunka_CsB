using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace csapatMunka_CsB
{
    public class Crime : MovieGenre
    {
      
        public string CrimeType { get; set; }
        public string InvestigatorName { get; set; }
        public bool IsBasedOnTrueEvents { get; set; }
        public int VictimCount { get; set; }
        public Crime(
            string movie_Name,
            DateTime release_Date,
            string movie_Type,
            string director,
            string music_Composer,
            decimal money_Spent,
            decimal income,
            string name,
            string theme,
            string tone,
            string targetAudience,
            string crimeType,
            string investigatorName,
           
            bool isBasedOnTrueEvents,
            int victimCount
            
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            CrimeType = crimeType;
            InvestigatorName = investigatorName;
            
            IsBasedOnTrueEvents = isBasedOnTrueEvents;
            VictimCount = victimCount;
                      
        }
    }
}
