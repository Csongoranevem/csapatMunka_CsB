using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
    public abstract class MovieGenre
    {
        public string Name { get; set; }
        public string Theme { get; set; }
        public string Tone { get; set; }
        public string TargetAudience { get; set; }
    }
}
