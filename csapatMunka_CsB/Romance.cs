using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace csapatMunka_CsB
{
    public class Romance : MovieGenre
    {
        public string MainCoupleNames { get; set; }
        public string RelationshipConflict { get; set; } 
        public bool HasHappyEnding { get; set; }
        public int ChemistryLevel { get; set; }

        public Romance(
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
            string mainCoupleNames,
            string relationshipConflict,
            bool hasHappyEnding,
            int chemistryLevel
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, genre, theme, tone, targetAudience)
        {
            movie_Type = "romance";
            MainCoupleNames = mainCoupleNames;
            RelationshipConflict = relationshipConflict;
            HasHappyEnding = hasHappyEnding;
            ChemistryLevel = chemistryLevel;
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
                   $"Main Couple: {MainCoupleNames}, " +
                   $"Conflict: {RelationshipConflict}, " +
                   $"Happy Ending: {HasHappyEnding}, " +
                   $"Chemistry Level: {ChemistryLevel}";
        }
    }
}
