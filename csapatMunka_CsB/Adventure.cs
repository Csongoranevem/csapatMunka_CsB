using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csapatMunka_CsB
{
	public class Adventure : MovieGenre
	{
		public Adventure(string name, string theme, string tone, string targetAudience)
            : base(name, theme, tone, targetAudience)
        {
		}
	}


}
