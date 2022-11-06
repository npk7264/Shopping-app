using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline
{
    public partial class ProductInfo : Form
    {
        public ProductInfo()
        {
            InitializeComponent();
        }

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            pbDetail.BackgroundImage = Home.pbClick.BackgroundImage;
            pbDetail.BackgroundImageLayout = ImageLayout.Zoom;
            lbTenSP.Text = Convert.ToString(Functions.GetFieldValues(
                "select TenSP from SANPHAM where TenFile = N'" + Home.filenameclick + "'"));
            lbGiaSP.Text = Convert.ToString(Functions.GetFieldValues(
                "select GiaSP from SANPHAM where TenFile = N'" + Home.filenameclick + "'"));
            lbXuatXu.Text = Convert.ToString(Functions.GetFieldValues(
                "select XuatXu from SANPHAM where TenFile = N'" + Home.filenameclick + "'"));
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            string thanhtien = (Convert.ToInt32(lbGiaSP.Text) * Convert.ToInt32(lbSoLuong.Text)).ToString();
            string sql;
            int tensp = Convert.ToInt32(Functions.GetFieldValues("select COUNT(TenSP) from GIOHANG where TenSP = N'" + lbTenSP.Text + "'"));
            if (tensp == 0)
                sql = "insert into GIOHANG values (N'" + lbTenSP.Text + "', " + lbGiaSP.Text + ", " + lbSoLuong.Text + ", " + thanhtien + ")";
            else
                sql = "update GIOHANG set SoLuong = SoLuong + " + lbSoLuong.Text + ", ThanhTien = ThanhTien + " + thanhtien + " where TenSP = N'" + lbTenSP.Text + "'";
            Functions.RunSQL(sql);
        }

        private void btnGiamSP_Click(object sender, EventArgs e)
        {
            if (lbSoLuong.Text != "1")
            {
                int soluong = Int32.Parse(lbSoLuong.Text) - 1;
                lbSoLuong.Text = soluong.ToString();
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            int soluong = Int32.Parse(lbSoLuong.Text) + 1;
            lbSoLuong.Text = soluong.ToString();
        }
    }
}
