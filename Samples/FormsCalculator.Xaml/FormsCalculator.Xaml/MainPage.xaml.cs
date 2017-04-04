using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Calculator.Core;

namespace FormsCalculator.Xaml
{
	public partial class MainPage : ContentPage
	{
		CalculatorService calcService = new CalculatorService();

		public MainPage() {
			InitializeComponent();

			calcService.TotalChanged += (sender, e) => {
				displayLabel.Text = $"{calcService.Total}";
			};
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
