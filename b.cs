using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class b
{
	public static c a = new c(e.a + "\\General.ini");

	public static int b = 100;

	public static string b(string A_0)
	{
		return global::b.a.a(e.b, A_0);
	}

	public static void a(string A_0, string A_1)
	{
		global::b.a.a(e.b, A_0, A_1);
	}

	[SpecialName]
	public static string c()
	{
		string text = b("MusicPath");
		if (text != "")
		{
			if (true)
			{
			}
			return text;
		}
		return Application.StartupPath + "\\Settings\\Alarm.mp3";
	}

	[SpecialName]
	public static void a(string A_0)
	{
		a("MusicPath", A_0);
	}

	[SpecialName]
	public static bool b()
	{
		try
		{
			if (true)
			{
			}
			return Convert.ToBoolean(b("IsPopup"));
		}
		catch
		{
			return true;
		}
	}

	[SpecialName]
	public static bool a()
	{
		bool result;
		try
		{
			result = Convert.ToBoolean(b("TopMost"));
		}
		catch
		{
			result = false;
		}
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public static void a(bool A_0)
	{
		a("TopMost", A_0.ToString());
	}

	public static ulong a(int A_0)
	{
		ulong result;
		try
		{
			result = Convert.ToUInt64(global::b.a.a(e.b, "Lvl" + A_0));
		}
		catch
		{
			result = 0uL;
		}
		if (true)
		{
		}
		return result;
	}

	public static void a(int A_0, ulong A_1)
	{
		global::b.a.a(e.b, "Lvl" + A_0, A_1.ToString());
	}
}
