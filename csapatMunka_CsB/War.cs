using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Globalization;

namespace csapatMunka_CsB
{
    public class War : MovieGenre
    {
        public string BattleName { get; set; }
        public string MainCommander { get; set; }
        public int SoldierCount { get; set; }
        public bool HasHistoricAccuracy { get; set; }

        public War(
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
            string battleName,
            string mainCommander,
            int soldierCount,
            bool hasHistoricAccuracy
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, genre, theme, tone, targetAudience)
        {
            movie_Type = "war";
            BattleName = battleName;
            MainCommander = mainCommander;
            SoldierCount = soldierCount;
            HasHistoricAccuracy = hasHistoricAccuracy;
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
                   $"Battle: {BattleName}, Commander: {MainCommander}, " +
                   $"Soldiers: {SoldierCount}, Historically Accurate: {HasHistoricAccuracy}";
        }
    }
}
