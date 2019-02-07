using App9.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App9
{
    public partial class MainPage : ContentPage
    {
        List<Personas> listaP= new List<Personas>
        {
            new Personas{Name = "hulio",age = "32",OrderNumber = 1, foto="superman.jpg"},
               new Personas{Name = "ana",age = "22",OrderNumber = 2 ,foto="wonder.jpg"},
                new Personas{Name = "martin",age = "25",OrderNumber = 3,foto="bat.Jpg"}

           };

        public MainPage()
        {
            InitializeComponent();

            MainListView.ItemsSource = listaP;




        }

        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as Personas;

            await Navigation.PushAsync(new Page1(Selected));


            ((ListView)sender).SelectedItem = null;


        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
           

            if (string.IsNullOrEmpty(e.NewTextValue))
            {
                MainListView.ItemsSource = listaP;
            }

            else
            {
                MainListView.ItemsSource = listaP.Where(x => x.Name.StartsWith(e.NewTextValue));
            }
        }



    }
}
