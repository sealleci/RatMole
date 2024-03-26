using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace RatMole
{
    public partial class scorelist : Form
    {
        public scorelist()
        {
            InitializeComponent();
        }

        private void scorelist_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = this.MaximumSize = this.Size;
            chart1.BackColor = System.Drawing.Color.Transparent;

            int[] score = new int[10000];
            StreamReader sr = File.OpenText("_UsersData.txt");
            string[] lines = new string[10000];
            string[] everyname = new string[10000];
            int i = 0;
            while ((lines[i] = sr.ReadLine()) != null)
            {
                string[] tmp = lines[i].Split('_');
                int tmpnum = int.Parse(tmp[2]);
                everyname[int.Parse(tmp[0])] = tmp[1];               
                if (score[int.Parse(tmp[0])] < tmpnum)
                {
                    score[int.Parse(tmp[0])] = tmpnum;
                }
                i++;
            }
            sr.Close();
            for(int v=0;everyname[v]!=null;v++)
            {
                cmbname.Items.Add(everyname[v]);
            }
            for (int j = 0; j < score.Length - 1; j++)
            {
                if (everyname[j] == null)
                {
                    break;
                }
                else
                { 
                    for (int k = 0; k < score.Length - 1 - j; k++)
                    {
                        if (everyname[k] == null)
                        {
                            break;
                        }
                        else
                        {
                            if (score[k] < score[k + 1])
                            {
                                int tmp = score[k];
                                score[k] = score[k + 1];
                                score[k + 1] = tmp;

                                string media = everyname[k];
                                everyname[k] = everyname[k + 1];
                                everyname[k + 1] = media;
                            }
                        }
                    }
                }
            }
            for (int j = 0; j<score.Length; j++)
            {
                if (everyname[j] == null)
                {
                    break;
                }
                else
                {
                    listBox1.Items.Add((j + 1).ToString() + "." + everyname[j] + ",得分:" + score[j]);
                }
            }
            
        }

        private void cmbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            StreamReader sr = File.OpenText("_UsersData.txt");
            string[] lines = new string[10000];
            ArrayList historyvalue = new ArrayList();
            int i = 0;
            while ((lines[i] = sr.ReadLine()) != null)
            {
                string[] tmp = lines[i].Split('_');
                if(int.Parse(tmp[0])==cmbname.SelectedIndex)
                {
                    if (tmp[2] != "0")
                    {
                        historyvalue.Add(int.Parse(tmp[2]));
                    }
                }
                i++;
            }
            chart1.Series["Series1"].Points.DataBindY(historyvalue);
            for (int j=0; j<historyvalue.Count;j++)
            {
                chart1.Series["Series1"].Points[j].LegendText="第"+(j+1).ToString()+"次";
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
