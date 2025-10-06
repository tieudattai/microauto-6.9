using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


public partial class FormAlarm : Form
{
	
	public FormAlarm()
	{
		this.InitializeComponent();
	}

	
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

	
	private void FormAlarm_Load(object sender, EventArgs e)
	{
		base.Location = new Point(Class4.smethod_0() - base.Width, Class4.smethod_1() - base.Height - 30);
	}

	
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

	
	private void label1_Click(object sender, EventArgs e)
	{
		base.Hide();
		this.timer_0.Stop();
	}

	
	private void trackBar1_Scroll(object sender, EventArgs e)
	{
		base.Opacity = (double)((float)this.trackBar1.Value / 100f);
		Class8.int_0 = (int)(base.Opacity * 100.0);
	}

	
	protected virtual void Dispose(bool disposing)
	{
		if (disposing && this.icontainer_0 != null)
		{
			this.icontainer_0.Dispose();
		}
		base.Dispose(disposing);
	}

	
	private int int_0;

	
	private string string_0 = "";
}
