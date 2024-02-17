using System;
using System.Runtime.InteropServices;

internal class i
{
	public static int a;

	public static int b;

	public static int c;

	public static int d;

	public static int e;

	public static int f;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool SendMessage(IntPtr A_0, int A_1, int A_2, int A_3);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool BringWindowToTop(IntPtr A_0);

	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr A_0, int A_1);

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr A_0);

	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(int A_0, uint A_1, uint A_2, uint A_3, uint A_4);

	static i()
	{
		if (true)
		{
		}
		a = 256;
		b = 257;
		c = 2;
		d = 4;
		e = 8;
		f = 16;
	}
}
