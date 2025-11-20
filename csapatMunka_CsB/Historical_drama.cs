using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public class Historical_drama : MovieGenre
    {
        public string HistoricalPeriod { get; set; }     
        public string SettingLocation { get; set; }      
        public bool BasedOnRealPeople { get; set; }      
        public int HistoricalAccuracyLevel { get; set; } 

        public Historical_drama(
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
            string historicalPeriod,
            string settingLocation,
            bool basedOnRealPeople,
            int historicalAccuracyLevel
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            HistoricalPeriod = historicalPeriod;
            SettingLocation = settingLocation;
            BasedOnRealPeople = basedOnRealPeople;
            HistoricalAccuracyLevel = historicalAccuracyLevel;
        }
    }
}
