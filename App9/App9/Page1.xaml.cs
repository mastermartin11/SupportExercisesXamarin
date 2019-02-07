using App9.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App9
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
        Personas p1;
		public Page1 (Personas p)
		{
            InitializeComponent();
            p1 = p;
            nombre.Text = p.Name;
            edad.Text = p.age;

        }

	}
}