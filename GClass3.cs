using System;


public class GClass3
{
	
	public static string smethod_0(string string_1)
	{
		for (int i = 1; i < GClass3.string_0.Length; i++)
		{
			for (int j = 0; j < GClass3.string_0[i].Length; j++)
			{
				string_1 = string_1.Replace(GClass3.string_0[i][j], GClass3.string_0[0][i - 1]);
			}
		}
		return string_1;
	}

	
	private static readonly string[] string_0 = new string[]
	{
		"aAeEoOuUiIdDyY",
		"áàạảãâấầậẩẫăắằặẳẵ",
		"ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",
		"éèẹẻẽêếềệểễ",
		"ÉÈẸẺẼÊẾỀỆỂỄ",
		"óòọỏõôốồộổỗơớờợởỡ",
		"ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",
		"úùụủũưứừựửữ",
		"ÚÙỤỦŨƯỨỪỰỬỮ",
		"íìịỉĩ",
		"ÍÌỊỈĨ",
		"đ",
		"Đ",
		"ýỳỵỷỹ",
		"ÝỲỴỶỸ"
	};
}
