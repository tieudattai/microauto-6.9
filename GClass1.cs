using System;
using System.Runtime.InteropServices;
using System.Text;


public class GClass1
{
	
	[DllImport("kernel32")]
	private static extern long WritePrivateProfileString(string string_1, string string_2, string string_3, string string_4);

	
	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string string_1, string string_2, string string_3, StringBuilder stringBuilder_0, int int_0, string string_4);

	
	public GClass1(string string_1)
	{
		this.string_0 = string_1;
	}

	
	public void method_0(string string_1, string string_2, string string_3)
	{
		GClass1.WritePrivateProfileString(string_1, string_2, string_3, this.string_0);
	}

	
	public string method_1(string string_1, string string_2)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		GClass1.GetPrivateProfileString(string_1, string_2, "", stringBuilder, 255, this.string_0);
		return stringBuilder.ToString();
	}

	
	public string string_0;
}
