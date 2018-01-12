using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var dogs = new Dogs();

            Console.WriteLine("I love dogs!");
            string inputString = dogs.DogType();
        }
    }
}
