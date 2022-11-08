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
            this.label4 = new System.Windows.Forms.Label();
            this.lbOrder = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.pbGioHang = new System.Windows.Forms.PictureBox();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pbGioHang);
            this.panel2.Controls.Add(this.lbOrder);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 83);
            this.panel2.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(32, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 83);
            this.label4.TabIndex = 16;
            this.label4.Text = "Grocery";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrder
            // 
            this.lbOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.lbOrder.Location = new System.Drawing.Point(987, 20);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(125, 43);
            this.lbOrder.TabIndex = 6;
            this.lbOrder.Text = "Đơn hàng";
            this.lbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.txtTimSP);
            this.panel3.Controls.Add(this.pbSearchIcon);
            this.panel3.Location = new System.Drawing.Point(371, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 50);
            this.panel3.TabIndex = 14;
            // 
            // txtTimSP
            // 
            this.txtTimSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtTimSP.Location = new System.Drawing.Point(12, 11);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(459, 27);
            this.txtTimSP.TabIndex = 5;
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
            // pbGioHang
            // 
            this.pbGioHang.BackColor = System.Drawing.Color.SteelBlue;
            this.pbGioHang.BackgroundImage = global::ShoppingOnline.Properties.Resources._353439_basket_purse_shopping_cart_ecommerce_icon;
            this.pbGioHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGioHang.Location = new System.Drawing.Point(1140, 20);
            this.pbGioHang.Name = "pbGioHang";
            this.pbGioHang.Size = new System.Drawing.Size(73, 43);
            this.pbGioHang.TabIndex = 15;
            this.pbGioHang.TabStop = false;
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.BackColor = System.Drawing.Color.SteelBlue;
            this.pbSearchIcon.BackgroundImage = global::ShoppingOnline.Properties.Resources._211817_search_strong_icon;
            this.pbSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchIcon.Location = new System.Drawing.Point(481, 4);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(73, 43);
            this.pbSearchIcon.TabIndex = 12;
            this.pbSearchIcon.TabStop = false;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 740);
            this.Controls.Add(this.flowLayoutPanelOrder);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbGioHang;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.PictureBox pbSearchIcon;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOrder;
    }
}