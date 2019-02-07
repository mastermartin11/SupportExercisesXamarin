using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await LabelText.TranslateTo(0, -40, 500, Easing.SinIn);
            await LabelText.RotateTo(360, 500, Easing.SinOut);
            await LabelText.RotateTo(-360, 500, Easing.SpringOut);
            await LabelText.TranslateTo(0, 40, 500, Easing.SinOut);

        }
    }
}
