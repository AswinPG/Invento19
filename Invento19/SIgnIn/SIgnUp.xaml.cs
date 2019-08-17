using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Invento19.SIgnIn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SIgnUp : ContentPage
    {
        public SIgnUp()
        {
            InitializeComponent();
        }

        private async void GoTapped(object sender, EventArgs e)
        {
            await GoBut.ScaleTo(.96, 100);
            await GoBut.ScaleTo(1, 100);
            //await Navigation.PushAsync(new MainShell());
            App.Current.MainPage= new MainShell();
        }

        private async void SignInTapped(object sender, EventArgs e)
        {
            await SignInLabel.ScaleTo(.96, 100);
            await SignInLabel.ScaleTo(1, 100);
            await Navigation.PushAsync(new LogIn());
        }
    }
}