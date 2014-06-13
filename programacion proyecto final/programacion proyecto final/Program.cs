/*
 * Creado por SharpDevelop.
 * Usuario: Nano
 * Fecha: 12/06/2014
 * Hora: 11:03 p.m.
 */
using System;
using System.Windows.Forms;

namespace programacion_proyecto_final
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
