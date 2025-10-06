using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;


internal class Class6
{
	
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(KeyEventHandler keyEventHandler_2)
	{
		this.keyEventHandler_0 = (KeyEventHandler)Delegate.Combine(this.keyEventHandler_0, keyEventHandler_2);
	}

	
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(KeyEventHandler keyEventHandler_2)
	{
		this.keyEventHandler_0 = (KeyEventHandler)Delegate.Remove(this.keyEventHandler_0, keyEventHandler_2);
	}

	
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_2(KeyEventHandler keyEventHandler_2)
	{
		this.keyEventHandler_1 = (KeyEventHandler)Delegate.Combine(this.keyEventHandler_1, keyEventHandler_2);
	}

	
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_3(KeyEventHandler keyEventHandler_2)
	{
		this.keyEventHandler_1 = (KeyEventHandler)Delegate.Remove(this.keyEventHandler_1, keyEventHandler_2);
	}

	
	public Class6()
	{
		this.method_4();
	}

	
	
	
	
	

	
	public void method_4()
	{
		IntPtr intptr_ = Class6.LoadLibrary("User32");
		this.delegate0_0 = new Class6.Delegate0(this.method_6);
		this.intptr_0 = Class6.SetWindowsHookEx(13, this.delegate0_0, intptr_, 0U);
	}

	
	public void method_5()
	{
		Class6.UnhookWindowsHookEx(this.intptr_0);
	}

	
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

	
	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int int_5, Class6.Delegate0 delegate0_1, IntPtr intptr_1, uint uint_0);

	
	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr intptr_1);

	
	[DllImport("user32.dll")]
	private static extern int CallNextHookEx(IntPtr intptr_1, int int_5, int int_6, ref Class6.Struct1 struct1_0);

	
	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string string_0);

	
	private const int int_0 = 13;

	
	private const int int_1 = 256;

	
	private const int int_2 = 257;

	
	private const int int_3 = 260;

	
	private const int int_4 = 261;

	
	public List<Keys> list_0 = new List<Keys>();

	
	private IntPtr intptr_0 = IntPtr.Zero;

	
	private KeyEventHandler keyEventHandler_0;

	
	private KeyEventHandler keyEventHandler_1;

	
	private Class6.Delegate0 delegate0_0;

	
	
	public delegate int Delegate0(int int_0, int int_1, ref Class6.Struct1 struct1_0);

	
	public struct Struct1
	{
		
		public int int_0;

		
		public int int_1;

		
		public int int_2;

		
		public int int_3;

		
		public int int_4;
	}
}
