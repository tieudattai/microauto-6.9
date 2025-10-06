using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;


public class GClass0
{
	
	public ulong method_0()
	{
		return this.ulong_0;
	}

	
	public void method_1(ulong ulong_1)
	{
		this.ulong_0 = ulong_1;
		Class8.smethod_8(this.method_40(), ulong_1);
	}

	
	public int method_2()
	{
		return (int)Math.Sqrt(Math.Pow((double)(this.method_13() - this.int_4), 2.0) + Math.Pow((double)(this.method_17() - this.int_5), 2.0));
	}

	
	public int method_3()
	{
		return (int)Math.Sqrt(Math.Pow((double)(this.method_20() - (float)this.int_4), 2.0) + Math.Pow((double)(this.method_21() - (float)this.int_5), 2.0));
	}

	
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

	
	public uint method_5()
	{
		if ((long)this.method_41() <= (long)((ulong)this.uint_0))
		{
			return 1U;
		}
		return (uint)((double)((long)this.method_41() - (long)((ulong)this.uint_0)) / (this.stopwatch_8.Elapsed.TotalSeconds + 1.0) * 3600.0);
	}

	
	public bool method_6()
	{
		return this.bool_7;
	}

	
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

	
	public int method_11()
	{
		return this.class7_0.method_1(new int[]
		{
			7319476,
			12
		});
	}

	
	public int method_12()
	{
		return this.method_11() + 92;
	}

	
	public int method_13()
	{
		return (int)this.class7_0.method_3(this.method_11() + 92);
	}

	
	public int method_14()
	{
		return (int)this.class7_0.method_3(this.method_11() + 408);
	}

	
	public int method_15()
	{
		return (int)this.class7_0.method_3(this.method_11() + 68);
	}

	
	public int method_16()
	{
		return this.method_11() + 100;
	}

	
	public int method_17()
	{
		return (int)this.class7_0.method_3(this.method_11() + 100);
	}

	
	public int method_18()
	{
		return (int)this.class7_0.method_3(this.method_11() + 412);
	}

	
	public int method_19()
	{
		return (int)this.class7_0.method_3(this.method_11() + 76);
	}

	
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

	
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.method_22("F1");
	}

	
	private void timer_1_Tick(object sender, EventArgs e)
	{
		this.method_22("F2");
	}

	
	private void timer_2_Tick(object sender, EventArgs e)
	{
		this.method_22("F3");
	}

	
	private void timer_3_Tick(object sender, EventArgs e)
	{
		this.method_22("F4");
	}

	
	private void timer_4_Tick(object sender, EventArgs e)
	{
		this.method_22("F5");
	}

	
	private void timer_5_Tick(object sender, EventArgs e)
	{
		this.method_22("F6");
	}

	
	private void timer_6_Tick(object sender, EventArgs e)
	{
		this.method_22("F7");
	}

	
	private void timer_7_Tick(object sender, EventArgs e)
	{
		this.method_22("F8");
	}

	
	private void timer_8_Tick(object sender, EventArgs e)
	{
		this.method_22("F9");
	}

	
	private void timer_9_Tick(object sender, EventArgs e)
	{
		this.method_22("F10");
	}

	
	private void timer_10_Tick(object sender, EventArgs e)
	{
		this.method_22("F11");
	}

	
	private void timer_11_Tick(object sender, EventArgs e)
	{
		this.method_22("F12");
	}

	
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

	
	private void method_23()
	{
		this.method_54(this.string_2);
		this.stopwatch_5.Reset();
		this.stopwatch_5.Start();
	}

	
	private void method_24()
	{
		this.stopwatch_6.Reset();
		this.stopwatch_6.Start();
		this.method_22(this.string_0);
	}

	
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

	
	private void timer_19_Tick(object sender, EventArgs e)
	{
		if (this.method_33() > 0 && this.method_33() < this.int_8)
		{
			this.method_63();
		}
	}

	
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

	
	private void timer_16_Tick_1(object sender, EventArgs e)
	{
		if (this.method_40() < 1)
		{
			return;
		}
		this.method_1(Class8.smethod_7(this.method_40()));
		this.timer_16.Tick -= this.timer_16_Tick_1;
	}

	
	public int method_25()
	{
		return this.class7_0.method_1(new int[]
		{
			6870940,
			14232
		});
	}

	
	public int method_26()
	{
		return this.class7_0.method_0(this.method_25() + 8);
	}

	
	public string method_27()
	{
		if (!(this.class7_0.method_5(this.class7_0.method_0(this.method_25() + 96)) == ""))
		{
			return this.class7_0.method_5(this.class7_0.method_0(this.method_25() + 96));
		}
		return this.class7_0.method_5(this.method_25() + 96);
	}

	
	public int method_28()
	{
		return this.class7_0.method_0(this.method_25() + 160);
	}

	
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

	
	public int method_30()
	{
		return this.class7_0.method_0(this.method_29() + 16);
	}

	
	public int method_31()
	{
		return this.class7_0.method_0(this.method_29() + 2292);
	}

	
	public int method_32()
	{
		return this.class7_0.method_0(this.method_29() + 2400);
	}

	
	public int method_33()
	{
		if (this.method_32() == 0)
		{
			return 100;
		}
		return (int)((float)this.method_31() * 100f / (float)this.method_32());
	}

	
	public int method_34()
	{
		return this.class7_0.method_0(this.method_29() + 2296);
	}

	
	public int method_35()
	{
		return this.class7_0.method_0(this.method_29() + 2404);
	}

	
	public int method_36()
	{
		if (this.method_35() == 0)
		{
			return 100;
		}
		return (int)(100f * (float)this.method_34() / (float)this.method_35());
	}

	
	public int method_37()
	{
		return this.class7_0.method_0(this.method_29() + 2356);
	}

	
	public string method_38()
	{
		string text = this.class7_0.method_5(this.method_29() + 48);
		if (text == "")
		{
			return "Đăng nhập";
		}
		return text;
	}

	
	public int method_39()
	{
		return this.class7_0.method_1(new int[]
		{
			7319476,
			12,
			348
		});
	}

	
	public int method_40()
	{
		return this.class7_0.method_0(this.method_29() + 92);
	}

	
	public int method_41()
	{
		return this.class7_0.method_0(this.method_29() + 2300);
	}

	
	public int method_42()
	{
		return this.class7_0.method_1(new int[]
		{
			7319540,
			299356
		});
	}

	
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

	
	public void method_61()
	{
		Class9.ShowWindow(this.intptr_0, 0);
		Class8.smethod_1(this.int_12.ToString(), this.intptr_0.ToString());
	}

	
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

	
	public void method_64()
	{
		this.stopwatch_8.Reset();
		this.stopwatch_8.Start();
		this.uint_0 = (uint)this.method_41();
	}

	
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

	
	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr intptr_1, IntPtr intptr_2, [Out] byte[] byte_0, int int_20, out int int_21);

	
	public static bool bool_0 = false;

	
	public static bool bool_1 = false;

	
	public static bool bool_2 = false;

	
	public bool bool_3;

	
	public bool bool_4;

	
	public bool bool_5;

	
	private bool bool_6;

	
	public bool bool_7;

	
	public bool bool_8;

	
	public bool bool_9 = true;

	
	public string string_0 = "F1";

	
	public string string_1 = "F9";

	
	public string string_2 = "F11";

	
	public string string_3 = "F8";

	
	public string string_4 = "F7";

	
	public int int_0 = 50;

	
	public int int_1 = 50;

	
	public int int_2 = 50;

	
	public int int_3 = 20;

	
	public int int_4;

	
	public int int_5;

	
	public int int_6;

	
	public int int_7 = 100;

	
	public int int_8 = 50;

	
	public bool bool_10;

	
	public ulong ulong_0;

	
	public int int_9;

	
	public uint uint_0;

	
	public static int int_10 = 50;

	
	public static GDelegate1 gdelegate1_0;

	
	public static GDelegate1 gdelegate1_1;

	
	public static GDelegate2 gdelegate2_0;

	
	public int int_11;

	
	public string string_5 = "";

	
	public string string_6 = "Khong biet";

	
	public Stopwatch stopwatch_0 = new Stopwatch();

	
	public Stopwatch stopwatch_1 = new Stopwatch();

	
	public Stopwatch stopwatch_2 = new Stopwatch();

	
	public Stopwatch stopwatch_3 = new Stopwatch();

	
	public Stopwatch stopwatch_4 = new Stopwatch();

	
	public Stopwatch stopwatch_5 = new Stopwatch();

	
	public Stopwatch stopwatch_6 = new Stopwatch();

	
	private Stopwatch stopwatch_7 = new Stopwatch();

	
	public Stopwatch stopwatch_8 = new Stopwatch();

	
	private Class2 class2_0;

	
	public int int_12;

	
	private Class7 class7_0;

	
	public IntPtr intptr_0;

	
	public int int_13;

	
	public int int_14;

	
	private Thread thread_0;

	
	public System.Windows.Forms.Timer timer_0 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_1 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_2 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_3 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_4 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_5 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_6 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_7 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_8 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_9 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_10 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_11 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_12 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_13 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_14 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_15 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_16 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_17 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_18 = new System.Windows.Forms.Timer();

	
	public System.Windows.Forms.Timer timer_19 = new System.Windows.Forms.Timer();

	
	private int int_15;

	
	private FormAlarm formAlarm_0;

	
	private bool bool_11 = true;

	
	private bool bool_12;

	
	public bool bool_13 = true;

	
	public int int_16 = 312;

	
	public int int_17 = 60;

	
	public int int_18 = 64;

	
	public int int_19 = 8;

	
	public List<int> list_0 = new List<int>();
}
