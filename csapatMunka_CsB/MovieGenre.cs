using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public abstract class MovieGenre : Movie
    {
        public MovieGenre(string movie_Name, DateTime release_Date, string movie_Type, string director, string music_Composer, decimal money_Spent, decimal income,
            string genre, string theme, string tone, string targetAudience)
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income)
        {
            Genre = genre;
            Theme = theme;
            Tone = tone;
            TargetAudience = targetAudience;
        }

        public string Genre{ get; set; }
        public string Theme { get; set; }
        public string Tone { get; set; }
        public string TargetAudience { get; set; }


        public override string ToString()
        {
            var us = new CultureInfo("en-US");
            return $"{Movie_Name} ({Release_Date.Year}) - {Movie_Type}, " +
                   $"Directed by {Director}, Music by {Music_Composer}, " +
                   $"Genre: {Genre}, Theme: {Theme}, Tone: {Tone}, " +
                   $"Target Audience: {TargetAudience}, " +
                   $"Budget: {Money_Spent.ToString("C", us)}, " +
                   $"Income: {Income.ToString("C", us)}";
        }
    }
}
