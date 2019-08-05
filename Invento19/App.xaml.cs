using System;
using Invento19.EventDetail;
using Invento19.Events;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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
            

            MainPage = new Eventpage();
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
