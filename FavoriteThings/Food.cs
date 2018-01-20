using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Food
    {
       
            protected string _name;
            protected string _foodGroup;

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


            public string FoodGroup
            {
                get
                {
                    return _foodGroup;
                }
                set
                {
                    _foodGroup = value;
                }
            }

            public Food(string name)
            {
                _name = name;
                Console.WriteLine("\n" + "This food isd" + _name);
            }

            public void PrintName()
            {
                Console.WriteLine("This food is: " + Name);
            }
        
    }
}
