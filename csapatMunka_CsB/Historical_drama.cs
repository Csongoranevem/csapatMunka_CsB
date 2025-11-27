using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace csapatMunka_CsB
{
    public class Historical_drama : MovieGenre
    {
        public string HistoricalPeriod { get; set; }     
        public string SettingLocation { get; set; }      
        public bool BasedOnRealPeople { get; set; }      
        public int HistoricalAccuracyLevel { get; set; } 

        public Historical_drama(
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
            string historicalPeriod,
            string settingLocation,
            bool basedOnRealPeople,
            int historicalAccuracyLevel
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, genre, theme, tone, targetAudience)
        {
            HistoricalPeriod = historicalPeriod;
            SettingLocation = settingLocation;
            BasedOnRealPeople = basedOnRealPeople;
            HistoricalAccuracyLevel = historicalAccuracyLevel;
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
                   $"Historical Period: {HistoricalPeriod}, " +
                   $"Setting: {SettingLocation}, " +
                   $"Based on Real People: {BasedOnRealPeople}, " +
                   $"Accuracy Level: {HistoricalAccuracyLevel}";
        }
    }
}
