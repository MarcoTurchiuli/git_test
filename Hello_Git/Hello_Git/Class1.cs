using System;

namespace Hello_Git
{
	/// <summary>
	/// Descrizione di riepilogo per Class1.
	/// </summary>
	class Class1
	{
		/// <summary>
		/// Il punto di ingresso principale dell'applicazione.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
			//Questo commento LF
			Console.Write("ciao git!! seconda volta");
			Login login = new Login();
			Console.ReadLine();
		}
	}
}
