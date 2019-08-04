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
                "Webdevelopment","Webdevelopment Using Python","webdevelopment", "webdevelopment","webdevelopment.svg","webdevelopment.svg"
            };



            



            List<string> Talks = new List<string>
            {
               "Webdevelopment","Webdevelopment","webdevelopment", "webdevelopment.svg","webdevelopment.svg","webdevelopment.svg"
            };



            



         

            List<ProgramModel> ShowData = new List<ProgramModel>()
            {
                new ProgramModel()
                {
                    ImgUrl="inspectra.svg",
                    Name="Inspectra 2.0",
                    About="About"
                },
                  new ProgramModel()
                {
                    ImgUrl="googler.svg",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },
                new ProgramModel()
                {
                    ImgUrl="dbmania.svg",
                    Name="DBmania",
                    About="Database Trails"
                },
                new ProgramModel()
                {
                    ImgUrl="inspectra.svg",
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
              
            };


            List<ProgramModel> EventData = new List<ProgramModel>()
            {
                new ProgramModel()
                {
                    ImgUrl="inspectra.svg",
                    Name="Inspectra 2.O",
                    About="Investigation game"
                },
                new ProgramModel()
                {
                    ImgUrl="googler.svg",
                    Name="Googler 2.O",
                    About="Googling Contest"
                },
                new ProgramModel()
                {
                    ImgUrl="dbmania.svg",
                    Name="DBmania",
                    About="Database Trails"
                },
               
                new ProgramModel()
                {
                    ImgUrl="coderelay.svg",
                    Name="Code Relay",
                    About="Team Coding"
                },
                new ProgramModel()
                {
                    ImgUrl="ideaslam.svg",
                    Name="Idea Slam",
                    About="Idea Pitching Contest"
                },

            };



            WorkShopCollectionView.ItemsSource = Workshops;
            ShowCollectionView.ItemsSource = ShowData;
            CompCollectionView.ItemsSource = EventData;
            TalksCollectionView.ItemsSource = Talks;


          

        }
        
    }
}