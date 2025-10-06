using System;
using System.Windows.Forms;


internal class Class8
{
	
	public static string smethod_0(string string_0)
	{
		return Class8.gclass1_0.method_1(Class2.string_1, string_0);
	}

	
	public static void smethod_1(string string_0, string string_1)
	{
		Class8.gclass1_0.method_0(Class2.string_1, string_0, string_1);
	}

	
	public static string smethod_2()
	{
		string text = Class8.smethod_0("MusicPath");
		if (text != "")
		{
			return text;
		}
		return Application.StartupPath + "\\Settings\\Alarm.mp3";
	}

	
	public static void smethod_3(string string_0)
	{
		Class8.smethod_1("MusicPath", string_0);
	}

	
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

	
	public static void smethod_6(bool bool_0)
	{
		Class8.smethod_1("TopMost", bool_0.ToString());
	}

	
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

	
	public static void smethod_8(int int_1, ulong ulong_0)
	{
		Class8.gclass1_0.method_0(Class2.string_1, "Lvl" + int_1, ulong_0.ToString());
	}

	
	public static GClass1 gclass1_0 = new GClass1(Class2.string_0 + "\\General.ini");

	
	public static int int_0 = 100;
}
