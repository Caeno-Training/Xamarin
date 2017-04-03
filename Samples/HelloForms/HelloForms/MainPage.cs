using System;

using Xamarin.Forms;

namespace HelloForms
{
	public class MainPage : ContentPage
	{

		/// <summary>
		/// Uma caixa de texto para entrada do nome do usuário.
		/// </summary>
		Entry nameEntry;

		public MainPage() {

			//
			// Inicializa os componentes que serão usados nessa página

			// Inicializa a caixa de texto para digitação do nome
			nameEntry = new Entry {
				Placeholder = "Nome",
				HorizontalOptions = LayoutOptions.FillAndExpand,
			};

			// Cria e inicializa um botão. Não é necessário manter a referência para ele
			//	por isso ele é criado como variável local
			var button = new Button {
				HorizontalOptions = LayoutOptions.End,
				Text = "Enviar"
			};
			button.Clicked += SendClickedHandler;

			// Atribuímos um StackLayout a propriedade "Content" dessa página
			// Esse layout empilha verticalmente os elementos 'filhos'.
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Margin = new Thickness(16, 0, 16, 0),
				Children = {
					new Label { 
						FontAttributes = FontAttributes.Bold,
						Text = "Diga seu nome!" 
					},
					nameEntry,
					button,
				}
			};
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

