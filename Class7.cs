using System;
using System.Runtime.InteropServices;
using System.Text;


internal class Class7
{
	
	public Class7(int int_0)
	{
		this.intptr_0 = Class7.OpenProcess(2035711, false, int_0);
	}

	
	public int method_0(int int_0)
	{
		byte[] array = new byte[4];
		Class7.ReadProcessMemory(this.intptr_0, int_0, array, 4, 0);
		return BitConverter.ToInt32(array, 0);
	}

	
	public int method_1(int[] int_0)
	{
		int num = this.method_0(int_0[0]);
		for (int i = 1; i < int_0.Length; i++)
		{
			num = this.method_0(num + int_0[i]);
		}
		return num;
	}

	
	public float method_2(int[] int_0)
	{
		int num = this.method_0(int_0[0]);
		for (int i = 1; i < int_0.Length - 1; i++)
		{
			num = this.method_0(num + int_0[i]);
		}
		return this.method_3(num + int_0[int_0.Length - 1]);
	}

	
	public float method_3(int int_0)
	{
		byte[] array = new byte[4];
		Class7.ReadProcessMemory(this.intptr_0, int_0, array, 4, 0);
		return BitConverter.ToSingle(array, 0);
	}

	
	public int method_4(int int_0, float float_0)
	{
		byte[] bytes = BitConverter.GetBytes(float_0);
		int result;
		Class7.WriteProcessMemory(this.intptr_0, int_0, bytes, 4U, out result);
		return result;
	}

	
	public string method_5(int int_0)
	{
		byte[] array = new byte[30];
		Class7.ReadProcessMemory(this.intptr_0, int_0, array, array.Length, 0);
		return Class4.smethod_2(Encoding.Default.GetString(array));
	}

	
	public void method_6()
	{
		Class7.CloseHandle(this.intptr_0);
	}

	
	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int int_0, bool bool_0, int int_1);

	
	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(IntPtr intptr_1, int int_0, byte[] byte_0, int int_1, int int_2);

	
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr intptr_1, int int_0, byte[] byte_0, uint uint_0, out int int_1);

	
	[DllImport("kernel32.dll")]
	public static extern bool CloseHandle(IntPtr intptr_1);

	
	public IntPtr intptr_0;
}
