using System.Runtime.InteropServices;
using System.Text;

public class c
{
	public string a;

	[DllImport("kernel32")]
	private static extern long WritePrivateProfileString(string A_0, string A_1, string A_2, string A_3);

	[DllImport("kernel32")]
	private static extern int GetPrivateProfileString(string A_0, string A_1, string A_2, StringBuilder A_3, int A_4, string A_5);

	public c(string A_0)
	{
		this.a = A_0;
	}

	public void a(string A_0, string A_1, string A_2)
	{
		WritePrivateProfileString(A_0, A_1, A_2, this.a);
	}

	public string a(string A_0, string A_1)
	{
		if (true)
		{
		}
		StringBuilder stringBuilder = new StringBuilder(255);
		GetPrivateProfileString(A_0, A_1, "", stringBuilder, 255, this.a);
		return stringBuilder.ToString();
	}
}
