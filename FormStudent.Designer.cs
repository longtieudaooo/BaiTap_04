namespace Bai_tap_04
{
    partial class FormStudent
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
            this.grpInput = new System.Windows.Forms.GroupBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnChooseAvatar = new System.Windows.Forms.Button();
            this.txtAvatarPath = new System.Windows.Forms.TextBox();

            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadAsync = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();

            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.cmsDgv = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cmsItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsItemDetails = new System.Windows.Forms.ToolStripMenuItem();

            this.pnlProgress = new System.Windows.Forms.Panel();
            this.lblProgressPercent = new System.Windows.Forms.Label();
            this.pbLoadProgress = new System.Windows.Forms.ProgressBar();

            this.ofdAvatar = new System.Windows.Forms.OpenFileDialog();
            this.sfdCsv = new System.Windows.Forms.SaveFileDialog();

            this.grpInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.pnlButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.cmsDgv.SuspendLayout();
            this.pnlProgress.SuspendLayout();
            this.SuspendLayout();

            // GroupBox Nhập liệu
            this.grpInput.Controls.Add(this.txtAvatarPath);
            this.grpInput.Controls.Add(this.btnChooseAvatar);
            this.grpInput.Controls.Add(this.picAvatar);
            this.grpInput.Controls.Add(this.cboGender);
            this.grpInput.Controls.Add(this.lblGender);
            this.grpInput.Controls.Add(this.txtAge);
            this.grpInput.Controls.Add(this.lblAge);
            this.grpInput.Controls.Add(this.txtFullName);
            this.grpInput.Controls.Add(this.lblFullName);
            this.grpInput.Controls.Add(this.txtStudentId);
            this.grpInput.Controls.Add(this.lblStudentId);
            this.grpInput.Location = new System.Drawing.Point(12, 12);
            this.grpInput.Name = "grpInput";
            this.grpInput.Size = new System.Drawing.Size(760, 180);
            this.grpInput.TabIndex = 0;
            this.grpInput.TabStop = false;
            this.grpInput.Text = "Thông tin Sinh viên & Avatar";

            // Control chi tiết trong GroupBox
            this.lblStudentId.Location = new System.Drawing.Point(15, 28);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(60, 23);
            this.lblStudentId.Text = "Mã SV:";

            this.txtStudentId.Location = new System.Drawing.Point(85, 25);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(180, 23);

            this.lblFullName.Location = new System.Drawing.Point(15, 63);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 23);
            this.lblFullName.Text = "Họ tên:";

            this.txtFullName.Location = new System.Drawing.Point(85, 60);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(180, 23);

            this.lblAge.Location = new System.Drawing.Point(15, 98);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(60, 23);
            this.lblAge.Text = "Tuổi:";

            this.txtAge.Location = new System.Drawing.Point(85, 95);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(180, 23);

            this.lblGender.Location = new System.Drawing.Point(15, 133);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 23);
            this.lblGender.Text = "Giới tính:";

            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cboGender.Location = new System.Drawing.Point(85, 130);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(180, 23);

            // Avatar Controls
            this.picAvatar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvatar.Location = new System.Drawing.Point(300, 22);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(130, 140);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnChooseAvatar.Location = new System.Drawing.Point(445, 22);
            this.btnChooseAvatar.Name = "btnChooseAvatar";
            this.btnChooseAvatar.Size = new System.Drawing.Size(100, 30);
            this.btnChooseAvatar.Text = "Chọn ảnh...";

            this.txtAvatarPath.Location = new System.Drawing.Point(445, 60);
            this.txtAvatarPath.Name = "txtAvatarPath";
            this.txtAvatarPath.ReadOnly = true;
            this.txtAvatarPath.Size = new System.Drawing.Size(300, 23);

            // Panel Nút bấm
            this.pnlButtons.Controls.Add(this.btnExportCsv);
            this.pnlButtons.Controls.Add(this.btnLoadAsync);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Location = new System.Drawing.Point(12, 198);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(760, 40);

            this.btnAdd.Location = new System.Drawing.Point(0, 5);
            this.btnAdd.Size = new System.Drawing.Size(95, 30);
            this.btnAdd.Text = "Thêm";

            this.btnUpdate.Location = new System.Drawing.Point(105, 5);
            this.btnUpdate.Size = new System.Drawing.Size(95, 30);
            this.btnUpdate.Text = "Cập nhật";

            this.btnDelete.Location = new System.Drawing.Point(210, 5);
            this.btnDelete.Size = new System.Drawing.Size(95, 30);
            this.btnDelete.Text = "Xóa";

            this.btnClear.Location = new System.Drawing.Point(315, 5);
            this.btnClear.Size = new System.Drawing.Size(95, 30);
            this.btnClear.Text = "Làm mới";

            this.btnLoadAsync.Location = new System.Drawing.Point(420, 5);
            this.btnLoadAsync.Size = new System.Drawing.Size(130, 30);
            this.btnLoadAsync.Text = "Nạp Async";

            this.btnExportCsv.Location = new System.Drawing.Point(560, 5);
            this.btnExportCsv.Size = new System.Drawing.Size(110, 30);
            this.btnExportCsv.Text = "Xuất CSV";

            // Panel Tiến trình ProgressBar
            this.pnlProgress.Controls.Add(this.lblProgressPercent);
            this.pnlProgress.Controls.Add(this.pbLoadProgress);
            this.pnlProgress.Location = new System.Drawing.Point(12, 244);
            this.pnlProgress.Size = new System.Drawing.Size(760, 25);

            this.pbLoadProgress.Location = new System.Drawing.Point(0, 2);
            this.pbLoadProgress.Size = new System.Drawing.Size(680, 20);

            this.lblProgressPercent.Location = new System.Drawing.Point(690, 2);
            this.lblProgressPercent.Size = new System.Drawing.Size(65, 20);
            this.lblProgressPercent.Text = "0%";

            // DataGridView & ContextMenuStrip
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.ContextMenuStrip = this.cmsDgv;
            this.dgvStudents.Location = new System.Drawing.Point(12, 275);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(760, 240);

            this.cmsDgv.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.cmsItemDetails,
                this.cmsItemRefresh,
                this.cmsItemDelete
            });

            this.cmsItemDetails.Text = "Xem chi tiết";
            this.cmsItemRefresh.Text = "Làm mới dữ liệu";
            this.cmsItemDelete.Text = "Xóa dòng";

            // Form Properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 526);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.pnlProgress);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.grpInput);
            this.Name = "FormStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Quản Lý Sinh Viên";
            this.Load += new System.EventHandler(this.FormStudent_Load);

            this.grpInput.ResumeLayout(false);
            this.grpInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.pnlButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.cmsDgv.ResumeLayout(false);
            this.pnlProgress.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnChooseAvatar;
        private System.Windows.Forms.TextBox txtAvatarPath;

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadAsync;
        private System.Windows.Forms.Button btnExportCsv;

        private System.Windows.Forms.Panel pnlProgress;
        private System.Windows.Forms.ProgressBar pbLoadProgress;
        private System.Windows.Forms.Label lblProgressPercent;

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.ContextMenuStrip cmsDgv;
        private System.Windows.Forms.ToolStripMenuItem cmsItemDelete;
        private System.Windows.Forms.ToolStripMenuItem cmsItemRefresh;
        private System.Windows.Forms.ToolStripMenuItem cmsItemDetails;

        private System.Windows.Forms.OpenFileDialog ofdAvatar;
        private System.Windows.Forms.SaveFileDialog sfdCsv;
    }
}