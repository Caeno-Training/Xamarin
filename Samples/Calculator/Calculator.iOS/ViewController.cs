using System;

using UIKit;
using Calculator.Core;

namespace Calculator.iOS
{
	public partial class ViewController : UIViewController
	{

		CalculatorService calcService = new CalculatorService();

		protected ViewController(IntPtr handle) : base(handle) {
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();

			calcService.TotalChanged += (sender, e) => {
				DisplayTextField.Text = calcService.Total.ToString();
			};
		}

		partial void DigitPressedHandler(UIButton sender) {
			var digit = Convert.ToInt32(sender.Title(UIControlState.Normal));

			// Atualizar o Display
			calcService.AddDigit(digit);
		}

		partial void OperationPressedHandler(UIButton sender) {
		 	var val = (int)sender.Tag;
			var operation = (Operation)val;

			// Aplicar operação
			calcService.SetOperation(operation);
		}

		partial void ClearButton_TouchUpInside(UIButton sender) {
			calcService.Reset();
		}

		partial void EqualsButton_TouchUpInside(UIButton sender) {
			calcService.PerformOperation();
		}

	}
}
