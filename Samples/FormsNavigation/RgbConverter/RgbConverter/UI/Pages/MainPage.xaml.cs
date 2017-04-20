using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Linq;

namespace RgbConverter.UI.Pages
{
    public partial class MainPage : TabbedPage
    {

        int red, green, blue;
        
        public MainPage()
        {
            InitializeComponent();
        }

        void OnRgbEntryChanged(object sender, TextChangedEventArgs args) {
            var entry = sender as Entry;

            // Usa o recurso "out variables" do C# para tentar converter em inteiro
            //  o valor digitado no Entry
            if (int.TryParse(entry.Text, out var val) &&
                val >= 0 && val <= 255)
            {
                // Usa a propriedade StyleId para determinar qual dos entries disparou o evento
                switch (entry.StyleId)
                {
                    case "Red":
                        red = val;
                        break;
                    case "Green":
                        green = val;
                        break;
                    case "Blue":
                        blue = val;
                        break;
                }

                // Atualiza a tela
                CalculateHex();
            } else {
                hexValueLabel.Text = "Valor inválido!";
            }
        }

		readonly static char[] validHex = "0123456789ABCDEF".ToCharArray();
        void OnHexEntryChanged(object sender, TextChangedEventArgs args) {
            if (rgbValueLabel == null)
                return;

            var entry = sender as Entry;

            // Verifica se é uma string hexadecimal válida
            if (entry.Text.Length != 6 || !IsValidHex()) {
                rgbValueLabel.Text = "Valor inválido!";
                return;
            }

            CalculateRgb();

			bool IsValidHex() {
                var isValid = true;
				foreach (var c in entry.Text) {
					if (!validHex.Any(d => d == c)) {
						isValid = false;
						break;
					}
				}

				return isValid;
			}
		}


		void CalculateHex()
        {
            // Tratamento de chamada antes da árvore de UI estar pronta
            if (hexValueLabel == null || hexColorBox == null)
                return;

            // Obtém a cor e atualiza os elementos de tela
            var color = Color.FromRgb(red, green, blue);
            hexValueLabel.Text = $"#{(int)(color.R * 255):X2}{(int)(color.G * 255):X2}{(int)(color.B * 255):X2}";
            hexColorBox.Color = color;
        }

        void CalculateRgb() {
            if (rgbValueLabel == null || rgbColorBox == null)
                return;

            var color = Color.FromHex($"#{hexEntry.Text}");
            rgbValueLabel.Text = $"RGB ({(int)(color.R * 255)}, {(int)(color.G * 255)}, {(int)(color.B * 255)})";
            rgbColorBox.Color = color;
        }

    }
}
