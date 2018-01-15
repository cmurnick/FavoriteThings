using System;


namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
      

            Console.WriteLine("I love dogs!");
            Console.Read();
            

        }
    }

    class Bulldogs
    {
        private string _bulldogColor;
        private string _bulldogName;

        public string BulldogColor
        {
            get
            {
                return _bulldogColor;
            }
            set
            {
                _bulldogColor = value;
            }

        }


        public string BulldogName
        {
            get
            {
                return _bulldogName;
            }
            set
            {
                _bulldogName = value;
            }
        }

        public Bulldogs(string name)
        {
            _bulldogName = name;
            Console.WriteLine("\n" + "My bulldog's Name is" + _bulldogName);
            Console.ReadLine();

        }

        public void PrintMessage()
        {
            Console.WriteLine("My Bulldog's name is: ");
        }

        public string GetDogName()
        {
            PrintMessage();

        }

    }

}