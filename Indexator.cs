using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MyRecipes.Program;

namespace MyRecipes
{
    internal class Indexator
    {
        public class IndexatorDemo
        {
            private int[] array = new int[5];
            public int this[int index]
            {
                get => array[index];
                set => array[index] = value;
            }
        }


        public class IndexatorDemo2
        {
            private string[] array = new string[5];
            public string this[int index]
            {
                get
                {
                    if (index >= 0 && index < array.Length)
                    {
                        return array[index];
                    }
                    else
                    {
                        //
                        return "error";
                    }
                }
                set
                {
                    if (index >= 0 && index < array.Length)
                    {
                        array[index] = value;
                    }
                    else
                    {
                        throw new IndexOutOfRangeException();
                    }
                }
            }
        }

        public class IndexatorDemo3
        {
            private Product[] records = new Product[5];

            public Product this[int index]
            {
                get => records[index];
                set => records[index] = value;
            }
        }

        public class IndX4
        {
            private List<string> records = new List<string>();
            public string this[int index]
            {
                get => records[index];
                set => records.Add(value);
            }
        }
    }
}
