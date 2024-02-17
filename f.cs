using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class f
{
	public delegate int a(int A_0, int A_1, ref b A_2);

	public struct b
	{
		public int a;

		public int b;

		public int c;

		public int d;

		public int e;
	}

	private const int m_a = 13;

	private const int m_b = 256;

	private const int m_c = 257;

	private const int m_d = 260;

	private const int e = 261;

	public List<Keys> f = new List<Keys>();

	private IntPtr g = IntPtr.Zero;

	private KeyEventHandler h;

	private KeyEventHandler i;

	private a j;

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void a(KeyEventHandler A_0)
	{
		h = (KeyEventHandler)Delegate.Combine(h, A_0);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void c(KeyEventHandler A_0)
	{
		h = (KeyEventHandler)Delegate.Remove(h, A_0);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void b(KeyEventHandler A_0)
	{
		i = (KeyEventHandler)Delegate.Combine(i, A_0);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void d(KeyEventHandler A_0)
	{
		i = (KeyEventHandler)Delegate.Remove(i, A_0);
	}

	public f()
	{
		b();
	}

	protected virtual void c()
	{
		try
		{
			a();
		}
		finally
		{
			Finalize();
		}
	}

	public void b()
	{
		if (true)
		{
		}
		IntPtr a_ = LoadLibrary("User32");
		j = a;
		g = SetWindowsHookEx(13, j, a_, 0u);
	}

	public void a()
	{
		UnhookWindowsHookEx(g);
	}

	public int a(int A_0, int A_1, ref b A_2)
	{
		int num = 4;
		KeyEventArgs keyEventArgs = default(KeyEventArgs);
		Keys keys = default(Keys);
		while (true)
		{
			switch (num)
			{
			default:
				if (A_0 >= 0)
				{
					num = 5;
					continue;
				}
				break;
			case 17:
				num = 1;
				continue;
			case 1:
				if (i != null)
				{
					num = 16;
					continue;
				}
				goto case 0;
			case 14:
				if (A_1 != 257)
				{
					num = 7;
					continue;
				}
				goto case 17;
			case 13:
				if (true)
				{
				}
				keyEventArgs = new KeyEventArgs(keys);
				num = 9;
				continue;
			case 9:
				if (A_1 != 256)
				{
					num = 15;
					continue;
				}
				goto case 18;
			case 16:
				i(this, keyEventArgs);
				num = 0;
				continue;
			case 5:
				keys = (Keys)A_2.a;
				num = 6;
				continue;
			case 6:
				if (f.Contains(keys))
				{
					num = 13;
					continue;
				}
				break;
			case 7:
				num = 10;
				continue;
			case 10:
				if (A_1 == 261)
				{
					num = 17;
					continue;
				}
				goto case 0;
			case 0:
			case 3:
				CallNextHookEx(g, A_0, A_1, ref A_2);
				num = 2;
				continue;
			case 18:
				num = 8;
				continue;
			case 8:
				if (h != null)
				{
					num = 11;
					continue;
				}
				goto IL_009f;
			case 15:
				num = 12;
				continue;
			case 12:
				if (A_1 == 260)
				{
					num = 18;
					continue;
				}
				goto IL_009f;
			case 11:
				h(this, keyEventArgs);
				num = 3;
				continue;
			case 2:
				break;
				IL_009f:
				num = 14;
				continue;
			}
			break;
		}
		return CallNextHookEx(g, A_0, A_1, ref A_2);
	}

	[DllImport("user32.dll")]
	private static extern IntPtr SetWindowsHookEx(int A_0, a A_1, IntPtr A_2, uint A_3);

	[DllImport("user32.dll")]
	private static extern bool UnhookWindowsHookEx(IntPtr A_0);

	[DllImport("user32.dll")]
	private static extern int CallNextHookEx(IntPtr A_0, int A_1, int A_2, ref b A_3);

	[DllImport("kernel32.dll")]
	private static extern IntPtr LoadLibrary(string A_0);
}
