using System;

namespace Descriptionary.GameData
{
    public static class StringExtensions
    {
        /// <summary>
        /// Will return a random string from the array for strings
        /// </summary>
        /// <param name="array">an array of strings</param>
        /// <returns></returns>
        public static string GetRandomString(this string[] array)
        {
            var r = new Random();
            var rli = r.Next(0, array.Length);

            return array[rli];
        }
    }
}
