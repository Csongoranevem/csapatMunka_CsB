using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
            string genre,
            string theme,
            string tone,
            string targetAudience,
            string conflictType,
            string mainProtagonistName,
            int emotionalIntensityLevel,
            bool hasTragicEnding
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, genre, theme, tone, targetAudience)
        {
            ConflictType = conflictType;
            MainProtagonistName = mainProtagonistName;
            EmotionalIntensityLevel = emotionalIntensityLevel;
            HasTragicEnding = hasTragicEnding;
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
                   $"Conflict Type: {ConflictType}, " +
                   $"Protagonist: {MainProtagonistName}, " +
                   $"Emotion Level: {EmotionalIntensityLevel}, " +
                   $"Tragic Ending: {HasTragicEnding}";
        }
    }
}
