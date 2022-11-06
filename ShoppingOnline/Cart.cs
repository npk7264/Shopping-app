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
    public partial class Cart : Form
    {
        public Cart()
        {
            InitializeComponent();
        }

        int count;

        private void Cart_Load(object sender, EventArgs e)
        {
            count = Convert.ToInt32(Functions.GetFieldValues("select COUNT(TenSP) from GIOHANG"));
            if (count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong giỏ hàng!");
            }
            flowLayoutPanelCart.AutoScroll = false;
            flowLayoutPanelCart.HorizontalScroll.Enabled = false;
            flowLayoutPanelCart.HorizontalScroll.Visible = false;
            flowLayoutPanelCart.HorizontalScroll.Maximum = 0;
            flowLayoutPanelCart.AutoScroll = true;

            List<string> sp_in_cart = Functions.GetFieldValuesList("select TenSP from GIOHANG");

            foreach (string sp in sp_in_cart)
            {
                Panel p = new Panel();
                p.Size = new Size(1316, 100);
                p.BackColor = SystemColors.Window;

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
                name_lb.Location = new Point(170, 38);
                name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                // Price label
                Label price_lb = new Label();
                price_lb.Text = Functions.GetFieldValues("select GiaSP from SANPHAM where TenSP = N'" + sp + "'");
                price_lb.Location = new Point(470, 38);
                price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                // Quantity label
                Label quantity_lb = new Label();
                quantity_lb.Text = Functions.GetFieldValues("select SoLuong from GIOHANG where TenSP = N'" + sp + "'");
                quantity_lb.Location = new Point(570, 38);
                quantity_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                // Total price label
                Label total_lb = new Label();
                total_lb.Text = (Convert.ToInt32(price_lb.Text) * Convert.ToInt32(quantity_lb.Text)).ToString();
                total_lb.Location = new Point(670, 38);
                total_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                total_lb.ForeColor = Color.FromArgb(193, 0, 23);
                // Remove label
                Label remove_lb = new Label();
                remove_lb.Text = "Xóa";
                remove_lb.Location = new Point(870, 38);
                remove_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                remove_lb.MouseClick += new MouseEventHandler(this._remove);

                p.Controls.Add(pb);
                p.Controls.Add(name_lb);
                p.Controls.Add(price_lb);
                p.Controls.Add(quantity_lb);
                p.Controls.Add(total_lb);
                p.Controls.Add(remove_lb);
                flowLayoutPanelCart.Controls.Add(p);
            }
        }

        void _remove(object sender, MouseEventArgs e)
        {

            Label temp = (Label)sender;
            Control x = temp.Parent;
            Control name_lb = x.Controls[1];
            x.Controls.Remove(name_lb);
            flowLayoutPanelCart.Controls.Remove(x);
            Functions.RunSQL("delete from GIOHANG where TenSP = N'" + name_lb.Text + "'");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Payment frm = new Payment();
            frm.ShowDialog();
        }
    }
}
