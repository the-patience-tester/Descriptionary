using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace Descriptionary.ViewModels
{
    public class DescribeMe : INotifyPropertyChanged
    {
        public DescribeMe()
        {
            var gd = new GameData.DescribeMe();
            BlueWord = gd.GetRandomBlueWord();
            YellowWord = gd.GetRandomYellowWord();
        }

        public string BlueWord { get; set; }
        public string YellowWord { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
