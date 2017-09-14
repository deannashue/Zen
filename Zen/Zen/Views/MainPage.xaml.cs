using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Zen.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Register_Clicked(object sender, EventArgs e)
        {
            Register.TextColor = Xamarin.Forms.Color.FromHex("fff200");
            DisplayAlert("Hi", "Do Register", "cancel");

        }

        async private void Guest_Clicked(object sender, EventArgs e)
        {
            Guest.TextColor = Xamarin.Forms.Color.FromHex("fff200");
            //DisplayAlert("Hi", "Do Guest", "cancel");
            await Navigation.PushAsync(new Guest());
            
             

        }

    }
}
