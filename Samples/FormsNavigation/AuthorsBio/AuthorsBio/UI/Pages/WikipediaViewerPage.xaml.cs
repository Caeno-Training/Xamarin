using System;
using System.Collections.Generic;

using Xamarin.Forms;
using AuthorsBio.Model;

namespace AuthorsBio.UI.Pages
{
    public partial class WikipediaViewerPage : ContentPage
    {

        public WikipediaViewerPage()
        {
            InitializeComponent();
        }

        public WikipediaViewerPage(Author author)
        {
            InitializeComponent();

            // Título que irá aparecer na barra de navegação
            Title = author.Name;

            // Abre a página da Wikipedia no WebView
			webView.Source = author.WikipediaUrl;
		}

    }
}
