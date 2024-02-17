using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

// Token: 0x02000012 RID: 18
internal class Class6
{
	// Token: 0x0600015B RID: 347 RVA: 0x00003B89 File Offset: 0x00001D89
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(KeyEventHandler keyEventHandler_2)
	{
		this.keyEventHandler_0 = (KeyEventHandler)Delegate.Combine(this.keyEventHandler_0, keyEventHandler_2);
	}

	// Token: 0x0600015C RID: 348 RVA: 0x00003BA2 File Offset: 0x00001DA2
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(KeyEventHandler keyEventHandler_2)
	{
		this.keyEventHandler_0 = (KeyEventHandler)Delegate.Remove(this.keyEventHandler_0, keyEventHandler_2);
	}

	// Token: 0x0600015D RID: 349 RVA: 0x00003BBB File Offset: 0x00001DBB
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(KeyEventHandler keyEventHandler_2)
	{
		this.keyEventHandler_1 = (KeyEventHandler)Delegate.Combine(this.keyEventHandler_1, keyEventHandler_2);
	}

	// Token: 0x0600015E RID: 350 RVA: 0x00003BD4 File Offset: 0x00001DD4
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(KeyEventHandler keyEventHandler_2)
	{
		this.keyEventHandler_1 = (KeyEventHandler)Delegate.Remove(this.keyEventHandler_1, keyEventHandler_2);
	}

	// Token: 0x0600015F RID: 351 RVA: 0x00003BED File Offset: 0x00001DED
	public Class6()
	{
		this.method_4();
	}

	// Token: 0x06000160 RID: 352 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
	//virtual ~Class6()
	//{
	//	this.method_5();
	//}

	// Token: 0x06000161 RID: 353 RVA: 0x0000E8F0 File Offset: 0x0000CAF0
	public void method_4()
	{
		IntPtr intptr_ = Class6.LoadLibrary("User32");
		this.delegate0_0 = new Class6.Delegate0(this.method_6);
		this.intptr_0 = Class6.SetWindowsHookEx(13, this.delegate0_0, intptr_, 0U);
	}

	// Token: 0x06000162 RID: 354 RVA: 0x00003C11 File Offset: 0x00001E11
	public void method_5()
	{
		Class6.UnhookWindowsHookEx(this.intptr_0);
	}

	// Token: 0x06000163 RID: 355 RVA: 0x0000E930 File Offset: 0x0000CB30
	public int method_6(int int_5, int int_6, ref Class6.Struct1 struct1_0)
	{
		if (int_5 >= 0)
		{
			Keys keys = (Keys)struct1_0.int_0;
			if (this.list_0.Contains(keys))
			{
				KeyEventArgs e = new KeyEventArgs(keys);
				if ((int_6 == 256 || int_6 == 260) && this.keyEventHandler_0 != null)
				{
					this.keyEventHandler_0(this, e);
				}
				else if ((int_6 == 257 || int_6 == 261) && this.keyEventHandler_1 != null)
				{
					this.keyEventHandler_1(this, e);
				}
				Class6.CallNextHookEx(this.intptr_0, int_5, int_6, ref struct1_0);
			}
		}
		return Class6.CallNextHookEx(this.intptr_0, int_5, int_6, ref struct1_0);
	}

	// Token: 0x06000164 RID: 356
	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int int_5, Class6.Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	// Token: 0x06000165 RID: 357
	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	// Token: 0x06000166 RID: 358
	[DllImport("user32.dll")]
	private static extern int CallNextHookEx(IntPtr intptr_1, int int_5, int int_6, ref Class6.Struct1 struct1_0);

	// Token: 0x06000167 RID: 359
	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string string_0);

	// Token: 0x040000E2 RID: 226
	private const int int_0 = 13;

	// Token: 0x040000E3 RID: 227
	private const int int_1 = 256;

	// Token: 0x040000E4 RID: 228
	private const int int_2 = 257;

	// Token: 0x040000E5 RID: 229
	private const int int_3 = 260;

	// Token: 0x040000E6 RID: 230
	private const int int_4 = 261;

	// Token: 0x040000E7 RID: 231
	public List<Keys> list_0 = new List<Keys>();

	// Token: 0x040000E8 RID: 232
	private IntPtr intptr_0 = IntPtr.Zero;

	// Token: 0x040000E9 RID: 233
	private KeyEventHandler keyEventHandler_0;

	// Token: 0x040000EA RID: 234
	private KeyEventHandler keyEventHandler_1;

	// Token: 0x040000EB RID: 235
	private Class6.Delegate0 delegate0_0;

	// Token: 0x02000013 RID: 19
	// (Invoke) Token: 0x06000169 RID: 361
	public delegate int Delegate0(int int_0, int int_1, ref Class6.Struct1 struct1_0);

	// Token: 0x02000014 RID: 20
	public struct Struct1
	{
		// Token: 0x040000EC RID: 236
		public int int_0;

		// Token: 0x040000ED RID: 237
		public int int_1;

		// Token: 0x040000EE RID: 238
		public int int_2;

		// Token: 0x040000EF RID: 239
		public int int_3;

		// Token: 0x040000F0 RID: 240
		public int int_4;
	}
}
