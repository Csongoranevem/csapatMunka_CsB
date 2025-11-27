using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace csapatMunka_CsB
{
    public class Adventure : MovieGenre
    {
      
        
        public bool HasTreasureHunt { get; set; }
        public string MainProtagonistName { get; set; }
        public string MainAntagonistName { get; set; }
       

        public Adventure(
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
            bool hasTreasureHunt,
            string mainProtagonistName,
            string mainAntagonistName
           
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, genre, theme, tone, targetAudience)
        {
            HasTreasureHunt = hasTreasureHunt;
            MainProtagonistName = mainProtagonistName;
            MainAntagonistName = mainAntagonistName;
           
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
                   $"Treasure Hunt: {HasTreasureHunt}, " +
                   $"Protagonist: {MainProtagonistName}, " +
                   $"Antagonist: {MainAntagonistName}";
        }
    }
}
