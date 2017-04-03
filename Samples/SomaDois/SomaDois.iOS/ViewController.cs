using System;

using UIKit;

namespace SomaDois.iOS
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle) {
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		partial void CalculateButton_TouchUpInside(UIButton sender) {
			var n1 = 0;
			int n2 = 0;

			// Tenta obter os números convertidos como inteiros
			if (int.TryParse(FirstNumberTextField.Text, out n1) &&
			    int.TryParse(SecondNumberTextField.Text, out n2)) {

				ResultLabel.Text = $"{n1 + n2}";
			} else {
				// Apresenta uma mensagem de erro
				new UIAlertView("Opa!",
								"Digite um número valido, companheiro!",
								null, "OK", null).Show();
			}
		}

	}
}
