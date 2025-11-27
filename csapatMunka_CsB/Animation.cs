using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            string genre,
            string theme,
            string tone,
            string targetAudience,
            string animationStyle,
            string targetAgeGroup,
            string studioName,
            string mainCharacterName
            
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, genre, theme, tone, targetAudience)
        {
            movie_Type = "animation";
            AnimationStyle = animationStyle;
            TargetAgeGroup = targetAgeGroup;
            StudioName = studioName;
            MainCharacterName = mainCharacterName;
        }
        public override string ToString()
        {
            var us = new CultureInfo("en-US");

            return $"{Movie_Name} ({Release_Date.Year}) - {Movie_Type}, " +
                   $"Directed by {Director}, Music by {Music_Composer}, " +
                   $"Genre: {Genre}, Theme: {Theme}, Tone: {Tone}, " +
                   $"Target Audience: {TargetAudience}, " +
                   $"Budget: {Money_Spent.ToString("C", us)}, " +
                   $"Income: {Income.ToString("C", us)}, " +
                   $"Animation Style: {AnimationStyle}, " +
                   $"Target Age Group: {TargetAgeGroup}, " +
                   $"Studio: {StudioName}, " +
                   $"Main Character: {MainCharacterName}";
        }
    }
}
