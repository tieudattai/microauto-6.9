using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class g
{
	[Flags]
	public enum a
	{
		a = 2,
		b = 4,
		c = 0x20,
		d = 0x40,
		e = 1,
		f = 0x8000,
		g = 8,
		h = 0x10
	}

	[DllImport("user32.dll")]
	private static extern void mouse_event(int A_0, int A_1, int A_2, int A_3, int A_4);

	public static void a(int A_0, int A_1)
	{
		if (true)
		{
		}
		Cursor.Position = new Point(A_0, A_1);
		mouse_event(2, 0, 0, 0, 0);
		mouse_event(4, 0, 0, 0, 0);
	}
}
