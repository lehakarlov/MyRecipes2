using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipes
{

    internal class CovarianceArray
    {

        public interface IAnimal
        {
            void Voice();
        }
        public class Dog : IAnimal
        {
            public void Voice()
            {
                Console.WriteLine("Woof");
            }

            public void Jump()
            {
                Console.WriteLine("Jump");
            }
        }
        public class Program
        {
            public static void Main()
            {
                Dog[] dogs = { new Dog(), new Dog(), new Dog() };
                for (int i = 0; i < dogs.Length; i++)
                {
                    dogs[i].Voice();
                    dogs[i].Jump();
                }
                Console.WriteLine(new String('_', 10));
                //upcast
                IAnimal[] animals = dogs;
                for (int i = 0; i < animals.Length; i++)
                {
                    animals[i].Voice();
                }
                //downcast
                dogs = (Dog[])animals;
                for (int i = 0; i < dogs.Length; i++)
                {
                    dogs[i].Voice();
                    dogs[i].Jump();
                }
            }

        }

    }
}
