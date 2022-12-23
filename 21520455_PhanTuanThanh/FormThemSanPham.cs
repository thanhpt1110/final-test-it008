using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21520455_PhanTuanThanh
{
    public partial class FormThemSanPham : Form
    {
        // Khai báo biến
        private string strMa = null;
        private string Ten = null;
        private string GiaNhap = null;
        private string GiaBan = null;
        private string NgayNhap = null;
        List<SanPham> list = new List<SanPham>();

        public FormThemSanPham()
        {
            InitializeComponent();
        }

        public FormThemSanPham(List<SanPham> list)
        {
            InitializeComponent();
            this.list = list;
        }

        private int getMaSp()
        {
            int MaSP = 1;
            try
            {
                if (list.Count != 0)
                {
                    string MaTMP = list[list.Count - 1].Ma;
                    MaSP = (int.Parse(MaTMP) + 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MaSP;
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

        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkNhapThongTin())
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                strMa = getMaSp().ToString();
                SanPham sp = new SanPham();
                sp.Ma = strMa;
                sp.Ten = textBoxTen.Text;
                sp.GiaNhap = double.Parse(textBoxGiaNhap.Text);
                sp.GiaBan = double.Parse(textBoxGiaNhap.Text);
                sp.NgayNhap = DateTime.ParseExact(datePickerNgayNhap.Text, "dd/MM/yyyy", null);
                this.list.Add(sp);
                MessageBox.Show("Thêm thông tin thành công.", "Thông báo",
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
    }
}
