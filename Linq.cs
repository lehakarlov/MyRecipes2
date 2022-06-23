using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyRecipes.Program;

namespace MyRecipes
{
    public static class Extention
    {
        public static string ChangeFirstLetter(this String s)
        {
            if (s.Equals(string.Empty))
            {
                return string.Empty;
            }
            else
            {
                if (s.Length == 1)
                {
                    return s.ToUpper();
                }
                else if (s.Length > 1)
                {

                    string start = s[0].ToString().ToUpper();
                    StringBuilder temp = new StringBuilder(start);
                    temp.Append(string.Join("", s[1..]));
                    return temp.ToString();

                }
                else
                {
                    return string.Empty;
                }
            }

        }
    }
    internal class Linq
    {
        public IEnumerable<int> numbers1 => new int[] { 1, 2, 3, 4, 5, 6, 7 };
        public IEnumerable<int> numbers2 => new int[] { 1, 2, 3, 5, 6, 7 };

        public static IEnumerable<int> UnionCollection(IEnumerable<int> collection1, IEnumerable<int> collection2)
        {
            return collection1.Union(collection2);
        }

        public static IEnumerable<Product> UnionCollectionProduct(IEnumerable<Product> c1, IEnumerable<Product> c2)
        {
            return c1.Union(c2);
        }




    }
}
