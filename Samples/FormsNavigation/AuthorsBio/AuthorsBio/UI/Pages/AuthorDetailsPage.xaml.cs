using System;
using System.Collections.Generic;

using Xamarin.Forms;
using AuthorsBio.Model;
using System.Linq;

namespace AuthorsBio.UI.Pages
{
    public partial class AuthorDetailsPage : ContentPage
    {

        Author author;

        public AuthorDetailsPage()
        {
            InitializeComponent();
        }

        public AuthorDetailsPage(int authorId)
        {
            InitializeComponent();

            // Obtém o autor a partir do "banco de dados"
            author = DataContext.Database.First(a => a.Id == authorId);

            // Carrega as informações na tela
            pictureImage.Source = author.PictureUrl;
            bioLabel.Text = author.Bio;
        }

        async void OnWikipediaClicked(object source, EventArgs args) {
            await Navigation.PushAsync(new WikipediaViewerPage(author));
        }

    }
}
