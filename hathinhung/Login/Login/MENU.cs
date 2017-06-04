using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
            this.FormClosed += MENU_FormClosed;
        }

        private void MENU_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            SinhVien sv = new SinhVien();
            sv.Show();
        }

        private void trợGiúpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HuongDan hd = new HuongDan();
            hd.Show();
        }

        private void giaovienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giaovien gv = new Giaovien();
            gv.Show();
        }

        private void monHocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MonHoc mh = new MonHoc();
            mh.Show();
        }

        private void diemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
