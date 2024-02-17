using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

public class q
{
	public static bool a = false;

	public static bool b = false;

	public static bool c = false;

	public bool d;

	public bool e;

	public bool f;

	private bool m_g;

	public bool h;

	public bool i;

	public bool j = true;

	public string k = "F1";

	public string l = "F9";

	public string m = "F11";

	public string n = "F8";

	public string o = "F7";

	public int p = 50;

	public int q = 50;

	public int r = 50;

	public int s = 20;

	public int t;

	public int u;

	public int v;

	public int w = 100;

	public int x = 50;

	public bool y;

	public ulong z;

	public int aa;

	public uint ab;

	public static int ac = 50;

	public static j ad;

	public static j ae;

	public static a af;

	public int ag;

	public string ah = "";

	public string ai = "Khong biet";

	public Stopwatch aj = new Stopwatch();

	public Stopwatch ak = new Stopwatch();

	public Stopwatch al = new Stopwatch();

	public Stopwatch am = new Stopwatch();

	public Stopwatch an = new Stopwatch();

	public Stopwatch ao = new Stopwatch();

	public Stopwatch ap = new Stopwatch();

	private Stopwatch m_aq = new Stopwatch();

	public Stopwatch ar = new Stopwatch();

	private e m_as;

	public int at;

	private r m_au;

	public IntPtr av;

	public int aw;

	public int ax;

	private Thread m_ay;

	public System.Windows.Forms.Timer az = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a0 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a1 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a2 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a3 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a4 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a5 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a6 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a7 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a8 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer a9 = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer ba = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer bb = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer bc = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer bd = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer be = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer bf = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer bg = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer bh = new System.Windows.Forms.Timer();

	public System.Windows.Forms.Timer bi = new System.Windows.Forms.Timer();

	private int bj;

	private d bk;

	private bool bl = true;

	private bool bm;

	public bool bn = true;

	public int bo = 312;

	public int bp = 60;

	public int bq = 64;

	public int br = 8;

	public List<int> bs = new List<int>();

	[SpecialName]
	public ulong a1()
	{
		return this.z;
	}

	[SpecialName]
	public void a(ulong A_0)
	{
		this.z = A_0;
		global::b.a(ao(), A_0);
	}

	[SpecialName]
	public int l()
	{
		if (true)
		{
		}
		return (int)Math.Sqrt(Math.Pow(ab() - this.t, 2.0) + Math.Pow(ag() - this.u, 2.0));
	}

	[SpecialName]
	public int ap()
	{
		if (true)
		{
		}
		return (int)Math.Sqrt(Math.Pow(t() - (float)this.t, 2.0) + Math.Pow(s() - (float)this.u, 2.0));
	}

	[SpecialName]
	public string n()
	{
		if (!this.y)
		{
			return "Bán kính";
		}
		if (true)
		{
		}
		return "Tọa độ " + this.t + ", " + this.u;
	}

	[SpecialName]
	public uint w()
	{
		if (q() <= this.ab)
		{
			return 1u;
		}
		if (true)
		{
		}
		return (uint)((double)(q() - this.ab) / (this.ar.Elapsed.TotalSeconds + 1.0) * 3600.0);
	}

	[SpecialName]
	public bool u()
	{
		return this.h;
	}

	[SpecialName]
	public void a(bool A_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				if (!A_0)
				{
					num = 2;
					continue;
				}
				aj();
				num = 1;
				continue;
			case 1:
				if (1 == 0)
				{
				}
				break;
			case 2:
				p();
				num = 0;
				continue;
			case 0:
				break;
			}
			break;
		}
		this.h = A_0;
	}

	[SpecialName]
	public int aq()
	{
		TimeSpan elapsed2 = default(TimeSpan);
		while (true)
		{
			TimeSpan elapsed = this.an.Elapsed;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (true)
					{
					}
					if (elapsed.TotalMinutes < 10.0)
					{
						num = 3;
						continue;
					}
					elapsed2 = this.an.Elapsed;
					num = 1;
					continue;
				case 2:
					return 2;
				case 1:
					if (elapsed2.TotalMinutes < 20.0)
					{
						num = 2;
						continue;
					}
					return 3;
				case 3:
					return 1;
				}
				break;
			}
		}
	}

	public void a(int A_0, int A_1)
	{
		int num = 7;
		while (true)
		{
			switch (num)
			{
			default:
				if (!global::q.b)
				{
					num = 0;
					break;
				}
				return;
			case 10:
				this.m_ay = new Thread(av);
				num = 2;
				break;
			case 2:
				if (1 == 0)
				{
				}
				goto IL_0164;
			case 1:
				if (this.m_ay == null)
				{
					num = 10;
					break;
				}
				goto IL_0164;
			case 6:
				num = 8;
				break;
			case 8:
				if (!this.ah.Equals(""))
				{
					num = 3;
					break;
				}
				goto IL_008f;
			case 3:
				return;
			case 5:
				this.m_ay = new Thread(av);
				this.m_ay.Start();
				num = 11;
				break;
			case 11:
				return;
			case 0:
				num = 4;
				break;
			case 4:
				if (x() == 2)
				{
					num = 6;
					break;
				}
				goto IL_008f;
			case 9:
				{
					if (this.m_ay.ThreadState != 0)
					{
						num = 5;
						break;
					}
					return;
				}
				IL_0164:
				num = 9;
				break;
				IL_008f:
				global::q.b = true;
				ai();
				this.aw = A_0;
				this.ax = A_1;
				num = 1;
				break;
			}
		}
	}

	public void av()
	{
		int num2 = default(int);
		while (true)
		{
			new n(this.av);
			Thread.Sleep(1000);
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (global::n.GetForegroundWindow() == this.av)
					{
						num = 4;
						continue;
					}
					goto case 5;
				case 7:
				case 8:
					num = 3;
					continue;
				case 3:
					if (x() == 2)
					{
						num = 2;
						continue;
					}
					this.m_au.a(a2(), this.aw);
					this.m_au.a(aa(), this.ax);
					num2++;
					num = 0;
					continue;
				case 1:
					Thread.Sleep(1000);
					num = 7;
					continue;
				case 4:
					num2 = 0;
					if (true)
					{
					}
					num = 8;
					continue;
				case 2:
					Thread.Sleep(2000);
					num = 5;
					continue;
				case 0:
					if (num2 <= 5)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 5:
					global::q.b = false;
					return;
				}
				break;
			}
		}
	}

	[SpecialName]
	public int @as()
	{
		if (true)
		{
		}
		return this.m_au.b(new int[2] { 7319476, 12 });
	}

	[SpecialName]
	public int a2()
	{
		return @as() + 92;
	}

	[SpecialName]
	public int ab()
	{
		return (int)this.m_au.b(@as() + 92);
	}

	[SpecialName]
	public int am()
	{
		return (int)this.m_au.b(@as() + 408);
	}

	[SpecialName]
	public int z()
	{
		return (int)this.m_au.b(@as() + 68);
	}

	[SpecialName]
	public int aa()
	{
		return @as() + 100;
	}

	[SpecialName]
	public int ag()
	{
		return (int)this.m_au.b(@as() + 100);
	}

	[SpecialName]
	public int y()
	{
		return (int)this.m_au.b(@as() + 412);
	}

	[SpecialName]
	public int an()
	{
		return (int)this.m_au.b(@as() + 76);
	}

	[SpecialName]
	public float t()
	{
		int num = 35;
		int[] array2 = default(int[]);
		int num7 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		int num2 = default(int);
		List<int>.Enumerator enumerator = default(List<int>.Enumerator);
		int num11 = default(int);
		int num17 = default(int);
		int num15 = default(int);
		int[] array6 = default(int[]);
		int num4 = default(int);
		int num10 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		int num12 = default(int);
		int num3 = default(int);
		float result = default(float);
		int[] array7 = default(int[]);
		int num9 = default(int);
		int[] array4 = default(int[]);
		int num8 = default(int);
		int[] array5 = default(int[]);
		int[] array11 = default(int[]);
		int[] array3 = default(int[]);
		int current = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (!ae())
				{
					num = 32;
					continue;
				}
				array2 = new int[3] { 0, 4, 8 };
				num7 = 0;
				num5 = 7317332;
				num6 = 1324;
				num2 = 68;
				enumerator = bs.GetEnumerator();
				num = 24;
				continue;
			case 0:
				num11++;
				num = 6;
				continue;
			case 12:
				num17++;
				num = 44;
				continue;
			case 16:
			case 40:
				num = 9;
				continue;
			case 9:
			{
				if (num15 >= array6.Length)
				{
					num = 0;
					continue;
				}
				int num16 = array6[num15];
				num7 = this.m_au.b(new int[7] { num5, num6, num4, num10, num13, num14, num12 }) + num16;
				if (true)
				{
				}
				num = 22;
				continue;
			}
			case 5:
				num3++;
				num = 28;
				continue;
			case 14:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 41;
				continue;
			case 37:
			{
				r obj6 = this.m_au;
				int[] array13 = new int[5] { 0, 16, 60, 24, 168 };
				array13[0] = num7;
				if (obj6.b(array13) == 1)
				{
					num = 17;
					continue;
				}
				array7 = array2;
				num17 = 0;
				num = 10;
				continue;
			}
			case 7:
				num9++;
				num = 4;
				continue;
			case 42:
				return 0f;
			case 32:
				return this.t;
			case 29:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 15;
				continue;
			case 43:
			{
				r obj2 = this.m_au;
				int[] array8 = new int[5] { 0, 16, 60, 24, 168 };
				array8[0] = num7;
				if (obj2.b(array8) != 1)
				{
					array4 = array2;
					num9 = 0;
					num = 18;
				}
				else
				{
					num = 29;
				}
				continue;
			}
			case 4:
			case 18:
				num = 19;
				continue;
			case 19:
				if (num9 < array4.Length)
				{
					num10 = array4[num9];
					num7 = this.m_au.b(new int[3] { num5, num6, num4 }) + num10;
					num = 37;
				}
				else
				{
					num = 5;
				}
				continue;
			case 38:
				num8++;
				num = 2;
				continue;
			case 30:
			{
				r obj7 = this.m_au;
				int[] array14 = new int[5] { 0, 16, 60, 24, 168 };
				array14[0] = num7;
				if (obj7.b(array14) == 1)
				{
					num = 26;
					continue;
				}
				array5 = array2;
				num11 = 0;
				num = 1;
				continue;
			}
			case 26:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 34;
				continue;
			case 25:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 31;
				continue;
			case 33:
			{
				r obj5 = this.m_au;
				int[] array12 = new int[5] { 0, 16, 60, 24, 168 };
				array12[0] = num7;
				if (obj5.b(array12) != 1)
				{
					array11 = array2;
					num8 = 0;
					num = 8;
				}
				else
				{
					num = 23;
				}
				continue;
			}
			case 2:
			case 8:
				num = 39;
				continue;
			case 39:
				if (num8 < array11.Length)
				{
					num14 = array11[num8];
					num7 = this.m_au.b(new int[5] { num5, num6, num4, num10, num13 }) + num14;
					num = 30;
				}
				else
				{
					num = 12;
				}
				continue;
			case 23:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 21;
				continue;
			case 17:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 3;
				continue;
			case 22:
			{
				r obj4 = this.m_au;
				int[] array10 = new int[5] { 0, 16, 60, 24, 168 };
				array10[0] = num7;
				if (obj4.b(array10) != 1)
				{
					num15++;
					num = 40;
				}
				else
				{
					num = 25;
				}
				continue;
			}
			case 13:
			{
				r obj3 = this.m_au;
				int[] array9 = new int[5] { 0, 16, 60, 24, 168 };
				array9[0] = num7;
				if (obj3.b(array9) != 1)
				{
					array6 = array2;
					num15 = 0;
					num = 16;
				}
				else
				{
					num = 14;
				}
				continue;
			}
			case 10:
			case 44:
				num = 20;
				continue;
			case 20:
				if (num17 < array7.Length)
				{
					num13 = array7[num17];
					num7 = this.m_au.b(new int[4] { num5, num6, num4, num10 }) + num13;
					num = 33;
				}
				else
				{
					num = 7;
				}
				continue;
			case 1:
			case 6:
				num = 27;
				continue;
			case 27:
				if (num11 < array5.Length)
				{
					num12 = array5[num11];
					num7 = this.m_au.b(new int[6] { num5, num6, num4, num10, num13, num14 }) + num12;
					num = 13;
				}
				else
				{
					num = 38;
				}
				continue;
			case 11:
			case 28:
				num = 36;
				continue;
			case 36:
				if (num3 < array3.Length)
				{
					num4 = array3[num3];
					num7 = this.m_au.b(new int[2] { num5, num6 }) + num4;
					num = 43;
				}
				else
				{
					num = 42;
				}
				continue;
			case 24:
				try
				{
					num = 6;
					while (true)
					{
						switch (num)
						{
						case 2:
							break;
						case 4:
						{
							r obj = this.m_au;
							int[] array = new int[5] { 0, 16, 60, 24, 168 };
							array[0] = current;
							if (obj.b(array) == 1)
							{
								num = 5;
								continue;
							}
							goto default;
						}
						default:
							num = 3;
							continue;
						case 3:
							if (enumerator.MoveNext())
							{
								current = enumerator.Current;
								num = 4;
							}
							else
							{
								num = 1;
							}
							continue;
						case 5:
							result = this.m_au.a(new int[3] { current, 16, num2 });
							num = 0;
							continue;
						case 0:
							goto end_IL_0820;
						case 1:
							num = 2;
							continue;
						}
						break;
					}
					goto IL_014f;
					end_IL_0820:;
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				break;
			case 3:
			case 15:
			case 21:
			case 31:
			case 34:
			case 41:
				break;
				IL_014f:
				array3 = array2;
				num3 = 0;
				num = 11;
				continue;
			}
			break;
		}
		return result;
	}

	[SpecialName]
	public float s()
	{
		int num = 33;
		int[] array2 = default(int[]);
		int num7 = default(int);
		int num2 = default(int);
		int num5 = default(int);
		int num6 = default(int);
		List<int>.Enumerator enumerator = default(List<int>.Enumerator);
		int num11 = default(int);
		int num17 = default(int);
		int num15 = default(int);
		int[] array6 = default(int[]);
		int num4 = default(int);
		int num10 = default(int);
		int num13 = default(int);
		int num14 = default(int);
		int num12 = default(int);
		int num3 = default(int);
		float result = default(float);
		int[] array7 = default(int[]);
		int num9 = default(int);
		int[] array4 = default(int[]);
		int num8 = default(int);
		int[] array5 = default(int[]);
		int[] array11 = default(int[]);
		int[] array3 = default(int[]);
		int current = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (!ae())
				{
					num = 43;
					continue;
				}
				array2 = new int[3] { 0, 4, 8 };
				num7 = 0;
				num2 = 76;
				num5 = 7317332;
				num6 = 1324;
				enumerator = bs.GetEnumerator();
				num = 16;
				continue;
			case 42:
				num11++;
				if (true)
				{
				}
				num = 0;
				continue;
			case 22:
				num17++;
				num = 7;
				continue;
			case 32:
			case 41:
				num = 26;
				continue;
			case 26:
			{
				if (num15 >= array6.Length)
				{
					num = 42;
					continue;
				}
				int num16 = array6[num15];
				num7 = this.m_au.b(new int[7] { num5, num6, num4, num10, num13, num14, num12 }) + num16;
				num = 6;
				continue;
			}
			case 30:
				num3++;
				num = 10;
				continue;
			case 13:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 31;
				continue;
			case 14:
			{
				r obj6 = this.m_au;
				int[] array13 = new int[5] { 0, 16, 60, 24, 168 };
				array13[0] = num7;
				if (obj6.b(array13) == 1)
				{
					num = 44;
					continue;
				}
				array7 = array2;
				num17 = 0;
				num = 17;
				continue;
			}
			case 35:
				num9++;
				num = 23;
				continue;
			case 9:
				return 0f;
			case 43:
				return this.u;
			case 2:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 36;
				continue;
			case 12:
			{
				r obj2 = this.m_au;
				int[] array8 = new int[5] { 0, 16, 60, 24, 168 };
				array8[0] = num7;
				if (obj2.b(array8) != 1)
				{
					array4 = array2;
					num9 = 0;
					num = 4;
				}
				else
				{
					num = 2;
				}
				continue;
			}
			case 4:
			case 23:
				num = 25;
				continue;
			case 25:
				if (num9 < array4.Length)
				{
					num10 = array4[num9];
					num7 = this.m_au.b(new int[3] { num5, num6, num4 }) + num10;
					num = 14;
				}
				else
				{
					num = 30;
				}
				continue;
			case 27:
				num8++;
				num = 39;
				continue;
			case 18:
			{
				r obj7 = this.m_au;
				int[] array14 = new int[5] { 0, 16, 60, 24, 168 };
				array14[0] = num7;
				if (obj7.b(array14) == 1)
				{
					num = 1;
					continue;
				}
				array5 = array2;
				num11 = 0;
				num = 24;
				continue;
			}
			case 1:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 40;
				continue;
			case 38:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 15;
				continue;
			case 28:
			{
				r obj5 = this.m_au;
				int[] array12 = new int[5] { 0, 16, 60, 24, 168 };
				array12[0] = num7;
				if (obj5.b(array12) != 1)
				{
					array11 = array2;
					num8 = 0;
					num = 21;
				}
				else
				{
					num = 29;
				}
				continue;
			}
			case 21:
			case 39:
				num = 34;
				continue;
			case 34:
				if (num8 < array11.Length)
				{
					num14 = array11[num8];
					num7 = this.m_au.b(new int[5] { num5, num6, num4, num10, num13 }) + num14;
					num = 18;
				}
				else
				{
					num = 22;
				}
				continue;
			case 29:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 11;
				continue;
			case 44:
				a(num7);
				result = this.m_au.a(new int[3] { num7, 16, num2 });
				num = 20;
				continue;
			case 6:
			{
				r obj4 = this.m_au;
				int[] array10 = new int[5] { 0, 16, 60, 24, 168 };
				array10[0] = num7;
				if (obj4.b(array10) != 1)
				{
					num15++;
					num = 41;
				}
				else
				{
					num = 38;
				}
				continue;
			}
			case 37:
			{
				r obj3 = this.m_au;
				int[] array9 = new int[5] { 0, 16, 60, 24, 168 };
				array9[0] = num7;
				if (obj3.b(array9) != 1)
				{
					array6 = array2;
					num15 = 0;
					num = 32;
				}
				else
				{
					num = 13;
				}
				continue;
			}
			case 7:
			case 17:
				num = 5;
				continue;
			case 5:
				if (num17 < array7.Length)
				{
					num13 = array7[num17];
					num7 = this.m_au.b(new int[4] { num5, num6, num4, num10 }) + num13;
					num = 28;
				}
				else
				{
					num = 35;
				}
				continue;
			case 0:
			case 24:
				num = 19;
				continue;
			case 19:
				if (num11 < array5.Length)
				{
					num12 = array5[num11];
					num7 = this.m_au.b(new int[6] { num5, num6, num4, num10, num13, num14 }) + num12;
					num = 37;
				}
				else
				{
					num = 27;
				}
				continue;
			case 3:
			case 10:
				num = 8;
				continue;
			case 8:
				if (num3 < array3.Length)
				{
					num4 = array3[num3];
					num7 = this.m_au.b(new int[2] { num5, num6 }) + num4;
					num = 12;
				}
				else
				{
					num = 9;
				}
				continue;
			case 16:
				try
				{
					num = 4;
					while (true)
					{
						switch (num)
						{
						case 1:
							break;
						case 2:
						{
							r obj = this.m_au;
							int[] array = new int[5] { 0, 16, 60, 24, 168 };
							array[0] = current;
							if (obj.b(array) == 1)
							{
								num = 6;
								continue;
							}
							goto default;
						}
						default:
							num = 5;
							continue;
						case 5:
							if (enumerator.MoveNext())
							{
								current = enumerator.Current;
								num = 2;
							}
							else
							{
								num = 0;
							}
							continue;
						case 6:
							result = this.m_au.a(new int[3] { current, 16, num2 });
							num = 3;
							continue;
						case 3:
							goto end_IL_0820;
						case 0:
							num = 1;
							continue;
						}
						break;
					}
					goto IL_0157;
					end_IL_0820:;
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
				break;
			case 11:
			case 15:
			case 20:
			case 31:
			case 36:
			case 40:
				break;
				IL_0157:
				array3 = array2;
				num3 = 0;
				num = 3;
				continue;
			}
			break;
		}
		return result;
	}

	private void u(object A_0, EventArgs A_1)
	{
		a("F1");
	}

	private void t(object A_0, EventArgs A_1)
	{
		a("F2");
	}

	private void s(object A_0, EventArgs A_1)
	{
		a("F3");
	}

	private void r(object A_0, EventArgs A_1)
	{
		a("F4");
	}

	private void q(object A_0, EventArgs A_1)
	{
		a("F5");
	}

	private void p(object A_0, EventArgs A_1)
	{
		a("F6");
	}

	private void o(object A_0, EventArgs A_1)
	{
		a("F7");
	}

	private void n(object A_0, EventArgs A_1)
	{
		a("F8");
	}

	private void m(object A_0, EventArgs A_1)
	{
		a("F9");
	}

	private void l(object A_0, EventArgs A_1)
	{
		a("F10");
	}

	private void k(object A_0, EventArgs A_1)
	{
		a("F11");
	}

	private void j(object A_0, EventArgs A_1)
	{
		a("F12");
	}

	private void a(string A_0)
	{
		int num = 6;
		while (true)
		{
			switch (num)
			{
			default:
				if (!global::q.a)
				{
					num = 9;
					continue;
				}
				return;
			case 10:
				num = 7;
				continue;
			case 7:
				if (!this.y)
				{
					num = 5;
					continue;
				}
				break;
			case 5:
				if (true)
				{
				}
				num = 8;
				continue;
			case 11:
				if (!this.e)
				{
					num = 10;
					continue;
				}
				break;
			case 3:
				num = 0;
				continue;
			case 0:
				num = (this.f ? 1 : 11);
				continue;
			case 1:
				return;
			case 4:
				return;
			case 9:
				num = 2;
				continue;
			case 2:
				if (bl)
				{
					num = 3;
					continue;
				}
				return;
			case 8:
				if (x() == 2)
				{
					num = 4;
					continue;
				}
				break;
			}
			break;
		}
		b(A_0);
	}

	private void i(object A_0, EventArgs A_1)
	{
		while (true)
		{
			int num = a4();
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (true)
					{
					}
					if (num > 0)
					{
						num2 = 3;
						continue;
					}
					goto IL_00d3;
				case 1:
					b(this.l);
					bj = num;
					this.ak.Reset();
					this.ak.Start();
					return;
				case 2:
					num2 = 0;
					continue;
				case 0:
					if (this.ak.ElapsedMilliseconds > 400)
					{
						num2 = 1;
						continue;
					}
					goto IL_00d3;
				case 3:
					num2 = 4;
					continue;
				case 4:
					{
						if (num < this.p)
						{
							num2 = 2;
							continue;
						}
						goto IL_00d3;
					}
					IL_00d3:
					bj = 0;
					return;
				}
				break;
			}
		}
	}

	private void h(object A_0, EventArgs A_1)
	{
		while (true)
		{
			int num = i();
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (num > 0)
					{
						if (true)
						{
						}
						num2 = 5;
						continue;
					}
					return;
				case 2:
					b(this.n);
					this.al.Reset();
					this.al.Start();
					num2 = 0;
					continue;
				case 0:
					return;
				case 3:
					num2 = 6;
					continue;
				case 6:
					if (this.al.ElapsedMilliseconds > 400)
					{
						num2 = 2;
						continue;
					}
					return;
				case 5:
					num2 = 4;
					continue;
				case 4:
					if (num < this.q)
					{
						num2 = 3;
						continue;
					}
					return;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		while (true)
		{
			int num = al();
			int num2 = 4;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (num > 0)
					{
						num2 = 6;
						continue;
					}
					return;
				case 3:
					b(this.o);
					this.am.Reset();
					this.am.Start();
					if (true)
					{
					}
					num2 = 0;
					continue;
				case 0:
					return;
				case 5:
					num2 = 1;
					continue;
				case 1:
					if (this.am.ElapsedMilliseconds > 400)
					{
						num2 = 3;
						continue;
					}
					return;
				case 6:
					num2 = 2;
					continue;
				case 2:
					if (num < this.r)
					{
						num2 = 5;
						continue;
					}
					return;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		int num = 6;
		TimeSpan elapsed = default(TimeSpan);
		while (true)
		{
			if (true)
			{
			}
			switch (num)
			{
			default:
				if (ad())
				{
					num = 0;
					break;
				}
				goto case 8;
			case 2:
				num = 10;
				break;
			case 10:
				if (this.m_aq.IsRunning)
				{
					num = 5;
					break;
				}
				return;
			case 13:
				bk.Dispose();
				this.m_aq.Reset();
				this.f = false;
				global::l.a();
				num = 2;
				break;
			case 4:
				bk = new d();
				bk.a(ak(), global::q.ac);
				this.an.Reset();
				this.an.Start();
				this.m_aq.Start();
				global::l.c();
				this.f = true;
				ai();
				num = 8;
				break;
			case 7:
				a5();
				num = 1;
				break;
			case 1:
				return;
			case 0:
				num = 14;
				break;
			case 14:
				if (!this.f)
				{
					num = 4;
					break;
				}
				goto case 8;
			case 5:
				elapsed = this.m_aq.Elapsed;
				num = 11;
				break;
			case 11:
				if (elapsed.Seconds > global::q.ac)
				{
					num = 7;
					break;
				}
				return;
			case 12:
				num = 3;
				break;
			case 3:
				if (this.f)
				{
					num = 13;
					break;
				}
				goto case 2;
			case 8:
				num = 9;
				break;
			case 9:
				if (!ad())
				{
					num = 12;
					break;
				}
				goto case 2;
			}
		}
	}

	private void e(object A_0, EventArgs A_1)
	{
		bool flag = default(bool);
		int num3 = default(int);
		TimeSpan elapsed3 = default(TimeSpan);
		TimeSpan elapsed2 = default(TimeSpan);
		TimeSpan elapsed = default(TimeSpan);
		while (true)
		{
			int num = x();
			int num2 = 58;
			while (true)
			{
				switch (num2)
				{
				case 58:
					if (num == 0)
					{
						num2 = 29;
						continue;
					}
					this.aj.Reset();
					this.aj.Start();
					num2 = 39;
					continue;
				case 24:
					num2 = 57;
					continue;
				case 57:
					if (!ae())
					{
						num2 = 4;
						continue;
					}
					goto case 2;
				case 37:
					d();
					num2 = 20;
					continue;
				case 47:
					num2 = 21;
					continue;
				case 21:
					if (num == 2)
					{
						num2 = 22;
						continue;
					}
					goto IL_022e;
				case 22:
					return;
				case 18:
					num2 = 40;
					continue;
				case 40:
					num2 = ((!this.i) ? 34 : 32);
					continue;
				case 56:
					return;
				case 11:
					flag = false;
					d();
					num2 = 24;
					continue;
				case 60:
					c();
					num2 = 25;
					continue;
				case 59:
					num2 = 45;
					continue;
				case 45:
					if (x() == 0)
					{
						num2 = 37;
						continue;
					}
					goto case 20;
				case 42:
					if (global::q.a)
					{
						num2 = 27;
						continue;
					}
					flag = true;
					num2 = 3;
					continue;
				case 27:
					return;
				case 34:
					if (num == 0)
					{
						num2 = 60;
						continue;
					}
					goto case 17;
				case 6:
					d();
					num2 = 30;
					continue;
				case 15:
					num3 = ap();
					num2 = 36;
					continue;
				case 36:
					if (num3 > this.s)
					{
						num2 = 7;
						continue;
					}
					goto case 55;
				case 29:
					this.aj.Start();
					num2 = 48;
					continue;
				case 13:
					num2 = 5;
					continue;
				case 5:
					if (!this.y)
					{
						num2 = 47;
						continue;
					}
					goto IL_022e;
				case 44:
					if (!this.e)
					{
						num2 = 13;
						continue;
					}
					goto IL_022e;
				case 3:
					if (this.i)
					{
						num2 = 14;
						continue;
					}
					goto case 10;
				case 32:
					c();
					num2 = 17;
					continue;
				case 2:
					num2 = 31;
					continue;
				case 31:
					if (flag)
					{
						num2 = 35;
						continue;
					}
					goto case 17;
				case 10:
					num2 = 50;
					continue;
				case 50:
					if (this.y)
					{
						num2 = 15;
						continue;
					}
					goto case 55;
				case 7:
					num2 = 38;
					continue;
				case 38:
					if (num3 > l())
					{
						num2 = 23;
						continue;
					}
					goto case 55;
				case 61:
					num2 = 41;
					continue;
				case 41:
					if (m() >= this.v)
					{
						num2 = 52;
						continue;
					}
					goto case 11;
				case 14:
					elapsed3 = this.ao.Elapsed;
					num2 = 33;
					continue;
				case 33:
					if (elapsed3.TotalMilliseconds > 500.0)
					{
						num2 = 51;
						continue;
					}
					goto case 10;
				case 9:
					num2 = 8;
					continue;
				case 8:
					if (!this.e)
					{
						num2 = 18;
						continue;
					}
					goto case 32;
				case 51:
					d();
					num2 = 10;
					continue;
				case 43:
					num2 = 28;
					continue;
				case 28:
					num2 = ((num == 6) ? 56 : 44);
					continue;
				case 20:
					num2 = 54;
					continue;
				case 54:
					if (this.e)
					{
						num2 = 61;
						continue;
					}
					goto case 24;
				case 52:
					num2 = 49;
					continue;
				case 49:
					if (m() > this.w)
					{
						num2 = 11;
						continue;
					}
					goto case 24;
				case 55:
					num2 = 1;
					continue;
				case 1:
					if (this.d)
					{
						num2 = 53;
						continue;
					}
					goto case 24;
				case 17:
				case 25:
					elapsed2 = this.aj.Elapsed;
					num2 = 26;
					continue;
				case 26:
					if (true)
					{
					}
					if (elapsed2.TotalMilliseconds > 700.0)
					{
						num2 = 19;
						continue;
					}
					goto case 30;
				case 53:
					num2 = 16;
					continue;
				case 16:
					if (m() == 0)
					{
						num2 = 59;
						continue;
					}
					goto case 20;
				case 19:
					elapsed = this.ao.Elapsed;
					num2 = 46;
					continue;
				case 46:
					if (elapsed.TotalMilliseconds > 500.0)
					{
						num2 = 6;
						continue;
					}
					goto case 30;
				case 39:
				case 48:
					num2 = 0;
					continue;
				case 0:
					if (num == 5)
					{
						return;
					}
					num2 = 43;
					continue;
				case 23:
					flag = false;
					d();
					num2 = 55;
					continue;
				case 35:
					num2 = 12;
					continue;
				case 12:
					if (!this.y)
					{
						num2 = 9;
						continue;
					}
					goto case 32;
				case 4:
					d();
					num2 = 2;
					continue;
				case 30:
					{
						bl = flag;
						return;
					}
					IL_022e:
					num2 = 42;
					continue;
				}
				break;
			}
		}
	}

	private void d()
	{
		if (true)
		{
		}
		b(this.m);
		this.ao.Reset();
		this.ao.Start();
	}

	private void c()
	{
		if (true)
		{
		}
		this.ap.Reset();
		this.ap.Start();
		a(this.k);
	}

	private void d(object A_0, EventArgs A_1)
	{
		int num = 36;
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				if (!global::k.a(this.at))
				{
					num = 4;
					break;
				}
				goto case 16;
			case 3:
				num = 19;
				break;
			case 19:
				if (global::k.a(this.at))
				{
					num = 23;
					break;
				}
				goto case 15;
			case 11:
				num = 22;
				break;
			case 22:
				if (m() < 100)
				{
					if (true)
					{
					}
					num = 7;
					break;
				}
				goto case 20;
			case 26:
				global::q.ae(this.at);
				num = 8;
				break;
			case 10:
				af();
				num = 27;
				break;
			case 16:
				text = ak();
				num = 12;
				break;
			case 12:
				num = ((!(this.ah != text)) ? 14 : 28);
				break;
			case 17:
				num = 9;
				break;
			case 9:
				if (ak() != "")
				{
					num = 3;
					break;
				}
				goto case 15;
			case 15:
				num = 30;
				break;
			case 30:
				if (ao() > this.aa)
				{
					num = 29;
					break;
				}
				return;
			case 25:
				num = 13;
				break;
			case 13:
				if (m() > 0)
				{
					num = 11;
					break;
				}
				goto case 20;
			case 8:
				num = 37;
				break;
			case 37:
				if (text != "Đăng nhập")
				{
					num = 21;
					break;
				}
				this.m_g = true;
				num = 2;
				break;
			case 27:
				this.ai = a6();
				this.d = false;
				global::q.af(this.at);
				g();
				this.av = global::k.b(this.at);
				bs.Clear();
				num = 15;
				break;
			case 29:
				this.aa = ao();
				this.ab = 0u;
				a(global::b.a(ao()));
				a3();
				num = 1;
				break;
			case 1:
				return;
			case 14:
				if (this.m_g)
				{
					num = 31;
					break;
				}
				goto case 2;
			case 4:
				num = 5;
				break;
			case 5:
				if (global::q.ad != null)
				{
					num = 33;
					break;
				}
				goto case 16;
			case 28:
				num = 38;
				break;
			case 38:
				if (!this.m_g)
				{
					num = 26;
					break;
				}
				goto case 8;
			case 21:
				this.ah = text;
				af();
				num = 24;
				break;
			case 6:
				num = 35;
				break;
			case 35:
				if (this.ai == "")
				{
					num = 10;
					break;
				}
				goto case 27;
			case 20:
				num = 0;
				break;
			case 0:
				if (this.ai != a6())
				{
					num = 17;
					break;
				}
				goto case 15;
			case 31:
				global::q.ae(this.at);
				this.m_g = false;
				num = 18;
				break;
			case 2:
			case 18:
			case 24:
				num = 34;
				break;
			case 34:
				if (!this.d)
				{
					num = 25;
					break;
				}
				goto case 20;
			case 7:
				this.d = true;
				global::q.af(this.at);
				num = 20;
				break;
			case 33:
				k();
				global::q.ad(this.at);
				num = 16;
				break;
			case 23:
				num = 32;
				break;
			case 32:
				if (Process.GetProcessById(this.at).Responding)
				{
					num = 6;
					break;
				}
				goto case 15;
			}
		}
	}

	private void c(object A_0, EventArgs A_1)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				if (i() > 0)
				{
					num = 4;
					break;
				}
				return;
			case 2:
				a5();
				num = 1;
				break;
			case 1:
				if (1 == 0)
				{
				}
				return;
			case 4:
				num = 0;
				break;
			case 0:
				if (i() < this.x)
				{
					num = 2;
					break;
				}
				return;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		int num = 7;
		int num2 = default(int);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			switch (num)
			{
			default:
				if (!bm)
				{
					num = 104;
					break;
				}
				goto case 17;
			case 91:
				a(25, 152);
				num = 20;
				break;
			case 70:
				num = 116;
				break;
			case 116:
				if (Math.Abs(num2 - 168) > 30)
				{
					num = 59;
					break;
				}
				goto case 35;
			case 16:
				num = 100;
				break;
			case 100:
				if (Math.Abs(num3 - 33) <= 30)
				{
					num = 19;
					break;
				}
				goto case 27;
			case 41:
				a(287, 144);
				num = 18;
				break;
			case 28:
				a(101, 167);
				num = 31;
				break;
			case 33:
				num = 15;
				break;
			case 15:
				if (Math.Abs(num2 - 152) > 30)
				{
					num = 91;
					break;
				}
				goto case 20;
			case 53:
				num = 68;
				break;
			case 68:
				if (Math.Abs(num3 - 72) <= 30)
				{
					num = 102;
					break;
				}
				goto case 12;
			case 59:
				a(101, 168);
				num = 35;
				break;
			case 27:
				a(33, 130);
				num = 37;
				break;
			case 105:
				a(287, 127);
				num = 73;
				break;
			case 86:
				num = 46;
				break;
			case 46:
				if (Math.Abs(num2 - 50) > 30)
				{
					num = 5;
					break;
				}
				return;
			case 66:
				num = 57;
				break;
			case 57:
				if (text.Equals("nhi hai"))
				{
					num = 30;
					break;
				}
				goto case 47;
			case 104:
				num = 25;
				break;
			case 25:
				if (x() == 0)
				{
					num = 43;
					break;
				}
				goto case 17;
			case 119:
				a(264, 293);
				num = 40;
				break;
			case 45:
				num = 9;
				break;
			case 9:
				if (Math.Abs(num3 - 264) <= 30)
				{
					num = 107;
					break;
				}
				goto case 119;
			case 37:
				num = 0;
				break;
			case 0:
				if (text.Equals("don hoang"))
				{
					num = 48;
					break;
				}
				goto case 117;
			case 73:
				num = 112;
				break;
			case 112:
				if (text.Equals("nhon nam"))
				{
					num = 53;
					break;
				}
				goto case 80;
			case 78:
				num = 23;
				break;
			case 23:
				if (text.Equals("don hoang"))
				{
					num = 77;
					break;
				}
				goto case 18;
			case 62:
				num = 95;
				break;
			case 95:
				if (Math.Abs(num2 - 295) > 30)
				{
					num = 90;
					break;
				}
				goto case 66;
			case 55:
				num = 109;
				break;
			case 109:
				if (Math.Abs(num3 - 160) <= 30)
				{
					num = 62;
					break;
				}
				goto case 90;
			case 94:
				num = 69;
				break;
			case 69:
				if (Math.Abs(num2 - 21) > 30)
				{
					num = 2;
					break;
				}
				goto case 32;
			case 117:
				num = 52;
				break;
			case 52:
				if (text.Equals("kiem cac"))
				{
					num = 111;
					break;
				}
				goto case 54;
			case 19:
				num = 3;
				break;
			case 3:
				if (Math.Abs(num2 - 130) > 30)
				{
					num = 27;
					break;
				}
				goto case 37;
			case 85:
				num = 42;
				break;
			case 42:
				if (Math.Abs(num2 - 144) > 30)
				{
					num = 41;
					break;
				}
				goto case 18;
			case 22:
				a(231, 289);
				num = 117;
				break;
			case 75:
				num = 58;
				break;
			case 58:
				if (Math.Abs(num2 - 289) > 30)
				{
					num = 22;
					break;
				}
				goto case 117;
			case 48:
				num = 103;
				break;
			case 103:
				if (Math.Abs(num3 - 231) <= 30)
				{
					num = 75;
					break;
				}
				goto case 22;
			case 106:
				a(150, 50);
				return;
			case 17:
				num = 89;
				break;
			case 89:
				if (x() == 2)
				{
					num = 115;
					break;
				}
				goto case 71;
			case 67:
				num = 34;
				break;
			case 34:
				if (Math.Abs(num3 - 150) <= 30)
				{
					num = 6;
					break;
				}
				goto case 106;
			case 54:
				num = 49;
				break;
			case 49:
				if (text.Equals("doi lu"))
				{
					num = 55;
					break;
				}
				goto case 66;
			case 38:
				a(105, 26);
				num = 78;
				break;
			case 90:
				a(160, 292);
				num = 66;
				break;
			case 97:
				num = 87;
				break;
			case 87:
				if (Math.Abs(num2 - 127) > 30)
				{
					num = 105;
					break;
				}
				goto case 73;
			case 82:
				num = 14;
				break;
			case 14:
				if (Math.Abs(num2 - 167) > 30)
				{
					num = 28;
					break;
				}
				goto case 31;
			case 43:
				ai();
				bm = true;
				num = 17;
				break;
			case 12:
				a(72, 284);
				num = 80;
				break;
			case 111:
				num = 101;
				break;
			case 101:
				if (Math.Abs(num3 - 36) <= 30)
				{
					num = 96;
					break;
				}
				goto case 8;
			case 31:
				num = 118;
				break;
			case 118:
				if (text.Equals("nhon nam"))
				{
					num = 45;
					break;
				}
				goto case 40;
			case 77:
				num = 39;
				break;
			case 39:
				if (Math.Abs(num3 - 287) <= 30)
				{
					num = 85;
					break;
				}
				goto case 41;
			case 56:
				num = 120;
				break;
			case 120:
				if (text.Equals("heaven"))
				{
					num = 79;
					break;
				}
				goto case 31;
			case 40:
				num = 98;
				break;
			case 98:
				if (text.Equals("loc duong"))
				{
					num = 16;
					break;
				}
				goto case 37;
			case 32:
				num = 4;
				break;
			case 4:
				if (text.Equals("doi lu"))
				{
					num = 76;
					break;
				}
				goto case 20;
			case 8:
				a(36, 300);
				num = 54;
				break;
			case 24:
				num = 50;
				break;
			case 50:
				if (Math.Abs(num3 - 287) <= 30)
				{
					num = 97;
					break;
				}
				goto case 105;
			case 1:
				num = 10;
				break;
			case 10:
				if (Math.Abs(num3 - 105) <= 30)
				{
					num = 92;
					break;
				}
				goto case 38;
			case 102:
				num = 51;
				break;
			case 51:
				if (Math.Abs(num2 - 284) > 30)
				{
					num = 12;
					break;
				}
				goto case 80;
			case 18:
				num = 99;
				break;
			case 99:
				if (text.Equals("loc duong"))
				{
					num = 24;
					break;
				}
				goto case 73;
			case 107:
				num = 60;
				break;
			case 60:
				if (Math.Abs(num2 - 293) > 30)
				{
					num = 119;
					break;
				}
				goto case 40;
			case 63:
				num = 93;
				break;
			case 93:
				if (Math.Abs(num3 - 287) <= 30)
				{
					num = 94;
					break;
				}
				goto case 2;
			case 114:
				num = 84;
				break;
			case 84:
				if (Math.Abs(num2 - 180) > 30)
				{
					num = 88;
					break;
				}
				goto case 47;
			case 61:
				num = 13;
				break;
			case 13:
				if (Math.Abs(num3 - 101) <= 30)
				{
					num = 70;
					break;
				}
				goto case 59;
			case 79:
				num = 113;
				break;
			case 113:
				if (Math.Abs(num3 - 107) <= 30)
				{
					num = 82;
					break;
				}
				goto case 28;
			case 92:
				num = 21;
				break;
			case 21:
				if (Math.Abs(num2 - 26) > 30)
				{
					num = 38;
					break;
				}
				goto case 78;
			case 35:
				num = 36;
				break;
			case 36:
				if (text.Equals("nhi hai"))
				{
					num = 63;
					break;
				}
				goto case 32;
			case 47:
				num = 64;
				break;
			case 64:
				if (text.Equals("bangthien"))
				{
					num = 67;
					break;
				}
				return;
			case 88:
				a(285, 180);
				num = 47;
				break;
			case 6:
				num = 72;
				break;
			case 72:
				if (Math.Abs(num2 - 50) > 30)
				{
					if (true)
					{
					}
					num = 106;
					break;
				}
				return;
			case 2:
				a(287, 21);
				num = 32;
				break;
			case 29:
				num = 81;
				break;
			case 81:
				if (Math.Abs(num3 - 150) <= 30)
				{
					num = 86;
					break;
				}
				goto case 5;
			case 30:
				num = 65;
				break;
			case 65:
				if (Math.Abs(num3 - 285) <= 30)
				{
					num = 114;
					break;
				}
				goto case 88;
			case 110:
				if (text.Equals("bangthien"))
				{
					num = 61;
					break;
				}
				goto case 35;
			case 76:
				num = 44;
				break;
			case 44:
				if (Math.Abs(num3 - 25) <= 30)
				{
					num = 33;
					break;
				}
				goto case 91;
			case 80:
				num = 74;
				break;
			case 74:
				if (text.Equals("heaven"))
				{
					num = 29;
					break;
				}
				return;
			case 96:
				num = 26;
				break;
			case 26:
				if (Math.Abs(num2 - 300) > 30)
				{
					num = 8;
					break;
				}
				goto case 54;
			case 115:
				bm = false;
				num = 71;
				break;
			case 71:
				text = global::m.a(a6()).ToLower().Trim();
				num3 = z();
				num2 = an();
				num = 11;
				break;
			case 11:
				num = (bn ? 56 : 110);
				break;
			case 20:
				num = 83;
				break;
			case 83:
				if (text.Equals("kiem cac"))
				{
					num = 1;
					break;
				}
				goto case 78;
			case 5:
				a(150, 50);
				num = 108;
				break;
			case 108:
				return;
			}
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		if (ao() >= 1)
		{
			a(global::b.a(ao()));
			bf.Tick -= a;
		}
	}

	[SpecialName]
	public int a0()
	{
		if (true)
		{
		}
		return this.m_au.b(new int[2] { 6870940, 14232 });
	}

	[SpecialName]
	public int ay()
	{
		return this.m_au.c(a0() + 8);
	}

	[SpecialName]
	public string a6()
	{
		if (!(this.m_au.a(this.m_au.c(a0() + 96)) == ""))
		{
			return this.m_au.a(this.m_au.c(a0() + 96));
		}
		if (true)
		{
		}
		return this.m_au.a(a0() + 96);
	}

	[SpecialName]
	public int at()
	{
		return this.m_au.c(a0() + 160);
	}

	[SpecialName]
	public int r()
	{
		return this.m_au.b(new int[4] { 7319476, 12, 344, 4 });
	}

	[SpecialName]
	public int ax()
	{
		return this.m_au.c(r() + 16);
	}

	[SpecialName]
	public int e()
	{
		return this.m_au.c(r() + 2292);
	}

	[SpecialName]
	public int au()
	{
		return this.m_au.c(r() + 2400);
	}

	[SpecialName]
	public int i()
	{
		if (au() == 0)
		{
			return 100;
		}
		if (true)
		{
		}
		return (int)((float)e() * 100f / (float)au());
	}

	[SpecialName]
	public int h()
	{
		return this.m_au.c(r() + 2296);
	}

	[SpecialName]
	public int f()
	{
		return this.m_au.c(r() + 2404);
	}

	[SpecialName]
	public int al()
	{
		if (f() == 0)
		{
			if (true)
			{
			}
			return 100;
		}
		return (int)(100f * (float)h() / (float)f());
	}

	[SpecialName]
	public int j()
	{
		return this.m_au.c(r() + 2356);
	}

	[SpecialName]
	public string ak()
	{
		string text = this.m_au.a(r() + 48);
		if (text == "")
		{
			if (true)
			{
			}
			return "Đăng nhập";
		}
		return text;
	}

	[SpecialName]
	public int x()
	{
		return this.m_au.b(new int[3] { 7319476, 12, 348 });
	}

	[SpecialName]
	public int ao()
	{
		return this.m_au.c(r() + 92);
	}

	[SpecialName]
	public int q()
	{
		return this.m_au.c(r() + 2300);
	}

	[SpecialName]
	public int o()
	{
		if (true)
		{
		}
		return this.m_au.b(new int[2] { 7319540, 299356 });
	}

	[SpecialName]
	public int a4()
	{
		int num = 0;
		int num3 = default(int);
		int num2 = default(int);
		while (true)
		{
			if (true)
			{
			}
			switch (num)
			{
			default:
				if (j() != 0)
				{
					num = 3;
					break;
				}
				return 0;
			case 1:
				return 0;
			case 3:
			{
				int num4 = az();
				num3 = this.m_au.c(o() + num4 * bo + bp);
				num2 = this.m_au.c(o() + num4 * bo + bq);
				num = 2;
				break;
			}
			case 2:
				if (num2 != 0)
				{
					return (int)((float)num3 / (float)num2 * 100f);
				}
				num = 1;
				break;
			}
		}
	}

	[SpecialName]
	public int az()
	{
		int num3 = default(int);
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				if (true)
				{
				}
				switch (num2)
				{
				case 3:
					num++;
					num2 = 4;
					continue;
				case 7:
					if (num3 != 0)
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				case 2:
					num2 = ((num3 == j()) ? 6 : 7);
					continue;
				case 4:
				case 5:
					num2 = 0;
					continue;
				case 0:
					if (num < 20)
					{
						num3 = this.m_au.c(o() + num * bo + br);
						num2 = 2;
					}
					else
					{
						num2 = 1;
					}
					continue;
				case 6:
					return num;
				case 1:
					return -1;
				}
				break;
			}
		}
	}

	private void b()
	{
		if (true)
		{
		}
		bf.Tick += d;
		bf.Tick += a;
		bb.Tick += e;
		bc.Tick += i;
		bg.Tick += f;
		bh.Tick += b;
		be.Tick += g;
		bd.Tick += h;
		bi.Tick += c;
		bf.Interval = 10000;
		bg.Interval = 1000;
		bg.Start();
		bf.Start();
		this.ak.Start();
		this.al.Start();
		this.am.Start();
		this.ao.Start();
		this.ap.Start();
		this.ar.Start();
	}

	public q(int A_0)
	{
		b();
		this.at = A_0;
		this.m_au = new r(A_0);
		this.av = global::k.b(A_0);
		af();
		this.ah = ak();
		this.ab = (uint)q();
		this.ai = a6();
	}

	public void k()
	{
		if (true)
		{
		}
		this.az.Dispose();
		this.a0.Dispose();
		this.a1.Dispose();
		this.a2.Dispose();
		this.a3.Dispose();
		this.a4.Dispose();
		this.a5.Dispose();
		this.a6.Dispose();
		a7.Dispose();
		a8.Dispose();
		a9.Dispose();
		ba.Dispose();
		bc.Dispose();
		bd.Dispose();
		be.Dispose();
		this.ak.Stop();
		this.al.Stop();
		this.am.Stop();
		this.ar.Stop();
		this.m_aq.Stop();
		bf.Dispose();
		bg.Dispose();
		bi.Dispose();
		bb.Dispose();
		this.m_au.a();
	}

	[SpecialName]
	public bool ae()
	{
		if (this.m_au.b(new int[4] { 7254568, 0, 12, 100 }) != 1)
		{
			if (true)
			{
			}
			return false;
		}
		return true;
	}

	[SpecialName]
	public int m()
	{
		if (true)
		{
		}
		return (int)(this.m_au.a(new int[7] { 7254568, 0, 12, 144, 32, 4, 624 }) * 100f);
	}

	[SpecialName]
	public bool ad()
	{
		if (true)
		{
		}
		if (this.m_au.b(new int[4] { 7264696, 0, 12, 100 }) != 1)
		{
			return false;
		}
		return true;
	}

	public void a(int A_0)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (bs.Count > 20)
				{
					num = 4;
					break;
				}
				goto case 1;
			case 3:
				bs.Add(A_0);
				if (true)
				{
				}
				num = 0;
				break;
			case 0:
				return;
			case 1:
				num = 5;
				break;
			case 5:
				if (!bs.Contains(A_0))
				{
					num = 3;
					break;
				}
				return;
			case 4:
				bs.Clear();
				num = 1;
				break;
			}
		}
	}

	[SpecialName]
	public string aw()
	{
		if (true)
		{
		}
		return this.an.Elapsed.Hours + ":" + this.an.Elapsed.Minutes + ":" + this.an.Elapsed.Seconds;
	}

	[SpecialName]
	public string ar()
	{
		if (true)
		{
		}
		return this.ar.Elapsed.Hours + ":" + this.ar.Elapsed.Minutes + ":" + this.ar.Elapsed.Seconds;
	}

	[SpecialName]
	public string ah()
	{
		int num5 = default(int);
		int num3 = default(int);
		int num4 = default(int);
		ulong num2 = default(ulong);
		while (true)
		{
			StringBuilder stringBuilder = new StringBuilder();
			int num = 15;
			while (true)
			{
				switch (num)
				{
				case 15:
					if (this.d)
					{
						num = 16;
						continue;
					}
					stringBuilder.AppendLine("Mục tiêu: chưa phát hiện được");
					num = 10;
					continue;
				case 7:
					num5 = 0;
					num = 6;
					continue;
				case 11:
					stringBuilder.AppendLine("Exp tối đa: " + $"{a1():#,#.}");
					num = 17;
					continue;
				case 0:
				case 1:
				case 13:
					num = 14;
					continue;
				case 14:
					if (this.y)
					{
						num = 21;
						continue;
					}
					stringBuilder.AppendLine("Bán kính hiện tại: ko sử dụng");
					num = 3;
					continue;
				case 6:
				case 19:
					stringBuilder.AppendLine("- Thời gian : " + num3 + " ngày, " + num4 + " giờ, " + num5 + " phút");
					num = 13;
					continue;
				case 2:
					num3 = (int)Math.Floor((float)num2 / (float)w() / 24f);
					num4 = (int)(num2 / w()) % 24;
					num5 = 0;
					num = 20;
					continue;
				case 20:
					if (w() / 60 == 0)
					{
						num = 7;
						continue;
					}
					num5 = (int)(num2 / (w() / 60)) % 60;
					num = 19;
					continue;
				case 10:
				case 22:
					stringBuilder.AppendLine("Exp ban đầu: " + $"{this.ab:#,#.}");
					stringBuilder.AppendLine("Exp hiện tại: " + $"{q():#,#.}");
					stringBuilder.AppendLine("Exp nhận được: " + $"{q() - this.ab:#,#.}");
					num = 9;
					continue;
				case 9:
					if (a1() != 0)
					{
						num = 11;
						continue;
					}
					stringBuilder.AppendLine("Exp tối đa: Các hạ cần nhập vào");
					num = 8;
					continue;
				case 21:
					stringBuilder.AppendLine("Bán kính nhân vật : " + l());
					stringBuilder.AppendLine("Bán kính mục tiêu : " + ap());
					num = 12;
					continue;
				case 8:
				case 17:
					stringBuilder.AppendLine("Thời gian luyện cấp: " + ar());
					stringBuilder.AppendLine("Tốc độ train: " + $"{w():#,#.}" + " Exp / Giờ");
					stringBuilder.AppendLine("Để thăng cấp cần: ");
					num2 = a1() - (ulong)q();
					num = 5;
					continue;
				case 5:
					if (a1() == 0)
					{
						stringBuilder.AppendLine("- Thời gian: Cần nhập vào Exp tối đa");
						num = 1;
					}
					else
					{
						num = 4;
					}
					continue;
				case 16:
					stringBuilder.AppendLine("Mục tiêu: " + m() + "%");
					num = 22;
					continue;
				case 4:
					num = 18;
					continue;
				case 18:
					if (true)
					{
					}
					if (num2 == 0)
					{
						stringBuilder.AppendLine("- Đã đủ Exp để thăng cấp");
						num = 0;
					}
					else
					{
						num = 2;
					}
					continue;
				case 3:
				case 12:
					stringBuilder.AppendLine("Vị trí: " + a6());
					return stringBuilder.ToString();
				}
				break;
			}
		}
	}

	public void b(string A_0)
	{
		int num = 2;
		string key = default(string);
		int value = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!this.f) ? 7 : 5);
				break;
			case 5:
				if (1 == 0)
				{
				}
				return;
			case 9:
				global::p.t = new Dictionary<string, int>(12)
				{
					{ "F1", 0 },
					{ "F2", 1 },
					{ "F3", 2 },
					{ "F4", 3 },
					{ "F5", 4 },
					{ "F6", 5 },
					{ "F7", 6 },
					{ "F8", 7 },
					{ "F9", 8 },
					{ "F10", 9 },
					{ "F11", 10 },
					{ "F12", 11 }
				};
				num = 8;
				break;
			case 0:
				num = 11;
				break;
			case 11:
				if (global::p.t == null)
				{
					num = 9;
					break;
				}
				goto case 8;
			case 8:
				num = 6;
				break;
			case 6:
				if (global::p.t.TryGetValue(key, out value))
				{
					num = 4;
					break;
				}
				return;
			case 1:
				return;
			case 3:
				return;
			case 4:
				num = 10;
				break;
			case 10:
				switch (value)
				{
				case 6:
					global::i.SendMessage(this.av, global::i.b, 118, 0);
					return;
				case 3:
					global::i.SendMessage(this.av, global::i.b, 115, 0);
					return;
				case 8:
					global::i.SendMessage(this.av, global::i.b, 120, 0);
					return;
				case 5:
					global::i.SendMessage(this.av, global::i.b, 117, 0);
					return;
				case 10:
					global::i.SendMessage(this.av, global::i.a, 122, 0);
					return;
				case 2:
					global::i.SendMessage(this.av, global::i.b, 114, 0);
					return;
				case 9:
					global::i.SendMessage(this.av, global::i.b, 121, 0);
					return;
				case 11:
					global::i.SendMessage(this.av, global::i.a, 123, 0);
					num = 1;
					break;
				default:
					num = 3;
					break;
				case 0:
					global::i.SendMessage(this.av, global::i.b, 112, 0);
					return;
				case 7:
					global::i.SendMessage(this.av, global::i.b, 119, 0);
					return;
				case 4:
					global::i.SendMessage(this.av, global::i.b, 116, 0);
					return;
				case 1:
					global::i.SendMessage(this.av, global::i.b, 113, 0);
					return;
				}
				break;
			case 7:
				if ((key = A_0) != null)
				{
					num = 0;
					break;
				}
				return;
			}
		}
	}

	public void aj()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				if (!this.h)
				{
					num = 2;
					break;
				}
				return;
			case 2:
				if (true)
				{
				}
				this.az.Tick += u;
				this.a0.Tick += t;
				this.a1.Tick += s;
				this.a2.Tick += r;
				this.a3.Tick += q;
				this.a4.Tick += p;
				this.a5.Tick += o;
				this.a6.Tick += n;
				a7.Tick += m;
				a8.Tick += l;
				a9.Tick += k;
				ba.Tick += j;
				this.h = true;
				num = 1;
				break;
			case 1:
				return;
			}
		}
	}

	public void p()
	{
		if (true)
		{
		}
		this.az.Tick -= u;
		this.a0.Tick -= t;
		this.a1.Tick -= s;
		this.a2.Tick -= r;
		this.a3.Tick -= q;
		this.a4.Tick -= p;
		this.a5.Tick -= o;
		this.a6.Tick -= n;
		a7.Tick -= m;
		a8.Tick -= l;
		a9.Tick -= k;
		ba.Tick -= j;
	}

	public void ac()
	{
		if (true)
		{
		}
		this.m_as.c(u());
		this.m_as.k(bb.Enabled);
		this.m_as.d(this.az.Enabled);
		this.m_as.f(this.a0.Enabled);
		this.m_as.i(this.a1.Enabled);
		this.m_as.m(this.a2.Enabled);
		this.m_as.p(this.a3.Enabled);
		this.m_as.q(this.a4.Enabled);
		this.m_as.s(this.a5.Enabled);
		this.m_as.e(this.a6.Enabled);
		this.m_as.g(a7.Enabled);
		this.m_as.h(a8.Enabled);
		this.m_as.b(a9.Enabled);
		this.m_as.t(ba.Enabled);
		this.m_as.g(this.az.Interval);
		this.m_as.o(this.a0.Interval);
		this.m_as.c(this.a1.Interval);
		this.m_as.h(this.a2.Interval);
		this.m_as.r(this.a3.Interval);
		this.m_as.d(this.a4.Interval);
		this.m_as.l(this.a5.Interval);
		this.m_as.b(this.a6.Interval);
		this.m_as.i(a7.Interval);
		this.m_as.a(a8.Interval);
		this.m_as.k(a9.Interval);
		this.m_as.j(ba.Interval);
		this.m_as.a(bc.Enabled);
		this.m_as.e(this.p);
		this.m_as.c(this.l);
		this.m_as.n(bd.Enabled);
		this.m_as.m(this.q);
		this.m_as.e(this.n);
		this.m_as.j(be.Enabled);
		this.m_as.q(this.r);
		this.m_as.g(this.o);
		this.m_as.n(this.x);
		this.m_as.r(this.e);
		this.m_as.p(this.v);
		this.m_as.s(this.w);
		this.m_as.o(this.y);
		this.m_as.f(this.s);
		this.m_as.a(this.k);
		this.m_as.f(this.m);
		this.m_as.l(this.i);
	}

	public void af()
	{
		if (true)
		{
		}
		this.m_as = new e(global::m.a(ak()));
		a(this.m_as.n());
		bb.Enabled = this.m_as.v();
		this.az.Enabled = this.m_as.aa();
		this.a0.Enabled = this.m_as.s();
		this.a1.Enabled = this.m_as.ak();
		this.a2.Enabled = this.m_as.y();
		this.a3.Enabled = this.m_as.t();
		this.a4.Enabled = this.m_as.l();
		this.a5.Enabled = this.m_as.ac();
		this.a6.Enabled = this.m_as.aq();
		a7.Enabled = this.m_as.an();
		a8.Enabled = this.m_as.aj();
		a9.Enabled = this.m_as.al();
		ba.Enabled = this.m_as.w();
		this.az.Interval = this.m_as.p();
		this.a0.Interval = this.m_as.c();
		this.a1.Interval = this.m_as.x();
		this.a2.Interval = this.m_as.j();
		this.a3.Interval = this.m_as.h();
		this.a4.Interval = this.m_as.ar();
		this.a5.Interval = this.m_as.o();
		this.a6.Interval = this.m_as.ag();
		a7.Interval = this.m_as.ae();
		a8.Interval = this.m_as.am();
		a9.Interval = this.m_as.d();
		ba.Interval = this.m_as.ai();
		bc.Enabled = this.m_as.q();
		this.p = this.m_as.ad();
		this.l = this.m_as.u();
		bd.Enabled = this.m_as.a();
		this.q = this.m_as.ap();
		this.n = this.m_as.f();
		be.Enabled = this.m_as.z();
		this.r = this.m_as.k();
		this.o = this.m_as.af();
		this.x = this.m_as.m();
		this.e = this.m_as.ab();
		this.v = this.m_as.ah();
		this.w = this.m_as.i();
		this.y = this.m_as.r();
		this.s = this.m_as.e();
		this.t = ab();
		this.u = ag();
		this.k = this.m_as.ao();
		this.m = this.m_as.g();
		this.i = this.m_as.b();
		g();
	}

	[SpecialName]
	private string a()
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((!global::q.a) ? 1 : 5);
				continue;
			case 0:
				if (!bb.Enabled)
				{
					num = 4;
					continue;
				}
				break;
			case 12:
				num = 9;
				continue;
			case 9:
				if (!u())
				{
					num = 6;
					continue;
				}
				goto IL_0065;
			case 6:
				if (true)
				{
				}
				return "Target";
			case 1:
				if (bb.Enabled)
				{
					num = 11;
					continue;
				}
				goto IL_014d;
			case 4:
				num = 8;
				continue;
			case 8:
				if (u())
				{
					num = 10;
					continue;
				}
				break;
			case 5:
				return "Stoped All";
			case 10:
				return "Skill";
			case 13:
				return "Target & Skill";
			case 11:
				num = 7;
				continue;
			case 7:
				if (u())
				{
					num = 13;
					continue;
				}
				goto IL_014d;
			case 3:
				{
					if (bb.Enabled)
					{
						num = 12;
						continue;
					}
					goto IL_0065;
				}
				IL_0065:
				num = 0;
				continue;
				IL_014d:
				num = 3;
				continue;
			}
			break;
		}
		return "Stoped";
	}

	public void g()
	{
		if (true)
		{
		}
		string text = global::m.a(ak());
		global::n.SetWindowText(this.av, text + "(" + a() + ") - " + global::m.a(a6()));
	}

	public void v()
	{
		if (true)
		{
		}
		global::i.ShowWindow(this.av, 0);
		global::b.a(this.at.ToString(), this.av.ToString());
	}

	public void ai()
	{
		new n(this.av).f();
		try
		{
			while (true)
			{
				IL_002d:
				IntPtr intPtr = (IntPtr)Convert.ToInt32(global::b.b(this.at.ToString()));
				int num = 3;
				while (true)
				{
					switch (num)
					{
					case 3:
						if (this.av != intPtr)
						{
							num = 1;
							continue;
						}
						goto IL_008e;
					case 1:
						new n(intPtr).f();
						num = 0;
						continue;
					case 0:
						if (1 == 0)
						{
						}
						goto IL_008e;
					case 2:
						goto end_IL_0014;
						IL_008e:
						num = 2;
						continue;
					}
					goto IL_002d;
					continue;
					end_IL_0014:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		this.av = global::k.b(this.at);
	}

	public void a5()
	{
		try
		{
			while (true)
			{
				IL_001b:
				Process.GetProcessById(this.at).Kill();
				k();
				global::q.ad(this.at);
				int num = 0;
				while (true)
				{
					switch (num)
					{
					case 0:
						if (global::q.c)
						{
							num = 2;
							continue;
						}
						goto case 1;
					case 2:
						Process.Start("shutdown", "-s -t 0");
						num = 1;
						continue;
					case 1:
						num = 3;
						continue;
					case 3:
						goto end_IL_0002;
					}
					goto IL_001b;
					continue;
					end_IL_0002:
					break;
				}
				break;
			}
		}
		catch
		{
		}
		if (1 == 0)
		{
		}
	}

	public void a3()
	{
		if (true)
		{
		}
		this.ar.Reset();
		this.ar.Start();
		this.ab = (uint)q();
	}

	private long a(byte A_0)
	{
		while (true)
		{
			long num = 6847512L;
			long[] array = new long[10] { 928L, 608L, 144L, 12L, 244L, 0L, 0L, 16L, 4L, 1636L };
			byte[] array2 = new byte[4];
			int A_ = 2;
			byte b2 = 0;
			if (true)
			{
			}
			int num2 = 1;
			while (true)
			{
				switch (num2)
				{
				case 6:
					ReadProcessMemory(this.m_au.a, (IntPtr)num, array2, 4, out A_);
					num = BitConverter.ToInt32(array2, 0) + array[4] + 12 * A_0;
					b2 = 5;
					num2 = 2;
					continue;
				case 2:
				case 3:
					num2 = 4;
					continue;
				case 4:
					if (b2 < 10)
					{
						ReadProcessMemory(this.m_au.a, (IntPtr)num, array2, 4, out A_);
						num = BitConverter.ToInt32(array2, 0) + array[b2];
						b2++;
						num2 = 3;
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 1:
				case 5:
					num2 = 0;
					continue;
				case 0:
					if (b2 < 4)
					{
						ReadProcessMemory(this.m_au.a, (IntPtr)num, array2, 4, out A_);
						num = BitConverter.ToInt32(array2, 0) + array[b2];
						b2++;
						num2 = 5;
					}
					else
					{
						num2 = 6;
					}
					continue;
				case 7:
					ReadProcessMemory(this.m_au.a, (IntPtr)num, array2, 1, out A_);
					return array2[0];
				}
				break;
			}
		}
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool ReadProcessMemory(IntPtr A_0, IntPtr A_1, [Out] byte[] A_2, int A_3, out int A_4);
}
