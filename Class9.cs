using System;
using System.Runtime.InteropServices;


internal class Class9
{
	
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool SendMessage(IntPtr intptr_0, int int_6, int int_7, int int_8);

	
	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool BringWindowToTop(IntPtr intptr_0);

	
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr intptr_0, int int_6);

	
	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr intptr_0);

	
	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(int int_6, uint uint_0, uint uint_1, uint uint_2, uint uint_3);

	
	public static int int_0 = 256;

	
	public static int int_1 = 257;

	
	public static int int_2 = 2;

	
	public static int int_3 = 4;

	
	public static int int_4 = 8;

	
	public static int int_5 = 16;
}
