using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

// Token: 0x0200000B RID: 11
public class GClass0
{
	// Token: 0x06000083 RID: 131 RVA: 0x00002CD8 File Offset: 0x00000ED8
	public ulong method_0()
	{
		return this.ulong_0;
	}

	// Token: 0x06000084 RID: 132 RVA: 0x00002CE0 File Offset: 0x00000EE0
	public void method_1(ulong ulong_1)
	{
		this.ulong_0 = ulong_1;
		Class8.smethod_8(this.method_40(), ulong_1);
	}

	// Token: 0x06000085 RID: 133 RVA: 0x00004D28 File Offset: 0x00002F28
	public int method_2()
	{
		return (int)Math.Sqrt(Math.Pow((double)(this.method_13() - this.int_4), 2.0) + Math.Pow((double)(this.method_17() - this.int_5), 2.0));
	}

	// Token: 0x06000086 RID: 134 RVA: 0x00004D74 File Offset: 0x00002F74
	public int method_3()
	{
		return (int)Math.Sqrt(Math.Pow((double)(this.method_20() - (float)this.int_4), 2.0) + Math.Pow((double)(this.method_21() - (float)this.int_5), 2.0));
	}

	// Token: 0x06000087 RID: 135 RVA: 0x00004DC4 File Offset: 0x00002FC4
	public string method_4()
	{
		if (!this.bool_10)
		{
			return "Bán kính";
		}
		return string.Concat(new object[]
		{
			"Tọa độ ",
			this.int_4,
			", ",
			this.int_5
		});
	}

	// Token: 0x06000088 RID: 136 RVA: 0x00004E18 File Offset: 0x00003018
	public uint method_5()
	{
		if ((long)this.method_41() <= (long)((ulong)this.uint_0))
		{
			return 1U;
		}
		return (uint)((double)((long)this.method_41() - (long)((ulong)this.uint_0)) / (this.stopwatch_8.Elapsed.TotalSeconds + 1.0) * 3600.0);
	}

	// Token: 0x06000089 RID: 137 RVA: 0x00002CF5 File Offset: 0x00000EF5
	public bool method_6()
	{
		return this.bool_7;
	}

	// Token: 0x0600008A RID: 138 RVA: 0x00002CFD File Offset: 0x00000EFD
	public void method_7(bool bool_14)
	{
		if (!bool_14)
		{
			this.method_56();
		}
		else
		{
			this.method_55();
		}
		this.bool_7 = bool_14;
	}

	// Token: 0x0600008B RID: 139 RVA: 0x00004E70 File Offset: 0x00003070
	public int method_8()
	{
		if (this.stopwatch_4.Elapsed.TotalMinutes < 10.0)
		{
			return 1;
		}
		if (this.stopwatch_4.Elapsed.TotalMinutes < 20.0)
		{
			return 2;
		}
		return 3;
	}

	// Token: 0x0600008C RID: 140 RVA: 0x00004EC0 File Offset: 0x000030C0
	public void method_9(int int_20, int int_21)
	{
		if (!GClass0.bool_1 && (this.method_39() != 2 || this.string_5.Equals("")))
		{
			GClass0.bool_1 = true;
			this.method_62();
			this.int_13 = int_20;
			this.int_14 = int_21;
			if (this.thread_0 == null)
			{
				this.thread_0 = new Thread(new ThreadStart(this.method_10));
			}
			if (this.thread_0.ThreadState != System.Threading.ThreadState.Running)
			{
				this.thread_0 = new Thread(new ThreadStart(this.method_10));
				this.thread_0.Start();
			}
			return;
		}
	}

	// Token: 0x0600008D RID: 141 RVA: 0x00004F5C File Offset: 0x0000315C
	public void method_10()
	{
		new Class5(this.intptr_0);
		Thread.Sleep(1000);
		if (Class5.GetForegroundWindow() == this.intptr_0)
		{
			int num = 0;
			while (this.method_39() != 2)
			{
				this.class7_0.method_4(this.method_12(), (float)this.int_13);
				this.class7_0.method_4(this.method_16(), (float)this.int_14);
				num++;
				if (num > 5)
				{
					break;
				}
				Thread.Sleep(1000);
			}
			Thread.Sleep(2000);
		}
		GClass0.bool_1 = false;
	}

	// Token: 0x0600008E RID: 142 RVA: 0x00004FF4 File Offset: 0x000031F4
	public int method_11()
	{
		return this.class7_0.method_1(new int[]
		{
			7319476,
			12
		});
	}

	// Token: 0x0600008F RID: 143 RVA: 0x00002D17 File Offset: 0x00000F17
	public int method_12()
	{
		return this.method_11() + 92;
	}

	// Token: 0x06000090 RID: 144 RVA: 0x00002D22 File Offset: 0x00000F22
	public int method_13()
	{
		return (int)this.class7_0.method_3(this.method_11() + 92);
	}

	// Token: 0x06000091 RID: 145 RVA: 0x00002D39 File Offset: 0x00000F39
	public int method_14()
	{
		return (int)this.class7_0.method_3(this.method_11() + 408);
	}

	// Token: 0x06000092 RID: 146 RVA: 0x00002D53 File Offset: 0x00000F53
	public int method_15()
	{
		return (int)this.class7_0.method_3(this.method_11() + 68);
	}

	// Token: 0x06000093 RID: 147 RVA: 0x00002D6A File Offset: 0x00000F6A
	public int method_16()
	{
		return this.method_11() + 100;
	}

	// Token: 0x06000094 RID: 148 RVA: 0x00002D75 File Offset: 0x00000F75
	public int method_17()
	{
		return (int)this.class7_0.method_3(this.method_11() + 100);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x00002D8C File Offset: 0x00000F8C
	public int method_18()
	{
		return (int)this.class7_0.method_3(this.method_11() + 412);
	}

	// Token: 0x06000096 RID: 150 RVA: 0x00002DA6 File Offset: 0x00000FA6
	public int method_19()
	{
		return (int)this.class7_0.method_3(this.method_11() + 76);
	}

	// Token: 0x06000097 RID: 151 RVA: 0x00005024 File Offset: 0x00003224
	public float method_20()
	{
		if (!this.method_47())
		{
			return (float)this.int_4;
		}
		int[] array = new int[]
		{
			0,
			4,
			8
		};
		int num = 7317332;
		int num2 = 1324;
		int num3 = 68;
		foreach (int num4 in this.list_0)
		{
			Class7 @class = this.class7_0;
			int[] array2 = new int[]
			{
				0,
				16,
				60,
				24,
				168
			};
			array2[0] = num4;
			if (@class.method_1(array2) == 1)
			{
				return this.class7_0.method_2(new int[]
				{
					num4,
					16,
					num3
				});
			}
		}
		foreach (int num5 in array)
		{
			int num6 = this.class7_0.method_1(new int[]
			{
				num,
				num2
			}) + num5;
			Class7 class2 = this.class7_0;
			int[] array4 = new int[]
			{
				0,
				16,
				60,
				24,
				168
			};
			array4[0] = num6;
			if (class2.method_1(array4) == 1)
			{
				this.method_50(num6);
				return this.class7_0.method_2(new int[]
				{
					num6,
					16,
					num3
				});
			}
			foreach (int num7 in array)
			{
				num6 = this.class7_0.method_1(new int[]
				{
					num,
					num2,
					num5
				}) + num7;
				Class7 class3 = this.class7_0;
				int[] array6 = new int[]
				{
					0,
					16,
					60,
					24,
					168
				};
				array6[0] = num6;
				if (class3.method_1(array6) == 1)
				{
					this.method_50(num6);
					return this.class7_0.method_2(new int[]
					{
						num6,
						16,
						num3
					});
				}
				foreach (int num8 in array)
				{
					num6 = this.class7_0.method_1(new int[]
					{
						num,
						num2,
						num5,
						num7
					}) + num8;
					Class7 class4 = this.class7_0;
					int[] array8 = new int[]
					{
						0,
						16,
						60,
						24,
						168
					};
					array8[0] = num6;
					if (class4.method_1(array8) == 1)
					{
						this.method_50(num6);
						return this.class7_0.method_2(new int[]
						{
							num6,
							16,
							num3
						});
					}
					foreach (int num9 in array)
					{
						num6 = this.class7_0.method_1(new int[]
						{
							num,
							num2,
							num5,
							num7,
							num8
						}) + num9;
						Class7 class5 = this.class7_0;
						int[] array10 = new int[]
						{
							0,
							16,
							60,
							24,
							168
						};
						array10[0] = num6;
						if (class5.method_1(array10) == 1)
						{
							this.method_50(num6);
							return this.class7_0.method_2(new int[]
							{
								num6,
								16,
								num3
							});
						}
						foreach (int num10 in array)
						{
							num6 = this.class7_0.method_1(new int[]
							{
								num,
								num2,
								num5,
								num7,
								num8,
								num9
							}) + num10;
							Class7 class6 = this.class7_0;
							int[] array12 = new int[]
							{
								0,
								16,
								60,
								24,
								168
							};
							array12[0] = num6;
							if (class6.method_1(array12) == 1)
							{
								this.method_50(num6);
								return this.class7_0.method_2(new int[]
								{
									num6,
									16,
									num3
								});
							}
							foreach (int num11 in array)
							{
								num6 = this.class7_0.method_1(new int[]
								{
									num,
									num2,
									num5,
									num7,
									num8,
									num9,
									num10
								}) + num11;
								Class7 class7 = this.class7_0;
								int[] array14 = new int[]
								{
									0,
									16,
									60,
									24,
									168
								};
								array14[0] = num6;
								if (class7.method_1(array14) == 1)
								{
									this.method_50(num6);
									return this.class7_0.method_2(new int[]
									{
										num6,
										16,
										num3
									});
								}
							}
						}
					}
				}
			}
		}
		return 0f;
	}

	// Token: 0x06000098 RID: 152 RVA: 0x00005560 File Offset: 0x00003760
	public float method_21()
	{
		if (!this.method_47())
		{
			return (float)this.int_5;
		}
		int[] array = new int[]
		{
			0,
			4,
			8
		};
		int num = 76;
		int num2 = 7317332;
		int num3 = 1324;
		foreach (int num4 in this.list_0)
		{
			Class7 @class = this.class7_0;
			int[] array2 = new int[]
			{
				0,
				16,
				60,
				24,
				168
			};
			array2[0] = num4;
			if (@class.method_1(array2) == 1)
			{
				return this.class7_0.method_2(new int[]
				{
					num4,
					16,
					num
				});
			}
		}
		foreach (int num5 in array)
		{
			int num6 = this.class7_0.method_1(new int[]
			{
				num2,
				num3
			}) + num5;
			Class7 class2 = this.class7_0;
			int[] array4 = new int[]
			{
				0,
				16,
				60,
				24,
				168
			};
			array4[0] = num6;
			if (class2.method_1(array4) == 1)
			{
				this.method_50(num6);
				return this.class7_0.method_2(new int[]
				{
					num6,
					16,
					num
				});
			}
			foreach (int num7 in array)
			{
				num6 = this.class7_0.method_1(new int[]
				{
					num2,
					num3,
					num5
				}) + num7;
				Class7 class3 = this.class7_0;
				int[] array6 = new int[]
				{
					0,
					16,
					60,
					24,
					168
				};
				array6[0] = num6;
				if (class3.method_1(array6) == 1)
				{
					this.method_50(num6);
					return this.class7_0.method_2(new int[]
					{
						num6,
						16,
						num
					});
				}
				foreach (int num8 in array)
				{
					num6 = this.class7_0.method_1(new int[]
					{
						num2,
						num3,
						num5,
						num7
					}) + num8;
					Class7 class4 = this.class7_0;
					int[] array8 = new int[]
					{
						0,
						16,
						60,
						24,
						168
					};
					array8[0] = num6;
					if (class4.method_1(array8) == 1)
					{
						this.method_50(num6);
						return this.class7_0.method_2(new int[]
						{
							num6,
							16,
							num
						});
					}
					foreach (int num9 in array)
					{
						num6 = this.class7_0.method_1(new int[]
						{
							num2,
							num3,
							num5,
							num7,
							num8
						}) + num9;
						Class7 class5 = this.class7_0;
						int[] array10 = new int[]
						{
							0,
							16,
							60,
							24,
							168
						};
						array10[0] = num6;
						if (class5.method_1(array10) == 1)
						{
							this.method_50(num6);
							return this.class7_0.method_2(new int[]
							{
								num6,
								16,
								num
							});
						}
						foreach (int num10 in array)
						{
							num6 = this.class7_0.method_1(new int[]
							{
								num2,
								num3,
								num5,
								num7,
								num8,
								num9
							}) + num10;
							Class7 class6 = this.class7_0;
							int[] array12 = new int[]
							{
								0,
								16,
								60,
								24,
								168
							};
							array12[0] = num6;
							if (class6.method_1(array12) == 1)
							{
								this.method_50(num6);
								return this.class7_0.method_2(new int[]
								{
									num6,
									16,
									num
								});
							}
							foreach (int num11 in array)
							{
								num6 = this.class7_0.method_1(new int[]
								{
									num2,
									num3,
									num5,
									num7,
									num8,
									num9,
									num10
								}) + num11;
								Class7 class7 = this.class7_0;
								int[] array14 = new int[]
								{
									0,
									16,
									60,
									24,
									168
								};
								array14[0] = num6;
								if (class7.method_1(array14) == 1)
								{
									this.method_50(num6);
									return this.class7_0.method_2(new int[]
									{
										num6,
										16,
										num
									});
								}
							}
						}
					}
				}
			}
		}
		return 0f;
	}

	// Token: 0x06000099 RID: 153 RVA: 0x00002DBD File Offset: 0x00000FBD
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.method_22("F1");
	}

	// Token: 0x0600009A RID: 154 RVA: 0x00002DCA File Offset: 0x00000FCA
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.method_22("F2");
	}

	// Token: 0x0600009B RID: 155 RVA: 0x00002DD7 File Offset: 0x00000FD7
	private void timer_2_Tick(object sender, EventArgs e)
	{
		this.method_22("F3");
	}

	// Token: 0x0600009C RID: 156 RVA: 0x00002DE4 File Offset: 0x00000FE4
	private void timer_3_Tick(object sender, EventArgs e)
	{
		this.method_22("F4");
	}

	// Token: 0x0600009D RID: 157 RVA: 0x00002DF1 File Offset: 0x00000FF1
	private void timer_4_Tick(object sender, EventArgs e)
	{
		this.method_22("F5");
	}

	// Token: 0x0600009E RID: 158 RVA: 0x00002DFE File Offset: 0x00000FFE
	private void timer_5_Tick(object sender, EventArgs e)
	{
		this.method_22("F6");
	}

	// Token: 0x0600009F RID: 159 RVA: 0x00002E0B File Offset: 0x0000100B
	private void timer_6_Tick(object sender, EventArgs e)
	{
		this.method_22("F7");
	}

	// Token: 0x060000A0 RID: 160 RVA: 0x00002E18 File Offset: 0x00001018
	private void timer_7_Tick(object sender, EventArgs e)
	{
		this.method_22("F8");
	}

	// Token: 0x060000A1 RID: 161 RVA: 0x00002E25 File Offset: 0x00001025
	private void timer_8_Tick(object sender, EventArgs e)
	{
		this.method_22("F9");
	}

	// Token: 0x060000A2 RID: 162 RVA: 0x00002E32 File Offset: 0x00001032
	private void timer_9_Tick(object sender, EventArgs e)
	{
		this.method_22("F10");
	}

	// Token: 0x060000A3 RID: 163 RVA: 0x00002E3F File Offset: 0x0000103F
	private void timer_10_Tick(object sender, EventArgs e)
	{
		this.method_22("F11");
	}

	// Token: 0x060000A4 RID: 164 RVA: 0x00002E4C File Offset: 0x0000104C
	private void timer_11_Tick(object sender, EventArgs e)
	{
		this.method_22("F12");
	}

	// Token: 0x060000A5 RID: 165 RVA: 0x00002E59 File Offset: 0x00001059
	private void method_22(string string_7)
	{
		if (GClass0.bool_0 || !this.bool_11 || this.bool_5)
		{
			return;
		}
		if (!this.bool_4 && !this.bool_10 && this.method_39() == 2)
		{
			return;
		}
		this.method_54(string_7);
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00005A9C File Offset: 0x00003C9C
	private void timer_13_Tick(object sender, EventArgs e)
	{
		int num = this.method_43();
		if (num > 0 && num < this.int_0 && this.stopwatch_1.ElapsedMilliseconds > 400L)
		{
			this.method_54(this.string_1);
			this.int_15 = num;
			this.stopwatch_1.Reset();
			this.stopwatch_1.Start();
			return;
		}
		this.int_15 = 0;
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00005B04 File Offset: 0x00003D04
	private void timer_14_Tick(object sender, EventArgs e)
	{
		int num = this.method_33();
		if (num > 0 && num < this.int_1 && this.stopwatch_2.ElapsedMilliseconds > 400L)
		{
			this.method_54(this.string_3);
			this.stopwatch_2.Reset();
			this.stopwatch_2.Start();
		}
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00005B60 File Offset: 0x00003D60
	private void timer_15_Tick(object sender, EventArgs e)
	{
		int num = this.method_36();
		if (num > 0 && num < this.int_2 && this.stopwatch_3.ElapsedMilliseconds > 400L)
		{
			this.method_54(this.string_4);
			this.stopwatch_3.Reset();
			this.stopwatch_3.Start();
		}
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00005BBC File Offset: 0x00003DBC
	private void timer_17_Tick(object sender, EventArgs e)
	{
		if (this.method_49() && !this.bool_5)
		{
			this.formAlarm_0 = new FormAlarm();
			this.formAlarm_0.method_0(this.method_38(), GClass0.int_10);
			this.stopwatch_4.Reset();
			this.stopwatch_4.Start();
			this.stopwatch_7.Start();
			GClass4.smethod_2();
			this.bool_5 = true;
			this.method_62();
		}
		if (!this.method_49() && this.bool_5)
		{
			this.formAlarm_0.Dispose();
			this.stopwatch_7.Reset();
			this.bool_5 = false;
			GClass4.smethod_4();
		}
		if (this.stopwatch_7.IsRunning && this.stopwatch_7.Elapsed.Seconds > GClass0.int_10)
		{
			this.method_63();
		}
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00005C8C File Offset: 0x00003E8C
	private void timer_12_Tick(object sender, EventArgs e)
	{
		int num = this.method_39();
		if (num == 0)
		{
			this.stopwatch_0.Start();
		}
		else
		{
			this.stopwatch_0.Reset();
			this.stopwatch_0.Start();
		}
		if (num != 5)
		{
			if (num != 6)
			{
				if (!this.bool_4 && !this.bool_10 && num == 2)
				{
					return;
				}
				if (GClass0.bool_0)
				{
					return;
				}
				bool flag = true;
				if (this.bool_8 && this.stopwatch_5.Elapsed.TotalMilliseconds > 500.0)
				{
					this.method_23();
				}
				if (this.bool_10)
				{
					int num2 = this.method_3();
					if (num2 > this.int_3 && num2 > this.method_2())
					{
						flag = false;
						this.method_23();
					}
				}
				if (this.bool_3)
				{
					if (this.method_48() == 0 && this.method_39() == 0)
					{
						this.method_23();
					}
					if (this.bool_4 && (this.method_48() < this.int_6 || this.method_48() > this.int_7))
					{
						flag = false;
						this.method_23();
					}
				}
				if (!this.method_47())
				{
					this.method_23();
				}
				if (flag)
				{
					if (!this.bool_10 && !this.bool_4 && !this.bool_8)
					{
						if (num == 0)
						{
							this.method_24();
						}
					}
					else
					{
						this.method_24();
					}
				}
				if (this.stopwatch_0.Elapsed.TotalMilliseconds > 700.0 && this.stopwatch_5.Elapsed.TotalMilliseconds > 500.0)
				{
					this.method_23();
				}
				this.bool_11 = flag;
				return;
			}
		}
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00002E94 File Offset: 0x00001094
	private void method_23()
	{
		this.method_54(this.string_2);
		this.stopwatch_5.Reset();
		this.stopwatch_5.Start();
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00002EB8 File Offset: 0x000010B8
	private void method_24()
	{
		this.stopwatch_6.Reset();
		this.stopwatch_6.Start();
		this.method_22(this.string_0);
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00005E1C File Offset: 0x0000401C
	private void timer_16_Tick(object sender, EventArgs e)
	{
		if (!Class4.smethod_5(this.int_12) && GClass0.gdelegate1_0 != null)
		{
			this.method_46();
			GClass0.gdelegate1_0(this.int_12);
		}
		string text = this.method_38();
		if (this.string_5 != text)
		{
			if (!this.bool_6)
			{
				GClass0.gdelegate1_1(this.int_12);
			}
			if (text != "Đăng nhập")
			{
				this.string_5 = text;
				this.method_58();
			}
			else
			{
				this.bool_6 = true;
			}
		}
		else if (this.bool_6)
		{
			GClass0.gdelegate1_1(this.int_12);
			this.bool_6 = false;
		}
		if (!this.bool_3 && this.method_48() > 0 && this.method_48() < 100)
		{
			this.bool_3 = true;
			GClass0.gdelegate2_0(this.int_12);
		}
		if (this.string_6 != this.method_27() && this.method_38() != "" && Class4.smethod_5(this.int_12) && Process.GetProcessById(this.int_12).Responding)
		{
			if (this.string_6 == "")
			{
				this.method_58();
			}
			this.string_6 = this.method_27();
			this.bool_3 = false;
			GClass0.gdelegate2_0(this.int_12);
			this.method_60();
			this.intptr_0 = Class4.smethod_4(this.int_12);
			this.list_0.Clear();
		}
		if (this.method_40() > this.int_9)
		{
			this.int_9 = this.method_40();
			this.uint_0 = 0U;
			this.method_1(Class8.smethod_7(this.method_40()));
			this.method_64();
		}
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00002EDC File Offset: 0x000010DC
	private void timer_19_Tick(object sender, EventArgs e)
	{
		if (this.method_33() > 0 && this.method_33() < this.int_8)
		{
			this.method_63();
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00005FD4 File Offset: 0x000041D4
	private void timer_18_Tick(object sender, EventArgs e)
	{
		if (!this.bool_12 && this.method_39() == 0)
		{
			this.method_62();
			this.bool_12 = true;
		}
		if (this.method_39() == 2)
		{
			this.bool_12 = false;
		}
		string text = GClass3.smethod_0(this.method_27()).ToLower().Trim();
		int num = this.method_15();
		int num2 = this.method_19();
		if (this.bool_13)
		{
			if (text.Equals("heaven") && (Math.Abs(num - 107) > 30 || Math.Abs(num2 - 167) > 30))
			{
				this.method_9(101, 167);
			}
			if (text.Equals("nhon nam") && (Math.Abs(num - 264) > 30 || Math.Abs(num2 - 293) > 30))
			{
				this.method_9(264, 293);
			}
			if (text.Equals("loc duong") && (Math.Abs(num - 33) > 30 || Math.Abs(num2 - 130) > 30))
			{
				this.method_9(33, 130);
			}
			if (text.Equals("don hoang") && (Math.Abs(num - 231) > 30 || Math.Abs(num2 - 289) > 30))
			{
				this.method_9(231, 289);
			}
			if (text.Equals("kiem cac") && (Math.Abs(num - 36) > 30 || Math.Abs(num2 - 300) > 30))
			{
				this.method_9(36, 300);
			}
			if (text.Equals("doi lu") && (Math.Abs(num - 160) > 30 || Math.Abs(num2 - 295) > 30))
			{
				this.method_9(160, 292);
			}
			if (text.Equals("nhi hai") && (Math.Abs(num - 285) > 30 || Math.Abs(num2 - 180) > 30))
			{
				this.method_9(285, 180);
			}
			if (text.Equals("bangthien") && (Math.Abs(num - 150) > 30 || Math.Abs(num2 - 50) > 30))
			{
				this.method_9(150, 50);
				return;
			}
		}
		else
		{
			if (text.Equals("bangthien") && (Math.Abs(num - 101) > 30 || Math.Abs(num2 - 168) > 30))
			{
				this.method_9(101, 168);
			}
			if (text.Equals("nhi hai") && (Math.Abs(num - 287) > 30 || Math.Abs(num2 - 21) > 30))
			{
				this.method_9(287, 21);
			}
			if (text.Equals("doi lu") && (Math.Abs(num - 25) > 30 || Math.Abs(num2 - 152) > 30))
			{
				this.method_9(25, 152);
			}
			if (text.Equals("kiem cac") && (Math.Abs(num - 105) > 30 || Math.Abs(num2 - 26) > 30))
			{
				this.method_9(105, 26);
			}
			if (text.Equals("don hoang") && (Math.Abs(num - 287) > 30 || Math.Abs(num2 - 144) > 30))
			{
				this.method_9(287, 144);
			}
			if (text.Equals("loc duong") && (Math.Abs(num - 287) > 30 || Math.Abs(num2 - 127) > 30))
			{
				this.method_9(287, 127);
			}
			if (text.Equals("nhon nam") && (Math.Abs(num - 72) > 30 || Math.Abs(num2 - 284) > 30))
			{
				this.method_9(72, 284);
			}
			if (text.Equals("heaven") && (Math.Abs(num - 150) > 30 || Math.Abs(num2 - 50) > 30))
			{
				this.method_9(150, 50);
			}
		}
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00002EFB File Offset: 0x000010FB
	private void timer_16_Tick_1(object sender, EventArgs e)
	{
		if (this.method_40() < 1)
		{
			return;
		}
		this.method_1(Class8.smethod_7(this.method_40()));
		this.timer_16.Tick -= this.timer_16_Tick_1;
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x000063CC File Offset: 0x000045CC
	public int method_25()
	{
		return this.class7_0.method_1(new int[]
		{
			6870940,
			14232
		});
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00002F2F File Offset: 0x0000112F
	public int method_26()
	{
		return this.class7_0.method_0(this.method_25() + 8);
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x000063FC File Offset: 0x000045FC
	public string method_27()
	{
		if (!(this.class7_0.method_5(this.class7_0.method_0(this.method_25() + 96)) == ""))
		{
			return this.class7_0.method_5(this.class7_0.method_0(this.method_25() + 96));
		}
		return this.class7_0.method_5(this.method_25() + 96);
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00002F44 File Offset: 0x00001144
	public int method_28()
	{
		return this.class7_0.method_0(this.method_25() + 160);
	}

	// Token: 0x060000B5 RID: 181 RVA: 0x00002F5D File Offset: 0x0000115D
	public int method_29()
	{
		return this.class7_0.method_1(new int[]
		{
			7319476,
			12,
			344,
			4
		});
	}

	// Token: 0x060000B6 RID: 182 RVA: 0x00002F7B File Offset: 0x0000117B
	public int method_30()
	{
		return this.class7_0.method_0(this.method_29() + 16);
	}

	// Token: 0x060000B7 RID: 183 RVA: 0x00002F91 File Offset: 0x00001191
	public int method_31()
	{
		return this.class7_0.method_0(this.method_29() + 2292);
	}

	// Token: 0x060000B8 RID: 184 RVA: 0x00002FAA File Offset: 0x000011AA
	public int method_32()
	{
		return this.class7_0.method_0(this.method_29() + 2400);
	}

	// Token: 0x060000B9 RID: 185 RVA: 0x00002FC3 File Offset: 0x000011C3
	public int method_33()
	{
		if (this.method_32() == 0)
		{
			return 100;
		}
		return (int)((float)this.method_31() * 100f / (float)this.method_32());
	}

	// Token: 0x060000BA RID: 186 RVA: 0x00002FE6 File Offset: 0x000011E6
	public int method_34()
	{
		return this.class7_0.method_0(this.method_29() + 2296);
	}

	// Token: 0x060000BB RID: 187 RVA: 0x00002FFF File Offset: 0x000011FF
	public int method_35()
	{
		return this.class7_0.method_0(this.method_29() + 2404);
	}

	// Token: 0x060000BC RID: 188 RVA: 0x00003018 File Offset: 0x00001218
	public int method_36()
	{
		if (this.method_35() == 0)
		{
			return 100;
		}
		return (int)(100f * (float)this.method_34() / (float)this.method_35());
	}

	// Token: 0x060000BD RID: 189 RVA: 0x0000303B File Offset: 0x0000123B
	public int method_37()
	{
		return this.class7_0.method_0(this.method_29() + 2356);
	}

	// Token: 0x060000BE RID: 190 RVA: 0x00006468 File Offset: 0x00004668
	public string method_38()
	{
		string text = this.class7_0.method_5(this.method_29() + 48);
		if (text == "")
		{
			return "Đăng nhập";
		}
		return text;
	}

	// Token: 0x060000BF RID: 191 RVA: 0x00003054 File Offset: 0x00001254
	public int method_39()
	{
		return this.class7_0.method_1(new int[]
		{
			7319476,
			12,
			348
		});
	}

	// Token: 0x060000C0 RID: 192 RVA: 0x00003072 File Offset: 0x00001272
	public int method_40()
	{
		return this.class7_0.method_0(this.method_29() + 92);
	}

	// Token: 0x060000C1 RID: 193 RVA: 0x00003088 File Offset: 0x00001288
	public int method_41()
	{
		return this.class7_0.method_0(this.method_29() + 2300);
	}

	// Token: 0x060000C2 RID: 194 RVA: 0x000064A0 File Offset: 0x000046A0
	public int method_42()
	{
		return this.class7_0.method_1(new int[]
		{
			7319540,
			299356
		});
	}

	// Token: 0x060000C3 RID: 195 RVA: 0x000064D0 File Offset: 0x000046D0
	public int method_43()
	{
		if (this.method_37() == 0)
		{
			return 0;
		}
		int num = this.method_44();
		int num2 = this.class7_0.method_0(this.method_42() + num * this.int_16 + this.int_17);
		int num3 = this.class7_0.method_0(this.method_42() + num * this.int_16 + this.int_18);
		if (num3 == 0)
		{
			return 0;
		}
		return (int)((float)num2 / (float)num3 * 100f);
	}

	// Token: 0x060000C4 RID: 196 RVA: 0x00006544 File Offset: 0x00004744
	public int method_44()
	{
		for (int i = 0; i < 20; i++)
		{
			int num = this.class7_0.method_0(this.method_42() + i * this.int_16 + this.int_19);
			if (num == this.method_37())
			{
				return i;
			}
			if (num == 0)
			{
				return -1;
			}
		}
		return -1;
	}

	// Token: 0x060000C5 RID: 197 RVA: 0x00006594 File Offset: 0x00004794
	private void method_45()
	{
		this.timer_16.Tick += this.timer_16_Tick;
		this.timer_16.Tick += this.timer_16_Tick_1;
		this.timer_12.Tick += this.timer_12_Tick;
		this.timer_13.Tick += this.timer_13_Tick;
		this.timer_17.Tick += this.timer_17_Tick;
		this.timer_18.Tick += this.timer_18_Tick;
		this.timer_15.Tick += this.timer_15_Tick;
		this.timer_14.Tick += this.timer_14_Tick;
		this.timer_19.Tick += this.timer_19_Tick;
		this.timer_16.Interval = 10000;
		this.timer_17.Interval = 1000;
		this.timer_17.Start();
		this.timer_16.Start();
		this.stopwatch_1.Start();
		this.stopwatch_2.Start();
		this.stopwatch_3.Start();
		this.stopwatch_5.Start();
		this.stopwatch_6.Start();
		this.stopwatch_8.Start();
	}

	// Token: 0x060000C6 RID: 198 RVA: 0x000066E8 File Offset: 0x000048E8
	public GClass0(int int_20)
	{
		this.method_45();
		this.int_12 = int_20;
		this.class7_0 = new Class7(int_20);
		this.intptr_0 = Class4.smethod_4(int_20);
		this.method_58();
		this.string_5 = this.method_38();
		this.uint_0 = (uint)this.method_41();
		this.string_6 = this.method_27();
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00006948 File Offset: 0x00004B48
	public void method_46()
	{
		this.timer_0.Dispose();
		this.timer_1.Dispose();
		this.timer_2.Dispose();
		this.timer_3.Dispose();
		this.timer_4.Dispose();
		this.timer_5.Dispose();
		this.timer_6.Dispose();
		this.timer_7.Dispose();
		this.timer_8.Dispose();
		this.timer_9.Dispose();
		this.timer_10.Dispose();
		this.timer_11.Dispose();
		this.timer_13.Dispose();
		this.timer_14.Dispose();
		this.timer_15.Dispose();
		this.stopwatch_1.Stop();
		this.stopwatch_2.Stop();
		this.stopwatch_3.Stop();
		this.stopwatch_8.Stop();
		this.stopwatch_7.Stop();
		this.timer_16.Dispose();
		this.timer_17.Dispose();
		this.timer_19.Dispose();
		this.timer_12.Dispose();
		this.class7_0.method_6();
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x000030A1 File Offset: 0x000012A1
	public bool method_47()
	{
		return this.class7_0.method_1(new int[]
		{
			7254568,
			0,
			12,
			100
		}) == 1;
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x000030C5 File Offset: 0x000012C5
	public int method_48()
	{
		return (int)(this.class7_0.method_2(new int[]
		{
			7254568,
			0,
			12,
			144,
			32,
			4,
			624
		}) * 100f);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000030EA File Offset: 0x000012EA
	public bool method_49()
	{
		return this.class7_0.method_1(new int[]
		{
			7264696,
			0,
			12,
			100
		}) == 1;
	}

	// Token: 0x060000CB RID: 203 RVA: 0x0000310E File Offset: 0x0000130E
	public void method_50(int int_20)
	{
		if (this.list_0.Count > 20)
		{
			this.list_0.Clear();
		}
		if (!this.list_0.Contains(int_20))
		{
			this.list_0.Add(int_20);
		}
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00006A68 File Offset: 0x00004C68
	public string method_51()
	{
		return string.Concat(new object[]
		{
			this.stopwatch_4.Elapsed.Hours,
			":",
			this.stopwatch_4.Elapsed.Minutes,
			":",
			this.stopwatch_4.Elapsed.Seconds
		});
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00006AE4 File Offset: 0x00004CE4
	public string method_52()
	{
		return string.Concat(new object[]
		{
			this.stopwatch_8.Elapsed.Hours,
			":",
			this.stopwatch_8.Elapsed.Minutes,
			":",
			this.stopwatch_8.Elapsed.Seconds
		});
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00006B60 File Offset: 0x00004D60
	public string method_53()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (this.bool_3)
		{
			stringBuilder.AppendLine("Mục tiêu: " + this.method_48() + "%");
		}
		else
		{
			stringBuilder.AppendLine("Mục tiêu: chưa phát hiện được");
		}
		stringBuilder.AppendLine("Exp ban đầu: " + string.Format("{0:#,#.}", this.uint_0));
		stringBuilder.AppendLine("Exp hiện tại: " + string.Format("{0:#,#.}", this.method_41()));
		stringBuilder.AppendLine("Exp nhận được: " + string.Format("{0:#,#.}", (long)this.method_41() - (long)((ulong)this.uint_0)));
		if (this.method_0() != 0UL)
		{
			stringBuilder.AppendLine("Exp tối đa: " + string.Format("{0:#,#.}", this.method_0()));
		}
		else
		{
			stringBuilder.AppendLine("Exp tối đa: Các hạ cần nhập vào");
		}
		stringBuilder.AppendLine("Thời gian luyện cấp: " + this.method_52());
		stringBuilder.AppendLine("Tốc độ train: " + string.Format("{0:#,#.}", this.method_5()) + " Exp / Giờ");
		stringBuilder.AppendLine("Để thăng cấp cần: ");
		ulong num = this.method_0() - (ulong)((long)this.method_41());
		if (this.method_0() != 0UL)
		{
			if (num > 0UL)
			{
				int num2 = (int)Math.Floor((double)(num / this.method_5() / 24f));
				int num3 = (int)(num / (ulong)this.method_5()) % 24;
				int num4;
				if (this.method_5() / 60U == 0U)
				{
					num4 = 0;
				}
				else
				{
					num4 = (int)(num / (ulong)(this.method_5() / 60U)) % 60;
				}
				stringBuilder.AppendLine(string.Concat(new object[]
				{
					"- Thời gian : ",
					num2,
					" ngày, ",
					num3,
					" giờ, ",
					num4,
					" phút"
				}));
			}
			else
			{
				stringBuilder.AppendLine("- Đã đủ Exp để thăng cấp");
			}
		}
		else
		{
			stringBuilder.AppendLine("- Thời gian: Cần nhập vào Exp tối đa");
		}
		if (this.bool_10)
		{
			stringBuilder.AppendLine("Bán kính nhân vật : " + this.method_2().ToString());
			stringBuilder.AppendLine("Bán kính mục tiêu : " + this.method_3().ToString());
		}
		else
		{
			stringBuilder.AppendLine("Bán kính hiện tại: ko sử dụng");
		}
		stringBuilder.AppendLine("Vị trí: " + this.method_27());
		return stringBuilder.ToString();
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00006E20 File Offset: 0x00005020
	public void method_54(string string_7)
	{
		if (this.bool_5)
		{
			return;
		}
		switch (string_7)
		{
		case "F1":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 112, 0);
			return;
		case "F2":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 113, 0);
			return;
		case "F3":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 114, 0);
			return;
		case "F4":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 115, 0);
			return;
		case "F5":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 116, 0);
			return;
		case "F6":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 117, 0);
			return;
		case "F7":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 118, 0);
			return;
		case "F8":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 119, 0);
			return;
		case "F9":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 120, 0);
			return;
		case "F10":
			Class9.SendMessage(this.intptr_0, Class9.int_1, 121, 0);
			return;
		case "F11":
			Class9.SendMessage(this.intptr_0, Class9.int_0, 122, 0);
			return;
		case "F12":
			Class9.SendMessage(this.intptr_0, Class9.int_0, 123, 0);
			break;

			return;
		}
	}

	// Token: 0x060000D0 RID: 208 RVA: 0x00007034 File Offset: 0x00005234
	public void method_55()
	{
		if (!this.bool_7)
		{
			this.timer_0.Tick += this.timer_0_Tick;
			this.timer_1.Tick += this.timer_1_Tick;
			this.timer_2.Tick += this.timer_2_Tick;
			this.timer_3.Tick += this.timer_3_Tick;
			this.timer_4.Tick += this.timer_4_Tick;
			this.timer_5.Tick += this.timer_5_Tick;
			this.timer_6.Tick += this.timer_6_Tick;
			this.timer_7.Tick += this.timer_7_Tick;
			this.timer_8.Tick += this.timer_8_Tick;
			this.timer_9.Tick += this.timer_9_Tick;
			this.timer_10.Tick += this.timer_10_Tick;
			this.timer_11.Tick += this.timer_11_Tick;
			this.bool_7 = true;
		}
	}

	// Token: 0x060000D1 RID: 209 RVA: 0x00007168 File Offset: 0x00005368
	public void method_56()
	{
		this.timer_0.Tick -= this.timer_0_Tick;
		this.timer_1.Tick -= this.timer_1_Tick;
		this.timer_2.Tick -= this.timer_2_Tick;
		this.timer_3.Tick -= this.timer_3_Tick;
		this.timer_4.Tick -= this.timer_4_Tick;
		this.timer_5.Tick -= this.timer_5_Tick;
		this.timer_6.Tick -= this.timer_6_Tick;
		this.timer_7.Tick -= this.timer_7_Tick;
		this.timer_8.Tick -= this.timer_8_Tick;
		this.timer_9.Tick -= this.timer_9_Tick;
		this.timer_10.Tick -= this.timer_10_Tick;
		this.timer_11.Tick -= this.timer_11_Tick;
	}

	// Token: 0x060000D2 RID: 210 RVA: 0x0000728C File Offset: 0x0000548C
	public void method_57()
	{
		this.class2_0.method_1(this.method_6());
		this.class2_0.method_5(this.timer_12.Enabled);
		this.class2_0.method_15(this.timer_0.Enabled);
		this.class2_0.method_17(this.timer_1.Enabled);
		this.class2_0.method_19(this.timer_2.Enabled);
		this.class2_0.method_21(this.timer_3.Enabled);
		this.class2_0.method_23(this.timer_4.Enabled);
		this.class2_0.method_25(this.timer_5.Enabled);
		this.class2_0.method_27(this.timer_6.Enabled);
		this.class2_0.method_29(this.timer_7.Enabled);
		this.class2_0.method_31(this.timer_8.Enabled);
		this.class2_0.method_33(this.timer_9.Enabled);
		this.class2_0.method_35(this.timer_10.Enabled);
		this.class2_0.method_37(this.timer_11.Enabled);
		this.class2_0.method_43(this.timer_0.Interval);
		this.class2_0.method_45(this.timer_1.Interval);
		this.class2_0.method_47(this.timer_2.Interval);
		this.class2_0.method_49(this.timer_3.Interval);
		this.class2_0.method_51(this.timer_4.Interval);
		this.class2_0.method_53(this.timer_5.Interval);
		this.class2_0.method_55(this.timer_6.Interval);
		this.class2_0.method_57(this.timer_7.Interval);
		this.class2_0.method_59(this.timer_8.Interval);
		this.class2_0.method_61(this.timer_9.Interval);
		this.class2_0.method_63(this.timer_10.Interval);
		this.class2_0.method_65(this.timer_11.Interval);
		this.class2_0.method_9(this.timer_13.Enabled);
		this.class2_0.method_67(this.int_0);
		this.class2_0.method_79(this.string_1);
		this.class2_0.method_11(this.timer_14.Enabled);
		this.class2_0.method_69(this.int_1);
		this.class2_0.method_81(this.string_3);
		this.class2_0.method_13(this.timer_15.Enabled);
		this.class2_0.method_71(this.int_2);
		this.class2_0.method_83(this.string_4);
		this.class2_0.method_77(this.int_8);
		this.class2_0.method_7(this.bool_4);
		this.class2_0.method_73(this.int_6);
		this.class2_0.method_75(this.int_7);
		this.class2_0.method_3(this.bool_10);
		this.class2_0.method_41(this.int_3);
		this.class2_0.method_85(this.string_0);
		this.class2_0.method_87(this.string_2);
		this.class2_0.method_39(this.bool_8);
	}

	// Token: 0x060000D3 RID: 211 RVA: 0x00007614 File Offset: 0x00005814
	public void method_58()
	{
		this.class2_0 = new Class2(GClass3.smethod_0(this.method_38()));
		this.method_7(this.class2_0.method_0());
		this.timer_12.Enabled = this.class2_0.method_4();
		this.timer_0.Enabled = this.class2_0.method_14();
		this.timer_1.Enabled = this.class2_0.method_16();
		this.timer_2.Enabled = this.class2_0.method_18();
		this.timer_3.Enabled = this.class2_0.method_20();
		this.timer_4.Enabled = this.class2_0.method_22();
		this.timer_5.Enabled = this.class2_0.method_24();
		this.timer_6.Enabled = this.class2_0.method_26();
		this.timer_7.Enabled = this.class2_0.method_28();
		this.timer_8.Enabled = this.class2_0.method_30();
		this.timer_9.Enabled = this.class2_0.method_32();
		this.timer_10.Enabled = this.class2_0.method_34();
		this.timer_11.Enabled = this.class2_0.method_36();
		this.timer_0.Interval = this.class2_0.method_42();
		this.timer_1.Interval = this.class2_0.method_44();
		this.timer_2.Interval = this.class2_0.method_46();
		this.timer_3.Interval = this.class2_0.method_48();
		this.timer_4.Interval = this.class2_0.method_50();
		this.timer_5.Interval = this.class2_0.method_52();
		this.timer_6.Interval = this.class2_0.method_54();
		this.timer_7.Interval = this.class2_0.method_56();
		this.timer_8.Interval = this.class2_0.method_58();
		this.timer_9.Interval = this.class2_0.method_60();
		this.timer_10.Interval = this.class2_0.method_62();
		this.timer_11.Interval = this.class2_0.method_64();
		this.timer_13.Enabled = this.class2_0.method_8();
		this.int_0 = this.class2_0.method_66();
		this.string_1 = this.class2_0.method_78();
		this.timer_14.Enabled = this.class2_0.method_10();
		this.int_1 = this.class2_0.method_68();
		this.string_3 = this.class2_0.method_80();
		this.timer_15.Enabled = this.class2_0.method_12();
		this.int_2 = this.class2_0.method_70();
		this.string_4 = this.class2_0.method_82();
		this.int_8 = this.class2_0.method_76();
		this.bool_4 = this.class2_0.method_6();
		this.int_6 = this.class2_0.method_72();
		this.int_7 = this.class2_0.method_74();
		this.bool_10 = this.class2_0.method_2();
		this.int_3 = this.class2_0.method_40();
		this.int_4 = this.method_13();
		this.int_5 = this.method_17();
		this.string_0 = this.class2_0.method_84();
		this.string_2 = this.class2_0.method_86();
		this.bool_8 = this.class2_0.method_38();
		this.method_60();
	}

	// Token: 0x060000D4 RID: 212 RVA: 0x000079D0 File Offset: 0x00005BD0
	private string method_59()
	{
		if (GClass0.bool_0)
		{
			return "Stoped All";
		}
		if (this.timer_12.Enabled && this.method_6())
		{
			return "Target & Skill";
		}
		if (this.timer_12.Enabled && !this.method_6())
		{
			return "Target";
		}
		if (!this.timer_12.Enabled && this.method_6())
		{
			return "Skill";
		}
		return "Stoped";
	}

	// Token: 0x060000D5 RID: 213 RVA: 0x00007A40 File Offset: 0x00005C40
	public void method_60()
	{
		string text = GClass3.smethod_0(this.method_38());
		Class5.SetWindowText(this.intptr_0, string.Concat(new string[]
		{
			text,
			"(",
			this.method_59(),
			") - ",
			GClass3.smethod_0(this.method_27())
		}));
	}

	// Token: 0x060000D6 RID: 214 RVA: 0x00003144 File Offset: 0x00001344
	public void method_61()
	{
		Class9.ShowWindow(this.intptr_0, 0);
		Class8.smethod_1(this.int_12.ToString(), this.intptr_0.ToString());
	}

	// Token: 0x060000D7 RID: 215 RVA: 0x00007AA0 File Offset: 0x00005CA0
	public void method_62()
	{
		new Class5(this.intptr_0).method_8();
		try
		{
			IntPtr intPtr = (IntPtr)Convert.ToInt32(Class8.smethod_0(this.int_12.ToString()));
			if (this.intptr_0 != intPtr)
			{
				new Class5(intPtr).method_8();
			}
		}
		catch
		{
		}
		this.intptr_0 = Class4.smethod_4(this.int_12);
	}

	// Token: 0x060000D8 RID: 216 RVA: 0x00007B18 File Offset: 0x00005D18
	public void method_63()
	{
		try
		{
			Process.GetProcessById(this.int_12).Kill();
			this.method_46();
			GClass0.gdelegate1_0(this.int_12);
			if (GClass0.bool_2)
			{
				Process.Start("shutdown", "-s -t 0");
			}
		}
		catch
		{
		}
	}

	// Token: 0x060000D9 RID: 217 RVA: 0x00003174 File Offset: 0x00001374
	public void method_64()
	{
		this.stopwatch_8.Reset();
		this.stopwatch_8.Start();
		this.uint_0 = (uint)this.method_41();
	}

	// Token: 0x060000DA RID: 218 RVA: 0x00007B78 File Offset: 0x00005D78
	private long method_65(byte byte_0)
	{
		long value = 6847512L;
		long[] array = new long[]
		{
			928L,
			608L,
			144L,
			12L,
			244L,
			0L,
			0L,
			16L,
			4L,
			1636L
		};
		byte[] array2 = new byte[4];
		int num = 2;
		for (byte b = 0; b < 4; b += 1)
		{
			GClass0.ReadProcessMemory(this.class7_0.intptr_0, (IntPtr)value, array2, 4, out num);
			value = (long)BitConverter.ToInt32(array2, 0) + array[(int)b];
		}
		GClass0.ReadProcessMemory(this.class7_0.intptr_0, (IntPtr)value, array2, 4, out num);
		value = (long)BitConverter.ToInt32(array2, 0) + array[4] + (long)(12 * byte_0);
		for (byte b = 5; b < 10; b += 1)
		{
			GClass0.ReadProcessMemory(this.class7_0.intptr_0, (IntPtr)value, array2, 4, out num);
			value = (long)BitConverter.ToInt32(array2, 0) + array[(int)b];
		}
		GClass0.ReadProcessMemory(this.class7_0.intptr_0, (IntPtr)value, array2, 1, out num);
		return (long)((ulong)array2[0]);
	}

	// Token: 0x060000DB RID: 219
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_1, IntPtr intptr_2, [Out] byte[] byte_0, int int_20, out int int_21);

	// Token: 0x0400000F RID: 15
	public static bool bool_0 = false;

	// Token: 0x04000010 RID: 16
	public static bool bool_1 = false;

	// Token: 0x04000011 RID: 17
	public static bool bool_2 = false;

	// Token: 0x04000012 RID: 18
	public bool bool_3;

	// Token: 0x04000013 RID: 19
	public bool bool_4;

	// Token: 0x04000014 RID: 20
	public bool bool_5;

	// Token: 0x04000015 RID: 21
	private bool bool_6;

	// Token: 0x04000016 RID: 22
	public bool bool_7;

	// Token: 0x04000017 RID: 23
	public bool bool_8;

	// Token: 0x04000018 RID: 24
	public bool bool_9 = true;

	// Token: 0x04000019 RID: 25
	public string string_0 = "F1";

	// Token: 0x0400001A RID: 26
	public string string_1 = "F9";

	// Token: 0x0400001B RID: 27
	public string string_2 = "F11";

	// Token: 0x0400001C RID: 28
	public string string_3 = "F8";

	// Token: 0x0400001D RID: 29
	public string string_4 = "F7";

	// Token: 0x0400001E RID: 30
	public int int_0 = 50;

	// Token: 0x0400001F RID: 31
	public int int_1 = 50;

	// Token: 0x04000020 RID: 32
	public int int_2 = 50;

	// Token: 0x04000021 RID: 33
	public int int_3 = 20;

	// Token: 0x04000022 RID: 34
	public int int_4;

	// Token: 0x04000023 RID: 35
	public int int_5;

	// Token: 0x04000024 RID: 36
	public int int_6;

	// Token: 0x04000025 RID: 37
	public int int_7 = 100;

	// Token: 0x04000026 RID: 38
	public int int_8 = 50;

	// Token: 0x04000027 RID: 39
	public bool bool_10;

	// Token: 0x04000028 RID: 40
	public ulong ulong_0;

	// Token: 0x04000029 RID: 41
	public int int_9;

	// Token: 0x0400002A RID: 42
	public uint uint_0;

	// Token: 0x0400002B RID: 43
	public static int int_10 = 50;

	// Token: 0x0400002C RID: 44
	public static GDelegate1 gdelegate1_0;

	// Token: 0x0400002D RID: 45
	public static GDelegate1 gdelegate1_1;

	// Token: 0x0400002E RID: 46
	public static GDelegate2 gdelegate2_0;

	// Token: 0x0400002F RID: 47
	public int int_11;

	// Token: 0x04000030 RID: 48
	public string string_5 = "";

	// Token: 0x04000031 RID: 49
	public string string_6 = "Khong biet";

	// Token: 0x04000032 RID: 50
	public Stopwatch stopwatch_0 = new Stopwatch();

	// Token: 0x04000033 RID: 51
	public Stopwatch stopwatch_1 = new Stopwatch();

	// Token: 0x04000034 RID: 52
	public Stopwatch stopwatch_2 = new Stopwatch();

	// Token: 0x04000035 RID: 53
	public Stopwatch stopwatch_3 = new Stopwatch();

	// Token: 0x04000036 RID: 54
	public Stopwatch stopwatch_4 = new Stopwatch();

	// Token: 0x04000037 RID: 55
	public Stopwatch stopwatch_5 = new Stopwatch();

	// Token: 0x04000038 RID: 56
	public Stopwatch stopwatch_6 = new Stopwatch();

	// Token: 0x04000039 RID: 57
	private Stopwatch stopwatch_7 = new Stopwatch();

	// Token: 0x0400003A RID: 58
	public Stopwatch stopwatch_8 = new Stopwatch();

	// Token: 0x0400003B RID: 59
	private Class2 class2_0;

	// Token: 0x0400003C RID: 60
	public int int_12;

	// Token: 0x0400003D RID: 61
	private Class7 class7_0;

	// Token: 0x0400003E RID: 62
	public IntPtr intptr_0;

	// Token: 0x0400003F RID: 63
	public int int_13;

	// Token: 0x04000040 RID: 64
	public int int_14;

	// Token: 0x04000041 RID: 65
	private Thread thread_0;

	// Token: 0x04000042 RID: 66
	public System.Windows.Forms.Timer timer_0 = new System.Windows.Forms.Timer();

	// Token: 0x04000043 RID: 67
	public System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();

	// Token: 0x04000044 RID: 68
	public System.Windows.Forms.Timer timer_2 = new System.Windows.Forms.Timer();

	// Token: 0x04000045 RID: 69
	public System.Windows.Forms.Timer timer_3 = new System.Windows.Forms.Timer();

	// Token: 0x04000046 RID: 70
	public System.Windows.Forms.Timer timer_4 = new System.Windows.Forms.Timer();

	// Token: 0x04000047 RID: 71
	public System.Windows.Forms.Timer timer_5 = new System.Windows.Forms.Timer();

	// Token: 0x04000048 RID: 72
	public System.Windows.Forms.Timer timer_6 = new System.Windows.Forms.Timer();

	// Token: 0x04000049 RID: 73
	public System.Windows.Forms.Timer timer_7 = new System.Windows.Forms.Timer();

	// Token: 0x0400004A RID: 74
	public System.Windows.Forms.Timer timer_8 = new System.Windows.Forms.Timer();

	// Token: 0x0400004B RID: 75
	public System.Windows.Forms.Timer timer_9 = new System.Windows.Forms.Timer();

	// Token: 0x0400004C RID: 76
	public System.Windows.Forms.Timer timer_10 = new System.Windows.Forms.Timer();

	// Token: 0x0400004D RID: 77
	public System.Windows.Forms.Timer timer_11 = new System.Windows.Forms.Timer();

	// Token: 0x0400004E RID: 78
	public System.Windows.Forms.Timer timer_12 = new System.Windows.Forms.Timer();

	// Token: 0x0400004F RID: 79
	public System.Windows.Forms.Timer timer_13 = new System.Windows.Forms.Timer();

	// Token: 0x04000050 RID: 80
	public System.Windows.Forms.Timer timer_14 = new System.Windows.Forms.Timer();

	// Token: 0x04000051 RID: 81
	public System.Windows.Forms.Timer timer_15 = new System.Windows.Forms.Timer();

	// Token: 0x04000052 RID: 82
	public System.Windows.Forms.Timer timer_16 = new System.Windows.Forms.Timer();

	// Token: 0x04000053 RID: 83
	public System.Windows.Forms.Timer timer_17 = new System.Windows.Forms.Timer();

	// Token: 0x04000054 RID: 84
	public System.Windows.Forms.Timer timer_18 = new System.Windows.Forms.Timer();

	// Token: 0x04000055 RID: 85
	public System.Windows.Forms.Timer timer_19 = new System.Windows.Forms.Timer();

	// Token: 0x04000056 RID: 86
	private int int_15;

	// Token: 0x04000057 RID: 87
	private FormAlarm formAlarm_0;

	// Token: 0x04000058 RID: 88
	private bool bool_11 = true;

	// Token: 0x04000059 RID: 89
	private bool bool_12;

	// Token: 0x0400005A RID: 90
	public bool bool_13 = true;

	// Token: 0x0400005B RID: 91
	public int int_16 = 312;

	// Token: 0x0400005C RID: 92
	public int int_17 = 60;

	// Token: 0x0400005D RID: 93
	public int int_18 = 64;

	// Token: 0x0400005E RID: 94
	public int int_19 = 8;

	// Token: 0x0400005F RID: 95
	public List<int> list_0 = new List<int>();
}
