using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    public class Bulldog
    {
        

        public string Color { get; set; }
        public string Name { get; set; }


        public Bulldog(string name)
        {
            Name = name;
            PrintName();
            
        }


        public void PrintName()
        {
            Console.WriteLine("My Bulldog's name is: " + Name);
        }

   

        
    }
}
