using System;
using System.IO;
using Xamarin.Forms;

namespace Descriptionary
{
    public partial class DescribeMePage : ContentPage
    {
        public DescribeMePage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        async void OnRefreshClicked(object sender, EventArgs e)
        {
            BindingContext = new ViewModels.DescribeMe();
        }
    }
}