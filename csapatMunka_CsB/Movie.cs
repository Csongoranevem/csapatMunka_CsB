using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    internal class Movie
    {
        //movie_name release_date    movie_type director    music_composer money_spent income


        public string Movie_Name { get; set; }
        public DateTime Release_Date { get; set; }
        public string Movie_Type { get; set; }
        public string Director { get; set; }
        public string Music_Composer { get; set; }
        public decimal Money_Spent { get; set; }
        public decimal Income { get; set; }

        public Movie(string movie_Name, DateTime release_Date, string movie_Type, string director, string music_Composer, decimal money_Spent, decimal income)
        {
            Movie_Name = movie_Name;
            Release_Date = release_Date;
            Movie_Type = movie_Type;
            Director = director;
            Music_Composer = music_Composer;
            Money_Spent = money_Spent;
            Income = income;
        }

        public override string ToString()
        {
            return $"{Movie_Name} ({Release_Date.Year}) - {Movie_Type}, Directed by {Director}, Music by {Music_Composer}, Budget: {Money_Spent:C}, Income: {Income:C}";
        }
    }
}
