using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App27
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Deportista d1 = new Deportista(1,"hulio","tenis",25);
            Deportista d2 = new Deportista(1,"ana","tenis",25);

            Label l1 = new Label();
            Label l2 = new Label();
            l1.Text = d1.ToString();
            l2.Text = d2.ToString();

            l1.Text = d1.ToString();
            Grid.SetRow(l1, 0);
            Grid.SetColumn(l1, 0);
            gridDeporte.Children.Add(l1);

            l2.Text = d2.ToString();
            Grid.SetRow(l2, 1);
            Grid.SetColumn(l2, 0);
            gridDeporte.Children.Add(l2);

        }
    }
}
