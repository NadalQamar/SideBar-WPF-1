using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SideBar
{
    internal static class ColorCharacterAvoidList
    {
        public static char CheckChar(char c)
        {
            c = CharsAvoid(c);
            return c;
        }

        private static char CharsAvoid(char c)
        {
            if(c == 'g')
            {
                return 'y';
            }
            else if (c == 'G')
            {
                return 'y';
            }
            else
            {
                return 'n';
            }
        }
    }
}
