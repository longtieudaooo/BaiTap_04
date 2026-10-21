using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_tap_04
{
    public partial class FormStudent : Form
    {
        private BindingList<Student> listStudents = new BindingList<Student>();
        private BindingSource studentBindingSource = new BindingSource();

        public FormStudent()
        {
            InitializeComponent();

            // Đăng ký sự kiện Nút bấm
            this.btnAdd.Click += btnAdd_Click;
            this.btnUpdate.Click += btnUpdate_Click;
            this.btnDelete.Click += btnDelete_Click;
            this.btnClear.Click += btnClear_Click;
            this.btnChooseAvatar.Click += btnChooseAvatar_Click;
            this.btnExportCsv.Click += btnExportCsv_Click;
            this.btnLoadAsync.Click += btnLoadAsync_Click;

            // Đăng ký sự kiện ContextMenuStrip trên DataGridView
            this.cmsItemDelete.Click += btnDelete_Click;
            this.cmsItemRefresh.Click += btnClear_Click;
            this.cmsItemDetails.Click += CmsItemDetails_Click;

            // Đăng ký sự kiện chọn dòng để tải Avatar
            this.studentBindingSource.CurrentChanged += StudentBindingSource_CurrentChanged;
        }

        private void FormStudent_Load(object sender, EventArgs e)
        {
            SetupDataGridViewColumns();
            InitSampleData();

            studentBindingSource.DataSource = listStudents;
            dgvStudents.DataSource = studentBindingSource;

            SetupDataBindings();
            NotifyParentStatus("Đã tải xong danh sách sinh viên.");
        }

        private void SetupDataGridViewColumns()
        {
            dgvStudents.AutoGenerateColumns = false;
            dgvStudents.Columns.Clear();

            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "StudentId", HeaderText = "Mã SV", Width = 90 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "FullName", HeaderText = "Họ và tên", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Age", HeaderText = "Tuổi", Width = 70 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Gender", HeaderText = "Giới tính", Width = 90 });
            dgvStudents.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "AvatarPath", HeaderText = "Đường dẫn Avatar", Width = 200 });
        }

        // BÀI 4.6: CẤU HÌNH DATABINDING 2 CHIỀU SỬ DỤNG BINDINGSOURCE
        private void SetupDataBindings()
        {
            txtStudentId.DataBindings.Clear();
            txtFullName.DataBindings.Clear();
            txtAge.DataBindings.Clear();
            cboGender.DataBindings.Clear();
            txtAvatarPath.DataBindings.Clear();

            txtStudentId.DataBindings.Add("Text", studentBindingSource, "StudentId", true, DataSourceUpdateMode.OnPropertyChanged);
            txtFullName.DataBindings.Add("Text", studentBindingSource, "FullName", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAge.DataBindings.Add("Text", studentBindingSource, "Age", true, DataSourceUpdateMode.OnPropertyChanged);
            cboGender.DataBindings.Add("Text", studentBindingSource, "Gender", true, DataSourceUpdateMode.OnPropertyChanged);
            txtAvatarPath.DataBindings.Add("Text", studentBindingSource, "AvatarPath", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void InitSampleData()
        {
            listStudents.Add(new Student("SV001", "Nguyễn Văn An", 20, "Nam", ""));
            listStudents.Add(new Student("SV002", "Trần Thị Bích", 21, "Nữ", ""));
            listStudents.Add(new Student("SV003", "Lê Hoàng Nam", 19, "Nam", ""));
        }

        // Tự động load ảnh Avatar khi chọn sinh viên khác
        private void StudentBindingSource_CurrentChanged(object? sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student s && !string.IsNullOrEmpty(s.AvatarPath) && File.Exists(s.AvatarPath))
            {
                try
                {
                    picAvatar.Image = Image.FromFile(s.AvatarPath);
                }
                catch
                {
                    picAvatar.Image = null;
                }
            }
            else
            {
                picAvatar.Image = null;
            }
        }

        // BÀI 4.6: CHỌN ĐƯỜNG DẪN ẢNH AVATAR
        private void btnChooseAvatar_Click(object? sender, EventArgs e)
        {
            ofdAvatar.Filter = "File Hình Ảnh (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|Tất cả tệp (*.*)|*.*";
            ofdAvatar.Title = "Chọn ảnh đại diện Sinh viên";

            if (ofdAvatar.ShowDialog() == DialogResult.OK)
            {
                txtAvatarPath.Text = ofdAvatar.FileName;
                if (studentBindingSource.Current is Student current)
                {
                    current.AvatarPath = ofdAvatar.FileName;
                    studentBindingSource.ResetCurrentItem();
                }
                picAvatar.Image = Image.FromFile(ofdAvatar.FileName);
            }
        }

        private void btnAdd_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentId.Text) || string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Mã SV và Họ tên không được trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int.TryParse(txtAge.Text, out int age);
            Student newSv = new Student(txtStudentId.Text.Trim(), txtFullName.Text.Trim(), age > 0 ? age : 18, cboGender.Text, txtAvatarPath.Text);

            listStudents.Add(newSv);
            studentBindingSource.MoveLast();
            NotifyParentStatus($"Đã thêm sinh viên [{newSv.FullName}] thành công.");
        }

        private void btnUpdate_Click(object? sender, EventArgs e)
        {
            studentBindingSource.ResetCurrentItem();
            NotifyParentStatus("Đã cập nhật thông tin sinh viên.");
            MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object? sender, EventArgs e)
        {
            if (studentBindingSource.Current is not Student current) return;

            if (MessageBox.Show($"Bạn có muốn xóa sinh viên [{current.FullName}]?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string name = current.FullName;
                listStudents.Remove(current);
                NotifyParentStatus($"Đã xóa sinh viên [{name}].");
            }
        }

        private void btnClear_Click(object? sender, EventArgs e)
        {
            txtStudentId.Clear();
            txtFullName.Clear();
            txtAge.Clear();
            txtAvatarPath.Clear();
            picAvatar.Image = null;
            if (cboGender.Items.Count > 0) cboGender.SelectedIndex = 0;
            txtStudentId.Focus();
        }

        // BÀI 4.6: XUẤT FILE CSV
        private void btnExportCsv_Click(object? sender, EventArgs e)
        {
            sfdCsv.Filter = "File CSV (*.csv)|*.csv";
            sfdCsv.Title = "Xuất Danh Sách Sinh Viên";
            sfdCsv.FileName = "DanhSachSinhVien.csv";

            if (sfdCsv.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StringBuilder sb = new StringBuilder();
                    sb.AppendLine("StudentId,FullName,Age,Gender,AvatarPath");

                    foreach (var std in listStudents)
                    {
                        sb.AppendLine(std.ToCsvRow());
                    }

                    File.WriteAllText(sfdCsv.FileName, sb.ToString(), Encoding.UTF8);
                    NotifyParentStatus("Xuất dữ liệu CSV thành công!");
                    MessageBox.Show("Xuất file CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi xuất file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // BÀI 4.8: NẠP DỮ LIỆU BẤT ĐỒNG BỘ (ASYNC / AWAIT & PROGRESSBAR)
        private async void btnLoadAsync_Click(object? sender, EventArgs e)
        {
            btnLoadAsync.Enabled = false;
            pbLoadProgress.Value = 0;
            lblProgressPercent.Text = "0%";
            NotifyParentStatus("Đang tải dữ liệu sinh viên bất đồng bộ...");

            var progress = new Progress<int>(percent =>
            {
                pbLoadProgress.Value = percent;
                lblProgressPercent.Text = $"{percent}%";
                NotifyParentStatus($"Đang nạp dữ liệu... ({percent}%)");
            });

            try
            {
                List<Student> loadedList = await FetchStudentsDataAsync(progress);

                listStudents.Clear();
                foreach (var st in loadedList)
                {
                    listStudents.Add(st);
                }

                NotifyParentStatus("Hoàn tất nạp dữ liệu bất đồng bộ!");
                MessageBox.Show("Tải danh sách sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLoadAsync.Enabled = true;
            }
        }

        // Phương thức giả lập nạp dữ liệu ngầm với Task.Run & Task.Delay
        private async Task<List<Student>> FetchStudentsDataAsync(IProgress<int> progress)
        {
            return await Task.Run(async () =>
            {
                List<Student> result = new List<Student>();
                for (int i = 1; i <= 10; i++)
                {
                    await Task.Delay(200); // Giả lập đọc dữ liệu nặng
                    result.Add(new Student($"SV0{i:D2}", $"Sinh Viên Bất Đồng Bộ {i}", 18 + i, i % 2 == 0 ? "Nữ" : "Nam", ""));
                    progress?.Report(i * 10);
                }
                return result;
            });
        }

        private void CmsItemDetails_Click(object? sender, EventArgs e)
        {
            if (studentBindingSource.Current is Student s)
            {
                MessageBox.Show($"[CHI TIẾT SINH VIÊN]\nMã SV: {s.StudentId}\nHọ tên: {s.FullName}\nTuổi: {s.Age}\nGiới tính: {s.Gender}\nAvatar: {s.AvatarPath}", "Thông Tin Chi Tiết", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // BÀI 4.7: GỬI THÔNG ĐIỆP CẬP NHẬT STATUSSTRIP TRÊN FORM CHA (FormMain)
        private void NotifyParentStatus(string message)
        {
            if (this.MdiParent is FormMain mainForm)
            {
                mainForm.SetStatusMessage(message);
            }
        }
    }
}