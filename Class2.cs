using System;
using System.Windows.Forms;

// Token: 0x02000006 RID: 6
internal class Class2
{
	// Token: 0x06000014 RID: 20 RVA: 0x00002253 File Offset: 0x00000453
	public Class2(string string_2)
	{
		this.gclass1_0 = new GClass1(Class2.string_0 + "\\" + string_2 + ".ini");
	}

	// Token: 0x06000015 RID: 21 RVA: 0x0000227B File Offset: 0x0000047B
	public bool method_0()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "IsSkill"));
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00002298 File Offset: 0x00000498
	public void method_1(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "IsSkill", bool_0.ToString());
	}

	// Token: 0x06000017 RID: 23 RVA: 0x000022B6 File Offset: 0x000004B6
	public bool method_2()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "RadiusEnable"));
	}

	// Token: 0x06000018 RID: 24 RVA: 0x000022D3 File Offset: 0x000004D3
	public void method_3(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "RadiusEnable", bool_0.ToString());
	}

	// Token: 0x06000019 RID: 25 RVA: 0x000022F1 File Offset: 0x000004F1
	public bool method_4()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "IsUseTarget"));
	}

	// Token: 0x0600001A RID: 26 RVA: 0x0000230E File Offset: 0x0000050E
	public void method_5(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "IsUseTarget", bool_0.ToString());
	}

	// Token: 0x0600001B RID: 27 RVA: 0x0000232C File Offset: 0x0000052C
	public bool method_6()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "IsOnlyAttackFixHP"));
	}

	// Token: 0x0600001C RID: 28 RVA: 0x00002349 File Offset: 0x00000549
	public void method_7(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "IsOnlyAttackFixHP", bool_0.ToString());
	}

	// Token: 0x0600001D RID: 29 RVA: 0x00002367 File Offset: 0x00000567
	public bool method_8()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "BuffPetEnable"));
	}

	// Token: 0x0600001E RID: 30 RVA: 0x00002384 File Offset: 0x00000584
	public void method_9(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffPetEnable", bool_0.ToString());
	}

	// Token: 0x0600001F RID: 31 RVA: 0x000023A2 File Offset: 0x000005A2
	public bool method_10()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "BuffHPEnable"));
	}

	// Token: 0x06000020 RID: 32 RVA: 0x000023BF File Offset: 0x000005BF
	public void method_11(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffHPEnable", bool_0.ToString());
	}

	// Token: 0x06000021 RID: 33 RVA: 0x000023DD File Offset: 0x000005DD
	public bool method_12()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "BuffMPEnable"));
	}

	// Token: 0x06000022 RID: 34 RVA: 0x000023FA File Offset: 0x000005FA
	public void method_13(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffMPEnable", bool_0.ToString());
	}

	// Token: 0x06000023 RID: 35 RVA: 0x00002418 File Offset: 0x00000618
	public bool method_14()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F1Enable"));
	}

	// Token: 0x06000024 RID: 36 RVA: 0x00002435 File Offset: 0x00000635
	public void method_15(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F1Enable", bool_0.ToString());
	}

	// Token: 0x06000025 RID: 37 RVA: 0x00002453 File Offset: 0x00000653
	public bool method_16()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F2Enable"));
	}

	// Token: 0x06000026 RID: 38 RVA: 0x00002470 File Offset: 0x00000670
	public void method_17(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F2Enable", bool_0.ToString());
	}

	// Token: 0x06000027 RID: 39 RVA: 0x0000248E File Offset: 0x0000068E
	public bool method_18()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F3Enable"));
	}

	// Token: 0x06000028 RID: 40 RVA: 0x000024AB File Offset: 0x000006AB
	public void method_19(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F3Enable", bool_0.ToString());
	}

	// Token: 0x06000029 RID: 41 RVA: 0x000024C9 File Offset: 0x000006C9
	public bool method_20()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F4Enable"));
	}

	// Token: 0x0600002A RID: 42 RVA: 0x000024E6 File Offset: 0x000006E6
	public void method_21(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F4Enable", bool_0.ToString());
	}

	// Token: 0x0600002B RID: 43 RVA: 0x00002504 File Offset: 0x00000704
	public bool method_22()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F5Enable"));
	}

	// Token: 0x0600002C RID: 44 RVA: 0x00002521 File Offset: 0x00000721
	public void method_23(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F5Enable", bool_0.ToString());
	}

	// Token: 0x0600002D RID: 45 RVA: 0x0000253F File Offset: 0x0000073F
	public bool method_24()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F6Enable"));
	}

	// Token: 0x0600002E RID: 46 RVA: 0x0000255C File Offset: 0x0000075C
	public void method_25(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F6Enable", bool_0.ToString());
	}

	// Token: 0x0600002F RID: 47 RVA: 0x0000257A File Offset: 0x0000077A
	public bool method_26()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F7Enable"));
	}

	// Token: 0x06000030 RID: 48 RVA: 0x00002597 File Offset: 0x00000797
	public void method_27(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F7Enable", bool_0.ToString());
	}

	// Token: 0x06000031 RID: 49 RVA: 0x000025B5 File Offset: 0x000007B5
	public bool method_28()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F8Enable"));
	}

	// Token: 0x06000032 RID: 50 RVA: 0x000025D2 File Offset: 0x000007D2
	public void method_29(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F8Enable", bool_0.ToString());
	}

	// Token: 0x06000033 RID: 51 RVA: 0x000025F0 File Offset: 0x000007F0
	public bool method_30()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F9Enable"));
	}

	// Token: 0x06000034 RID: 52 RVA: 0x0000260D File Offset: 0x0000080D
	public void method_31(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F9Enable", bool_0.ToString());
	}

	// Token: 0x06000035 RID: 53 RVA: 0x0000262B File Offset: 0x0000082B
	public bool method_32()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F10Enable"));
	}

	// Token: 0x06000036 RID: 54 RVA: 0x00002648 File Offset: 0x00000848
	public void method_33(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F10Enable", bool_0.ToString());
	}

	// Token: 0x06000037 RID: 55 RVA: 0x00002666 File Offset: 0x00000866
	public bool method_34()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F11Enable"));
	}

	// Token: 0x06000038 RID: 56 RVA: 0x00002683 File Offset: 0x00000883
	public void method_35(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F11Enable", bool_0.ToString());
	}

	// Token: 0x06000039 RID: 57 RVA: 0x000026A1 File Offset: 0x000008A1
	public bool method_36()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "F12Enable"));
	}

	// Token: 0x0600003A RID: 58 RVA: 0x000026BE File Offset: 0x000008BE
	public void method_37(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F12Enable", bool_0.ToString());
	}

	// Token: 0x0600003B RID: 59 RVA: 0x000026DC File Offset: 0x000008DC
	public bool method_38()
	{
		return this.method_88(this.gclass1_0.method_1(Class2.string_1, "IsLure"));
	}

	// Token: 0x0600003C RID: 60 RVA: 0x000026F9 File Offset: 0x000008F9
	public void method_39(bool bool_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "IsLure", bool_0.ToString());
	}

	// Token: 0x0600003D RID: 61 RVA: 0x000042BC File Offset: 0x000024BC
	public int method_40()
	{
		int result;
		try
		{
			result = (int)Convert.ToInt16(this.gclass1_0.method_1(Class2.string_1, "RadiusValue"));
		}
		catch
		{
			result = 18;
		}
		return result;
	}

	// Token: 0x0600003E RID: 62 RVA: 0x00002717 File Offset: 0x00000917
	public void method_41(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "RadiusValue", int_0.ToString());
	}

	// Token: 0x0600003F RID: 63 RVA: 0x00002735 File Offset: 0x00000935
	public int method_42()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F1Delay"));
	}

	// Token: 0x06000040 RID: 64 RVA: 0x00002752 File Offset: 0x00000952
	public void method_43(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F1Delay", int_0.ToString());
	}

	// Token: 0x06000041 RID: 65 RVA: 0x00002770 File Offset: 0x00000970
	public int method_44()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F2Delay"));
	}

	// Token: 0x06000042 RID: 66 RVA: 0x0000278D File Offset: 0x0000098D
	public void method_45(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F2Delay", int_0.ToString());
	}

	// Token: 0x06000043 RID: 67 RVA: 0x000027AB File Offset: 0x000009AB
	public int method_46()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F3Delay"));
	}

	// Token: 0x06000044 RID: 68 RVA: 0x000027C8 File Offset: 0x000009C8
	public void method_47(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F3Delay", int_0.ToString());
	}

	// Token: 0x06000045 RID: 69 RVA: 0x000027E6 File Offset: 0x000009E6
	public int method_48()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F4Delay"));
	}

	// Token: 0x06000046 RID: 70 RVA: 0x00002803 File Offset: 0x00000A03
	public void method_49(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F4Delay", int_0.ToString());
	}

	// Token: 0x06000047 RID: 71 RVA: 0x00002821 File Offset: 0x00000A21
	public int method_50()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F5Delay"));
	}

	// Token: 0x06000048 RID: 72 RVA: 0x0000283E File Offset: 0x00000A3E
	public void method_51(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F5Delay", int_0.ToString());
	}

	// Token: 0x06000049 RID: 73 RVA: 0x0000285C File Offset: 0x00000A5C
	public int method_52()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F6Delay"));
	}

	// Token: 0x0600004A RID: 74 RVA: 0x00002879 File Offset: 0x00000A79
	public void method_53(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F6Delay", int_0.ToString());
	}

	// Token: 0x0600004B RID: 75 RVA: 0x00002897 File Offset: 0x00000A97
	public int method_54()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F7Delay"));
	}

	// Token: 0x0600004C RID: 76 RVA: 0x000028B4 File Offset: 0x00000AB4
	public void method_55(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F7Delay", int_0.ToString());
	}

	// Token: 0x0600004D RID: 77 RVA: 0x000028D2 File Offset: 0x00000AD2
	public int method_56()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F8Delay"));
	}

	// Token: 0x0600004E RID: 78 RVA: 0x000028EF File Offset: 0x00000AEF
	public void method_57(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F8Delay", int_0.ToString());
	}

	// Token: 0x0600004F RID: 79 RVA: 0x0000290D File Offset: 0x00000B0D
	public int method_58()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F9Delay"));
	}

	// Token: 0x06000050 RID: 80 RVA: 0x0000292A File Offset: 0x00000B2A
	public void method_59(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F9Delay", int_0.ToString());
	}

	// Token: 0x06000051 RID: 81 RVA: 0x00002948 File Offset: 0x00000B48
	public int method_60()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F10Delay"));
	}

	// Token: 0x06000052 RID: 82 RVA: 0x00002965 File Offset: 0x00000B65
	public void method_61(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F10Delay", int_0.ToString());
	}

	// Token: 0x06000053 RID: 83 RVA: 0x00002983 File Offset: 0x00000B83
	public int method_62()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F11Delay"));
	}

	// Token: 0x06000054 RID: 84 RVA: 0x000029A0 File Offset: 0x00000BA0
	public void method_63(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F11Delay", int_0.ToString());
	}

	// Token: 0x06000055 RID: 85 RVA: 0x000029BE File Offset: 0x00000BBE
	public int method_64()
	{
		return this.method_89(this.gclass1_0.method_1(Class2.string_1, "F12Delay"));
	}

	// Token: 0x06000056 RID: 86 RVA: 0x000029DB File Offset: 0x00000BDB
	public void method_65(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "F12Delay", int_0.ToString());
	}

	// Token: 0x06000057 RID: 87 RVA: 0x00004300 File Offset: 0x00002500
	public int method_66()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.gclass1_0.method_1(Class2.string_1, "BuffPetPercent"));
		}
		catch
		{
			result = 50;
		}
		return result;
	}

	// Token: 0x06000058 RID: 88 RVA: 0x000029F9 File Offset: 0x00000BF9
	public void method_67(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffPetPercent", int_0.ToString());
	}

	// Token: 0x06000059 RID: 89 RVA: 0x00004344 File Offset: 0x00002544
	public int method_68()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.gclass1_0.method_1(Class2.string_1, "BuffHPPercent"));
		}
		catch
		{
			result = 50;
		}
		return result;
	}

	// Token: 0x0600005A RID: 90 RVA: 0x00002A17 File Offset: 0x00000C17
	public void method_69(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffHPPercent", int_0.ToString());
	}

	// Token: 0x0600005B RID: 91 RVA: 0x00004388 File Offset: 0x00002588
	public int method_70()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.gclass1_0.method_1(Class2.string_1, "BuffMPPercent"));
		}
		catch
		{
			result = 50;
		}
		return result;
	}

	// Token: 0x0600005C RID: 92 RVA: 0x00002A35 File Offset: 0x00000C35
	public void method_71(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffMPPercent", int_0.ToString());
	}

	// Token: 0x0600005D RID: 93 RVA: 0x000043CC File Offset: 0x000025CC
	public int method_72()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.gclass1_0.method_1(Class2.string_1, "OnlyAttackFixHPMinPercent"));
		}
		catch
		{
			result = 0;
		}
		return result;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x00002A53 File Offset: 0x00000C53
	public void method_73(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "OnlyAttackFixHPMinPercent", int_0.ToString());
	}

	// Token: 0x0600005F RID: 95 RVA: 0x0000440C File Offset: 0x0000260C
	public int method_74()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.gclass1_0.method_1(Class2.string_1, "OnlyAttackFixHPMaxPercent"));
		}
		catch
		{
			result = 100;
		}
		return result;
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00002A71 File Offset: 0x00000C71
	public void method_75(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "OnlyAttackFixHPMaxPercent", int_0.ToString());
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00004450 File Offset: 0x00002650
	public int method_76()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.gclass1_0.method_1(Class2.string_1, "ExitWhenHPLowPercent"));
		}
		catch
		{
			result = 50;
		}
		return result;
	}

	// Token: 0x06000062 RID: 98 RVA: 0x00002A8F File Offset: 0x00000C8F
	public void method_77(int int_0)
	{
		this.gclass1_0.method_0(Class2.string_1, "ExitWhenHPLowPercent", int_0.ToString());
	}

	// Token: 0x06000063 RID: 99 RVA: 0x00002AAD File Offset: 0x00000CAD
	public string method_78()
	{
		if (!(this.gclass1_0.method_1(Class2.string_1, "BuffPetKey") == ""))
		{
			return this.gclass1_0.method_1(Class2.string_1, "BuffPetKey");
		}
		return "F9";
	}

	// Token: 0x06000064 RID: 100 RVA: 0x00002AEB File Offset: 0x00000CEB
	public void method_79(string string_2)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffPetKey", string_2.ToString());
	}

	// Token: 0x06000065 RID: 101 RVA: 0x00002B08 File Offset: 0x00000D08
	public string method_80()
	{
		if (!(this.gclass1_0.method_1(Class2.string_1, "BuffHPKey") == ""))
		{
			return this.gclass1_0.method_1(Class2.string_1, "BuffHPKey");
		}
		return "F8";
	}

	// Token: 0x06000066 RID: 102 RVA: 0x00002B46 File Offset: 0x00000D46
	public void method_81(string string_2)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffHPKey", string_2.ToString());
	}

	// Token: 0x06000067 RID: 103 RVA: 0x00002B63 File Offset: 0x00000D63
	public string method_82()
	{
		if (!(this.gclass1_0.method_1(Class2.string_1, "BuffMPKey") == ""))
		{
			return this.gclass1_0.method_1(Class2.string_1, "BuffMPKey");
		}
		return "F7";
	}

	// Token: 0x06000068 RID: 104 RVA: 0x00002BA1 File Offset: 0x00000DA1
	public void method_83(string string_2)
	{
		this.gclass1_0.method_0(Class2.string_1, "BuffMPKey", string_2.ToString());
	}

	// Token: 0x06000069 RID: 105 RVA: 0x00002BBE File Offset: 0x00000DBE
	public string method_84()
	{
		if (!(this.gclass1_0.method_1(Class2.string_1, "BaseSkill") == ""))
		{
			return this.gclass1_0.method_1(Class2.string_1, "BaseSkill");
		}
		return "F1";
	}

	// Token: 0x0600006A RID: 106 RVA: 0x00002BFC File Offset: 0x00000DFC
	public void method_85(string string_2)
	{
		this.gclass1_0.method_0(Class2.string_1, "BaseSkill", string_2.ToString());
	}

	// Token: 0x0600006B RID: 107 RVA: 0x00002C19 File Offset: 0x00000E19
	public string method_86()
	{
		if (!(this.gclass1_0.method_1(Class2.string_1, "TargetKey") == ""))
		{
			return this.gclass1_0.method_1(Class2.string_1, "TargetKey");
		}
		return "F11";
	}

	// Token: 0x0600006C RID: 108 RVA: 0x00002C57 File Offset: 0x00000E57
	public void method_87(string string_2)
	{
		this.gclass1_0.method_0(Class2.string_1, "TargetKey", string_2.ToString());
	}

	// Token: 0x0600006D RID: 109 RVA: 0x00004494 File Offset: 0x00002694
	public bool method_88(string string_2)
	{
		bool result;
		try
		{
			result = Convert.ToBoolean(string_2);
		}
		catch
		{
			result = false;
		}
		return result;
	}

	// Token: 0x0600006E RID: 110 RVA: 0x000044C0 File Offset: 0x000026C0
	public int method_89(string string_2)
	{
		int result;
		try
		{
			result = Convert.ToInt32(string_2);
		}
		catch
		{
			result = 1000;
		}
		return result;
	}

	// Token: 0x0400000B RID: 11
	public static string string_0 = Application.StartupPath + "\\Settings";

	// Token: 0x0400000C RID: 12
	public static string string_1 = "Microauto";

	// Token: 0x0400000D RID: 13
	private GClass1 gclass1_0;
}
