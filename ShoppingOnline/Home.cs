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

        string[] topic_list = { "meat", "vegetable", "noodle", "cake", "drink" };

        private void Home_Load(object sender, EventArgs e)
        {
            Functions.Connect();
            foreach (string topic in topic_list)
            {
                string[] files = Directory.GetFiles(topic);
                foreach (string file in files)
                {
                    int index = file.IndexOf("\\") + 1;
                    string path = file.Substring(index, file.Length - index - 4);

                    Panel p = new Panel();
                    p.Size = new Size(220, 250);
                    // Product Image
                    Panel pn = new Panel();
                    pn.Size = new Size(220, 165);
                    pn.Location = new Point(0, 0);
                    PictureBox pb = new PictureBox();
                    pb.Size = new Size(220, 165);
                    pb.BackgroundImageLayout = ImageLayout.Zoom;
                    pb.BackgroundImage = Image.FromFile(file);
                    pb.Tag = file;
                    pb.MouseClick += new MouseEventHandler(this._click);
                    pn.Controls.Add(pb);
                    // Name label
                    Label name_lb = new Label();
                    name_lb.Text = Convert.ToString(Functions.GetFieldValues(
                        "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                    name_lb.TextAlign = ContentAlignment.MiddleCenter;
                    name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                    name_lb.AutoSize = false;
                    name_lb.Width = 240;
                    name_lb.Location = new Point(0, 175);
                    // Price label
                    Label price_lb = new Label();
                    price_lb.Text = Convert.ToString(Functions.GetFieldValues(
                        "select GiaSP from SANPHAM where TenFile = N'" + path + "'"));
                    price_lb.TextAlign = ContentAlignment.MiddleCenter;
                    price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                    price_lb.AutoSize = false;
                    price_lb.Width = 240;
                    price_lb.Location = new Point(0, 200);
                    // Add to panel
                    p.Controls.Add(pn);
                    p.Controls.Add(name_lb);
                    p.Controls.Add(price_lb);
                    flowLayoutPanel.Controls.Add(p);
                }
            }
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
                int index = file.IndexOf("\\") + 1;
                string path = file.Substring(index, file.Length - index - 4);

                Panel p = new Panel();
                p.Size = new Size(220, 250);
                // Product Image
                Panel pn = new Panel();
                pn.Size = new Size(220, 165);
                pn.Location = new Point(0, 0);
                PictureBox pb = new PictureBox();
                pb.Size = new Size(220, 165);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pb.BackgroundImage = Image.FromFile(file);
                pb.Tag = file;
                pb.MouseClick += new MouseEventHandler(this._click);
                pn.Controls.Add(pb);
                // Name label
                Label name_lb = new Label();
                name_lb.Text = Convert.ToString(Functions.GetFieldValues(
                    "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                name_lb.TextAlign = ContentAlignment.MiddleCenter;
                name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                name_lb.AutoSize = false;
                name_lb.Width = 240;
                name_lb.Location = new Point(0, 175);
                // Price label
                Label price_lb = new Label();
                price_lb.Text = Convert.ToString(Functions.GetFieldValues(
                    "select GiaSP from SANPHAM where TenFile = N'" + path + "'"));
                price_lb.TextAlign = ContentAlignment.MiddleCenter;
                price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                price_lb.AutoSize = false;
                price_lb.Width = 240;
                price_lb.Location = new Point(0, 200);
                // Add to panel
                p.Controls.Add(pn);
                p.Controls.Add(name_lb);
                p.Controls.Add(price_lb);
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
        private void btnNuoc_Click(object sender, EventArgs e)
        {
            loadData("drink");
        }

        private void lbGioHang_Click(object sender, EventArgs e)
        {
            Cart frm = new Cart();
            frm.ShowDialog();
        }

        private void pbSearchIcon_Click(object sender, EventArgs e)
        {
            string search_string = txtTimSP.Text;
            string[] search_word_list = search_string.Split(' ');

            if (search_string.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập tên sản phẩm");
                return;
            }

            flowLayoutPanel.Controls.Clear();
            foreach (string topic in topic_list)
            {
                string[] files = Directory.GetFiles(topic);
                foreach (string file in files)
                {
                    int index = file.IndexOf("\\") + 1;
                    string path = file.Substring(index, file.Length - index - 4);
                    string tensp = Convert.ToString(Functions.GetFieldValues(
                            "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                    bool flag = true;

                    foreach (string i in search_word_list)
                        if (tensp.ToUpper().IndexOf(i.ToUpper()) == -1)
                            flag = false;

                    if (flag)
                    {
                        Panel p = new Panel();
                        p.Size = new Size(220, 250);
                        // Product Image
                        Panel pn = new Panel();
                        pn.Size = new Size(220, 165);
                        pn.Location = new Point(0, 0);
                        PictureBox pb = new PictureBox();
                        pb.Size = new Size(220, 165);
                        pb.BackgroundImageLayout = ImageLayout.Zoom;
                        pb.BackgroundImage = Image.FromFile(file);
                        pb.Tag = file;
                        pb.MouseClick += new MouseEventHandler(this._click);
                        pn.Controls.Add(pb);
                        // Name label
                        Label name_lb = new Label();
                        name_lb.Text = Convert.ToString(Functions.GetFieldValues(
                            "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                        name_lb.TextAlign = ContentAlignment.MiddleCenter;
                        name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                        name_lb.AutoSize = false;
                        name_lb.Width = 240;
                        name_lb.Location = new Point(0, 175);
                        // Price label
                        Label price_lb = new Label();
                        price_lb.Text = Convert.ToString(Functions.GetFieldValues(
                            "select GiaSP from SANPHAM where TenFile = N'" + path + "'"));
                        price_lb.TextAlign = ContentAlignment.MiddleCenter;
                        price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                        price_lb.AutoSize = false;
                        price_lb.Width = 240;
                        price_lb.Location = new Point(0, 200);
                        // Add to panel
                        p.Controls.Add(pn);
                        p.Controls.Add(name_lb);
                        p.Controls.Add(price_lb);
                        flowLayoutPanel.Controls.Add(p);
                    }
                }
            }
        }

        private void txtTimSP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search_string = txtTimSP.Text;
                string[] search_word_list = search_string.Split(' ');

                if (search_string.Trim().Length == 0)
                {
                    MessageBox.Show("Hãy nhập tên sản phẩm");
                    return;
                }

                flowLayoutPanel.Controls.Clear();
                foreach (string topic in topic_list)
                {
                    string[] files = Directory.GetFiles(topic);
                    foreach (string file in files)
                    {
                        int index = file.IndexOf("\\") + 1;
                        string path = file.Substring(index, file.Length - index - 4);
                        string tensp = Convert.ToString(Functions.GetFieldValues(
                                "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                        bool flag = true;

                        foreach (string i in search_word_list)
                            if (tensp.ToUpper().IndexOf(i.ToUpper()) == -1)
                                flag = false;

                        if (flag)
                        {
                            Panel p = new Panel();
                            p.Size = new Size(220, 250);
                            // Product Image
                            Panel pn = new Panel();
                            pn.Size = new Size(220, 165);
                            pn.Location = new Point(0, 0);
                            PictureBox pb = new PictureBox();
                            pb.Size = new Size(220, 165);
                            pb.BackgroundImageLayout = ImageLayout.Zoom;
                            pb.BackgroundImage = Image.FromFile(file);
                            pb.Tag = file;
                            pb.MouseClick += new MouseEventHandler(this._click);
                            pn.Controls.Add(pb);
                            // Name label
                            Label name_lb = new Label();
                            name_lb.Text = Convert.ToString(Functions.GetFieldValues(
                                "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                            name_lb.TextAlign = ContentAlignment.MiddleCenter;
                            name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                            name_lb.AutoSize = false;
                            name_lb.Width = 240;
                            name_lb.Location = new Point(0, 175);
                            // Price label
                            Label price_lb = new Label();
                            price_lb.Text = Convert.ToString(Functions.GetFieldValues(
                                "select GiaSP from SANPHAM where TenFile = N'" + path + "'"));
                            price_lb.TextAlign = ContentAlignment.MiddleCenter;
                            price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                            price_lb.AutoSize = false;
                            price_lb.Width = 240;
                            price_lb.Location = new Point(0, 200);
                            // Add to panel
                            p.Controls.Add(pn);
                            p.Controls.Add(name_lb);
                            p.Controls.Add(price_lb);
                            flowLayoutPanel.Controls.Add(p);
                        }
                    }
                }
            }
        }
    }
}