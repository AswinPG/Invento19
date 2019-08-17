using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Invento19.SIgnIn
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private async void GoTapped(object sender, EventArgs e)
        {
            await GoBut.ScaleTo(.96, 100);
            await GoBut.ScaleTo(1, 100);
            App.Current.MainPage = new MainShell();
        }

        private async void SignUpTapped(object sender, EventArgs e)
        {
            await SignUpLabel.ScaleTo(.96, 100);
            await SignUpLabel.ScaleTo(1, 100);
            await Navigation.PushAsync(new SIgnUp());
        }
    }
}