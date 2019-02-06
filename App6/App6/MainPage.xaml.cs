using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App6
{
    public partial class MainPage :MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new homepage());
          

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new batpage());
            IsPresented = false;
        }
        private void Button_Clicked2(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new superpage());
            IsPresented = false;
        }

        private void Button_Clicked3(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new wonderpage());
            IsPresented = false;
        }

    }
}
