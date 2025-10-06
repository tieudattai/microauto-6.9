using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;


internal class Class5
{
	
	public int method_0()
	{
		return this.struct0_0.int_0;
	}

	
	public IntPtr method_1()
	{
		return this.intptr_0;
	}

	
	public void method_2(IntPtr intptr_1)
	{
		this.intptr_0 = intptr_1;
	}

	
	public Class5(IntPtr intptr_1)
	{
		Class5.GetWindowRect(intptr_1, out this.struct0_0);
		this.method_2(intptr_1);
	}

	
	public int method_3()
	{
		return this.struct0_0.int_2 - this.struct0_0.int_0 + 1;
	}

	
	public int method_4()
	{
		return this.struct0_0.int_3 - this.struct0_0.int_1 + 1;
	}

	
	public int method_5()
	{
		return this.method_3() / 2 + this.struct0_0.int_0;
	}

	
	public int method_6()
	{
		return this.method_4() / 2 + this.struct0_0.int_1;
	}

	
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

	
	[DllImport("user32.dll")]
	public static extern int SetWindowText(IntPtr intptr_1, string string_0);

	
	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr intptr_1, out Class5.Struct0 struct0_1);

	
	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	
	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool MoveWindow(IntPtr intptr_1, int int_0, int int_1, int int_2, int int_3, bool bool_0);

	
	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr intptr_1);

	
	public Class5.Struct0 struct0_0;

	
	private IntPtr intptr_0 = IntPtr.Zero;

	
	public struct Struct0
	{
		
		public int int_0;

		
		public int int_1;

		
		public int int_2;

		
		public int int_3;
	}
}
