using System;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;


internal class Class4
{
	
	public static int smethod_0()
	{
		return Screen.PrimaryScreen.Bounds.Width;
	}

	
	public static int smethod_1()
	{
		return Screen.PrimaryScreen.Bounds.Height;
	}

	
	public static string smethod_2(string string_0)
	{
		string_0 = Regex.Replace(string_0, "Õ", "ạ");
		string_0 = Regex.Replace(string_0, "ä", "ả");
		string_0 = Regex.Replace(string_0, "€", "Ạ");
		string_0 = Regex.Replace(string_0, "Ä", "Ả");
		string_0 = Regex.Replace(string_0, "å", "ă");
		string_0 = Regex.Replace(string_0, "¡", "ắ");
		string_0 = Regex.Replace(string_0, "¢", "ằ");
		string_0 = Regex.Replace(string_0, "£", "ặ");
		string_0 = Regex.Replace(string_0, "Ç", "ẵ");
		string_0 = Regex.Replace(string_0, "Æ", "ẳ");
		string_0 = Regex.Replace(string_0, "Å", "Ă");
		string_0 = Regex.Replace(string_0, "\u0081", "Ắ");
		string_0 = Regex.Replace(string_0, "‚", "Ằ");
		string_0 = Regex.Replace(string_0, "ƒ", "Ặ");
		string_0 = Regex.Replace(string_0, "\u0005", "Ẵ");
		string_0 = Regex.Replace(string_0, "\u0002", "Ẳ");
		string_0 = Regex.Replace(string_0, "¤", "ấ");
		string_0 = Regex.Replace(string_0, "¥", "ầ");
		string_0 = Regex.Replace(string_0, "§", "ậ");
		string_0 = Regex.Replace(string_0, "ç", "ẵ");
		string_0 = Regex.Replace(string_0, "¦", "ẳ");
		string_0 = Regex.Replace(string_0, "„", "Ấ");
		string_0 = Regex.Replace(string_0, "…", "Ầ");
		string_0 = Regex.Replace(string_0, "‡", "Ậ");
		string_0 = Regex.Replace(string_0, "\u0006", "Ẫ");
		string_0 = Regex.Replace(string_0, "†", "Ẩ");
		string_0 = Regex.Replace(string_0, "ð", "đ");
		string_0 = Regex.Replace(string_0, "ë", "ẹ");
		string_0 = Regex.Replace(string_0, "¨", "ẽ");
		string_0 = Regex.Replace(string_0, "©", "ẻ");
		string_0 = Regex.Replace(string_0, "Ë", "Ẹ");
		string_0 = Regex.Replace(string_0, "ˆ", "Ẽ");
		string_0 = Regex.Replace(string_0, "‰", "Ẻ");
		string_0 = Regex.Replace(string_0, "ª", "ế");
		string_0 = Regex.Replace(string_0, "«", "ề");
		string_0 = Regex.Replace(string_0, "®", "ệ");
		string_0 = Regex.Replace(string_0, "­", "ễ");
		string_0 = Regex.Replace(string_0, "¬", "ể");
		string_0 = Regex.Replace(string_0, "Š", "Ế");
		string_0 = Regex.Replace(string_0, "‹", "Ề");
		string_0 = Regex.Replace(string_0, "Ž", "Ệ");
		string_0 = Regex.Replace(string_0, "\u008d", "Ễ");
		string_0 = Regex.Replace(string_0, "Œ", "Ể");
		string_0 = Regex.Replace(string_0, "¸", "ị");
		string_0 = Regex.Replace(string_0, "î", "ĩ");
		string_0 = Regex.Replace(string_0, "ï", "ỉ");
		string_0 = Regex.Replace(string_0, "˜", "Ị");
		string_0 = Regex.Replace(string_0, "Î", "Ĩ");
		string_0 = Regex.Replace(string_0, "›", "Ỉ");
		string_0 = Regex.Replace(string_0, "÷", "ọ");
		string_0 = Regex.Replace(string_0, "ö", "ỏ");
		string_0 = Regex.Replace(string_0, "š", "Ọ");
		string_0 = Regex.Replace(string_0, "\u00a0", "Õ");
		string_0 = Regex.Replace(string_0, "™", "Ỏ");
		string_0 = Regex.Replace(string_0, "¯", "ố");
		string_0 = Regex.Replace(string_0, "°", "ồ");
		string_0 = Regex.Replace(string_0, "µ", "ộ");
		string_0 = Regex.Replace(string_0, "²", "ỗ");
		string_0 = Regex.Replace(string_0, "±", "ổ");
		string_0 = Regex.Replace(string_0, "\u008f", "Ố");
		string_0 = Regex.Replace(string_0, "\u0090", "Ồ");
		string_0 = Regex.Replace(string_0, "“", "Ộ");
		string_0 = Regex.Replace(string_0, "’", "Ỗ");
		string_0 = Regex.Replace(string_0, "‘", "Ổ");
		string_0 = Regex.Replace(string_0, "½", "ơ");
		string_0 = Regex.Replace(string_0, "¾", "ớ");
		string_0 = Regex.Replace(string_0, "¶", "ờ");
		string_0 = Regex.Replace(string_0, "þ", "ợ");
		string_0 = Regex.Replace(string_0, "Þ", "ỡ");
		string_0 = Regex.Replace(string_0, "·", "ở");
		string_0 = Regex.Replace(string_0, "´", "Ơ");
		string_0 = Regex.Replace(string_0, "•", "Ớ");
		string_0 = Regex.Replace(string_0, "–", "Ờ");
		string_0 = Regex.Replace(string_0, "”", "Ợ");
		string_0 = Regex.Replace(string_0, "³", "Ỡ");
		string_0 = Regex.Replace(string_0, "—", "Ở");
		string_0 = Regex.Replace(string_0, "ø", "ụ");
		string_0 = Regex.Replace(string_0, "û", "ũ");
		string_0 = Regex.Replace(string_0, "ü", "ủ");
		string_0 = Regex.Replace(string_0, "ž", "Ụ");
		string_0 = Regex.Replace(string_0, "\u009d", "Ũ");
		string_0 = Regex.Replace(string_0, "œ", "Ủ");
		string_0 = Regex.Replace(string_0, "ß", "ư");
		string_0 = Regex.Replace(string_0, "Ñ", "ứ");
		string_0 = Regex.Replace(string_0, "×", "ừ");
		string_0 = Regex.Replace(string_0, "ñ", "ự");
		string_0 = Regex.Replace(string_0, "æ", "ữ");
		string_0 = Regex.Replace(string_0, "Ø", "ử");
		string_0 = Regex.Replace(string_0, "¿", "Ư");
		string_0 = Regex.Replace(string_0, "º", "Ứ");
		string_0 = Regex.Replace(string_0, "»", "Ừ");
		string_0 = Regex.Replace(string_0, "¹", "Ự");
		string_0 = Regex.Replace(string_0, "ÿ", "Ữ");
		string_0 = Regex.Replace(string_0, "¼", "Ử");
		string_0 = Regex.Replace(string_0, "Ï", "ỳ");
		string_0 = Regex.Replace(string_0, "Ü", "ỵ");
		string_0 = Regex.Replace(string_0, "Û", "ỹ");
		string_0 = Regex.Replace(string_0, "Ö", "ỷ");
		string_0 = Regex.Replace(string_0, "Ÿ", "Ỳ");
		string_0 = Regex.Replace(string_0, "\u001e", "Ỵ");
		string_0 = Regex.Replace(string_0, "\u0019", "Ỹ");
		string_0 = Regex.Replace(string_0, "\u0014", "Ỷ");
		return Class4.smethod_3(string_0);
	}

	
	public static string smethod_3(string string_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		foreach (char c in string_0)
		{
			if (c == '\0')
			{
				break;
			}
			stringBuilder.Append(c);
		}
		return stringBuilder.ToString();
	}

	
	public static IntPtr smethod_4(int int_0)
	{
		foreach (Process process in Process.GetProcesses())
		{
			if (process.Id == int_0)
			{
				return process.MainWindowHandle;
			}
		}
		return IntPtr.Zero;
	}

	
	public static bool smethod_5(int int_0)
	{
		foreach (Process process in Process.GetProcesses())
		{
			if (process.Id == int_0)
			{
				return true;
			}
		}
		return false;
	}

	
	public static void smethod_6(IntPtr intptr_0)
	{
		if (Class5.GetForegroundWindow() != intptr_0)
		{
			Class9.ShowWindow(intptr_0, 1);
		}
	}
}
