using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace up
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            //MainPage = new NavigationPage(new MainPage());
        }

        private void OnSignInButtonClicked(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (username == "admin" && password == "passwd")
            {
                DisplayAlert("Login", "Login success", "OK");                
                Application.Current.MainPage = new HomePage();

                //NavigationPage HomePage = new NavigationPage(new HomePage());
                //await Navigation.PushAsync(new HomePage());
            }
            else
            {                
                DisplayAlert("Login", "Login failed", "OK");                
                passwordEntry.Text = string.Empty;
            }
        }
    }
}
