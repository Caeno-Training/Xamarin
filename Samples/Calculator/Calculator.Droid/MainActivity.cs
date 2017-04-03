using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Views;
using Android.Provider;
using Java.Interop;
using Calculator.Core;

namespace Calculator
{
	[Activity(Label = "Calculator", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		CalculatorService calcService = new CalculatorService();
		EditText displayEditText;

		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Obtém as referências
			displayEditText = FindViewById<EditText>(Resource.Id.displayEditText);

			// Configura o modelo
			calcService.TotalChanged += (sender, e) => {
				displayEditText.Text = calcService.Total.ToString();
			};
		}

		[Export("OperationClicked")]
		public void OperationClicked(View view) {
			var button = (Button)view;
			var operation = (Operation)Convert.ToInt32(button.Tag.ToString());
			calcService.SetOperation(operation);
		}

		[Export("DigitClicked")]
		public void DigitClicked(View view) {
			var button = (Button)view;
			var digit = Convert.ToInt32(button.Text);
			calcService.AddDigit(digit);
		}

		[Export("ResetClicked")]
		public void ResetClicked(View view) {
			calcService.Reset();
		}

		[Export("EqualsClicked")]
		public void EqualsClicked(View view) {
			calcService.PerformOperation();
		}

	}
}

