using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App12
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}


        async void Login_Clicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = UserNameEntry.Text,
                Password = PasswordEntry.Text
            };

            var isVaild = AreCredentialsCorrect(user);
            if (isVaild)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
               
            }
            else
            {
                if (user.Username != Constants.Username)
                {
                    LoginFail.Text = "usuario incorrecto";
                    UserNameEntry.Text = string.Empty;
                    UserNameEntry.BackgroundColor = Color.Red;
                }

                if (user.Password != Constants.Password)
                {
                    PassFail.Text = "Password incorrecta";
                    PasswordEntry.Text = string.Empty;
                    PasswordEntry.BackgroundColor = Color.Red;
                }
            }

         
        }

        bool AreCredentialsCorrect(User user)
        {
            return user.Username == Constants.Username && user.Password == Constants.Password;

        }


    }
}