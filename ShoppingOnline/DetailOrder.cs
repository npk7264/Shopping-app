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
    public partial class DetailOrder : Form
    {
        public DetailOrder()
        {
            InitializeComponent();
        }

        private void DetailOrder_Load(object sender, EventArgs e)
        {
            flowLayoutPanelCart.AutoScroll = false;
            flowLayoutPanelCart.HorizontalScroll.Enabled = false;
            flowLayoutPanelCart.HorizontalScroll.Visible = false;
            flowLayoutPanelCart.HorizontalScroll.Maximum = 0;
            flowLayoutPanelCart.AutoScroll = true;

            string max1 = Order.id_click;

            List<string> sp_in_cart = Functions.GetFieldValuesList("select TenSP from GIOHANG where ID = " + max1);
            foreach (string sp in sp_in_cart)
            {
                Panel p = new Panel();
                p.Size = new Size(flowLayoutPanelCart.Width - 20, 100);
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
                price_lb.Location = new Point(315, 38);
                price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                // Quantity label
                Label quantity_lb = new Label();
                quantity_lb.Text = Functions.GetFieldValues("select SoLuong from GIOHANG where TenSP = N'" + sp + "' and ID = " + max1);
                quantity_lb.Location = new Point(520, 38);
                quantity_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                // Total price label
                Label total_lb = new Label();
                total_lb.Text = (Convert.ToInt32(price_lb.Text) * Convert.ToInt32(quantity_lb.Text)).ToString();
                total_lb.Location = new Point(680, 38);
                total_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                total_lb.ForeColor = Color.FromArgb(193, 0, 23);

                p.Controls.Add(pb);
                p.Controls.Add(name_lb);
                p.Controls.Add(price_lb);
                p.Controls.Add(quantity_lb);
                p.Controls.Add(total_lb);
                flowLayoutPanelCart.Controls.Add(p);
            }
            lbTongTien.Text = Functions.GetFieldValues("select SUM(ThanhTien) from GIOHANG where ID = " + max1);
        }
    }
}
