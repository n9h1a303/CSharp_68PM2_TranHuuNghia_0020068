namespace WinFormsApp1
{
    partial class StudentManagementControl
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

        private void InitializeComponent()
        {
            this.pnlLeftStudent = new System.Windows.Forms.Panel();
            this.lblStudentTitle = new System.Windows.Forms.Label();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.lblClass = new System.Windows.Forms.Label();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnEditStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnClearStudent = new System.Windows.Forms.Button();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.pnlRightStudent = new System.Windows.Forms.Panel();
            this.lblSearchStudent = new System.Windows.Forms.Label();
            this.txtSearchStudent = new System.Windows.Forms.TextBox();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.pnlLeftStudent.SuspendLayout();
            this.pnlRightStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();

            // pnlLeftStudent
            this.pnlLeftStudent.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeftStudent.Controls.Add(this.lblStudentTitle);
            this.pnlLeftStudent.Controls.Add(this.lblStudentId);
            this.pnlLeftStudent.Controls.Add(this.txtStudentId);
            this.pnlLeftStudent.Controls.Add(this.lblFullName);
            this.pnlLeftStudent.Controls.Add(this.txtFullName);
            this.pnlLeftStudent.Controls.Add(this.lblBirthDate);
            this.pnlLeftStudent.Controls.Add(this.dtpBirthDate);
            this.pnlLeftStudent.Controls.Add(this.lblGender);
            this.pnlLeftStudent.Controls.Add(this.cmbGender);
            this.pnlLeftStudent.Controls.Add(this.lblClass);
            this.pnlLeftStudent.Controls.Add(this.cmbClass);
            this.pnlLeftStudent.Controls.Add(this.btnAddStudent);
            this.pnlLeftStudent.Controls.Add(this.btnEditStudent);
            this.pnlLeftStudent.Controls.Add(this.btnDeleteStudent);
            this.pnlLeftStudent.Controls.Add(this.btnClearStudent);
            this.pnlLeftStudent.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftStudent.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftStudent.Name = "pnlLeftStudent";
            this.pnlLeftStudent.Size = new System.Drawing.Size(350, 600);
            this.pnlLeftStudent.TabIndex = 0;

            this.lblStudentTitle.AutoSize = true;
            this.lblStudentTitle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            this.lblStudentTitle.Location = new System.Drawing.Point(20, 20);
            this.lblStudentTitle.Name = "lblStudentTitle";
            this.lblStudentTitle.Size = new System.Drawing.Size(150, 20);
            this.lblStudentTitle.TabIndex = 0;
            this.lblStudentTitle.Text = "Thông tin sinh viên";

            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(20, 60);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(80, 15);
            this.lblStudentId.TabIndex = 1;
            this.lblStudentId.Text = "Mã sinh viên:";

            this.txtStudentId.Location = new System.Drawing.Point(20, 80);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(300, 23);
            this.txtStudentId.TabIndex = 2;

            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(20, 120);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(60, 15);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Họ và tên:";

            this.txtFullName.Location = new System.Drawing.Point(20, 140);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(300, 23);
            this.txtFullName.TabIndex = 4;

            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(20, 180);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(70, 15);
            this.lblBirthDate.TabIndex = 5;
            this.lblBirthDate.Text = "Ngày sinh:";

            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirthDate.Location = new System.Drawing.Point(20, 200);
            this.dtpBirthDate.Name = "dtpBirthDate";
            this.dtpBirthDate.Size = new System.Drawing.Size(300, 23);
            this.dtpBirthDate.TabIndex = 6;

            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(20, 240);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(60, 15);
            this.lblGender.TabIndex = 7;
            this.lblGender.Text = "Giới tính:";

            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] { "Nam", "Nữ" });
            this.cmbGender.Location = new System.Drawing.Point(20, 260);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(300, 23);
            this.cmbGender.TabIndex = 8;

            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(20, 300);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(35, 15);
            this.lblClass.TabIndex = 9;
            this.lblClass.Text = "Lớp:";

            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(20, 320);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(300, 23);
            this.cmbClass.TabIndex = 10;

            this.btnAddStudent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddStudent.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnAddStudent.ForeColor = System.Drawing.Color.White;
            this.btnAddStudent.Location = new System.Drawing.Point(20, 370);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(140, 35);
            this.btnAddStudent.TabIndex = 11;
            this.btnAddStudent.Text = "Thêm";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);

            this.btnEditStudent.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditStudent.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnEditStudent.ForeColor = System.Drawing.Color.White;
            this.btnEditStudent.Location = new System.Drawing.Point(180, 370);
            this.btnEditStudent.Name = "btnEditStudent";
            this.btnEditStudent.Size = new System.Drawing.Size(140, 35);
            this.btnEditStudent.TabIndex = 12;
            this.btnEditStudent.Text = "Sửa";
            this.btnEditStudent.UseVisualStyleBackColor = false;
            this.btnEditStudent.Click += new System.EventHandler(this.btnEditStudent_Click);

            this.btnDeleteStudent.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStudent.Location = new System.Drawing.Point(20, 420);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(140, 35);
            this.btnDeleteStudent.TabIndex = 13;
            this.btnDeleteStudent.Text = "Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);

            this.btnClearStudent.BackColor = System.Drawing.Color.Gray;
            this.btnClearStudent.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnClearStudent.ForeColor = System.Drawing.Color.White;
            this.btnClearStudent.Location = new System.Drawing.Point(180, 420);
            this.btnClearStudent.Name = "btnClearStudent";
            this.btnClearStudent.Size = new System.Drawing.Size(140, 35);
            this.btnClearStudent.TabIndex = 14;
            this.btnClearStudent.Text = "Làm mới";
            this.btnClearStudent.UseVisualStyleBackColor = false;
            this.btnClearStudent.Click += new System.EventHandler(this.btnClearStudent_Click);

            // pnlRightStudent
            this.pnlRightStudent.Controls.Add(this.lblSearchStudent);
            this.pnlRightStudent.Controls.Add(this.txtSearchStudent);
            this.pnlRightStudent.Controls.Add(this.btnSearchStudent);
            this.pnlRightStudent.Controls.Add(this.dgvStudent);
            this.pnlRightStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightStudent.Location = new System.Drawing.Point(350, 0);
            this.pnlRightStudent.Name = "pnlRightStudent";
            this.pnlRightStudent.Size = new System.Drawing.Size(650, 600);
            this.pnlRightStudent.TabIndex = 1;

            this.lblSearchStudent.AutoSize = true;
            this.lblSearchStudent.Font = new System.Drawing.Font("Arial", 9);
            this.lblSearchStudent.Location = new System.Drawing.Point(20, 20);
            this.lblSearchStudent.Name = "lblSearchStudent";
            this.lblSearchStudent.Size = new System.Drawing.Size(250, 15);
            this.lblSearchStudent.TabIndex = 0;
            this.lblSearchStudent.Text = "Tìm kiếm (Tên / Mã SV / Lớp):";

            this.txtSearchStudent.Location = new System.Drawing.Point(20, 40);
            this.txtSearchStudent.Name = "txtSearchStudent";
            this.txtSearchStudent.Size = new System.Drawing.Size(450, 23);
            this.txtSearchStudent.TabIndex = 1;

            this.btnSearchStudent.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchStudent.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnSearchStudent.ForeColor = System.Drawing.Color.White;
            this.btnSearchStudent.Location = new System.Drawing.Point(480, 40);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(100, 23);
            this.btnSearchStudent.TabIndex = 2;
            this.btnSearchStudent.Text = "Tìm";
            this.btnSearchStudent.UseVisualStyleBackColor = false;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);

            // paging controls
            this.lblPageSize = new System.Windows.Forms.Label();
            this.nudPageSize = new System.Windows.Forms.NumericUpDown();
            this.btnPrevPage = new System.Windows.Forms.Button();
            this.btnNextPage = new System.Windows.Forms.Button();
            this.lblPageInfo = new System.Windows.Forms.Label();

            this.lblPageSize.AutoSize = true;
            this.lblPageSize.Location = new System.Drawing.Point(20, 70);
            this.lblPageSize.Name = "lblPageSize";
            this.lblPageSize.Size = new System.Drawing.Size(70, 15);
            this.lblPageSize.TabIndex = 4;
            this.lblPageSize.Text = "Số / trang:";

            this.nudPageSize.Location = new System.Drawing.Point(90, 68);
            this.nudPageSize.Minimum = new decimal(new int[] {1,0,0,0});
            this.nudPageSize.Maximum = new decimal(new int[] {100,0,0,0});
            this.nudPageSize.Value = new decimal(new int[] {10,0,0,0});
            this.nudPageSize.Name = "nudPageSize";
            this.nudPageSize.Size = new System.Drawing.Size(60, 23);
            this.nudPageSize.TabIndex = 5;
            this.nudPageSize.ValueChanged += new System.EventHandler(this.nudPageSize_ValueChanged);

            this.btnPrevPage.BackColor = System.Drawing.Color.LightGray;
            this.btnPrevPage.Font = new System.Drawing.Font("Arial", 9);
            this.btnPrevPage.Location = new System.Drawing.Point(480, 68);
            this.btnPrevPage.Name = "btnPrevPage";
            this.btnPrevPage.Size = new System.Drawing.Size(60, 23);
            this.btnPrevPage.TabIndex = 6;
            this.btnPrevPage.Text = "<<";
            this.btnPrevPage.UseVisualStyleBackColor = false;
            this.btnPrevPage.Click += new System.EventHandler(this.btnPrevPage_Click);

            this.btnNextPage.BackColor = System.Drawing.Color.LightGray;
            this.btnNextPage.Font = new System.Drawing.Font("Arial", 9);
            this.btnNextPage.Location = new System.Drawing.Point(560, 68);
            this.btnNextPage.Name = "btnNextPage";
            this.btnNextPage.Size = new System.Drawing.Size(60, 23);
            this.btnNextPage.TabIndex = 7;
            this.btnNextPage.Text = ">>";
            this.btnNextPage.UseVisualStyleBackColor = false;
            this.btnNextPage.Click += new System.EventHandler(this.btnNextPage_Click);

            this.lblPageInfo.AutoSize = true;
            this.lblPageInfo.Location = new System.Drawing.Point(630, 72);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Size = new System.Drawing.Size(80, 15);
            this.lblPageInfo.TabIndex = 8;
            this.lblPageInfo.Text = "Trang 0 / 0";

            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.BackgroundColor = System.Drawing.Color.White;
            this.dgvStudent.Location = new System.Drawing.Point(20, 80);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(610, 490);
            this.dgvStudent.TabIndex = 3;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRightStudent);
            this.Controls.Add(this.pnlLeftStudent);
            this.Name = "StudentManagementControl";
            this.Size = new System.Drawing.Size(1000, 600);

            this.pnlLeftStudent.ResumeLayout(false);
            this.pnlLeftStudent.PerformLayout();
            this.pnlRightStudent.ResumeLayout(false);
            this.pnlRightStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeftStudent;
        private System.Windows.Forms.Label lblStudentTitle;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnEditStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnClearStudent;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.Panel pnlRightStudent;
        private System.Windows.Forms.Label lblSearchStudent;
        private System.Windows.Forms.TextBox txtSearchStudent;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label lblPageSize;
        private System.Windows.Forms.NumericUpDown nudPageSize;
        private System.Windows.Forms.Button btnPrevPage;
        private System.Windows.Forms.Button btnNextPage;
        private System.Windows.Forms.Label lblPageInfo;
    }
}
