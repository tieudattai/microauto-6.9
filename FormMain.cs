using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MicroAuto_6._0.Properties;
using Microsoft.VisualBasic;

// Token: 0x0200000C RID: 12
public partial class FormMain : Form
{
	// Token: 0x060000DD RID: 221 RVA: 0x000031B3 File Offset: 0x000013B3
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x060000DF RID: 223 RVA: 0x000031D2 File Offset: 0x000013D2
	public FormMain()
	{
		this.InitializeComponent();
	}

	// Token: 0x060000E0 RID: 224 RVA: 0x0000BFE8 File Offset: 0x0000A1E8
	private void method_0(object sender, KeyEventArgs e)
	{
		Keys keyCode = e.KeyCode;
		if (keyCode != Keys.Pause)
		{
			switch (keyCode)
			{
			case Keys.Prior:
				break;
			case Keys.Next:
				foreach (GClass0 gclass in this.dictionary_0.Values)
				{
					if (Class5.GetForegroundWindow() == gclass.intptr_0)
					{
						gclass.method_61();
					}
				}
				return;
			default:
				if (keyCode != Keys.Insert)
				{
					return;
				}
				using (Dictionary<int, GClass0>.ValueCollection.Enumerator enumerator2 = this.dictionary_0.Values.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						GClass0 gclass2 = enumerator2.Current;
						if (Class5.GetForegroundWindow() == gclass2.intptr_0)
						{
							foreach (object obj in this.listViewGame.Items)
							{
								ListViewItem listViewItem = (ListViewItem)obj;
								if ((int)listViewItem.Tag == gclass2.int_12)
								{
									listViewItem.Checked = !listViewItem.Checked;
									gclass2.method_7(listViewItem.Checked);
									gclass2.method_60();
									this.method_2();
								}
							}
						}
					}
					return;
				}
				break;
			}
			this.method_6();
			return;
		}
		this.method_7();
	}

	// Token: 0x060000E1 RID: 225 RVA: 0x0000C174 File Offset: 0x0000A374
	public void method_1(int int_0)
	{
		if (this.tabPageAcc.Tag != null && (int)this.tabPageAcc.Tag == int_0 && this.dictionary_0.ContainsKey(int_0))
		{
			this.onlyAttackFixHP.Enabled = this.dictionary_0[int_0].bool_3;
			this.onlyAttackFixHPMinPercent.Enabled = this.dictionary_0[int_0].bool_3;
			this.onlyAttackFixHPMaxPercent.Enabled = this.dictionary_0[int_0].bool_3;
		}
	}

	// Token: 0x060000E2 RID: 226 RVA: 0x0000C204 File Offset: 0x0000A404
	public void method_2()
	{
		if (this.tabPageAcc.Tag != null && this.dictionary_0.ContainsKey((int)this.tabPageAcc.Tag))
		{
			this.isSkill.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].method_6();
			this.f1Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_0.Enabled;
			this.f2Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_1.Enabled;
			this.f3Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_2.Enabled;
			this.f4Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_3.Enabled;
			this.f5Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_4.Enabled;
			this.f6Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_5.Enabled;
			this.f7Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_6.Enabled;
			this.f8Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_7.Enabled;
			this.f9Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_8.Enabled;
			this.f10Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_9.Enabled;
			this.f11Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_10.Enabled;
			this.f12Enable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_11.Enabled;
			this.f1Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_0.Interval / 100;
			this.f2Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_1.Interval / 100;
			this.f3Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_2.Interval / 100;
			this.f4Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_3.Interval / 100;
			this.f5Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_4.Interval / 100;
			this.f6Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_5.Interval / 100;
			this.f7Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_6.Interval / 100;
			this.f8Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_7.Interval / 100;
			this.f9Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_8.Interval / 100;
			this.f10Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_9.Interval / 100;
			this.f11Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_10.Interval / 100;
			this.f12Delay.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_11.Interval / 100;
			this.buffPetEnable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_13.Enabled;
			this.buffPetPercent.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].int_0;
			this.buffPetKey.SelectedIndex = this.buffPetKey.FindString(this.dictionary_0[(int)this.tabPageAcc.Tag].string_1);
			this.buffHPEnable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_14.Enabled;
			this.buffHPPercent.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].int_1;
			this.buffHPKey.SelectedIndex = this.buffHPKey.FindString(this.dictionary_0[(int)this.tabPageAcc.Tag].string_3);
			this.buffMPEnable.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].timer_15.Enabled;
			this.buffMPPercent.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].int_2;
			this.buffMPKey.SelectedIndex = this.buffMPKey.FindString(this.dictionary_0[(int)this.tabPageAcc.Tag].string_4);
			this.exitWhenHPLowPercent.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].int_8;
			this.onlyAttackFixHP.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].bool_4;
			this.onlyAttackFixHPMinPercent.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].int_6;
			this.onlyAttackFixHPMaxPercent.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].int_7;
			this.onlyAttackFixHP.Enabled = this.dictionary_0[(int)this.tabPageAcc.Tag].bool_3;
			this.onlyAttackFixHPMinPercent.Enabled = this.dictionary_0[(int)this.tabPageAcc.Tag].bool_3;
			this.onlyAttackFixHPMaxPercent.Enabled = this.dictionary_0[(int)this.tabPageAcc.Tag].bool_3;
			this.radius.Checked = this.dictionary_0[(int)this.tabPageAcc.Tag].bool_10;
			this.radiusValue.Value = this.dictionary_0[(int)this.tabPageAcc.Tag].int_3;
			this.radius.Text = this.method_13().method_4();
			this.baseSkill.SelectedIndex = this.baseSkill.FindString(this.dictionary_0[(int)this.tabPageAcc.Tag].string_0);
			this.targetKey.SelectedIndex = this.baseSkill.FindString(this.dictionary_0[(int)this.tabPageAcc.Tag].string_2);
			this.lure.Checked = this.method_13().bool_8;
		}
	}

	// Token: 0x060000E3 RID: 227 RVA: 0x0000CB40 File Offset: 0x0000AD40
	public void method_3()
	{
		if (this.tabPageAcc.Tag != null && !this.dictionary_0.ContainsKey((int)this.tabPageAcc.Tag))
		{
			this.tabPageAcc.Tag = null;
		}
		this.listViewGame.Items.Clear();
		foreach (KeyValuePair<int, GClass0> keyValuePair in this.dictionary_0)
		{
			int key = keyValuePair.Key;
			ListViewItem listViewItem = new ListViewItem();
			listViewItem.Tag = key;
			listViewItem.Checked = this.dictionary_0[key].timer_12.Enabled;
			listViewItem.SubItems.Add("");
			listViewItem.SubItems.Add("");
			listViewItem.SubItems.Add("");
			listViewItem.SubItems.Add("");
			listViewItem.SubItems.Add("");
			listViewItem.SubItems.Add("");
			listViewItem.SubItems[0].Name = "acc";
			listViewItem.SubItems[1].Name = "hp";
			listViewItem.SubItems[2].Name = "pet";
			listViewItem.SubItems[3].Name = "captcha";
			listViewItem.SubItems[4].Name = "mp";
			listViewItem.SubItems[5].Name = "bk";
			listViewItem.ForeColor = Color.White;
			listViewItem.UseItemStyleForSubItems = false;
			this.listViewGame.Items.Add(listViewItem);
		}
	}

	// Token: 0x060000E4 RID: 228 RVA: 0x0000CD2C File Offset: 0x0000AF2C
	public void method_4()
	{
		for (int i = 0; i < this.listViewGame.Items.Count; i++)
		{
			int key = (int)this.listViewGame.Items[i].Tag;
			if (this.dictionary_0.ContainsKey(key))
			{
				int num = this.dictionary_0[key].method_33();
				int num2 = this.dictionary_0[key].method_43();
				int num3 = this.dictionary_0[key].method_36();
				int num4 = this.dictionary_0[key].method_2();
				int num5 = this.dictionary_0[key].method_8();
				string a = this.dictionary_0[key].method_38();
				this.listViewGame.Items[i].SubItems["acc"].Text = this.dictionary_0[key].method_38();
				this.listViewGame.Items[i].SubItems["hp"].Text = num + "%";
				this.listViewGame.Items[i].SubItems["pet"].Text = num2 + "%";
				this.listViewGame.Items[i].SubItems["mp"].Text = num3 + "%";
				this.listViewGame.Items[i].SubItems["hp"].ForeColor = Color.White;
				this.listViewGame.Items[i].SubItems["pet"].ForeColor = Color.White;
				this.listViewGame.Items[i].SubItems["mp"].ForeColor = Color.White;
				this.listViewGame.Items[i].SubItems["bk"].ForeColor = Color.White;
				this.listViewGame.Items[i].SubItems["captcha"].ForeColor = Color.White;
				if (a == "Đăng nhập")
				{
					this.listViewGame.Items[i].SubItems["acc"].BackColor = Color.Orange;
				}
				else
				{
					this.listViewGame.Items[i].SubItems["acc"].BackColor = Color.Green;
				}
				if (num > 30)
				{
					this.listViewGame.Items[i].SubItems["hp"].BackColor = Color.Green;
				}
				else
				{
					this.listViewGame.Items[i].SubItems["hp"].BackColor = Color.Red;
				}
				if (num2 > 30)
				{
					this.listViewGame.Items[i].SubItems["pet"].BackColor = Color.Green;
				}
				else
				{
					this.listViewGame.Items[i].SubItems["pet"].BackColor = Color.Red;
				}
				if (num3 > 10)
				{
					this.listViewGame.Items[i].SubItems["mp"].BackColor = Color.Green;
				}
				else
				{
					this.listViewGame.Items[i].SubItems["mp"].BackColor = Color.Red;
				}
				if (this.dictionary_0[key].bool_10)
				{
					this.listViewGame.Items[i].SubItems["bk"].Text = num4.ToString();
					if (num4 > this.dictionary_0[key].int_3)
					{
						this.listViewGame.Items[i].SubItems["bk"].BackColor = Color.Red;
					}
					else
					{
						this.listViewGame.Items[i].SubItems["bk"].BackColor = Color.Orange;
					}
				}
				else
				{
					this.listViewGame.Items[i].SubItems["bk"].Text = "0";
					this.listViewGame.Items[i].SubItems["bk"].BackColor = Color.Green;
				}
				this.listViewGame.Items[i].SubItems["captcha"].Text = this.dictionary_0[key].method_51();
				switch (num5)
				{
				case 1:
					this.listViewGame.Items[i].SubItems["captcha"].BackColor = Color.Green;
					break;
				case 2:
					this.listViewGame.Items[i].SubItems["captcha"].BackColor = Color.Orange;
					break;
				case 3:
					this.listViewGame.Items[i].SubItems["captcha"].BackColor = Color.Red;
					break;
				}
			}
		}
	}

	// Token: 0x060000E5 RID: 229 RVA: 0x0000D2F4 File Offset: 0x0000B4F4
	public void method_5(int int_0)
	{
		for (int i = 0; i < this.listViewGame.Items.Count; i++)
		{
			if (this.dictionary_0.ContainsKey(int_0) && (int)this.listViewGame.Items[i].Tag == int_0)
			{
				this.listViewGame.Items[i].SubItems["acc"].Text = this.dictionary_0[int_0].method_38();
			}
		}
	}

	// Token: 0x060000E6 RID: 230 RVA: 0x0000320C File Offset: 0x0000140C
	public void method_6()
	{
		if (this.bool_0)
		{
			base.Show();
			new Class5(base.Handle).method_8();
		}
		else
		{
			base.Hide();
		}
		this.bool_0 = !this.bool_0;
	}

	// Token: 0x060000E7 RID: 231 RVA: 0x0000D380 File Offset: 0x0000B580
	private void FormMain_Load(object sender, EventArgs e)
	{
		this.class6_0.list_0.Add(Keys.Pause);
		this.class6_0.list_0.Add(Keys.Prior);
		this.class6_0.list_0.Add(Keys.Next);
		this.class6_0.list_0.Add(Keys.Insert);
		this.class6_0.method_2(new KeyEventHandler(this.method_0));
		base.Icon = Resources.dragon;
		this.notifyIcon_0.Icon = Resources.dragon;
		base.TopMost = Class8.smethod_5();
		this.topMost.Checked = base.TopMost;
		if (!Directory.Exists(Class2.string_0))
		{
			Directory.CreateDirectory(Class2.string_0);
		}
		this.dictionary_0 = this.class0_0.dictionary_0;
		this.class0_0.method_0(new GDelegate0(this.method_9));
		GClass0.gdelegate1_1 = (GDelegate1)Delegate.Combine(GClass0.gdelegate1_1, new GDelegate1(this.method_5));
		this.method_3();
		this.method_4();
		base.Location = new Point(Class4.smethod_0() - base.Width, 0);
		this.musicPath.Text = Class8.smethod_2();
		if (Class8.smethod_4())
		{
			this.webBrowser1.Navigate("http://forum.vipautopro.com/adstlbb.html");
		}
		GClass0.gdelegate2_0 = (GDelegate2)Delegate.Combine(GClass0.gdelegate2_0, new GDelegate2(this.method_1));
	}

	// Token: 0x060000E8 RID: 232 RVA: 0x0000D4F0 File Offset: 0x0000B6F0
	private void method_7()
	{
		GClass0.bool_0 = !GClass0.bool_0;
		if (GClass0.bool_0)
		{
			base.Icon = Resources.dragonPause;
			this.notifyIcon_0.Icon = Resources.dragonPause;
			{
				var enumerator = this.listViewGame.Items.GetEnumerator();
				while (enumerator.MoveNext())
				{
					object obj = enumerator.Current;
					ListViewItem listViewItem = (ListViewItem)obj;
					this.dictionary_0[(int)listViewItem.Tag].method_60();
				}
				return;
			}
		}
		base.Icon = Resources.dragon;
		this.notifyIcon_0.Icon = Resources.dragon;
		this.method_8();
		foreach (object obj2 in this.listViewGame.Items)
		{
			ListViewItem listViewItem2 = (ListViewItem)obj2;
			this.dictionary_0[(int)listViewItem2.Tag].method_60();
		}
	}

	// Token: 0x060000E9 RID: 233 RVA: 0x0000D620 File Offset: 0x0000B820
	private void method_8()
	{
		foreach (KeyValuePair<int, GClass0> keyValuePair in this.dictionary_0)
		{
			keyValuePair.Value.int_4 = keyValuePair.Value.method_13();
			keyValuePair.Value.int_5 = keyValuePair.Value.method_17();
		}
		if (this.tabPageAcc.Tag != null)
		{
			int num = this.dictionary_0[(int)this.tabPageAcc.Tag].int_4 = this.dictionary_0[(int)this.tabPageAcc.Tag].method_13();
			int num2 = this.dictionary_0[(int)this.tabPageAcc.Tag].int_5 = this.dictionary_0[(int)this.tabPageAcc.Tag].method_17();
			this.dictionary_0[(int)this.tabPageAcc.Tag].bool_10 = this.radius.Checked;
			if (this.radius.Checked)
			{
				this.radius.Text = string.Concat(new object[]
				{
					"Tọa độ: ",
					num,
					",",
					num2
				});
			}
			else
			{
				this.radius.Text = "Bán kính";
			}
			this.radiusValue.Enabled = this.radius.Checked;
		}
	}

	// Token: 0x060000EA RID: 234 RVA: 0x00003243 File Offset: 0x00001443
	private void method_9()
	{
		this.method_3();
		this.method_2();
	}

	// Token: 0x060000EB RID: 235 RVA: 0x0000D7D4 File Offset: 0x0000B9D4
	private void listViewGame_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.listViewGame.SelectedItems.Count > 0)
		{
			this.tabPageAcc.Text = this.listViewGame.SelectedItems[0].SubItems["acc"].Text;
			this.tabPageAcc.Tag = this.listViewGame.SelectedItems[0].Tag;
		}
		else if (this.listViewGame.Items.Count > 0)
		{
			this.tabPageAcc.Text = this.listViewGame.Items[0].SubItems["acc"].Text;
			this.tabPageAcc.Tag = this.listViewGame.Items[0].Tag;
		}
		else
		{
			this.tabPageAcc.Text = "Nhân vật";
			this.tabPageAcc.Tag = null;
		}
		if (this.dictionary_0.ContainsKey((int)this.tabPageAcc.Tag))
		{
			this.charName.Text = ((this.tabPageAcc.Tag == null) ? "Chưa chọn nhân vật" : this.dictionary_0[(int)this.tabPageAcc.Tag].method_38());
		}
		this.timer_0.Start();
		this.method_2();
	}

	// Token: 0x060000EC RID: 236 RVA: 0x00003251 File Offset: 0x00001451
	private void f1Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_0.Enabled = this.f1Enable.Checked;
		}
	}

	// Token: 0x060000ED RID: 237 RVA: 0x00003290 File Offset: 0x00001490
	private void f2Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_1.Enabled = this.f2Enable.Checked;
		}
	}

	// Token: 0x060000EE RID: 238 RVA: 0x000032CF File Offset: 0x000014CF
	private void f3Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_2.Enabled = this.f3Enable.Checked;
		}
	}

	// Token: 0x060000EF RID: 239 RVA: 0x0000330E File Offset: 0x0000150E
	private void f4Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_3.Enabled = this.f4Enable.Checked;
		}
	}

	// Token: 0x060000F0 RID: 240 RVA: 0x0000334D File Offset: 0x0000154D
	private void f5Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_4.Enabled = this.f5Enable.Checked;
		}
	}

	// Token: 0x060000F1 RID: 241 RVA: 0x0000338C File Offset: 0x0000158C
	private void f6Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_5.Enabled = this.f6Enable.Checked;
		}
	}

	// Token: 0x060000F2 RID: 242 RVA: 0x000033CB File Offset: 0x000015CB
	private void f7Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_6.Enabled = this.f7Enable.Checked;
		}
	}

	// Token: 0x060000F3 RID: 243 RVA: 0x0000340A File Offset: 0x0000160A
	private void f8Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_7.Enabled = this.f8Enable.Checked;
		}
	}

	// Token: 0x060000F4 RID: 244 RVA: 0x00003449 File Offset: 0x00001649
	private void f9Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_8.Enabled = this.f9Enable.Checked;
		}
	}

	// Token: 0x060000F5 RID: 245 RVA: 0x00003488 File Offset: 0x00001688
	private void f10Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_9.Enabled = this.f10Enable.Checked;
		}
	}

	// Token: 0x060000F6 RID: 246 RVA: 0x000034C7 File Offset: 0x000016C7
	private void f11Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_10.Enabled = this.f11Enable.Checked;
		}
	}

	// Token: 0x060000F7 RID: 247 RVA: 0x00003506 File Offset: 0x00001706
	private void f12Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_11.Enabled = this.f12Enable.Checked;
		}
	}

	// Token: 0x060000F8 RID: 248 RVA: 0x0000D93C File Offset: 0x0000BB3C
	private void f1Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_0.Interval = (int)this.f1Delay.Value * 100;
		}
	}

	// Token: 0x060000F9 RID: 249 RVA: 0x0000D990 File Offset: 0x0000BB90
	private void f2Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_1.Interval = (int)this.f2Delay.Value * 100;
		}
	}

	// Token: 0x060000FA RID: 250 RVA: 0x0000D9E4 File Offset: 0x0000BBE4
	private void f3Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_2.Interval = (int)this.f3Delay.Value * 100;
		}
	}

	// Token: 0x060000FB RID: 251 RVA: 0x0000DA38 File Offset: 0x0000BC38
	private void f4Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_3.Interval = (int)this.f4Delay.Value * 100;
		}
	}

	// Token: 0x060000FC RID: 252 RVA: 0x0000DA8C File Offset: 0x0000BC8C
	private void f5Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_4.Interval = (int)this.f5Delay.Value * 100;
		}
	}

	// Token: 0x060000FD RID: 253 RVA: 0x0000DAE0 File Offset: 0x0000BCE0
	private void f6Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_5.Interval = (int)this.f6Delay.Value * 100;
		}
	}

	// Token: 0x060000FE RID: 254 RVA: 0x0000DB34 File Offset: 0x0000BD34
	private void f7Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_6.Interval = (int)this.f7Delay.Value * 100;
		}
	}

	// Token: 0x060000FF RID: 255 RVA: 0x0000DB88 File Offset: 0x0000BD88
	private void f8Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_7.Interval = (int)this.f8Delay.Value * 100;
		}
	}

	// Token: 0x06000100 RID: 256 RVA: 0x0000DBDC File Offset: 0x0000BDDC
	private void f9Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_8.Interval = (int)this.f9Delay.Value * 100;
		}
	}

	// Token: 0x06000101 RID: 257 RVA: 0x0000DC30 File Offset: 0x0000BE30
	private void f10Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_9.Interval = (int)this.f10Delay.Value * 100;
		}
	}

	// Token: 0x06000102 RID: 258 RVA: 0x0000DC84 File Offset: 0x0000BE84
	private void f11Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_10.Interval = (int)this.f11Delay.Value * 100;
		}
	}

	// Token: 0x06000103 RID: 259 RVA: 0x0000DCD8 File Offset: 0x0000BED8
	private void f12Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_11.Interval = (int)this.f12Delay.Value * 100;
		}
	}

	// Token: 0x06000104 RID: 260 RVA: 0x0000DD2C File Offset: 0x0000BF2C
	private void isSkill_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].method_7(this.isSkill.Checked);
			this.dictionary_0[(int)this.tabPageAcc.Tag].method_60();
		}
		this.panelSkill.Enabled = this.isSkill.Checked;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x0000DDA8 File Offset: 0x0000BFA8
	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_57();
		}
	}

	// Token: 0x06000106 RID: 262 RVA: 0x0000DE1C File Offset: 0x0000C01C
	private void timer_0_Tick(object sender, EventArgs e)
	{
		if (this.tabControl1.SelectedTab == this.tabPageInfo && this.tabPageAcc.Tag != null && this.dictionary_0.ContainsKey((int)this.tabPageAcc.Tag))
		{
			string text = this.dictionary_0[(int)this.tabPageAcc.Tag].method_53();
			this.info.Text = text;
			return;
		}
		this.timer_0.Stop();
	}

	// Token: 0x06000107 RID: 263 RVA: 0x0000DEA0 File Offset: 0x0000C0A0
	private void buffPetEnable_CheckedChanged(object sender, EventArgs e)
	{
		this.buffPetPercent.Enabled = this.buffPetEnable.Checked;
		this.buffPetKey.Enabled = this.buffPetEnable.Checked;
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_13.Enabled = this.buffPetEnable.Checked;
		}
	}

	// Token: 0x06000108 RID: 264 RVA: 0x00003545 File Offset: 0x00001745
	private void buffPetPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_0 = (int)this.buffPetPercent.Value;
		}
	}

	// Token: 0x06000109 RID: 265 RVA: 0x00003584 File Offset: 0x00001784
	private void buffPetKey_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_1 = this.buffPetKey.Text;
		}
	}

	// Token: 0x0600010A RID: 266 RVA: 0x0000DF18 File Offset: 0x0000C118
	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_61();
		}
	}

	// Token: 0x0600010B RID: 267 RVA: 0x0000DF8C File Offset: 0x0000C18C
	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_62();
		}
	}

	// Token: 0x0600010C RID: 268 RVA: 0x0000E000 File Offset: 0x0000C200
	private void button1_Click(object sender, EventArgs e)
	{
		MessageBox.Show(long.MaxValue.ToString());
	}

	// Token: 0x0600010D RID: 269 RVA: 0x0000E024 File Offset: 0x0000C224
	private void farmEnable_CheckedChanged(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].timer_18.Enabled = this.farmEnable.Checked;
		}
	}

	// Token: 0x0600010E RID: 270 RVA: 0x000035BE File Offset: 0x000017BE
	private void farmGo_CheckedChanged(object sender, EventArgs e)
	{
		this.method_10();
	}

	// Token: 0x0600010F RID: 271 RVA: 0x000035BE File Offset: 0x000017BE
	private void farmBack_CheckedChanged(object sender, EventArgs e)
	{
		this.method_10();
	}

	// Token: 0x06000110 RID: 272 RVA: 0x000035C6 File Offset: 0x000017C6
	private void method_10()
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].bool_13 = this.farmGo.Checked;
		}
	}

	// Token: 0x06000111 RID: 273 RVA: 0x00003600 File Offset: 0x00001800
	private void buffMPPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_2 = (int)this.buffMPPercent.Value;
		}
	}

	// Token: 0x06000112 RID: 274 RVA: 0x0000E0A8 File Offset: 0x0000C2A8
	private void buffHPEnable_CheckedChanged(object sender, EventArgs e)
	{
		this.buffHPPercent.Enabled = this.buffHPEnable.Checked;
		this.buffHPKey.Enabled = this.buffHPEnable.Checked;
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_14.Enabled = this.buffHPEnable.Checked;
		}
	}

	// Token: 0x06000113 RID: 275 RVA: 0x0000E120 File Offset: 0x0000C320
	private void buffMPEnable_CheckedChanged(object sender, EventArgs e)
	{
		this.buffMPPercent.Enabled = this.buffMPEnable.Checked;
		this.buffMPKey.Enabled = this.buffMPEnable.Checked;
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_15.Enabled = this.buffMPEnable.Checked;
		}
	}

	// Token: 0x06000114 RID: 276 RVA: 0x0000363F File Offset: 0x0000183F
	private void buffHPPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_1 = (int)this.buffHPPercent.Value;
		}
	}

	// Token: 0x06000115 RID: 277 RVA: 0x0000367E File Offset: 0x0000187E
	private void buffHPKey_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_3 = this.buffHPKey.Text;
		}
	}

	// Token: 0x06000116 RID: 278 RVA: 0x000036B8 File Offset: 0x000018B8
	private void buffMPKey_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_4 = this.buffMPKey.Text;
		}
	}

	// Token: 0x06000117 RID: 279 RVA: 0x000036F2 File Offset: 0x000018F2
	private void topMost_CheckedChanged(object sender, EventArgs e)
	{
		base.TopMost = this.topMost.Checked;
		Class8.smethod_6(base.TopMost);
	}

	// Token: 0x06000118 RID: 280 RVA: 0x00003710 File Offset: 0x00001910
	private void shutdownAfterKill_CheckedChanged(object sender, EventArgs e)
	{
		GClass0.bool_2 = this.shutdownAfterKill.Checked;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x0000E198 File Offset: 0x0000C398
	private void exitWhenHPLow_CheckedChanged(object sender, EventArgs e)
	{
		this.exitWhenHPLowPercent.Enabled = this.exitWhenHPLow.Checked;
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_19.Enabled = this.exitWhenHPLow.Checked;
		}
	}

	// Token: 0x0600011A RID: 282 RVA: 0x00003722 File Offset: 0x00001922
	private void exitWhenHPLowPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_8 = (int)this.exitWhenHPLowPercent.Value;
		}
	}

	// Token: 0x0600011B RID: 283 RVA: 0x0000E1F8 File Offset: 0x0000C3F8
	private void openMusic_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		openFileDialog.Multiselect = false;
		openFileDialog.InitialDirectory = Class2.string_0;
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			this.musicPath.Text = openFileDialog.FileName;
		}
	}

	// Token: 0x0600011C RID: 284 RVA: 0x00003761 File Offset: 0x00001961
	private void playMusic_Click(object sender, EventArgs e)
	{
		GClass4.smethod_2();
	}

	// Token: 0x0600011D RID: 285 RVA: 0x00003768 File Offset: 0x00001968
	private void stopMusic_Click(object sender, EventArgs e)
	{
		GClass4.smethod_4();
	}

	// Token: 0x0600011E RID: 286 RVA: 0x0000376F File Offset: 0x0000196F
	private void musicPath_TextChanged(object sender, EventArgs e)
	{
		Class8.smethod_3(this.musicPath.Text);
	}

	// Token: 0x0600011F RID: 287 RVA: 0x00003781 File Offset: 0x00001981
	private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		this.notifyIcon_0.Visible = false;
	}

	// Token: 0x06000120 RID: 288 RVA: 0x0000378F File Offset: 0x0000198F
	private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Class4.smethod_6(base.Handle);
			this.method_6();
		}
	}

	// Token: 0x06000121 RID: 289 RVA: 0x000037AF File Offset: 0x000019AF
	private void FormMain_Resize(object sender, EventArgs e)
	{
		if (base.WindowState == FormWindowState.Minimized)
		{
			this.method_6();
		}
	}

	// Token: 0x06000122 RID: 290 RVA: 0x000037C0 File Offset: 0x000019C0
	private void onlyAttackFixHPMinPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_6 = (int)this.onlyAttackFixHPMinPercent.Value;
		}
	}

	// Token: 0x06000123 RID: 291 RVA: 0x000037FF File Offset: 0x000019FF
	private void onlyAttackFixHPMaxPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_7 = (int)this.onlyAttackFixHPMaxPercent.Value;
		}
	}

	// Token: 0x06000124 RID: 292 RVA: 0x0000383E File Offset: 0x00001A3E
	private void onlyAttackFixHP_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].bool_4 = this.onlyAttackFixHP.Checked;
		}
	}

	// Token: 0x06000125 RID: 293 RVA: 0x00003878 File Offset: 0x00001A78
	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		base.Dispose();
	}

	// Token: 0x06000126 RID: 294 RVA: 0x0000E238 File Offset: 0x0000C438
	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_63();
		}
	}

	// Token: 0x06000127 RID: 295 RVA: 0x0000E2AC File Offset: 0x0000C4AC
	private void resetAutoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		foreach (GClass0 gclass in this.dictionary_0.Values)
		{
			gclass.method_46();
		}
		this.dictionary_0.Clear();
	}

	// Token: 0x06000128 RID: 296 RVA: 0x0000E310 File Offset: 0x0000C510
	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		try
		{
			Process.Start("http://forum.vipautopro.com/forums/148-Thien-Long-Bat-Bo");
		}
		catch
		{
		}
	}

	// Token: 0x06000129 RID: 297 RVA: 0x0000E340 File Offset: 0x0000C540
	private void radius_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			int num = this.dictionary_0[(int)this.tabPageAcc.Tag].int_4 = this.dictionary_0[(int)this.tabPageAcc.Tag].method_13();
			int num2 = this.dictionary_0[(int)this.tabPageAcc.Tag].int_5 = this.dictionary_0[(int)this.tabPageAcc.Tag].method_17();
			this.dictionary_0[(int)this.tabPageAcc.Tag].bool_10 = this.radius.Checked;
			if (this.radius.Checked)
			{
				this.radius.Text = string.Concat(new object[]
				{
					"Tọa độ: ",
					num,
					",",
					num2
				});
			}
			else
			{
				this.radius.Text = "Bán kính";
			}
			this.radiusValue.Enabled = this.radius.Checked;
		}
	}

	// Token: 0x0600012A RID: 298 RVA: 0x00003880 File Offset: 0x00001A80
	private void radiusValue_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_3 = (int)this.radiusValue.Value;
		}
	}

	// Token: 0x0600012B RID: 299 RVA: 0x000038BF File Offset: 0x00001ABF
	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		this.method_7();
	}

	// Token: 0x0600012C RID: 300 RVA: 0x0000E488 File Offset: 0x0000C688
	private void enterExpMax_Click(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag == null)
		{
			return;
		}
		string value = Interaction.InputBox("Microauto", "Microauto", "", Class4.smethod_0() / 2, Class4.smethod_1() / 2);
		try
		{
			ulong ulong_ = Convert.ToUInt64(value);
			this.dictionary_0[(int)this.tabPageAcc.Tag].method_1(ulong_);
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
	}

	// Token: 0x0600012D RID: 301 RVA: 0x000038C7 File Offset: 0x00001AC7
	private void resetExpCaculator_Click(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].method_64();
		}
	}

	// Token: 0x0600012E RID: 302 RVA: 0x000038F6 File Offset: 0x00001AF6
	private void baseSkill_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_0 = this.baseSkill.Text;
		}
	}

	// Token: 0x0600012F RID: 303 RVA: 0x00003930 File Offset: 0x00001B30
	private void targetKey_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_2 = this.targetKey.Text;
		}
	}

	// Token: 0x06000130 RID: 304 RVA: 0x000038BF File Offset: 0x00001ABF
	private void toolStripMenuItem_6_Click(object sender, EventArgs e)
	{
		this.method_7();
	}

	// Token: 0x06000131 RID: 305 RVA: 0x0000396A File Offset: 0x00001B6A
	private void tabPageInfo_Enter(object sender, EventArgs e)
	{
		this.timer_0.Start();
	}

	// Token: 0x06000132 RID: 306 RVA: 0x00003977 File Offset: 0x00001B77
	private void toolStripMenuItem_7_Click(object sender, EventArgs e)
	{
		this.method_11();
	}

	// Token: 0x06000133 RID: 307 RVA: 0x0000E510 File Offset: 0x0000C710
	private void method_11()
	{
		this.radius.Checked = true;
		foreach (object obj in this.listViewGame.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].bool_10 = true;
		}
		this.method_8();
		this.method_2();
	}

	// Token: 0x06000134 RID: 308 RVA: 0x00003977 File Offset: 0x00001B77
	private void toolStripMenuItem_8_Click(object sender, EventArgs e)
	{
		this.method_11();
	}

	// Token: 0x06000135 RID: 309 RVA: 0x0000E59C File Offset: 0x0000C79C
	private void toolStripMenuItem_10_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_61();
		}
	}

	// Token: 0x06000136 RID: 310 RVA: 0x0000E610 File Offset: 0x0000C810
	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_62();
		}
	}

	// Token: 0x06000137 RID: 311 RVA: 0x0000397F File Offset: 0x00001B7F
	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		this.method_12();
	}

	// Token: 0x06000138 RID: 312 RVA: 0x0000E684 File Offset: 0x0000C884
	private void method_12()
	{
		foreach (object obj in this.listViewGame.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_57();
		}
	}

	// Token: 0x06000139 RID: 313 RVA: 0x00003987 File Offset: 0x00001B87
	private GClass0 method_13()
	{
		if (this.tabPageAcc.Tag == null)
		{
			return null;
		}
		return this.dictionary_0[(int)this.tabPageAcc.Tag];
	}

	// Token: 0x0600013A RID: 314 RVA: 0x000039B3 File Offset: 0x00001BB3
	private void toolStripMenuItem_12_Click(object sender, EventArgs e)
	{
		this.method_6();
	}

	// Token: 0x0600013B RID: 315 RVA: 0x0000E6F8 File Offset: 0x0000C8F8
	private void listViewGame_ItemChecked(object sender, ItemCheckedEventArgs e)
	{
		if (this.dictionary_0.ContainsKey((int)e.Item.Tag))
		{
			this.dictionary_0[(int)e.Item.Tag].timer_12.Enabled = e.Item.Checked;
			this.dictionary_0[(int)e.Item.Tag].method_7(e.Item.Checked);
			this.dictionary_0[(int)e.Item.Tag].int_4 = this.dictionary_0[(int)e.Item.Tag].method_13();
			this.dictionary_0[(int)e.Item.Tag].int_5 = this.dictionary_0[(int)e.Item.Tag].method_17();
			this.method_2();
			this.dictionary_0[(int)e.Item.Tag].method_60();
		}
	}

	// Token: 0x0600013C RID: 316 RVA: 0x000039BB File Offset: 0x00001BBB
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.method_4();
	}

	// Token: 0x0600013D RID: 317 RVA: 0x000039C3 File Offset: 0x00001BC3
	private void testAlarm_Click(object sender, EventArgs e)
	{
		new FormAlarm().method_0("Thử nghiệm", GClass0.int_10);
		GClass4.smethod_2();
	}

	// Token: 0x0600013E RID: 318 RVA: 0x000039DE File Offset: 0x00001BDE
	private void lure_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].bool_8 = this.lure.Checked;
		}
	}

	// Token: 0x0600013F RID: 319 RVA: 0x00003A18 File Offset: 0x00001C18
	private void listViewGame_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Next && this.listViewGame.SelectedItems.Count > 0)
		{
			this.method_13().method_62();
		}
	}

	// Token: 0x06000140 RID: 320 RVA: 0x0000397F File Offset: 0x00001B7F
	private void lToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.method_12();
	}

	// Token: 0x06000141 RID: 321 RVA: 0x0000E828 File Offset: 0x0000CA28
	private void label5_MouseClick(object sender, MouseEventArgs e)
	{
		try
		{
			Process.Start("http://www.vipautopro.com/");
		}
		catch (Exception)
		{
		}
	}

	// Token: 0x06000142 RID: 322 RVA: 0x0000E858 File Offset: 0x0000CA58
	private void contextMenuStripListView_Opening(object sender, CancelEventArgs e)
	{
		bool enabled = this.listViewGame.SelectedItems.Count > 0;
		this.toolStripMenuItem_0.Enabled = enabled;
	}

	// Token: 0x040000CC RID: 204
	private bool bool_0;

	// Token: 0x040000CD RID: 205
	private Dictionary<int, GClass0> dictionary_0 = new Dictionary<int, GClass0>();

	// Token: 0x040000CE RID: 206
	private Class0 class0_0 = new Class0();

	// Token: 0x040000CF RID: 207
	private Class6 class6_0 = new Class6();

	// Token: 0x040000D0 RID: 208
	public static FormAlarm formAlarm_0 = new FormAlarm();

	// Token: 0x040000D1 RID: 209
	private Stopwatch stopwatch_0 = new Stopwatch();
}
