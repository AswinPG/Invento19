using Invento19.Home;
using Invento19.SIgnIn;
using System;
using Xamarin.Forms;

namespace Invento19
{
    public partial class App : Application
    {
        public App()
        {
            try
            {
                InitializeComponent();
            }
            catch(Exception e)
            {
                var a = e;
            }


            MainPage = new NavigationPage(new LogIn());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
