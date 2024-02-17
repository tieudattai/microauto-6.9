using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class e
{
	public static string a = Application.StartupPath + "\\Settings";

	public static string b = "Microauto";

	private c m_c;

	public e(string A_0)
	{
		this.m_c = new c(global::e.a + "\\" + A_0 + ".ini");
	}

	[SpecialName]
	public bool n()
	{
		return d(this.m_c.a(global::e.b, "IsSkill"));
	}

	[SpecialName]
	public void c(bool A_0)
	{
		this.m_c.a(global::e.b, "IsSkill", A_0.ToString());
	}

	[SpecialName]
	public bool r()
	{
		return d(this.m_c.a(global::e.b, "RadiusEnable"));
	}

	[SpecialName]
	public void o(bool A_0)
	{
		this.m_c.a(global::e.b, "RadiusEnable", A_0.ToString());
	}

	[SpecialName]
	public bool v()
	{
		return d(this.m_c.a(global::e.b, "IsUseTarget"));
	}

	[SpecialName]
	public void k(bool A_0)
	{
		this.m_c.a(global::e.b, "IsUseTarget", A_0.ToString());
	}

	[SpecialName]
	public bool ab()
	{
		return d(this.m_c.a(global::e.b, "IsOnlyAttackFixHP"));
	}

	[SpecialName]
	public void r(bool A_0)
	{
		this.m_c.a(global::e.b, "IsOnlyAttackFixHP", A_0.ToString());
	}

	[SpecialName]
	public bool q()
	{
		return d(this.m_c.a(global::e.b, "BuffPetEnable"));
	}

	[SpecialName]
	public void a(bool A_0)
	{
		this.m_c.a(global::e.b, "BuffPetEnable", A_0.ToString());
	}

	[SpecialName]
	public bool a()
	{
		return d(this.m_c.a(global::e.b, "BuffHPEnable"));
	}

	[SpecialName]
	public void n(bool A_0)
	{
		this.m_c.a(global::e.b, "BuffHPEnable", A_0.ToString());
	}

	[SpecialName]
	public bool z()
	{
		return d(this.m_c.a(global::e.b, "BuffMPEnable"));
	}

	[SpecialName]
	public void j(bool A_0)
	{
		this.m_c.a(global::e.b, "BuffMPEnable", A_0.ToString());
	}

	[SpecialName]
	public bool aa()
	{
		return d(this.m_c.a(global::e.b, "F1Enable"));
	}

	[SpecialName]
	public void d(bool A_0)
	{
		this.m_c.a(global::e.b, "F1Enable", A_0.ToString());
	}

	[SpecialName]
	public bool s()
	{
		return d(this.m_c.a(global::e.b, "F2Enable"));
	}

	[SpecialName]
	public void f(bool A_0)
	{
		this.m_c.a(global::e.b, "F2Enable", A_0.ToString());
	}

	[SpecialName]
	public bool ak()
	{
		return d(this.m_c.a(global::e.b, "F3Enable"));
	}

	[SpecialName]
	public void i(bool A_0)
	{
		this.m_c.a(global::e.b, "F3Enable", A_0.ToString());
	}

	[SpecialName]
	public bool y()
	{
		return d(this.m_c.a(global::e.b, "F4Enable"));
	}

	[SpecialName]
	public void m(bool A_0)
	{
		this.m_c.a(global::e.b, "F4Enable", A_0.ToString());
	}

	[SpecialName]
	public bool t()
	{
		return d(this.m_c.a(global::e.b, "F5Enable"));
	}

	[SpecialName]
	public void p(bool A_0)
	{
		this.m_c.a(global::e.b, "F5Enable", A_0.ToString());
	}

	[SpecialName]
	public bool l()
	{
		return d(this.m_c.a(global::e.b, "F6Enable"));
	}

	[SpecialName]
	public void q(bool A_0)
	{
		this.m_c.a(global::e.b, "F6Enable", A_0.ToString());
	}

	[SpecialName]
	public bool ac()
	{
		return d(this.m_c.a(global::e.b, "F7Enable"));
	}

	[SpecialName]
	public void s(bool A_0)
	{
		this.m_c.a(global::e.b, "F7Enable", A_0.ToString());
	}

	[SpecialName]
	public bool aq()
	{
		return d(this.m_c.a(global::e.b, "F8Enable"));
	}

	[SpecialName]
	public void e(bool A_0)
	{
		this.m_c.a(global::e.b, "F8Enable", A_0.ToString());
	}

	[SpecialName]
	public bool an()
	{
		return d(this.m_c.a(global::e.b, "F9Enable"));
	}

	[SpecialName]
	public void g(bool A_0)
	{
		this.m_c.a(global::e.b, "F9Enable", A_0.ToString());
	}

	[SpecialName]
	public bool aj()
	{
		return d(this.m_c.a(global::e.b, "F10Enable"));
	}

	[SpecialName]
	public void h(bool A_0)
	{
		this.m_c.a(global::e.b, "F10Enable", A_0.ToString());
	}

	[SpecialName]
	public bool al()
	{
		return d(this.m_c.a(global::e.b, "F11Enable"));
	}

	[SpecialName]
	public void b(bool A_0)
	{
		this.m_c.a(global::e.b, "F11Enable", A_0.ToString());
	}

	[SpecialName]
	public bool w()
	{
		return d(this.m_c.a(global::e.b, "F12Enable"));
	}

	[SpecialName]
	public void t(bool A_0)
	{
		this.m_c.a(global::e.b, "F12Enable", A_0.ToString());
	}

	[SpecialName]
	public bool b()
	{
		return d(this.m_c.a(global::e.b, "IsLure"));
	}

	[SpecialName]
	public void l(bool A_0)
	{
		this.m_c.a(global::e.b, "IsLure", A_0.ToString());
	}

	[SpecialName]
	public int e()
	{
		try
		{
			if (true)
			{
			}
			return Convert.ToInt16(this.m_c.a(global::e.b, "RadiusValue"));
		}
		catch
		{
			return 18;
		}
	}

	[SpecialName]
	public void f(int A_0)
	{
		this.m_c.a(global::e.b, "RadiusValue", A_0.ToString());
	}

	[SpecialName]
	public int p()
	{
		return b(this.m_c.a(global::e.b, "F1Delay"));
	}

	[SpecialName]
	public void g(int A_0)
	{
		this.m_c.a(global::e.b, "F1Delay", A_0.ToString());
	}

	[SpecialName]
	public int c()
	{
		return b(this.m_c.a(global::e.b, "F2Delay"));
	}

	[SpecialName]
	public void o(int A_0)
	{
		this.m_c.a(global::e.b, "F2Delay", A_0.ToString());
	}

	[SpecialName]
	public int x()
	{
		return b(this.m_c.a(global::e.b, "F3Delay"));
	}

	[SpecialName]
	public void c(int A_0)
	{
		this.m_c.a(global::e.b, "F3Delay", A_0.ToString());
	}

	[SpecialName]
	public int j()
	{
		return b(this.m_c.a(global::e.b, "F4Delay"));
	}

	[SpecialName]
	public void h(int A_0)
	{
		this.m_c.a(global::e.b, "F4Delay", A_0.ToString());
	}

	[SpecialName]
	public int h()
	{
		return b(this.m_c.a(global::e.b, "F5Delay"));
	}

	[SpecialName]
	public void r(int A_0)
	{
		this.m_c.a(global::e.b, "F5Delay", A_0.ToString());
	}

	[SpecialName]
	public int ar()
	{
		return b(this.m_c.a(global::e.b, "F6Delay"));
	}

	[SpecialName]
	public void d(int A_0)
	{
		this.m_c.a(global::e.b, "F6Delay", A_0.ToString());
	}

	[SpecialName]
	public int o()
	{
		return b(this.m_c.a(global::e.b, "F7Delay"));
	}

	[SpecialName]
	public void l(int A_0)
	{
		this.m_c.a(global::e.b, "F7Delay", A_0.ToString());
	}

	[SpecialName]
	public int ag()
	{
		return b(this.m_c.a(global::e.b, "F8Delay"));
	}

	[SpecialName]
	public void b(int A_0)
	{
		this.m_c.a(global::e.b, "F8Delay", A_0.ToString());
	}

	[SpecialName]
	public int ae()
	{
		return b(this.m_c.a(global::e.b, "F9Delay"));
	}

	[SpecialName]
	public void i(int A_0)
	{
		this.m_c.a(global::e.b, "F9Delay", A_0.ToString());
	}

	[SpecialName]
	public int am()
	{
		return b(this.m_c.a(global::e.b, "F10Delay"));
	}

	[SpecialName]
	public void a(int A_0)
	{
		this.m_c.a(global::e.b, "F10Delay", A_0.ToString());
	}

	[SpecialName]
	public int d()
	{
		return b(this.m_c.a(global::e.b, "F11Delay"));
	}

	[SpecialName]
	public void k(int A_0)
	{
		this.m_c.a(global::e.b, "F11Delay", A_0.ToString());
	}

	[SpecialName]
	public int ai()
	{
		return b(this.m_c.a(global::e.b, "F12Delay"));
	}

	[SpecialName]
	public void j(int A_0)
	{
		this.m_c.a(global::e.b, "F12Delay", A_0.ToString());
	}

	[SpecialName]
	public int ad()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.m_c.a(global::e.b, "BuffPetPercent"));
		}
		catch
		{
			result = 50;
		}
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public void e(int A_0)
	{
		this.m_c.a(global::e.b, "BuffPetPercent", A_0.ToString());
	}

	[SpecialName]
	public int ap()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.m_c.a(global::e.b, "BuffHPPercent"));
		}
		catch
		{
			result = 50;
		}
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public void m(int A_0)
	{
		this.m_c.a(global::e.b, "BuffHPPercent", A_0.ToString());
	}

	[SpecialName]
	public int k()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.m_c.a(global::e.b, "BuffMPPercent"));
		}
		catch
		{
			result = 50;
		}
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public void q(int A_0)
	{
		this.m_c.a(global::e.b, "BuffMPPercent", A_0.ToString());
	}

	[SpecialName]
	public int ah()
	{
		try
		{
			if (true)
			{
			}
			return Convert.ToInt32(this.m_c.a(global::e.b, "OnlyAttackFixHPMinPercent"));
		}
		catch
		{
			return 0;
		}
	}

	[SpecialName]
	public void p(int A_0)
	{
		this.m_c.a(global::e.b, "OnlyAttackFixHPMinPercent", A_0.ToString());
	}

	[SpecialName]
	public int i()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.m_c.a(global::e.b, "OnlyAttackFixHPMaxPercent"));
		}
		catch
		{
			result = 100;
		}
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public void s(int A_0)
	{
		this.m_c.a(global::e.b, "OnlyAttackFixHPMaxPercent", A_0.ToString());
	}

	[SpecialName]
	public int m()
	{
		int result;
		try
		{
			result = Convert.ToInt32(this.m_c.a(global::e.b, "ExitWhenHPLowPercent"));
		}
		catch
		{
			result = 50;
		}
		if (true)
		{
		}
		return result;
	}

	[SpecialName]
	public void n(int A_0)
	{
		this.m_c.a(global::e.b, "ExitWhenHPLowPercent", A_0.ToString());
	}

	[SpecialName]
	public string u()
	{
		if (true)
		{
		}
		if (!(this.m_c.a(global::e.b, "BuffPetKey") == ""))
		{
			return this.m_c.a(global::e.b, "BuffPetKey");
		}
		return "F9";
	}

	[SpecialName]
	public void c(string A_0)
	{
		this.m_c.a(global::e.b, "BuffPetKey", A_0.ToString());
	}

	[SpecialName]
	public string f()
	{
		if (!(this.m_c.a(global::e.b, "BuffHPKey") == ""))
		{
			if (true)
			{
			}
			return this.m_c.a(global::e.b, "BuffHPKey");
		}
		return "F8";
	}

	[SpecialName]
	public void e(string A_0)
	{
		this.m_c.a(global::e.b, "BuffHPKey", A_0.ToString());
	}

	[SpecialName]
	public string af()
	{
		if (!(this.m_c.a(global::e.b, "BuffMPKey") == ""))
		{
			if (true)
			{
			}
			return this.m_c.a(global::e.b, "BuffMPKey");
		}
		return "F7";
	}

	[SpecialName]
	public void g(string A_0)
	{
		this.m_c.a(global::e.b, "BuffMPKey", A_0.ToString());
	}

	[SpecialName]
	public string ao()
	{
		if (!(this.m_c.a(global::e.b, "BaseSkill") == ""))
		{
			if (true)
			{
			}
			return this.m_c.a(global::e.b, "BaseSkill");
		}
		return "F1";
	}

	[SpecialName]
	public void a(string A_0)
	{
		this.m_c.a(global::e.b, "BaseSkill", A_0.ToString());
	}

	[SpecialName]
	public string g()
	{
		if (!(this.m_c.a(global::e.b, "TargetKey") == ""))
		{
			if (true)
			{
			}
			return this.m_c.a(global::e.b, "TargetKey");
		}
		return "F11";
	}

	[SpecialName]
	public void f(string A_0)
	{
		this.m_c.a(global::e.b, "TargetKey", A_0.ToString());
	}

	public bool d(string A_0)
	{
		try
		{
			if (true)
			{
			}
			return Convert.ToBoolean(A_0);
		}
		catch
		{
			return false;
		}
	}

	public int b(string A_0)
	{
		int result;
		try
		{
			result = Convert.ToInt32(A_0);
		}
		catch
		{
			result = 1000;
		}
		if (true)
		{
		}
		return result;
	}
}
