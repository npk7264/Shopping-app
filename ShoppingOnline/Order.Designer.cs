namespace ShoppingOnline
{
    partial class Order
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbHome = new System.Windows.Forms.PictureBox();
            this.pbGioHang = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(125)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pbBack);
            this.panel2.Controls.Add(this.pbHome);
            this.panel2.Controls.Add(this.pbGioHang);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 83);
            this.panel2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(529, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 38);
            this.label3.TabIndex = 21;
            this.label3.Text = "Đơn hàng đã đặt";
            // 
            // pbBack
            // 
            this.pbBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(125)))), ((int)(((byte)(252)))));
            this.pbBack.BackgroundImage = global::ShoppingOnline.Properties.Resources._1564492_navigation_back_arrow_left_icon;
            this.pbBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Location = new System.Drawing.Point(78, 20);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(73, 43);
            this.pbBack.TabIndex = 19;
            this.pbBack.TabStop = false;
            this.pbBack.Click += new System.EventHandler(this.pbBack_Click);
            // 
            // pbHome
            // 
            this.pbHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(125)))), ((int)(((byte)(252)))));
            this.pbHome.BackgroundImage = global::ShoppingOnline.Properties.Resources._216242_home_icon;
            this.pbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbHome.Location = new System.Drawing.Point(208, 20);
            this.pbHome.Name = "pbHome";
            this.pbHome.Size = new System.Drawing.Size(73, 43);
            this.pbHome.TabIndex = 18;
            this.pbHome.TabStop = false;
            this.pbHome.Click += new System.EventHandler(this.pbHome_Click);
            // 
            // pbGioHang
            // 
            this.pbGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(125)))), ((int)(((byte)(252)))));
            this.pbGioHang.BackgroundImage = global::ShoppingOnline.Properties.Resources._353439_basket_purse_shopping_cart_ecommerce_icon;
            this.pbGioHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGioHang.Location = new System.Drawing.Point(1164, 20);
            this.pbGioHang.Name = "pbGioHang";
            this.pbGioHang.Size = new System.Drawing.Size(73, 43);
            this.pbGioHang.TabIndex = 15;
            this.pbGioHang.TabStop = false;
            // 
            // flowLayoutPanelOrder
            // 
            this.flowLayoutPanelOrder.AutoScroll = true;
            this.flowLayoutPanelOrder.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanelOrder.Location = new System.Drawing.Point(12, 110);
            this.flowLayoutPanelOrder.Name = "flowLayoutPanelOrder";
            this.flowLayoutPanelOrder.Size = new System.Drawing.Size(1305, 618);
            this.flowLayoutPanelOrder.TabIndex = 15;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 740);
            this.Controls.Add(this.flowLayoutPanelOrder);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGioHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbGioHang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrder;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbHome;
        private System.Windows.Forms.Label label3;
    }
}