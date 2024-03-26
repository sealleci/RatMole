using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace RatMole
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            labelname.Text = Users.usersname;
            Bitmap a = (Bitmap)Bitmap.FromFile("hammer.png");
            SetCursor(a, new Point(12, 27));
        }
        public void SetCursor(Bitmap cursor, Point hotPoint)
        {
            int hotX = hotPoint.X;
            int hotY = hotPoint.Y;
            Bitmap myNewCursor = new Bitmap(cursor.Width * 2 - hotX, cursor.Height * 2 - hotY);
            Graphics g = Graphics.FromImage(myNewCursor);
            g.Clear(Color.FromArgb(0, 0, 0, 0));
            g.DrawImage(cursor, cursor.Width - hotX, cursor.Height - hotY, cursor.Width,
            cursor.Height);
            this.Cursor = new Cursor(myNewCursor.GetHicon());

            g.Dispose();
            myNewCursor.Dispose();
        }
        struct dishu//构建地鼠属性
        {
            public int flag;//flag用來表示觸沒觸動，1/2/3為動，0/4不動。
            public int origintop;//原始位置
            public int roadlength;//移动长度
            public int stoptime;//停留时间
            public int hittime;
            public Button bt;
            public Label lb;
        }
        dishu[] btay = new dishu[9];

        struct start//构建游戏模式属性
        {
            public int diffty;//难度标志
            public int style;//风格标志
            public int mode;//模式标志
        }
        start gamestart = new start();
        
        //formload时初始化时构建动态按钮
        private void main_Load(object sender, EventArgs e)
        {
            login li = new login();
            li.Close();
            this.MaximumSize = this.MinimumSize = this.Size;
            for (int i=0;i<9;i++)
            {

                Button tmp = new Button();
                tmp.Enabled = false;tmp.Visible = false;
                tmp.Size = new Size(45, 65);
                tmp.Location = new Point(55+(i%3)*140, 90+(i/3)*180);
                tmp.Image = Image.FromFile("dishu1.png");tmp.AutoSize = true;
                tmp.BackColor = Color.Transparent;
                //tmp.Cursor = Cursors.Hand;
                tmp.FlatStyle = FlatStyle.Flat;
                tmp.FlatAppearance.BorderSize = 0;
                tmp.FlatAppearance.MouseDownBackColor = Color.Transparent;
                tmp.FlatAppearance.MouseOverBackColor = Color.Transparent;
                Controls.Add(tmp);

                Label tmp2 = new Label();
                tmp2.Visible = false;
                tmp2.AutoSize = true;
                tmp2.BringToFront();
                tmp2.Location = new Point(47 + (i % 3) * 140, 90 + (i / 3) * 180);
                tmp2.BackColor = Color.Transparent;
                tmp2.BorderStyle = BorderStyle.None;
                tmp2.FlatStyle = FlatStyle.Flat;
                tmp2.Font = new Font("OCR A Std", 14, FontStyle.Bold);
                tmp2.ForeColor = Color.DarkViolet;
                Controls.Add(tmp2);          

                btay[i].bt = tmp; btay[i].bt.SendToBack();
                btay[i].origintop = btay[i].bt.Top;
                btay[i].lb = tmp2; btay[i].lb.BringToFront();
                btay[i].hittime = 8;
                btay[i].flag = 0;
                btay[i].roadlength = 56;
                btay[i].stoptime = 25;                
                btay[i].bt.Click +=new EventHandler(Bt_Click);
            }
            /*FlagChange(3);
            outtime.Start();timeout.Start();*/
        }

        //敲地鼠事件
        private void Bt_Click(object sender, EventArgs e)
        {
            total++;labelsum.Text = total.ToString();
            Button bt = (Button)sender;
            for (int i = 0; i < 9; i++)
            {
                if (bt == btay[i].bt)
                {
                    btay[i].flag = 4;
                    //FlagChange(1);
                    //btay[i].flag = 0;
                    //btay[i].roadlength = 54;
                    //btay[i].bt.Top = btay[i].origintop;
                }
            }
        }

        //生成地鼠出洞
        void FlagChange(int count)
        {
            Random RD = new Random();
            while(count>0)
            {
                int tmp = RD.Next(0, 9);
                if (btay[tmp].flag==0)
                {
                    btay[tmp].flag = 1;
                    count--;
                }
            }
        }

        //地鼠出入的timer
        private void Outtime_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i <9; i++)
            {
                if (btay[i].flag == 1)
                {
                    btay[i].bt.Top-= speed;
                    btay[i].roadlength-= speed;
                    if(btay[i].roadlength<=0)
                    {
                        btay[i].flag = 2;
                    }
                }

                if (btay[i].flag == 2)
                {
                    btay[i].bt.Enabled = true;
                    btay[i].stoptime-=stptime;
                    if (btay[i].stoptime <= 0)
                    {
                        btay[i].flag = 3;
                        btay[i].stoptime = 20;
                    }

                }

                if (btay[i].flag == 3)
                {
                    btay[i].bt.Enabled = false;
                    btay[i].bt.Top += speed;
                    btay[i].roadlength += speed;

                    btay[i].lb.Text = "MISS~";
                    btay[i].lb.Visible = true;
                    btay[i].lb.Top = btay[i].bt.Top;

                    if (btay[i].roadlength >= 56)
                    {
                        btay[i].lb.Visible = false;
                        btay[i].lb.Text = "";
                        btay[i].flag = 0;
                        FlagChange(1);
                    }
                }

                if (btay[i].flag == 4)
                {
                    if (gamestart.style == 1)
                    {
                        btay[i].bt.Image = Image.FromFile("dishu11.png");
                    }
                    if (gamestart.style == 2)
                    {
                        btay[i].bt.Image = Image.FromFile("dishu22.png");
                    }
                    if (gamestart.style == 3)
                    {
                        btay[i].bt.Image = Image.FromFile("dishu33.png");
                    }
                    btay[i].lb.Text = "BANG!!";
                    btay[i].lb.Visible = true;
                    btay[i].lb.Top = btay[i].bt.Top;

                    btay[i].bt.Enabled = false;
                    btay[i].hittime--;
                    if (btay[i].hittime == 0)
                    {
                        if (gamestart.style == 1)
                        {
                            btay[i].bt.Image = Image.FromFile("dishu1.png");
                           
                        }
                        if (gamestart.style == 2)
                        {
                            btay[i].bt.Image = Image.FromFile("dishu2.png");
                            
                        }
                        if (gamestart.style == 3)
                        {
                            btay[i].bt.Image = Image.FromFile("dishu3.png");
                           
                        }
                        btay[i].bt.Enabled = true;
                        FlagChange(1);
                        btay[i].flag = 0;
                        btay[i].stoptime = 20;
                        btay[i].hittime = 8;
                        btay[i].roadlength = 56;
                        btay[i].bt.Top = btay[i].origintop;
                        btay[i].lb.Visible = false;
                        btay[i].lb.Text = "";
                    }
                }
            }
        }

        //点击开始设计
        private void 开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(btpause.Text=="解除暂停")
            {
                outtime.Enabled = true;
                if (gamestart.mode == 1)
                {
                    timeout.Enabled = true;
                }
                for (int i = 0; i < 9; i++)
                {
                    btay[i].bt.Enabled = true;
                }
                btpause.Text = "暂停";
                pauseflag = 1;
            }
            //判断难度模式风格
            //难度
            if(普通NormalToolStripMenuItem.Checked)
            {
                gamestart.diffty = 1;
            }
            else if(困难HardToolStripMenuItem.Checked)
            {
                gamestart.diffty = 2;
            }
            else if(普通NormalToolStripMenuItem.Checked==false&&困难HardToolStripMenuItem.Checked==false)
            {
                gamestart.diffty = 1;
            }
            //
            //风格
            if(田园ToolStripMenuItem.Checked)
            {
                gamestart.style = 1;
            }
            else if(生化ToolStripMenuItem.Checked)
            {
                gamestart.style = 2;
            }
            else if(电子ToolStripMenuItem.Checked)
            {
                gamestart.style = 3;
            }
            else if(田园ToolStripMenuItem.Checked==false&&生化ToolStripMenuItem.Checked==false&&电子ToolStripMenuItem.Checked==false)
            {
                gamestart.style = 1;
            }
            //
            //模式
            if (闯关模式ToolStripMenuItem.Checked)
            {
                gamestart.mode = 1;
            }
            else if (无限模式ToolStripMenuItem.Checked)
            {
                gamestart.mode = 2;
            }
            else if(闯关模式ToolStripMenuItem.Checked==false&&无限模式ToolStripMenuItem.Checked==false)
            {
                gamestart.mode = 1;
            }
            //
            //mode
            switch(gamestart.mode)
            {
                case 1:
                    Guanqia();
                     break;
                case 2:
                    Unlimit();
                    break;
            }
            //
            //difficuty
            switch(gamestart.diffty)
            {
                case 1:
                    outtime.Interval = 60;
                    break;
                case 2:
                    outtime.Interval = 40;
                    break;
            }
            //style
            switch (gamestart.style)
            {
                case 1:
                    this.BackgroundImage = Image.FromFile("tianyuan_bg.png");
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    for (int i = 0; i < 9; i++)
                    {
                        btay[i].bt.Image = Image.FromFile("dishu1.png");
                    }
                        break;
                case 2:
                    this.BackgroundImage = Image.FromFile("shenghua_bg.png");
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    for (int i = 0; i < 9; i++)
                    {
                        btay[i].bt.Image = Image.FromFile("dishu2.png");
                    }
                    break;
                case 3:
                    this.BackgroundImage = Image.FromFile("dianzi_bg.png");
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                    for (int i = 0; i < 9; i++)
                    {
                        btay[i].bt.Image = Image.FromFile("dishu3.png");
                    }
                    break;

            }

        }

        //关卡设计
        //公共变量
        int level = 1;
        int total = 0;
        int lvtime;
        int aim = 0;
        int speed = 8;
        int stptime = 1;

        void Guanqia()
        {
            switch (level)
            {
                case 1:
                    total = 0; labelsum.Text = total.ToString();
                    labelevel.Text = "第" + level.ToString() + "关";
                    aim = 5; labelaim.Text = aim.ToString();
                    lvtime = 500;
                    speed = 8; stptime = 1;
                    LvInitia();
                    FlagChange(2);
                    outtime.Start(); timeout.Start();
                    break;
                case 2:
                    total = 0; labelsum.Text = total.ToString();
                    labelevel.Text = "第" + level.ToString() + "关";
                    aim = 12; labelaim.Text = aim.ToString();
                    lvtime = 400;
                    speed = 10; stptime = 1;
                    LvInitia();
                    FlagChange(3);
                    outtime.Start(); timeout.Start();
                    break;
                case 3:
                    total = 0; labelsum.Text = total.ToString();
                    labelevel.Text = "第" + level.ToString() + "关";
                    aim = 10; labelaim.Text = aim.ToString();
                    lvtime = 350;
                    speed = 12; stptime = 2;
                    LvInitia();
                    FlagChange(3);
                    outtime.Start(); timeout.Start();
                    break;
                case 4:
                    total = 0; labelsum.Text = total.ToString();
                    labelevel.Text = "第" + level.ToString() + "关";
                    aim = 8; labelaim.Text = aim.ToString();
                    lvtime = 300;
                    speed = 14; stptime = 2;
                    LvInitia();
                    FlagChange(4);
                    outtime.Start(); timeout.Start();
                    break;
                case 5:
                    total = 0; labelsum.Text = total.ToString();
                    labelevel.Text = "第" + level.ToString() + "关";
                    aim = 4; labelaim.Text = aim.ToString();
                    lvtime = 250;
                    speed = 14; stptime = 3;
                    LvInitia();
                    FlagChange(5);
                    outtime.Start(); timeout.Start();
                    break;
            }
        }
        void Unlimit()
        {
            total = 0; labelsum.Text = total.ToString();
            labelevel.Text = "无限模式∞";
            labelaim.Text = "None";
            labeltime.Text = "∞";
            speed = 9; stptime = 2;
            LvInitia();
            FlagChange(4);
            outtime.Start();
            timeout.Stop();
        }

        void LvInitia()
        {
            btback.Visible = true;
            btpause.Visible = true;
            btpause.Enabled = true;

            btrethis.Visible = false;
            btreall.Visible = false;
            btnext.Visible = false;

            pictureinst.Visible = false;
            for (int i = 0; i < 9; i++)
            {
                btay[i].bt.Visible = true;
                btay[i].bt.Enabled = true;
                btay[i].lb.Visible = false;
                btay[i].lb.Text = "";
                btay[i].flag = 0;
                btay[i].stoptime = 25;
                btay[i].hittime = 8;
                btay[i].roadlength = 56;
                btay[i].bt.Top = btay[i].origintop;
                if (gamestart.style == 1)
                {
                    btay[i].bt.Image = Image.FromFile("dishu1.png");
                }
                if (gamestart.style == 2)
                {
                    btay[i].bt.Image = Image.FromFile("dishu2.png");
                }
                if (gamestart.style == 3)
                {
                    btay[i].bt.Image = Image.FromFile("dishu3.png");
                }

            }
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
        }

        void UnInitia()
        {
            btback.Visible = false;
            btpause.Visible = false;
            btpause.Enabled = false;

            btrethis.Visible = false;
            btreall.Visible = false;
            btnext.Visible = false;

            pictureinst.Visible = true;
            for (int i = 0; i < 9; i++)
            {
                btay[i].bt.Visible = false;
                btay[i].bt.Enabled = false;
                btay[i].lb.Visible = false;
                btay[i].lb.Text = "";
                btay[i].flag = 0;
                btay[i].stoptime = 20;
                btay[i].hittime = 8;
                btay[i].roadlength = 56;
                btay[i].bt.Top = btay[i].origintop;
                if (gamestart.style == 1)
                {
                    btay[i].bt.Image = Image.FromFile("dishu1.png");
                }
                if (gamestart.style == 2)
                {
                    btay[i].bt.Image = Image.FromFile("dishu2.png");
                }
                if (gamestart.style == 3)
                {
                    btay[i].bt.Image = Image.FromFile("dishu3.png");
                }
            }
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
        }

        //
        //关卡输赢判断
        private void timeout_Tick(object sender, EventArgs e)
        {
            labeltime.Text = (lvtime/10).ToString();
            lvtime--;
            if(lvtime > 0&& total >= aim)
            {
                if (level == 5)
                {
                    outtime.Enabled = false;
                    timeout.Enabled = false;
                    MessageBox.Show("通关了!");
                    UnInitia();
                    level = 1;
                    labelaim.Text = "--"; labelsum.Text = "--";
                    labeltime.Text = "--"; labelevel.Text = "--";
                }
                else
                {
                    outtime.Enabled = false;
                    timeout.Enabled = false;
                    MessageBox.Show("过关了!","Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    btnext.Visible = true;
                    btrethis.Visible = true;
                    btreall.Visible = true;
                    
                    btpause.Visible = false;
                }
            }
            if (lvtime < 0)
            {
                timeout.Enabled = false;
                outtime.Enabled = false;
                btpause.Enabled = false;
                if (total<aim)
                {
                    MessageBox.Show("闯关失败。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btrethis.Visible = true;
                    btreall.Visible = true;

                    btpause.Visible = false;
                }
            }
        }

        //
        private void btnext_Click(object sender, EventArgs e)
        {
            level++;
            Guanqia();
        }
        private void btrethis_Click(object sender, EventArgs e)
        {
            Guanqia();
        }
        private void btreall_Click(object sender, EventArgs e)
        {
            level = 1;
            Guanqia();
        }

        int pauseflag = 1;
        private void btpause_Click(object sender, EventArgs e)
        {
            switch (pauseflag)
            {
                case 1:
                    outtime.Enabled = false;
                    timeout.Enabled = false;
                    for (int i = 0; i < 9; i++)
                    {
                        btay[i].bt.Enabled = false;
                    }
                    pauseflag = 2;
                    btpause.Text = "解除暂停";
                    break;
                case 2:
                    outtime.Enabled = true;
                    if (gamestart.mode == 1)
                    {
                        timeout.Enabled = true;
                    }
                    for (int i = 0; i < 9; i++)
                    {
                        btay[i].bt.Enabled = true;
                    }
                    btpause.Text = "暂停";
                    pauseflag = 1;
                    break;

            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            UnInitia();
            level = 1;
            outtime.Enabled = false;
            timeout.Enabled = false;
            labelaim.Text = "--"; labelsum.Text = "--";
            labeltime.Text = "--"; labelevel.Text = "--";
        }
        //
        //menu设计
        private void 困难HardToolStripMenuItem_CheckedChanged(object sender, EventArgs e)//难度共享
        {
            ToolStripMenuItem tl = (ToolStripMenuItem)sender;
                if(tl.Checked)
                {
                    if(tl==普通NormalToolStripMenuItem)
                    {
                        困难HardToolStripMenuItem.Checked = false;
                    }
                    if (tl == 困难HardToolStripMenuItem)
                    {
                        普通NormalToolStripMenuItem.Checked = false;
                    }
                }
        }

        private void 田园ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem tl = (ToolStripMenuItem)sender;
           if(tl.Checked)
            {
                if(tl==田园ToolStripMenuItem)
                {
                    生化ToolStripMenuItem.Checked = false;
                    电子ToolStripMenuItem.Checked = false;
                }
                if (tl == 生化ToolStripMenuItem)
                {
                    田园ToolStripMenuItem.Checked = false;
                    电子ToolStripMenuItem.Checked = false;
                }
                if (tl == 电子ToolStripMenuItem)
                {
                    田园ToolStripMenuItem.Checked = false;
                    生化ToolStripMenuItem.Checked = false;
                }
            }
        }

        private void 闯关模式ToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem tl = (ToolStripMenuItem)sender;
            if (tl.Checked)
            {
                if (tl == 闯关模式ToolStripMenuItem)
                {
                    无限模式ToolStripMenuItem.Checked = false;
                }
                if (tl == 无限模式ToolStripMenuItem)
                {
                    闯关模式ToolStripMenuItem.Checked = false;
                }
            }
        }

        private void 历史成绩ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            scorelist sl = new scorelist();
            sl.Show();
        }

        private void 保存成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (labelname.Text == "_Vistor")
            {
                MessageBox.Show("游客模式下不能保存。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if(labelsum.Text== "--")
            {
                MessageBox.Show("暂无分数，不能保存。", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                StreamReader sr = File.OpenText("_UsersData.txt");
                string[] lines = new string[10000];
                int i = 0;
                while ((lines[i] = sr.ReadLine()) != null)
                {
                    string[] tmp = lines[i].Split('_');
                    if(labelname.Text==tmp[1])
                    {                          
                        sr.Close();
                        StreamWriter sw = new StreamWriter("_UsersData.txt", true, Encoding.UTF8);
                        sw.WriteLine(tmp[0] + "_" + tmp[1] +"_"+ labelsum.Text);
                        sw.Close();
                        MessageBox.Show(labelname.Text + ",保存成功。", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                    }
                    i++;
                }
                
            }
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpform hf = new helpform();
            hf.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btpause_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.P)
            {
                this.btpause_Click(sender, e);
            }
            if (e.KeyCode == Keys.R)
            {
                this.btback_Click(sender, e);
            }
            if(e.KeyCode==Keys.Escape)
            {
                this.Close();
            }
        }

        private void 设置风格ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureinst_Click(object sender, EventArgs e)
        {

        }
    }
}
