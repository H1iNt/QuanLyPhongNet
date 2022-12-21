namespace QuanLyPhongNet
{
    partial class fQuanLyPhongNet
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
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinTàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinCáNhânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lsvHoaDon = new System.Windows.Forms.ListView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbMenu = new System.Windows.Forms.ComboBox();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.cbMonAn = new System.Windows.Forms.ComboBox();
            this.nmSoLuongMon = new System.Windows.Forms.NumericUpDown();
            this.flpMay = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnChuyenMay = new System.Windows.Forms.Button();
            this.cbChuyenMay = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongMon)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adminToolStripMenuItem,
            this.thôngTinTàiKhoảnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            this.thôngTinTàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinCáNhânToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            this.thôngTinTàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // thôngTinCáNhânToolStripMenuItem
            // 
            this.thôngTinCáNhânToolStripMenuItem.Name = "thôngTinCáNhânToolStripMenuItem";
            this.thôngTinCáNhânToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.thôngTinCáNhânToolStripMenuItem.Text = "Thông tin cá nhân";
            this.thôngTinCáNhânToolStripMenuItem.Click += new System.EventHandler(this.thôngTinCáNhânToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lsvHoaDon);
            this.panel2.Location = new System.Drawing.Point(493, 109);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(537, 377);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbChuyenMay);
            this.panel3.Controls.Add(this.btnChuyenMay);
            this.panel3.Controls.Add(this.btnThanhToan);
            this.panel3.Location = new System.Drawing.Point(493, 492);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(537, 72);
            this.panel3.TabIndex = 3;
            // 
            // lsvHoaDon
            // 
            this.lsvHoaDon.HideSelection = false;
            this.lsvHoaDon.Location = new System.Drawing.Point(4, 7);
            this.lsvHoaDon.Name = "lsvHoaDon";
            this.lsvHoaDon.Size = new System.Drawing.Size(530, 367);
            this.lsvHoaDon.TabIndex = 0;
            this.lsvHoaDon.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nmSoLuongMon);
            this.panel4.Controls.Add(this.cbMonAn);
            this.panel4.Controls.Add(this.btnThemMon);
            this.panel4.Controls.Add(this.cbMenu);
            this.panel4.Location = new System.Drawing.Point(493, 38);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(536, 65);
            this.panel4.TabIndex = 4;
            // 
            // cbMenu
            // 
            this.cbMenu.FormattingEnabled = true;
            this.cbMenu.Location = new System.Drawing.Point(3, 4);
            this.cbMenu.Name = "cbMenu";
            this.cbMenu.Size = new System.Drawing.Size(267, 21);
            this.cbMenu.TabIndex = 0;
            // 
            // btnThemMon
            // 
            this.btnThemMon.Location = new System.Drawing.Point(276, 4);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(107, 48);
            this.btnThemMon.TabIndex = 1;
            this.btnThemMon.Text = "Thêm";
            this.btnThemMon.UseVisualStyleBackColor = true;
            this.btnThemMon.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbMonAn
            // 
            this.cbMonAn.FormattingEnabled = true;
            this.cbMonAn.Location = new System.Drawing.Point(3, 31);
            this.cbMonAn.Name = "cbMonAn";
            this.cbMonAn.Size = new System.Drawing.Size(267, 21);
            this.cbMonAn.TabIndex = 2;
            // 
            // nmSoLuongMon
            // 
            this.nmSoLuongMon.Location = new System.Drawing.Point(425, 20);
            this.nmSoLuongMon.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmSoLuongMon.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.nmSoLuongMon.Name = "nmSoLuongMon";
            this.nmSoLuongMon.Size = new System.Drawing.Size(98, 20);
            this.nmSoLuongMon.TabIndex = 3;
            // 
            // flpMay
            // 
            this.flpMay.Location = new System.Drawing.Point(0, 38);
            this.flpMay.Name = "flpMay";
            this.flpMay.Size = new System.Drawing.Size(490, 526);
            this.flpMay.TabIndex = 5;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(331, 3);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(172, 66);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            this.btnThanhToan.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnChuyenMay
            // 
            this.btnChuyenMay.Location = new System.Drawing.Point(37, 3);
            this.btnChuyenMay.Name = "btnChuyenMay";
            this.btnChuyenMay.Size = new System.Drawing.Size(172, 40);
            this.btnChuyenMay.TabIndex = 5;
            this.btnChuyenMay.Text = "Chuyển Máy";
            this.btnChuyenMay.UseVisualStyleBackColor = true;
            this.btnChuyenMay.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // cbChuyenMay
            // 
            this.cbChuyenMay.FormattingEnabled = true;
            this.cbChuyenMay.Location = new System.Drawing.Point(37, 48);
            this.cbChuyenMay.Name = "cbChuyenMay";
            this.cbChuyenMay.Size = new System.Drawing.Size(172, 21);
            this.cbChuyenMay.TabIndex = 4;
            // 
            // fQuanLyPhongNet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 573);
            this.Controls.Add(this.flpMay);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.menuStrip1);
            this.Name = "fQuanLyPhongNet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần Mềm Quản Lý Phòng Net";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinCáNhânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lsvHoaDon;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.ComboBox cbMenu;
        private System.Windows.Forms.ComboBox cbMonAn;
        private System.Windows.Forms.NumericUpDown nmSoLuongMon;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.FlowLayoutPanel flpMay;
        private System.Windows.Forms.Button btnChuyenMay;
        private System.Windows.Forms.ComboBox cbChuyenMay;
    }
}