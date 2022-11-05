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
            string sql = "insert into GIOHANG values (N'" + lbTenSP.Text + "', " + lbGiaSP.Text + ", " + lbSoLuong.Text + ")";
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
