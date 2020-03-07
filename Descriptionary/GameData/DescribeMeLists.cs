using System;
using System.Collections.Generic;

namespace Descriptionary.GameData
{
    public class DescribeMe
    {
        readonly string[] yellowList =
        {
                "Awkward",
                "Calm",
                "Cheerful",
                "Chunky",
                "Clumsy",
                "Colossal",
                "Complex",
                "Cool",
                "Crunchy",
                "Damp",
                "Dull",
                "Enchanted",
                "Exciting",
                "Fake",
                "Feeble",
                "Fierce",
                "Floppy",
                "Foolish",
                "Fragile",
                "Freaky",
                "Friendly",
                "Furry",
                "Grumpy",
                "Hairy",
                "Inventive",
                "Lumpy",
                "Magical",
                "Mushy",
                "Quirky",
                "Repulsive",
                "Ruthless",
                "Savory",
                "Sharp",
                "Silly",
                "Slinky",
                "Solid",
                "Spicy",
                "Squeaky",
                "Sticky",
                "Stiff",
                "Strong",
                "Tangy",
                "Terrible",
                "Tasty",
                "Tricky",
                "Weird",
                "Wild",
                "Wonderful",
                "Yummy",
                "Zesty"
        };

        readonly string[] blueList = { "Wobbly", "Spikey", "Childish", "Lazy", "Wet", "Invisible"};

        public string GetRandomBlueWord()
        {
            return GetRandomWordFormArray(blueList);
        }

        public string GetRandomYellowWord()
        {
            return GetRandomWordFormArray(yellowList);
        }

        string GetRandomWordFormArray(string[] array)
        {
            var r = new Random();
            var rli = r.Next(0, array.Length);

            return array[rli];
        }
    }
}
