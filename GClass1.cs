using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x0200000D RID: 13
public class GClass1
{
	// Token: 0x06000144 RID: 324
	[DllImport("kernel32")]
	private static extern long WritePrivateProfileString(string string_1, string string_2, string string_3, string string_4);

	// Token: 0x06000145 RID: 325
	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string string_1, string string_2, string string_3, StringBuilder stringBuilder_0, int int_0, string string_4);

	// Token: 0x06000146 RID: 326 RVA: 0x00003A4E File Offset: 0x00001C4E
	public GClass1(string string_1)
	{
		this.string_0 = string_1;
	}

	// Token: 0x06000147 RID: 327 RVA: 0x00003A5D File Offset: 0x00001C5D
	public void method_0(string string_1, string string_2, string string_3)
	{
		GClass1.WritePrivateProfileString(string_1, string_2, string_3, this.string_0);
	}

	// Token: 0x06000148 RID: 328 RVA: 0x0000E88C File Offset: 0x0000CA8C
	public string method_1(string string_1, string string_2)
	{
		StringBuilder stringBuilder = new StringBuilder(255);
		GClass1.GetPrivateProfileString(string_1, string_2, "", stringBuilder, 255, this.string_0);
		return stringBuilder.ToString();
	}

	// Token: 0x040000D2 RID: 210
	public string string_0;
}
