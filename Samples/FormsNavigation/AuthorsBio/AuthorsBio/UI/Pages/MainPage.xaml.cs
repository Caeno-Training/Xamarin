using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AuthorsBio.UI.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnAuthorClicked(object sender, EventArgs args) {
            var button = sender as Button;
            if (button != null) {
                var id = Convert.ToInt32(button.CommandParameter);
                await Navigation.PushAsync(new AuthorDetailsPage(id));
            }
        }

    }
}
