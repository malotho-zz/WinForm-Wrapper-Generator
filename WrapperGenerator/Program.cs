using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace WrapperGenerator.UI
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main ()
		{
			Application.ThreadException += Program.OnThreadException;
			AppDomain.CurrentDomain.UnhandledException += Program.OnUnhandledException;

			Application.EnableVisualStyles ();
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new View ());
		}

		private static void OnThreadException (object sender, ThreadExceptionEventArgs e)
		{
			Program.DisplayGenericError (e.Exception);
		}

		private static void OnUnhandledException (object sender, UnhandledExceptionEventArgs e)
		{
			Program.DisplayGenericError (e.ExceptionObject);
		}

		private static void DisplayGenericError (object error)
		{
			string message = "An unexpected error has occurred. The application may be in an unusable state." + Environment.NewLine + Environment.NewLine + error;
			MessageBox.Show (message, "Unknown Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
		}
	}
}