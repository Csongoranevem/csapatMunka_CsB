using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace csapatMunka_CsB
{
    public class War : MovieGenre
    {
        public string BattleName { get; set; }
        public string MainCommander { get; set; }
        public int SoldierCount { get; set; }
        public bool HasHistoricAccuracy { get; set; }

        public War(
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
            string battleName,
            string mainCommander,
            int soldierCount,
            bool hasHistoricAccuracy
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            BattleName = battleName;
            MainCommander = mainCommander;
            SoldierCount = soldierCount;
            HasHistoricAccuracy = hasHistoricAccuracy;
        }
    }
}
