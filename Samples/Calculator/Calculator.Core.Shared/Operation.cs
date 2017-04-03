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

}
