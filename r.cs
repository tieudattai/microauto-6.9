using System;
using System.Runtime.InteropServices;
using System.Text;

internal class r
{
	public IntPtr a;

	public r(int A_0)
	{
		this.a = OpenProcess(2035711, A_1: false, A_0);
	}

	public int c(int A_0)
	{
		if (true)
		{
		}
		byte[] array = new byte[4];
		ReadProcessMemory(this.a, A_0, array, 4, 0);
		return BitConverter.ToInt32(array, 0);
	}

	public int b(int[] A_0)
	{
		while (true)
		{
			int num = c(A_0[0]);
			int num2 = 1;
			if (true)
			{
			}
			int num3 = 1;
			while (true)
			{
				switch (num3)
				{
				case 1:
				case 3:
					num3 = 2;
					continue;
				case 2:
					if (num2 >= A_0.Length)
					{
						num3 = 0;
						continue;
					}
					num = c(num + A_0[num2]);
					num2++;
					num3 = 3;
					continue;
				case 0:
					return num;
				}
				break;
			}
		}
	}

	public float a(int[] A_0)
	{
		while (true)
		{
			int num = c(A_0[0]);
			int num2 = 1;
			int num3 = 1;
			while (true)
			{
				switch (num3)
				{
				case 0:
				case 1:
					num3 = 3;
					continue;
				case 3:
					if (num2 >= A_0.Length - 1)
					{
						num3 = 2;
						continue;
					}
					num = c(num + A_0[num2]);
					num2++;
					if (true)
					{
					}
					num3 = 0;
					continue;
				case 2:
					return b(num + A_0[A_0.Length - 1]);
				}
				break;
			}
		}
	}

	public float b(int A_0)
	{
		if (true)
		{
		}
		byte[] array = new byte[4];
		ReadProcessMemory(this.a, A_0, array, 4, 0);
		return BitConverter.ToSingle(array, 0);
	}

	public int a(int A_0, float A_1)
	{
		if (true)
		{
		}
		byte[] bytes = BitConverter.GetBytes(A_1);
		WriteProcessMemory(this.a, A_0, bytes, 4u, out var A_2);
		return A_2;
	}

	public string a(int A_0)
	{
		if (true)
		{
		}
		byte[] array = new byte[30];
		ReadProcessMemory(this.a, A_0, array, array.Length, 0);
		return k.b(Encoding.Default.GetString(array));
	}

	public void a()
	{
		CloseHandle(this.a);
	}

	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int A_0, bool A_1, int A_2);

	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(IntPtr A_0, int A_1, byte[] A_2, int A_3, int A_4);

	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr A_0, int A_1, byte[] A_2, uint A_3, out int A_4);

	[DllImport("kernel32.dll")]
	public static extern bool CloseHandle(IntPtr A_0);
}
