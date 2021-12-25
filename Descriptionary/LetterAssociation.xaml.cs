using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Descriptionary
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LetterAssociationPage : ContentPage
    {
        public LetterAssociationPage()
        {
            InitializeComponent();
        }


        void OnRefreshClicked(object sender, EventArgs e)
        {
            BindingContext = new ViewModels.LetterAssociation();
        }
    }
}