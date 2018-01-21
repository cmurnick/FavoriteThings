using System;
using System.Collections.Generic;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("I love dogs!");


            var bulldog = new Bulldog("Patrick");
            var bulldog2 = new Bulldog("Dozer \n" );

            var yogaWorld = new List<Yoga>
            {
                new Yoga { Pose = "Shavasna", Hot= false, Studio = "Half Moon"},
                new Yoga { Pose = "Pigeon", Hot= true, Studio = "Shakti" }
            };

            foreach (var yoga in yogaWorld)
            {
                Console.WriteLine($"{yoga.Studio} is {(yoga.Hot ? "Toasty" : "bearable")}");
                Console.WriteLine(yoga.WhereToGo());
            }

            var foods = new List<Food>
            {
                new Food { Name = "Pizza", FoodGroup= "Junk", Vegan = false},
                new Food { Name = "Kale Salad", FoodGroup = "Vegetable", Vegan = true},
                new Food { Name = "Buffalo Temph", FoodGroup = "Healthy", Vegan = true}
            };

            foreach(var food in foods)
            {
                if (food.Vegan)
                {
                    Console.WriteLine(food.GoodToEat());
                }
                else
                    Console.WriteLine(food.GoodToEat());
            }

            Console.ReadLine();


        }
    } 



}