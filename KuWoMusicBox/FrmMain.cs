using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KuWoMusicBox
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        public List<String> listsongs = new List<string>();
        int Sign = 0;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //初始化 控制栏半透明
            pnlContralBar.BackColor = Color.FromArgb(127, 200, 200, 200);

            listsongs.Add("song\\陈一发儿-童话镇.mp3");
            //加载音乐，停止播放
            WMPKowo.URL = "song\\陈一发儿-童话镇.mp3";//相对路径
            WMPKowo.Ctlcontrols.stop();

            tmrTotalTime.Start();//加载时间
    
        }

        //拖动窗体
        Point clickPoint;
        private void FrmMain_MouseDown(object sender, MouseEventArgs e)
        {
            clickPoint = new Point(e.X, e.Y);
        }

        private void FrmMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - clickPoint.X,this.Location.Y + e.Y -clickPoint.Y);
            }
        }

        //点击，关闭程序
        private void picClose_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(0);//强制关闭程序，退出
            Application.Exit();
        }

        //播放音乐
        bool isPlay = false;
        private void picPlay_Click(object sender, EventArgs e)
        {
            isPlay = !isPlay;

            //加载背景图片
            this.BackgroundImage = Image.FromFile(listsongs[Sign].Replace("song", "Image").Replace("mp3","jpg"));
            //替换播放按钮图标
            if (isPlay)
            {
                WMPKowo.Ctlcontrols.play();
                picPlay.BackgroundImage = Properties.Resources.pause_circle_o;
            }
            else
            {
                WMPKowo.Ctlcontrols.pause();
                picPlay.BackgroundImage = Properties.Resources.play_circle_o;
            }
        }

        
        private void tmrTotalTime_Tick(object sender, EventArgs e)
        {
            //记录当前时间以及总时间
            lblCurrentTime.Text = WMPKowo.Ctlcontrols.currentPositionString.ToString();
            lblTotalTime.Text = WMPKowo.currentMedia.durationString;

            LyricFiles lyricFiles = new LyricFiles();
            //lyricFiles.LoadLyric("lyric\\陈一发儿-童话镇.lrc");
            lyricFiles.LoadLyric(listsongs[Sign].Replace("mp3","lrc").Replace("song","lyric"));

            int index;
            for (index = 0; index < lyricFiles.lstLyric.Count; index++)
            {
                if (lyricFiles.lstLyric[index].currenttime > WMPKowo.Ctlcontrols.currentPosition)
                {
                    index--;
                    break;
                }
            }
            
            //int yStep = 0;
            for (int i = index; i < index + 3/*lyricFiles.lstLyric.Count*/; i++)
            {
                //Label lblLyric = new Label();
                //lblLyric.BackColor = Color.Transparent;
                //lblLyric.ForeColor = Color.White;
                //lblLyric.Size = new System.Drawing.Size(500, 30);
                //lblLyric.Font = new System.Drawing.Font("微软雅黑", 15);
                //lblLyric.Text = lyricFiles.lstLyric[i].strLyric;
                //lblLyric.Location = new Point(60, yStep);
                //yStep += 40;
                //this.Controls.Add(lblLyric);

                //当前歌词与上一句歌词、下一句歌词的逻辑替换
                if (i - 1 <=  0)
                {
                    lblLastLine.Text = "";
                    lblCurrentLyric.Text = "";
                    lblNextLine.Text = lyricFiles.lstLyric[i + 1].strLyric;
                }
                else if (i >= lyricFiles.lstLyric.Count)
                {
                    lblNextLine.Text = "";
                }
                else
                {
                    lblLastLine.Text = lblCurrentLyric.Text;
                    lblCurrentLyric.Text = lblNextLine.Text;
                    lblNextLine.Text = lyricFiles.lstLyric[i - 1].strLyric;//按逻辑应该将 i - 1 改为 i + 1 ；但是会提前两句歌词，不知道为什么
                }
                
            }

            //if (int.Parse(lblCurrentTime.Text) == lyricFiles.lstLyric[i].currenttime)
            //{
            //    yStep += 40;
            //    lblLyric.Location = new Point(60, yStep);
            //}
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择文件";
            ofd.Multiselect = true;
            ofd.InitialDirectory = @"\\song";
            ofd.Filter = "音乐文件|*.mp3|mp3文件|*.wav|所有文件|*.*"; ofd.ShowDialog();
            //获得我们在文件夹中选择所有文件的全路径            
            string[] path = ofd.FileNames;
            for (int i = 0; i < path.Length; i++)
            {
                //将音乐文件的文件名加载到ListBox中
                lstMusic.Items.Add(Path.GetFileName(path[i]));
                //将音乐文件的全路径存储到泛型集合中
                listsongs.Add(path[i]);
            }
        }

        private void picLeft_Click(object sender, EventArgs e)
        {
            int index = lstMusic.SelectedIndex;
            index--;
            if (index < 0)
            {
                index = lstMusic.Items.Count - 1;
            }            //将重新改变后的索引重新的赋值给当前选中项
            lstMusic.SelectedIndex = index;
            WMPKowo.URL = listsongs[index];

            Sign = index;
            this.BackgroundImage = Image.FromFile(listsongs[Sign].Replace("song", "Image").Replace("mp3", "jpg"));

            WMPKowo.Ctlcontrols.play();

        }

        private void pictRight_Click(object sender, EventArgs e)
        {
            int index = lstMusic.SelectedIndex;
            index++;
            if (index == lstMusic.Items.Count)
            {
                index = 0;
            }
            lstMusic.SelectedIndex = index;//
            WMPKowo.URL = listsongs[index];

            Sign = index;
            this.BackgroundImage = Image.FromFile(listsongs[Sign].Replace("song", "Image").Replace("mp3", "jpg"));

            WMPKowo.Ctlcontrols.play();
        }

        //播放方式选择
        bool playMode = true;
        private void picRetweet_Click(object sender, EventArgs e)
        {
            playMode = !playMode;
            if (playMode)
            {
                picRetweet.BackgroundImage = Properties.Resources.random;
                WMPKowo.settings.setMode("shuffle", true);//随机播放
            }
            else
            {
                picRetweet.BackgroundImage = Properties.Resources.retweet;
                WMPKowo.settings.setMode("loop", true);//循环播放
            }
                
        }

        //静音选项
        private void picSound_Click(object sender, EventArgs e)
        {
            if (WMPKowo.settings.volume == 0)
            {
                picSound.BackgroundImage = Properties.Resources.sound;
                WMPKowo.settings.volume = 70;
            }
            else
            {
                picSound.BackgroundImage = Properties.Resources.mute;
                WMPKowo.settings.volume = 0;
            }
        }
    }
}
