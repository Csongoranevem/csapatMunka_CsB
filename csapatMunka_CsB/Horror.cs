using System;
using System;

namespace csapatMunka_CsB
{
    public class Horror : MovieGenre
    {
       
        public int GoreLevel { get; set; }
        public bool BasedOnTrueStory { get; set; }
        public int KillCount { get; set; }
        public string MainAntagonistName { get; set; }

        public Horror(
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
            int goreLevel,
            bool basedOnTrueStory,
            int killCount,
            string mainAntagonistName
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            GoreLevel = goreLevel;
            BasedOnTrueStory = basedOnTrueStory;
            KillCount = killCount;
            MainAntagonistName = mainAntagonistName;
        }
    }
}
