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
    public partial class login : Form
    {

        public login()
        {
            InitializeComponent();
        }

        string[] everyname = new string[10000];//用户名数组
        string[] lines = new string[10000];//读取文档里的行
        int biggervalue = 0;
        int i = 0;//读取文档里的索引
        private void login_Load(object sender, EventArgs e)
        {
            this.MinimumSize = this.MaximumSize = this.Size;
            //文件設置
            if (!File.Exists("_UsersData.txt"))//判断是否存在文档
            {
                File.Create("_UsersData.txt");
            }
            StreamReader sr = File.OpenText("_UsersData.txt");


            while ((lines[i] = sr.ReadLine()) != null)//读行
            {               
                string[] tmp = lines[i].Split('_');
                everyname[i] = tmp[1];
                if(int.Parse(tmp[0])>biggervalue)
                {
                    biggervalue = int.Parse(tmp[0]);
                }
                i++;
            }
            sr.Close();
        }   


        private void button1_Click(object sender, EventArgs e)
        {
            

            string tmpname;
            //Users.password = textBox2.Text.Trim();
            if (txbxUser.Text == "")
            {
                MessageBox.Show("请输入用户名！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txbxUser.Text != "")
            {
                tmpname = txbxUser.Text.Trim();

                for (int i=0;i<everyname.Length;i++)
                {
                    if(tmpname ==everyname[i])
                    {                       
                        Users.usersname = tmpname;
                        main frm = new main();
                        MessageBox.Show("你好," + Users.usersname + ",登录成功!", "登录信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Visible = false; frm.ShowDialog(); this.Close();                       
                        return;
                    }
                }
                MessageBox.Show("用户名不存在，请先注册！", "NotFound", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btzhuce_Click(object sender, EventArgs e)
        {
            labelyonghu.Visible = false;
            txbxUser.Visible = false;
            labelyonghuming2.Visible = true;
            txbxReg.Visible = true;
            //
            btlogin.Visible = false;
            btzhuce.Visible = false;
            btvistor.Visible = false;
            btOK.Visible = true;
            btback.Visible = true;
            //
           
        }

        private void btOK_Click(object sender, EventArgs e)
        {
           
            string tmpname;
            if (txbxReg.Text == "")
            {
                MessageBox.Show("请输入用户名！", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txbxReg.Text != "")
            {
                tmpname = txbxReg.Text.Trim();
                for (int i = 0; i < tmpname.Length; i++)
                {
                    if(tmpname[i]=='_')
                    {
                        MessageBox.Show("名称里不可带有下划线'_'。", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    if (tmpname == everyname[i])
                    {
                        MessageBox.Show("用户名已存在。", "Existed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                StreamWriter sw = new StreamWriter("_UsersData.txt", true, Encoding.UTF8);//文件流写入
                sw.WriteLine((biggervalue+1).ToString() + "_" + tmpname + "_" + "0");//追加一条新的记录
                sw.Close();
                everyname[biggervalue + 1] = tmpname; biggervalue++;
                MessageBox.Show(tmpname+",注册成功。", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);

                labelyonghu.Visible = true;
                txbxUser.Visible = true; txbxUser.Text = tmpname;
                labelyonghuming2.Visible = false;
                txbxReg.Visible = false;
                //
                btlogin.Visible = true;
                btzhuce.Visible = true;
                btvistor.Visible = true;
                btOK.Visible = false;
                btback.Visible = false;
                //
            }
        }

        private void btback_Click(object sender, EventArgs e)
        {
            labelyonghu.Visible = true;
            txbxUser.Visible = true;
            labelyonghuming2.Visible = false;
            txbxReg.Visible = false;
            //
            btlogin.Visible = true;
            btzhuce.Visible = true;
            btvistor.Visible = true;
            btOK.Visible = false;
            btback.Visible = false;
            //
        }

        private void btvistor_Click(object sender, EventArgs e)
        {            
            Users.usersname = "_Vistor";           
            main frm = new main();
            MessageBox.Show("游客登录成功！", "登录信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Visible = false; frm.ShowDialog(); this.Close();

            
            
        }
        private void btclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
