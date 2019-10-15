using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Invento19.Home
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            

            //var name = new List<string>
            //{
            //    "bandwar1.png", "natya1.png", "projectexpo.png", "queen.png", "robowar.png"
            //};
            //Car.ItemsSource = name;
        }
    }
}