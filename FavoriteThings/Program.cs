using System;


namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("I love dogs!");


            var bulldog = new Bulldog("Patrick");
            var bulldog2 = new Bulldog("Dozer \n" );
            

            var yoga = new Yoga("Childs Pose");
            var yoga2 = new Yoga("Downward Dog \n");

            var food = new Food("Kale Salad");
            var food2 = new Food("Buffalo Temph \n");


            Console.ReadLine();


        }
    } 



}