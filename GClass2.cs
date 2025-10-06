using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;


public class GClass2
{
	
	[DllImport("user32.dll")]
	private static extern void mouse_event(int int_0, int int_1, int int_2, int int_3, int int_4);

	
	public static void smethod_0(int int_0, int int_1)
	{
		Cursor.Position = new Point(int_0, int_1);
		GClass2.mouse_event(2, 0, 0, 0, 0);
		GClass2.mouse_event(4, 0, 0, 0, 0);
	}

	
	[Flags]
	public enum GEnum0
	{
		
		flag_0 = 2,
		
		flag_1 = 4,
		
		flag_2 = 32,
		
		flag_3 = 64,
		
		flag_4 = 1,
		
		flag_5 = 32768,
		
		flag_6 = 8,
		
		flag_7 = 16
	}
}
