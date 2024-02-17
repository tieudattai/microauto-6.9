using System;
using System.Windows.Forms;

internal static class s
{
	[STAThread]
	private static void a()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		Application.Run(new u());
	}
}
