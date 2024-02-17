using System;
using System.Windows.Forms;

// Token: 0x02000004 RID: 4
internal static class Class1
{
	// Token: 0x0600000B RID: 11 RVA: 0x00002198 File Offset: 0x00000398
	[STAThread]
	private static void Main()
	{
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(false);
		Application.Run(new FormMain());
	}
}
