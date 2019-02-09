using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App22
{
    public partial class MainPage : ContentPage
    {
        ArrayList listilla = new ArrayList();
        

        public MainPage()
        {
            InitializeComponent();

            Cliente c1 = new Cliente("hulio","123");
            Proveedor p1 = new Proveedor("martin","cosplay");
            Proveedor p2 = new Proveedor("ana","motos");

            listilla.Add(c1);
            listilla.Add(p1);
            listilla.Add(p2);
            MainListView.ItemsSource = listilla;


        }
    }
}
