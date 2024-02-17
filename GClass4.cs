using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000018 RID: 24
public class GClass4
{
	// Token: 0x06000186 RID: 390 RVA: 0x00003CD6 File Offset: 0x00001ED6
	public static string smethod_0()
	{
		return Class8.smethod_2();
	}

	// Token: 0x06000187 RID: 391 RVA: 0x00003CDD File Offset: 0x00001EDD
	public static void smethod_1()
	{
		GClass4.mciSendString("open \"" + GClass4.smethod_0() + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
	}

	// Token: 0x06000188 RID: 392 RVA: 0x00003D00 File Offset: 0x00001F00
	public static void smethod_2()
	{
		GClass4.smethod_4();
		GClass4.smethod_1();
		GClass4.mciSendString("play MediaFile", null, 0, IntPtr.Zero);
	}

	// Token: 0x06000189 RID: 393 RVA: 0x0000ECEC File Offset: 0x0000CEEC
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

	// Token: 0x0600018A RID: 394 RVA: 0x0000ED20 File Offset: 0x0000CF20
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

	// Token: 0x0600018B RID: 395
	[DllImport("winmm.dll")]
	public static extern long mciSendString(string string_0, StringBuilder stringBuilder_0, int int_0, IntPtr intptr_0);
}
