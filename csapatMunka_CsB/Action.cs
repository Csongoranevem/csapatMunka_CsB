using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace csapatMunka_CsB
{
    public class Action : MovieGenre
    {
        // Új action-specifikus mezők
        
        public string MainHeroName { get; set; }
        public string MainVillainName { get; set; }
        public int StuntIntensityLevel { get; set; }  
        public Action(
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
           
            string mainHeroName,
            string mainVillainName,
            int stuntIntensityLevel
            
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
          
            MainHeroName = mainHeroName;
            MainVillainName = mainVillainName;
            StuntIntensityLevel = stuntIntensityLevel;
            
        }
    }
}


