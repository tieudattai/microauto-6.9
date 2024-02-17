using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

public class d : Form
{
	private int m_a;

	private string m_b = "";

	private IContainer m_c;

	private Label m_d;

	private Timer e;

	private Label f;

	private TrackBar g;

	public d()
	{
		a();
	}

	public void a(string A_0, int A_1)
	{
		if (true)
		{
		}
		this.m_a = A_1;
		this.m_b = A_0;
		e.Enabled = true;
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Nhân vật " + this.m_b + " đang có câu hỏi chống auto");
		stringBuilder.AppendLine("Auto sẽ tự động thoát sau " + this.m_a + "s");
		this.m_d.Text = stringBuilder.ToString();
		g.Value = global::b.b;
		base.Opacity = (float)g.Value / 100f;
		Show();
	}

	private void d(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		base.Location = new Point(k.b() - base.Width, k.a() - base.Height - 30);
	}

	private void c(object A_0, EventArgs A_1)
	{
		while (true)
		{
			this.m_a--;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (this.m_a == 0)
					{
						num = 1;
						continue;
					}
					goto case 2;
				case 1:
					Hide();
					e.Stop();
					if (true)
					{
					}
					num = 2;
					continue;
				case 2:
				{
					StringBuilder stringBuilder = new StringBuilder();
					stringBuilder.AppendLine("Nhân vật " + this.m_b + " đang có câu hỏi chống auto");
					stringBuilder.AppendLine("Auto sẽ tự động thoát sau " + this.m_a + "s");
					this.m_d.Text = stringBuilder.ToString();
					return;
				}
				}
				break;
			}
		}
	}

	private void b(object A_0, EventArgs A_1)
	{
		Hide();
		e.Stop();
	}

	private void a(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		base.Opacity = (float)g.Value / 100f;
		global::b.b = (int)(base.Opacity * 100.0);
	}

	protected virtual void a(bool A_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				if (A_0)
				{
					num = 2;
					continue;
				}
				break;
			case 0:
				this.m_c.Dispose();
				num = 1;
				continue;
			case 2:
				if (true)
				{
				}
				num = 4;
				continue;
			case 4:
				if (this.m_c != null)
				{
					num = 0;
					continue;
				}
				break;
			case 1:
				break;
			}
			break;
		}
		Dispose(A_0);
	}

	private void a()
	{
		if (true)
		{
		}
		this.m_c = new Container();
		this.m_d = new Label();
		e = new Timer(this.m_c);
		f = new Label();
		g = new TrackBar();
		((ISupportInitialize)g).BeginInit();
		SuspendLayout();
		this.m_d.AutoSize = true;
		this.m_d.Dock = DockStyle.Fill;
		this.m_d.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.m_d.ForeColor = Color.OrangeRed;
		this.m_d.Location = new Point(0, 0);
		this.m_d.Name = "labelAlarmInfo";
		this.m_d.Size = new Size(350, 40);
		this.m_d.TabIndex = 0;
		this.m_d.Text = "Nhân vật không biết đang có câu hỏi chống auto\r\nMicroAuto sẽ tự động thoát  sau 50s";
		e.Interval = 1000;
		e.Tick += c;
		f.AutoSize = true;
		f.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 163);
		f.Location = new Point(335, 27);
		f.Name = "label1";
		f.Size = new Size(15, 13);
		f.TabIndex = 1;
		f.Text = "X";
		f.Click += b;
		g.AutoSize = false;
		g.Location = new Point(273, 27);
		g.Maximum = 100;
		g.Name = "trackBar1";
		g.Size = new Size(56, 19);
		g.TabIndex = 2;
		g.TickStyle = TickStyle.None;
		g.Value = 100;
		g.Scroll += a;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		base.ClientSize = new Size(357, 43);
		base.ControlBox = false;
		base.Controls.Add(g);
		base.Controls.Add(f);
		base.Controls.Add(this.m_d);
		base.FormBorderStyle = FormBorderStyle.None;
		base.Name = "FormAlarm";
		base.ShowInTaskbar = false;
		base.TopMost = true;
		base.Load += d;
		((ISupportInitialize)g).EndInit();
		ResumeLayout(performLayout: false);
		PerformLayout();
	}
}
