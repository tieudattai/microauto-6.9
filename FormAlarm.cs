using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

// Token: 0x02000005 RID: 5
public partial class FormAlarm : Form
{
	// Token: 0x0600000C RID: 12 RVA: 0x000021AF File Offset: 0x000003AF
	public FormAlarm()
	{
		this.InitializeComponent();
	}

	// Token: 0x0600000D RID: 13 RVA: 0x00003E88 File Offset: 0x00002088
	public void method_0(string string_1, int int_1)
	{
		this.int_0 = int_1;
		this.string_0 = string_1;
		this.timer_0.Enabled = true;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Nhân vật " + this.string_0 + " đang có câu hỏi chống auto");
		stringBuilder.AppendLine("Auto sẽ tự động thoát sau " + this.int_0 + "s");
		this.labelAlarmInfo.Text = stringBuilder.ToString();
		this.trackBar1.Value = Class8.int_0;
		base.Opacity = (double)((float)this.trackBar1.Value / 100f);
		base.Show();
	}

	// Token: 0x0600000E RID: 14 RVA: 0x000021C8 File Offset: 0x000003C8
	private void FormAlarm_Load(object sender, EventArgs e)
	{
		base.Location = new Point(Class4.smethod_0() - base.Width, Class4.smethod_1() - base.Height - 30);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00003F34 File Offset: 0x00002134
	private void timer_0_Tick(object sender, EventArgs e)
	{
		this.int_0--;
		if (this.int_0 == 0)
		{
			base.Hide();
			this.timer_0.Stop();
		}
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Nhân vật " + this.string_0 + " đang có câu hỏi chống auto");
		stringBuilder.AppendLine("Auto sẽ tự động thoát sau " + this.int_0 + "s");
		this.labelAlarmInfo.Text = stringBuilder.ToString();
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000021F0 File Offset: 0x000003F0
	private void label1_Click(object sender, EventArgs e)
	{
		base.Hide();
		this.timer_0.Stop();
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002203 File Offset: 0x00000403
	private void trackBar1_Scroll(object sender, EventArgs e)
	{
		base.Opacity = (double)((float)this.trackBar1.Value / 100f);
		Class8.int_0 = (int)(base.Opacity * 100.0);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002234 File Offset: 0x00000434
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	// Token: 0x04000004 RID: 4
	private int int_0;

	// Token: 0x04000005 RID: 5
	private string string_0 = "";
}
