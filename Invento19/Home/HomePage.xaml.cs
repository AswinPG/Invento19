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
            var name = new List<string>
            {
                "highlights.png", "highlights1.png", "highlights.png"
            };
            CarouselView.ItemsSource = name;
        }
    }
}