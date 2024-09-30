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
			//modificato il commento, modificato il valore di i e rimosso l'ultimo commento
			//Questo commento MT
			int i = 555; 
			Console.Write("ciao git!! test2");
			Login login = new Login();
			Console.ReadLine();
		}
	}
}
