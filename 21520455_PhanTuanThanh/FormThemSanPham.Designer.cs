namespace _21520455_PhanTuanThanh
{
    partial class FormThemSanPham
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.textBoxGiaNhap = new System.Windows.Forms.TextBox();
            this.textBoxGiaBan = new System.Windows.Forms.TextBox();
            this.datePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(149, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(345, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Thêm thông tin sản phẩm";
            // 
            // textBoxTen
            // 
            this.textBoxTen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTen.Location = new System.Drawing.Point(288, 104);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(216, 35);
            this.textBoxTen.TabIndex = 1;
            this.textBoxTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTen_KeyPress);
            // 
            // textBoxGiaNhap
            // 
            this.textBoxGiaNhap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaNhap.Location = new System.Drawing.Point(288, 182);
            this.textBoxGiaNhap.Name = "textBoxGiaNhap";
            this.textBoxGiaNhap.Size = new System.Drawing.Size(216, 35);
            this.textBoxGiaNhap.TabIndex = 2;
            this.textBoxGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGiaNhap_KeyPress);
            // 
            // textBoxGiaBan
            // 
            this.textBoxGiaBan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaBan.Location = new System.Drawing.Point(288, 262);
            this.textBoxGiaBan.Name = "textBoxGiaBan";
            this.textBoxGiaBan.Size = new System.Drawing.Size(216, 35);
            this.textBoxGiaBan.TabIndex = 3;
            this.textBoxGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGiaBan_KeyPress);
            // 
            // datePickerNgayNhap
            // 
            this.datePickerNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.datePickerNgayNhap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerNgayNhap.Location = new System.Drawing.Point(288, 346);
            this.datePickerNgayNhap.Name = "datePickerNgayNhap";
            this.datePickerNgayNhap.Size = new System.Drawing.Size(216, 35);
            this.datePickerNgayNhap.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(172, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 7;
            this.label2.Text = "Giá nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(184, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 8;
            this.label3.Text = "Giá bán:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(126, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThem.Location = new System.Drawing.Point(225, 442);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(145, 44);
            this.buttonThem.TabIndex = 5;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // FormThemSanPham
            // 
            this.AcceptButton = this.buttonThem;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(642, 544);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePickerNgayNhap);
            this.Controls.Add(this.textBoxGiaBan);
            this.Controls.Add(this.textBoxGiaNhap);
            this.Controls.Add(this.textBoxTen);
            this.Controls.Add(this.labelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormThemSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormThen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.TextBox textBoxGiaNhap;
        private System.Windows.Forms.TextBox textBoxGiaBan;
        private System.Windows.Forms.DateTimePicker datePickerNgayNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonThem;
    }
}