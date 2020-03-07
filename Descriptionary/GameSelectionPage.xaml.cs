using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Descriptionary
{
    public partial class GameSelectionPage : ContentPage
    {
        public GameSelectionPage()
        {
            InitializeComponent();
        }

        async void OnDescribeMeClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new DescribeMePage
            {
                BindingContext = new ViewModels.DescribeMe()
            });
        }
    }
}
