using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

public class l
{
	[SpecialName]
	public static string e()
	{
		return global::b.c();
	}

	public static void d()
	{
		mciSendString("open \"" + e() + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
	}

	public static void c()
	{
		a();
		d();
		mciSendString("play MediaFile", null, 0, IntPtr.Zero);
	}

	public static void b()
	{
		try
		{
			if (true)
			{
			}
			mciSendString("stop MediaFile", null, 0, IntPtr.Zero);
		}
		catch
		{
		}
	}

	public static void a()
	{
		try
		{
			mciSendString("close MediaFile", null, 0, IntPtr.Zero);
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	[DllImport("winmm.dll")]
	public static extern long mciSendString(string A_0, StringBuilder A_1, int A_2, IntPtr A_3);
}
