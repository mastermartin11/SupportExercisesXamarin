﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App10
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
        }

        public void modifica(object sender, TextChangedEventArgs e)
        {
            
            salida.Placeholder = entrada.Text;

        }
    }
}
