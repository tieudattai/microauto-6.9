using System;
using System.Runtime.InteropServices;
using System.Text;


public class GClass4
{
	
	public static string smethod_0()
	{
		return Class8.smethod_2();
	}

	
	public static void smethod_1()
	{
		GClass4.mciSendString("open \"" + GClass4.smethod_0() + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
	}

	
	public static void smethod_2()
	{
		GClass4.smethod_4();
		GClass4.smethod_1();
		GClass4.mciSendString("play MediaFile", null, 0, IntPtr.Zero);
	}

	
	public static void smethod_3()
	{
		try
		{
			GClass4.mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
		}
		catch
		{
		}
	}

	
	public static void smethod_4()
	{
		try
		{
			GClass4.mciSendString("close MediaFile", null, 0, IntPtr.Zero);
		}
		catch
		{
		}
	}

	
	[DllImport("winmm.dll")]
	public static extern long mciSendString(string string_0, StringBuilder stringBuilder_0, int int_0, IntPtr intptr_0);
}
