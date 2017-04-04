using System;

namespace Calculator.Core
{

	/// <summary>
	/// Operações suportadas pelo serviço de calculadora
	/// </summary>
	public enum Operation
	{
		/// <summary>
		/// Soma
		/// </summary>
		Sum = 1,

		/// <summary>
		/// Subtração
		/// </summary>
		Subtract,

		/// <summary>
		/// Multiplicação
		/// </summary>
		Multiply,

		/// <summary>
		/// Divisão
		/// </summary>
		Divide,

		/// <summary>
		/// Performs the Power Operation.
		/// </summary>
		Power,
	}

	/// <summary>
	/// Métodos de Extensão para a enumeração 'Operation'.
	/// </summary>
	public static class OperationExtensions {

		/// <summary>
		/// Obtém o sinal matemático relativo a operação.
		/// </summary>
		/// <returns>O sinal matemático da operação.</returns>
		/// <param name="operation">Operation.</param>
		public static string GetOperationSign(this Operation operation) {
			switch (operation) {
				case Operation.Sum:
					return "+";
				case Operation.Subtract:
					return "−";
				case Operation.Multiply:
					return "×";
				case Operation.Divide:
					return "÷";
				case Operation.Power:
					return "xʸ";
				default:
					return "?";
			}
		}

	}

}
