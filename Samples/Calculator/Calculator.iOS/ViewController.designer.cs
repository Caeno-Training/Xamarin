// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Calculator.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ClearButton { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField DisplayTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton EqualsButton { get; set; }

        [Action ("ClearButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ClearButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("DigitPressedHandler:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void DigitPressedHandler (UIKit.UIButton sender);

        [Action ("EqualsButton_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void EqualsButton_TouchUpInside (UIKit.UIButton sender);

        [Action ("OperationPressedHandler:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void OperationPressedHandler (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (ClearButton != null) {
                ClearButton.Dispose ();
                ClearButton = null;
            }

            if (DisplayTextField != null) {
                DisplayTextField.Dispose ();
                DisplayTextField = null;
            }

            if (EqualsButton != null) {
                EqualsButton.Dispose ();
                EqualsButton = null;
            }
        }
    }
}