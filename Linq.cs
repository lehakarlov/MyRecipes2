using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipes
{
    internal class Linq
    {
        public IEnumerable<int> numbers1 => new int[] { 1, 2, 3, 4, 5, 6, 7 };
        public IEnumerable<int> numbers2 => new int[] { 1, 2, 3, 5, 6, 7 };

        public static IEnumerable<int> JoinCollection(IEnumerable<int> collection1, IEnumerable<int> collection2)
        {
            return collection1.Union(collection2);
        }

    }
}
