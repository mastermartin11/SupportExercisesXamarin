using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App18
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        protected override bool OnBackButtonPressed()
        {
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result= await this.DisplayAlert("salir", "seguro que quieres salir", "si", "no");
                if (result) await this.Navigation.PopAsync();
            });
            return true;
        }
    }
}
