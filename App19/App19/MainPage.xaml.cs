using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App19
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            activity.IsEnabled = true;
            activity.IsRunning = true;
            activity.IsVisible = true;


            parar();
        }

        public void parar()
        {
            System.Threading.Thread.Sleep(30000);

            activity.IsEnabled = false;
            activity.IsRunning = false;
            activity.IsVisible = false;
        }


    } 
    }
