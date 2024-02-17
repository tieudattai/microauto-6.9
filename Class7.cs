using System;
using System.Runtime.InteropServices;
using System.Text;

// Token: 0x02000015 RID: 21
internal class Class7
{
	// Token: 0x0600016C RID: 364 RVA: 0x00003C1F File Offset: 0x00001E1F
	public Class7(int int_0)
	{
		this.intptr_0 = Class7.OpenProcess(2035711, false, int_0);
	}

	// Token: 0x0600016D RID: 365 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
	public int method_0(int int_0)
	{
		byte[] array = new byte[4];
		Class7.ReadProcessMemory(this.intptr_0, int_0, array, 4, 0);
		return BitConverter.ToInt32(array, 0);
	}

	// Token: 0x0600016E RID: 366 RVA: 0x0000E9F4 File Offset: 0x0000CBF4
	public int method_1(int[] int_0)
	{
		int num = this.method_0(int_0[0]);
		for (int i = 1; i < int_0.Length; i++)
		{
			num = this.method_0(num + int_0[i]);
		}
		return num;
	}

	// Token: 0x0600016F RID: 367 RVA: 0x0000EA28 File Offset: 0x0000CC28
	public float method_2(int[] int_0)
	{
		int num = this.method_0(int_0[0]);
		for (int i = 1; i < int_0.Length - 1; i++)
		{
			num = this.method_0(num + int_0[i]);
		}
		return this.method_3(num + int_0[int_0.Length - 1]);
	}

	// Token: 0x06000170 RID: 368 RVA: 0x0000EA6C File Offset: 0x0000CC6C
	public float method_3(int int_0)
	{
		byte[] array = new byte[4];
		Class7.ReadProcessMemory(this.intptr_0, int_0, array, 4, 0);
		return BitConverter.ToSingle(array, 0);
	}

	// Token: 0x06000171 RID: 369 RVA: 0x0000EA98 File Offset: 0x0000CC98
	public int method_4(int int_0, float float_0)
	{
		byte[] bytes = BitConverter.GetBytes(float_0);
		int result;
		Class7.WriteProcessMemory(this.intptr_0, int_0, bytes, 4U, out result);
		return result;
	}

	// Token: 0x06000172 RID: 370 RVA: 0x0000EAC0 File Offset: 0x0000CCC0
	public string method_5(int int_0)
	{
		byte[] array = new byte[30];
		Class7.ReadProcessMemory(this.intptr_0, int_0, array, array.Length, 0);
		return Class4.smethod_2(Encoding.Default.GetString(array));
	}

	// Token: 0x06000173 RID: 371 RVA: 0x00003C39 File Offset: 0x00001E39
	public void method_6()
	{
		Class7.CloseHandle(this.intptr_0);
	}

	// Token: 0x06000174 RID: 372
	[DllImport("kernel32.dll")]
	public static extern IntPtr OpenProcess(int int_0, bool bool_0, int int_1);

	// Token: 0x06000175 RID: 373
	[DllImport("kernel32.dll")]
	public static extern bool ReadProcessMemory(IntPtr intptr_1, int int_0, byte[] byte_0, int int_1, int int_2);

	// Token: 0x06000176 RID: 374
	[DllImport("kernel32.dll", SetLastError = true)]
	public static extern bool WriteProcessMemory(IntPtr intptr_1, int int_0, byte[] byte_0, uint uint_0, out int int_1);

	// Token: 0x06000177 RID: 375
	[DllImport("kernel32.dll")]
	public static extern bool CloseHandle(IntPtr intptr_1);

	// Token: 0x040000F1 RID: 241
	public IntPtr intptr_0;
}
