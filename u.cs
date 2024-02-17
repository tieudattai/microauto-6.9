using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using MicroAuto_6._0.Properties;
using Microsoft.VisualBasic;

public class u : Form
{
	private IContainer m_a;

	private ListView m_b;

	private ColumnHeader m_c;

	private TabControl m_d;

	private TabPage m_e;

	private TabPage m_f;

	private CheckBox m_g;

	private CheckBox m_h;

	private NumericUpDown m_i;

	private CheckBox m_j;

	private NumericUpDown m_k;

	private CheckBox m_l;

	private NumericUpDown m_m;

	private CheckBox m_n;

	private NumericUpDown m_o;

	private CheckBox m_p;

	private NumericUpDown m_q;

	private CheckBox m_r;

	private NumericUpDown m_s;

	private CheckBox m_t;

	private NumericUpDown m_u;

	private CheckBox m_v;

	private NumericUpDown m_w;

	private CheckBox m_x;

	private NumericUpDown m_y;

	private CheckBox m_z;

	private NumericUpDown m_aa;

	private CheckBox m_ab;

	private NumericUpDown m_ac;

	private CheckBox m_ad;

	private NumericUpDown m_ae;

	private Panel m_af;

	private ContextMenuStrip m_ag;

	private ToolStripMenuItem m_ah;

	private Label m_ai;

	private Timer m_aj;

	private NumericUpDown m_ak;

	private ComboBox m_al;

	private CheckBox m_am;

	private CheckBox m_an;

	private ComboBox m_ao;

	private NumericUpDown m_ap;

	private CheckBox m_aq;

	private ComboBox m_ar;

	private NumericUpDown m_as;

	private ToolStripMenuItem m_at;

	private ToolStripMenuItem m_au;

	private CheckBox m_av;

	private Button m_aw;

	private Panel m_ax;

	private RadioButton m_ay;

	private RadioButton m_az;

	private ImageList m_a0;

	private CheckBox m_a1;

	private CheckBox m_a2;

	private TabPage m_a3;

	private CheckBox m_a4;

	private NumericUpDown m_a5;

	private GroupBox m_a6;

	private Button m_a7;

	private TextBox m_a8;

	private Button m_a9;

	private Button m_ba;

	private NotifyIcon m_bb;

	private Label m_bc;

	private NumericUpDown m_bd;

	private NumericUpDown m_be;

	private CheckBox m_bf;

	private ToolTip m_bg;

	private WebBrowser m_bh;

	private ContextMenuStrip m_bi;

	private ToolStripMenuItem m_bj;

	private ToolStripMenuItem m_bk;

	private ToolStripSeparator m_bl;

	private ToolStripMenuItem m_bm;

	private LinkLabel m_bn;

	private Label m_bo;

	private CheckBox m_bp;

	private NumericUpDown bq;

	private ToolStripMenuItem br;

	private Button bs;

	private Button bt;

	private Label bu;

	private Label bv;

	private ComboBox bw;

	private ComboBox bx;

	private ToolStripMenuItem by;

	private Label bz;

	private ToolStripMenuItem b0;

	private ToolStripMenuItem b1;

	private ToolStripMenuItem b2;

	private ToolStripMenuItem b3;

	private ToolStripMenuItem b4;

	private ToolStripMenuItem b5;

	private Timer b6;

	private ColumnHeader b7;

	private ColumnHeader b8;

	private ColumnHeader b9;

	private ToolStripSeparator ca;

	private ToolStripSeparator cb;

	private ToolStripSeparator cc;

	private ToolStripSeparator cd;

	private ColumnHeader ce;

	private Button cf;

	private CheckBox cg;

	private ColumnHeader ch;

	private ToolStripMenuItem ci;

	private Label cj;

	private bool ck;

	private Dictionary<int, q> cl = new Dictionary<int, q>();

	private h cm = new h();

	private f cn = new f();

	public static d co = new d();

	private Stopwatch cp = new Stopwatch();

	protected virtual void a(bool A_0)
	{
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				if (true)
				{
				}
				if (A_0)
				{
					num = 4;
					continue;
				}
				break;
			case 0:
				this.m_a.Dispose();
				num = 2;
				continue;
			case 4:
				num = 1;
				continue;
			case 1:
				if (this.m_a != null)
				{
					num = 0;
					continue;
				}
				break;
			case 2:
				break;
			}
			break;
		}
		Dispose(A_0);
	}

	private void h()
	{
		if (true)
		{
		}
		this.m_a = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(u));
		this.m_b = new ListView();
		this.m_c = new ColumnHeader();
		b7 = new ColumnHeader();
		b9 = new ColumnHeader();
		ch = new ColumnHeader();
		b8 = new ColumnHeader();
		ce = new ColumnHeader();
		this.m_ag = new ContextMenuStrip(this.m_a);
		this.m_ah = new ToolStripMenuItem();
		ci = new ToolStripMenuItem();
		cc = new ToolStripSeparator();
		this.m_at = new ToolStripMenuItem();
		this.m_au = new ToolStripMenuItem();
		this.m_bk = new ToolStripMenuItem();
		this.m_bl = new ToolStripSeparator();
		by = new ToolStripMenuItem();
		b5 = new ToolStripMenuItem();
		this.m_bm = new ToolStripMenuItem();
		cd = new ToolStripSeparator();
		b0 = new ToolStripMenuItem();
		this.m_d = new TabControl();
		this.m_e = new TabPage();
		cg = new CheckBox();
		bq = new NumericUpDown();
		this.m_bp = new CheckBox();
		this.m_bc = new Label();
		this.m_bd = new NumericUpDown();
		this.m_be = new NumericUpDown();
		this.m_bf = new CheckBox();
		this.m_a4 = new CheckBox();
		this.m_a5 = new NumericUpDown();
		this.m_aq = new CheckBox();
		this.m_ar = new ComboBox();
		this.m_as = new NumericUpDown();
		this.m_an = new CheckBox();
		this.m_ao = new ComboBox();
		this.m_ap = new NumericUpDown();
		this.m_am = new CheckBox();
		this.m_al = new ComboBox();
		this.m_ak = new NumericUpDown();
		this.m_af = new Panel();
		this.m_u = new NumericUpDown();
		this.m_h = new CheckBox();
		this.m_i = new NumericUpDown();
		this.m_ae = new NumericUpDown();
		this.m_j = new CheckBox();
		this.m_ad = new CheckBox();
		this.m_k = new NumericUpDown();
		this.m_ac = new NumericUpDown();
		this.m_l = new CheckBox();
		this.m_ab = new CheckBox();
		this.m_m = new NumericUpDown();
		this.m_aa = new NumericUpDown();
		this.m_n = new CheckBox();
		this.m_z = new CheckBox();
		this.m_o = new NumericUpDown();
		this.m_y = new NumericUpDown();
		this.m_p = new CheckBox();
		this.m_x = new CheckBox();
		this.m_q = new NumericUpDown();
		this.m_w = new NumericUpDown();
		this.m_r = new CheckBox();
		this.m_v = new CheckBox();
		this.m_s = new NumericUpDown();
		this.m_t = new CheckBox();
		this.m_g = new CheckBox();
		this.m_f = new TabPage();
		bu = new Label();
		bv = new Label();
		bw = new ComboBox();
		bx = new ComboBox();
		this.m_bo = new Label();
		this.m_bn = new LinkLabel();
		this.m_bh = new WebBrowser();
		this.m_a6 = new GroupBox();
		cf = new Button();
		this.m_a9 = new Button();
		this.m_ba = new Button();
		this.m_a7 = new Button();
		this.m_a8 = new TextBox();
		this.m_a2 = new CheckBox();
		this.m_a1 = new CheckBox();
		this.m_ax = new Panel();
		this.m_av = new CheckBox();
		this.m_ay = new RadioButton();
		this.m_az = new RadioButton();
		this.m_aw = new Button();
		this.m_a3 = new TabPage();
		bz = new Label();
		bt = new Button();
		bs = new Button();
		this.m_ai = new Label();
		this.m_aj = new Timer(this.m_a);
		this.m_a0 = new ImageList(this.m_a);
		this.m_bb = new NotifyIcon(this.m_a);
		this.m_bi = new ContextMenuStrip(this.m_a);
		br = new ToolStripMenuItem();
		ca = new ToolStripSeparator();
		b4 = new ToolStripMenuItem();
		b2 = new ToolStripMenuItem();
		b3 = new ToolStripMenuItem();
		b1 = new ToolStripMenuItem();
		cb = new ToolStripSeparator();
		this.m_bj = new ToolStripMenuItem();
		this.m_bg = new ToolTip(this.m_a);
		cj = new Label();
		b6 = new Timer(this.m_a);
		this.m_ag.SuspendLayout();
		this.m_d.SuspendLayout();
		this.m_e.SuspendLayout();
		((ISupportInitialize)bq).BeginInit();
		((ISupportInitialize)this.m_bd).BeginInit();
		((ISupportInitialize)this.m_be).BeginInit();
		((ISupportInitialize)this.m_a5).BeginInit();
		((ISupportInitialize)this.m_as).BeginInit();
		((ISupportInitialize)this.m_ap).BeginInit();
		((ISupportInitialize)this.m_ak).BeginInit();
		this.m_af.SuspendLayout();
		((ISupportInitialize)this.m_u).BeginInit();
		((ISupportInitialize)this.m_i).BeginInit();
		((ISupportInitialize)this.m_ae).BeginInit();
		((ISupportInitialize)this.m_k).BeginInit();
		((ISupportInitialize)this.m_ac).BeginInit();
		((ISupportInitialize)this.m_m).BeginInit();
		((ISupportInitialize)this.m_aa).BeginInit();
		((ISupportInitialize)this.m_o).BeginInit();
		((ISupportInitialize)this.m_y).BeginInit();
		((ISupportInitialize)this.m_q).BeginInit();
		((ISupportInitialize)this.m_w).BeginInit();
		((ISupportInitialize)this.m_s).BeginInit();
		this.m_f.SuspendLayout();
		this.m_a6.SuspendLayout();
		this.m_ax.SuspendLayout();
		this.m_a3.SuspendLayout();
		this.m_bi.SuspendLayout();
		SuspendLayout();
		this.m_b.CheckBoxes = true;
		this.m_b.Columns.AddRange(new ColumnHeader[6] { this.m_c, b7, b9, ch, b8, ce });
		this.m_b.ContextMenuStrip = this.m_ag;
		this.m_b.Dock = DockStyle.Top;
		this.m_b.FullRowSelect = true;
		this.m_b.GridLines = true;
		this.m_b.Location = new Point(0, 0);
		this.m_b.Name = "listViewGame";
		this.m_b.Size = new Size(199, 142);
		this.m_b.TabIndex = 1;
		this.m_b.UseCompatibleStateImageBehavior = false;
		this.m_b.View = View.Details;
		this.m_b.ItemChecked += a;
		this.m_b.SelectedIndexChanged += bo;
		this.m_b.KeyUp += a;
		this.m_c.Text = "Nhân Vật";
		this.m_c.Width = 90;
		b7.Text = "Máu";
		b7.Width = 40;
		b9.Text = "Pet";
		b9.Width = 40;
		ch.Text = "Captcha";
		b8.Text = "Khí";
		b8.Width = 40;
		ce.Text = "Bk";
		ce.Width = 40;
		this.m_ag.Items.AddRange(new ToolStripItem[12]
		{
			this.m_ah, ci, cc, this.m_at, this.m_au, this.m_bk, this.m_bl, by, b5, this.m_bm,
			cd, b0
		});
		this.m_ag.Name = "contextMenuStripListView";
		this.m_ag.Size = new Size(233, 220);
		this.m_ag.Opening += a;
		this.m_ah.Name = "lưuThiếtLậpToolStripMenuItem";
		this.m_ah.Size = new Size(232, 22);
		this.m_ah.Text = "Lưu Thiết Lập";
		this.m_ah.Click += ay;
		ci.Name = "lToolStripMenuItem";
		ci.ShortcutKeys = Keys.S | Keys.Control;
		ci.Size = new Size(232, 22);
		ci.Text = "Lưu toàn bộ thiết lập";
		ci.Click += a;
		cc.Name = "toolStripSeparator4";
		cc.Size = new Size(229, 6);
		this.m_at.Name = "ẩnGameToolStripMenuItem";
		this.m_at.Size = new Size(232, 22);
		this.m_at.Text = "Ẩn game (Page Down)";
		this.m_at.Click += at;
		this.m_au.Name = "hiệnGameToolStripMenuItem";
		this.m_au.Size = new Size(232, 22);
		this.m_au.Text = "Hiện game (Page Down)";
		this.m_au.Click += @as;
		this.m_bk.Name = "thoátGameToolStripMenuItem";
		this.m_bk.Size = new Size(232, 22);
		this.m_bk.Text = "Thoát game";
		this.m_bk.Click += u;
		this.m_bl.Name = "toolStripSeparator1";
		this.m_bl.Size = new Size(229, 6);
		by.Name = "bắtĐầuTạmDừngAutoToolStripMenuItem";
		by.Size = new Size(232, 22);
		by.Text = "Bắt đầu / tạm dừng auto (Pause)";
		by.Click += l;
		b5.Name = "ẩnAutoToolStripMenuItem";
		b5.Size = new Size(232, 22);
		b5.Text = "Ẩn auto (Page Up)";
		b5.Click += e;
		this.m_bm.Name = "resetAutoToolStripMenuItem";
		this.m_bm.Size = new Size(232, 22);
		this.m_bm.Text = "Reset auto";
		this.m_bm.Click += t;
		cd.Name = "toolStripSeparator5";
		cd.Size = new Size(229, 6);
		b0.Name = "tọaĐộTrainTạiĐâyToolStripMenuItem";
		b0.Size = new Size(232, 22);
		b0.Text = "Tọa độ train tại đây";
		b0.Click += j;
		this.m_d.Controls.Add(this.m_e);
		this.m_d.Controls.Add(this.m_f);
		this.m_d.Controls.Add(this.m_a3);
		this.m_d.Location = new Point(0, 141);
		this.m_d.Name = "tabControl1";
		this.m_d.SelectedIndex = 0;
		this.m_d.Size = new Size(199, 342);
		this.m_d.TabIndex = 2;
		this.m_e.Controls.Add(cg);
		this.m_e.Controls.Add(bq);
		this.m_e.Controls.Add(this.m_bp);
		this.m_e.Controls.Add(this.m_bc);
		this.m_e.Controls.Add(this.m_bd);
		this.m_e.Controls.Add(this.m_be);
		this.m_e.Controls.Add(this.m_bf);
		this.m_e.Controls.Add(this.m_a4);
		this.m_e.Controls.Add(this.m_a5);
		this.m_e.Controls.Add(this.m_aq);
		this.m_e.Controls.Add(this.m_ar);
		this.m_e.Controls.Add(this.m_as);
		this.m_e.Controls.Add(this.m_an);
		this.m_e.Controls.Add(this.m_ao);
		this.m_e.Controls.Add(this.m_ap);
		this.m_e.Controls.Add(this.m_am);
		this.m_e.Controls.Add(this.m_al);
		this.m_e.Controls.Add(this.m_ak);
		this.m_e.Controls.Add(this.m_af);
		this.m_e.Controls.Add(this.m_g);
		this.m_e.Location = new Point(4, 22);
		this.m_e.Name = "tabPageAcc";
		this.m_e.Padding = new Padding(3);
		this.m_e.Size = new Size(191, 316);
		this.m_e.TabIndex = 0;
		this.m_e.Text = "Nhân Vật";
		this.m_e.UseVisualStyleBackColor = true;
		cg.AutoSize = true;
		cg.Location = new Point(107, 6);
		cg.Name = "lure";
		cg.Size = new Size(67, 17);
		cg.TabIndex = 48;
		cg.Text = "Lùa quái";
		cg.UseVisualStyleBackColor = true;
		cg.CheckedChanged += b;
		bq.Enabled = false;
		bq.Location = new Point(8, 292);
		bq.Maximum = new decimal(new int[4] { 10000, 0, 0, 0 });
		bq.Name = "radiusValue";
		bq.Size = new Size(38, 20);
		bq.TabIndex = 43;
		bq.Value = new decimal(new int[4] { 20, 0, 0, 0 });
		bq.ValueChanged += r;
		this.m_bp.AutoSize = true;
		this.m_bp.Location = new Point(52, 293);
		this.m_bp.Name = "radius";
		this.m_bp.Size = new Size(70, 17);
		this.m_bp.TabIndex = 42;
		this.m_bp.Text = "Bán kính";
		this.m_bp.UseVisualStyleBackColor = true;
		this.m_bp.CheckedChanged += s;
		this.m_bc.AutoSize = true;
		this.m_bc.Location = new Point(126, 174);
		this.m_bc.Name = "label1";
		this.m_bc.Size = new Size(16, 13);
		this.m_bc.TabIndex = 41;
		this.m_bc.Text = "->";
		this.m_bd.Enabled = false;
		this.m_bd.Location = new Point(148, 172);
		this.m_bd.Maximum = new decimal(new int[4] { 1000, 0, 0, 0 });
		this.m_bd.Name = "onlyAttackFixHPMaxPercent";
		this.m_bd.Size = new Size(40, 20);
		this.m_bd.TabIndex = 40;
		this.m_bd.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_bd.ValueChanged += x;
		this.m_be.Enabled = false;
		this.m_be.Location = new Point(89, 172);
		this.m_be.Name = "onlyAttackFixHPMinPercent";
		this.m_be.Size = new Size(32, 20);
		this.m_be.TabIndex = 39;
		this.m_be.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_be.ValueChanged += y;
		this.m_bf.AutoSize = true;
		this.m_bf.Location = new Point(8, 175);
		this.m_bf.Name = "onlyAttackFixHP";
		this.m_bf.Size = new Size(75, 17);
		this.m_bf.TabIndex = 38;
		this.m_bf.Text = "Đánh quái";
		this.m_bg.SetToolTip(this.m_bf, "Chỉ đánh quái có máu trong khoảng");
		this.m_bf.UseVisualStyleBackColor = true;
		this.m_bf.CheckedChanged += w;
		this.m_a4.AutoSize = true;
		this.m_a4.Location = new Point(8, 273);
		this.m_a4.Name = "exitWhenHPLow";
		this.m_a4.Size = new Size(117, 17);
		this.m_a4.TabIndex = 37;
		this.m_a4.Text = "Thoát khi máu dưới";
		this.m_a4.UseVisualStyleBackColor = true;
		this.m_a4.CheckedChanged += af;
		this.m_a5.Enabled = false;
		this.m_a5.Location = new Point(131, 270);
		this.m_a5.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_a5.Name = "exitWhenHPLowPercent";
		this.m_a5.Size = new Size(44, 20);
		this.m_a5.TabIndex = 36;
		this.m_a5.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_a5.ValueChanged += ae;
		this.m_aq.AutoSize = true;
		this.m_aq.Location = new Point(8, 250);
		this.m_aq.Name = "buffMPEnable";
		this.m_aq.Size = new Size(43, 17);
		this.m_aq.TabIndex = 35;
		this.m_aq.Text = "Khí";
		this.m_aq.UseVisualStyleBackColor = true;
		this.m_aq.CheckedChanged += al;
		this.m_ar.DropDownStyle = ComboBoxStyle.DropDownList;
		this.m_ar.Enabled = false;
		this.m_ar.FormattingEnabled = true;
		this.m_ar.Items.AddRange(new object[12]
		{
			"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10",
			"F11", "F12"
		});
		this.m_ar.Location = new Point(106, 246);
		this.m_ar.Name = "buffMPKey";
		this.m_ar.Size = new Size(50, 21);
		this.m_ar.TabIndex = 34;
		this.m_ar.SelectedIndexChanged += ai;
		this.m_as.Enabled = false;
		this.m_as.Location = new Point(56, 247);
		this.m_as.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_as.Name = "buffMPPercent";
		this.m_as.Size = new Size(44, 20);
		this.m_as.TabIndex = 33;
		this.m_as.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_as.ValueChanged += an;
		this.m_an.AutoSize = true;
		this.m_an.Location = new Point(8, 224);
		this.m_an.Name = "buffHPEnable";
		this.m_an.Size = new Size(47, 17);
		this.m_an.TabIndex = 32;
		this.m_an.Text = "Máu";
		this.m_an.UseVisualStyleBackColor = true;
		this.m_an.CheckedChanged += am;
		this.m_ao.DropDownStyle = ComboBoxStyle.DropDownList;
		this.m_ao.Enabled = false;
		this.m_ao.FormattingEnabled = true;
		this.m_ao.Items.AddRange(new object[12]
		{
			"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10",
			"F11", "F12"
		});
		this.m_ao.Location = new Point(106, 220);
		this.m_ao.Name = "buffHPKey";
		this.m_ao.Size = new Size(50, 21);
		this.m_ao.TabIndex = 31;
		this.m_ao.SelectedIndexChanged += aj;
		this.m_ap.Enabled = false;
		this.m_ap.Location = new Point(56, 221);
		this.m_ap.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_ap.Name = "buffHPPercent";
		this.m_ap.Size = new Size(44, 20);
		this.m_ap.TabIndex = 30;
		this.m_ap.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_ap.ValueChanged += ak;
		this.m_am.AutoSize = true;
		this.m_am.Location = new Point(8, 198);
		this.m_am.Name = "buffPetEnable";
		this.m_am.Size = new Size(42, 17);
		this.m_am.TabIndex = 29;
		this.m_am.Text = "Pet";
		this.m_am.UseVisualStyleBackColor = true;
		this.m_am.CheckedChanged += aw;
		this.m_al.DropDownStyle = ComboBoxStyle.DropDownList;
		this.m_al.Enabled = false;
		this.m_al.FormattingEnabled = true;
		this.m_al.Items.AddRange(new object[12]
		{
			"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10",
			"F11", "F12"
		});
		this.m_al.Location = new Point(106, 194);
		this.m_al.Name = "buffPetKey";
		this.m_al.Size = new Size(50, 21);
		this.m_al.TabIndex = 28;
		this.m_al.SelectedIndexChanged += au;
		this.m_ak.Enabled = false;
		this.m_ak.Location = new Point(56, 195);
		this.m_ak.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_ak.Name = "buffPetPercent";
		this.m_ak.Size = new Size(44, 20);
		this.m_ak.TabIndex = 25;
		this.m_ak.Value = new decimal(new int[4] { 50, 0, 0, 0 });
		this.m_ak.ValueChanged += av;
		this.m_af.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
		this.m_af.Controls.Add(this.m_u);
		this.m_af.Controls.Add(this.m_h);
		this.m_af.Controls.Add(this.m_i);
		this.m_af.Controls.Add(this.m_ae);
		this.m_af.Controls.Add(this.m_j);
		this.m_af.Controls.Add(this.m_ad);
		this.m_af.Controls.Add(this.m_k);
		this.m_af.Controls.Add(this.m_ac);
		this.m_af.Controls.Add(this.m_l);
		this.m_af.Controls.Add(this.m_ab);
		this.m_af.Controls.Add(this.m_m);
		this.m_af.Controls.Add(this.m_aa);
		this.m_af.Controls.Add(this.m_n);
		this.m_af.Controls.Add(this.m_z);
		this.m_af.Controls.Add(this.m_o);
		this.m_af.Controls.Add(this.m_y);
		this.m_af.Controls.Add(this.m_p);
		this.m_af.Controls.Add(this.m_x);
		this.m_af.Controls.Add(this.m_q);
		this.m_af.Controls.Add(this.m_w);
		this.m_af.Controls.Add(this.m_r);
		this.m_af.Controls.Add(this.m_v);
		this.m_af.Controls.Add(this.m_s);
		this.m_af.Controls.Add(this.m_t);
		this.m_af.Enabled = false;
		this.m_af.Location = new Point(-4, 29);
		this.m_af.Name = "panelSkill";
		this.m_af.Size = new Size(198, 137);
		this.m_af.TabIndex = 26;
		this.m_u.Location = new Point(56, 117);
		this.m_u.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_u.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_u.Name = "f6Delay";
		this.m_u.Size = new Size(40, 20);
		this.m_u.TabIndex = 12;
		this.m_u.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_u.ValueChanged += a6;
		this.m_h.AutoSize = true;
		this.m_h.Location = new Point(12, 3);
		this.m_h.Name = "f1Enable";
		this.m_h.Size = new Size(38, 17);
		this.m_h.TabIndex = 1;
		this.m_h.Text = "F1";
		this.m_h.UseVisualStyleBackColor = true;
		this.m_h.CheckedChanged += bn;
		this.m_i.Location = new Point(146, 117);
		this.m_i.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_i.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_i.Name = "f12Delay";
		this.m_i.Size = new Size(40, 20);
		this.m_i.TabIndex = 24;
		this.m_i.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_i.ValueChanged += a0;
		this.m_ae.Location = new Point(56, 2);
		this.m_ae.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_ae.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_ae.Name = "f1Delay";
		this.m_ae.Size = new Size(40, 20);
		this.m_ae.TabIndex = 2;
		this.m_ae.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_ae.ValueChanged += bb;
		this.m_j.AutoSize = true;
		this.m_j.Location = new Point(102, 118);
		this.m_j.Name = "f12Enable";
		this.m_j.Size = new Size(44, 17);
		this.m_j.TabIndex = 23;
		this.m_j.Text = "F12";
		this.m_j.UseVisualStyleBackColor = true;
		this.m_j.CheckedChanged += bc;
		this.m_ad.AutoSize = true;
		this.m_ad.Location = new Point(12, 26);
		this.m_ad.Name = "f2Enable";
		this.m_ad.Size = new Size(38, 17);
		this.m_ad.TabIndex = 3;
		this.m_ad.Text = "F2";
		this.m_ad.UseVisualStyleBackColor = true;
		this.m_ad.CheckedChanged += bm;
		this.m_k.Location = new Point(146, 94);
		this.m_k.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_k.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_k.Name = "f11Delay";
		this.m_k.Size = new Size(40, 20);
		this.m_k.TabIndex = 22;
		this.m_k.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_k.ValueChanged += a1;
		this.m_ac.Location = new Point(56, 25);
		this.m_ac.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_ac.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_ac.Name = "f2Delay";
		this.m_ac.Size = new Size(40, 20);
		this.m_ac.TabIndex = 4;
		this.m_ac.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_ac.ValueChanged += ba;
		this.m_l.AutoSize = true;
		this.m_l.Location = new Point(102, 95);
		this.m_l.Name = "f11Enable";
		this.m_l.Size = new Size(44, 17);
		this.m_l.TabIndex = 21;
		this.m_l.Text = "F11";
		this.m_l.UseVisualStyleBackColor = true;
		this.m_l.CheckedChanged += bd;
		this.m_ab.AutoSize = true;
		this.m_ab.Location = new Point(12, 49);
		this.m_ab.Name = "f3Enable";
		this.m_ab.Size = new Size(38, 17);
		this.m_ab.TabIndex = 5;
		this.m_ab.Text = "F3";
		this.m_ab.UseVisualStyleBackColor = true;
		this.m_ab.CheckedChanged += bl;
		this.m_m.Location = new Point(146, 71);
		this.m_m.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_m.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_m.Name = "f10Delay";
		this.m_m.Size = new Size(40, 20);
		this.m_m.TabIndex = 20;
		this.m_m.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_m.ValueChanged += a2;
		this.m_aa.Location = new Point(56, 48);
		this.m_aa.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_aa.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_aa.Name = "f3Delay";
		this.m_aa.Size = new Size(40, 20);
		this.m_aa.TabIndex = 6;
		this.m_aa.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_aa.ValueChanged += a9;
		this.m_n.AutoSize = true;
		this.m_n.Location = new Point(102, 72);
		this.m_n.Name = "f10Enable";
		this.m_n.Size = new Size(44, 17);
		this.m_n.TabIndex = 19;
		this.m_n.Text = "F10";
		this.m_n.UseVisualStyleBackColor = true;
		this.m_n.CheckedChanged += be;
		this.m_z.AutoSize = true;
		this.m_z.Location = new Point(12, 72);
		this.m_z.Name = "f4Enable";
		this.m_z.Size = new Size(38, 17);
		this.m_z.TabIndex = 7;
		this.m_z.Text = "F4";
		this.m_z.UseVisualStyleBackColor = true;
		this.m_z.CheckedChanged += bk;
		this.m_o.Location = new Point(146, 48);
		this.m_o.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_o.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_o.Name = "f9Delay";
		this.m_o.Size = new Size(40, 20);
		this.m_o.TabIndex = 18;
		this.m_o.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_o.ValueChanged += a3;
		this.m_y.Location = new Point(56, 71);
		this.m_y.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_y.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_y.Name = "f4Delay";
		this.m_y.Size = new Size(40, 20);
		this.m_y.TabIndex = 8;
		this.m_y.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_y.ValueChanged += a8;
		this.m_p.AutoSize = true;
		this.m_p.Location = new Point(102, 49);
		this.m_p.Name = "f9Enable";
		this.m_p.Size = new Size(38, 17);
		this.m_p.TabIndex = 17;
		this.m_p.Text = "F9";
		this.m_p.UseVisualStyleBackColor = true;
		this.m_p.CheckedChanged += bf;
		this.m_x.AutoSize = true;
		this.m_x.Location = new Point(12, 95);
		this.m_x.Name = "f5Enable";
		this.m_x.Size = new Size(38, 17);
		this.m_x.TabIndex = 9;
		this.m_x.Text = "F5";
		this.m_x.UseVisualStyleBackColor = true;
		this.m_x.CheckedChanged += bj;
		this.m_q.Location = new Point(146, 25);
		this.m_q.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_q.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_q.Name = "f8Delay";
		this.m_q.Size = new Size(40, 20);
		this.m_q.TabIndex = 16;
		this.m_q.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_q.ValueChanged += a4;
		this.m_w.Location = new Point(56, 94);
		this.m_w.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_w.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_w.Name = "f5Delay";
		this.m_w.Size = new Size(40, 20);
		this.m_w.TabIndex = 10;
		this.m_w.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_w.ValueChanged += a7;
		this.m_r.AutoSize = true;
		this.m_r.Location = new Point(102, 26);
		this.m_r.Name = "f8Enable";
		this.m_r.Size = new Size(38, 17);
		this.m_r.TabIndex = 15;
		this.m_r.Text = "F8";
		this.m_r.UseVisualStyleBackColor = true;
		this.m_r.CheckedChanged += bg;
		this.m_v.AutoSize = true;
		this.m_v.Location = new Point(12, 118);
		this.m_v.Name = "f6Enable";
		this.m_v.Size = new Size(38, 17);
		this.m_v.TabIndex = 11;
		this.m_v.Text = "F6";
		this.m_v.UseVisualStyleBackColor = true;
		this.m_v.CheckedChanged += bi;
		this.m_s.Location = new Point(146, 0);
		this.m_s.Maximum = new decimal(new int[4] { 100000, 0, 0, 0 });
		this.m_s.Minimum = new decimal(new int[4] { 1, 0, 0, 0 });
		this.m_s.Name = "f7Delay";
		this.m_s.Size = new Size(40, 20);
		this.m_s.TabIndex = 14;
		this.m_s.Value = new decimal(new int[4] { 10, 0, 0, 0 });
		this.m_s.ValueChanged += a5;
		this.m_t.AutoSize = true;
		this.m_t.Location = new Point(102, 1);
		this.m_t.Name = "f7Enable";
		this.m_t.Size = new Size(38, 17);
		this.m_t.TabIndex = 13;
		this.m_t.Text = "F7";
		this.m_t.UseVisualStyleBackColor = true;
		this.m_t.CheckedChanged += bh;
		this.m_g.AccessibleRole = AccessibleRole.None;
		this.m_g.AutoSize = true;
		this.m_g.Location = new Point(8, 6);
		this.m_g.Name = "isSkill";
		this.m_g.Size = new Size(93, 17);
		this.m_g.TabIndex = 0;
		this.m_g.Text = "Dùng kĩ năng";
		this.m_g.UseVisualStyleBackColor = true;
		this.m_g.CheckedChanged += az;
		this.m_f.Controls.Add(bu);
		this.m_f.Controls.Add(bv);
		this.m_f.Controls.Add(bw);
		this.m_f.Controls.Add(bx);
		this.m_f.Controls.Add(this.m_bo);
		this.m_f.Controls.Add(this.m_bn);
		this.m_f.Controls.Add(this.m_bh);
		this.m_f.Controls.Add(this.m_a6);
		this.m_f.Controls.Add(this.m_a2);
		this.m_f.Controls.Add(this.m_a1);
		this.m_f.Controls.Add(this.m_ax);
		this.m_f.Controls.Add(this.m_aw);
		this.m_f.Location = new Point(4, 22);
		this.m_f.Name = "tabPageConfig";
		this.m_f.Padding = new Padding(3);
		this.m_f.Size = new Size(191, 316);
		this.m_f.TabIndex = 1;
		this.m_f.Text = "Tùy Chọn";
		this.m_f.UseVisualStyleBackColor = true;
		bu.AutoSize = true;
		bu.Location = new Point(4, 77);
		bu.Name = "label4";
		bu.Size = new Size(113, 13);
		bu.TabIndex = 47;
		bu.Text = "Phím chuyển mục tiêu";
		bv.AutoSize = true;
		bv.Location = new Point(6, 50);
		bv.Name = "label3";
		bv.Size = new Size(109, 13);
		bv.TabIndex = 46;
		bv.Text = "Phím kĩ năng cơ bản";
		bw.DropDownStyle = ComboBoxStyle.DropDownList;
		bw.FormattingEnabled = true;
		bw.Items.AddRange(new object[12]
		{
			"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10",
			"F11", "F12"
		});
		bw.Location = new Point(121, 74);
		bw.Name = "targetKey";
		bw.Size = new Size(50, 21);
		bw.TabIndex = 45;
		bw.SelectedIndexChanged += m;
		bx.DropDownStyle = ComboBoxStyle.DropDownList;
		bx.FormattingEnabled = true;
		bx.Items.AddRange(new object[12]
		{
			"F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10",
			"F11", "F12"
		});
		bx.Location = new Point(121, 47);
		bx.Name = "baseSkill";
		bx.Size = new Size(50, 21);
		bx.TabIndex = 44;
		bx.SelectedIndexChanged += n;
		this.m_bo.AutoSize = true;
		this.m_bo.Location = new Point(6, 300);
		this.m_bo.Name = "label2";
		this.m_bo.Size = new Size(168, 13);
		this.m_bo.TabIndex = 8;
		this.m_bo.Text = "Ym liên hệ: tieudattai@yahoo.com";
		this.m_bn.AutoSize = true;
		this.m_bn.Location = new Point(6, 261);
		this.m_bn.Name = "linkLabel1";
		this.m_bn.Size = new Size(180, 39);
		this.m_bn.TabIndex = 7;
		this.m_bn.TabStop = true;
		this.m_bn.Text = "Bản quyền thuộc về Vipautopro.com\r\nDownload phiên bản mới nhất tại \r\ntrang chủ Vipautopro.com";
		this.m_bn.LinkClicked += a;
		this.m_bh.Location = new Point(6, 231);
		this.m_bh.MinimumSize = new Size(20, 20);
		this.m_bh.Name = "webBrowser1";
		this.m_bh.ScriptErrorsSuppressed = true;
		this.m_bh.Size = new Size(93, 27);
		this.m_bh.TabIndex = 6;
		this.m_bh.Visible = false;
		this.m_a6.Controls.Add(cf);
		this.m_a6.Controls.Add(this.m_a9);
		this.m_a6.Controls.Add(this.m_ba);
		this.m_a6.Controls.Add(this.m_a7);
		this.m_a6.Controls.Add(this.m_a8);
		this.m_a6.Location = new Point(7, 101);
		this.m_a6.Name = "groupBox1";
		this.m_a6.Size = new Size(178, 72);
		this.m_a6.TabIndex = 5;
		this.m_a6.TabStop = false;
		this.m_a6.Text = "File nhạc khi cảnh báo";
		cf.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 163);
		cf.ForeColor = SystemColors.AppWorkspace;
		cf.Location = new Point(111, 45);
		cf.Name = "testAlarm";
		cf.Size = new Size(29, 20);
		cf.TabIndex = 7;
		cf.Text = "?";
		cf.UseVisualStyleBackColor = true;
		cf.Click += c;
		this.m_a9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 163);
		this.m_a9.ForeColor = SystemColors.AppWorkspace;
		this.m_a9.Location = new Point(76, 45);
		this.m_a9.Name = "stopMusic";
		this.m_a9.Size = new Size(29, 20);
		this.m_a9.TabIndex = 6;
		this.m_a9.Text = "\u007f";
		this.m_a9.UseVisualStyleBackColor = true;
		this.m_a9.Click += ab;
		this.m_ba.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 163);
		this.m_ba.ForeColor = Color.FromArgb(0, 192, 0);
		this.m_ba.Location = new Point(41, 45);
		this.m_ba.Name = "playMusic";
		this.m_ba.Size = new Size(29, 20);
		this.m_ba.TabIndex = 2;
		this.m_ba.Text = ">";
		this.m_ba.UseVisualStyleBackColor = true;
		this.m_ba.Click += ac;
		this.m_a7.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, 163);
		this.m_a7.Location = new Point(6, 45);
		this.m_a7.Name = "openMusic";
		this.m_a7.Size = new Size(29, 20);
		this.m_a7.TabIndex = 1;
		this.m_a7.Text = "...";
		this.m_a7.UseVisualStyleBackColor = true;
		this.m_a7.Click += ad;
		this.m_a8.Location = new Point(6, 19);
		this.m_a8.Name = "musicPath";
		this.m_a8.Size = new Size(166, 20);
		this.m_a8.TabIndex = 0;
		this.m_a8.TextChanged += aa;
		this.m_a2.AutoSize = true;
		this.m_a2.Location = new Point(6, 30);
		this.m_a2.Name = "shutdownAfterKill";
		this.m_a2.Size = new Size(157, 17);
		this.m_a2.TabIndex = 4;
		this.m_a2.Text = "Tắt máy sau khi thoát game";
		this.m_a2.UseVisualStyleBackColor = true;
		this.m_a2.CheckedChanged += ag;
		this.m_a1.AutoSize = true;
		this.m_a1.Location = new Point(7, 7);
		this.m_a1.Name = "topMost";
		this.m_a1.Size = new Size(80, 17);
		this.m_a1.TabIndex = 3;
		this.m_a1.Text = "Luôn ở trên";
		this.m_a1.UseVisualStyleBackColor = true;
		this.m_a1.CheckedChanged += ah;
		this.m_ax.Controls.Add(this.m_av);
		this.m_ax.Controls.Add(this.m_ay);
		this.m_ax.Controls.Add(this.m_az);
		this.m_ax.Location = new Point(105, 189);
		this.m_ax.Name = "panel1";
		this.m_ax.Size = new Size(83, 69);
		this.m_ax.TabIndex = 2;
		this.m_ax.Visible = false;
		this.m_av.AutoSize = true;
		this.m_av.Location = new Point(3, 3);
		this.m_av.Name = "farmEnable";
		this.m_av.Size = new Size(90, 17);
		this.m_av.TabIndex = 36;
		this.m_av.Text = "Thương nhân";
		this.m_av.UseVisualStyleBackColor = true;
		this.m_av.CheckedChanged += aq;
		this.m_ay.AutoSize = true;
		this.m_ay.Location = new Point(3, 49);
		this.m_ay.Name = "farmBack";
		this.m_ay.Size = new Size(38, 17);
		this.m_ay.TabIndex = 1;
		this.m_ay.TabStop = true;
		this.m_ay.Text = "Về";
		this.m_ay.UseVisualStyleBackColor = true;
		this.m_ay.CheckedChanged += ao;
		this.m_az.AutoSize = true;
		this.m_az.Location = new Point(3, 26);
		this.m_az.Name = "farmGo";
		this.m_az.Size = new Size(35, 17);
		this.m_az.TabIndex = 0;
		this.m_az.TabStop = true;
		this.m_az.Text = "Đi";
		this.m_az.UseVisualStyleBackColor = true;
		this.m_az.CheckedChanged += ap;
		this.m_aw.Location = new Point(3, 186);
		this.m_aw.Name = "button1";
		this.m_aw.Size = new Size(75, 23);
		this.m_aw.TabIndex = 1;
		this.m_aw.Text = "button1";
		this.m_aw.UseVisualStyleBackColor = true;
		this.m_aw.Visible = false;
		this.m_aw.Click += ar;
		this.m_a3.Controls.Add(bz);
		this.m_a3.Controls.Add(bt);
		this.m_a3.Controls.Add(bs);
		this.m_a3.Controls.Add(this.m_ai);
		this.m_a3.Location = new Point(4, 22);
		this.m_a3.Name = "tabPageInfo";
		this.m_a3.Size = new Size(191, 316);
		this.m_a3.TabIndex = 2;
		this.m_a3.Text = "Thông Tin";
		this.m_a3.UseVisualStyleBackColor = true;
		this.m_a3.Enter += k;
		bz.AutoSize = true;
		bz.Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold, GraphicsUnit.Point, 163);
		bz.ForeColor = Color.OrangeRed;
		bz.Location = new Point(8, 10);
		bz.Name = "charName";
		bz.Size = new Size(73, 17);
		bz.TabIndex = 3;
		bz.Text = "Nhân vật";
		bt.Location = new Point(3, 256);
		bt.Name = "resetExpCaculator";
		bt.Size = new Size(185, 23);
		bt.TabIndex = 2;
		bt.Text = "Tính lại tốc độ luyện cấp";
		bt.UseVisualStyleBackColor = true;
		bt.Click += o;
		bs.Location = new Point(3, 285);
		bs.Name = "enterExpMax";
		bs.Size = new Size(185, 23);
		bs.TabIndex = 1;
		bs.Text = "Nhập vào Exp cần để thăng cấp";
		bs.UseVisualStyleBackColor = true;
		bs.Click += p;
		this.m_ai.AutoSize = true;
		this.m_ai.Location = new Point(8, 35);
		this.m_ai.Name = "info";
		this.m_ai.Size = new Size(104, 13);
		this.m_ai.TabIndex = 0;
		this.m_ai.Text = "Chưa chọn nhân vật";
		this.m_aj.Enabled = true;
		this.m_aj.Interval = 1000;
		this.m_aj.Tick += ax;
		this.m_a0.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList1.ImageStream");
		this.m_a0.TransparentColor = Color.Transparent;
		this.m_a0.Images.SetKeyName(0, "dragon.ico");
		this.m_a0.Images.SetKeyName(1, "dragonPause.ico");
		this.m_bb.ContextMenuStrip = this.m_bi;
		this.m_bb.Text = "MicroAuto";
		this.m_bb.Visible = true;
		this.m_bb.MouseClick += b;
		this.m_bi.Items.AddRange(new ToolStripItem[8] { br, ca, b4, b2, b3, b1, cb, this.m_bj });
		this.m_bi.Name = "contextMenuStripNotifyIcon";
		this.m_bi.Size = new Size(213, 148);
		br.Name = "bắtĐầuDừngAutoToolStripMenuItem";
		br.Size = new Size(212, 22);
		br.Text = "Bắt Đầu/ Tạm dừng auto";
		br.Click += q;
		ca.Name = "toolStripSeparator2";
		ca.Size = new Size(209, 6);
		b4.Name = "lưuToànBộThiếtLậpToolStripMenuItem";
		b4.ShortcutKeys = Keys.S | Keys.Control;
		b4.Size = new Size(212, 22);
		b4.Text = "Lưu toàn bộ thiết lập";
		b4.Click += f;
		b2.Name = "hiệnToànBộGameToolStripMenuItem";
		b2.Size = new Size(212, 22);
		b2.Text = "Hiện toàn bộ game";
		b2.Click += g;
		b3.Name = "ẩnToànBộGameToolStripMenuItem";
		b3.Size = new Size(212, 22);
		b3.Text = "Ẩn toàn bộ game";
		b3.Click += h;
		b1.Name = "tọaĐộTrainTạiĐâyToolStripMenuItem1";
		b1.Size = new Size(212, 22);
		b1.Text = "Tọa độ train tại đây";
		b1.Click += i;
		cb.Name = "toolStripSeparator3";
		cb.Size = new Size(209, 6);
		this.m_bj.Name = "thoátToolStripMenuItem";
		this.m_bj.Size = new Size(212, 22);
		this.m_bj.Text = "Thoát";
		this.m_bj.Click += v;
		cj.AutoSize = true;
		cj.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 163);
		cj.ForeColor = Color.Red;
		cj.Location = new Point(5, 484);
		cj.Name = "label5";
		cj.Size = new Size(193, 26);
		cj.TabIndex = 3;
		cj.Text = "Click tại đây để ủng hộ auto \r\nngày một hoàn thiện và miễn phí";
		this.m_bg.SetToolTip(cj, "Để auto ngày một phát triển, thỉnh thoảng bạn nên click tại đây,\r\nRất mong được sự ủng hộ của tất cả mọi người sử dụng auto.");
		cj.MouseClick += a;
		b6.Enabled = true;
		b6.Interval = 1000;
		b6.Tick += d;
		base.AutoScaleDimensions = new SizeF(6f, 13f);
		base.AutoScaleMode = AutoScaleMode.Font;
		BackColor = Color.White;
		base.ClientSize = new Size(199, 512);
		base.Controls.Add(cj);
		base.Controls.Add(this.m_b);
		base.Controls.Add(this.m_d);
		base.FormBorderStyle = FormBorderStyle.Fixed3D;
		base.MaximizeBox = false;
		base.Name = "FormMain";
		Text = "MicroAuto 6.9";
		base.Load += bp;
		base.FormClosing += a;
		base.Resize += z;
		this.m_ag.ResumeLayout(performLayout: false);
		this.m_d.ResumeLayout(performLayout: false);
		this.m_e.ResumeLayout(performLayout: false);
		this.m_e.PerformLayout();
		((ISupportInitialize)bq).EndInit();
		((ISupportInitialize)this.m_bd).EndInit();
		((ISupportInitialize)this.m_be).EndInit();
		((ISupportInitialize)this.m_a5).EndInit();
		((ISupportInitialize)this.m_as).EndInit();
		((ISupportInitialize)this.m_ap).EndInit();
		((ISupportInitialize)this.m_ak).EndInit();
		this.m_af.ResumeLayout(performLayout: false);
		this.m_af.PerformLayout();
		((ISupportInitialize)this.m_u).EndInit();
		((ISupportInitialize)this.m_i).EndInit();
		((ISupportInitialize)this.m_ae).EndInit();
		((ISupportInitialize)this.m_k).EndInit();
		((ISupportInitialize)this.m_ac).EndInit();
		((ISupportInitialize)this.m_m).EndInit();
		((ISupportInitialize)this.m_aa).EndInit();
		((ISupportInitialize)this.m_o).EndInit();
		((ISupportInitialize)this.m_y).EndInit();
		((ISupportInitialize)this.m_q).EndInit();
		((ISupportInitialize)this.m_w).EndInit();
		((ISupportInitialize)this.m_s).EndInit();
		this.m_f.ResumeLayout(performLayout: false);
		this.m_f.PerformLayout();
		this.m_a6.ResumeLayout(performLayout: false);
		this.m_a6.PerformLayout();
		this.m_ax.ResumeLayout(performLayout: false);
		this.m_ax.PerformLayout();
		this.m_a3.ResumeLayout(performLayout: false);
		this.m_a3.PerformLayout();
		this.m_bi.ResumeLayout(performLayout: false);
		ResumeLayout(performLayout: false);
		PerformLayout();
	}

	public u()
	{
		h();
	}

	private void b(object A_0, KeyEventArgs A_1)
	{
		Dictionary<int, q>.ValueCollection.Enumerator enumerator2 = default(Dictionary<int, q>.ValueCollection.Enumerator);
		q current2 = default(q);
		Dictionary<int, q>.ValueCollection.Enumerator enumerator3 = default(Dictionary<int, q>.ValueCollection.Enumerator);
		q current = default(q);
		IEnumerator enumerator = default(IEnumerator);
		ListViewItem listViewItem = default(ListViewItem);
		while (true)
		{
			Keys keyCode = A_1.KeyCode;
			int num = 6;
			while (true)
			{
				switch (num)
				{
				case 6:
					if (keyCode != Keys.Pause)
					{
						num = 5;
						continue;
					}
					g();
					return;
				case 3:
					num = 1;
					continue;
				case 1:
					if (keyCode == Keys.Insert)
					{
						enumerator2 = cl.Values.GetEnumerator();
						num = 7;
					}
					else
					{
						num = 0;
					}
					continue;
				case 0:
					return;
				case 4:
					try
					{
						num = 6;
						while (true)
						{
							switch (num)
							{
							case 4:
								current2.v();
								num = 3;
								break;
							case 0:
								if (global::n.GetForegroundWindow() == current2.av)
								{
									num = 4;
									break;
								}
								goto default;
							default:
								num = 2;
								break;
							case 2:
								if (enumerator3.MoveNext())
								{
									current2 = enumerator3.Current;
									num = 0;
								}
								else
								{
									num = 1;
								}
								break;
							case 1:
								num = 5;
								break;
							case 5:
								return;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator3).Dispose();
					}
				case 5:
					num = 2;
					continue;
				case 2:
					switch (keyCode)
					{
					default:
						num = 3;
						break;
					case Keys.Next:
						enumerator3 = cl.Values.GetEnumerator();
						num = 4;
						break;
					case Keys.Prior:
						if (true)
						{
						}
						i();
						return;
					}
					continue;
				case 7:
					try
					{
						num = 5;
						while (true)
						{
							switch (num)
							{
							case 2:
								if (global::n.GetForegroundWindow() == current.av)
								{
									num = 6;
									break;
								}
								goto default;
							case 6:
								enumerator = this.m_b.Items.GetEnumerator();
								num = 3;
								break;
							default:
								num = 1;
								break;
							case 1:
								if (enumerator2.MoveNext())
								{
									current = enumerator2.Current;
									num = 2;
								}
								else
								{
									num = 4;
								}
								break;
							case 3:
								try
								{
									num = 5;
									while (true)
									{
										switch (num)
										{
										case 6:
											listViewItem.Checked = !listViewItem.Checked;
											current.a(listViewItem.Checked);
											current.g();
											k();
											num = 0;
											continue;
										default:
											num = 1;
											continue;
										case 1:
											if (!enumerator.MoveNext())
											{
												num = 4;
												continue;
											}
											listViewItem = (ListViewItem)enumerator.Current;
											num = 3;
											continue;
										case 3:
											if ((int)listViewItem.Tag == current.at)
											{
												num = 6;
												continue;
											}
											goto default;
										case 4:
											num = 2;
											continue;
										case 2:
											break;
										}
										break;
									}
								}
								finally
								{
									while (true)
									{
										IL_0368:
										IDisposable disposable = enumerator as IDisposable;
										num = 1;
										while (true)
										{
											switch (num)
											{
											case 1:
												if (disposable != null)
												{
													num = 2;
													continue;
												}
												goto end_IL_0353;
											case 2:
												disposable.Dispose();
												num = 0;
												continue;
											case 0:
												goto end_IL_0353;
											}
											goto IL_0368;
											continue;
											end_IL_0353:
											break;
										}
										break;
									}
								}
								goto default;
							case 4:
								num = 0;
								break;
							case 0:
								return;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
					}
				}
				break;
			}
		}
	}

	public void a(int A_0)
	{
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 1;
					break;
				}
				return;
			case 0:
				this.m_bf.Enabled = cl[A_0].d;
				this.m_be.Enabled = cl[A_0].d;
				this.m_bd.Enabled = cl[A_0].d;
				num = 2;
				break;
			case 2:
				return;
			case 5:
				num = 3;
				break;
			case 3:
				if (cl.ContainsKey(A_0))
				{
					num = 0;
					break;
				}
				return;
			case 1:
				num = 6;
				break;
			case 6:
				if ((int)this.m_e.Tag == A_0)
				{
					if (true)
					{
					}
					num = 5;
					break;
				}
				return;
			}
		}
	}

	public void k()
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 3;
					break;
				}
				return;
			case 4:
				this.m_g.Checked = cl[(int)this.m_e.Tag].u();
				this.m_h.Checked = cl[(int)this.m_e.Tag].az.Enabled;
				this.m_ad.Checked = cl[(int)this.m_e.Tag].a0.Enabled;
				this.m_ab.Checked = cl[(int)this.m_e.Tag].a1.Enabled;
				this.m_z.Checked = cl[(int)this.m_e.Tag].a2.Enabled;
				this.m_x.Checked = cl[(int)this.m_e.Tag].a3.Enabled;
				this.m_v.Checked = cl[(int)this.m_e.Tag].a4.Enabled;
				this.m_t.Checked = cl[(int)this.m_e.Tag].a5.Enabled;
				this.m_r.Checked = cl[(int)this.m_e.Tag].a6.Enabled;
				this.m_p.Checked = cl[(int)this.m_e.Tag].a7.Enabled;
				this.m_n.Checked = cl[(int)this.m_e.Tag].a8.Enabled;
				this.m_l.Checked = cl[(int)this.m_e.Tag].a9.Enabled;
				this.m_j.Checked = cl[(int)this.m_e.Tag].ba.Enabled;
				this.m_ae.Value = cl[(int)this.m_e.Tag].az.Interval / 100;
				this.m_ac.Value = cl[(int)this.m_e.Tag].a0.Interval / 100;
				this.m_aa.Value = cl[(int)this.m_e.Tag].a1.Interval / 100;
				this.m_y.Value = cl[(int)this.m_e.Tag].a2.Interval / 100;
				this.m_w.Value = cl[(int)this.m_e.Tag].a3.Interval / 100;
				this.m_u.Value = cl[(int)this.m_e.Tag].a4.Interval / 100;
				this.m_s.Value = cl[(int)this.m_e.Tag].a5.Interval / 100;
				this.m_q.Value = cl[(int)this.m_e.Tag].a6.Interval / 100;
				this.m_o.Value = cl[(int)this.m_e.Tag].a7.Interval / 100;
				this.m_m.Value = cl[(int)this.m_e.Tag].a8.Interval / 100;
				this.m_k.Value = cl[(int)this.m_e.Tag].a9.Interval / 100;
				this.m_i.Value = cl[(int)this.m_e.Tag].ba.Interval / 100;
				this.m_am.Checked = cl[(int)this.m_e.Tag].bc.Enabled;
				this.m_ak.Value = cl[(int)this.m_e.Tag].p;
				this.m_al.SelectedIndex = this.m_al.FindString(cl[(int)this.m_e.Tag].l);
				this.m_an.Checked = cl[(int)this.m_e.Tag].bd.Enabled;
				this.m_ap.Value = cl[(int)this.m_e.Tag].q;
				this.m_ao.SelectedIndex = this.m_ao.FindString(cl[(int)this.m_e.Tag].n);
				this.m_aq.Checked = cl[(int)this.m_e.Tag].be.Enabled;
				this.m_as.Value = cl[(int)this.m_e.Tag].r;
				this.m_ar.SelectedIndex = this.m_ar.FindString(cl[(int)this.m_e.Tag].o);
				this.m_a5.Value = cl[(int)this.m_e.Tag].x;
				this.m_bf.Checked = cl[(int)this.m_e.Tag].e;
				this.m_be.Value = cl[(int)this.m_e.Tag].v;
				this.m_bd.Value = cl[(int)this.m_e.Tag].w;
				this.m_bf.Enabled = cl[(int)this.m_e.Tag].d;
				this.m_be.Enabled = cl[(int)this.m_e.Tag].d;
				this.m_bd.Enabled = cl[(int)this.m_e.Tag].d;
				this.m_bp.Checked = cl[(int)this.m_e.Tag].y;
				bq.Value = cl[(int)this.m_e.Tag].s;
				this.m_bp.Text = a().n();
				bx.SelectedIndex = bx.FindString(cl[(int)this.m_e.Tag].k);
				bw.SelectedIndex = bx.FindString(cl[(int)this.m_e.Tag].m);
				cg.Checked = a().i;
				num = 2;
				break;
			case 2:
				return;
			case 3:
				if (true)
				{
				}
				num = 0;
				break;
			case 0:
				if (cl.ContainsKey((int)this.m_e.Tag))
				{
					num = 4;
					break;
				}
				return;
			}
		}
	}

	public void j()
	{
		int num = 1;
		Dictionary<int, q>.Enumerator enumerator = default(Dictionary<int, q>.Enumerator);
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 3;
					break;
				}
				goto case 5;
			case 3:
				if (true)
				{
				}
				num = 4;
				break;
			case 2:
				try
				{
					num = 3;
					while (true)
					{
						switch (num)
						{
						default:
							num = 2;
							break;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = 0;
								break;
							}
							int key = enumerator.Current.Key;
							ListViewItem listViewItem = new ListViewItem();
							listViewItem.Tag = key;
							listViewItem.Checked = cl[key].bb.Enabled;
							listViewItem.SubItems.Add("");
							listViewItem.SubItems.Add("");
							listViewItem.SubItems.Add("");
							listViewItem.SubItems.Add("");
							listViewItem.SubItems.Add("");
							listViewItem.SubItems.Add("");
							listViewItem.SubItems[0].Name = "acc";
							listViewItem.SubItems[1].Name = "hp";
							listViewItem.SubItems[2].Name = "pet";
							listViewItem.SubItems[3].Name = "captcha";
							listViewItem.SubItems[4].Name = "mp";
							listViewItem.SubItems[5].Name = "bk";
							listViewItem.ForeColor = Color.White;
							listViewItem.UseItemStyleForSubItems = false;
							this.m_b.Items.Add(listViewItem);
							num = 1;
							break;
						}
						case 0:
							num = 4;
							break;
						case 4:
							return;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
				}
			case 5:
				this.m_b.Items.Clear();
				enumerator = cl.GetEnumerator();
				num = 2;
				break;
			case 4:
				if (!cl.ContainsKey((int)this.m_e.Tag))
				{
					num = 0;
					break;
				}
				goto case 5;
			case 0:
				this.m_e.Tag = null;
				num = 5;
				break;
			}
		}
	}

	public void l()
	{
		int key = default(int);
		int num4 = default(int);
		int num8 = default(int);
		int num7 = default(int);
		int num6 = default(int);
		int num5 = default(int);
		int num3 = default(int);
		string text = default(string);
		while (true)
		{
			int num = 0;
			int num2 = 8;
			while (true)
			{
				switch (num2)
				{
				case 15:
				case 31:
					num2 = 18;
					continue;
				case 18:
					if (!cl[key].y)
					{
						this.m_b.Items[num].SubItems["bk"].Text = "0";
						this.m_b.Items[num].SubItems["bk"].BackColor = Color.Green;
						num2 = 21;
					}
					else
					{
						num2 = 27;
					}
					continue;
				case 9:
				case 11:
					num2 = 14;
					continue;
				case 14:
					if (num4 > 30)
					{
						num2 = 5;
						continue;
					}
					this.m_b.Items[num].SubItems["hp"].BackColor = Color.Red;
					num2 = 24;
					continue;
				case 34:
					this.m_b.Items[num].SubItems["acc"].BackColor = Color.Orange;
					num2 = 9;
					continue;
				case 3:
				case 12:
				case 32:
				case 33:
					num++;
					if (true)
					{
					}
					num2 = 0;
					continue;
				case 0:
				case 8:
					num2 = 29;
					continue;
				case 29:
					if (num >= this.m_b.Items.Count)
					{
						num2 = 28;
						continue;
					}
					key = (int)this.m_b.Items[num].Tag;
					num2 = 17;
					continue;
				case 28:
					return;
				case 17:
					if (cl.ContainsKey(key))
					{
						num2 = 20;
						continue;
					}
					goto case 3;
				case 5:
					this.m_b.Items[num].SubItems["hp"].BackColor = Color.Green;
					num2 = 1;
					continue;
				case 16:
					this.m_b.Items[num].SubItems["pet"].BackColor = Color.Green;
					num2 = 4;
					continue;
				case 10:
				case 21:
				case 30:
					this.m_b.Items[num].SubItems["captcha"].Text = cl[key].aw();
					num8 = num7;
					num2 = 23;
					continue;
				case 23:
					switch (num8)
					{
					case 1:
						this.m_b.Items[num].SubItems["captcha"].BackColor = Color.Green;
						num2 = 33;
						break;
					case 2:
						this.m_b.Items[num].SubItems["captcha"].BackColor = Color.Orange;
						num2 = 3;
						break;
					case 3:
						this.m_b.Items[num].SubItems["captcha"].BackColor = Color.Red;
						num2 = 32;
						break;
					default:
						num2 = 13;
						break;
					}
					continue;
				case 4:
				case 22:
					num2 = 26;
					continue;
				case 26:
					if (num6 <= 10)
					{
						this.m_b.Items[num].SubItems["mp"].BackColor = Color.Red;
						num2 = 15;
					}
					else
					{
						num2 = 7;
					}
					continue;
				case 7:
					this.m_b.Items[num].SubItems["mp"].BackColor = Color.Green;
					num2 = 31;
					continue;
				case 2:
					this.m_b.Items[num].SubItems["bk"].BackColor = Color.Red;
					num2 = 10;
					continue;
				case 1:
				case 24:
					num2 = 19;
					continue;
				case 19:
					if (num5 <= 30)
					{
						this.m_b.Items[num].SubItems["pet"].BackColor = Color.Red;
						num2 = 22;
					}
					else
					{
						num2 = 16;
					}
					continue;
				case 20:
					num4 = cl[key].i();
					num5 = cl[key].a4();
					num6 = cl[key].al();
					num3 = cl[key].l();
					num7 = cl[key].aq();
					text = cl[key].ak();
					this.m_b.Items[num].SubItems["acc"].Text = cl[key].ak();
					this.m_b.Items[num].SubItems["hp"].Text = num4 + "%";
					this.m_b.Items[num].SubItems["pet"].Text = num5 + "%";
					this.m_b.Items[num].SubItems["mp"].Text = num6 + "%";
					this.m_b.Items[num].SubItems["hp"].ForeColor = Color.White;
					this.m_b.Items[num].SubItems["pet"].ForeColor = Color.White;
					this.m_b.Items[num].SubItems["mp"].ForeColor = Color.White;
					this.m_b.Items[num].SubItems["bk"].ForeColor = Color.White;
					this.m_b.Items[num].SubItems["captcha"].ForeColor = Color.White;
					num2 = 6;
					continue;
				case 6:
					if (!(text == "Đăng nhập"))
					{
						this.m_b.Items[num].SubItems["acc"].BackColor = Color.Green;
						num2 = 11;
					}
					else
					{
						num2 = 34;
					}
					continue;
				case 13:
					num2 = 12;
					continue;
				case 27:
					this.m_b.Items[num].SubItems["bk"].Text = num3.ToString();
					num2 = 25;
					continue;
				case 25:
					if (num3 <= cl[key].s)
					{
						this.m_b.Items[num].SubItems["bk"].BackColor = Color.Orange;
						num2 = 30;
					}
					else
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	public void b(int A_0)
	{
		while (true)
		{
			int num = 0;
			int num2 = 5;
			while (true)
			{
				switch (num2)
				{
				case 1:
					num++;
					num2 = 3;
					continue;
				case 2:
					this.m_b.Items[num].SubItems["acc"].Text = cl[A_0].ak();
					num2 = 1;
					continue;
				case 4:
					if (cl.ContainsKey(A_0))
					{
						num2 = 6;
						continue;
					}
					goto case 1;
				case 6:
					if (true)
					{
					}
					num2 = 0;
					continue;
				case 3:
				case 5:
					num2 = 7;
					continue;
				case 7:
					num2 = ((num >= this.m_b.Items.Count) ? 8 : 4);
					continue;
				case 8:
					return;
				case 0:
					if ((int)this.m_b.Items[num].Tag == A_0)
					{
						num2 = 2;
						continue;
					}
					goto case 1;
				}
				break;
			}
		}
	}

	public void i()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				Show();
				new n(base.Handle).f();
				num = 2;
				continue;
			case 2:
			case 3:
				ck = !ck;
				return;
			}
			if (true)
			{
			}
			if (ck)
			{
				num = 1;
				continue;
			}
			Hide();
			num = 3;
		}
	}

	private void bp(object A_0, EventArgs A_1)
	{
		while (true)
		{
			cn.f.Add(Keys.Pause);
			cn.f.Add(Keys.Prior);
			cn.f.Add(Keys.Next);
			cn.f.Add(Keys.Insert);
			cn.b(b);
			base.Icon = Resources.dragon;
			this.m_bb.Icon = Resources.dragon;
			base.TopMost = global::b.a();
			this.m_a1.Checked = base.TopMost;
			int num = 1;
			while (true)
			{
				switch (num)
				{
				case 1:
					if (!Directory.Exists(global::e.a))
					{
						num = 3;
						continue;
					}
					goto case 0;
				case 5:
					this.m_bh.Navigate("http://forum.vipautopro.com/adstlbb.html");
					num = 4;
					continue;
				case 0:
					cl = cm.b;
					cm.a(e);
					global::q.ae = (j)Delegate.Combine(global::q.ae, new j(b));
					j();
					l();
					base.Location = new Point(global::k.b() - base.Width, 0);
					this.m_a8.Text = global::b.c();
					num = 2;
					continue;
				case 2:
					if (global::b.b())
					{
						num = 5;
						continue;
					}
					goto case 4;
				case 3:
					if (true)
					{
					}
					Directory.CreateDirectory(global::e.a);
					num = 0;
					continue;
				case 4:
					global::q.af = (a)Delegate.Combine(global::q.af, new a(a));
					return;
				}
				break;
			}
		}
	}

	private void g()
	{
		IEnumerator enumerator2 = default(IEnumerator);
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			global::q.a = !global::q.a;
			int num = 0;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				case 0:
					if (global::q.a)
					{
						num = 2;
						continue;
					}
					base.Icon = Resources.dragon;
					this.m_bb.Icon = Resources.dragon;
					f();
					enumerator2 = this.m_b.Items.GetEnumerator();
					num = 3;
					continue;
				case 3:
					try
					{
						num = 2;
						while (true)
						{
							switch (num)
							{
							default:
								num = 1;
								break;
							case 1:
							{
								if (!enumerator2.MoveNext())
								{
									num = 0;
									break;
								}
								ListViewItem listViewItem2 = (ListViewItem)enumerator2.Current;
								cl[(int)listViewItem2.Tag].g();
								num = 4;
								break;
							}
							case 0:
								num = 3;
								break;
							case 3:
								return;
							}
						}
					}
					finally
					{
						while (true)
						{
							IL_00fe:
							IDisposable disposable2 = enumerator2 as IDisposable;
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (disposable2 != null)
									{
										num = 0;
										continue;
									}
									goto end_IL_00e9;
								case 0:
									disposable2.Dispose();
									num = 2;
									continue;
								case 2:
									goto end_IL_00e9;
								}
								goto IL_00fe;
								continue;
								end_IL_00e9:
								break;
							}
							break;
						}
					}
				case 2:
					base.Icon = Resources.dragonPause;
					this.m_bb.Icon = Resources.dragonPause;
					enumerator = this.m_b.Items.GetEnumerator();
					num = 1;
					continue;
				case 1:
					try
					{
						num = 2;
						while (true)
						{
							switch (num)
							{
							default:
								num = 4;
								break;
							case 4:
								if (enumerator.MoveNext())
								{
									ListViewItem listViewItem = (ListViewItem)enumerator.Current;
									cl[(int)listViewItem.Tag].g();
									num = 0;
								}
								else
								{
									num = 3;
								}
								break;
							case 3:
								num = 1;
								break;
							case 1:
								return;
							}
						}
					}
					finally
					{
						while (true)
						{
							IL_021b:
							IDisposable disposable = enumerator as IDisposable;
							num = 1;
							while (true)
							{
								switch (num)
								{
								case 1:
									if (disposable != null)
									{
										num = 2;
										continue;
									}
									goto end_IL_0206;
								case 2:
									disposable.Dispose();
									num = 0;
									continue;
								case 0:
									goto end_IL_0206;
								}
								goto IL_021b;
								continue;
								end_IL_0206:
								break;
							}
							break;
						}
					}
				}
				break;
			}
		}
	}

	private void f()
	{
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			Dictionary<int, q>.Enumerator enumerator = cl.GetEnumerator();
			int num = 5;
			while (true)
			{
				switch (num)
				{
				case 1:
					this.m_bp.Text = "Tọa độ: " + num2 + "," + num3;
					num = 2;
					continue;
				case 7:
					if (true)
					{
					}
					num2 = (cl[(int)this.m_e.Tag].t = cl[(int)this.m_e.Tag].ab());
					num3 = (cl[(int)this.m_e.Tag].u = cl[(int)this.m_e.Tag].ag());
					cl[(int)this.m_e.Tag].y = this.m_bp.Checked;
					num = 4;
					continue;
				case 4:
					if (this.m_bp.Checked)
					{
						num = 1;
						continue;
					}
					this.m_bp.Text = "Bán kính";
					num = 6;
					continue;
				case 2:
				case 6:
					bq.Enabled = this.m_bp.Checked;
					num = 0;
					continue;
				case 0:
					return;
				case 5:
					try
					{
						num = 0;
						while (true)
						{
							switch (num)
							{
							default:
								num = 1;
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = 2;
									continue;
								}
								KeyValuePair<int, q> current = enumerator.Current;
								current.Value.t = current.Value.ab();
								current.Value.u = current.Value.ag();
								num = 3;
								continue;
							}
							case 2:
								num = 4;
								continue;
							case 4:
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
					num = 3;
					continue;
				case 3:
					if (this.m_e.Tag != null)
					{
						num = 7;
						continue;
					}
					return;
				}
				break;
			}
		}
	}

	private void e()
	{
		j();
		k();
	}

	private void bo(object A_0, EventArgs A_1)
	{
		int num = 10;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((this.m_b.SelectedItems.Count > 0) ? 5 : 0);
				continue;
			case 1:
			case 6:
			case 7:
				num = 9;
				continue;
			case 9:
				if (cl.ContainsKey((int)this.m_e.Tag))
				{
					if (true)
					{
					}
					num = 8;
					continue;
				}
				break;
			case 5:
				this.m_e.Text = this.m_b.SelectedItems[0].SubItems["acc"].Text;
				this.m_e.Tag = this.m_b.SelectedItems[0].Tag;
				num = 7;
				continue;
			case 8:
				num = 2;
				continue;
			case 2:
				bz.Text = ((this.m_e.Tag != null) ? cl[(int)this.m_e.Tag].ak() : "Chưa chọn nhân vật");
				num = 4;
				continue;
			case 3:
				this.m_e.Text = this.m_b.Items[0].SubItems["acc"].Text;
				this.m_e.Tag = this.m_b.Items[0].Tag;
				num = 1;
				continue;
			case 0:
				if (this.m_b.Items.Count <= 0)
				{
					this.m_e.Text = "Nhân vật";
					this.m_e.Tag = null;
					num = 6;
				}
				else
				{
					num = 3;
				}
				continue;
			case 4:
				break;
			}
			break;
		}
		this.m_aj.Start();
		k();
	}

	private void bn(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				cl[(int)this.m_e.Tag].az.Enabled = this.m_h.Checked;
				num = 2;
				continue;
			case 2:
				return;
			}
			if (true)
			{
			}
			if (this.m_e.Tag != null)
			{
				num = 1;
				continue;
			}
			return;
		}
	}

	private void bm(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				cl[(int)this.m_e.Tag].a0.Enabled = this.m_ad.Checked;
				num = 2;
				continue;
			case 2:
				return;
			}
			if (this.m_e.Tag != null)
			{
				if (true)
				{
				}
				num = 1;
				continue;
			}
			return;
		}
	}

	private void bl(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				cl[(int)this.m_e.Tag].a1.Enabled = this.m_ab.Checked;
				num = 2;
				continue;
			case 2:
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 0;
				continue;
			}
			return;
		}
	}

	private void bk(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				cl[(int)this.m_e.Tag].a2.Enabled = this.m_z.Checked;
				num = 0;
				continue;
			case 0:
				if (1 == 0)
				{
				}
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 1;
				continue;
			}
			return;
		}
	}

	private void bj(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].a3.Enabled = this.m_x.Checked;
				num = 1;
				continue;
			case 1:
				return;
			}
			if (true)
			{
			}
			if (this.m_e.Tag != null)
			{
				num = 2;
				continue;
			}
			return;
		}
	}

	private void bi(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 0;
					continue;
				}
				break;
			case 0:
				cl[(int)this.m_e.Tag].a4.Enabled = this.m_v.Checked;
				num = 1;
				continue;
			case 1:
				break;
			}
			break;
		}
		if (1 == 0)
		{
		}
	}

	private void bh(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (1 == 0)
				{
				}
				goto default;
			default:
				if (this.m_e.Tag != null)
				{
					num = 2;
					break;
				}
				return;
			case 2:
				cl[(int)this.m_e.Tag].a5.Enabled = this.m_t.Checked;
				num = 1;
				break;
			case 1:
				return;
			}
		}
	}

	private void bg(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 2;
					break;
				}
				return;
			case 2:
				if (true)
				{
				}
				cl[(int)this.m_e.Tag].a6.Enabled = this.m_r.Checked;
				num = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private void bf(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				cl[(int)this.m_e.Tag].a7.Enabled = this.m_p.Checked;
				num = 2;
				continue;
			case 2:
				if (1 == 0)
				{
				}
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 0;
				continue;
			}
			return;
		}
	}

	private void be(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				cl[(int)this.m_e.Tag].a8.Enabled = this.m_n.Checked;
				num = 0;
				continue;
			case 0:
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 1;
				continue;
			}
			return;
		}
	}

	private void bd(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 0;
					break;
				}
				return;
			case 0:
				cl[(int)this.m_e.Tag].a9.Enabled = this.m_l.Checked;
				if (true)
				{
				}
				num = 1;
				break;
			case 1:
				return;
			}
		}
	}

	private void bc(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 1;
					continue;
				}
				break;
			case 1:
				cl[(int)this.m_e.Tag].ba.Enabled = this.m_j.Checked;
				num = 2;
				continue;
			case 2:
				break;
			}
			break;
		}
		if (1 == 0)
		{
		}
	}

	private void bb(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].az.Interval = (int)this.m_ae.Value * 100;
				num = 0;
				continue;
			case 0:
				if (1 == 0)
				{
				}
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 2;
				continue;
			}
			return;
		}
	}

	private void ba(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				cl[(int)this.m_e.Tag].a0.Interval = (int)this.m_ac.Value * 100;
				num = 2;
				continue;
			case 2:
				return;
			}
			if (true)
			{
			}
			if (this.m_e.Tag != null)
			{
				num = 1;
				continue;
			}
			return;
		}
	}

	private void a9(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 1;
					break;
				}
				return;
			case 1:
				cl[(int)this.m_e.Tag].a1.Interval = (int)this.m_aa.Value * 100;
				if (true)
				{
				}
				num = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private void a8(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				cl[(int)this.m_e.Tag].a2.Interval = (int)this.m_y.Value * 100;
				num = 1;
				continue;
			case 1:
				if (1 == 0)
				{
				}
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 0;
				continue;
			}
			return;
		}
	}

	private void a7(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (1 == 0)
				{
				}
				goto default;
			default:
				if (this.m_e.Tag != null)
				{
					num = 1;
					break;
				}
				return;
			case 1:
				cl[(int)this.m_e.Tag].a3.Interval = (int)this.m_w.Value * 100;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	private void a6(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].a4.Interval = (int)this.m_u.Value * 100;
				num = 1;
				continue;
			case 1:
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 2;
				continue;
			}
			return;
		}
	}

	private void a5(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 0;
					break;
				}
				return;
			case 0:
				if (true)
				{
				}
				cl[(int)this.m_e.Tag].a5.Interval = (int)this.m_s.Value * 100;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	private void a4(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				cl[(int)this.m_e.Tag].a6.Interval = (int)this.m_q.Value * 100;
				num = 2;
				continue;
			case 2:
				return;
			}
			if (true)
			{
			}
			if (this.m_e.Tag != null)
			{
				num = 0;
				continue;
			}
			return;
		}
	}

	private void a3(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				cl[(int)this.m_e.Tag].a7.Interval = (int)this.m_o.Value * 100;
				num = 0;
				continue;
			case 0:
				return;
			}
			if (this.m_e.Tag != null)
			{
				if (true)
				{
				}
				num = 1;
				continue;
			}
			return;
		}
	}

	private void a2(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 1;
					break;
				}
				return;
			case 1:
				if (true)
				{
				}
				cl[(int)this.m_e.Tag].a8.Interval = (int)this.m_m.Value * 100;
				num = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private void a1(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			if (true)
			{
			}
			switch (num)
			{
			case 0:
				cl[(int)this.m_e.Tag].a9.Interval = (int)this.m_k.Value * 100;
				num = 1;
				continue;
			case 1:
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 0;
				continue;
			}
			return;
		}
	}

	private void a0(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 0:
				cl[(int)this.m_e.Tag].ba.Interval = (int)this.m_i.Value * 100;
				num = 1;
				continue;
			case 1:
				return;
			}
			if (this.m_e.Tag != null)
			{
				if (true)
				{
				}
				num = 0;
				continue;
			}
			return;
		}
	}

	private void az(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 2;
					continue;
				}
				break;
			case 2:
				cl[(int)this.m_e.Tag].a(this.m_g.Checked);
				cl[(int)this.m_e.Tag].g();
				num = 1;
				continue;
			case 1:
				break;
			}
			break;
		}
		this.m_af.Enabled = this.m_g.Checked;
	}

	private void ay(object A_0, EventArgs A_1)
	{
		IEnumerator enumerator = this.m_b.SelectedItems.GetEnumerator();
		try
		{
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					break;
				case 2:
					if (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].ac();
						num = 3;
					}
					else
					{
						num = 1;
					}
					break;
				case 1:
					if (true)
					{
					}
					num = 0;
					break;
				case 0:
					return;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00c2:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 1;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (disposable != null)
						{
							num2 = 0;
							continue;
						}
						goto end_IL_00ad;
					case 0:
						disposable.Dispose();
						num2 = 2;
						continue;
					case 2:
						goto end_IL_00ad;
					}
					goto IL_00c2;
					continue;
					end_IL_00ad:
					break;
				}
				break;
			}
		}
	}

	private void ax(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			if (true)
			{
			}
			switch (num)
			{
			default:
				if (this.m_d.SelectedTab == this.m_a3)
				{
					num = 5;
					break;
				}
				goto case 4;
			case 4:
				this.m_aj.Stop();
				return;
			case 1:
				num = 3;
				break;
			case 3:
			{
				if (!cl.ContainsKey((int)this.m_e.Tag))
				{
					num = 4;
					break;
				}
				string text = cl[(int)this.m_e.Tag].ah();
				this.m_ai.Text = text;
				return;
			}
			case 5:
				num = 2;
				break;
			case 2:
				if (this.m_e.Tag != null)
				{
					num = 1;
					break;
				}
				goto case 4;
			}
		}
	}

	private void aw(object A_0, EventArgs A_1)
	{
		while (true)
		{
			this.m_ak.Enabled = this.m_am.Checked;
			this.m_al.Enabled = this.m_am.Checked;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (this.m_e.Tag != null)
					{
						if (true)
						{
						}
						num = 2;
						continue;
					}
					return;
				case 2:
					cl[(int)this.m_e.Tag].bc.Enabled = this.m_am.Checked;
					num = 1;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	private void av(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 0;
					break;
				}
				return;
			case 0:
				if (true)
				{
				}
				cl[(int)this.m_e.Tag].p = (int)this.m_ak.Value;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	private void au(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 2;
					break;
				}
				return;
			case 2:
				if (true)
				{
				}
				cl[(int)this.m_e.Tag].l = this.m_al.Text;
				num = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private void at(object A_0, EventArgs A_1)
	{
		IEnumerator enumerator = this.m_b.SelectedItems.GetEnumerator();
		try
		{
			int num = 0;
			while (true)
			{
				switch (num)
				{
				default:
					num = 3;
					break;
				case 3:
					if (enumerator.MoveNext())
					{
						if (true)
						{
						}
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].v();
						num = 2;
					}
					else
					{
						num = 4;
					}
					break;
				case 4:
					num = 1;
					break;
				case 1:
					return;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00c2:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 0;
				while (true)
				{
					switch (num2)
					{
					case 0:
						if (disposable != null)
						{
							num2 = 1;
							continue;
						}
						goto end_IL_00ad;
					case 1:
						disposable.Dispose();
						num2 = 2;
						continue;
					case 2:
						goto end_IL_00ad;
					}
					goto IL_00c2;
					continue;
					end_IL_00ad:
					break;
				}
				break;
			}
		}
	}

	private void @as(object A_0, EventArgs A_1)
	{
		IEnumerator enumerator = this.m_b.SelectedItems.GetEnumerator();
		try
		{
			int num = 2;
			while (true)
			{
				if (true)
				{
				}
				switch (num)
				{
				default:
					num = 1;
					break;
				case 1:
					if (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].ai();
						num = 0;
					}
					else
					{
						num = 3;
					}
					break;
				case 3:
					num = 4;
					break;
				case 4:
					return;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00c2:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (disposable != null)
						{
							num2 = 0;
							continue;
						}
						goto end_IL_00ad;
					case 0:
						disposable.Dispose();
						num2 = 1;
						continue;
					case 1:
						goto end_IL_00ad;
					}
					goto IL_00c2;
					continue;
					end_IL_00ad:
					break;
				}
				break;
			}
		}
	}

	private void ar(object A_0, EventArgs A_1)
	{
		MessageBox.Show(long.MaxValue.ToString());
	}

	private void aq(object A_0, EventArgs A_1)
	{
		IEnumerator enumerator = this.m_b.SelectedItems.GetEnumerator();
		try
		{
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					num = 1;
					break;
				case 1:
					if (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].bh.Enabled = this.m_av.Checked;
						num = 0;
						break;
					}
					if (true)
					{
					}
					num = 2;
					break;
				case 2:
					num = 4;
					break;
				case 4:
					return;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00d5:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (disposable != null)
						{
							num2 = 1;
							continue;
						}
						goto end_IL_00c0;
					case 1:
						disposable.Dispose();
						num2 = 0;
						continue;
					case 0:
						goto end_IL_00c0;
					}
					goto IL_00d5;
					continue;
					end_IL_00c0:
					break;
				}
				break;
			}
		}
	}

	private void ap(object A_0, EventArgs A_1)
	{
		d();
	}

	private void ao(object A_0, EventArgs A_1)
	{
		d();
	}

	private void d()
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 1:
				cl[(int)this.m_e.Tag].bn = this.m_az.Checked;
				num = 2;
				continue;
			case 2:
				if (1 == 0)
				{
				}
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 1;
				continue;
			}
			return;
		}
	}

	private void an(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].r = (int)this.m_as.Value;
				num = 0;
				continue;
			case 0:
				return;
			}
			if (this.m_e.Tag != null)
			{
				if (true)
				{
				}
				num = 2;
				continue;
			}
			return;
		}
	}

	private void am(object A_0, EventArgs A_1)
	{
		while (true)
		{
			if (true)
			{
			}
			this.m_ap.Enabled = this.m_an.Checked;
			this.m_ao.Enabled = this.m_an.Checked;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (this.m_e.Tag != null)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					cl[(int)this.m_e.Tag].bd.Enabled = this.m_an.Checked;
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void al(object A_0, EventArgs A_1)
	{
		while (true)
		{
			this.m_as.Enabled = this.m_aq.Checked;
			this.m_ar.Enabled = this.m_aq.Checked;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (this.m_e.Tag != null)
					{
						num = 0;
						continue;
					}
					goto case 1;
				case 0:
					cl[(int)this.m_e.Tag].be.Enabled = this.m_aq.Checked;
					num = 1;
					continue;
				case 1:
					if (1 == 0)
					{
					}
					return;
				}
				break;
			}
		}
	}

	private void ak(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 0;
					break;
				}
				return;
			case 0:
				if (true)
				{
				}
				cl[(int)this.m_e.Tag].q = (int)this.m_ap.Value;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	private void aj(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				cl[(int)this.m_e.Tag].n = this.m_ao.Text;
				num = 0;
				continue;
			case 0:
				return;
			}
			if (this.m_e.Tag != null)
			{
				if (true)
				{
				}
				num = 1;
				continue;
			}
			return;
		}
	}

	private void ai(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			if (true)
			{
			}
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].o = this.m_ar.Text;
				num = 0;
				continue;
			case 0:
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 2;
				continue;
			}
			return;
		}
	}

	private void ah(object A_0, EventArgs A_1)
	{
		base.TopMost = this.m_a1.Checked;
		global::b.a(base.TopMost);
	}

	private void ag(object A_0, EventArgs A_1)
	{
		global::q.c = this.m_a2.Checked;
	}

	private void af(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		while (true)
		{
			this.m_a5.Enabled = this.m_a4.Checked;
			int num = 0;
			while (true)
			{
				switch (num)
				{
				case 0:
					if (this.m_e.Tag != null)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					cl[(int)this.m_e.Tag].bi.Enabled = this.m_a4.Checked;
					num = 2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	private void ae(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].x = (int)this.m_a5.Value;
				num = 0;
				continue;
			case 0:
				if (1 == 0)
				{
				}
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 2;
				continue;
			}
			return;
		}
	}

	private void ad(object A_0, EventArgs A_1)
	{
		while (true)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = global::e.a;
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 2:
					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						num = 1;
						continue;
					}
					return;
				case 1:
					this.m_a8.Text = openFileDialog.FileName;
					if (true)
					{
					}
					num = 0;
					continue;
				case 0:
					return;
				}
				break;
			}
		}
	}

	private void ac(object A_0, EventArgs A_1)
	{
		global::l.c();
	}

	private void ab(object A_0, EventArgs A_1)
	{
		global::l.a();
	}

	private void aa(object A_0, EventArgs A_1)
	{
		global::b.a(this.m_a8.Text);
	}

	private void a(object A_0, FormClosingEventArgs A_1)
	{
		this.m_bb.Visible = false;
	}

	private void b(object A_0, MouseEventArgs A_1)
	{
		if (A_1.Button == MouseButtons.Left)
		{
			global::k.a(base.Handle);
			i();
		}
	}

	private void z(object A_0, EventArgs A_1)
	{
		if (base.WindowState == FormWindowState.Minimized)
		{
			i();
		}
	}

	private void y(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 0:
				cl[(int)this.m_e.Tag].v = (int)this.m_be.Value;
				num = 2;
				continue;
			case 2:
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 0;
				continue;
			}
			return;
		}
	}

	private void x(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 1;
					break;
				}
				return;
			case 1:
				if (true)
				{
				}
				cl[(int)this.m_e.Tag].w = (int)this.m_bd.Value;
				num = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private void w(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 2;
					break;
				}
				return;
			case 2:
				cl[(int)this.m_e.Tag].e = this.m_bf.Checked;
				if (true)
				{
				}
				num = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private void v(object A_0, EventArgs A_1)
	{
		Dispose();
	}

	private void u(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		IEnumerator enumerator = this.m_b.SelectedItems.GetEnumerator();
		try
		{
			int num = 4;
			while (true)
			{
				switch (num)
				{
				default:
					num = 0;
					break;
				case 0:
					if (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].a5();
						num = 2;
					}
					else
					{
						num = 1;
					}
					break;
				case 1:
					num = 3;
					break;
				case 3:
					return;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00bf:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 0;
				while (true)
				{
					switch (num2)
					{
					case 0:
						if (disposable != null)
						{
							num2 = 1;
							continue;
						}
						goto end_IL_00aa;
					case 1:
						disposable.Dispose();
						num2 = 2;
						continue;
					case 2:
						goto end_IL_00aa;
					}
					goto IL_00bf;
					continue;
					end_IL_00aa:
					break;
				}
				break;
			}
		}
	}

	private void t(object A_0, EventArgs A_1)
	{
		using (Dictionary<int, q>.ValueCollection.Enumerator enumerator = cl.Values.GetEnumerator())
		{
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					continue;
				case 2:
					if (enumerator.MoveNext())
					{
						q current = enumerator.Current;
						current.k();
						num = 4;
					}
					else
					{
						num = 0;
					}
					continue;
				case 0:
					num = 1;
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		if (true)
		{
		}
		cl.Clear();
	}

	private void a(object A_0, LinkLabelLinkClickedEventArgs A_1)
	{
		try
		{
			Process.Start("http://forum.vipautopro.com/forums/148-Thien-Long-Bat-Bo");
		}
		catch
		{
		}
	}

	private void s(object A_0, EventArgs A_1)
	{
		int num = 5;
		int num2 = default(int);
		int num3 = default(int);
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 3;
					continue;
				}
				return;
			case 2:
				if (1 == 0)
				{
				}
				break;
			case 4:
				this.m_bp.Text = "Tọa độ: " + num2 + "," + num3;
				num = 0;
				continue;
			case 3:
				num2 = (cl[(int)this.m_e.Tag].t = cl[(int)this.m_e.Tag].ab());
				num3 = (cl[(int)this.m_e.Tag].u = cl[(int)this.m_e.Tag].ag());
				cl[(int)this.m_e.Tag].y = this.m_bp.Checked;
				num = 6;
				continue;
			case 6:
				if (!this.m_bp.Checked)
				{
					this.m_bp.Text = "Bán kính";
					num = 2;
				}
				else
				{
					num = 4;
				}
				continue;
			case 0:
				break;
			case 1:
				return;
			}
			bq.Enabled = this.m_bp.Checked;
			num = 1;
		}
	}

	private void r(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].s = (int)bq.Value;
				num = 1;
				continue;
			case 1:
				return;
			}
			if (this.m_e.Tag != null)
			{
				num = 2;
				continue;
			}
			return;
		}
	}

	private void q(object A_0, EventArgs A_1)
	{
		g();
	}

	private void p(object A_0, EventArgs A_1)
	{
		int num = 2;
		string value = default(string);
		while (true)
		{
			switch (num)
			{
			case 0:
				return;
			case 1:
				try
				{
					ulong a_ = Convert.ToUInt64(value);
					cl[(int)this.m_e.Tag].a(a_);
					return;
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
					return;
				}
			}
			if (this.m_e.Tag == null)
			{
				num = 0;
				continue;
			}
			value = Interaction.InputBox("Microauto", "Microauto", "", global::k.b() / 2, global::k.a() / 2);
			if (true)
			{
			}
			num = 1;
		}
	}

	private void o(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 2;
					break;
				}
				return;
			case 2:
				cl[(int)this.m_e.Tag].a3();
				if (true)
				{
				}
				num = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private void n(object A_0, EventArgs A_1)
	{
		int num = 1;
		while (true)
		{
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].k = bx.Text;
				num = 0;
				continue;
			case 0:
				return;
			}
			if (true)
			{
			}
			if (this.m_e.Tag != null)
			{
				num = 2;
				continue;
			}
			return;
		}
	}

	private void m(object A_0, EventArgs A_1)
	{
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				if (this.m_e.Tag != null)
				{
					num = 1;
					break;
				}
				return;
			case 1:
				if (true)
				{
				}
				cl[(int)this.m_e.Tag].m = bw.Text;
				num = 0;
				break;
			case 0:
				return;
			}
		}
	}

	private void l(object A_0, EventArgs A_1)
	{
		g();
	}

	private void k(object A_0, EventArgs A_1)
	{
		this.m_aj.Start();
	}

	private void j(object A_0, EventArgs A_1)
	{
		c();
	}

	private void c()
	{
		this.m_bp.Checked = true;
		IEnumerator enumerator = this.m_b.Items.GetEnumerator();
		try
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					num = 3;
					continue;
				case 3:
					if (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].y = true;
						num = 0;
					}
					else
					{
						num = 4;
					}
					continue;
				case 4:
					num = 1;
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		finally
		{
			while (true)
			{
				IL_00c4:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (disposable != null)
						{
							num2 = 0;
							continue;
						}
						goto end_IL_00af;
					case 0:
						disposable.Dispose();
						num2 = 1;
						continue;
					case 1:
						goto end_IL_00af;
					}
					goto IL_00c4;
					continue;
					end_IL_00af:
					break;
				}
				break;
			}
		}
		if (true)
		{
		}
		f();
		k();
	}

	private void i(object A_0, EventArgs A_1)
	{
		c();
	}

	private void h(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		IEnumerator enumerator = this.m_b.Items.GetEnumerator();
		try
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					break;
				case 4:
					if (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].v();
						num = 1;
					}
					else
					{
						num = 0;
					}
					break;
				case 0:
					num = 3;
					break;
				case 3:
					return;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00bf:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 1;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (disposable != null)
						{
							num2 = 2;
							continue;
						}
						goto end_IL_00aa;
					case 2:
						disposable.Dispose();
						num2 = 0;
						continue;
					case 0:
						goto end_IL_00aa;
					}
					goto IL_00bf;
					continue;
					end_IL_00aa:
					break;
				}
				break;
			}
		}
	}

	private void g(object A_0, EventArgs A_1)
	{
		if (true)
		{
		}
		IEnumerator enumerator = this.m_b.Items.GetEnumerator();
		try
		{
			int num = 3;
			while (true)
			{
				switch (num)
				{
				default:
					num = 2;
					break;
				case 2:
					if (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].ai();
						num = 1;
					}
					else
					{
						num = 0;
					}
					break;
				case 0:
					num = 4;
					break;
				case 4:
					return;
				}
			}
		}
		finally
		{
			while (true)
			{
				IL_00bf:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 0;
				while (true)
				{
					switch (num2)
					{
					case 0:
						if (disposable != null)
						{
							num2 = 2;
							continue;
						}
						goto end_IL_00aa;
					case 2:
						disposable.Dispose();
						num2 = 1;
						continue;
					case 1:
						goto end_IL_00aa;
					}
					goto IL_00bf;
					continue;
					end_IL_00aa:
					break;
				}
				break;
			}
		}
	}

	private void f(object A_0, EventArgs A_1)
	{
		b();
	}

	private void b()
	{
		IEnumerator enumerator = this.m_b.Items.GetEnumerator();
		try
		{
			int num = 2;
			while (true)
			{
				switch (num)
				{
				default:
					num = 4;
					continue;
				case 4:
					if (enumerator.MoveNext())
					{
						ListViewItem listViewItem = (ListViewItem)enumerator.Current;
						cl[(int)listViewItem.Tag].ac();
						num = 1;
					}
					else
					{
						num = 3;
					}
					continue;
				case 3:
					num = 0;
					continue;
				case 0:
					break;
				}
				break;
			}
		}
		finally
		{
			while (true)
			{
				IL_00b7:
				IDisposable disposable = enumerator as IDisposable;
				int num2 = 2;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (disposable != null)
						{
							num2 = 1;
							continue;
						}
						goto end_IL_00a2;
					case 1:
						disposable.Dispose();
						num2 = 0;
						continue;
					case 0:
						goto end_IL_00a2;
					}
					goto IL_00b7;
					continue;
					end_IL_00a2:
					break;
				}
				break;
			}
		}
		if (1 == 0)
		{
		}
	}

	[SpecialName]
	private q a()
	{
		if (true)
		{
		}
		if (this.m_e.Tag == null)
		{
			return null;
		}
		return cl[(int)this.m_e.Tag];
	}

	private void e(object A_0, EventArgs A_1)
	{
		i();
	}

	private void a(object A_0, ItemCheckedEventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			if (true)
			{
			}
			switch (num)
			{
			default:
				if (cl.ContainsKey((int)A_1.Item.Tag))
				{
					num = 2;
					break;
				}
				return;
			case 2:
				cl[(int)A_1.Item.Tag].bb.Enabled = A_1.Item.Checked;
				cl[(int)A_1.Item.Tag].a(A_1.Item.Checked);
				cl[(int)A_1.Item.Tag].t = cl[(int)A_1.Item.Tag].ab();
				cl[(int)A_1.Item.Tag].u = cl[(int)A_1.Item.Tag].ag();
				k();
				cl[(int)A_1.Item.Tag].g();
				num = 1;
				break;
			case 1:
				return;
			}
		}
	}

	private void d(object A_0, EventArgs A_1)
	{
		l();
	}

	private void c(object A_0, EventArgs A_1)
	{
		new d().a("Thử nghiệm", global::q.ac);
		global::l.c();
	}

	private void b(object A_0, EventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				cl[(int)this.m_e.Tag].i = cg.Checked;
				num = 1;
				continue;
			case 1:
				return;
			}
			if (this.m_e.Tag != null)
			{
				if (true)
				{
				}
				num = 2;
				continue;
			}
			return;
		}
	}

	private void a(object A_0, KeyEventArgs A_1)
	{
		int num = 0;
		while (true)
		{
			switch (num)
			{
			case 2:
				a().ai();
				num = 3;
				continue;
			case 3:
				return;
			case 1:
				num = 4;
				continue;
			case 4:
				if (this.m_b.SelectedItems.Count > 0)
				{
					num = 2;
					continue;
				}
				return;
			}
			if (true)
			{
			}
			if (A_1.KeyCode == Keys.Next)
			{
				num = 1;
				continue;
			}
			return;
		}
	}

	private void a(object A_0, EventArgs A_1)
	{
		b();
	}

	private void a(object A_0, MouseEventArgs A_1)
	{
		try
		{
			Process.Start("http://www.vipautopro.com/");
		}
		catch (Exception)
		{
		}
	}

	private void a(object A_0, CancelEventArgs A_1)
	{
		int num = 1;
		int num2;
		while (true)
		{
			switch (num)
			{
			default:
				num = ((this.m_b.SelectedItems.Count > 0) ? 3 : 2);
				continue;
			case 2:
				if (true)
				{
				}
				num = 0;
				continue;
			case 3:
				num2 = 1;
				break;
			case 0:
				num2 = 0;
				break;
			}
			break;
		}
		bool enabled = (byte)num2 != 0;
		this.m_ah.Enabled = enabled;
	}
}
