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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _21520455_PhanTuanThanh
{
    public partial class FormDanhSachSanPham : Form
    {
        private List<SanPham> DSSP = new List<SanPham>();
        public FormDanhSachSanPham()
        {
            InitializeComponent();
        }

        private void LoadDataTuFile()
        {
            listView.Clear();
            DSSP.Clear();

            listView.Columns.Add("Mã sản phẩm", 120);
            listView.Columns.Add("Tên sản phẩm", 180);
            listView.Columns.Add("Giá nhập", 150);
            listView.Columns.Add("Giá bán", 150);
            listView.Columns.Add("Ngày nhập", 155);
            listView.View = View.Details;

            string[] lines = File.ReadAllLines("dssp.txt");
            for (int i = 0; i < lines.Length; ++i)
            {
                string[] words = lines[i].Split('|');
                SanPham sp = new SanPham();
                sp.Ma = words[0];
                sp.Ten = words[1];
                sp.GiaNhap = double.Parse(words[2]);
                sp.GiaBan = double.Parse(words[3]);
                sp.NgayNhap = DateTime.Parse(words[4]);
                DSSP.Add(sp);
            }

            for (int i = 0; i < DSSP.Count; ++i)
            {
                listView.Items.Add(DSSP[i].Ma.ToString());
                listView.Items[i].SubItems.Add(DSSP[i].Ten.ToString());
                listView.Items[i].SubItems.Add(DSSP[i].GiaNhap.ToString());
                listView.Items[i].SubItems.Add(DSSP[i].GiaBan.ToString());
                listView.Items[i].SubItems.Add(DSSP[i].NgayNhap.ToString("dd/MM/yyyy"));
            }
        }

        private void LoadThongTinTuListview()
        {
            DSSP.Clear();
            foreach (ListViewItem item in listView.Items)
            {
                item.Selected = true;
                SanPham sp = new SanPham();
                sp.Ma = item.SubItems[0].Text;
                sp.Ten = item.SubItems[1].Text;
                sp.GiaNhap = double.Parse(item.SubItems[2].Text);
                sp.GiaBan = double.Parse(item.SubItems[3].Text);
                sp.NgayNhap = DateTime.Parse(item.SubItems[4].Text);
                DSSP.Add(sp);
            }
        }

        private void LoadDataVaoListview(List<SanPham> sp)
        {
            listView.Clear();
            listView.Columns.Add("Mã sản phẩm", 120);
            listView.Columns.Add("Tên sản phẩm", 180);
            listView.Columns.Add("Giá nhập", 150);
            listView.Columns.Add("Giá bán", 150);
            listView.Columns.Add("Ngày nhập", 155);
            listView.View = View.Details;

            for (int i = 0; i < DSSP.Count; ++i)
            {
                listView.Items.Add(DSSP[i].Ma.ToString());
                listView.Items[i].SubItems.Add(DSSP[i].Ten.ToString());
                listView.Items[i].SubItems.Add(DSSP[i].GiaNhap.ToString());
                listView.Items[i].SubItems.Add(DSSP[i].GiaBan.ToString());
                listView.Items[i].SubItems.Add(DSSP[i].NgayNhap.ToString("dd/MM/yyyy"));
            }
        }

        private void FormDanhSachSanPham_Load(object sender, EventArgs e)
        {
            if (File.Exists("dssp.txt"))
              LoadDataTuFile();
        }
       
        private void buttonThem_Click(object sender, EventArgs e)
        {
            try
            {
                using (FormThemSanPham formThemSanPham = new FormThemSanPham(DSSP))
                {
                    formThemSanPham.ShowDialog();
                    LoadDataVaoListview(DSSP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = listView.SelectedItems[0];
                string ma = lvi.Text;
                LoadThongTinTuListview();
                using (FormSuaSanPham formSuaSanPham = new FormSuaSanPham(ma, DSSP))
                {
                    formSuaSanPham.ShowDialog();
                    LoadDataVaoListview(DSSP);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn 1 hàng cần sửa.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem lvi = listView.SelectedItems[0];
                string ma = lvi.Text;
                int idx = -1;
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    LoadThongTinTuListview();
                    for (int i = 0; i < DSSP.Count; ++i)
                    {
                        SanPham sp = DSSP[i];
                        if (sp.Ma == ma)
                        {
                            idx = i; break;
                        }
                    }
                    DSSP.RemoveAt(idx);
                    LoadDataVaoListview(DSSP);
                    MessageBox.Show("Xóa thành công.", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Vui lòng chọn 1 hàng cần xóa.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLuu_Click(object sender, EventArgs e)
        {
            try
            {
                LoadThongTinTuListview();

                if (!File.Exists("dssp.txt"))
                {
                    File.Create("dssp.txt").Close();
                    using (StreamWriter sw = new StreamWriter("dssp.txt"))
                    {
                        for (int i = 0; i < DSSP.Count; ++i)
                        {
                            SanPham sp = DSSP[i];
                            string[] words = { sp.Ma, sp.Ten, sp.GiaNhap.ToString(), sp.GiaBan.ToString(), sp.NgayNhap.ToString("dd/MM/yyyy") };
                            string data = String.Join("|", words);
                            sw.WriteLine(data);
                        }
                    }
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter("dssp.txt"))
                    {
                        for (int i = 0; i < DSSP.Count; ++i)
                        {
                            SanPham sp = DSSP[i];
                            string[] words = { sp.Ma, sp.Ten, sp.GiaNhap.ToString(), sp.GiaBan.ToString(), sp.NgayNhap.ToString("dd/MM/yyyy") };
                            string data = String.Join("|", words);
                            sw.WriteLine(data);
                        }
                    }
                }

                MessageBox.Show("Lưu thông tin thành công.", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            LoadDataTuFile();
        }
    }
}
