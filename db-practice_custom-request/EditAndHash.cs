using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace nstd
{
    class EditAndHash
    {
        public static string DeleteExtraSpaces(string str)
        {
            return Regex.Replace(DeleteBorderSpaces(str), "\\s+", " ");
        }

        public static string DeleteBorderSpaces(string str)
        {
            if (str is null)
                return "";
            return Regex.Replace(Regex.Replace(str, "^\\s+", ""), "\\s+$", "");
        }
    }
}
