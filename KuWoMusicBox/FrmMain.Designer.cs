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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pnlContralBar = new System.Windows.Forms.Panel();
            this.picSound = new System.Windows.Forms.PictureBox();
            this.picRetweet = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.pictRight = new System.Windows.Forms.PictureBox();
            this.picLeft = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.WMPKowo = new AxWMPLib.AxWindowsMediaPlayer();
            this.pnlContralBar.SuspendLayout();
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
            // picSound
            // 
            this.picSound.BackColor = System.Drawing.Color.Transparent;
            this.picSound.BackgroundImage = global::KuWoMusicBox.Properties.Resources.sound;
            this.picSound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSound.Location = new System.Drawing.Point(881, 23);
            this.picSound.Name = "picSound";
            this.picSound.Size = new System.Drawing.Size(53, 50);
            this.picSound.TabIndex = 0;
            this.picSound.TabStop = false;
            // 
            // picRetweet
            // 
            this.picRetweet.BackColor = System.Drawing.Color.Transparent;
            this.picRetweet.BackgroundImage = global::KuWoMusicBox.Properties.Resources.retweet;
            this.picRetweet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picRetweet.Location = new System.Drawing.Point(731, 23);
            this.picRetweet.Name = "picRetweet";
            this.picRetweet.Size = new System.Drawing.Size(53, 50);
            this.picRetweet.TabIndex = 0;
            this.picRetweet.TabStop = false;
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
            // 
            // picClose
            // 
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.BackgroundImage = global::KuWoMusicBox.Properties.Resources.close;
            this.picClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picClose.Location = new System.Drawing.Point(942, 12);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(53, 50);
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // WMPKowo
            // 
            this.WMPKowo.Enabled = true;
            this.WMPKowo.Location = new System.Drawing.Point(371, 289);
            this.WMPKowo.Name = "WMPKowo";
            this.WMPKowo.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMPKowo.OcxState")));
            this.WMPKowo.Size = new System.Drawing.Size(160, 88);
            this.WMPKowo.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KuWoMusicBox.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1007, 568);
            this.Controls.Add(this.WMPKowo);
            this.Controls.Add(this.picClose);
            this.Controls.Add(this.pnlContralBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseMove);
            this.pnlContralBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSound)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRetweet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WMPKowo)).EndInit();
            this.ResumeLayout(false);

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
    }
}

