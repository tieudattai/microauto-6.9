// Token: 0x0200000C RID: 12
public partial class FormMain : global::System.Windows.Forms.Form
{
	// Token: 0x060000DE RID: 222 RVA: 0x00007C70 File Offset: 0x00005E70
	private void InitializeComponent()
	{
		this.icontainer_0 = new global::System.ComponentModel.Container();
		global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FormMain));
		this.listViewGame = new global::System.Windows.Forms.ListView();
		this.columnHeader_0 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_1 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_3 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_5 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_2 = new global::System.Windows.Forms.ColumnHeader();
		this.columnHeader_4 = new global::System.Windows.Forms.ColumnHeader();
		this.contextMenuStripListView = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_0 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.lToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator4 = new global::System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem_1 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_2 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_4 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator1 = new global::System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem_6 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_12 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.resetAutoToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator5 = new global::System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem_7 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.tabControl1 = new global::System.Windows.Forms.TabControl();
		this.tabPageAcc = new global::System.Windows.Forms.TabPage();
		this.lure = new global::System.Windows.Forms.CheckBox();
		this.radiusValue = new global::System.Windows.Forms.NumericUpDown();
		this.radius = new global::System.Windows.Forms.CheckBox();
		this.label1 = new global::System.Windows.Forms.Label();
		this.onlyAttackFixHPMaxPercent = new global::System.Windows.Forms.NumericUpDown();
		this.onlyAttackFixHPMinPercent = new global::System.Windows.Forms.NumericUpDown();
		this.onlyAttackFixHP = new global::System.Windows.Forms.CheckBox();
		this.exitWhenHPLow = new global::System.Windows.Forms.CheckBox();
		this.exitWhenHPLowPercent = new global::System.Windows.Forms.NumericUpDown();
		this.buffMPEnable = new global::System.Windows.Forms.CheckBox();
		this.buffMPKey = new global::System.Windows.Forms.ComboBox();
		this.buffMPPercent = new global::System.Windows.Forms.NumericUpDown();
		this.buffHPEnable = new global::System.Windows.Forms.CheckBox();
		this.buffHPKey = new global::System.Windows.Forms.ComboBox();
		this.buffHPPercent = new global::System.Windows.Forms.NumericUpDown();
		this.buffPetEnable = new global::System.Windows.Forms.CheckBox();
		this.buffPetKey = new global::System.Windows.Forms.ComboBox();
		this.buffPetPercent = new global::System.Windows.Forms.NumericUpDown();
		this.panelSkill = new global::System.Windows.Forms.Panel();
		this.f6Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f1Enable = new global::System.Windows.Forms.CheckBox();
		this.f12Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f1Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f12Enable = new global::System.Windows.Forms.CheckBox();
		this.f2Enable = new global::System.Windows.Forms.CheckBox();
		this.f11Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f2Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f11Enable = new global::System.Windows.Forms.CheckBox();
		this.f3Enable = new global::System.Windows.Forms.CheckBox();
		this.f10Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f3Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f10Enable = new global::System.Windows.Forms.CheckBox();
		this.f4Enable = new global::System.Windows.Forms.CheckBox();
		this.f9Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f4Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f9Enable = new global::System.Windows.Forms.CheckBox();
		this.f5Enable = new global::System.Windows.Forms.CheckBox();
		this.f8Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f5Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f8Enable = new global::System.Windows.Forms.CheckBox();
		this.f6Enable = new global::System.Windows.Forms.CheckBox();
		this.f7Delay = new global::System.Windows.Forms.NumericUpDown();
		this.f7Enable = new global::System.Windows.Forms.CheckBox();
		this.isSkill = new global::System.Windows.Forms.CheckBox();
		this.tabPageConfig = new global::System.Windows.Forms.TabPage();
		this.label4 = new global::System.Windows.Forms.Label();
		this.label3 = new global::System.Windows.Forms.Label();
		this.targetKey = new global::System.Windows.Forms.ComboBox();
		this.baseSkill = new global::System.Windows.Forms.ComboBox();
		this.label2 = new global::System.Windows.Forms.Label();
		this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
		this.webBrowser1 = new global::System.Windows.Forms.WebBrowser();
		this.groupBox1 = new global::System.Windows.Forms.GroupBox();
		this.testAlarm = new global::System.Windows.Forms.Button();
		this.stopMusic = new global::System.Windows.Forms.Button();
		this.playMusic = new global::System.Windows.Forms.Button();
		this.openMusic = new global::System.Windows.Forms.Button();
		this.musicPath = new global::System.Windows.Forms.TextBox();
		this.shutdownAfterKill = new global::System.Windows.Forms.CheckBox();
		this.topMost = new global::System.Windows.Forms.CheckBox();
		this.panel1 = new global::System.Windows.Forms.Panel();
		this.farmEnable = new global::System.Windows.Forms.CheckBox();
		this.farmBack = new global::System.Windows.Forms.RadioButton();
		this.farmGo = new global::System.Windows.Forms.RadioButton();
		this.button1 = new global::System.Windows.Forms.Button();
		this.tabPageInfo = new global::System.Windows.Forms.TabPage();
		this.charName = new global::System.Windows.Forms.Label();
		this.resetExpCaculator = new global::System.Windows.Forms.Button();
		this.enterExpMax = new global::System.Windows.Forms.Button();
		this.info = new global::System.Windows.Forms.Label();
		this.timer_0 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.imageList_0 = new global::System.Windows.Forms.ImageList(this.icontainer_0);
		this.notifyIcon_0 = new global::System.Windows.Forms.NotifyIcon(this.icontainer_0);
		this.contextMenuStripNotifyIcon = new global::System.Windows.Forms.ContextMenuStrip(this.icontainer_0);
		this.toolStripMenuItem_5 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator2 = new global::System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem_11 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_9 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_10 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripMenuItem_8 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolStripSeparator3 = new global::System.Windows.Forms.ToolStripSeparator();
		this.toolStripMenuItem_3 = new global::System.Windows.Forms.ToolStripMenuItem();
		this.toolTip_0 = new global::System.Windows.Forms.ToolTip(this.icontainer_0);
		this.label5 = new global::System.Windows.Forms.Label();
		this.timer_1 = new global::System.Windows.Forms.Timer(this.icontainer_0);
		this.contextMenuStripListView.SuspendLayout();
		this.tabControl1.SuspendLayout();
		this.tabPageAcc.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.radiusValue).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.onlyAttackFixHPMaxPercent).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.onlyAttackFixHPMinPercent).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.exitWhenHPLowPercent).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.buffMPPercent).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.buffHPPercent).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.buffPetPercent).BeginInit();
		this.panelSkill.SuspendLayout();
		((global::System.ComponentModel.ISupportInitialize)this.f6Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f12Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f1Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f11Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f2Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f10Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f3Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f9Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f4Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f8Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f5Delay).BeginInit();
		((global::System.ComponentModel.ISupportInitialize)this.f7Delay).BeginInit();
		this.tabPageConfig.SuspendLayout();
		this.groupBox1.SuspendLayout();
		this.panel1.SuspendLayout();
		this.tabPageInfo.SuspendLayout();
		this.contextMenuStripNotifyIcon.SuspendLayout();
		base.SuspendLayout();
		this.listViewGame.CheckBoxes = true;
		this.listViewGame.Columns.AddRange(new global::System.Windows.Forms.ColumnHeader[]
		{
			this.columnHeader_0,
			this.columnHeader_1,
			this.columnHeader_3,
			this.columnHeader_5,
			this.columnHeader_2,
			this.columnHeader_4
		});
		this.listViewGame.ContextMenuStrip = this.contextMenuStripListView;
		this.listViewGame.Dock = global::System.Windows.Forms.DockStyle.Top;
		this.listViewGame.FullRowSelect = true;
		this.listViewGame.GridLines = true;
		this.listViewGame.Location = new global::System.Drawing.Point(0, 0);
		this.listViewGame.Name = "listViewGame";
		this.listViewGame.Size = new global::System.Drawing.Size(199, 142);
		this.listViewGame.TabIndex = 1;
		this.listViewGame.UseCompatibleStateImageBehavior = false;
		this.listViewGame.View = global::System.Windows.Forms.View.Details;
		this.listViewGame.ItemChecked += new global::System.Windows.Forms.ItemCheckedEventHandler(this.listViewGame_ItemChecked);
		this.listViewGame.SelectedIndexChanged += new global::System.EventHandler(this.listViewGame_SelectedIndexChanged);
		this.listViewGame.KeyUp += new global::System.Windows.Forms.KeyEventHandler(this.listViewGame_KeyUp);
		this.columnHeader_0.Text = "Nhân Vật";
		this.columnHeader_0.Width = 90;
		this.columnHeader_1.Text = "Máu";
		this.columnHeader_1.Width = 40;
		this.columnHeader_3.Text = "Pet";
		this.columnHeader_3.Width = 40;
		this.columnHeader_5.Text = "Captcha";
		this.columnHeader_2.Text = "Khí";
		this.columnHeader_2.Width = 40;
		this.columnHeader_4.Text = "Bk";
		this.columnHeader_4.Width = 40;
		this.contextMenuStripListView.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.toolStripMenuItem_0,
			this.lToolStripMenuItem,
			this.toolStripSeparator4,
			this.toolStripMenuItem_1,
			this.toolStripMenuItem_2,
			this.toolStripMenuItem_4,
			this.toolStripSeparator1,
			this.toolStripMenuItem_6,
			this.toolStripMenuItem_12,
			this.resetAutoToolStripMenuItem,
			this.toolStripSeparator5,
			this.toolStripMenuItem_7
		});
		this.contextMenuStripListView.Name = "contextMenuStripListView";
		this.contextMenuStripListView.Size = new global::System.Drawing.Size(233, 220);
		this.contextMenuStripListView.Opening += new global::System.ComponentModel.CancelEventHandler(this.contextMenuStripListView_Opening);
		this.toolStripMenuItem_0.Name = "lưuThiếtLậpToolStripMenuItem";
		this.toolStripMenuItem_0.Size = new global::System.Drawing.Size(232, 22);
		this.toolStripMenuItem_0.Text = "Lưu Thiết Lập";
		this.toolStripMenuItem_0.Click += new global::System.EventHandler(this.toolStripMenuItem_0_Click);
		this.lToolStripMenuItem.Name = "lToolStripMenuItem";
		this.lToolStripMenuItem.ShortcutKeys = (global::System.Windows.Forms.Keys)131155;
		this.lToolStripMenuItem.Size = new global::System.Drawing.Size(232, 22);
		this.lToolStripMenuItem.Text = "Lưu toàn bộ thiết lập";
		this.lToolStripMenuItem.Click += new global::System.EventHandler(this.lToolStripMenuItem_Click);
		this.toolStripSeparator4.Name = "toolStripSeparator4";
		this.toolStripSeparator4.Size = new global::System.Drawing.Size(229, 6);
		this.toolStripMenuItem_1.Name = "ẩnGameToolStripMenuItem";
		this.toolStripMenuItem_1.Size = new global::System.Drawing.Size(232, 22);
		this.toolStripMenuItem_1.Text = "Ẩn game (Page Down)";
		this.toolStripMenuItem_1.Click += new global::System.EventHandler(this.toolStripMenuItem_1_Click);
		this.toolStripMenuItem_2.Name = "hiệnGameToolStripMenuItem";
		this.toolStripMenuItem_2.Size = new global::System.Drawing.Size(232, 22);
		this.toolStripMenuItem_2.Text = "Hiện game (Page Down)";
		this.toolStripMenuItem_2.Click += new global::System.EventHandler(this.toolStripMenuItem_2_Click);
		this.toolStripMenuItem_4.Name = "thoátGameToolStripMenuItem";
		this.toolStripMenuItem_4.Size = new global::System.Drawing.Size(232, 22);
		this.toolStripMenuItem_4.Text = "Thoát game";
		this.toolStripMenuItem_4.Click += new global::System.EventHandler(this.toolStripMenuItem_4_Click);
		this.toolStripSeparator1.Name = "toolStripSeparator1";
		this.toolStripSeparator1.Size = new global::System.Drawing.Size(229, 6);
		this.toolStripMenuItem_6.Name = "bắtĐầuTạmDừngAutoToolStripMenuItem";
		this.toolStripMenuItem_6.Size = new global::System.Drawing.Size(232, 22);
		this.toolStripMenuItem_6.Text = "Bắt đầu / tạm dừng auto (Pause)";
		this.toolStripMenuItem_6.Click += new global::System.EventHandler(this.toolStripMenuItem_6_Click);
		this.toolStripMenuItem_12.Name = "ẩnAutoToolStripMenuItem";
		this.toolStripMenuItem_12.Size = new global::System.Drawing.Size(232, 22);
		this.toolStripMenuItem_12.Text = "Ẩn auto (Page Up)";
		this.toolStripMenuItem_12.Click += new global::System.EventHandler(this.toolStripMenuItem_12_Click);
		this.resetAutoToolStripMenuItem.Name = "resetAutoToolStripMenuItem";
		this.resetAutoToolStripMenuItem.Size = new global::System.Drawing.Size(232, 22);
		this.resetAutoToolStripMenuItem.Text = "Reset auto";
		this.resetAutoToolStripMenuItem.Click += new global::System.EventHandler(this.resetAutoToolStripMenuItem_Click);
		this.toolStripSeparator5.Name = "toolStripSeparator5";
		this.toolStripSeparator5.Size = new global::System.Drawing.Size(229, 6);
		this.toolStripMenuItem_7.Name = "tọaĐộTrainTạiĐâyToolStripMenuItem";
		this.toolStripMenuItem_7.Size = new global::System.Drawing.Size(232, 22);
		this.toolStripMenuItem_7.Text = "Tọa độ train tại đây";
		this.toolStripMenuItem_7.Click += new global::System.EventHandler(this.toolStripMenuItem_7_Click);
		this.tabControl1.Controls.Add(this.tabPageAcc);
		this.tabControl1.Controls.Add(this.tabPageConfig);
		this.tabControl1.Controls.Add(this.tabPageInfo);
		this.tabControl1.Location = new global::System.Drawing.Point(0, 141);
		this.tabControl1.Name = "tabControl1";
		this.tabControl1.SelectedIndex = 0;
		this.tabControl1.Size = new global::System.Drawing.Size(199, 342);
		this.tabControl1.TabIndex = 2;
		this.tabPageAcc.Controls.Add(this.lure);
		this.tabPageAcc.Controls.Add(this.radiusValue);
		this.tabPageAcc.Controls.Add(this.radius);
		this.tabPageAcc.Controls.Add(this.label1);
		this.tabPageAcc.Controls.Add(this.onlyAttackFixHPMaxPercent);
		this.tabPageAcc.Controls.Add(this.onlyAttackFixHPMinPercent);
		this.tabPageAcc.Controls.Add(this.onlyAttackFixHP);
		this.tabPageAcc.Controls.Add(this.exitWhenHPLow);
		this.tabPageAcc.Controls.Add(this.exitWhenHPLowPercent);
		this.tabPageAcc.Controls.Add(this.buffMPEnable);
		this.tabPageAcc.Controls.Add(this.buffMPKey);
		this.tabPageAcc.Controls.Add(this.buffMPPercent);
		this.tabPageAcc.Controls.Add(this.buffHPEnable);
		this.tabPageAcc.Controls.Add(this.buffHPKey);
		this.tabPageAcc.Controls.Add(this.buffHPPercent);
		this.tabPageAcc.Controls.Add(this.buffPetEnable);
		this.tabPageAcc.Controls.Add(this.buffPetKey);
		this.tabPageAcc.Controls.Add(this.buffPetPercent);
		this.tabPageAcc.Controls.Add(this.panelSkill);
		this.tabPageAcc.Controls.Add(this.isSkill);
		this.tabPageAcc.Location = new global::System.Drawing.Point(4, 22);
		this.tabPageAcc.Name = "tabPageAcc";
		this.tabPageAcc.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabPageAcc.Size = new global::System.Drawing.Size(191, 316);
		this.tabPageAcc.TabIndex = 0;
		this.tabPageAcc.Text = "Nhân Vật";
		this.tabPageAcc.UseVisualStyleBackColor = true;
		this.lure.AutoSize = true;
		this.lure.Location = new global::System.Drawing.Point(107, 6);
		this.lure.Name = "lure";
		this.lure.Size = new global::System.Drawing.Size(67, 17);
		this.lure.TabIndex = 48;
		this.lure.Text = "Lùa quái";
		this.lure.UseVisualStyleBackColor = true;
		this.lure.CheckedChanged += new global::System.EventHandler(this.lure_CheckedChanged);
		this.radiusValue.Enabled = false;
		this.radiusValue.Location = new global::System.Drawing.Point(8, 292);
		global::System.Windows.Forms.NumericUpDown numericUpDown = this.radiusValue;
		int[] array = new int[4];
		array[0] = 10000;
		numericUpDown.Maximum = new decimal(array);
		this.radiusValue.Name = "radiusValue";
		this.radiusValue.Size = new global::System.Drawing.Size(38, 20);
		this.radiusValue.TabIndex = 43;
		global::System.Windows.Forms.NumericUpDown numericUpDown2 = this.radiusValue;
		int[] array2 = new int[4];
		array2[0] = 20;
		numericUpDown2.Value = new decimal(array2);
		this.radiusValue.ValueChanged += new global::System.EventHandler(this.radiusValue_ValueChanged);
		this.radius.AutoSize = true;
		this.radius.Location = new global::System.Drawing.Point(52, 293);
		this.radius.Name = "radius";
		this.radius.Size = new global::System.Drawing.Size(70, 17);
		this.radius.TabIndex = 42;
		this.radius.Text = "Bán kính";
		this.radius.UseVisualStyleBackColor = true;
		this.radius.CheckedChanged += new global::System.EventHandler(this.radius_CheckedChanged);
		this.label1.AutoSize = true;
		this.label1.Location = new global::System.Drawing.Point(126, 174);
		this.label1.Name = "label1";
		this.label1.Size = new global::System.Drawing.Size(16, 13);
		this.label1.TabIndex = 41;
		this.label1.Text = "->";
		this.onlyAttackFixHPMaxPercent.Enabled = false;
		this.onlyAttackFixHPMaxPercent.Location = new global::System.Drawing.Point(148, 172);
		global::System.Windows.Forms.NumericUpDown numericUpDown3 = this.onlyAttackFixHPMaxPercent;
		int[] array3 = new int[4];
		array3[0] = 1000;
		numericUpDown3.Maximum = new decimal(array3);
		this.onlyAttackFixHPMaxPercent.Name = "onlyAttackFixHPMaxPercent";
		this.onlyAttackFixHPMaxPercent.Size = new global::System.Drawing.Size(40, 20);
		this.onlyAttackFixHPMaxPercent.TabIndex = 40;
		global::System.Windows.Forms.NumericUpDown numericUpDown4 = this.onlyAttackFixHPMaxPercent;
		int[] array4 = new int[4];
		array4[0] = 50;
		numericUpDown4.Value = new decimal(array4);
		this.onlyAttackFixHPMaxPercent.ValueChanged += new global::System.EventHandler(this.onlyAttackFixHPMaxPercent_ValueChanged);
		this.onlyAttackFixHPMinPercent.Enabled = false;
		this.onlyAttackFixHPMinPercent.Location = new global::System.Drawing.Point(89, 172);
		this.onlyAttackFixHPMinPercent.Name = "onlyAttackFixHPMinPercent";
		this.onlyAttackFixHPMinPercent.Size = new global::System.Drawing.Size(32, 20);
		this.onlyAttackFixHPMinPercent.TabIndex = 39;
		global::System.Windows.Forms.NumericUpDown numericUpDown5 = this.onlyAttackFixHPMinPercent;
		int[] array5 = new int[4];
		array5[0] = 50;
		numericUpDown5.Value = new decimal(array5);
		this.onlyAttackFixHPMinPercent.ValueChanged += new global::System.EventHandler(this.onlyAttackFixHPMinPercent_ValueChanged);
		this.onlyAttackFixHP.AutoSize = true;
		this.onlyAttackFixHP.Location = new global::System.Drawing.Point(8, 175);
		this.onlyAttackFixHP.Name = "onlyAttackFixHP";
		this.onlyAttackFixHP.Size = new global::System.Drawing.Size(75, 17);
		this.onlyAttackFixHP.TabIndex = 38;
		this.onlyAttackFixHP.Text = "Đánh quái";
		this.toolTip_0.SetToolTip(this.onlyAttackFixHP, "Chỉ đánh quái có máu trong khoảng");
		this.onlyAttackFixHP.UseVisualStyleBackColor = true;
		this.onlyAttackFixHP.CheckedChanged += new global::System.EventHandler(this.onlyAttackFixHP_CheckedChanged);
		this.exitWhenHPLow.AutoSize = true;
		this.exitWhenHPLow.Location = new global::System.Drawing.Point(8, 273);
		this.exitWhenHPLow.Name = "exitWhenHPLow";
		this.exitWhenHPLow.Size = new global::System.Drawing.Size(117, 17);
		this.exitWhenHPLow.TabIndex = 37;
		this.exitWhenHPLow.Text = "Thoát khi máu dưới";
		this.exitWhenHPLow.UseVisualStyleBackColor = true;
		this.exitWhenHPLow.CheckedChanged += new global::System.EventHandler(this.exitWhenHPLow_CheckedChanged);
		this.exitWhenHPLowPercent.Enabled = false;
		this.exitWhenHPLowPercent.Location = new global::System.Drawing.Point(131, 270);
		global::System.Windows.Forms.NumericUpDown numericUpDown6 = this.exitWhenHPLowPercent;
		int[] array6 = new int[4];
		array6[0] = 1;
		numericUpDown6.Minimum = new decimal(array6);
		this.exitWhenHPLowPercent.Name = "exitWhenHPLowPercent";
		this.exitWhenHPLowPercent.Size = new global::System.Drawing.Size(44, 20);
		this.exitWhenHPLowPercent.TabIndex = 36;
		global::System.Windows.Forms.NumericUpDown numericUpDown7 = this.exitWhenHPLowPercent;
		int[] array7 = new int[4];
		array7[0] = 50;
		numericUpDown7.Value = new decimal(array7);
		this.exitWhenHPLowPercent.ValueChanged += new global::System.EventHandler(this.exitWhenHPLowPercent_ValueChanged);
		this.buffMPEnable.AutoSize = true;
		this.buffMPEnable.Location = new global::System.Drawing.Point(8, 250);
		this.buffMPEnable.Name = "buffMPEnable";
		this.buffMPEnable.Size = new global::System.Drawing.Size(43, 17);
		this.buffMPEnable.TabIndex = 35;
		this.buffMPEnable.Text = "Khí";
		this.buffMPEnable.UseVisualStyleBackColor = true;
		this.buffMPEnable.CheckedChanged += new global::System.EventHandler(this.buffMPEnable_CheckedChanged);
		this.buffMPKey.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.buffMPKey.Enabled = false;
		this.buffMPKey.FormattingEnabled = true;
		this.buffMPKey.Items.AddRange(new object[]
		{
			"F1",
			"F2",
			"F3",
			"F4",
			"F5",
			"F6",
			"F7",
			"F8",
			"F9",
			"F10",
			"F11",
			"F12"
		});
		this.buffMPKey.Location = new global::System.Drawing.Point(106, 246);
		this.buffMPKey.Name = "buffMPKey";
		this.buffMPKey.Size = new global::System.Drawing.Size(50, 21);
		this.buffMPKey.TabIndex = 34;
		this.buffMPKey.SelectedIndexChanged += new global::System.EventHandler(this.buffMPKey_SelectedIndexChanged);
		this.buffMPPercent.Enabled = false;
		this.buffMPPercent.Location = new global::System.Drawing.Point(56, 247);
		global::System.Windows.Forms.NumericUpDown numericUpDown8 = this.buffMPPercent;
		int[] array8 = new int[4];
		array8[0] = 1;
		numericUpDown8.Minimum = new decimal(array8);
		this.buffMPPercent.Name = "buffMPPercent";
		this.buffMPPercent.Size = new global::System.Drawing.Size(44, 20);
		this.buffMPPercent.TabIndex = 33;
		global::System.Windows.Forms.NumericUpDown numericUpDown9 = this.buffMPPercent;
		int[] array9 = new int[4];
		array9[0] = 50;
		numericUpDown9.Value = new decimal(array9);
		this.buffMPPercent.ValueChanged += new global::System.EventHandler(this.buffMPPercent_ValueChanged);
		this.buffHPEnable.AutoSize = true;
		this.buffHPEnable.Location = new global::System.Drawing.Point(8, 224);
		this.buffHPEnable.Name = "buffHPEnable";
		this.buffHPEnable.Size = new global::System.Drawing.Size(47, 17);
		this.buffHPEnable.TabIndex = 32;
		this.buffHPEnable.Text = "Máu";
		this.buffHPEnable.UseVisualStyleBackColor = true;
		this.buffHPEnable.CheckedChanged += new global::System.EventHandler(this.buffHPEnable_CheckedChanged);
		this.buffHPKey.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.buffHPKey.Enabled = false;
		this.buffHPKey.FormattingEnabled = true;
		this.buffHPKey.Items.AddRange(new object[]
		{
			"F1",
			"F2",
			"F3",
			"F4",
			"F5",
			"F6",
			"F7",
			"F8",
			"F9",
			"F10",
			"F11",
			"F12"
		});
		this.buffHPKey.Location = new global::System.Drawing.Point(106, 220);
		this.buffHPKey.Name = "buffHPKey";
		this.buffHPKey.Size = new global::System.Drawing.Size(50, 21);
		this.buffHPKey.TabIndex = 31;
		this.buffHPKey.SelectedIndexChanged += new global::System.EventHandler(this.buffHPKey_SelectedIndexChanged);
		this.buffHPPercent.Enabled = false;
		this.buffHPPercent.Location = new global::System.Drawing.Point(56, 221);
		global::System.Windows.Forms.NumericUpDown numericUpDown10 = this.buffHPPercent;
		int[] array10 = new int[4];
		array10[0] = 1;
		numericUpDown10.Minimum = new decimal(array10);
		this.buffHPPercent.Name = "buffHPPercent";
		this.buffHPPercent.Size = new global::System.Drawing.Size(44, 20);
		this.buffHPPercent.TabIndex = 30;
		global::System.Windows.Forms.NumericUpDown numericUpDown11 = this.buffHPPercent;
		int[] array11 = new int[4];
		array11[0] = 50;
		numericUpDown11.Value = new decimal(array11);
		this.buffHPPercent.ValueChanged += new global::System.EventHandler(this.buffHPPercent_ValueChanged);
		this.buffPetEnable.AutoSize = true;
		this.buffPetEnable.Location = new global::System.Drawing.Point(8, 198);
		this.buffPetEnable.Name = "buffPetEnable";
		this.buffPetEnable.Size = new global::System.Drawing.Size(42, 17);
		this.buffPetEnable.TabIndex = 29;
		this.buffPetEnable.Text = "Pet";
		this.buffPetEnable.UseVisualStyleBackColor = true;
		this.buffPetEnable.CheckedChanged += new global::System.EventHandler(this.buffPetEnable_CheckedChanged);
		this.buffPetKey.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.buffPetKey.Enabled = false;
		this.buffPetKey.FormattingEnabled = true;
		this.buffPetKey.Items.AddRange(new object[]
		{
			"F1",
			"F2",
			"F3",
			"F4",
			"F5",
			"F6",
			"F7",
			"F8",
			"F9",
			"F10",
			"F11",
			"F12"
		});
		this.buffPetKey.Location = new global::System.Drawing.Point(106, 194);
		this.buffPetKey.Name = "buffPetKey";
		this.buffPetKey.Size = new global::System.Drawing.Size(50, 21);
		this.buffPetKey.TabIndex = 28;
		this.buffPetKey.SelectedIndexChanged += new global::System.EventHandler(this.buffPetKey_SelectedIndexChanged);
		this.buffPetPercent.Enabled = false;
		this.buffPetPercent.Location = new global::System.Drawing.Point(56, 195);
		global::System.Windows.Forms.NumericUpDown numericUpDown12 = this.buffPetPercent;
		int[] array12 = new int[4];
		array12[0] = 1;
		numericUpDown12.Minimum = new decimal(array12);
		this.buffPetPercent.Name = "buffPetPercent";
		this.buffPetPercent.Size = new global::System.Drawing.Size(44, 20);
		this.buffPetPercent.TabIndex = 25;
		global::System.Windows.Forms.NumericUpDown numericUpDown13 = this.buffPetPercent;
		int[] array13 = new int[4];
		array13[0] = 50;
		numericUpDown13.Value = new decimal(array13);
		this.buffPetPercent.ValueChanged += new global::System.EventHandler(this.buffPetPercent_ValueChanged);
		this.panelSkill.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
		this.panelSkill.Controls.Add(this.f6Delay);
		this.panelSkill.Controls.Add(this.f1Enable);
		this.panelSkill.Controls.Add(this.f12Delay);
		this.panelSkill.Controls.Add(this.f1Delay);
		this.panelSkill.Controls.Add(this.f12Enable);
		this.panelSkill.Controls.Add(this.f2Enable);
		this.panelSkill.Controls.Add(this.f11Delay);
		this.panelSkill.Controls.Add(this.f2Delay);
		this.panelSkill.Controls.Add(this.f11Enable);
		this.panelSkill.Controls.Add(this.f3Enable);
		this.panelSkill.Controls.Add(this.f10Delay);
		this.panelSkill.Controls.Add(this.f3Delay);
		this.panelSkill.Controls.Add(this.f10Enable);
		this.panelSkill.Controls.Add(this.f4Enable);
		this.panelSkill.Controls.Add(this.f9Delay);
		this.panelSkill.Controls.Add(this.f4Delay);
		this.panelSkill.Controls.Add(this.f9Enable);
		this.panelSkill.Controls.Add(this.f5Enable);
		this.panelSkill.Controls.Add(this.f8Delay);
		this.panelSkill.Controls.Add(this.f5Delay);
		this.panelSkill.Controls.Add(this.f8Enable);
		this.panelSkill.Controls.Add(this.f6Enable);
		this.panelSkill.Controls.Add(this.f7Delay);
		this.panelSkill.Controls.Add(this.f7Enable);
		this.panelSkill.Enabled = false;
		this.panelSkill.Location = new global::System.Drawing.Point(-4, 29);
		this.panelSkill.Name = "panelSkill";
		this.panelSkill.Size = new global::System.Drawing.Size(198, 137);
		this.panelSkill.TabIndex = 26;
		this.f6Delay.Location = new global::System.Drawing.Point(56, 117);
		global::System.Windows.Forms.NumericUpDown numericUpDown14 = this.f6Delay;
		int[] array14 = new int[4];
		array14[0] = 100000;
		numericUpDown14.Maximum = new decimal(array14);
		global::System.Windows.Forms.NumericUpDown numericUpDown15 = this.f6Delay;
		int[] array15 = new int[4];
		array15[0] = 1;
		numericUpDown15.Minimum = new decimal(array15);
		this.f6Delay.Name = "f6Delay";
		this.f6Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f6Delay.TabIndex = 12;
		global::System.Windows.Forms.NumericUpDown numericUpDown16 = this.f6Delay;
		int[] array16 = new int[4];
		array16[0] = 10;
		numericUpDown16.Value = new decimal(array16);
		this.f6Delay.ValueChanged += new global::System.EventHandler(this.f6Delay_ValueChanged);
		this.f1Enable.AutoSize = true;
		this.f1Enable.Location = new global::System.Drawing.Point(12, 3);
		this.f1Enable.Name = "f1Enable";
		this.f1Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f1Enable.TabIndex = 1;
		this.f1Enable.Text = "F1";
		this.f1Enable.UseVisualStyleBackColor = true;
		this.f1Enable.CheckedChanged += new global::System.EventHandler(this.f1Enable_CheckedChanged);
		this.f12Delay.Location = new global::System.Drawing.Point(146, 117);
		global::System.Windows.Forms.NumericUpDown numericUpDown17 = this.f12Delay;
		int[] array17 = new int[4];
		array17[0] = 100000;
		numericUpDown17.Maximum = new decimal(array17);
		global::System.Windows.Forms.NumericUpDown numericUpDown18 = this.f12Delay;
		int[] array18 = new int[4];
		array18[0] = 1;
		numericUpDown18.Minimum = new decimal(array18);
		this.f12Delay.Name = "f12Delay";
		this.f12Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f12Delay.TabIndex = 24;
		global::System.Windows.Forms.NumericUpDown numericUpDown19 = this.f12Delay;
		int[] array19 = new int[4];
		array19[0] = 10;
		numericUpDown19.Value = new decimal(array19);
		this.f12Delay.ValueChanged += new global::System.EventHandler(this.f12Delay_ValueChanged);
		this.f1Delay.Location = new global::System.Drawing.Point(56, 2);
		global::System.Windows.Forms.NumericUpDown numericUpDown20 = this.f1Delay;
		int[] array20 = new int[4];
		array20[0] = 100000;
		numericUpDown20.Maximum = new decimal(array20);
		global::System.Windows.Forms.NumericUpDown numericUpDown21 = this.f1Delay;
		int[] array21 = new int[4];
		array21[0] = 1;
		numericUpDown21.Minimum = new decimal(array21);
		this.f1Delay.Name = "f1Delay";
		this.f1Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f1Delay.TabIndex = 2;
		global::System.Windows.Forms.NumericUpDown numericUpDown22 = this.f1Delay;
		int[] array22 = new int[4];
		array22[0] = 10;
		numericUpDown22.Value = new decimal(array22);
		this.f1Delay.ValueChanged += new global::System.EventHandler(this.f1Delay_ValueChanged);
		this.f12Enable.AutoSize = true;
		this.f12Enable.Location = new global::System.Drawing.Point(102, 118);
		this.f12Enable.Name = "f12Enable";
		this.f12Enable.Size = new global::System.Drawing.Size(44, 17);
		this.f12Enable.TabIndex = 23;
		this.f12Enable.Text = "F12";
		this.f12Enable.UseVisualStyleBackColor = true;
		this.f12Enable.CheckedChanged += new global::System.EventHandler(this.f12Enable_CheckedChanged);
		this.f2Enable.AutoSize = true;
		this.f2Enable.Location = new global::System.Drawing.Point(12, 26);
		this.f2Enable.Name = "f2Enable";
		this.f2Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f2Enable.TabIndex = 3;
		this.f2Enable.Text = "F2";
		this.f2Enable.UseVisualStyleBackColor = true;
		this.f2Enable.CheckedChanged += new global::System.EventHandler(this.f2Enable_CheckedChanged);
		this.f11Delay.Location = new global::System.Drawing.Point(146, 94);
		global::System.Windows.Forms.NumericUpDown numericUpDown23 = this.f11Delay;
		int[] array23 = new int[4];
		array23[0] = 100000;
		numericUpDown23.Maximum = new decimal(array23);
		global::System.Windows.Forms.NumericUpDown numericUpDown24 = this.f11Delay;
		int[] array24 = new int[4];
		array24[0] = 1;
		numericUpDown24.Minimum = new decimal(array24);
		this.f11Delay.Name = "f11Delay";
		this.f11Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f11Delay.TabIndex = 22;
		global::System.Windows.Forms.NumericUpDown numericUpDown25 = this.f11Delay;
		int[] array25 = new int[4];
		array25[0] = 10;
		numericUpDown25.Value = new decimal(array25);
		this.f11Delay.ValueChanged += new global::System.EventHandler(this.f11Delay_ValueChanged);
		this.f2Delay.Location = new global::System.Drawing.Point(56, 25);
		global::System.Windows.Forms.NumericUpDown numericUpDown26 = this.f2Delay;
		int[] array26 = new int[4];
		array26[0] = 100000;
		numericUpDown26.Maximum = new decimal(array26);
		global::System.Windows.Forms.NumericUpDown numericUpDown27 = this.f2Delay;
		int[] array27 = new int[4];
		array27[0] = 1;
		numericUpDown27.Minimum = new decimal(array27);
		this.f2Delay.Name = "f2Delay";
		this.f2Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f2Delay.TabIndex = 4;
		global::System.Windows.Forms.NumericUpDown numericUpDown28 = this.f2Delay;
		int[] array28 = new int[4];
		array28[0] = 10;
		numericUpDown28.Value = new decimal(array28);
		this.f2Delay.ValueChanged += new global::System.EventHandler(this.f2Delay_ValueChanged);
		this.f11Enable.AutoSize = true;
		this.f11Enable.Location = new global::System.Drawing.Point(102, 95);
		this.f11Enable.Name = "f11Enable";
		this.f11Enable.Size = new global::System.Drawing.Size(44, 17);
		this.f11Enable.TabIndex = 21;
		this.f11Enable.Text = "F11";
		this.f11Enable.UseVisualStyleBackColor = true;
		this.f11Enable.CheckedChanged += new global::System.EventHandler(this.f11Enable_CheckedChanged);
		this.f3Enable.AutoSize = true;
		this.f3Enable.Location = new global::System.Drawing.Point(12, 49);
		this.f3Enable.Name = "f3Enable";
		this.f3Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f3Enable.TabIndex = 5;
		this.f3Enable.Text = "F3";
		this.f3Enable.UseVisualStyleBackColor = true;
		this.f3Enable.CheckedChanged += new global::System.EventHandler(this.f3Enable_CheckedChanged);
		this.f10Delay.Location = new global::System.Drawing.Point(146, 71);
		global::System.Windows.Forms.NumericUpDown numericUpDown29 = this.f10Delay;
		int[] array29 = new int[4];
		array29[0] = 100000;
		numericUpDown29.Maximum = new decimal(array29);
		global::System.Windows.Forms.NumericUpDown numericUpDown30 = this.f10Delay;
		int[] array30 = new int[4];
		array30[0] = 1;
		numericUpDown30.Minimum = new decimal(array30);
		this.f10Delay.Name = "f10Delay";
		this.f10Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f10Delay.TabIndex = 20;
		global::System.Windows.Forms.NumericUpDown numericUpDown31 = this.f10Delay;
		int[] array31 = new int[4];
		array31[0] = 10;
		numericUpDown31.Value = new decimal(array31);
		this.f10Delay.ValueChanged += new global::System.EventHandler(this.f10Delay_ValueChanged);
		this.f3Delay.Location = new global::System.Drawing.Point(56, 48);
		global::System.Windows.Forms.NumericUpDown numericUpDown32 = this.f3Delay;
		int[] array32 = new int[4];
		array32[0] = 100000;
		numericUpDown32.Maximum = new decimal(array32);
		global::System.Windows.Forms.NumericUpDown numericUpDown33 = this.f3Delay;
		int[] array33 = new int[4];
		array33[0] = 1;
		numericUpDown33.Minimum = new decimal(array33);
		this.f3Delay.Name = "f3Delay";
		this.f3Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f3Delay.TabIndex = 6;
		global::System.Windows.Forms.NumericUpDown numericUpDown34 = this.f3Delay;
		int[] array34 = new int[4];
		array34[0] = 10;
		numericUpDown34.Value = new decimal(array34);
		this.f3Delay.ValueChanged += new global::System.EventHandler(this.f3Delay_ValueChanged);
		this.f10Enable.AutoSize = true;
		this.f10Enable.Location = new global::System.Drawing.Point(102, 72);
		this.f10Enable.Name = "f10Enable";
		this.f10Enable.Size = new global::System.Drawing.Size(44, 17);
		this.f10Enable.TabIndex = 19;
		this.f10Enable.Text = "F10";
		this.f10Enable.UseVisualStyleBackColor = true;
		this.f10Enable.CheckedChanged += new global::System.EventHandler(this.f10Enable_CheckedChanged);
		this.f4Enable.AutoSize = true;
		this.f4Enable.Location = new global::System.Drawing.Point(12, 72);
		this.f4Enable.Name = "f4Enable";
		this.f4Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f4Enable.TabIndex = 7;
		this.f4Enable.Text = "F4";
		this.f4Enable.UseVisualStyleBackColor = true;
		this.f4Enable.CheckedChanged += new global::System.EventHandler(this.f4Enable_CheckedChanged);
		this.f9Delay.Location = new global::System.Drawing.Point(146, 48);
		global::System.Windows.Forms.NumericUpDown numericUpDown35 = this.f9Delay;
		int[] array35 = new int[4];
		array35[0] = 100000;
		numericUpDown35.Maximum = new decimal(array35);
		global::System.Windows.Forms.NumericUpDown numericUpDown36 = this.f9Delay;
		int[] array36 = new int[4];
		array36[0] = 1;
		numericUpDown36.Minimum = new decimal(array36);
		this.f9Delay.Name = "f9Delay";
		this.f9Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f9Delay.TabIndex = 18;
		global::System.Windows.Forms.NumericUpDown numericUpDown37 = this.f9Delay;
		int[] array37 = new int[4];
		array37[0] = 10;
		numericUpDown37.Value = new decimal(array37);
		this.f9Delay.ValueChanged += new global::System.EventHandler(this.f9Delay_ValueChanged);
		this.f4Delay.Location = new global::System.Drawing.Point(56, 71);
		global::System.Windows.Forms.NumericUpDown numericUpDown38 = this.f4Delay;
		int[] array38 = new int[4];
		array38[0] = 100000;
		numericUpDown38.Maximum = new decimal(array38);
		global::System.Windows.Forms.NumericUpDown numericUpDown39 = this.f4Delay;
		int[] array39 = new int[4];
		array39[0] = 1;
		numericUpDown39.Minimum = new decimal(array39);
		this.f4Delay.Name = "f4Delay";
		this.f4Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f4Delay.TabIndex = 8;
		global::System.Windows.Forms.NumericUpDown numericUpDown40 = this.f4Delay;
		int[] array40 = new int[4];
		array40[0] = 10;
		numericUpDown40.Value = new decimal(array40);
		this.f4Delay.ValueChanged += new global::System.EventHandler(this.f4Delay_ValueChanged);
		this.f9Enable.AutoSize = true;
		this.f9Enable.Location = new global::System.Drawing.Point(102, 49);
		this.f9Enable.Name = "f9Enable";
		this.f9Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f9Enable.TabIndex = 17;
		this.f9Enable.Text = "F9";
		this.f9Enable.UseVisualStyleBackColor = true;
		this.f9Enable.CheckedChanged += new global::System.EventHandler(this.f9Enable_CheckedChanged);
		this.f5Enable.AutoSize = true;
		this.f5Enable.Location = new global::System.Drawing.Point(12, 95);
		this.f5Enable.Name = "f5Enable";
		this.f5Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f5Enable.TabIndex = 9;
		this.f5Enable.Text = "F5";
		this.f5Enable.UseVisualStyleBackColor = true;
		this.f5Enable.CheckedChanged += new global::System.EventHandler(this.f5Enable_CheckedChanged);
		this.f8Delay.Location = new global::System.Drawing.Point(146, 25);
		global::System.Windows.Forms.NumericUpDown numericUpDown41 = this.f8Delay;
		int[] array41 = new int[4];
		array41[0] = 100000;
		numericUpDown41.Maximum = new decimal(array41);
		global::System.Windows.Forms.NumericUpDown numericUpDown42 = this.f8Delay;
		int[] array42 = new int[4];
		array42[0] = 1;
		numericUpDown42.Minimum = new decimal(array42);
		this.f8Delay.Name = "f8Delay";
		this.f8Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f8Delay.TabIndex = 16;
		global::System.Windows.Forms.NumericUpDown numericUpDown43 = this.f8Delay;
		int[] array43 = new int[4];
		array43[0] = 10;
		numericUpDown43.Value = new decimal(array43);
		this.f8Delay.ValueChanged += new global::System.EventHandler(this.f8Delay_ValueChanged);
		this.f5Delay.Location = new global::System.Drawing.Point(56, 94);
		global::System.Windows.Forms.NumericUpDown numericUpDown44 = this.f5Delay;
		int[] array44 = new int[4];
		array44[0] = 100000;
		numericUpDown44.Maximum = new decimal(array44);
		global::System.Windows.Forms.NumericUpDown numericUpDown45 = this.f5Delay;
		int[] array45 = new int[4];
		array45[0] = 1;
		numericUpDown45.Minimum = new decimal(array45);
		this.f5Delay.Name = "f5Delay";
		this.f5Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f5Delay.TabIndex = 10;
		global::System.Windows.Forms.NumericUpDown numericUpDown46 = this.f5Delay;
		int[] array46 = new int[4];
		array46[0] = 10;
		numericUpDown46.Value = new decimal(array46);
		this.f5Delay.ValueChanged += new global::System.EventHandler(this.f5Delay_ValueChanged);
		this.f8Enable.AutoSize = true;
		this.f8Enable.Location = new global::System.Drawing.Point(102, 26);
		this.f8Enable.Name = "f8Enable";
		this.f8Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f8Enable.TabIndex = 15;
		this.f8Enable.Text = "F8";
		this.f8Enable.UseVisualStyleBackColor = true;
		this.f8Enable.CheckedChanged += new global::System.EventHandler(this.f8Enable_CheckedChanged);
		this.f6Enable.AutoSize = true;
		this.f6Enable.Location = new global::System.Drawing.Point(12, 118);
		this.f6Enable.Name = "f6Enable";
		this.f6Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f6Enable.TabIndex = 11;
		this.f6Enable.Text = "F6";
		this.f6Enable.UseVisualStyleBackColor = true;
		this.f6Enable.CheckedChanged += new global::System.EventHandler(this.f6Enable_CheckedChanged);
		this.f7Delay.Location = new global::System.Drawing.Point(146, 0);
		global::System.Windows.Forms.NumericUpDown numericUpDown47 = this.f7Delay;
		int[] array47 = new int[4];
		array47[0] = 100000;
		numericUpDown47.Maximum = new decimal(array47);
		global::System.Windows.Forms.NumericUpDown numericUpDown48 = this.f7Delay;
		int[] array48 = new int[4];
		array48[0] = 1;
		numericUpDown48.Minimum = new decimal(array48);
		this.f7Delay.Name = "f7Delay";
		this.f7Delay.Size = new global::System.Drawing.Size(40, 20);
		this.f7Delay.TabIndex = 14;
		global::System.Windows.Forms.NumericUpDown numericUpDown49 = this.f7Delay;
		int[] array49 = new int[4];
		array49[0] = 10;
		numericUpDown49.Value = new decimal(array49);
		this.f7Delay.ValueChanged += new global::System.EventHandler(this.f7Delay_ValueChanged);
		this.f7Enable.AutoSize = true;
		this.f7Enable.Location = new global::System.Drawing.Point(102, 1);
		this.f7Enable.Name = "f7Enable";
		this.f7Enable.Size = new global::System.Drawing.Size(38, 17);
		this.f7Enable.TabIndex = 13;
		this.f7Enable.Text = "F7";
		this.f7Enable.UseVisualStyleBackColor = true;
		this.f7Enable.CheckedChanged += new global::System.EventHandler(this.f7Enable_CheckedChanged);
		this.isSkill.AccessibleRole = global::System.Windows.Forms.AccessibleRole.None;
		this.isSkill.AutoSize = true;
		this.isSkill.Location = new global::System.Drawing.Point(8, 6);
		this.isSkill.Name = "isSkill";
		this.isSkill.Size = new global::System.Drawing.Size(93, 17);
		this.isSkill.TabIndex = 0;
		this.isSkill.Text = "Dùng kĩ năng";
		this.isSkill.UseVisualStyleBackColor = true;
		this.isSkill.CheckedChanged += new global::System.EventHandler(this.isSkill_CheckedChanged);
		this.tabPageConfig.Controls.Add(this.label4);
		this.tabPageConfig.Controls.Add(this.label3);
		this.tabPageConfig.Controls.Add(this.targetKey);
		this.tabPageConfig.Controls.Add(this.baseSkill);
		this.tabPageConfig.Controls.Add(this.label2);
		this.tabPageConfig.Controls.Add(this.linkLabel1);
		this.tabPageConfig.Controls.Add(this.webBrowser1);
		this.tabPageConfig.Controls.Add(this.groupBox1);
		this.tabPageConfig.Controls.Add(this.shutdownAfterKill);
		this.tabPageConfig.Controls.Add(this.topMost);
		this.tabPageConfig.Controls.Add(this.panel1);
		this.tabPageConfig.Controls.Add(this.button1);
		this.tabPageConfig.Location = new global::System.Drawing.Point(4, 22);
		this.tabPageConfig.Name = "tabPageConfig";
		this.tabPageConfig.Padding = new global::System.Windows.Forms.Padding(3);
		this.tabPageConfig.Size = new global::System.Drawing.Size(191, 316);
		this.tabPageConfig.TabIndex = 1;
		this.tabPageConfig.Text = "Tùy Chọn";
		this.tabPageConfig.UseVisualStyleBackColor = true;
		this.label4.AutoSize = true;
		this.label4.Location = new global::System.Drawing.Point(4, 77);
		this.label4.Name = "label4";
		this.label4.Size = new global::System.Drawing.Size(113, 13);
		this.label4.TabIndex = 47;
		this.label4.Text = "Phím chuyển mục tiêu";
		this.label3.AutoSize = true;
		this.label3.Location = new global::System.Drawing.Point(6, 50);
		this.label3.Name = "label3";
		this.label3.Size = new global::System.Drawing.Size(109, 13);
		this.label3.TabIndex = 46;
		this.label3.Text = "Phím kĩ năng cơ bản";
		this.targetKey.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.targetKey.FormattingEnabled = true;
		this.targetKey.Items.AddRange(new object[]
		{
			"F1",
			"F2",
			"F3",
			"F4",
			"F5",
			"F6",
			"F7",
			"F8",
			"F9",
			"F10",
			"F11",
			"F12"
		});
		this.targetKey.Location = new global::System.Drawing.Point(121, 74);
		this.targetKey.Name = "targetKey";
		this.targetKey.Size = new global::System.Drawing.Size(50, 21);
		this.targetKey.TabIndex = 45;
		this.targetKey.SelectedIndexChanged += new global::System.EventHandler(this.targetKey_SelectedIndexChanged);
		this.baseSkill.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
		this.baseSkill.FormattingEnabled = true;
		this.baseSkill.Items.AddRange(new object[]
		{
			"F1",
			"F2",
			"F3",
			"F4",
			"F5",
			"F6",
			"F7",
			"F8",
			"F9",
			"F10",
			"F11",
			"F12"
		});
		this.baseSkill.Location = new global::System.Drawing.Point(121, 47);
		this.baseSkill.Name = "baseSkill";
		this.baseSkill.Size = new global::System.Drawing.Size(50, 21);
		this.baseSkill.TabIndex = 44;
		this.baseSkill.SelectedIndexChanged += new global::System.EventHandler(this.baseSkill_SelectedIndexChanged);
		this.label2.AutoSize = true;
		this.label2.Location = new global::System.Drawing.Point(6, 300);
		this.label2.Name = "label2";
		this.label2.Size = new global::System.Drawing.Size(168, 13);
		this.label2.TabIndex = 8;
		this.label2.Text = "Ym liên hệ: tieudattai@yahoo.com";
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.Location = new global::System.Drawing.Point(6, 261);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new global::System.Drawing.Size(180, 39);
		this.linkLabel1.TabIndex = 7;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "Bản quyền thuộc về Vipautopro.com\r\nDownload phiên bản mới nhất tại \r\ntrang chủ Vipautopro.com";
		this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
		this.webBrowser1.Location = new global::System.Drawing.Point(6, 231);
		this.webBrowser1.MinimumSize = new global::System.Drawing.Size(20, 20);
		this.webBrowser1.Name = "webBrowser1";
		this.webBrowser1.ScriptErrorsSuppressed = true;
		this.webBrowser1.Size = new global::System.Drawing.Size(93, 27);
		this.webBrowser1.TabIndex = 6;
		this.webBrowser1.Visible = false;
		this.groupBox1.Controls.Add(this.testAlarm);
		this.groupBox1.Controls.Add(this.stopMusic);
		this.groupBox1.Controls.Add(this.playMusic);
		this.groupBox1.Controls.Add(this.openMusic);
		this.groupBox1.Controls.Add(this.musicPath);
		this.groupBox1.Location = new global::System.Drawing.Point(7, 101);
		this.groupBox1.Name = "groupBox1";
		this.groupBox1.Size = new global::System.Drawing.Size(178, 72);
		this.groupBox1.TabIndex = 5;
		this.groupBox1.TabStop = false;
		this.groupBox1.Text = "File nhạc khi cảnh báo";
		this.testAlarm.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
		this.testAlarm.ForeColor = global::System.Drawing.SystemColors.AppWorkspace;
		this.testAlarm.Location = new global::System.Drawing.Point(111, 45);
		this.testAlarm.Name = "testAlarm";
		this.testAlarm.Size = new global::System.Drawing.Size(29, 20);
		this.testAlarm.TabIndex = 7;
		this.testAlarm.Text = "?";
		this.testAlarm.UseVisualStyleBackColor = true;
		this.testAlarm.Click += new global::System.EventHandler(this.testAlarm_Click);
		this.stopMusic.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
		this.stopMusic.ForeColor = global::System.Drawing.SystemColors.AppWorkspace;
		this.stopMusic.Location = new global::System.Drawing.Point(76, 45);
		this.stopMusic.Name = "stopMusic";
		this.stopMusic.Size = new global::System.Drawing.Size(29, 20);
		this.stopMusic.TabIndex = 6;
		this.stopMusic.Text = "\u007f";
		this.stopMusic.UseVisualStyleBackColor = true;
		this.stopMusic.Click += new global::System.EventHandler(this.stopMusic_Click);
		this.playMusic.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
		this.playMusic.ForeColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
		this.playMusic.Location = new global::System.Drawing.Point(41, 45);
		this.playMusic.Name = "playMusic";
		this.playMusic.Size = new global::System.Drawing.Size(29, 20);
		this.playMusic.TabIndex = 2;
		this.playMusic.Text = ">";
		this.playMusic.UseVisualStyleBackColor = true;
		this.playMusic.Click += new global::System.EventHandler(this.playMusic_Click);
		this.openMusic.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 163);
		this.openMusic.Location = new global::System.Drawing.Point(6, 45);
		this.openMusic.Name = "openMusic";
		this.openMusic.Size = new global::System.Drawing.Size(29, 20);
		this.openMusic.TabIndex = 1;
		this.openMusic.Text = "...";
		this.openMusic.UseVisualStyleBackColor = true;
		this.openMusic.Click += new global::System.EventHandler(this.openMusic_Click);
		this.musicPath.Location = new global::System.Drawing.Point(6, 19);
		this.musicPath.Name = "musicPath";
		this.musicPath.Size = new global::System.Drawing.Size(166, 20);
		this.musicPath.TabIndex = 0;
		this.musicPath.TextChanged += new global::System.EventHandler(this.musicPath_TextChanged);
		this.shutdownAfterKill.AutoSize = true;
		this.shutdownAfterKill.Location = new global::System.Drawing.Point(6, 30);
		this.shutdownAfterKill.Name = "shutdownAfterKill";
		this.shutdownAfterKill.Size = new global::System.Drawing.Size(157, 17);
		this.shutdownAfterKill.TabIndex = 4;
		this.shutdownAfterKill.Text = "Tắt máy sau khi thoát game";
		this.shutdownAfterKill.UseVisualStyleBackColor = true;
		this.shutdownAfterKill.CheckedChanged += new global::System.EventHandler(this.shutdownAfterKill_CheckedChanged);
		this.topMost.AutoSize = true;
		this.topMost.Location = new global::System.Drawing.Point(7, 7);
		this.topMost.Name = "topMost";
		this.topMost.Size = new global::System.Drawing.Size(80, 17);
		this.topMost.TabIndex = 3;
		this.topMost.Text = "Luôn ở trên";
		this.topMost.UseVisualStyleBackColor = true;
		this.topMost.CheckedChanged += new global::System.EventHandler(this.topMost_CheckedChanged);
		this.panel1.Controls.Add(this.farmEnable);
		this.panel1.Controls.Add(this.farmBack);
		this.panel1.Controls.Add(this.farmGo);
		this.panel1.Location = new global::System.Drawing.Point(105, 189);
		this.panel1.Name = "panel1";
		this.panel1.Size = new global::System.Drawing.Size(83, 69);
		this.panel1.TabIndex = 2;
		this.panel1.Visible = false;
		this.farmEnable.AutoSize = true;
		this.farmEnable.Location = new global::System.Drawing.Point(3, 3);
		this.farmEnable.Name = "farmEnable";
		this.farmEnable.Size = new global::System.Drawing.Size(90, 17);
		this.farmEnable.TabIndex = 36;
		this.farmEnable.Text = "Thương nhân";
		this.farmEnable.UseVisualStyleBackColor = true;
		this.farmEnable.CheckedChanged += new global::System.EventHandler(this.farmEnable_CheckedChanged);
		this.farmBack.AutoSize = true;
		this.farmBack.Location = new global::System.Drawing.Point(3, 49);
		this.farmBack.Name = "farmBack";
		this.farmBack.Size = new global::System.Drawing.Size(38, 17);
		this.farmBack.TabIndex = 1;
		this.farmBack.TabStop = true;
		this.farmBack.Text = "Về";
		this.farmBack.UseVisualStyleBackColor = true;
		this.farmBack.CheckedChanged += new global::System.EventHandler(this.farmBack_CheckedChanged);
		this.farmGo.AutoSize = true;
		this.farmGo.Location = new global::System.Drawing.Point(3, 26);
		this.farmGo.Name = "farmGo";
		this.farmGo.Size = new global::System.Drawing.Size(35, 17);
		this.farmGo.TabIndex = 0;
		this.farmGo.TabStop = true;
		this.farmGo.Text = "Đi";
		this.farmGo.UseVisualStyleBackColor = true;
		this.farmGo.CheckedChanged += new global::System.EventHandler(this.farmGo_CheckedChanged);
		this.button1.Location = new global::System.Drawing.Point(3, 186);
		this.button1.Name = "button1";
		this.button1.Size = new global::System.Drawing.Size(75, 23);
		this.button1.TabIndex = 1;
		this.button1.Text = "button1";
		this.button1.UseVisualStyleBackColor = true;
		this.button1.Visible = false;
		this.button1.Click += new global::System.EventHandler(this.button1_Click);
		this.tabPageInfo.Controls.Add(this.charName);
		this.tabPageInfo.Controls.Add(this.resetExpCaculator);
		this.tabPageInfo.Controls.Add(this.enterExpMax);
		this.tabPageInfo.Controls.Add(this.info);
		this.tabPageInfo.Location = new global::System.Drawing.Point(4, 22);
		this.tabPageInfo.Name = "tabPageInfo";
		this.tabPageInfo.Size = new global::System.Drawing.Size(191, 316);
		this.tabPageInfo.TabIndex = 2;
		this.tabPageInfo.Text = "Thông Tin";
		this.tabPageInfo.UseVisualStyleBackColor = true;
		this.tabPageInfo.Enter += new global::System.EventHandler(this.tabPageInfo_Enter);
		this.charName.AutoSize = true;
		this.charName.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
		this.charName.ForeColor = global::System.Drawing.Color.OrangeRed;
		this.charName.Location = new global::System.Drawing.Point(8, 10);
		this.charName.Name = "charName";
		this.charName.Size = new global::System.Drawing.Size(73, 17);
		this.charName.TabIndex = 3;
		this.charName.Text = "Nhân vật";
		this.resetExpCaculator.Location = new global::System.Drawing.Point(3, 256);
		this.resetExpCaculator.Name = "resetExpCaculator";
		this.resetExpCaculator.Size = new global::System.Drawing.Size(185, 23);
		this.resetExpCaculator.TabIndex = 2;
		this.resetExpCaculator.Text = "Tính lại tốc độ luyện cấp";
		this.resetExpCaculator.UseVisualStyleBackColor = true;
		this.resetExpCaculator.Click += new global::System.EventHandler(this.resetExpCaculator_Click);
		this.enterExpMax.Location = new global::System.Drawing.Point(3, 285);
		this.enterExpMax.Name = "enterExpMax";
		this.enterExpMax.Size = new global::System.Drawing.Size(185, 23);
		this.enterExpMax.TabIndex = 1;
		this.enterExpMax.Text = "Nhập vào Exp cần để thăng cấp";
		this.enterExpMax.UseVisualStyleBackColor = true;
		this.enterExpMax.Click += new global::System.EventHandler(this.enterExpMax_Click);
		this.info.AutoSize = true;
		this.info.Location = new global::System.Drawing.Point(8, 35);
		this.info.Name = "info";
		this.info.Size = new global::System.Drawing.Size(104, 13);
		this.info.TabIndex = 0;
		this.info.Text = "Chưa chọn nhân vật";
		this.timer_0.Enabled = true;
		this.timer_0.Interval = 1000;
		this.timer_0.Tick += new global::System.EventHandler(this.timer_0_Tick);
		//this.imageList_0.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
		this.imageList_0.TransparentColor = global::System.Drawing.Color.Transparent;
		//this.imageList_0.Images.SetKeyName(0, "dragon.ico");
		//this.imageList_0.Images.SetKeyName(1, "dragonPause.ico");
		this.notifyIcon_0.ContextMenuStrip = this.contextMenuStripNotifyIcon;
		this.notifyIcon_0.Text = "MicroAuto";
		this.notifyIcon_0.Visible = true;
		this.notifyIcon_0.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.notifyIcon_0_MouseClick);
		this.contextMenuStripNotifyIcon.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
		{
			this.toolStripMenuItem_5,
			this.toolStripSeparator2,
			this.toolStripMenuItem_11,
			this.toolStripMenuItem_9,
			this.toolStripMenuItem_10,
			this.toolStripMenuItem_8,
			this.toolStripSeparator3,
			this.toolStripMenuItem_3
		});
		this.contextMenuStripNotifyIcon.Name = "contextMenuStripNotifyIcon";
		this.contextMenuStripNotifyIcon.Size = new global::System.Drawing.Size(213, 148);
		this.toolStripMenuItem_5.Name = "bắtĐầuDừngAutoToolStripMenuItem";
		this.toolStripMenuItem_5.Size = new global::System.Drawing.Size(212, 22);
		this.toolStripMenuItem_5.Text = "Bắt Đầu/ Tạm dừng auto";
		this.toolStripMenuItem_5.Click += new global::System.EventHandler(this.toolStripMenuItem_5_Click);
		this.toolStripSeparator2.Name = "toolStripSeparator2";
		this.toolStripSeparator2.Size = new global::System.Drawing.Size(209, 6);
		this.toolStripMenuItem_11.Name = "lưuToànBộThiếtLậpToolStripMenuItem";
		this.toolStripMenuItem_11.ShortcutKeys = (global::System.Windows.Forms.Keys)131155;
		this.toolStripMenuItem_11.Size = new global::System.Drawing.Size(212, 22);
		this.toolStripMenuItem_11.Text = "Lưu toàn bộ thiết lập";
		this.toolStripMenuItem_11.Click += new global::System.EventHandler(this.toolStripMenuItem_11_Click);
		this.toolStripMenuItem_9.Name = "hiệnToànBộGameToolStripMenuItem";
		this.toolStripMenuItem_9.Size = new global::System.Drawing.Size(212, 22);
		this.toolStripMenuItem_9.Text = "Hiện toàn bộ game";
		this.toolStripMenuItem_9.Click += new global::System.EventHandler(this.toolStripMenuItem_9_Click);
		this.toolStripMenuItem_10.Name = "ẩnToànBộGameToolStripMenuItem";
		this.toolStripMenuItem_10.Size = new global::System.Drawing.Size(212, 22);
		this.toolStripMenuItem_10.Text = "Ẩn toàn bộ game";
		this.toolStripMenuItem_10.Click += new global::System.EventHandler(this.toolStripMenuItem_10_Click);
		this.toolStripMenuItem_8.Name = "tọaĐộTrainTạiĐâyToolStripMenuItem1";
		this.toolStripMenuItem_8.Size = new global::System.Drawing.Size(212, 22);
		this.toolStripMenuItem_8.Text = "Tọa độ train tại đây";
		this.toolStripMenuItem_8.Click += new global::System.EventHandler(this.toolStripMenuItem_8_Click);
		this.toolStripSeparator3.Name = "toolStripSeparator3";
		this.toolStripSeparator3.Size = new global::System.Drawing.Size(209, 6);
		this.toolStripMenuItem_3.Name = "thoátToolStripMenuItem";
		this.toolStripMenuItem_3.Size = new global::System.Drawing.Size(212, 22);
		this.toolStripMenuItem_3.Text = "Thoát";
		this.toolStripMenuItem_3.Click += new global::System.EventHandler(this.toolStripMenuItem_3_Click);
		this.label5.AutoSize = true;
		this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 163);
		this.label5.ForeColor = global::System.Drawing.Color.Red;
		this.label5.Location = new global::System.Drawing.Point(5, 484);
		this.label5.Name = "label5";
		this.label5.Size = new global::System.Drawing.Size(193, 26);
		this.label5.TabIndex = 3;
		this.label5.Text = "Click tại đây để ủng hộ auto \r\nngày một hoàn thiện và miễn phí";
		this.toolTip_0.SetToolTip(this.label5, "Để auto ngày một phát triển, thỉnh thoảng bạn nên click tại đây,\r\nRất mong được sự ủng hộ của tất cả mọi người sử dụng auto.");
		this.label5.MouseClick += new global::System.Windows.Forms.MouseEventHandler(this.label5_MouseClick);
		this.timer_1.Enabled = true;
		this.timer_1.Interval = 1000;
		this.timer_1.Tick += new global::System.EventHandler(this.timer_1_Tick);
		base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = global::System.Drawing.Color.White;
		base.ClientSize = new global::System.Drawing.Size(199, 512);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.listViewGame);
		base.Controls.Add(this.tabControl1);
		base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "FormMain";
		this.Text = "MicroAuto 6.9";
		base.Load += new global::System.EventHandler(this.FormMain_Load);
		base.FormClosing += new global::System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
		base.Resize += new global::System.EventHandler(this.FormMain_Resize);
		this.contextMenuStripListView.ResumeLayout(false);
		this.tabControl1.ResumeLayout(false);
		this.tabPageAcc.ResumeLayout(false);
		this.tabPageAcc.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.radiusValue).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.onlyAttackFixHPMaxPercent).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.onlyAttackFixHPMinPercent).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.exitWhenHPLowPercent).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.buffMPPercent).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.buffHPPercent).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.buffPetPercent).EndInit();
		this.panelSkill.ResumeLayout(false);
		this.panelSkill.PerformLayout();
		((global::System.ComponentModel.ISupportInitialize)this.f6Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f12Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f1Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f11Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f2Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f10Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f3Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f9Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f4Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f8Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f5Delay).EndInit();
		((global::System.ComponentModel.ISupportInitialize)this.f7Delay).EndInit();
		this.tabPageConfig.ResumeLayout(false);
		this.tabPageConfig.PerformLayout();
		this.groupBox1.ResumeLayout(false);
		this.groupBox1.PerformLayout();
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		this.tabPageInfo.ResumeLayout(false);
		this.tabPageInfo.PerformLayout();
		this.contextMenuStripNotifyIcon.ResumeLayout(false);
		base.ResumeLayout(false);
		base.PerformLayout();
	}

	// Token: 0x04000060 RID: 96
	private global::System.ComponentModel.IContainer icontainer_0;

	// Token: 0x04000061 RID: 97
	private global::System.Windows.Forms.ListView listViewGame;

	// Token: 0x04000062 RID: 98
	private global::System.Windows.Forms.ColumnHeader columnHeader_0;

	// Token: 0x04000063 RID: 99
	private global::System.Windows.Forms.TabControl tabControl1;

	// Token: 0x04000064 RID: 100
	private global::System.Windows.Forms.TabPage tabPageAcc;

	// Token: 0x04000065 RID: 101
	private global::System.Windows.Forms.TabPage tabPageConfig;

	// Token: 0x04000066 RID: 102
	private global::System.Windows.Forms.CheckBox isSkill;

	// Token: 0x04000067 RID: 103
	private global::System.Windows.Forms.CheckBox f1Enable;

	// Token: 0x04000068 RID: 104
	private global::System.Windows.Forms.NumericUpDown f12Delay;

	// Token: 0x04000069 RID: 105
	private global::System.Windows.Forms.CheckBox f12Enable;

	// Token: 0x0400006A RID: 106
	private global::System.Windows.Forms.NumericUpDown f11Delay;

	// Token: 0x0400006B RID: 107
	private global::System.Windows.Forms.CheckBox f11Enable;

	// Token: 0x0400006C RID: 108
	private global::System.Windows.Forms.NumericUpDown f10Delay;

	// Token: 0x0400006D RID: 109
	private global::System.Windows.Forms.CheckBox f10Enable;

	// Token: 0x0400006E RID: 110
	private global::System.Windows.Forms.NumericUpDown f9Delay;

	// Token: 0x0400006F RID: 111
	private global::System.Windows.Forms.CheckBox f9Enable;

	// Token: 0x04000070 RID: 112
	private global::System.Windows.Forms.NumericUpDown f8Delay;

	// Token: 0x04000071 RID: 113
	private global::System.Windows.Forms.CheckBox f8Enable;

	// Token: 0x04000072 RID: 114
	private global::System.Windows.Forms.NumericUpDown f7Delay;

	// Token: 0x04000073 RID: 115
	private global::System.Windows.Forms.CheckBox f7Enable;

	// Token: 0x04000074 RID: 116
	private global::System.Windows.Forms.NumericUpDown f6Delay;

	// Token: 0x04000075 RID: 117
	private global::System.Windows.Forms.CheckBox f6Enable;

	// Token: 0x04000076 RID: 118
	private global::System.Windows.Forms.NumericUpDown f5Delay;

	// Token: 0x04000077 RID: 119
	private global::System.Windows.Forms.CheckBox f5Enable;

	// Token: 0x04000078 RID: 120
	private global::System.Windows.Forms.NumericUpDown f4Delay;

	// Token: 0x04000079 RID: 121
	private global::System.Windows.Forms.CheckBox f4Enable;

	// Token: 0x0400007A RID: 122
	private global::System.Windows.Forms.NumericUpDown f3Delay;

	// Token: 0x0400007B RID: 123
	private global::System.Windows.Forms.CheckBox f3Enable;

	// Token: 0x0400007C RID: 124
	private global::System.Windows.Forms.NumericUpDown f2Delay;

	// Token: 0x0400007D RID: 125
	private global::System.Windows.Forms.CheckBox f2Enable;

	// Token: 0x0400007E RID: 126
	private global::System.Windows.Forms.NumericUpDown f1Delay;

	// Token: 0x0400007F RID: 127
	private global::System.Windows.Forms.Panel panelSkill;

	// Token: 0x04000080 RID: 128
	private global::System.Windows.Forms.ContextMenuStrip contextMenuStripListView;

	// Token: 0x04000081 RID: 129
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_0;

	// Token: 0x04000082 RID: 130
	private global::System.Windows.Forms.Label info;

	// Token: 0x04000083 RID: 131
	private global::System.Windows.Forms.Timer timer_0;

	// Token: 0x04000084 RID: 132
	private global::System.Windows.Forms.NumericUpDown buffPetPercent;

	// Token: 0x04000085 RID: 133
	private global::System.Windows.Forms.ComboBox buffPetKey;

	// Token: 0x04000086 RID: 134
	private global::System.Windows.Forms.CheckBox buffPetEnable;

	// Token: 0x04000087 RID: 135
	private global::System.Windows.Forms.CheckBox buffHPEnable;

	// Token: 0x04000088 RID: 136
	private global::System.Windows.Forms.ComboBox buffHPKey;

	// Token: 0x04000089 RID: 137
	private global::System.Windows.Forms.NumericUpDown buffHPPercent;

	// Token: 0x0400008A RID: 138
	private global::System.Windows.Forms.CheckBox buffMPEnable;

	// Token: 0x0400008B RID: 139
	private global::System.Windows.Forms.ComboBox buffMPKey;

	// Token: 0x0400008C RID: 140
	private global::System.Windows.Forms.NumericUpDown buffMPPercent;

	// Token: 0x0400008D RID: 141
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_1;

	// Token: 0x0400008E RID: 142
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_2;

	// Token: 0x0400008F RID: 143
	private global::System.Windows.Forms.CheckBox farmEnable;

	// Token: 0x04000090 RID: 144
	private global::System.Windows.Forms.Button button1;

	// Token: 0x04000091 RID: 145
	private global::System.Windows.Forms.Panel panel1;

	// Token: 0x04000092 RID: 146
	private global::System.Windows.Forms.RadioButton farmBack;

	// Token: 0x04000093 RID: 147
	private global::System.Windows.Forms.RadioButton farmGo;

	// Token: 0x04000094 RID: 148
	private global::System.Windows.Forms.ImageList imageList_0;

	// Token: 0x04000095 RID: 149
	private global::System.Windows.Forms.CheckBox topMost;

	// Token: 0x04000096 RID: 150
	private global::System.Windows.Forms.CheckBox shutdownAfterKill;

	// Token: 0x04000097 RID: 151
	private global::System.Windows.Forms.TabPage tabPageInfo;

	// Token: 0x04000098 RID: 152
	private global::System.Windows.Forms.CheckBox exitWhenHPLow;

	// Token: 0x04000099 RID: 153
	private global::System.Windows.Forms.NumericUpDown exitWhenHPLowPercent;

	// Token: 0x0400009A RID: 154
	private global::System.Windows.Forms.GroupBox groupBox1;

	// Token: 0x0400009B RID: 155
	private global::System.Windows.Forms.Button openMusic;

	// Token: 0x0400009C RID: 156
	private global::System.Windows.Forms.TextBox musicPath;

	// Token: 0x0400009D RID: 157
	private global::System.Windows.Forms.Button stopMusic;

	// Token: 0x0400009E RID: 158
	private global::System.Windows.Forms.Button playMusic;

	// Token: 0x0400009F RID: 159
	private global::System.Windows.Forms.NotifyIcon notifyIcon_0;

	// Token: 0x040000A0 RID: 160
	private global::System.Windows.Forms.Label label1;

	// Token: 0x040000A1 RID: 161
	private global::System.Windows.Forms.NumericUpDown onlyAttackFixHPMaxPercent;

	// Token: 0x040000A2 RID: 162
	private global::System.Windows.Forms.NumericUpDown onlyAttackFixHPMinPercent;

	// Token: 0x040000A3 RID: 163
	private global::System.Windows.Forms.CheckBox onlyAttackFixHP;

	// Token: 0x040000A4 RID: 164
	private global::System.Windows.Forms.ToolTip toolTip_0;

	// Token: 0x040000A5 RID: 165
	private global::System.Windows.Forms.WebBrowser webBrowser1;

	// Token: 0x040000A6 RID: 166
	private global::System.Windows.Forms.ContextMenuStrip contextMenuStripNotifyIcon;

	// Token: 0x040000A7 RID: 167
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_3;

	// Token: 0x040000A8 RID: 168
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_4;

	// Token: 0x040000A9 RID: 169
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator1;

	// Token: 0x040000AA RID: 170
	private global::System.Windows.Forms.ToolStripMenuItem resetAutoToolStripMenuItem;

	// Token: 0x040000AB RID: 171
	private global::System.Windows.Forms.LinkLabel linkLabel1;

	// Token: 0x040000AC RID: 172
	private global::System.Windows.Forms.Label label2;

	// Token: 0x040000AD RID: 173
	private global::System.Windows.Forms.CheckBox radius;

	// Token: 0x040000AE RID: 174
	private global::System.Windows.Forms.NumericUpDown radiusValue;

	// Token: 0x040000AF RID: 175
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_5;

	// Token: 0x040000B0 RID: 176
	private global::System.Windows.Forms.Button enterExpMax;

	// Token: 0x040000B1 RID: 177
	private global::System.Windows.Forms.Button resetExpCaculator;

	// Token: 0x040000B2 RID: 178
	private global::System.Windows.Forms.Label label4;

	// Token: 0x040000B3 RID: 179
	private global::System.Windows.Forms.Label label3;

	// Token: 0x040000B4 RID: 180
	private global::System.Windows.Forms.ComboBox targetKey;

	// Token: 0x040000B5 RID: 181
	private global::System.Windows.Forms.ComboBox baseSkill;

	// Token: 0x040000B6 RID: 182
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_6;

	// Token: 0x040000B7 RID: 183
	private global::System.Windows.Forms.Label charName;

	// Token: 0x040000B8 RID: 184
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_7;

	// Token: 0x040000B9 RID: 185
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_8;

	// Token: 0x040000BA RID: 186
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_9;

	// Token: 0x040000BB RID: 187
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_10;

	// Token: 0x040000BC RID: 188
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_11;

	// Token: 0x040000BD RID: 189
	private global::System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_12;

	// Token: 0x040000BE RID: 190
	private global::System.Windows.Forms.Timer timer_1;

	// Token: 0x040000BF RID: 191
	private global::System.Windows.Forms.ColumnHeader columnHeader_1;

	// Token: 0x040000C0 RID: 192
	private global::System.Windows.Forms.ColumnHeader columnHeader_2;

	// Token: 0x040000C1 RID: 193
	private global::System.Windows.Forms.ColumnHeader columnHeader_3;

	// Token: 0x040000C2 RID: 194
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

	// Token: 0x040000C3 RID: 195
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator3;

	// Token: 0x040000C4 RID: 196
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator4;

	// Token: 0x040000C5 RID: 197
	private global::System.Windows.Forms.ToolStripSeparator toolStripSeparator5;

	// Token: 0x040000C6 RID: 198
	private global::System.Windows.Forms.ColumnHeader columnHeader_4;

	// Token: 0x040000C7 RID: 199
	private global::System.Windows.Forms.Button testAlarm;

	// Token: 0x040000C8 RID: 200
	private global::System.Windows.Forms.CheckBox lure;

	// Token: 0x040000C9 RID: 201
	private global::System.Windows.Forms.ColumnHeader columnHeader_5;

	// Token: 0x040000CA RID: 202
	private global::System.Windows.Forms.ToolStripMenuItem lToolStripMenuItem;

	// Token: 0x040000CB RID: 203
	private global::System.Windows.Forms.Label label5;
}
