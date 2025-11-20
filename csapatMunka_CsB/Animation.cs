using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public class Animation : MovieGenre
    {
       
        public string AnimationStyle { get; set; }
        public string TargetAgeGroup { get; set; }
        public string StudioName { get; set; }
        public string MainCharacterName { get; set; }
        

        public Animation(
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
            string animationStyle,
            string targetAgeGroup,
            string studioName,
            string mainCharacterName
            
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            AnimationStyle = animationStyle;
            TargetAgeGroup = targetAgeGroup;
            StudioName = studioName;
            MainCharacterName = mainCharacterName;
        }
    }
}
