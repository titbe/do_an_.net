namespace DoAnC_
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            rdbNam = new RadioButton();
            rdbNu = new RadioButton();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            txtSoCCCD = new TextBox();
            txtSDT = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgvNhanVien = new DataGridView();
            btnTimKiem = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(416, 9);
            label1.Name = "label1";
            label1.Size = new Size(463, 67);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý nhân viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(51, 115);
            label2.Name = "label2";
            label2.Size = new Size(141, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(51, 179);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên nhân viên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.Highlight;
            label4.Location = new Point(51, 243);
            label4.Name = "label4";
            label4.Size = new Size(107, 28);
            label4.TabIndex = 3;
            label4.Text = "Ngày sinh";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(51, 309);
            label5.Name = "label5";
            label5.Size = new Size(95, 28);
            label5.TabIndex = 4;
            label5.Text = "Giới tính";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.Highlight;
            label6.Location = new Point(51, 371);
            label6.Name = "label6";
            label6.Size = new Size(78, 28);
            label6.TabIndex = 5;
            label6.Text = "Địa chỉ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.Highlight;
            label7.Location = new Point(51, 436);
            label7.Name = "label7";
            label7.Size = new Size(64, 28);
            label7.TabIndex = 6;
            label7.Text = "Email";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Highlight;
            label8.Location = new Point(51, 499);
            label8.Name = "label8";
            label8.Size = new Size(90, 28);
            label8.TabIndex = 7;
            label8.Text = "Số CCCD";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.Highlight;
            label9.Location = new Point(51, 563);
            label9.Name = "label9";
            label9.Size = new Size(138, 28);
            label9.TabIndex = 8;
            label9.Text = "Số điện thoại";
            // 
            // txtMaNV
            // 
            txtMaNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMaNV.Location = new Point(244, 115);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(372, 34);
            txtMaNV.TabIndex = 9;
            // 
            // txtTenNV
            // 
            txtTenNV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtTenNV.Location = new Point(244, 179);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(372, 34);
            txtTenNV.TabIndex = 10;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNgaySinh.Format = DateTimePickerFormat.Short;
            dtpNgaySinh.Location = new Point(244, 245);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(372, 34);
            dtpNgaySinh.TabIndex = 11;
            // 
            // rdbNam
            // 
            rdbNam.AutoSize = true;
            rdbNam.BackColor = Color.Transparent;
            rdbNam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdbNam.ForeColor = SystemColors.Highlight;
            rdbNam.Location = new Point(244, 309);
            rdbNam.Name = "rdbNam";
            rdbNam.Size = new Size(78, 32);
            rdbNam.TabIndex = 12;
            rdbNam.TabStop = true;
            rdbNam.Text = "Nam";
            rdbNam.UseVisualStyleBackColor = false;
            // 
            // rdbNu
            // 
            rdbNu.AutoSize = true;
            rdbNu.BackColor = Color.Transparent;
            rdbNu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            rdbNu.ForeColor = SystemColors.Highlight;
            rdbNu.Location = new Point(416, 309);
            rdbNu.Name = "rdbNu";
            rdbNu.Size = new Size(62, 32);
            rdbNu.TabIndex = 13;
            rdbNu.TabStop = true;
            rdbNu.Text = "Nữ";
            rdbNu.UseVisualStyleBackColor = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDiaChi.Location = new Point(244, 368);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(372, 34);
            txtDiaChi.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(244, 433);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 34);
            txtEmail.TabIndex = 15;
            // 
            // txtSoCCCD
            // 
            txtSoCCCD.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoCCCD.Location = new Point(244, 496);
            txtSoCCCD.Name = "txtSoCCCD";
            txtSoCCCD.Size = new Size(372, 34);
            txtSoCCCD.TabIndex = 16;
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSDT.Location = new Point(244, 563);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(372, 34);
            txtSDT.TabIndex = 17;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.SkyBlue;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = SystemColors.Highlight;
            btnThem.Location = new Point(695, 111);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 42);
            btnThem.TabIndex = 18;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.Info;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = SystemColors.Highlight;
            btnSua.Location = new Point(879, 106);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 43);
            btnSua.TabIndex = 19;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.MistyRose;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = SystemColors.Highlight;
            btnXoa.Location = new Point(1054, 107);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 42);
            btnXoa.TabIndex = 20;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Location = new Point(695, 179);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 51;
            dgvNhanVien.RowTemplate.Height = 29;
            dgvNhanVien.Size = new Size(624, 418);
            dgvNhanVien.TabIndex = 21;
            // 
            // btnTimKiem
            // 
            btnTimKiem.BackColor = Color.PaleGreen;
            btnTimKiem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTimKiem.ForeColor = SystemColors.Highlight;
            btnTimKiem.Location = new Point(1196, 106);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(123, 42);
            btnTimKiem.TabIndex = 22;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = false;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveBorder;
            ClientSize = new Size(1331, 640);
            Controls.Add(btnTimKiem);
            Controls.Add(dgvNhanVien);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDT);
            Controls.Add(txtSoCCCD);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(rdbNu);
            Controls.Add(rdbNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private DateTimePicker dtpNgaySinh;
        private RadioButton rdbNam;
        private RadioButton rdbNu;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private TextBox txtSoCCCD;
        private TextBox txtSDT;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvNhanVien;
        private Button btnTimKiem;
    }
}