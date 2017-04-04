using System;

namespace Calculator.Core
{
	public class CalculatorService
	{

		int _number;            // Número que esta sendo digitado
		int _newNumber;
		Operation? operation;
		bool resetDisplay;


		private int _total;
		/// <summary>
		/// Obtém o total atual.
		/// </summary>
		public int Total {
			get { return _total; }
			private set {
				_total = value;
				TotalChanged?.Invoke(this, EventArgs.Empty);
			}
		}

		public event EventHandler TotalChanged;


		#region Métodos Públicos

		public void AddDigit(int digit) {
			if (resetDisplay) {
				_number = digit;
				resetDisplay = false;
			} else {
				_number = (_number * 10) + digit;
			}

			Total = _number;
		}

		public void SetOperation(Operation operation) {
			this.operation = operation;
			_newNumber = _number;
			_number = 0;
			resetDisplay = true;
		}

		public void PerformOperation() {
			if (operation.HasValue) {
				switch (operation) {
					case Operation.Sum:
						Total = _newNumber + _number;
						break;
					case Operation.Subtract:
						Total = _newNumber - _number;
						break;
					case Operation.Multiply:
						Total = _newNumber * _number;
						break;
					case Operation.Divide:
						Total = _newNumber / _number;
						break;
					case Operation.Power:
						Total = (int)Math.Pow(_newNumber, _number);
						break;
				}

				// Re-iniciar o estado da calculadora
				_number = 0;
				_newNumber = 0;
				resetDisplay = true;
				operation = null;
			}
		}

		public void Reset() {
			Total = 0;
			_number = 0;
			_newNumber = 0;
			operation = null;
			resetDisplay = true;
		}

		#endregion

	}

}
