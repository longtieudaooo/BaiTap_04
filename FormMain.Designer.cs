namespace Bai_tap_04
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.menuHeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCuaSo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTileVertical = new System.Windows.Forms.ToolStripMenuItem();

            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsbStudent = new System.Windows.Forms.ToolStripButton();
            this.tsbProduct = new System.Windows.Forms.ToolStripButton();

            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.lblUserStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblMessageStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTimeStatus = new System.Windows.Forms.ToolStripStatusLabel();

            this.timerClock = new System.Windows.Forms.Timer(this.components);

            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.ssMain.SuspendLayout();
            this.SuspendLayout();

            // MenuStrip
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuHeThong,
                this.menuDanhMuc,
                this.menuCuaSo
            });
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(1008, 24);

            // Menu Hệ thống
            this.menuHeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuLogout,
                this.menuExit
            });
            this.menuHeThong.Text = "Hệ thống";

            this.menuLogout.Text = "Đăng xuất";
            this.menuExit.Text = "Thoát";

            // Menu Danh mục
            this.menuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuStudent,
                this.menuProduct
            });
            this.menuDanhMuc.Text = "Danh mục";

            this.menuStudent.Text = "Quản lý Sinh viên";
            this.menuProduct.Text = "Quản lý Sản phẩm";

            // Menu Cửa sổ
            this.menuCuaSo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuCascade,
                this.menuTileHorizontal,
                this.menuTileVertical
            });
            this.menuCuaSo.Text = "Cửa sổ";

            this.menuCascade.Text = "Cascade";
            this.menuTileHorizontal.Text = "Tile Horizontal";
            this.menuTileVertical.Text = "Tile Vertical";

            // ToolStrip
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsbStudent,
                this.tsbProduct
            });
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1008, 25);

            this.tsbStudent.Text = "QL Sinh Viên";
            this.tsbProduct.Text = "QL Sản Phẩm";

            // StatusStrip
            this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblUserStatus,
                this.lblMessageStatus,
                this.lblTimeStatus
            });
            this.ssMain.Location = new System.Drawing.Point(0, 639);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(1008, 22);

            this.lblUserStatus.Text = "Người dùng: Admin | ";
            this.lblMessageStatus.Spring = true;
            this.lblMessageStatus.Text = "Sẵn sàng";
            this.lblMessageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTimeStatus.Text = "00:00:00";

            // Timer
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;

            // FormMain (MDI Parent)
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 661);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hệ Thống Quản Lý Đa Cửa Sổ (MDI Application)";

            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.ssMain.ResumeLayout(false);
            this.ssMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem menuHeThong;
        private System.Windows.Forms.ToolStripMenuItem menuLogout;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem menuStudent;
        private System.Windows.Forms.ToolStripMenuItem menuProduct;
        private System.Windows.Forms.ToolStripMenuItem menuCuaSo;
        private System.Windows.Forms.ToolStripMenuItem menuCascade;
        private System.Windows.Forms.ToolStripMenuItem menuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem menuTileVertical;

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbStudent;
        private System.Windows.Forms.ToolStripButton tsbProduct;

        private System.Windows.Forms.StatusStrip ssMain;
        private System.Windows.Forms.ToolStripStatusLabel lblUserStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblMessageStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblTimeStatus;

        private System.Windows.Forms.Timer timerClock;
    }
}