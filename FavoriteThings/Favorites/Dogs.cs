using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteThings.Favorites
{
    class Dogs
    {
        protected string _favoriteKindOfDog;

        public string FavoriteKindOfDog
        {
            get
            {
                return _favoriteKindOfDog;
            }

            set
            {
                _favoriteKindOfDog = value;
            }
        }
    }

    class DogName : Dogs
    {
        protected string _dogsName;

        public string FavoriteDogsName
        {
            get
            {
                return $"My favorite dog's name is {_dogsName}";
            }
            set
            {
                _dogsName = value;
            }
        }

    }
}
