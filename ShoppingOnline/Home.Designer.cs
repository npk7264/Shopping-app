namespace ShoppingOnline
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnThit = new System.Windows.Forms.Button();
            this.btnRau = new System.Windows.Forms.Button();
            this.btnMi = new System.Windows.Forms.Button();
            this.btnDau = new System.Windows.Forms.Button();
            this.btnBanh = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbGioHang = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnThit
            // 
            this.btnThit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThit.Location = new System.Drawing.Point(7, 36);
            this.btnThit.Name = "btnThit";
            this.btnThit.Size = new System.Drawing.Size(327, 46);
            this.btnThit.TabIndex = 0;
            this.btnThit.Text = "Thịt, cá, trứng, hải sản";
            this.btnThit.UseVisualStyleBackColor = true;
            this.btnThit.Click += new System.EventHandler(this.btnThit_Click);
            // 
            // btnRau
            // 
            this.btnRau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRau.Location = new System.Drawing.Point(7, 88);
            this.btnRau.Name = "btnRau";
            this.btnRau.Size = new System.Drawing.Size(327, 46);
            this.btnRau.TabIndex = 1;
            this.btnRau.Text = "Rau, củ, trái cây";
            this.btnRau.UseVisualStyleBackColor = true;
            this.btnRau.Click += new System.EventHandler(this.btnRau_Click);
            // 
            // btnMi
            // 
            this.btnMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMi.Location = new System.Drawing.Point(7, 140);
            this.btnMi.Name = "btnMi";
            this.btnMi.Size = new System.Drawing.Size(327, 46);
            this.btnMi.TabIndex = 2;
            this.btnMi.Text = "Mì, miến, cháo, phở";
            this.btnMi.UseVisualStyleBackColor = true;
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            // 
            // btnDau
            // 
            this.btnDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDau.Location = new System.Drawing.Point(7, 244);
            this.btnDau.Name = "btnDau";
            this.btnDau.Size = new System.Drawing.Size(327, 46);
            this.btnDau.TabIndex = 3;
            this.btnDau.Text = "Dầu ăn, nước chấm, gia vị";
            this.btnDau.UseVisualStyleBackColor = true;
            this.btnDau.Click += new System.EventHandler(this.btnDau_Click);
            // 
            // btnBanh
            // 
            this.btnBanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanh.Location = new System.Drawing.Point(7, 192);
            this.btnBanh.Name = "btnBanh";
            this.btnBanh.Size = new System.Drawing.Size(327, 46);
            this.btnBanh.TabIndex = 4;
            this.btnBanh.Text = "Bánh, kẹo";
            this.btnBanh.UseVisualStyleBackColor = true;
            this.btnBanh.Click += new System.EventHandler(this.btnBanh_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(383, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(374, 34);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Nhập sản phẩm bạn cần tìm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(763, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đơn hàng";
            // 
            // lbGioHang
            // 
            this.lbGioHang.AutoSize = true;
            this.lbGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGioHang.Location = new System.Drawing.Point(866, 18);
            this.lbGioHang.Name = "lbGioHang";
            this.lbGioHang.Size = new System.Drawing.Size(91, 25);
            this.lbGioHang.TabIndex = 7;
            this.lbGioHang.Text = "Giỏ hàng";
            this.lbGioHang.Click += new System.EventHandler(this.lbGioHang_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThit);
            this.panel1.Controls.Add(this.btnRau);
            this.panel1.Controls.Add(this.btnDau);
            this.panel1.Controls.Add(this.btnBanh);
            this.panel1.Controls.Add(this.btnMi);
            this.panel1.Location = new System.Drawing.Point(12, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 646);
            this.panel1.TabIndex = 10;
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(383, 82);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(931, 646);
            this.flowLayoutPanel.TabIndex = 11;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 740);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbGioHang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThit;
        private System.Windows.Forms.Button btnRau;
        private System.Windows.Forms.Button btnMi;
        private System.Windows.Forms.Button btnDau;
        private System.Windows.Forms.Button btnBanh;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbGioHang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
    }
}

