using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21520455_PhanTuanThanh
{
    public partial class FormSuaSanPham : Form
    {
        // Khai báo biến
        private string Ma = null;
        private string Ten = null;
        private string GiaNhap = null;
        private string GiaBan = null;
        private string NgayNhap = null;
        List<SanPham> list = new List<SanPham>();
        public FormSuaSanPham()
        {
            InitializeComponent();
        }

        public FormSuaSanPham(string ma, List<SanPham> DSSP)
        {
            InitializeComponent();
            this.Ma = ma;
            this.list = DSSP;
        }

        private bool checkNhapThongTin()
        {
            bool check = false;
            Ten = this.textBoxTen.Text;
            GiaNhap = this.textBoxGiaNhap.Text;
            GiaBan = this.textBoxGiaBan.Text;
            NgayNhap = this.datePickerNgayNhap.Value.ToString("dd/MM/yyyy");
            if (Ten != "" && GiaNhap != "" && GiaBan != "")
                check = true;
            return check;
        }
        
        private void LoadThongTin()
        {
            foreach (SanPham sp in list)
            {
                if (sp.Ma == this.Ma)
                {
                    textBoxTen.Text = sp.Ten;
                    textBoxGiaNhap.Text = sp.GiaNhap.ToString();
                    textBoxGiaBan.Text = sp.GiaBan.ToString();
                    datePickerNgayNhap.Text = sp.NgayNhap.ToString("dd/MM/yyyy");
                    break;
                }
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            if (!checkNhapThongTin())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {

            // Lưu lại thông tin vào list
            for (int i = 0; i < list.Count; ++i)
            {
                SanPham sp = list[i];
                if (sp.Ma == this.Ma)
                {
                    sp.Ten = textBoxTen.Text;
                    sp.GiaNhap = double.Parse(textBoxGiaNhap.Text);
                    sp.GiaBan = double.Parse(textBoxGiaBan.Text);
                    sp.NgayNhap = DateTime.ParseExact(datePickerNgayNhap.Text, "dd/MM/yyyy", null);
                    break;
                }
            }
            MessageBox.Show("Sửa thông tin thành công.", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region Xử lý key press
        private void textBoxTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                if (char.IsDigit(e.KeyChar))
                {
                    MessageBox.Show("Không được nhập các kí tự số.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Không được nhập các kí tự đặc biệt.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void textBoxGiaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (char.IsWhiteSpace(e.KeyChar))
                {
                    MessageBox.Show("Không được để khoảng trắng.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (char.IsLetter(e.KeyChar))
                {
                    MessageBox.Show("Không được nhập chữ.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Không được nhập các kí tự đặc biệt.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }

        private void textBoxGiaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (char.IsWhiteSpace(e.KeyChar))
                {
                    MessageBox.Show("Không được để khoảng trắng.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (char.IsLetter(e.KeyChar))
                {
                    MessageBox.Show("Không được nhập chữ.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Không được nhập các kí tự đặc biệt.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.Handled = true;
                base.OnKeyPress(e);
            }
        }
        #endregion

        private void FormSuaSanPham_Load(object sender, EventArgs e)
        {
            LoadThongTin();
        }
    }
}
