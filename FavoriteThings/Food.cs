using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    class Food
    {

        public string Name { get; set; }
        public string FoodGroup { get; set; }
        public bool Vegan  { get; set; }

        public string GoodToEat()
        {
        return Vegan

        ? $"{Name} is Vegan!  It's good for you and tastes good!!"
        : $"You might want to think twice before eating {Name}.  It's not the healthies option";
                
        }
        
    }
}
