using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingOnline
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.AutoScroll = false;
            flowLayoutPanel.HorizontalScroll.Enabled = false;
            flowLayoutPanel.HorizontalScroll.Visible = false;
            flowLayoutPanel.HorizontalScroll.Maximum = 0;
            flowLayoutPanel.AutoScroll = true;

            string id = Functions.GetFieldValues("select MAX(ID) from GIOHANG");
            List<string> sp_in_cart = Functions.GetFieldValuesList("select TenSP from GIOHANG where ID = " + id);

            foreach (string sp in sp_in_cart)
            {
                Panel p = new Panel();
                p.Size = new Size(flowLayoutPanel.Width - 20, 100);
                p.BackColor = SystemColors.Window;
                p.BorderStyle = BorderStyle.FixedSingle;

                string folder_name = Functions.GetFieldValues(
                    "select TenLoaiSP from SANPHAM a, GIOHANG b where a.TenSP = b.TenSP and a.TenSP = N'" + sp + "'");
                string file_name = Functions.GetFieldValues(
                    "select TenFile from SANPHAM a, GIOHANG b where a.TenSP = b.TenSP and a.TenSP = N'" + sp + "'");
                string path = folder_name + "/" + file_name + ".jpg";

                // Product PictureBox
                PictureBox pb = new PictureBox();
                pb.BackgroundImage = Image.FromFile(path);
                pb.Location = new Point(20, 0);
                pb.Size = new Size(100, 100);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                // Detail label
                Label name_lb = new Label();
                name_lb.Text = sp;
                name_lb.Height = 100;
                name_lb.Location = new Point(170, 0);
                name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                name_lb.TextAlign = ContentAlignment.MiddleCenter;
                // Price label
                Label price_lb = new Label();
                price_lb.Text = Functions.GetFieldValues("select GiaSP from SANPHAM where TenSP = N'" + sp + "'");
                price_lb.Location = new Point(380, 38);
                price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                price_lb.TextAlign = ContentAlignment.MiddleCenter;
                // Quantity label
                Label quantity_lb = new Label();
                quantity_lb.Text = Functions.GetFieldValues("select SoLuong from GIOHANG where TenSP = N'" + sp + "' and ID = " + id);
                quantity_lb.Location = new Point(570, 38);
                quantity_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                quantity_lb.TextAlign = ContentAlignment.MiddleCenter;
                // Total price label
                Label total_lb = new Label();
                total_lb.Text = (Convert.ToInt32(price_lb.Text) * Convert.ToInt32(quantity_lb.Text)).ToString();
                total_lb.Location = new Point(765, 38);
                total_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                total_lb.ForeColor = Color.FromArgb(193, 0, 23);
                total_lb.TextAlign= ContentAlignment.MiddleCenter;

                p.Controls.Add(pb);
                p.Controls.Add(name_lb);
                p.Controls.Add(price_lb);
                p.Controls.Add(quantity_lb);
                p.Controls.Add(total_lb);
                flowLayoutPanel.Controls.Add(p);
            }
            lbTien.Text = Functions.GetFieldValues("select SUM(ThanhTien) from GIOHANG where ID = " + id);
        }

        private void btnThanhToan_Click_1(object sender, EventArgs e)
        {
            if (txtTen.Text.Trim() == "" || txtSoDienThoai.Text.Trim() == "" || txtDiaChi.Text.Trim() == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin nhận hàng");
                return;
            }
            string id = Functions.GetFieldValues("select MAX(ID) from GIOHANG");
            string so_sp = Functions.GetFieldValues("select COUNT(TenSP) from GIOHANG where ID = " + id);
            Functions.RunSQL("insert into DONHANG values(" +
                id + ", " +
                so_sp + ", " +
                lbTien.Text + ", N'" + txtTen.Text.Trim() + "', " + txtSoDienThoai.Text.Trim() + ", N'" + txtDiaChi.Text.Trim() + "')");
            Cart.pCart.Controls.Clear();
            Label notice = new Label();
            notice.Text = "Giỏ hàng trống";
            notice.Font = new Font("Arial", 20, FontStyle.Regular);
            Cart.pCart.Controls.Add(notice);
            notice.BringToFront();
            notice.Size = Cart.pCart.Size;
            notice.TextAlign = ContentAlignment.MiddleCenter;
            this.Close();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
