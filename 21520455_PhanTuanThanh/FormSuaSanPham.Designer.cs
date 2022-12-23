namespace _21520455_PhanTuanThanh
{
    partial class FormSuaSanPham
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
            this.buttonSua = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.textBoxGiaBan = new System.Windows.Forms.TextBox();
            this.textBoxGiaNhap = new System.Windows.Forms.TextBox();
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSua.Location = new System.Drawing.Point(231, 458);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(145, 44);
            this.buttonSua.TabIndex = 15;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 366);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 30);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tên sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(190, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 30);
            this.label3.TabIndex = 18;
            this.label3.Text = "Giá bán:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(178, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 30);
            this.label2.TabIndex = 17;
            this.label2.Text = "Giá nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 30);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // datePickerNgayNhap
            // 
            this.datePickerNgayNhap.CustomFormat = "dd/MM/yyyy";
            this.datePickerNgayNhap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePickerNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerNgayNhap.Location = new System.Drawing.Point(294, 362);
            this.datePickerNgayNhap.Name = "datePickerNgayNhap";
            this.datePickerNgayNhap.Size = new System.Drawing.Size(216, 35);
            this.datePickerNgayNhap.TabIndex = 14;
            // 
            // textBoxGiaBan
            // 
            this.textBoxGiaBan.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaBan.Location = new System.Drawing.Point(294, 278);
            this.textBoxGiaBan.Name = "textBoxGiaBan";
            this.textBoxGiaBan.Size = new System.Drawing.Size(216, 35);
            this.textBoxGiaBan.TabIndex = 13;
            this.textBoxGiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGiaBan_KeyPress);
            // 
            // textBoxGiaNhap
            // 
            this.textBoxGiaNhap.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGiaNhap.Location = new System.Drawing.Point(294, 198);
            this.textBoxGiaNhap.Name = "textBoxGiaNhap";
            this.textBoxGiaNhap.Size = new System.Drawing.Size(216, 35);
            this.textBoxGiaNhap.TabIndex = 12;
            this.textBoxGiaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxGiaNhap_KeyPress);
            // 
            // textBoxTen
            // 
            this.textBoxTen.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTen.Location = new System.Drawing.Point(294, 120);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(216, 35);
            this.textBoxTen.TabIndex = 11;
            this.textBoxTen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxTen_KeyPress);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(161, 42);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(321, 37);
            this.labelTitle.TabIndex = 10;
            this.labelTitle.Text = "Sửa thông tin sản phẩm";
            // 
            // FormSuaSanPham
            // 
            this.AcceptButton = this.buttonSua;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(642, 544);
            this.Controls.Add(this.buttonSua);
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
            this.Name = "FormSuaSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormSua";
            this.Load += new System.EventHandler(this.FormSuaSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerNgayNhap;
        private System.Windows.Forms.TextBox textBoxGiaBan;
        private System.Windows.Forms.TextBox textBoxGiaNhap;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.Label labelTitle;
    }
}