using System;
using System.Windows.Forms;

// Token: 0x02000016 RID: 22
internal class Class8
{
	// Token: 0x06000178 RID: 376 RVA: 0x00003C47 File Offset: 0x00001E47
	public static string smethod_0(string string_0)
	{
		return Class8.gclass1_0.method_1(Class2.string_1, string_0);
	}

	// Token: 0x06000179 RID: 377 RVA: 0x00003C59 File Offset: 0x00001E59
	public static void smethod_1(string string_0, string string_1)
	{
		Class8.gclass1_0.method_0(Class2.string_1, string_0, string_1);
	}

	// Token: 0x0600017A RID: 378 RVA: 0x0000EAF8 File Offset: 0x0000CCF8
	public static string smethod_2()
	{
		string text = Class8.smethod_0("MusicPath");
		if (text != "")
		{
			return text;
		}
		return Application.StartupPath + "\\Settings\\Alarm.mp3";
	}

	// Token: 0x0600017B RID: 379 RVA: 0x00003C6C File Offset: 0x00001E6C
	public static void smethod_3(string string_0)
	{
		Class8.smethod_1("MusicPath", string_0);
	}

	// Token: 0x0600017C RID: 380 RVA: 0x0000EB30 File Offset: 0x0000CD30
	public static bool smethod_4()
	{
		bool result;
		try
		{
			result = Convert.ToBoolean(Class8.smethod_0("IsPopup"));
		}
		catch
		{
			result = true;
		}
		return result;
	}

	// Token: 0x0600017D RID: 381 RVA: 0x0000EB68 File Offset: 0x0000CD68
	public static bool smethod_5()
	{
		bool result;
		try
		{
			result = Convert.ToBoolean(Class8.smethod_0("TopMost"));
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600017E RID: 382 RVA: 0x00003C79 File Offset: 0x00001E79
	public static void smethod_6(bool bool_0)
	{
		Class8.smethod_1("TopMost", bool_0.ToString());
	}

	// Token: 0x0600017F RID: 383 RVA: 0x0000EBA0 File Offset: 0x0000CDA0
	public static ulong smethod_7(int int_1)
	{
		ulong result;
		try
		{
			result = Convert.ToUInt64(Class8.gclass1_0.method_1(Class2.string_1, "Lvl" + int_1));
		}
		catch
		{
			result = 0UL;
		}
		return result;
	}

	// Token: 0x06000180 RID: 384 RVA: 0x00003C8C File Offset: 0x00001E8C
	public static void smethod_8(int int_1, ulong ulong_0)
	{
		Class8.gclass1_0.method_0(Class2.string_1, "Lvl" + int_1, ulong_0.ToString());
	}

	// Token: 0x040000F2 RID: 242
	public static GClass1 gclass1_0 = new GClass1(Class2.string_0 + "\\General.ini");

	// Token: 0x040000F3 RID: 243
	public static int int_0 = 100;
}
