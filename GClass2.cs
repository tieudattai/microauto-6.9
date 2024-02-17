using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000010 RID: 16
public class GClass2
{
	// Token: 0x06000158 RID: 344
	[DllImport("user32.dll")]
	private static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

	// Token: 0x06000159 RID: 345 RVA: 0x00003B67 File Offset: 0x00001D67
	public static void smethod_0(int int_0, int int_1)
	{
		Cursor.Position = new Point(int_0, int_1);
		GClass2.mouse_event(2, 0, 0, 0, 0);
		GClass2.mouse_event(4, 0, 0, 0, 0);
	}

	// Token: 0x02000011 RID: 17
	[Flags]
	public enum GEnum0
	{
		// Token: 0x040000DA RID: 218
		flag_0 = 2,
		// Token: 0x040000DB RID: 219
		flag_1 = 4,
		// Token: 0x040000DC RID: 220
		flag_2 = 32,
		// Token: 0x040000DD RID: 221
		flag_3 = 64,
		// Token: 0x040000DE RID: 222
		flag_4 = 1,
		// Token: 0x040000DF RID: 223
		flag_5 = 32768,
		// Token: 0x040000E0 RID: 224
		flag_6 = 8,
		// Token: 0x040000E1 RID: 225
		flag_7 = 16
	}
}
