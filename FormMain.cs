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


public partial class FormMain : Form
{
	
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	
	public FormMain()
	{
		this.InitializeComponent();
	}

	
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

	
	public void method_1(int int_0)
	{
		if (this.tabPageAcc.Tag != null && (int)this.tabPageAcc.Tag == int_0 && this.dictionary_0.ContainsKey(int_0))
		{
			this.onlyAttackFixHP.Enabled = this.dictionary_0[int_0].bool_3;
			this.onlyAttackFixHPMinPercent.Enabled = this.dictionary_0[int_0].bool_3;
			this.onlyAttackFixHPMaxPercent.Enabled = this.dictionary_0[int_0].bool_3;
		}
	}

	
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

	
	private void method_9()
	{
		this.method_3();
		this.method_2();
	}

	
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

	
	private void f1Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_0.Enabled = this.f1Enable.Checked;
		}
	}

	
	private void f2Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_1.Enabled = this.f2Enable.Checked;
		}
	}

	
	private void f3Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_2.Enabled = this.f3Enable.Checked;
		}
	}

	
	private void f4Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_3.Enabled = this.f4Enable.Checked;
		}
	}

	
	private void f5Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_4.Enabled = this.f5Enable.Checked;
		}
	}

	
	private void f6Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_5.Enabled = this.f6Enable.Checked;
		}
	}

	
	private void f7Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_6.Enabled = this.f7Enable.Checked;
		}
	}

	
	private void f8Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_7.Enabled = this.f8Enable.Checked;
		}
	}

	
	private void f9Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_8.Enabled = this.f9Enable.Checked;
		}
	}

	
	private void f10Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_9.Enabled = this.f10Enable.Checked;
		}
	}

	
	private void f11Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_10.Enabled = this.f11Enable.Checked;
		}
	}

	
	private void f12Enable_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_11.Enabled = this.f12Enable.Checked;
		}
	}

	
	private void f1Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_0.Interval = (int)this.f1Delay.Value * 100;
		}
	}

	
	private void f2Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_1.Interval = (int)this.f2Delay.Value * 100;
		}
	}

	
	private void f3Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_2.Interval = (int)this.f3Delay.Value * 100;
		}
	}

	
	private void f4Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_3.Interval = (int)this.f4Delay.Value * 100;
		}
	}

	
	private void f5Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_4.Interval = (int)this.f5Delay.Value * 100;
		}
	}

	
	private void f6Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_5.Interval = (int)this.f6Delay.Value * 100;
		}
	}

	
	private void f7Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_6.Interval = (int)this.f7Delay.Value * 100;
		}
	}

	
	private void f8Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_7.Interval = (int)this.f8Delay.Value * 100;
		}
	}

	
	private void f9Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_8.Interval = (int)this.f9Delay.Value * 100;
		}
	}

	
	private void f10Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_9.Interval = (int)this.f10Delay.Value * 100;
		}
	}

	
	private void f11Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_10.Interval = (int)this.f11Delay.Value * 100;
		}
	}

	
	private void f12Delay_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_11.Interval = (int)this.f12Delay.Value * 100;
		}
	}

	
	private void isSkill_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].method_7(this.isSkill.Checked);
			this.dictionary_0[(int)this.tabPageAcc.Tag].method_60();
		}
		this.panelSkill.Enabled = this.isSkill.Checked;
	}

	
	private void toolStripMenuItem_0_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_57();
		}
	}

	
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

	
	private void buffPetEnable_CheckedChanged(object sender, EventArgs e)
	{
		this.buffPetPercent.Enabled = this.buffPetEnable.Checked;
		this.buffPetKey.Enabled = this.buffPetEnable.Checked;
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_13.Enabled = this.buffPetEnable.Checked;
		}
	}

	
	private void buffPetPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_0 = (int)this.buffPetPercent.Value;
		}
	}

	
	private void buffPetKey_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_1 = this.buffPetKey.Text;
		}
	}

	
	private void toolStripMenuItem_1_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_61();
		}
	}

	
	private void toolStripMenuItem_2_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_62();
		}
	}

	
	private void button1_Click(object sender, EventArgs e)
	{
		MessageBox.Show(long.MaxValue.ToString());
	}

	
	private void farmEnable_CheckedChanged(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].timer_18.Enabled = this.farmEnable.Checked;
		}
	}

	
	private void farmGo_CheckedChanged(object sender, EventArgs e)
	{
		this.method_10();
	}

	
	private void farmBack_CheckedChanged(object sender, EventArgs e)
	{
		this.method_10();
	}

	
	private void method_10()
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].bool_13 = this.farmGo.Checked;
		}
	}

	
	private void buffMPPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_2 = (int)this.buffMPPercent.Value;
		}
	}

	
	private void buffHPEnable_CheckedChanged(object sender, EventArgs e)
	{
		this.buffHPPercent.Enabled = this.buffHPEnable.Checked;
		this.buffHPKey.Enabled = this.buffHPEnable.Checked;
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_14.Enabled = this.buffHPEnable.Checked;
		}
	}

	
	private void buffMPEnable_CheckedChanged(object sender, EventArgs e)
	{
		this.buffMPPercent.Enabled = this.buffMPEnable.Checked;
		this.buffMPKey.Enabled = this.buffMPEnable.Checked;
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_15.Enabled = this.buffMPEnable.Checked;
		}
	}

	
	private void buffHPPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_1 = (int)this.buffHPPercent.Value;
		}
	}

	
	private void buffHPKey_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_3 = this.buffHPKey.Text;
		}
	}

	
	private void buffMPKey_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_4 = this.buffMPKey.Text;
		}
	}

	
	private void topMost_CheckedChanged(object sender, EventArgs e)
	{
		base.TopMost = this.topMost.Checked;
		Class8.smethod_6(base.TopMost);
	}

	
	private void shutdownAfterKill_CheckedChanged(object sender, EventArgs e)
	{
		GClass0.bool_2 = this.shutdownAfterKill.Checked;
	}

	
	private void exitWhenHPLow_CheckedChanged(object sender, EventArgs e)
	{
		this.exitWhenHPLowPercent.Enabled = this.exitWhenHPLow.Checked;
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].timer_19.Enabled = this.exitWhenHPLow.Checked;
		}
	}

	
	private void exitWhenHPLowPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_8 = (int)this.exitWhenHPLowPercent.Value;
		}
	}

	
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

	
	private void playMusic_Click(object sender, EventArgs e)
	{
		GClass4.smethod_2();
	}

	
	private void stopMusic_Click(object sender, EventArgs e)
	{
		GClass4.smethod_4();
	}

	
	private void musicPath_TextChanged(object sender, EventArgs e)
	{
		Class8.smethod_3(this.musicPath.Text);
	}

	
	private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
	{
		this.notifyIcon_0.Visible = false;
	}

	
	private void notifyIcon_0_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Class4.smethod_6(base.Handle);
			this.method_6();
		}
	}

	
	private void FormMain_Resize(object sender, EventArgs e)
	{
		if (base.WindowState == FormWindowState.Minimized)
		{
			this.method_6();
		}
	}

	
	private void onlyAttackFixHPMinPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_6 = (int)this.onlyAttackFixHPMinPercent.Value;
		}
	}

	
	private void onlyAttackFixHPMaxPercent_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_7 = (int)this.onlyAttackFixHPMaxPercent.Value;
		}
	}

	
	private void onlyAttackFixHP_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].bool_4 = this.onlyAttackFixHP.Checked;
		}
	}

	
	private void toolStripMenuItem_3_Click(object sender, EventArgs e)
	{
		base.Dispose();
	}

	
	private void toolStripMenuItem_4_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.SelectedItems)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_63();
		}
	}

	
	private void resetAutoToolStripMenuItem_Click(object sender, EventArgs e)
	{
		foreach (GClass0 gclass in this.dictionary_0.Values)
		{
			gclass.method_46();
		}
		this.dictionary_0.Clear();
	}

	
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

	
	private void radiusValue_ValueChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].int_3 = (int)this.radiusValue.Value;
		}
	}

	
	private void toolStripMenuItem_5_Click(object sender, EventArgs e)
	{
		this.method_7();
	}

	
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

	
	private void resetExpCaculator_Click(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].method_64();
		}
	}

	
	private void baseSkill_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_0 = this.baseSkill.Text;
		}
	}

	
	private void targetKey_SelectedIndexChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].string_2 = this.targetKey.Text;
		}
	}

	
	private void toolStripMenuItem_6_Click(object sender, EventArgs e)
	{
		this.method_7();
	}

	
	private void tabPageInfo_Enter(object sender, EventArgs e)
	{
		this.timer_0.Start();
	}

	
	private void toolStripMenuItem_7_Click(object sender, EventArgs e)
	{
		this.method_11();
	}

	
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

	
	private void toolStripMenuItem_8_Click(object sender, EventArgs e)
	{
		this.method_11();
	}

	
	private void toolStripMenuItem_10_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_61();
		}
	}

	
	private void toolStripMenuItem_9_Click(object sender, EventArgs e)
	{
		foreach (object obj in this.listViewGame.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_62();
		}
	}

	
	private void toolStripMenuItem_11_Click(object sender, EventArgs e)
	{
		this.method_12();
	}

	
	private void method_12()
	{
		foreach (object obj in this.listViewGame.Items)
		{
			ListViewItem listViewItem = (ListViewItem)obj;
			this.dictionary_0[(int)listViewItem.Tag].method_57();
		}
	}

	
	private GClass0 method_13()
	{
		if (this.tabPageAcc.Tag == null)
		{
			return null;
		}
		return this.dictionary_0[(int)this.tabPageAcc.Tag];
	}

	
	private void toolStripMenuItem_12_Click(object sender, EventArgs e)
	{
		this.method_6();
	}

	
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

	
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.method_4();
	}

	
	private void testAlarm_Click(object sender, EventArgs e)
	{
		new FormAlarm().method_0("Thử nghiệm", GClass0.int_10);
		GClass4.smethod_2();
	}

	
	private void lure_CheckedChanged(object sender, EventArgs e)
	{
		if (this.tabPageAcc.Tag != null)
		{
			this.dictionary_0[(int)this.tabPageAcc.Tag].bool_8 = this.lure.Checked;
		}
	}

	
	private void listViewGame_KeyUp(object sender, KeyEventArgs e)
	{
		if (e.KeyCode == Keys.Next && this.listViewGame.SelectedItems.Count > 0)
		{
			this.method_13().method_62();
		}
	}

	
	private void lToolStripMenuItem_Click(object sender, EventArgs e)
	{
		this.method_12();
	}

	
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

	
	private void contextMenuStripListView_Opening(object sender, CancelEventArgs e)
	{
		bool enabled = this.listViewGame.SelectedItems.Count > 0;
		this.toolStripMenuItem_0.Enabled = enabled;
	}

	
	private bool bool_0;

	
	private Dictionary<int, GClass0> dictionary_0 = new Dictionary<int, GClass0>();

	
	private Class0 class0_0 = new Class0();

	
	private Class6 class6_0 = new Class6();

	
	public static FormAlarm formAlarm_0 = new FormAlarm();

	
	private Stopwatch stopwatch_0 = new Stopwatch();
}
