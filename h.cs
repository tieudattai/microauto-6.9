using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class h
{
	private t m_a;

	public Dictionary<int, q> b = new Dictionary<int, q>();

	private Timer c = new Timer();

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void a(t A_0)
	{
		this.m_a = (t)Delegate.Combine(this.m_a, A_0);
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	public void b(t A_0)
	{
		this.m_a = (t)Delegate.Remove(this.m_a, A_0);
	}

	public h()
	{
		a();
		Process[] processesByName = Process.GetProcessesByName("game");
		foreach (Process process in processesByName)
		{
			if (!this.b.ContainsKey(process.Id) && Process.GetProcessById(process.Id).Responding)
			{
				this.b.Add(process.Id, new q(process.Id));
			}
		}
		q.ad = (j)Delegate.Combine(q.ad, new j(a));
	}

	public void a(int A_0)
	{
		this.b.Remove(A_0);
		this.m_a();
	}

	private void a()
	{
		if (true)
		{
		}
		c.Tick += a;
		c.Interval = 20000;
		c.Start();
	}

	private void a(object A_0, EventArgs A_1)
	{
		Process process = default(Process);
		while (true)
		{
			bool flag = false;
			Process[] processesByName = Process.GetProcessesByName("game");
			int num = 0;
			int num2 = 10;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num2 = 4;
					continue;
				case 4:
					if (flag)
					{
						num2 = 0;
						continue;
					}
					return;
				case 7:
				case 10:
					num2 = 5;
					continue;
				case 5:
					if (true)
					{
					}
					if (num >= processesByName.Length)
					{
						num2 = 2;
						continue;
					}
					process = processesByName[num];
					num2 = 1;
					continue;
				case 13:
					num2 = 12;
					continue;
				case 12:
					if (process.Responding)
					{
						num2 = 3;
						continue;
					}
					goto case 8;
				case 9:
					this.m_a();
					num2 = 6;
					continue;
				case 6:
					return;
				case 1:
					if (!this.b.ContainsKey(process.Id))
					{
						num2 = 13;
						continue;
					}
					goto case 8;
				case 0:
					num2 = 11;
					continue;
				case 11:
					if (this.m_a != null)
					{
						num2 = 9;
						continue;
					}
					return;
				case 8:
					num++;
					num2 = 7;
					continue;
				case 3:
					this.b.Add(process.Id, new q(process.Id));
					flag = true;
					num2 = 8;
					continue;
				}
				break;
			}
		}
	}
}
