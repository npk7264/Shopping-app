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
using System.IO;

namespace ShoppingOnline
{
    public partial class Home : Form
    {
        public static string topic;
        public static string filenameclick;
        public static PictureBox pbClick;
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            string[] files = Directory.GetFiles("meat");
            foreach (string file in files)
            {
                Panel p = new Panel();
                p.Size = new Size(220, 240);
                // Product Image
                PictureBox pb = new PictureBox();
                pb.Size = new Size(220, 220);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pb.BackgroundImage = Image.FromFile(file);
                pb.Tag = file;
                pb.MouseClick += new MouseEventHandler(this._click);
                // Price label
                Label lb = new Label();
                int index = file.IndexOf("\\") + 1;
                string path = file.Substring(index, file.Length - index - 4);
                lb.Text = Convert.ToString(Functions.GetFieldValues(
                    "select GiaSP from SANPHAM where TenFile = N'" + path + "'"));
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.BackColor = Color.Aqua;
                lb.Font = new Font("Arial", 12, FontStyle.Regular);
                lb.AutoSize = false;
                lb.Width = 240;
                lb.Location = new Point(3, 218);
                // Add to panel
                p.Controls.Add(pb);
                p.Controls.Add(lb);
                flowLayoutPanel.Controls.Add(p);
            }
            Cart cart = new Cart();
            cart.ShowDialog();
        }

        void _click(object sender, MouseEventArgs e)
        {
            pbClick = (PictureBox)sender;
            filenameclick = (string)pbClick.Tag;
            int index = filenameclick.IndexOf("\\") + 1;
            filenameclick = filenameclick.Substring(index, filenameclick.Length - index - 4);
            ProductInfo frm = new ProductInfo();
            frm.ShowDialog();
        }

        void loadData(string topic)
        {
            flowLayoutPanel.Controls.Clear();
            string[] files = Directory.GetFiles(topic);
            foreach (string file in files)
            {
                Panel p = new Panel();
                p.Size = new Size(220, 240);
                // Product Image
                PictureBox pb = new PictureBox();
                pb.Size = new Size(220, 220);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pb.BackgroundImage = Image.FromFile(file);
                pb.Tag = file;
                pb.MouseClick += new MouseEventHandler(this._click);
                // Price label
                Label lb = new Label();
                int index = file.IndexOf("\\") + 1;
                string path = file.Substring(index, file.Length - index - 4);
                lb.Text = Convert.ToString(Functions.GetFieldValues(
                    "select GiaSP from SANPHAM where TenFile = N'" + path + "'"));
                lb.TextAlign = ContentAlignment.MiddleCenter;
                lb.BackColor = Color.Aqua;
                lb.Font = new Font("Arial", 12, FontStyle.Regular);
                lb.AutoSize = false;
                lb.Width = 240;
                lb.Location = new Point(3, 218);
                // Add to panel
                p.Controls.Add(pb);
                p.Controls.Add(lb);
                flowLayoutPanel.Controls.Add(p);
            }
        }

        private void btnThit_Click(object sender, EventArgs e)
        {
            loadData("meat");
        }

        private void btnRau_Click(object sender, EventArgs e)
        {
            loadData("vegetable");
        }

        private void btnMi_Click(object sender, EventArgs e)
        {
            loadData("noodle");
        }

        private void btnBanh_Click(object sender, EventArgs e)
        {
            loadData("cake");
        }

        private void btnDau_Click(object sender, EventArgs e)
        {
            loadData("drink");
        }

        private void lbGioHang_Click(object sender, EventArgs e)
        {
            Cart frm = new Cart();
            frm.ShowDialog();
        }
    }
}