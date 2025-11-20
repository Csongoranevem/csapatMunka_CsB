using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public abstract class MovieGenre: Movie
    {
     
        public MovieGenre(string movie_Name, DateTime release_Date, string movie_Type, string director, string music_Composer, decimal money_Spent, decimal income, string name, string theme, string tone, string targetAudience) 
            : base(movie_Name, release_Date, movie_Type, director, music_Composer, money_Spent, income)
        {
            
        }

        public string Name { get; set; }
        public string Theme { get; set; }
        public string Tone { get; set; }
        public string TargetAudience { get; set; }


       
    }
}
