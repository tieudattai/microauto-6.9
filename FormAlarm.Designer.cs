// Token: 0x02000005 RID: 5
public partial class FormAlarm : global::System.Windows.Forms.Form
{
	// Token: 0x06000013 RID: 19 RVA: 0x00003FBC File Offset: 0x000021BC
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		this.labelAlarmInfo = new global::System.Windows.Forms.Label();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.label1 = new global::System.Windows.Forms.Label();
		this.trackBar1 = new global::System.Windows.Forms.TrackBar();
		((global::System.ComponentModel.ISupportInitialize)this.trackBar1).BeginInit();
		base.SuspendLayout();
		this.labelAlarmInfo.AutoSize = true;
		this.labelAlarmInfo.Dock = global::System.Windows.Forms.DockStyle.Fill;
		this.labelAlarmInfo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
		this.labelAlarmInfo.ForeColor = global::System.Drawing.Color.OrangeRed;
		this.labelAlarmInfo.Location = new global::System.Drawing.Point(0, 0);
		this.labelAlarmInfo.Name = "labelAlarmInfo";
		this.labelAlarmInfo.Size = new global::System.Drawing.Size(350, 40);
		this.labelAlarmInfo.TabIndex = 0;
		this.labelAlarmInfo.Text = "Nhân vật không biết đang có câu hỏi chống auto\r\nMicroAuto sẽ tự động thoát  sau 50s";
		this.timer_0.Interval = 1000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		this.label1.AutoSize = true;
		this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
		this.label1.Location = new global::System.Drawing.Point(335, 27);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(15, 13);
		this.label1.TabIndex = 1;
		this.label1.Text = "X";
		this.label1.Click += new global::System.EventHandler(this.label1_Click);
		this.trackBar1.AutoSize = false;
		this.trackBar1.Location = new global::System.Drawing.Point(273, 27);
		this.trackBar1.Maximum = 100;
		this.trackBar1.Name = "trackBar1";
		this.trackBar1.Size = new global::System.Drawing.Size(56, 19);
		this.trackBar1.TabIndex = 2;
		this.trackBar1.TickStyle = global::System.Windows.Forms.TickStyle.None;
		this.trackBar1.Value = 100;
		this.trackBar1.Scroll += new global::System.EventHandler(this.trackBar1_Scroll);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		base.ClientSize = new global::System.Drawing.Size(357, 43);
		base.ControlBox = false;
		base.Controls.Add(this.trackBar1);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.labelAlarmInfo);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
		base.Name = "FormAlarm";
		base.ShowInTaskbar = false;
		base.TopMost = true;
		base.Load += new global::System.EventHandler(this.FormAlarm_Load);
		((global::System.ComponentModel.ISupportInitialize)this.trackBar1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000006 RID: 6
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000007 RID: 7
	private global::System.Windows.Forms.Label labelAlarmInfo;

	// Token: 0x04000008 RID: 8
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x04000009 RID: 9
	private global::System.Windows.Forms.Label label1;

	// Token: 0x0400000A RID: 10
	private global::System.Windows.Forms.TrackBar trackBar1;
}
