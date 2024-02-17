using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly)]
[ComVisible(false)]
public sealed class DotfuscatorAttribute : Attribute
{
	private string a;

	private bool b;

	private int c;

	public string A => a;

	public bool B => b;

	public int C => c;

	public DotfuscatorAttribute(string a, int c, bool b)
	{
		this.a = a;
		this.c = c;
		this.b = b;
	}
}
