using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Model;
namespace Login
{
    public partial class SinhVien : Form
    {
        public SinhVien()
        {
            InitializeComponent();
            Load += SinhVien_Load;
            dgvdanhsachhocsinh.DataError += Dgvdanhsachhocsinh_DataError;
            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            dgvdanhsachhocsinh.CellClick += Dgvdanhsachhocsinh_CellClick;
        }

        private void Dgvdanhsachhocsinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var row = dgvdanhsachhocsinh.CurrentRow)
            {
                txtmahs.Text = row.Cells["ma"].Value.ToString();
                txthoten.Text = row.Cells["hoten"].Value.ToString();
                radbnam.Checked = row.Cells["gioitinh"].Value.ToString().Equals("Nam") ? true : false;
                txtdiachi.Text = row.Cells["diachi"].Value.ToString();
                dtpngaysinh.Value = (DateTime)row.Cells["ngaysinh"].Value;
                cmblop.SelectedValue = row.Cells["lop"].Value;
                txthanhkiem.Text = row.Cells["hanhkiem"].Value.ToString();
                txtchucvu.Text = row.Cells["chucvu"].Value.ToString();
                cmbGiaoVien.SelectedValue = row.Cells["giaovienchunhiem"].Value;
                txthocluc.Text = row.Cells["hocluc"].Value.ToString();
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (txtmahs.Text != string.Empty && MessageBox.Show("Xoa?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MyContext db = new MyContext())
                {
                    var id = int.Parse(txtmahs.Text);
                    var hs = db.hocsinhs.SingleOrDefault(x => x.ma == id);
                    db.hocsinhs.Remove(hs);
                    db.SaveChanges();
                    MessageBox.Show("Da xoa");
                    LoadData();
                }
            }
        }

        private void LoadData()
        {

            using (var db = new MyContext())
            {
                dgvdanhsachhocsinh.DataSource = db.hocsinhs.ToList();
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (txtmahs.Text != string.Empty)
            {
                using (var db = new MyContext())
                {

                    var id = int.Parse(txtmahs.Text);
                    var hs = db.hocsinhs.Find(id);
                    if (hs != null)
                    {
                        hs.hoten = txthoten.Text;
                        hs.ngaysinh = dtpngaysinh.Value;
                        hs.gioitinh = radbnam.Checked ? "Nam" : "Nữ";
                        hs.diachi = txtdiachi.Text;
                        hs.lop = (int)cmblop.SelectedValue;
                        hs.hocluc = txthocluc.Text;
                        hs.hanhkiem = txthanhkiem.Text;
                        hs.chucvu = txtchucvu.Text;
                        hs.giaovienchunhiem = (int)cmbGiaoVien.SelectedValue;

                        db.SaveChanges();
                        MessageBox.Show("Da cap nhat");
                        LoadData();

                    }
                }
            }
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            if(txtmahs.Text!=string.Empty && txthoten.Text!=string.Empty)
            using (var db = new MyContext())
            {
                db.hocsinhs.Add(new hocsinh()
                {
                    ma = int.Parse(txtmahs.Text),
                    hoten = txthoten.Text,
                    ngaysinh = dtpngaysinh.Value,
                    gioitinh = radbnam.Checked ? "Nam" : "Nữ",
                    diachi = txtdiachi.Text,
                    lop = (int)cmblop.SelectedValue,
                    hocluc = txthocluc.Text,
                    hanhkiem = txthanhkiem.Text,
                    chucvu = txtchucvu.Text,
                    giaovienchunhiem = (int)cmbGiaoVien.SelectedValue,
                });
                db.SaveChanges();
                LoadData();
            }
        }

        private void Dgvdanhsachhocsinh_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SinhVien_Load(object sender, EventArgs e)
        {
            LoadData();
            using (var db = new MyContext())
            {
                cmblop.DataSource = db.lophocs.ToList();
                cmblop.DisplayMember = "ten";
                cmblop.ValueMember = "ma";

                cmbGiaoVien.DataSource = db.giaoviens.ToList();
                cmbGiaoVien.DisplayMember = "ten";
                cmbGiaoVien.ValueMember = "ma";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("ban chac chan muon thoat?", "xan nhan", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
    }
}
