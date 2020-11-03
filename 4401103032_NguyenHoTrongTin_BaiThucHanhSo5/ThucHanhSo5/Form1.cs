using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhSo5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double tinhTien(double a, double b)
        {
            double tieuthu = b - a;
            if( 0< tieuthu && tieuthu <= 100 ) return 1.418;
            else if(tieuthu <= 150) return 1.622;
            else if (tieuthu <= 200) return 2.044;
            else if (tieuthu <= 300) return 2.210;
            else if (tieuthu <= 400) return 2.316;
            return 2.420;

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnTinh_Click(object sender, EventArgs e)
        {
            double csCu = double.Parse(tbCsCu.Text);
            double csMoi = double.Parse(tbCsMoi.Text);
            double tieuthu = csMoi - csCu;
            tbDienTieuThu.Text = tieuthu.ToString();
            double thanhtien = tinhTien(csCu, csMoi);
            tbThanhTien.Text = thanhtien.ToString();
            thanhtien *= 1.1;
            tbTongTienVAT.Text = thanhtien.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (this.GetNextControl(ActiveControl, true) != null)
                {
                    btnTinh_Click(sender, e);
                }
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            tbCsCu.Clear();
            tbCsMoi.Clear();
            tbDienTieuThu.Clear();
            tbThanhTien.Clear();
            tbTongTienVAT.Clear();
        }
    }
}
