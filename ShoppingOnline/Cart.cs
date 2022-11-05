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
            if(count == 0)
            {
                MessageBox.Show("Không có sản phẩm nào trong giỏ hàng!");
            }
            flowLayoutPanelCart.AutoScroll = false;
            flowLayoutPanelCart.HorizontalScroll.Enabled = false;
            flowLayoutPanelCart.HorizontalScroll.Visible = false;
            flowLayoutPanelCart.HorizontalScroll.Maximum = 0;
            flowLayoutPanelCart.AutoScroll = true;

            for (int i = 0; i < 10; i++)
            {
                Panel p = new Panel();
                p.Size = new Size(1316, 100);
                p.BackColor = SystemColors.Window;
                // Product PictureBox
                PictureBox pb = new PictureBox();
                pb.BackgroundImage = Image.FromFile("meat\\thit1.jpg");
                pb.Location = new Point(20, 0);
                pb.Size = new Size(100, 100);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                // Detail label
                Label name_lb = new Label();
                name_lb.Text = Convert.ToString(Functions.GetFieldValues("select TenSP from SANPHAM where TenFile = 'thit1'"));
                name_lb.Location = new Point(170, 38);
                name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                // Price label
                Label price_lb = new Label();
                price_lb.Text = Convert.ToString(Functions.GetFieldValues("select GiaSP from SANPHAM where TenFile = 'thit1'"));
                price_lb.Location = new Point(470, 38);
                price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                // Quantity label
                Label quantity_lb = new Label();
                quantity_lb.Text = "10";
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
        }
    }
}
