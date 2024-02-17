using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class n
{
	public struct a
	{
		public int a;

		public int b;

		public int c;

		public int d;
	}

	public a a;

	private IntPtr m_b = IntPtr.Zero;

	[SpecialName]
	public int d()
	{
		return this.a.a;
	}

	[SpecialName]
	public IntPtr e()
	{
		return this.m_b;
	}

	[SpecialName]
	public void a(IntPtr A_0)
	{
		this.m_b = A_0;
	}

	public n(IntPtr A_0)
	{
		GetWindowRect(A_0, out this.a);
		a(A_0);
	}

	[SpecialName]
	public int a()
	{
		return this.a.c - this.a.a + 1;
	}

	[SpecialName]
	public int g()
	{
		return this.a.d - this.a.b + 1;
	}

	[SpecialName]
	public int c()
	{
		return a() / 2 + this.a.a;
	}

	[SpecialName]
	public int h()
	{
		return g() / 2 + this.a.b;
	}

	[SpecialName]
	public FormWindowState b()
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				if (true)
				{
				}
				num = ((d() == -32000) ? 2 : 0);
				break;
			case 1:
				return FormWindowState.Maximized;
			case 0:
				if (d() == -4)
				{
					num = 1;
					break;
				}
				return FormWindowState.Normal;
			case 2:
				return FormWindowState.Minimized;
			}
		}
	}

	public void f()
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 3:
				i.ShowWindow(e(), 9);
				num = 0;
				continue;
			case 0:
			case 2:
				SetForegroundWindow(e());
				return;
			}
			if (true)
			{
			}
			if (b() == FormWindowState.Minimized)
			{
				num = 3;
				continue;
			}
			i.ShowWindow(e(), 8);
			num = 2;
		}
	}

	[DllImport("user32.dll")]
	public static extern int SetWindowText(IntPtr A_0, string A_1);

	[DllImport("user32.dll")]
	public static extern bool GetWindowRect(IntPtr A_0, out a A_1);

	[DllImport("user32.dll")]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", SetLastError = true)]
	internal static extern bool MoveWindow(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, bool A_5);

	[DllImport("user32.dll")]
	public static extern bool SetForegroundWindow(IntPtr A_0);
}
