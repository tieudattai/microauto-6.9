using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

internal class k
{
	[SpecialName]
	public static int b()
	{
		return Screen.PrimaryScreen.Bounds.Width;
	}

	[SpecialName]
	public static int a()
	{
		return Screen.PrimaryScreen.Bounds.Height;
	}

	public static string b(string A_0)
	{
		if (true)
		{
		}
		A_0 = Regex.Replace(A_0, "Õ", "ạ");
		A_0 = Regex.Replace(A_0, "ä", "ả");
		A_0 = Regex.Replace(A_0, "€", "Ạ");
		A_0 = Regex.Replace(A_0, "Ä", "Ả");
		A_0 = Regex.Replace(A_0, "å", "ă");
		A_0 = Regex.Replace(A_0, "¡", "ắ");
		A_0 = Regex.Replace(A_0, "¢", "ằ");
		A_0 = Regex.Replace(A_0, "£", "ặ");
		A_0 = Regex.Replace(A_0, "Ç", "ẵ");
		A_0 = Regex.Replace(A_0, "Æ", "ẳ");
		A_0 = Regex.Replace(A_0, "Å", "Ă");
		A_0 = Regex.Replace(A_0, "\u0081", "Ắ");
		A_0 = Regex.Replace(A_0, "‚", "Ằ");
		A_0 = Regex.Replace(A_0, "ƒ", "Ặ");
		A_0 = Regex.Replace(A_0, "\u0005", "Ẵ");
		A_0 = Regex.Replace(A_0, "\u0002", "Ẳ");
		A_0 = Regex.Replace(A_0, "¤", "ấ");
		A_0 = Regex.Replace(A_0, "¥", "ầ");
		A_0 = Regex.Replace(A_0, "§", "ậ");
		A_0 = Regex.Replace(A_0, "ç", "ẵ");
		A_0 = Regex.Replace(A_0, "¦", "ẳ");
		A_0 = Regex.Replace(A_0, "„", "Ấ");
		A_0 = Regex.Replace(A_0, "…", "Ầ");
		A_0 = Regex.Replace(A_0, "‡", "Ậ");
		A_0 = Regex.Replace(A_0, "\u0006", "Ẫ");
		A_0 = Regex.Replace(A_0, "†", "Ẩ");
		A_0 = Regex.Replace(A_0, "ð", "đ");
		A_0 = Regex.Replace(A_0, "ë", "ẹ");
		A_0 = Regex.Replace(A_0, "\u00a8", "ẽ");
		A_0 = Regex.Replace(A_0, "©", "ẻ");
		A_0 = Regex.Replace(A_0, "Ë", "Ẹ");
		A_0 = Regex.Replace(A_0, "ˆ", "Ẽ");
		A_0 = Regex.Replace(A_0, "‰", "Ẻ");
		A_0 = Regex.Replace(A_0, "ª", "ế");
		A_0 = Regex.Replace(A_0, "«", "ề");
		A_0 = Regex.Replace(A_0, "®", "ệ");
		A_0 = Regex.Replace(A_0, "\u00ad", "ễ");
		A_0 = Regex.Replace(A_0, "¬", "ể");
		A_0 = Regex.Replace(A_0, "Š", "Ế");
		A_0 = Regex.Replace(A_0, "‹", "Ề");
		A_0 = Regex.Replace(A_0, "Ž", "Ệ");
		A_0 = Regex.Replace(A_0, "\u008d", "Ễ");
		A_0 = Regex.Replace(A_0, "Œ", "Ể");
		A_0 = Regex.Replace(A_0, "\u00b8", "ị");
		A_0 = Regex.Replace(A_0, "î", "ĩ");
		A_0 = Regex.Replace(A_0, "ï", "ỉ");
		A_0 = Regex.Replace(A_0, "\u02dc", "Ị");
		A_0 = Regex.Replace(A_0, "Î", "Ĩ");
		A_0 = Regex.Replace(A_0, "›", "Ỉ");
		A_0 = Regex.Replace(A_0, "÷", "ọ");
		A_0 = Regex.Replace(A_0, "ö", "ỏ");
		A_0 = Regex.Replace(A_0, "š", "Ọ");
		A_0 = Regex.Replace(A_0, "\u00a0", "Õ");
		A_0 = Regex.Replace(A_0, "™", "Ỏ");
		A_0 = Regex.Replace(A_0, "\u00af", "ố");
		A_0 = Regex.Replace(A_0, "°", "ồ");
		A_0 = Regex.Replace(A_0, "µ", "ộ");
		A_0 = Regex.Replace(A_0, "²", "ỗ");
		A_0 = Regex.Replace(A_0, "±", "ổ");
		A_0 = Regex.Replace(A_0, "\u008f", "Ố");
		A_0 = Regex.Replace(A_0, "\u0090", "Ồ");
		A_0 = Regex.Replace(A_0, "“", "Ộ");
		A_0 = Regex.Replace(A_0, "’", "Ỗ");
		A_0 = Regex.Replace(A_0, "‘", "Ổ");
		A_0 = Regex.Replace(A_0, "½", "ơ");
		A_0 = Regex.Replace(A_0, "¾", "ớ");
		A_0 = Regex.Replace(A_0, "¶", "ờ");
		A_0 = Regex.Replace(A_0, "þ", "ợ");
		A_0 = Regex.Replace(A_0, "Þ", "ỡ");
		A_0 = Regex.Replace(A_0, "·", "ở");
		A_0 = Regex.Replace(A_0, "\u00b4", "Ơ");
		A_0 = Regex.Replace(A_0, "•", "Ớ");
		A_0 = Regex.Replace(A_0, "–", "Ờ");
		A_0 = Regex.Replace(A_0, "”", "Ợ");
		A_0 = Regex.Replace(A_0, "³", "Ỡ");
		A_0 = Regex.Replace(A_0, "—", "Ở");
		A_0 = Regex.Replace(A_0, "ø", "ụ");
		A_0 = Regex.Replace(A_0, "û", "ũ");
		A_0 = Regex.Replace(A_0, "ü", "ủ");
		A_0 = Regex.Replace(A_0, "ž", "Ụ");
		A_0 = Regex.Replace(A_0, "\u009d", "Ũ");
		A_0 = Regex.Replace(A_0, "œ", "Ủ");
		A_0 = Regex.Replace(A_0, "ß", "ư");
		A_0 = Regex.Replace(A_0, "Ñ", "ứ");
		A_0 = Regex.Replace(A_0, "×", "ừ");
		A_0 = Regex.Replace(A_0, "ñ", "ự");
		A_0 = Regex.Replace(A_0, "æ", "ữ");
		A_0 = Regex.Replace(A_0, "Ø", "ử");
		A_0 = Regex.Replace(A_0, "¿", "Ư");
		A_0 = Regex.Replace(A_0, "º", "Ứ");
		A_0 = Regex.Replace(A_0, "»", "Ừ");
		A_0 = Regex.Replace(A_0, "¹", "Ự");
		A_0 = Regex.Replace(A_0, "ÿ", "Ữ");
		A_0 = Regex.Replace(A_0, "¼", "Ử");
		A_0 = Regex.Replace(A_0, "Ï", "ỳ");
		A_0 = Regex.Replace(A_0, "Ü", "ỵ");
		A_0 = Regex.Replace(A_0, "Û", "ỹ");
		A_0 = Regex.Replace(A_0, "Ö", "ỷ");
		A_0 = Regex.Replace(A_0, "Ÿ", "Ỳ");
		A_0 = Regex.Replace(A_0, "\u001e", "Ỵ");
		A_0 = Regex.Replace(A_0, "\u0019", "Ỹ");
		A_0 = Regex.Replace(A_0, "\u0014", "Ỷ");
		return a(A_0);
	}

	public static string a(string A_0)
	{
		char c2 = default(char);
		while (true)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			int num2 = 0;
			while (true)
			{
				switch (num2)
				{
				case 0:
				case 1:
					if (true)
					{
					}
					num2 = 2;
					continue;
				case 2:
					if (num >= A_0.Length)
					{
						num2 = 4;
						continue;
					}
					c2 = A_0[num];
					num2 = 3;
					continue;
				case 5:
					stringBuilder.Append(c2);
					num++;
					num2 = 1;
					continue;
				case 3:
					if (c2 != 0)
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 4:
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	public static IntPtr b(int A_0)
	{
		Process process = default(Process);
		IntPtr mainWindowHandle = default(IntPtr);
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 5:
					num2 = 4;
					continue;
				case 4:
					if (num >= processes.Length)
					{
						num2 = 1;
						continue;
					}
					process = processes[num];
					num2 = 6;
					continue;
				case 6:
					if (process.Id != A_0)
					{
						num++;
						num2 = 3;
					}
					else
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (true)
					{
					}
					return IntPtr.Zero;
				case 0:
					mainWindowHandle = process.MainWindowHandle;
					num2 = 2;
					continue;
				case 2:
					return mainWindowHandle;
				}
				break;
			}
		}
	}

	public static bool a(int A_0)
	{
		Process process = default(Process);
		bool result = default(bool);
		while (true)
		{
			Process[] processes = Process.GetProcesses();
			int num = 0;
			int num2 = 6;
			while (true)
			{
				switch (num2)
				{
				case 1:
				case 6:
					num2 = 3;
					continue;
				case 3:
					if (num >= processes.Length)
					{
						num2 = 4;
						continue;
					}
					process = processes[num];
					num2 = 0;
					continue;
				case 0:
					if (process.Id != A_0)
					{
						num++;
						num2 = 1;
					}
					else
					{
						num2 = 5;
					}
					continue;
				case 4:
					return false;
				case 5:
					if (true)
					{
					}
					result = true;
					num2 = 2;
					continue;
				case 2:
					return result;
				}
				break;
			}
		}
	}

	public static void a(IntPtr A_0)
	{
		if (n.GetForegroundWindow() != A_0)
		{
			i.ShowWindow(A_0, 1);
		}
	}
}
