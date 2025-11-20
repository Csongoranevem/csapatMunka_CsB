using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public class Fantasy : MovieGenre
    {
      
        public string WorldName { get; set; }
        public string MagicSystemType { get; set; }
        public string MainHeroName { get; set; }
        public bool HasMythicalCreatures { get; set; }

        public Fantasy(
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
            string worldName,
            string magicSystemType,
            string mainHeroName,
            bool hasMythicalCreatures
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            WorldName = worldName;
            MagicSystemType = magicSystemType;
            MainHeroName = mainHeroName;
            HasMythicalCreatures = hasMythicalCreatures;
        }
    }
}
