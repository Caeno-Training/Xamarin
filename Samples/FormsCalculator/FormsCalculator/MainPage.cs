using System;

using Xamarin.Forms;
using Calculator.Core;

namespace FormsCalculator
{
	public class MainPage : ContentPage
	{

		CalculatorService calcService;
		Label displayLabel;

		public MainPage() {
			calcService = new CalculatorService();
			calcService.TotalChanged += (sender, e) => {
				displayLabel.Text = calcService.Total.ToString();
			};

			displayLabel = new Label {
				FontAttributes = FontAttributes.Bold,
				FontSize = 32,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				HorizontalTextAlignment = TextAlignment.End,
				Text = "0",
			};

			Content = new StackLayout {
				Margin = new Thickness(16, 32),
				Children = {
					displayLabel,
					new StackLayout {
						VerticalOptions = LayoutOptions.CenterAndExpand,
						Children = {
							new StackLayout {
								Orientation = StackOrientation.Horizontal,
								HorizontalOptions = LayoutOptions.CenterAndExpand,
								Children = {
									CreateDigitButton(7),
									CreateDigitButton(8),
									CreateDigitButton(9),
									CreateOperationButton(Operation.Divide),
								}
							},
							new StackLayout {
								Orientation = StackOrientation.Horizontal,
								HorizontalOptions = LayoutOptions.CenterAndExpand,
								Children = {
									CreateDigitButton(4),
									CreateDigitButton(5),
									CreateDigitButton(6),
									CreateOperationButton(Operation.Multiply),
								}
							},
							new StackLayout {
								Orientation = StackOrientation.Horizontal,
								HorizontalOptions = LayoutOptions.CenterAndExpand,
								Children = {
									CreateDigitButton(1),
									CreateDigitButton(2),
									CreateDigitButton(3),
									CreateOperationButton(Operation.Subtract),
								}
							},
							new StackLayout {
								Orientation = StackOrientation.Horizontal,
								HorizontalOptions = LayoutOptions.CenterAndExpand,
								Children = {
									CreateDigitButton(0),
									CreateResetButton(),
									CreateEqualsButton(),
									CreateOperationButton(Operation.Sum),
								}
							},
						}
					}
				}
			};
		}

		Button CreateDigitButton(int digit) {
			var button = new Button { 
				BackgroundColor = Color.Gray,
				FontAttributes = FontAttributes.Bold,
				HeightRequest = 64,
				WidthRequest = 64,
				HorizontalOptions = LayoutOptions.Center,
				Text = $"{digit}",
				TextColor = Color.White,
			};
			button.Clicked += DigitClickedHandler;

			return button;
		}

		Button CreateOperationButton(Operation operation) {
			var button = new Button { 
				BackgroundColor = Color.Maroon,
				CommandParameter = (int)operation,
				FontAttributes = FontAttributes.Bold,
				HeightRequest = 64,
				WidthRequest = 64,
				HorizontalOptions = LayoutOptions.Center,
				Text = operation.GetOperationSign(),
				TextColor = Color.White,
			};
			button.Clicked += OperationClickedHandler;

			return button;
		}

		Button CreateEqualsButton() {
			var button = new Button {
				BackgroundColor = Color.Maroon,
				FontAttributes = FontAttributes.Bold,
				HeightRequest = 64,
				WidthRequest = 64,
				HorizontalOptions = LayoutOptions.Center,
				Text = "=",
				TextColor = Color.White,
			};
			button.Clicked += EqualClickedHandler;

			return button;
		}

		Button CreateResetButton() {
			var button = new Button {
				BackgroundColor = Color.Maroon,
				FontAttributes = FontAttributes.Bold,
				HeightRequest = 64,
				WidthRequest = 64,
				HorizontalOptions = LayoutOptions.Center,
				Text = "AC",
				TextColor = Color.White,
			};
			button.Clicked += ResetClickedHandler;

			return button;			
		}


		void DigitClickedHandler(object sender, EventArgs args) {
			var button = (Button)sender;
			var digit = Convert.ToInt32(button.Text);

			calcService.AddDigit(digit);
		}

		void OperationClickedHandler(object sender, EventArgs args) {
			var button = (Button)sender;
			var operation = (Operation)Convert.ToInt32(button.CommandParameter);

			calcService.SetOperation(operation);
		}

		void EqualClickedHandler(object sender, EventArgs args) {
			calcService.PerformOperation();
		}

		void ResetClickedHandler(object sender, EventArgs args) {
			calcService.Reset();
		}

	}
}

