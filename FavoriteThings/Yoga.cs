using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings
{
    public class Yoga
    {

        public string Pose { get; set; }
        public bool Hot { get; set; }
        public string Studio { get; set; }

        public string WhereToGo()
        {
            return Hot

             ? $"{Studio} is a hot studio.  If you're sensitive to the heat, you will want to do {Pose} somewhere else. \n "
             : $"{Studio} is of normal temperature, so you won't die.  Sometimes it is nice to do {Pose} in these conditions";

        }

    }

}