using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public abstract class MovieGenre : Movie
    {
        // Constructor updated to include required parameters for the base class
        public MovieGenre(string movie_Name, DateTime release_Date, string movie_Type, string director, string music_Composer, decimal money_Spent, decimal income,
            string gname, string theme, string tone, string targetAudience)
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income)
        {
            gName = gname;
            Theme = theme;
            Tone = tone;
            TargetAudience = targetAudience;
        }

        public string gName { get; set; }
        public string Theme { get; set; }
        public string Tone { get; set; }
        public string TargetAudience { get; set; }

        // Removed the redundant constructor that caused the error
    }
}
