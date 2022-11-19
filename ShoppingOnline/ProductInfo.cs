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
        public static int product_to_cart;
        public ProductInfo()
        {
            InitializeComponent();
            string sl = Functions.GetFieldValues("select SoLuong from SANPHAM where TenFile = N'" + Home.filenameclick + "'");
            if (sl == "0")
                txtSL.Text = "Tạm hết hàng";
            else
                txtSL.Text = sl + " sản phẩm";
        }

        string price;

        private void ProductInfo_Load(object sender, EventArgs e)
        {
            product_to_cart = 0;
            pbDetail.BackgroundImage = Home.pbClick.BackgroundImage;
            pbDetail.BackgroundImageLayout = ImageLayout.Zoom;
            lbTenSP.Text = Convert.ToString(Functions.GetFieldValues(
                "select TenSP from SANPHAM where TenFile = N'" + Home.filenameclick + "'"));
            lbGiaSP.Text = Convert.ToString(Functions.GetFieldValues(
                "select GiaSP from SANPHAM where TenFile = N'" + Home.filenameclick + "'")) + " đồng";
            price = lbGiaSP.Text.Substring(0, lbGiaSP.Text.Length - 5);
            lbXuatXu.Text = Convert.ToString(Functions.GetFieldValues(
                "select XuatXu from SANPHAM where TenFile = N'" + Home.filenameclick + "'"));
            lbThuongHieu.Text = Functions.GetFieldValues("select ThuongHieu from SANPHAM where TenFile = N'" + Home.filenameclick + "'");
            lbNgaySX.Text = Functions.GetFieldValues("select NgaySX from SANPHAM where TenFile = N'" + Home.filenameclick + "'");
            lbHanSD.Text = Functions.GetFieldValues("select HanSD from SANPHAM where TenFile = N'" + Home.filenameclick + "'");
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn phải chọn số lượng sản phẩm");
                txtSoLuong.Text = "1";
                return;
            }
            if (txtSL.Text == "Tạm hết hàng" || Convert.ToInt32(Functions.GetFieldValues("select SoLuong from SANPHAM where TenFile = N'" + Home.filenameclick + "'")) < Int32.Parse(txtSoLuong.Text))
            {
                MessageBox.Show("Không đủ số lượng sản phẩm");
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

            //
            Functions.RunSQL("update SANPHAM set SoLuong = SoLuong - " + txtSoLuong.Text + " where TenFile = N'" + Home.filenameclick + "'");
            string sl = Functions.GetFieldValues("select SoLuong from SANPHAM where TenFile = N'" + Home.filenameclick + "'");
            if(sl == "0")
                txtSL.Text = "Tạm hết hàng";
            else
                txtSL.Text = sl + " sản phẩm";
        }

        private void pbGioHang_Click(object sender, EventArgs e)
        {
            product_to_cart = 1;//
            Cart frm = new Cart();
            frm.ShowDialog();
            this.Close();//
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
            int count = Convert.ToInt32(Functions.GetFieldValues("select SoLuong from SANPHAM where TenFile = N'" + Home.filenameclick + "'"));
            if (Int32.Parse(txtSoLuong.Text) == count || txtSL.Text == "Tạm hết hàng")
                MessageBox.Show("Bạn đã chọn tối đa số lượng sản phẩm này");
            else
                txtSoLuong.Text = (Int32.Parse(txtSoLuong.Text) + 1).ToString();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "1")
                txtSoLuong.Text = (Int32.Parse(txtSoLuong.Text) - 1).ToString();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);
            foreach (Form f in openForms)
                if (f.Name != "Home")
                    f.Close();
        }
    }
}
