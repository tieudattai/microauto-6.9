using System;
using System.Runtime.InteropServices;

// Token: 0x02000019 RID: 25
internal class Class9
{
	// Token: 0x0600018D RID: 397
	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	public static extern bool SendMessage(IntPtr intptr_0, int int_6, int int_7, int int_8);

	// Token: 0x0600018E RID: 398
	[DllImport("user32.dll", SetLastError = true)]
	public static extern bool BringWindowToTop(IntPtr intptr_0);

	// Token: 0x0600018F RID: 399
	[DllImport("user32.dll")]
	public static extern bool ShowWindow(IntPtr intptr_0, int int_6);

	// Token: 0x06000190 RID: 400
	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr intptr_0);

	// Token: 0x06000191 RID: 401
	[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	public static extern void mouse_event(int int_6, uint uint_0, uint uint_1, uint uint_2, uint uint_3);

	// Token: 0x040000F5 RID: 245
	public static int int_0 = 256;

	// Token: 0x040000F6 RID: 246
	public static int int_1 = 257;

	// Token: 0x040000F7 RID: 247
	public static int int_2 = 2;

	// Token: 0x040000F8 RID: 248
	public static int int_3 = 4;

	// Token: 0x040000F9 RID: 249
	public static int int_4 = 8;

	// Token: 0x040000FA RID: 250
	public static int int_5 = 16;
}
