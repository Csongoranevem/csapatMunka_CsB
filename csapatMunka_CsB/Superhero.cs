using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace csapatMunka_CsB
{
    public class Superhero : MovieGenre
    {
        public string HeroName { get; set; }
        public string SuperPower { get; set; }
        public string MainVillainName { get; set; }
        public bool HasTeamUp { get; set; }

        public Superhero(
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
            string heroName,
            string superPower,
            string mainVillainName,
            bool hasTeamUp
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            HeroName = heroName;
            SuperPower = superPower;
            MainVillainName = mainVillainName;
            HasTeamUp = hasTeamUp;
        }
    }
}
