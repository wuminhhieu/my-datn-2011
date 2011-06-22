namespace PNRSCtrl
{
    partial class frmPNRSView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSwitchUser = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngGiáToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPriceList = new System.Windows.Forms.ToolStripMenuItem();
            this.trợGiúpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plateNumberInfoView1 = new DisplayCtrl.PlateNumberInfoView();
            this.videoView1 = new DisplayCtrl.VideoView();
            this.toolStripSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.bảngGiáToolStripMenuItem,
            this.trợGiúpToolStripMenuItem,
            this.toolStripSearch});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đăngXuấtToolStripMenuItem,
            this.toolStripSwitchUser});
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            // 
            // toolStripSwitchUser
            // 
            this.toolStripSwitchUser.Name = "toolStripSwitchUser";
            this.toolStripSwitchUser.Size = new System.Drawing.Size(173, 22);
            this.toolStripSwitchUser.Text = "Chuyển Nhân Viên";
            this.toolStripSwitchUser.Click += new System.EventHandler(this.toolStripSwitchUser_Click);
            // 
            // bảngGiáToolStripMenuItem
            // 
            this.bảngGiáToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripPriceList});
            this.bảngGiáToolStripMenuItem.Name = "bảngGiáToolStripMenuItem";
            this.bảngGiáToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.bảngGiáToolStripMenuItem.Text = "Bảng giá";
            // 
            // toolStripPriceList
            // 
            this.toolStripPriceList.Name = "toolStripPriceList";
            this.toolStripPriceList.Size = new System.Drawing.Size(152, 22);
            this.toolStripPriceList.Text = "Xem";
            this.toolStripPriceList.Click += new System.EventHandler(this.toolStriptoolStripPriceList_Click);
            // 
            // trợGiúpToolStripMenuItem
            // 
            this.trợGiúpToolStripMenuItem.Name = "trợGiúpToolStripMenuItem";
            this.trợGiúpToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.trợGiúpToolStripMenuItem.Text = "Trợ giúp";
            this.trợGiúpToolStripMenuItem.Click += new System.EventHandler(this.trợGiúpToolStripMenuItem_Click);
            // 
            // plateNumberInfoView1
            // 
            this.plateNumberInfoView1.Location = new System.Drawing.Point(461, 27);
            this.plateNumberInfoView1.Name = "plateNumberInfoView1";
            this.plateNumberInfoView1.Size = new System.Drawing.Size(801, 479);
            this.plateNumberInfoView1.TabIndex = 2;
            // 
            // videoView1
            // 
            this.videoView1.Location = new System.Drawing.Point(12, 27);
            this.videoView1.Name = "videoView1";
            this.videoView1.Size = new System.Drawing.Size(443, 459);
            this.videoView1.TabIndex = 1;
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(69, 20);
            this.toolStripSearch.Text = "Tìm kiếm";
            this.toolStripSearch.Click += new System.EventHandler(this.toolStripSearch_Click);
            // 
            // frmPNRSView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 515);
            this.Controls.Add(this.plateNumberInfoView1);
            this.Controls.Add(this.videoView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPNRSView";
            this.Text = "TFM";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPNRSView_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngGiáToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trợGiúpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripSwitchUser;
        private System.Windows.Forms.ToolStripMenuItem toolStripPriceList;
        private DisplayCtrl.VideoView videoView1;
        private DisplayCtrl.PlateNumberInfoView plateNumberInfoView1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSearch;
    }
}

