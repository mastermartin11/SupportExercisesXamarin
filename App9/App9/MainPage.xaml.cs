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
        public MainPage()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<Personas>

            {
            new Personas{Name = "Hulio",age = "32",OrderNumber = 1},
               new Personas{Name = "Ana",age = "22",OrderNumber = 2},
                new Personas{Name = "martin",age = "25",OrderNumber = 3},

           };
        }




             private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
            {
                var Selected = e.Item as Personas;

            Personas p1= new Personas();
                Navigation.PushModalAsync(new Page1(Selected));
               

            ((ListView)sender).SelectedItem = null;


            

        }

    }
}
