namespace duyanh
{
    partial class FormEdit
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblMa, lblTen, lblLL;
        private System.Windows.Forms.TextBox txtMa, txtTen, txtLL;
        private System.Windows.Forms.Button btnLuu, btnHuy;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblMa = new System.Windows.Forms.Label();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLL = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtLL = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.lblMa.Text = "Mã tác giả:"; this.lblMa.Location = new System.Drawing.Point(20, 20);
            this.txtMa.Location = new System.Drawing.Point(120, 20); this.txtMa.Size = new System.Drawing.Size(220, 22);

            this.lblTen.Text = "Tên tác giả:"; this.lblTen.Location = new System.Drawing.Point(20, 60);
            this.txtTen.Location = new System.Drawing.Point(120, 60); this.txtTen.Size = new System.Drawing.Size(220, 22);

            this.lblLL.Text = "Liên lạc:"; this.lblLL.Location = new System.Drawing.Point(20, 100);
            this.txtLL.Location = new System.Drawing.Point(120, 100); this.txtLL.Size = new System.Drawing.Size(220, 22);

            this.btnLuu.Text = "Lưu"; this.btnLuu.Location = new System.Drawing.Point(80, 150); this.btnLuu.Size = new System.Drawing.Size(100, 36);
            this.btnLuu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            this.btnHuy.Text = "Hủy"; this.btnHuy.Location = new System.Drawing.Point(200, 150); this.btnHuy.Size = new System.Drawing.Size(100, 36);
            this.btnHuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.ClientSize = new System.Drawing.Size(380, 210);
            this.Controls.Add(this.lblMa); this.Controls.Add(this.txtMa);
            this.Controls.Add(this.lblTen); this.Controls.Add(this.txtTen);
            this.Controls.Add(this.lblLL); this.Controls.Add(this.txtLL);
            this.Controls.Add(this.btnLuu); this.Controls.Add(this.btnHuy);
            this.Text = "Sửa tác giả";
        }
    }
}
