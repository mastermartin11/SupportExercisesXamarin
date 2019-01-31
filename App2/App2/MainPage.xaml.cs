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

        private Random rnd = new Random();

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await LabelText.RotateTo(360, 500, Easing.SinOut);

            LabelText.Animate("ColorAnimation", (value) => LabelText.BackgroundColor = RandomColor(value));

            await LabelText.RotateTo(-360, 500, Easing.SpringOut);

            
        }

        private Color RandomColor(double value)
        {            
            System.Diagnostics.Debug.WriteLine($"Value: {value}");                       
            return new Color(rnd.NextDouble(), rnd.NextDouble(), rnd.NextDouble());
        }

    }
}
