using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HelloForms.CSharp
{
	public partial class MainPage : ContentPage
	{
		public MainPage() {
			InitializeComponent();
		}

		/// <summary>
		/// Event Handler para clique do botão Enviar.
		/// </summary>
		void SendClickedHandler(object sender, EventArgs e) {
			// Apresenta uma caixa de alerta no padrão do sistema nativo
			DisplayAlert("Olá!", $"Olá {nameEntry.Text}, seja bem-vindo ao Xamarin.Forms!", "OK");
		}

	}
}
