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
         
            List<string> Workshops = new List<string>
            {
                "webdevelopment.svg","webdevelopment.svg","webdevelopment.svg", "webdevelopment.svg","webdevelopment.svg","webdevelopment.svg"
            };



            



            List<string> Talks = new List<string>
            {
               "webdevelopment.svg","webdevelopment.svg","webdevelopment.svg", "webdevelopment.svg","webdevelopment.svg","webdevelopment.svg"
            };



            



            //List<string> Comp = new List<string>
            //{
            //    "coderelay.svg","dbmania.svg","inspecta.svg","coderelay.svg","dbmania.svg","inspecta.svg"

            //};
            //List<string> Names = new List<string>
            //{
            //    "code","dbmania","inspecta","coderelay","dbmania","inspecta"

            //};
            //List<string> Abouts = new List<string>
            //{
            //    "dbmania","inspecta","coderelay","dbmania","inspecta","coderelay"

            //};




            //CompCollectionView.ItemsSource = Comp;
            //CompCollectionView.ItemsSource = Names; 
            //CompCollectionView.ItemsSource = Abouts;

            List<ProgramModel> CompetionData = new List<ProgramModel>()
            {
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                }
            };


            List<ProgramModel> EventData = new List<ProgramModel>()
            {
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                },
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="About"
                }
            };



            WorkShopCollectionView.ItemsSource = Workshops;
            CompCollectionView.ItemsSource = CompetionData;
            MainCollectionView.ItemsSource = EventData;
            TalksCollectionView.ItemsSource = Talks;


            //List<string> Competition = new List<string>
            //{
            //    "coderelay.svg","dbmania.svg","inspecta.svg","coderelay.svg","dbmania.svg","inspecta.svg"



            //};
            //MainCollectionView.ItemsSource = Competition;
            //List<string> Name = new List<string>
            //{
            //    "code","dbmania","inspecta","coderelay","dbmania","inspecta"
            //};
            //List<string> About = new List<string>
            //{
            //   "dbmania","inspecta","coderelay","dbmania","inspecta","coderelay"
            //};
            //MainCollectionView.ItemsSource = Name;

            //MainCollectionView.ItemsSource = About;

        }
        
    }
}