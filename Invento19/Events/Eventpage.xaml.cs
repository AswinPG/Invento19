using Invento19.ListsEvent;
using Invento19.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Invento19.Events
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
   
    public partial class Eventpage : ContentPage
    {
        public Eventpage()
        {
            InitializeComponent();



            List<ProgramModel> WorkShops = new List<ProgramModel>()
            {
               new ProgramModel()
               {
                   Type="Talk",
                   Event="Indroduction to web development"

               },
                new ProgramModel()
               {
                   Type="Workshop",
                   Event="Indroduction to web development"

               },
                new ProgramModel()
               {
                   Type="Talk",
                   Event="Indroduction to web development"

               },
                new ProgramModel()
               {
                   Type="Workshop",
                   Event="Indroduction to web development"

               },
                new ProgramModel()
               {
                   Type="Talk",
                   Event="Indroduction to web development"

               }
            };

            List<ProgramModel> ShowData = new List<ProgramModel>()
            {
                new ProgramModel()
                {
                    ImgUrl="aqua.png",
                    Name="Inspectra 2.0",
                    About="About"
                },
                  new ProgramModel()
                {
                    ImgUrl="a.png",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },
                new ProgramModel()
                {
                    ImgUrl="b.png",
                    Name="DBmania",
                    About="Database Trails"
                },
                new ProgramModel()
                {
                    ImgUrl="c.png",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="d.png" ,
                   
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="aqua.png",
                    Name="Inspectra 2.0",
                    About="About"
                },
                  new ProgramModel()
                {
                    ImgUrl="a.png",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },
                new ProgramModel()
                {
                    ImgUrl="b.png",
                    Name="DBmania",
                    About="Database Trails"
                },
                new ProgramModel()
                {
                    ImgUrl="c.png",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="d.png" ,

                    Name="Code Relay",
                    About="About"
                },
                 new ProgramModel()
                {
                    ImgUrl="aqua.png",
                    Name="Inspectra 2.0",
                    About="About"
                },
                  new ProgramModel()
                {
                    ImgUrl="a.png",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },
                new ProgramModel()
                {
                    ImgUrl="b.png",
                    Name="DBmania",
                    About="Database Trails"
                },
                new ProgramModel()
                {
                    ImgUrl="c.png",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="d.png" ,

                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="aqua.png",
                    Name="Inspectra 2.0",
                    About="About"
                },
                  new ProgramModel()
                {
                    ImgUrl="a.png",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },
                new ProgramModel()
                {
                    ImgUrl="b.png",
                    Name="DBmania",
                    About="Database Trails"
                },
                new ProgramModel()
                {
                    ImgUrl="c.png",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="d.png" ,

                    Name="Code Relay",
                    About="About"
                },


            };


            List<ProgramModel> EventData = new List<ProgramModel>()
            {
                new ProgramModel()
                {
                    ImgUrl="idea1.png",
                    Name="Inspectra 2.O",
                    About="Investigation game"
                },
                 new ProgramModel()
                {
                    ImgUrl="aqua.png",
                    Name="Inspectra 2.0",
                    About="About"
                },
                  new ProgramModel()
                {
                    ImgUrl="a.png",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },
                new ProgramModel()
                {
                    ImgUrl="b.png",
                    Name="DBmania",
                    About="Database Trails"
                },
                 new ProgramModel()
                {
                    ImgUrl="c.png",
                    Name="Inspectra 2.O",
                    About="Investigation game"
                },
                 new ProgramModel()
                {
                    ImgUrl="d.png",
                    Name="Inspectra 2.0",
                    About="About"
                },
                  new ProgramModel()
                {
                    ImgUrl="aqua.png",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },
                new ProgramModel()
                {
                    ImgUrl="idea1.png",
                    Name="DBmania",
                    About="Database Trails"
                },
                 new ProgramModel()
                {
                    ImgUrl="a.png",
                    Name="Inspectra 2.O",
                    About="Investigation game"
                },
                 new ProgramModel()
                {
                    ImgUrl="b.png",
                    Name="Inspectra 2.0",
                    About="About"
                },
                  new ProgramModel()
                {
                    ImgUrl="c.png",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },

                new ProgramModel()
                {
                    ImgUrl="d.png",
                    Name="Idea Slam",
                    About="Idea Pitching Contest"
                }

            };



            
            ShowCollectionView.ItemsSource = ShowData;
            CompCollectionView.ItemsSource = EventData;
            WorkShopCollectionView.ItemsSource = WorkShops;






        }

        private async void OnTapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListsPage());
        }

        private void ShowCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var x = e;
        }

        //private async void TapOn(object sender, EventArgs e)
        //{
        //    await Navigation.PopAsync();
        //}
    }
}