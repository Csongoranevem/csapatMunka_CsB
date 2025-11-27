using System;
using System.Collections.Generic;
using System.Globalization;
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
            string genre,
            string theme,
            string tone,
            string targetAudience,
            string mainSuspect,
            string twistType,
            int suspenseLevel,
            bool hasChaseScenes
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, genre, theme, tone, targetAudience)
        {
            movie_Type = "thriller";
            MainSuspect = mainSuspect;
            TwistType = twistType;
            SuspenseLevel = suspenseLevel;
            HasChaseScenes = hasChaseScenes;
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
                   $"Main Suspect: {MainSuspect}, " +
                   $"Twist: {TwistType}, " +
                   $"Suspense Level: {SuspenseLevel}, " +
                   $"Chase Scenes: {HasChaseScenes}";
        }
    }
}
