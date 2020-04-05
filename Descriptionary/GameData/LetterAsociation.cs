using System;
using System.Collections.ObjectModel;

namespace Descriptionary.GameData
{
    public class LetterAsociation
    {
        readonly string[] _placeTypes =
        {
            "Country",
            "City/Town",
        };

        readonly string[] _animals =
        {
            "Animal",
            "4 legged animal",
        };

        readonly string[] _names =
        {
            "name",
            "Boys name",
            "Girls name",
            "Male celebrity",
            "Female celebrity",
            "Fictional character",
            "Musician",
        };

        readonly string[] _musicTypes =
        {
            "Band",
            "Song",
        };

        readonly string[] _foodTypes =
        {
            "Food",
            "Drink",
            "Fruit",
            "Vegetable",
            "Savory dish",
            "Dessert",
        };

        readonly string[] _entertainmentTypes =
        {
            "Movie",
            "TV show",
            "Book",
            "Sport",
        };

        readonly string[] _bonusTypes =
        {
            "Body part",
            "Colour",
        };

        readonly string[] _gameLetters =
        {
            "A", "B", "C", "D", "E", "F",
            "G", "H", "J", "K", "L", "M",
            "N", "P", "R", "S", "T",
        };

        public LetterAssociationWords GetGameWords()
        {
            return new LetterAssociationWords
            {
                Place = _placeTypes.GetRandomString(),
                Animal = _animals.GetRandomString(),
                Name = _names.GetRandomString(),
                MusicType = _musicTypes.GetRandomString(),
                FoodType = _foodTypes.GetRandomString(),
                EntertainmentType = _entertainmentTypes.GetRandomString(),
                BonusType = _bonusTypes.GetRandomString()
            };
        }

        public string GetGameLetter()
        {
            return _gameLetters.GetRandomString().ToUpper();
        }
    }
}
