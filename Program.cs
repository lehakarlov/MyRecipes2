using System;
using System.Collections;
using System.Collections.Generic;

namespace MyRecipes
{
    internal class Program
    {
        public class Myclass
        {
            private int[] array = new int[5];
            public int this[int index]
            {//

                get => array[index];
                set => array[index] = value;
            }
        }


        public class Myclass2
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

        public class Product
        {
            public Product(string _name, decimal _price)
            {
                this.name = _name;
                this.price = _price;
            }
            public Product()
            {

            }
            public string name { get; set; }
            public decimal price { get; set; }
        }
        public class Cart
        {
            public Product[] products = new Product[4];
            public Product this[int index]

            {
                get => products[index];
                //set
                set => products[index] = value;
            }

        }
        public class Cart2
        {
            public Dictionary<string, Product> products = new Dictionary<string, Product>();
            public Product this[string index]

            {
                get => products[index];
                set => products[index] = value;
            }

        }

        public void IndexatorMethod()
        {
            Cart cart = new Cart();
            cart[0] = new Product() { name = "one", price = 203 };
            cart[1] = new Product() { name = "two", price = 200 };
            cart[2] = new Product("third", 100);
            cart[3] = new Product("third", 50);
            Console.WriteLine(cart[0].name);
            Console.WriteLine(cart[1].name);
            Console.WriteLine(cart[2].name);
            //
            //--------------------------------
            Cart2 cart2 = new Cart2();
            cart2["f"] = new Product() { name = "oneCart2", price = 100 };
            Console.WriteLine(cart2["f"].name);
        }

        static void Main(string[] args)
        {


            //

        }
    }
}


