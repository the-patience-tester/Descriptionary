using System;

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

        async void OnLetterAssociationClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LetterAssociationPage()
            {
                BindingContext = new ViewModels.LetterAsociation()
            });
        }
    }
}
