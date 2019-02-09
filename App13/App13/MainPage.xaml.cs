using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App13
{
    public partial class MainPage : ContentPage
    {

        List<string> lista = new List<string>();

        public MainPage()
        {
            InitializeComponent();


            lista.Add("batman");
            lista.Add("harley quinn");
            lista.Add("joker");
            listaXaml.ItemsSource = lista;

            listaXaml.RefreshCommand = new Command(() => {
                  
                RefreshData();
                listaXaml.IsRefreshing = false;
            });

            
        }
        public void RefreshData()
        {
            String nombre = "bane";
            if (!lista.Last().Equals(nombre)){ 
            lista.Add(nombre);}
            listaXaml.ItemsSource = null;
            listaXaml.ItemsSource = lista;
        }
    }
}
