using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App16
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void nuevoLabel(object sender, EventArgs e)
        {
            var label = new Label();
            label.Text = "batman";

            layout.Children.Add(label);
            this.Content = layout;

        }
    }
}
