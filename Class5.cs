using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x0200000E RID: 14
internal class Class5
{
	// Token: 0x06000149 RID: 329 RVA: 0x00003A6E File Offset: 0x00001C6E
	public int method_0()
	{
		return this.struct0_0.int_0;
	}

	// Token: 0x0600014A RID: 330 RVA: 0x00003A7B File Offset: 0x00001C7B
	public IntPtr method_1()
	{
		return this.intptr_0;
	}

	// Token: 0x0600014B RID: 331 RVA: 0x00003A83 File Offset: 0x00001C83
	public void method_2(IntPtr intptr_1)
	{
		this.intptr_0 = intptr_1;
	}

	// Token: 0x0600014C RID: 332 RVA: 0x00003A8C File Offset: 0x00001C8C
	public Class5(IntPtr intptr_1)
	{
		Class5.GetWindowRect(intptr_1, out this.struct0_0);
		this.method_2(intptr_1);
	}

	// Token: 0x0600014D RID: 333 RVA: 0x00003AB3 File Offset: 0x00001CB3
	public int method_3()
	{
		return this.struct0_0.int_2 - this.struct0_0.int_0 + 1;
	}

	// Token: 0x0600014E RID: 334 RVA: 0x00003ACE File Offset: 0x00001CCE
	public int method_4()
	{
		return this.struct0_0.int_3 - this.struct0_0.int_1 + 1;
	}

	// Token: 0x0600014F RID: 335 RVA: 0x00003AE9 File Offset: 0x00001CE9
	public int method_5()
	{
		return this.method_3() / 2 + this.struct0_0.int_0;
	}

	// Token: 0x06000150 RID: 336 RVA: 0x00003AFF File Offset: 0x00001CFF
	public int method_6()
	{
		return this.method_4() / 2 + this.struct0_0.int_1;
	}

	// Token: 0x06000151 RID: 337 RVA: 0x00003B15 File Offset: 0x00001D15
	public FormWindowState method_7()
	{
		if (this.method_0() == -32000)
		{
			return FormWindowState.Minimized;
		}
		if (this.method_0() == -4)
		{
			return FormWindowState.Maximized;
		}
		return FormWindowState.Normal;
	}

	// Token: 0x06000152 RID: 338 RVA: 0x00003B33 File Offset: 0x00001D33
	public void method_8()
	{
		if (this.method_7() == FormWindowState.Minimized)
		{
			Class9.ShowWindow(this.method_1(), 9);
		}
		else
		{
			Class9.ShowWindow(this.method_1(), 8);
		}
		Class5.SetForegroundWindow(this.method_1());
	}

	// Token: 0x06000153 RID: 339
	[DllImport("user32.dll")]
	public static extern int SetWindowText(IntPtr intptr_1, string string_0);

	// Token: 0x06000154 RID: 340
	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr intptr_1, out Class5.Struct0 struct0_1);

	// Token: 0x06000155 RID: 341
	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	// Token: 0x06000156 RID: 342
	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool MoveWindow(IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, bool bool_0);

	// Token: 0x06000157 RID: 343
	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr intptr_1);

	// Token: 0x040000D3 RID: 211
	public Class5.Struct0 struct0_0;

	// Token: 0x040000D4 RID: 212
	private IntPtr intptr_0 = IntPtr.Zero;

	// Token: 0x0200000F RID: 15
	public struct Struct0
	{
		// Token: 0x040000D5 RID: 213
		public int int_0;

		// Token: 0x040000D6 RID: 214
		public int int_1;

		// Token: 0x040000D7 RID: 215
		public int int_2;

		// Token: 0x040000D8 RID: 216
		public int int_3;
	}
}
