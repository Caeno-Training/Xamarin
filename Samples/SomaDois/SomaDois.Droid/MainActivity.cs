using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace SomaDois
{
	[Activity(Label = "SomaDois", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		EditText firstNumberEditText;
		EditText secondNumberEditText;
		TextView resultTextView;

		
		protected override void OnCreate(Bundle savedInstanceState) {
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Obter as referências
			firstNumberEditText = FindViewById<EditText>(Resource.Id.firstNumberEditText);
			secondNumberEditText = FindViewById<EditText>(Resource.Id.secondNumberEditText);
			resultTextView = FindViewById<TextView>(Resource.Id.resultTextView);

			var button = FindViewById<Button>(Resource.Id.calculateButton);
			button.Click += Button_Click;
		}

		void Button_Click(object sender, System.EventArgs e) {
			var n1 = Convert.ToInt32(firstNumberEditText.Text);
			var n2 = int.Parse(secondNumberEditText.Text);
			var result = $"O resultado é {n1 + n2}.";

			resultTextView.Text = result;
			Toast.MakeText(this, result, ToastLength.Long).Show();
		}

	}
}

