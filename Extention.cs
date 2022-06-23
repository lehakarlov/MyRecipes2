using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipes
{
    public static class Extention
    {
        public static string ChangeFirstLetter(this String s)
        {
            char[] chars = s.ToCharArray();
            chars[0] =
            char.IsUpper(chars[0]) ?
            (char.ToLower(chars[0])) : (char.ToUpper(chars[0]));
            return new string(chars);
        }
    }
}
