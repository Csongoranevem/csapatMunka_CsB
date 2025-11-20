using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public class Drama : MovieGenre
    {
       
        public string ConflictType { get; set; }
        public string MainProtagonistName { get; set; }
        public int EmotionalIntensityLevel { get; set; } // 1–10
        public bool HasTragicEnding { get; set; }

        public Drama(
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
            string conflictType,
            string mainProtagonistName,
            int emotionalIntensityLevel,
            bool hasTragicEnding
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            ConflictType = conflictType;
            MainProtagonistName = mainProtagonistName;
            EmotionalIntensityLevel = emotionalIntensityLevel;
            HasTragicEnding = hasTragicEnding;
        }
    }
}
