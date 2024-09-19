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
			// Stampa il messaggio originale
			Console.Write("ciao git!!");

			// Creazione dell'istanza della classe Login
			Login login = new Login();

			// Mantiene aperta la finestra della console fino a quando non viene premuto un tasto
			Console.ReadLine();
		}
	}
}
