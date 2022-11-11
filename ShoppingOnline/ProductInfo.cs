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

        string price;

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            pbDetail.BackgroundImage = Home.pbClick.BackgroundImage;
            pbDetail.BackgroundImageLayout = ImageLayout.Zoom;
            lbTenSP.Text = Convert.ToString(Functions.GetFieldValues(
                "select TenSP from SANPHAM where TenFile = N'" + Home.filenameclick + "'"));
            lbGiaSP.Text = Convert.ToString(Functions.GetFieldValues(
                "select GiaSP from SANPHAM where TenFile = N'" + Home.filenameclick + "'")) + " đồng";
            price = lbGiaSP.Text.Substring(0, lbGiaSP.Text.Length - 5);
            lbXuatXu.Text = Convert.ToString(Functions.GetFieldValues(
                "select XuatXu from SANPHAM where TenFile = N'" + Home.filenameclick + "'"));
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn số lượng sản phẩm");
                txtSoLuong.Text = "1";
                return;
            }

            string thanhtien = (Convert.ToInt32(price) * Convert.ToInt32(txtSoLuong.Text)).ToString();
            string sql;

            int count_donhang = Convert.ToInt32(Functions.GetFieldValues("select COUNT(ID) from DONHANG"));
            string id_donhang;
            if (count_donhang == 0)
                id_donhang = "1";
            else
                id_donhang = (Convert.ToInt32(Functions.GetFieldValues("select MAX(ID) from DONHANG")) + 1).ToString();

            int tensp = Convert.ToInt32(Functions.GetFieldValues("select COUNT(TenSP) from GIOHANG where TenSP = N'" + lbTenSP.Text + "' and ID = " + id_donhang));
            if (tensp == 0)
                sql = "insert into GIOHANG values (N'" + lbTenSP.Text + "', " + price + ", " + txtSoLuong.Text + ", " + thanhtien + ", " + id_donhang + ")";
            else
                sql = "update GIOHANG set SoLuong = SoLuong + " + txtSoLuong.Text + ", ThanhTien = ThanhTien + " + thanhtien + " where TenSP = N'" + lbTenSP.Text + "' and ID = " + id_donhang;
            Functions.RunSQL(sql);
        }

        private void pbGioHang_Click(object sender, EventArgs e)
        {
            Cart frm = new Cart();
            frm.ShowDialog();
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && e.KeyChar != 8) || (txtSoLuong.Text == "" && e.KeyChar == '0'))
                e.Handled = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Order frm = new Order();
            frm.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtSoLuong.Text = (Int32.Parse(txtSoLuong.Text) + 1).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "1")
                txtSoLuong.Text = (Int32.Parse(txtSoLuong.Text) - 1).ToString();
        }
    }
}
