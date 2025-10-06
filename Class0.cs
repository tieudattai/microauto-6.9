using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;


internal class Class0
{
	
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate0 gdelegate0_1)
	{
		this.gdelegate0_0 = (GDelegate0)Delegate.Combine(this.gdelegate0_0, gdelegate0_1);
	}

	
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate0 gdelegate0_1)
	{
		this.gdelegate0_0 = (GDelegate0)Delegate.Remove(this.gdelegate0_0, gdelegate0_1);
	}

	
	public Class0()
	{
		this.method_3();
		foreach (Process process in Process.GetProcessesByName("game"))
		{
			if (!this.dictionary_0.ContainsKey(process.Id) && Process.GetProcessById(process.Id).Responding)
			{
				this.dictionary_0.Add(process.Id, new GClass0(process.Id));
			}
		}
		GClass0.gdelegate1_0 = (GDelegate1)Delegate.Combine(GClass0.gdelegate1_0, new GDelegate1(this.method_2));
	}

	
	public void method_2(int int_0)
	{
		this.dictionary_0.Remove(int_0);
		this.gdelegate0_0();
	}

	
	private void method_3()
	{
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_0.Interval = 20000;
		this.timer_0.Start();
	}

	
	private void timer_0_Tick(object sender, EventArgs e)
	{
		bool flag = false;
		foreach (Process process in Process.GetProcessesByName("game"))
		{
			if (!this.dictionary_0.ContainsKey(process.Id) && process.Responding)
			{
				this.dictionary_0.Add(process.Id, new GClass0(process.Id));
				flag = true;
			}
		}
		if (flag && this.gdelegate0_0 != null)
		{
			this.gdelegate0_0();
		}
	}

	
	private GDelegate0 gdelegate0_0;

	
	public Dictionary<int, GClass0> dictionary_0 = new Dictionary<int, GClass0>();

	
	private Timer timer_0 = new Timer();
}
