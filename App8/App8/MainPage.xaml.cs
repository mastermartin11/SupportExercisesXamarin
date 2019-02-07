using App8.classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App8
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<ListViewTemplate>

            {
            new ListViewTemplate
                {
                Name = "Xamarin.Forms",
                    Description = "One",
                    OrderNumber = 1
               },
               new ListViewTemplate
               {
                   Name = "Android",
                   Description = "Two",
                   OrderNumber = 2
                },
                new ListViewTemplate
                {
                    Name = "IOS",
                    Description = "Three",
                    OrderNumber = 3
               },
               new ListViewTemplate
               {
                   Name = "Windows",
                   Description = "Four",
                   OrderNumber = 4
               }
           };
        }
    }
}
