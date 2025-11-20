using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public class Thriller : MovieGenre
    {
      
        public string MainSuspect { get; set; }
        public string TwistType { get; set; }      
        public int SuspenseLevel { get; set; }   
        public bool HasChaseScenes { get; set; }

        public Thriller(
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
            string mainSuspect,
            string twistType,
            int suspenseLevel,
            bool hasChaseScenes
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            MainSuspect = mainSuspect;
            TwistType = twistType;
            SuspenseLevel = suspenseLevel;
            HasChaseScenes = hasChaseScenes;
        }
    }
}
