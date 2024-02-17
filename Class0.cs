using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

// Token: 0x02000003 RID: 3
internal class Class0
{
	// Token: 0x06000005 RID: 5 RVA: 0x00002118 File Offset: 0x00000318
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_0(GDelegate0 gdelegate0_1)
	{
		this.gdelegate0_0 = (GDelegate0)Delegate.Combine(this.gdelegate0_0, gdelegate0_1);
	}

	// Token: 0x06000006 RID: 6 RVA: 0x00002131 File Offset: 0x00000331
	[MethodImpl(MethodImplOptions.Synchronized)]
	public void method_1(GDelegate0 gdelegate0_1)
	{
		this.gdelegate0_0 = (GDelegate0)Delegate.Remove(this.gdelegate0_0, gdelegate0_1);
	}

	// Token: 0x06000007 RID: 7 RVA: 0x00003D5C File Offset: 0x00001F5C
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

	// Token: 0x06000008 RID: 8 RVA: 0x0000214A File Offset: 0x0000034A
	public void method_2(int int_0)
	{
		this.dictionary_0.Remove(int_0);
		this.gdelegate0_0();
	}

	// Token: 0x06000009 RID: 9 RVA: 0x00002164 File Offset: 0x00000364
	private void method_3()
	{
		this.timer_0.Tick += this.timer_0_Tick;
		this.timer_0.Interval = 20000;
		this.timer_0.Start();
	}

	// Token: 0x0600000A RID: 10 RVA: 0x00003E0C File Offset: 0x0000200C
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

	// Token: 0x04000001 RID: 1
	private GDelegate0 gdelegate0_0;

	// Token: 0x04000002 RID: 2
	public Dictionary<int, GClass0> dictionary_0 = new Dictionary<int, GClass0>();

	// Token: 0x04000003 RID: 3
	private Timer timer_0 = new Timer();
}
