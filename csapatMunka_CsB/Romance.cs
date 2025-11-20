using System;
using System.Collections.Generic;
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
            string name,
            string theme,
            string tone,
            string targetAudience,
            string mainCoupleNames,
            string relationshipConflict,
            bool hasHappyEnding,
            int chemistryLevel
        )
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income, name, theme, tone, targetAudience)
        {
            MainCoupleNames = mainCoupleNames;
            RelationshipConflict = relationshipConflict;
            HasHappyEnding = hasHappyEnding;
            ChemistryLevel = chemistryLevel;
        }
    }
}
