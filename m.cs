public class m
{
	private static readonly string[] m_a;

	public static string a(string A_0)
	{
		int num3 = default(int);
		while (true)
		{
			int num = 1;
			int num2 = 2;
			while (true)
			{
				switch (num2)
				{
				case 7:
					num++;
					if (true)
					{
					}
					num2 = 6;
					continue;
				case 1:
				case 3:
					num2 = 5;
					continue;
				case 5:
					if (num3 >= m.m_a[num].Length)
					{
						num2 = 7;
						continue;
					}
					A_0 = A_0.Replace(m.m_a[num][num3], m.m_a[0][num - 1]);
					num3++;
					num2 = 1;
					continue;
				case 2:
				case 6:
					num2 = 4;
					continue;
				case 4:
					if (num < m.m_a.Length)
					{
						num3 = 0;
						num2 = 3;
					}
					else
					{
						num2 = 0;
					}
					continue;
				case 0:
					return A_0;
				}
				break;
			}
		}
	}

	static m()
	{
		if (true)
		{
		}
		m.m_a = new string[15]
		{
			"aAeEoOuUiIdDyY", "áàạảãâấầậẩẫăắằặẳẵ", "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ", "éèẹẻẽêếềệểễ", "ÉÈẸẺẼÊẾỀỆỂỄ", "óòọỏõôốồộổỗơớờợởỡ", "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ", "úùụủũưứừựửữ", "ÚÙỤỦŨƯỨỪỰỬỮ", "íìịỉĩ",
			"ÍÌỊỈĨ", "đ", "Đ", "ýỳỵỷỹ", "ÝỲỴỶỸ"
		};
	}
}
