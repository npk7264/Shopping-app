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
        public static Panel pCart = new Panel();
        
        public Cart()
        {
            InitializeComponent();
        }

        public static FlowLayoutPanel cart_product;

        private void Cart_Load(object sender, EventArgs e)
        {
            flowLayoutPanelCart.AutoScroll = false;
            flowLayoutPanelCart.HorizontalScroll.Enabled = false;
            flowLayoutPanelCart.HorizontalScroll.Visible = false;
            flowLayoutPanelCart.HorizontalScroll.Maximum = 0;
            flowLayoutPanelCart.AutoScroll = true;

            int max1;
            if (Convert.ToInt32(Functions.GetFieldValues("select COUNT(ID) from GIOHANG")) != 0)
                max1 = Convert.ToInt32(Functions.GetFieldValues("select MAX(ID) from GIOHANG"));
            else
                max1 = 0;
            int max2;
            if (Convert.ToInt32(Functions.GetFieldValues("select COUNT(ID) from DONHANG")) != 0)
                max2 = Convert.ToInt32(Functions.GetFieldValues("select MAX(ID) from DONHANG"));
            else
                max2 = 0;

            if ((max1 == max2 && max2 != 0) || max1 == 0)
            {
                Label notice = new Label();
                notice.Text = "Giỏ hàng trống";
                notice.Font = new Font("Arial", 20, FontStyle.Regular);
                pnCart.Controls.Add(notice);
                notice.BringToFront();
                notice.Size = pnCart.Size;
                notice.TextAlign = ContentAlignment.MiddleCenter;
                return;
            }
            else
            {
                pnIndex.Visible = true;
                pnTien.Visible = true;
                List<string> sp_in_cart = Functions.GetFieldValuesList("select TenSP from GIOHANG where ID = " + max1.ToString());
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
                    name_lb.Location = new Point(140, 0);
                    name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                    name_lb.TextAlign = ContentAlignment.MiddleCenter;
                    // Price label
                    Label price_lb = new Label();
                    price_lb.Text = Functions.GetFieldValues("select GiaSP from SANPHAM where TenSP = N'" + sp + "'");
                    price_lb.Location = new Point(300, 38);
                    price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                    price_lb.TextAlign = ContentAlignment.MiddleCenter;
                    // Quantity label
                    Label quantity_lb = new Label();
                    quantity_lb.Text = Functions.GetFieldValues("select SoLuong from GIOHANG where TenSP = N'" + sp + "' and ID = " + max1.ToString());
                    quantity_lb.Location = new Point(470, 38);
                    quantity_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                    quantity_lb.TextAlign = ContentAlignment.MiddleCenter;
                    // Total price label
                    Label total_lb = new Label();
                    total_lb.Text = (Convert.ToInt32(price_lb.Text) * Convert.ToInt32(quantity_lb.Text)).ToString();
                    total_lb.Location = new Point(670, 38);
                    total_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                    total_lb.ForeColor = Color.FromArgb(193, 0, 23);
                    total_lb.TextAlign = ContentAlignment.MiddleCenter;
                    // Remove label
                    Label remove_lb = new Label();
                    remove_lb.Text = "Xóa";
                    remove_lb.Location = new Point(890, 38);
                    remove_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                    remove_lb.MouseClick += new MouseEventHandler(this._remove);

                    p.Controls.Add(pb);
                    p.Controls.Add(name_lb);
                    p.Controls.Add(price_lb);
                    p.Controls.Add(quantity_lb);
                    p.Controls.Add(total_lb);
                    p.Controls.Add(remove_lb);
                    flowLayoutPanelCart.Controls.Add(p);
                    cart_product = flowLayoutPanelCart;
                }
                lbTongTien.Text = Functions.GetFieldValues("select SUM(ThanhTien) from GIOHANG where ID = " + max1.ToString());
                pCart = pnCart;
            }
        }

        void _remove(object sender, MouseEventArgs e)
        {

            Label temp = (Label)sender;
            Control x = temp.Parent;
            Control name_lb = x.Controls[1];
            Control quantity_lb = x.Controls[3]; //
            x.Controls.Remove(name_lb);
            flowLayoutPanelCart.Controls.Remove(x);

            string id = Functions.GetFieldValues("select MAX(ID) from GIOHANG");
            Functions.RunSQL("delete from GIOHANG where TenSP = N'" + name_lb.Text + "' and ID = " + id);
            lbTongTien.Text = Functions.GetFieldValues("select SUM(ThanhTien) from GIOHANG where ID = " + id);
            pCart = pnCart;

            Functions.RunSQL("update SANPHAM set SoLuong = SoLuong + " + quantity_lb.Text + " where TenSP = N'" + name_lb.Text + "'");//
            
            if (flowLayoutPanelCart.Controls.Count == 0)
            {
                pnCart.Controls.Clear();
                Label notice = new Label();
                notice.Text = "Giỏ hàng trống";
                notice.Font = new Font("Arial", 20, FontStyle.Regular);
                pnCart.Controls.Add(notice);
                notice.BringToFront();
                notice.Size = pnCart.Size;
                notice.TextAlign = ContentAlignment.MiddleCenter;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            Payment frm = new Payment();
            frm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbBack_Click(object sender, EventArgs e)
        {
            this.Close();
            if (ProductInfo.product_to_cart == 1)
            {
                ProductInfo frm = new ProductInfo();
                frm.ShowDialog();
            }
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

        private void label8_Click(object sender, EventArgs e)
        {
            Order frm = new Order();
            frm.ShowDialog();
        }
    }
}
