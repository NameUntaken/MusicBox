namespace KuWoMusicBox
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlContralBar = new System.Windows.Forms.Panel();
            this.picAdd = new System.Windows.Forms.PictureBox();
            this.lblTotalTime = new System.Windows.Forms.Label();
            this.lblCurrentTime = new System.Windows.Forms.Label();
            this.picSound = new System.Windows.Forms.PictureBox();
            this.picRetweet = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.pictRight = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.WMPKowo = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmrTotalTime = new System.Windows.Forms.Timer(this.components);
            this.lblLastLine = new System.Windows.Forms.Label();
            this.lblNextLine = new System.Windows.Forms.Label();
            this.lblCurrentLyric = new System.Windows.Forms.Label();
            this.lstMusic = new System.Windows.Forms.ListBox();
            this.pnlContralBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetweet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPKowo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContralBar
            // 
            this.pnlContralBar.Controls.Add(this.picAdd);
            this.pnlContralBar.Controls.Add(this.lblTotalTime);
            this.pnlContralBar.Controls.Add(this.lblCurrentTime);
            this.pnlContralBar.Controls.Add(this.picSound);
            this.pnlContralBar.Controls.Add(this.picRetweet);
            this.pnlContralBar.Controls.Add(this.picPlay);
            this.pnlContralBar.Controls.Add(this.pictRight);
            this.pnlContralBar.Controls.Add(this.picLeft);
            this.pnlContralBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContralBar.Location = new System.Drawing.Point(0, 468);
            this.pnlContralBar.Name = "pnlContralBar";
            this.pnlContralBar.Size = new System.Drawing.Size(1007, 100);
            this.pnlContralBar.TabIndex = 0;
            // 
            // picAdd
            // 
            this.picAdd.BackColor = System.Drawing.Color.Transparent;
            this.picAdd.BackgroundImage = global::KuWoMusicBox.Properties.Resources.add;
            this.picAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAdd.Location = new System.Drawing.Point(201, 23);
            this.picAdd.Name = "picAdd";
            this.picAdd.Size = new System.Drawing.Size(56, 50);
            this.picAdd.TabIndex = 3;
            this.picAdd.TabStop = false;
            this.picAdd.Click += new System.EventHandler(this.picAdd_Click);
            // 
            // lblTotalTime
            // 
            this.lblTotalTime.AutoSize = true;
            this.lblTotalTime.Location = new System.Drawing.Point(736, 58);
            this.lblTotalTime.Name = "lblTotalTime";
            this.lblTotalTime.Size = new System.Drawing.Size(103, 15);
            this.lblTotalTime.TabIndex = 2;
            this.lblTotalTime.Text = "lbltotaltime";
            // 
            // lblCurrentTime
            // 
            this.lblCurrentTime.AutoSize = true;
            this.lblCurrentTime.Location = new System.Drawing.Point(659, 58);
            this.lblCurrentTime.Name = "lblCurrentTime";
            this.lblCurrentTime.Size = new System.Drawing.Size(71, 15);
            this.lblCurrentTime.TabIndex = 1;
            this.lblCurrentTime.Text = "lblTimer";
            // 
            // picSound
            // 
            this.picSound.BackColor = System.Drawing.Color.Transparent;
            this.picSound.BackgroundImage = global::KuWoMusicBox.Properties.Resources.sound;
            this.picSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSound.Location = new System.Drawing.Point(928, 23);
            this.picSound.Name = "picSound";
            this.picSound.Size = new System.Drawing.Size(53, 50);
            this.picSound.TabIndex = 0;
            this.picSound.TabStop = false;
            this.picSound.Click += new System.EventHandler(this.picSound_Click);
            // 
            // picRetweet
            // 
            this.picRetweet.BackColor = System.Drawing.Color.Transparent;
            this.picRetweet.BackgroundImage = global::KuWoMusicBox.Properties.Resources.retweet;
            this.picRetweet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRetweet.Location = new System.Drawing.Point(845, 23);
            this.picRetweet.Name = "picRetweet";
            this.picRetweet.Size = new System.Drawing.Size(53, 50);
            this.picRetweet.TabIndex = 0;
            this.picRetweet.TabStop = false;
            this.picRetweet.Click += new System.EventHandler(this.picRetweet_Click);
            // 
            // picPlay
            // 
            this.picPlay.BackColor = System.Drawing.Color.Transparent;
            this.picPlay.BackgroundImage = global::KuWoMusicBox.Properties.Resources.play_circle_o;
            this.picPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlay.Location = new System.Drawing.Point(71, 23);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(53, 50);
            this.picPlay.TabIndex = 0;
            this.picPlay.TabStop = false;
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // pictRight
            // 
            this.pictRight.BackColor = System.Drawing.Color.Transparent;
            this.pictRight.BackgroundImage = global::KuWoMusicBox.Properties.Resources.right_circle_o;
            this.pictRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictRight.Location = new System.Drawing.Point(130, 23);
            this.pictRight.Name = "pictRight";
            this.pictRight.Size = new System.Drawing.Size(53, 50);
            this.pictRight.TabIndex = 0;
            this.pictRight.TabStop = false;
            this.pictRight.Click += new System.EventHandler(this.pictRight_Click);
            // 
            // picLeft
            // 
            this.picLeft.BackColor = System.Drawing.Color.Transparent;
            this.picLeft.BackgroundImage = global::KuWoMusicBox.Properties.Resources.left_circle_o;
            this.picLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLeft.Location = new System.Drawing.Point(12, 23);
            this.picLeft.Name = "picLeft";
            this.picLeft.Size = new System.Drawing.Size(53, 50);
            this.picLeft.TabIndex = 0;
            this.picLeft.TabStop = false;
            this.picLeft.Click += new System.EventHandler(this.picLeft_Click);
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::KuWoMusicBox.Properties.Resources.close;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(928, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(53, 50);
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // WMPKowo
            // 
            this.WMPKowo.Enabled = true;
            this.WMPKowo.Location = new System.Drawing.Point(719, 282);
            this.WMPKowo.Name = "WMPKowo";
            this.WMPKowo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPKowo.OcxState")));
            this.WMPKowo.Size = new System.Drawing.Size(160, 88);
            this.WMPKowo.TabIndex = 1;
            this.WMPKowo.Visible = false;
            // 
            // tmrTotalTime
            // 
            this.tmrTotalTime.Interval = 1000;
            this.tmrTotalTime.Tick += new System.EventHandler(this.tmrTotalTime_Tick);
            // 
            // lblLastLine
            // 
            this.lblLastLine.AutoSize = true;
            this.lblLastLine.BackColor = System.Drawing.Color.Transparent;
            this.lblLastLine.Location = new System.Drawing.Point(68, 111);
            this.lblLastLine.Name = "lblLastLine";
            this.lblLastLine.Size = new System.Drawing.Size(31, 15);
            this.lblLastLine.TabIndex = 2;
            this.lblLastLine.Text = "lst";
            // 
            // lblNextLine
            // 
            this.lblNextLine.AutoSize = true;
            this.lblNextLine.BackColor = System.Drawing.Color.Transparent;
            this.lblNextLine.Location = new System.Drawing.Point(68, 255);
            this.lblNextLine.Name = "lblNextLine";
            this.lblNextLine.Size = new System.Drawing.Size(39, 15);
            this.lblNextLine.TabIndex = 3;
            this.lblNextLine.Text = "next";
            // 
            // lblCurrentLyric
            // 
            this.lblCurrentLyric.AutoSize = true;
            this.lblCurrentLyric.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentLyric.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.lblCurrentLyric.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblCurrentLyric.Location = new System.Drawing.Point(60, 185);
            this.lblCurrentLyric.Name = "lblCurrentLyric";
            this.lblCurrentLyric.Size = new System.Drawing.Size(101, 32);
            this.lblCurrentLyric.TabIndex = 4;
            this.lblCurrentLyric.Text = "current";
            // 
            // lstMusic
            // 
            this.lstMusic.FormattingEnabled = true;
            this.lstMusic.ItemHeight = 15;
            this.lstMusic.Location = new System.Drawing.Point(689, 111);
            this.lstMusic.Name = "lstMusic";
            this.lstMusic.Size = new System.Drawing.Size(120, 94);
            this.lstMusic.TabIndex = 5;
            this.lstMusic.Visible = false;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KuWoMusicBox.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 568);
            this.Controls.Add(this.lstMusic);
            this.Controls.Add(this.lblCurrentLyric);
            this.Controls.Add(this.lblNextLine);
            this.Controls.Add(this.lblLastLine);
            this.Controls.Add(this.WMPKowo);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pnlContralBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.pnlContralBar.ResumeLayout(false);
            this.pnlContralBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetweet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPKowo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlContralBar;
        private System.Windows.Forms.PictureBox picLeft;
        private System.Windows.Forms.PictureBox picSound;
        private System.Windows.Forms.PictureBox picRetweet;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox pictRight;
        private System.Windows.Forms.PictureBox picClose;
        private AxWMPLib.AxWindowsMediaPlayer WMPKowo;
        private System.Windows.Forms.Label lblCurrentTime;
        private System.Windows.Forms.Timer tmrTotalTime;
        private System.Windows.Forms.Label lblTotalTime;
        private System.Windows.Forms.Label lblLastLine;
        private System.Windows.Forms.Label lblNextLine;
        private System.Windows.Forms.Label lblCurrentLyric;
        private System.Windows.Forms.ListBox lstMusic;
        private System.Windows.Forms.PictureBox picAdd;
    }
}

