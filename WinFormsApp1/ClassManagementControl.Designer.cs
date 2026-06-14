namespace WinFormsApp1
{
    partial class ClassManagementControl
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
            this.pnlLeftClass = new System.Windows.Forms.Panel();
            this.lblClassTitle = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.txtMaLop = new System.Windows.Forms.TextBox();
            this.lblClassName = new System.Windows.Forms.Label();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnClearClass = new System.Windows.Forms.Button();
            this.btnSearchClass = new System.Windows.Forms.Button();
            this.pnlRightClass = new System.Windows.Forms.Panel();
            this.lblSearchClass = new System.Windows.Forms.Label();
            this.txtSearchClass = new System.Windows.Forms.TextBox();
            this.dgvClass = new System.Windows.Forms.DataGridView();
            this.pnlLeftClass.SuspendLayout();
            this.pnlRightClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).BeginInit();
            this.SuspendLayout();

            // pnlLeftClass
            this.pnlLeftClass.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlLeftClass.Controls.Add(this.lblClassTitle);
            this.pnlLeftClass.Controls.Add(this.lblMaLop);
            this.pnlLeftClass.Controls.Add(this.txtMaLop);
            this.pnlLeftClass.Controls.Add(this.lblClassName);
            this.pnlLeftClass.Controls.Add(this.txtClassName);
            this.pnlLeftClass.Controls.Add(this.lblNote);
            this.pnlLeftClass.Controls.Add(this.txtNote);
            this.pnlLeftClass.Controls.Add(this.btnAddClass);
            this.pnlLeftClass.Controls.Add(this.btnEditClass);
            this.pnlLeftClass.Controls.Add(this.btnDeleteClass);
            this.pnlLeftClass.Controls.Add(this.btnClearClass);
            this.pnlLeftClass.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeftClass.Location = new System.Drawing.Point(0, 0);
            this.pnlLeftClass.Name = "pnlLeftClass";
            this.pnlLeftClass.Size = new System.Drawing.Size(350, 600);
            this.pnlLeftClass.TabIndex = 0;

            this.lblClassTitle.AutoSize = true;
            this.lblClassTitle.Font = new System.Drawing.Font("Arial", 12, System.Drawing.FontStyle.Bold);
            this.lblClassTitle.Location = new System.Drawing.Point(20, 20);
            this.lblClassTitle.Name = "lblClassTitle";
            this.lblClassTitle.Size = new System.Drawing.Size(150, 20);
            this.lblClassTitle.TabIndex = 0;
            this.lblClassTitle.Text = "Thông tin lớp học";

            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(20, 60);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(50, 15);
            this.lblMaLop.TabIndex = 1;
            this.lblMaLop.Text = "Mã lớp:";

            this.txtMaLop.Location = new System.Drawing.Point(20, 80);
            this.txtMaLop.Name = "txtMaLop";
            this.txtMaLop.Size = new System.Drawing.Size(300, 23);
            this.txtMaLop.TabIndex = 2;

            this.lblClassName.AutoSize = true;
            this.lblClassName.Location = new System.Drawing.Point(20, 120);
            this.lblClassName.Name = "lblClassName";
            this.lblClassName.Size = new System.Drawing.Size(60, 15);
            this.lblClassName.TabIndex = 3;
            this.lblClassName.Text = "Tên lớp:";

            this.txtClassName.Location = new System.Drawing.Point(20, 140);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(300, 23);
            this.txtClassName.TabIndex = 4;

            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(20, 180);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(50, 15);
            this.lblNote.TabIndex = 5;
            this.lblNote.Text = "Ghi chú:";

            this.txtNote.Location = new System.Drawing.Point(20, 200);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(300, 60);
            this.txtNote.TabIndex = 6;

            this.btnAddClass.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddClass.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.Location = new System.Drawing.Point(20, 280);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(140, 35);
            this.btnAddClass.TabIndex = 7;
            this.btnAddClass.Text = "Thêm";
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click);

            this.btnEditClass.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnEditClass.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnEditClass.ForeColor = System.Drawing.Color.White;
            this.btnEditClass.Location = new System.Drawing.Point(180, 280);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(140, 35);
            this.btnEditClass.TabIndex = 8;
            this.btnEditClass.Text = "Sửa";
            this.btnEditClass.UseVisualStyleBackColor = false;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click);

            this.btnDeleteClass.BackColor = System.Drawing.Color.Tomato;
            this.btnDeleteClass.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnDeleteClass.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClass.Location = new System.Drawing.Point(20, 330);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(140, 35);
            this.btnDeleteClass.TabIndex = 9;
            this.btnDeleteClass.Text = "Xóa";
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click);

            this.btnClearClass.BackColor = System.Drawing.Color.Gray;
            this.btnClearClass.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnClearClass.ForeColor = System.Drawing.Color.White;
            this.btnClearClass.Location = new System.Drawing.Point(180, 330);
            this.btnClearClass.Name = "btnClearClass";
            this.btnClearClass.Size = new System.Drawing.Size(140, 35);
            this.btnClearClass.TabIndex = 10;
            this.btnClearClass.Text = "Làm mới";
            this.btnClearClass.UseVisualStyleBackColor = false;
            this.btnClearClass.Click += new System.EventHandler(this.btnClearClass_Click);

            this.btnViewStudents = new System.Windows.Forms.Button();
            this.btnViewStudents.BackColor = System.Drawing.Color.SteelBlue;
            this.btnViewStudents.Font = new System.Drawing.Font("Arial", 9);
            this.btnViewStudents.ForeColor = System.Drawing.Color.White;
            this.btnViewStudents.Location = new System.Drawing.Point(20, 380);
            this.btnViewStudents.Name = "btnViewStudents";
            this.btnViewStudents.Size = new System.Drawing.Size(300, 30);
            this.btnViewStudents.TabIndex = 11;
            this.btnViewStudents.Text = "Xem sinh viên của lớp";
            this.btnViewStudents.UseVisualStyleBackColor = false;
            this.btnViewStudents.Click += new System.EventHandler(this.btnViewStudents_Click);

            // pnlRightClass
            this.pnlRightClass.Controls.Add(this.lblSearchClass);
            this.pnlRightClass.Controls.Add(this.txtSearchClass);
            this.pnlRightClass.Controls.Add(this.btnSearchClass);
            this.pnlRightClass.Controls.Add(this.dgvClass);
            this.pnlRightClass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRightClass.Location = new System.Drawing.Point(350, 0);
            this.pnlRightClass.Name = "pnlRightClass";
            this.pnlRightClass.Size = new System.Drawing.Size(650, 600);
            this.pnlRightClass.TabIndex = 1;

            this.lblSearchClass.AutoSize = true;
            this.lblSearchClass.Font = new System.Drawing.Font("Arial", 9);
            this.lblSearchClass.Location = new System.Drawing.Point(20, 20);
            this.lblSearchClass.Name = "lblSearchClass";
            this.lblSearchClass.Size = new System.Drawing.Size(200, 15);
            this.lblSearchClass.TabIndex = 0;
            this.lblSearchClass.Text = "Tìm kiếm (Mã lớp / Tên lớp / Ghi chú):";

            this.txtSearchClass.Location = new System.Drawing.Point(20, 40);
            this.txtSearchClass.Name = "txtSearchClass";
            this.txtSearchClass.Size = new System.Drawing.Size(450, 23);
            this.txtSearchClass.TabIndex = 1;

            this.btnSearchClass.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSearchClass.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            this.btnSearchClass.ForeColor = System.Drawing.Color.White;
            this.btnSearchClass.Location = new System.Drawing.Point(480, 40);
            this.btnSearchClass.Name = "btnSearchClass";
            this.btnSearchClass.Size = new System.Drawing.Size(100, 23);
            this.btnSearchClass.TabIndex = 2;
            this.btnSearchClass.Text = "Tìm";
            this.btnSearchClass.UseVisualStyleBackColor = false;
            this.btnSearchClass.Click += new System.EventHandler(this.btnSearchClass_Click);

            this.dgvClass.AllowUserToAddRows = false;
            this.dgvClass.AllowUserToDeleteRows = false;
            this.dgvClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClass.BackgroundColor = System.Drawing.Color.White;
            this.dgvClass.Location = new System.Drawing.Point(20, 80);
            this.dgvClass.Name = "dgvClass";
            this.dgvClass.ReadOnly = true;
            this.dgvClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClass.Size = new System.Drawing.Size(610, 490);
            this.dgvClass.TabIndex = 3;
            this.dgvClass.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClass_CellClick);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRightClass);
            this.Controls.Add(this.pnlLeftClass);
            this.Name = "ClassManagementControl";
            this.Size = new System.Drawing.Size(1000, 600);

            this.pnlLeftClass.ResumeLayout(false);
            this.pnlLeftClass.PerformLayout();
            this.pnlRightClass.ResumeLayout(false);
            this.pnlRightClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClass)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnlLeftClass;
        private System.Windows.Forms.Label lblClassTitle;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.TextBox txtMaLop;
        private System.Windows.Forms.Label lblClassName;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnClearClass;
        private System.Windows.Forms.Button btnSearchClass;
        private System.Windows.Forms.Button btnViewStudents;
        private System.Windows.Forms.Panel pnlRightClass;
        private System.Windows.Forms.Label lblSearchClass;
        private System.Windows.Forms.TextBox txtSearchClass;
        private System.Windows.Forms.DataGridView dgvClass;
    }
}
