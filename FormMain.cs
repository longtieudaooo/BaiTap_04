using System;
using System.Windows.Forms;

namespace Bai_tap_04
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // Đăng ký sự kiện Menu Danh mục & ToolStrip
            this.menuStudent.Click += (s, e) => OpenChildForm<FormStudent>();
            this.tsbStudent.Click += (s, e) => OpenChildForm<FormStudent>();

            this.menuProduct.Click += (s, e) => OpenChildForm<FormProduct>();
            this.tsbProduct.Click += (s, e) => OpenChildForm<FormProduct>();

            // Đăng ký sự kiện Cửa sổ
            this.menuCascade.Click += (s, e) => LayoutMdi(MdiLayout.Cascade);
            this.menuTileHorizontal.Click += (s, e) => LayoutMdi(MdiLayout.TileHorizontal);
            this.menuTileVertical.Click += (s, e) => LayoutMdi(MdiLayout.TileVertical);

            // Đăng ký sự kiện Hệ thống
            this.menuLogout.Click += (s, e) => MessageBox.Show("Đã đăng xuất tài khoản!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.menuExit.Click += (s, e) => Application.Exit();

            // Timer đồng hồ
            this.timerClock.Tick += TimerClock_Tick;
        }

        private void TimerClock_Tick(object? sender, EventArgs e)
        {
            lblTimeStatus.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        // BÀI 4.7: PHƯƠNG THỨC MỞ FORM CON MDI (KIỂM TRA NẾU ĐÃ MỞ THÌ ACTIVATE, TRÁNH LẶP FORM)
        public void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    child.Activate(); // Kích hoạt form đã mở lên trên cùng
                    return;
                }
            }

            T newChild = new T
            {
                MdiParent = this
            };
            newChild.Show();
        }

        // BÀI 4.7: CẬP NHẬT THÔNG ĐIỆP STATUSSTRIP TỪ FORM CON (FormStudent, FormProduct)
        public void SetStatusMessage(string message)
        {
            lblMessageStatus.Text = message;
        }
    }
}