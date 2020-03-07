using System;
using System.Collections.Generic;

namespace Descriptionary.GameData
{
    public class DescribeMe
    {


        readonly string[] yellowList = { "Furry", "Friendly", "Wild", "Quirky", "Mushy", "Awkward" };

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
