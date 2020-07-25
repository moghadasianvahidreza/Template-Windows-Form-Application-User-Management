using System;
using System.Windows.Forms;

namespace MyApplication
{
	internal static class Program
	{ 
		static Program()
		{
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// **************************************************
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			// **************************************************

			// **************************************************
			MainForm startupForm = new MainForm();

			Application.Run(startupForm);

			if (startupForm != null)
			{
				if (startupForm.IsDisposed == false)
				{
					startupForm.Dispose();
				}
			}
			// **************************************************
		}
	}
}
