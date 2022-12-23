namespace _21520455_PhanTuanThanh
{
    partial class FormDanhSachSanPham
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
            this.listView = new System.Windows.Forms.ListView();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonThem = new System.Windows.Forms.Button();
            this.buttonSua = new System.Windows.Forms.Button();
            this.buttonXoa = new System.Windows.Forms.Button();
            this.buttonLuu = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listView.AutoArrange = false;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(33, 74);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(762, 469);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(261, 22);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(277, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Danh sách sản phẩm";
            // 
            // buttonThem
            // 
            this.buttonThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonThem.Location = new System.Drawing.Point(802, 74);
            this.buttonThem.Name = "buttonThem";
            this.buttonThem.Size = new System.Drawing.Size(145, 44);
            this.buttonThem.TabIndex = 2;
            this.buttonThem.Text = "Thêm";
            this.buttonThem.UseVisualStyleBackColor = true;
            this.buttonThem.Click += new System.EventHandler(this.buttonThem_Click);
            // 
            // buttonSua
            // 
            this.buttonSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSua.Location = new System.Drawing.Point(802, 199);
            this.buttonSua.Name = "buttonSua";
            this.buttonSua.Size = new System.Drawing.Size(145, 44);
            this.buttonSua.TabIndex = 3;
            this.buttonSua.Text = "Sửa";
            this.buttonSua.UseVisualStyleBackColor = true;
            this.buttonSua.Click += new System.EventHandler(this.buttonSua_Click);
            // 
            // buttonXoa
            // 
            this.buttonXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonXoa.Location = new System.Drawing.Point(801, 350);
            this.buttonXoa.Name = "buttonXoa";
            this.buttonXoa.Size = new System.Drawing.Size(145, 44);
            this.buttonXoa.TabIndex = 4;
            this.buttonXoa.Text = "Xóa";
            this.buttonXoa.UseVisualStyleBackColor = true;
            this.buttonXoa.Click += new System.EventHandler(this.buttonXoa_Click);
            // 
            // buttonLuu
            // 
            this.buttonLuu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLuu.Location = new System.Drawing.Point(802, 499);
            this.buttonLuu.Name = "buttonLuu";
            this.buttonLuu.Size = new System.Drawing.Size(145, 44);
            this.buttonLuu.TabIndex = 5;
            this.buttonLuu.Text = "Lưu";
            this.buttonLuu.UseVisualStyleBackColor = true;
            this.buttonLuu.Click += new System.EventHandler(this.buttonLuu_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã sản phẩm";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên sản phẩm";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giá nhập";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Giá bán";
            this.columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ngày nhập";
            this.columnHeader5.Width = 155;
            // 
            // FormDanhSachSanPham
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(959, 574);
            this.Controls.Add(this.buttonLuu);
            this.Controls.Add(this.buttonXoa);
            this.Controls.Add(this.buttonSua);
            this.Controls.Add(this.buttonThem);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.listView);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormDanhSachSanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sản phẩm";
            this.Load += new System.EventHandler(this.FormDanhSachSanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonThem;
        private System.Windows.Forms.Button buttonSua;
        private System.Windows.Forms.Button buttonXoa;
        private System.Windows.Forms.Button buttonLuu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

