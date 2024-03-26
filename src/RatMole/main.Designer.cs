namespace RatMole
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelname = new System.Windows.Forms.Label();
            this.outtime = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.labelscroe = new System.Windows.Forms.Label();
            this.labelsum = new System.Windows.Forms.Label();
            this.labelplayer = new System.Windows.Forms.Label();
            this.timeout = new System.Windows.Forms.Timer(this.components);
            this.labelshijian = new System.Windows.Forms.Label();
            this.labeltime = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置难度ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.普通NormalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.困难HardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置风格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.田园ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.生化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.电子ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.设置模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.闯关模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.无限模式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存成绩ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.历史成绩ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelexp = new System.Windows.Forms.Label();
            this.labelaim = new System.Windows.Forms.Label();
            this.labelevel = new System.Windows.Forms.Label();
            this.btreall = new System.Windows.Forms.Button();
            this.btrethis = new System.Windows.Forms.Button();
            this.btnext = new System.Windows.Forms.Button();
            this.btpause = new System.Windows.Forms.Button();
            this.btback = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureinst = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureinst)).BeginInit();
            this.SuspendLayout();
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("新宋体", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelname.Location = new System.Drawing.Point(907, 570);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(45, 30);
            this.labelname.TabIndex = 0;
            this.labelname.Text = "--";
            // 
            // outtime
            // 
            this.outtime.Enabled = true;
            this.outtime.Interval = 60;
            this.outtime.Tick += new System.EventHandler(this.Outtime_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(80, 136);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(502, 108);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelscroe
            // 
            this.labelscroe.AutoSize = true;
            this.labelscroe.BackColor = System.Drawing.Color.Transparent;
            this.labelscroe.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelscroe.ForeColor = System.Drawing.Color.Gold;
            this.labelscroe.Location = new System.Drawing.Point(682, 209);
            this.labelscroe.Name = "labelscroe";
            this.labelscroe.Size = new System.Drawing.Size(158, 37);
            this.labelscroe.TabIndex = 4;
            this.labelscroe.Text = "分数Score:";
            // 
            // labelsum
            // 
            this.labelsum.AutoSize = true;
            this.labelsum.BackColor = System.Drawing.Color.Transparent;
            this.labelsum.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelsum.ForeColor = System.Drawing.Color.Violet;
            this.labelsum.Location = new System.Drawing.Point(873, 270);
            this.labelsum.Name = "labelsum";
            this.labelsum.Size = new System.Drawing.Size(72, 45);
            this.labelsum.TabIndex = 5;
            this.labelsum.Text = "--";
            // 
            // labelplayer
            // 
            this.labelplayer.AutoSize = true;
            this.labelplayer.BackColor = System.Drawing.Color.Transparent;
            this.labelplayer.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelplayer.ForeColor = System.Drawing.Color.Gold;
            this.labelplayer.Location = new System.Drawing.Point(682, 563);
            this.labelplayer.Name = "labelplayer";
            this.labelplayer.Size = new System.Drawing.Size(167, 37);
            this.labelplayer.TabIndex = 6;
            this.labelplayer.Text = "玩家Player:";
            // 
            // timeout
            // 
            this.timeout.Tick += new System.EventHandler(this.timeout_Tick);
            // 
            // labelshijian
            // 
            this.labelshijian.AutoSize = true;
            this.labelshijian.BackColor = System.Drawing.Color.Transparent;
            this.labelshijian.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelshijian.ForeColor = System.Drawing.Color.Gold;
            this.labelshijian.Location = new System.Drawing.Point(683, 360);
            this.labelshijian.Name = "labelshijian";
            this.labelshijian.Size = new System.Drawing.Size(151, 37);
            this.labelshijian.TabIndex = 7;
            this.labelshijian.Text = "时间Time:";
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.BackColor = System.Drawing.Color.Transparent;
            this.labeltime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labeltime.Font = new System.Drawing.Font("Lithos Pro Regular", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.Color.Goldenrod;
            this.labeltime.Location = new System.Drawing.Point(850, 444);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(63, 58);
            this.labeltime.TabIndex = 8;
            this.labeltime.Text = "--";
            this.labeltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.开始ToolStripMenuItem,
            this.设置ToolStripMenuItem,
            this.查看ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1054, 32);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 开始ToolStripMenuItem
            // 
            this.开始ToolStripMenuItem.Name = "开始ToolStripMenuItem";
            this.开始ToolStripMenuItem.Size = new System.Drawing.Size(66, 28);
            this.开始ToolStripMenuItem.Text = "开始&s";
            this.开始ToolStripMenuItem.Click += new System.EventHandler(this.开始ToolStripMenuItem_Click);
            // 
            // 设置ToolStripMenuItem
            // 
            this.设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.设置难度ToolStripMenuItem,
            this.设置风格ToolStripMenuItem,
            this.设置模式ToolStripMenuItem});
            this.设置ToolStripMenuItem.Name = "设置ToolStripMenuItem";
            this.设置ToolStripMenuItem.Size = new System.Drawing.Size(69, 28);
            this.设置ToolStripMenuItem.Text = "设置&o";
            // 
            // 设置难度ToolStripMenuItem
            // 
            this.设置难度ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.普通NormalToolStripMenuItem,
            this.困难HardToolStripMenuItem});
            this.设置难度ToolStripMenuItem.Name = "设置难度ToolStripMenuItem";
            this.设置难度ToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.设置难度ToolStripMenuItem.Text = "设置难度&d";
            // 
            // 普通NormalToolStripMenuItem
            // 
            this.普通NormalToolStripMenuItem.Checked = true;
            this.普通NormalToolStripMenuItem.CheckOnClick = true;
            this.普通NormalToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.普通NormalToolStripMenuItem.Name = "普通NormalToolStripMenuItem";
            this.普通NormalToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.普通NormalToolStripMenuItem.Text = "普通Normal";
            this.普通NormalToolStripMenuItem.CheckedChanged += new System.EventHandler(this.困难HardToolStripMenuItem_CheckedChanged);
            // 
            // 困难HardToolStripMenuItem
            // 
            this.困难HardToolStripMenuItem.CheckOnClick = true;
            this.困难HardToolStripMenuItem.Name = "困难HardToolStripMenuItem";
            this.困难HardToolStripMenuItem.Size = new System.Drawing.Size(193, 30);
            this.困难HardToolStripMenuItem.Text = "困难Hard";
            this.困难HardToolStripMenuItem.CheckedChanged += new System.EventHandler(this.困难HardToolStripMenuItem_CheckedChanged);
            // 
            // 设置风格ToolStripMenuItem
            // 
            this.设置风格ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.田园ToolStripMenuItem,
            this.生化ToolStripMenuItem,
            this.电子ToolStripMenuItem});
            this.设置风格ToolStripMenuItem.Name = "设置风格ToolStripMenuItem";
            this.设置风格ToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.设置风格ToolStripMenuItem.Text = "设置风格&y";
            this.设置风格ToolStripMenuItem.Click += new System.EventHandler(this.设置风格ToolStripMenuItem_Click);
            // 
            // 田园ToolStripMenuItem
            // 
            this.田园ToolStripMenuItem.Checked = true;
            this.田园ToolStripMenuItem.CheckOnClick = true;
            this.田园ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.田园ToolStripMenuItem.Name = "田园ToolStripMenuItem";
            this.田园ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.田园ToolStripMenuItem.Text = "田园";
            this.田园ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.田园ToolStripMenuItem_CheckedChanged);
            // 
            // 生化ToolStripMenuItem
            // 
            this.生化ToolStripMenuItem.CheckOnClick = true;
            this.生化ToolStripMenuItem.Name = "生化ToolStripMenuItem";
            this.生化ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.生化ToolStripMenuItem.Text = "生化";
            this.生化ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.田园ToolStripMenuItem_CheckedChanged);
            // 
            // 电子ToolStripMenuItem
            // 
            this.电子ToolStripMenuItem.CheckOnClick = true;
            this.电子ToolStripMenuItem.Name = "电子ToolStripMenuItem";
            this.电子ToolStripMenuItem.Size = new System.Drawing.Size(128, 30);
            this.电子ToolStripMenuItem.Text = "电子";
            this.电子ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.田园ToolStripMenuItem_CheckedChanged);
            // 
            // 设置模式ToolStripMenuItem
            // 
            this.设置模式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.闯关模式ToolStripMenuItem,
            this.无限模式ToolStripMenuItem});
            this.设置模式ToolStripMenuItem.Name = "设置模式ToolStripMenuItem";
            this.设置模式ToolStripMenuItem.Size = new System.Drawing.Size(176, 30);
            this.设置模式ToolStripMenuItem.Text = "设置模式&l";
            // 
            // 闯关模式ToolStripMenuItem
            // 
            this.闯关模式ToolStripMenuItem.Checked = true;
            this.闯关模式ToolStripMenuItem.CheckOnClick = true;
            this.闯关模式ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.闯关模式ToolStripMenuItem.Name = "闯关模式ToolStripMenuItem";
            this.闯关模式ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.闯关模式ToolStripMenuItem.Text = "闯关模式";
            this.闯关模式ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.闯关模式ToolStripMenuItem_CheckedChanged);
            // 
            // 无限模式ToolStripMenuItem
            // 
            this.无限模式ToolStripMenuItem.CheckOnClick = true;
            this.无限模式ToolStripMenuItem.Name = "无限模式ToolStripMenuItem";
            this.无限模式ToolStripMenuItem.Size = new System.Drawing.Size(164, 30);
            this.无限模式ToolStripMenuItem.Text = "无限模式";
            this.无限模式ToolStripMenuItem.CheckedChanged += new System.EventHandler(this.闯关模式ToolStripMenuItem_CheckedChanged);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.保存成绩ToolStripMenuItem,
            this.历史成绩ToolStripMenuItem1});
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(75, 28);
            this.查看ToolStripMenuItem.Text = "成绩&m";
            // 
            // 保存成绩ToolStripMenuItem
            // 
            this.保存成绩ToolStripMenuItem.Name = "保存成绩ToolStripMenuItem";
            this.保存成绩ToolStripMenuItem.Size = new System.Drawing.Size(175, 30);
            this.保存成绩ToolStripMenuItem.Text = "保存成绩&v";
            this.保存成绩ToolStripMenuItem.Click += new System.EventHandler(this.保存成绩ToolStripMenuItem_Click);
            // 
            // 历史成绩ToolStripMenuItem1
            // 
            this.历史成绩ToolStripMenuItem1.Name = "历史成绩ToolStripMenuItem1";
            this.历史成绩ToolStripMenuItem1.Size = new System.Drawing.Size(175, 30);
            this.历史成绩ToolStripMenuItem1.Text = "历史成绩&h";
            this.历史成绩ToolStripMenuItem1.Click += new System.EventHandler(this.历史成绩ToolStripMenuItem1_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(70, 28);
            this.帮助ToolStripMenuItem.Text = "帮助&p";
            this.帮助ToolStripMenuItem.Click += new System.EventHandler(this.帮助ToolStripMenuItem_Click);
            // 
            // labelexp
            // 
            this.labelexp.AutoSize = true;
            this.labelexp.BackColor = System.Drawing.Color.Transparent;
            this.labelexp.Font = new System.Drawing.Font("微软雅黑", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelexp.ForeColor = System.Drawing.Color.Gold;
            this.labelexp.Location = new System.Drawing.Point(691, 131);
            this.labelexp.Name = "labelexp";
            this.labelexp.Size = new System.Drawing.Size(202, 37);
            this.labelexp.TabIndex = 11;
            this.labelexp.Text = "目标数Expect:";
            // 
            // labelaim
            // 
            this.labelaim.AutoSize = true;
            this.labelaim.BackColor = System.Drawing.Color.Transparent;
            this.labelaim.Font = new System.Drawing.Font("UD Digi Kyokasho NK-B", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelaim.ForeColor = System.Drawing.Color.MediumPurple;
            this.labelaim.Location = new System.Drawing.Point(952, 136);
            this.labelaim.Name = "labelaim";
            this.labelaim.Size = new System.Drawing.Size(53, 33);
            this.labelaim.TabIndex = 12;
            this.labelaim.Text = "--";
            // 
            // labelevel
            // 
            this.labelevel.AutoSize = true;
            this.labelevel.BackColor = System.Drawing.Color.Transparent;
            this.labelevel.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelevel.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelevel.ForeColor = System.Drawing.Color.Green;
            this.labelevel.Location = new System.Drawing.Point(1002, 32);
            this.labelevel.Name = "labelevel";
            this.labelevel.Size = new System.Drawing.Size(52, 47);
            this.labelevel.TabIndex = 13;
            this.labelevel.Text = "--";
            // 
            // btreall
            // 
            this.btreall.BackColor = System.Drawing.Color.DarkKhaki;
            this.btreall.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btreall.ForeColor = System.Drawing.Color.SeaGreen;
            this.btreall.Location = new System.Drawing.Point(111, 270);
            this.btreall.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btreall.Name = "btreall";
            this.btreall.Size = new System.Drawing.Size(205, 52);
            this.btreall.TabIndex = 14;
            this.btreall.Text = "从第一关开始";
            this.btreall.UseVisualStyleBackColor = false;
            this.btreall.Visible = false;
            this.btreall.Click += new System.EventHandler(this.btreall_Click);
            // 
            // btrethis
            // 
            this.btrethis.BackColor = System.Drawing.Color.DarkKhaki;
            this.btrethis.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btrethis.ForeColor = System.Drawing.Color.SeaGreen;
            this.btrethis.Location = new System.Drawing.Point(112, 335);
            this.btrethis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btrethis.Name = "btrethis";
            this.btrethis.Size = new System.Drawing.Size(204, 52);
            this.btrethis.TabIndex = 15;
            this.btrethis.Text = "本关重新开始";
            this.btrethis.UseVisualStyleBackColor = false;
            this.btrethis.Visible = false;
            this.btrethis.Click += new System.EventHandler(this.btrethis_Click);
            // 
            // btnext
            // 
            this.btnext.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnext.BackColor = System.Drawing.Color.DarkKhaki;
            this.btnext.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnext.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnext.Location = new System.Drawing.Point(411, 291);
            this.btnext.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnext.Name = "btnext";
            this.btnext.Size = new System.Drawing.Size(129, 88);
            this.btnext.TabIndex = 16;
            this.btnext.Text = "下一关";
            this.btnext.UseVisualStyleBackColor = false;
            this.btnext.Visible = false;
            this.btnext.Click += new System.EventHandler(this.btnext_Click);
            // 
            // btpause
            // 
            this.btpause.BackColor = System.Drawing.Color.Transparent;
            this.btpause.FlatAppearance.BorderSize = 0;
            this.btpause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btpause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btpause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btpause.Font = new System.Drawing.Font("黑体", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btpause.ForeColor = System.Drawing.Color.Red;
            this.btpause.Location = new System.Drawing.Point(630, 38);
            this.btpause.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btpause.Name = "btpause";
            this.btpause.Size = new System.Drawing.Size(81, 76);
            this.btpause.TabIndex = 17;
            this.btpause.Text = "暂停";
            this.btpause.UseVisualStyleBackColor = false;
            this.btpause.Visible = false;
            this.btpause.Click += new System.EventHandler(this.btpause_Click);
            // 
            // btback
            // 
            this.btback.BackColor = System.Drawing.Color.Transparent;
            this.btback.FlatAppearance.BorderSize = 0;
            this.btback.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btback.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btback.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btback.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btback.ForeColor = System.Drawing.Color.Red;
            this.btback.Location = new System.Drawing.Point(728, 38);
            this.btback.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btback.Name = "btback";
            this.btback.Size = new System.Drawing.Size(81, 76);
            this.btback.TabIndex = 18;
            this.btback.Text = "返回开始界面";
            this.btback.UseVisualStyleBackColor = false;
            this.btback.Visible = false;
            this.btback.Click += new System.EventHandler(this.btback_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(80, 677);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(502, 108);
            this.button3.TabIndex = 19;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(80, 407);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(502, 108);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // pictureinst
            // 
            this.pictureinst.BackColor = System.Drawing.Color.Transparent;
            this.pictureinst.Image = global::RatMole.Properties.Resources.starthelp;
            this.pictureinst.Location = new System.Drawing.Point(30, 214);
            this.pictureinst.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureinst.Name = "pictureinst";
            this.pictureinst.Size = new System.Drawing.Size(426, 168);
            this.pictureinst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureinst.TabIndex = 10;
            this.pictureinst.TabStop = false;
            this.pictureinst.Click += new System.EventHandler(this.pictureinst_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RatMole.Properties.Resources.tianyuan_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 839);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btback);
            this.Controls.Add(this.btpause);
            this.Controls.Add(this.btnext);
            this.Controls.Add(this.btrethis);
            this.Controls.Add(this.btreall);
            this.Controls.Add(this.labelevel);
            this.Controls.Add(this.labelaim);
            this.Controls.Add(this.labelexp);
            this.Controls.Add(this.pictureinst);
            this.Controls.Add(this.labelscroe);
            this.Controls.Add(this.labelplayer);
            this.Controls.Add(this.labelshijian);
            this.Controls.Add(this.labeltime);
            this.Controls.Add(this.labelsum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "main";
            this.Text = "打地鼠";
            this.Load += new System.EventHandler(this.main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureinst)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Timer outtime;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelscroe;
        private System.Windows.Forms.Label labelsum;
        private System.Windows.Forms.Label labelplayer;
        private System.Windows.Forms.Timer timeout;
        private System.Windows.Forms.Label labelshijian;
        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 开始ToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureinst;
        private System.Windows.Forms.ToolStripMenuItem 设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置难度ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置风格ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 普通NormalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 困难HardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 田园ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 生化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 电子ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 设置模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 闯关模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 无限模式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存成绩ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 历史成绩ToolStripMenuItem1;
        private System.Windows.Forms.Label labelexp;
        private System.Windows.Forms.Label labelaim;
        private System.Windows.Forms.Label labelevel;
        private System.Windows.Forms.Button btreall;
        private System.Windows.Forms.Button btrethis;
        private System.Windows.Forms.Button btnext;
        private System.Windows.Forms.Button btpause;
        private System.Windows.Forms.Button btback;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
    }
}