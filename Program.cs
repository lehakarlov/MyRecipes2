using MyRecipes.Repo;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static MyRecipes.Indexator;

namespace MyRecipes
{
    internal class Program
    {


        public class Product
        {
            #region ctor Product 
            public Product(string _name, decimal _price)
            {
                this.name = _name;
                this.price = _price;
            }
            public Product()
            {

            }
            #endregion
            public string name { get; set; }
            public decimal price { get; set; }

            public override bool Equals(Object obj)
            {
                if ((obj == null) || !this.GetType().Equals(obj.GetType()))
                {
                    return false;
                }
                else
                {
                    Product p = (Product)obj;
                    return (p.name.Equals(this.name)) && (p.price == this.price);
                }

            }
            public override int GetHashCode()
            {
                return HashCode.Combine(this.name, this.price);
            }
            public override string ToString()
            {
                return string.Format("{0} is {1};{2} is {3}",
                    nameof(this.name), this.name, nameof(this.price), this.price);
            }
        }
        public class Cart
        {
            public Product[] products = new Product[4];
            public Product this[int index]

            {
                get => products[index];
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
        public void DemoLinq()
        {
            IEnumerable<Product> products1 = new List<Product>
            {
                new Product() {name="1",price=200},
                new Product() {name="2",price=220},
            };
            IEnumerable<Product> products2 = new List<Product>
            {
                new Product(){ name="1",price=200},
                new Product() {name="3",price=220},
                new Product() {name="2",price=220},
            };
            var allProducts = Linq.UnionCollectionProduct(products2, products1).OrderBy(x => x.name);
            foreach (var item in allProducts)
            {
                Console.WriteLine(item.name + ";" + item.price);
            }
        }
        static void Main(string[] args)
        {

            IndexatorDemo3 indexatorDemo3 = new IndexatorDemo3();
            indexatorDemo3[0] = new Product() { name = "first name", price = 20 };
            indexatorDemo3[1] = new Product() { name = "2P", price = 200 };

            IndX4 indX4 = new IndX4();
            indX4[0] = "s";
            Console.WriteLine(indX4[0]);

        }
    }
}


