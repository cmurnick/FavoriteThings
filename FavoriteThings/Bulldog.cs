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
        
       
        protected string _color;
        protected string _name;

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }

        }


        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

 

        public Bulldog(string name)
        {
            _name = name;
            Console.WriteLine("\n" + "My bulldog's Name is" + _name);


        }

        public void PrintName()
        {
            Console.WriteLine("My Bulldog's name is: " + Name);
        }

   

        
    }
}
