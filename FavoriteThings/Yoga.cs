using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    public class Yoga
    {
        protected string _pose;
        protected string _type;

        public string Pose
        {
            get
            {
                return _pose;
            }
            set
            {
                _pose = value;
            }

        }


        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public Yoga(string pose)
        {
            _pose = pose;
            Console.WriteLine("\n" + "This pose is called" + _pose);
        }

        public void PrintName()
        {
            Console.WriteLine("This yoga pose is: " + Pose);
        }
    }
}
