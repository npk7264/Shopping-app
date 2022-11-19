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
    public partial class Order : Form
    {
        public static string id_click;
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            int count_order = Convert.ToInt32(Functions.GetFieldValues("select COUNT(ID) from DONHANG"));
            if(count_order == 0)
            {
                flowLayoutPanelOrder.AutoScroll = false;
                Label notice = new Label();
                notice.Text = "Chưa có đơn hàng nào";
                notice.Font = new Font("Arial", 20, FontStyle.Regular);
                flowLayoutPanelOrder.Controls.Add(notice);
                notice.BringToFront();
                notice.Size = flowLayoutPanelOrder.Size;
                notice.TextAlign = ContentAlignment.MiddleCenter;
                return;
            }

            flowLayoutPanelOrder.AutoScroll = false;
            flowLayoutPanelOrder.HorizontalScroll.Enabled = false;
            flowLayoutPanelOrder.HorizontalScroll.Visible = false;
            flowLayoutPanelOrder.HorizontalScroll.Maximum = 0;
            flowLayoutPanelOrder.AutoScroll = true;

            List<string> id = Functions.GetFieldValuesList("select ID from DONHANG order by ID desc");
            List<string> sosp = Functions.GetFieldValuesList("select SoSP from DONHANG order by ID desc");
            List<string> tongthanhtien = Functions.GetFieldValuesList("select TongThanhTien from DONHANG order by ID desc");
            List<string> ten = Functions.GetFieldValuesList("select ten from DONHANG order by ID desc");
            List<string> sodienthoai = Functions.GetFieldValuesList("select sodienthoai from DONHANG order by ID desc");
            List<string> diachi = Functions.GetFieldValuesList("select diachi from DONHANG order by ID desc");

            int count = id.Count();
            for (int i = 0; i < count; ++i)
            {
                Panel panel = new Panel();
                panel.Width = flowLayoutPanelOrder.Width - 20;
                panel.Height = 162;
                panel.BackColor = Color.White;
                panel.BorderStyle = BorderStyle.FixedSingle;
                panel.Cursor = Cursors.Hand;
                //
                Label lb1 = new Label();
                lb1.Text = "Người nhận: ";
                lb1.Width = 200;
                lb1.Location = new Point(10, 10);
                lb1.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lb1);
                //
                Label lb2 = new Label();
                lb2.Width = 150;
                lb2.Text = "Số điện thoại: ";
                lb2.Location = new Point(500, 10);
                lb2.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lb2);
                //
                Label lb3 = new Label();
                lb3.Width = 200;
                lb3.Text = "Địa chỉ: ";
                lb3.Location = new Point(10, 40);
                lb3.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lb3);
                //
                Label lb4 = new Label();
                lb4.Width = 200;
                lb4.Text = "Mã đơn hàng: ";
                lb4.Location = new Point(10, 90);
                lb4.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lb4);
                //
                Label lb5 = new Label();
                lb5.Width = 200;
                lb5.Text = "Số lượng sản phẩm: ";
                lb5.Location = new Point(10, 120);
                lb5.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lb5);
                //
                Label lb6 = new Label();
                lb6.Width = 150;
                lb6.Text = "Tổng tiền: ";
                lb6.Location = new Point(500, 120);
                lb6.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lb6);
                //////////////////////
                Label lbTen = new Label();
                lbTen.Text = ten[i];
                lbTen.ForeColor = Color.SteelBlue;
                lbTen.Width = 200;
                lbTen.Location = new Point(210, 10);
                lbTen.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lbTen);
                //
                Label lbSoDienThoai = new Label();
                lbSoDienThoai.Width = 150;
                lbSoDienThoai.Text = sodienthoai[i];
                lbSoDienThoai.ForeColor = Color.SteelBlue;
                lbSoDienThoai.Location = new Point(650, 10);
                lbSoDienThoai.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lbSoDienThoai);
                //
                Label lbDiaChi = new Label();
                lbDiaChi.Width = 700;
                lbDiaChi.Text = diachi[i];
                lbDiaChi.ForeColor = Color.SteelBlue;
                lbDiaChi.Location = new Point(210, 40);
                lbDiaChi.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lbDiaChi);
                //
                Label lbID = new Label();
                lbID.Width = 700;
                lbID.Text = id[i];
                lbID.Location = new Point(210, 90);
                lbID.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lbID);
                //
                Label lbSoSP = new Label();
                lbSoSP.Width = 200;
                lbSoSP.Text = sosp[i];
                lbSoSP.Location = new Point(210, 120);
                lbSoSP.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lbSoSP);
                //
                Label lbTongThanhTien = new Label();
                lbTongThanhTien.Width = 150;
                lbTongThanhTien.Text = tongthanhtien[i];
                lbTongThanhTien.Location = new Point(650, 120);
                lbTongThanhTien.Font = new Font("Arial", 14, FontStyle.Regular);
                panel.Controls.Add(lbTongThanhTien);
                //
                panel.MouseClick += new MouseEventHandler(this.order_click);
                foreach (Control control in panel.Controls)
                {
                    control.MouseClick += new MouseEventHandler(this.label_click);
                    control.Cursor = Cursors.Hand;
                }
                flowLayoutPanelOrder.Controls.Add(panel);
            }
        }

        void order_click(object sender, MouseEventArgs e)
        {
            Panel panel_click = (Panel)sender;
            Control label_id = panel_click.Controls[9];
            id_click = label_id.Text;
            DetailOrder frm = new DetailOrder();
            frm.ShowDialog();
        }

        void label_click(object sender, MouseEventArgs e)
        {
            Label lb_click = (Label)sender;
            Control panel = lb_click.Parent;
            order_click(panel, e);
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
