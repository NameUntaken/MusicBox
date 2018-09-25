using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //初始化 控制栏半透明
            pnlContralBar.BackColor = Color.FromArgb(127, 200, 200, 200);

            //加载音乐，停止播放
            WMPKowo.URL = "song\\陈一发儿-童话镇.mp3";//相对路径
            WMPKowo.Ctlcontrols.stop();
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

        bool isPlay = false;
        private void picPlay_Click(object sender, EventArgs e)
        {
            isPlay = !isPlay;

            if(isPlay)
        }
    }
}
