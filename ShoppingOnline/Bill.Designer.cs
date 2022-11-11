namespace ShoppingOnline
{
    partial class Bill
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
            this.pbGioHang = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGioHang)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pbGioHang);
            this.panel2.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(988, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 43);
            this.label1.TabIndex = 6;
            this.label1.Text = "Đơn hàng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 740);
            this.Controls.Add(this.panel2);
            this.Name = "Bill";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bill";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbGioHang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbGioHang;
        private System.Windows.Forms.Label label1;
    }
}