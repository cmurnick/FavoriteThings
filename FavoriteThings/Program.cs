using System;


namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("I love dogs!");


            var bulldog = new Bulldog("Patrick");

            Console.WriteLine("My Bulldog's name is: " + bulldog.Name);

            Console.ReadLine();

            var yoga = new Yoga("Childs Pose");

            Console.WriteLine("This yoga pose is: " + yoga.Pose);

            Console.ReadLine();

            var food = new Food("Kale Salad");

            Console.WriteLine("This food is: " + food.Name);

            Console.ReadLine();


        }
    } 



}