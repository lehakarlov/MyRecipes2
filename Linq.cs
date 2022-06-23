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
            char[] chars = s.ToCharArray();
            chars[0] = char.IsUpper(chars[0]) ? (char.ToLower(chars[0])) : (char.ToUpper(chars[0]));
            return new string(chars);
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
