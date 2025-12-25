namespace duyanh
{
    partial class FormDelete
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnXacNhan, btnHuy;

        protected override void Dispose(bool disposing) { if (disposing && (components != null)) components.Dispose(); base.Dispose(disposing); }

        private void InitializeComponent()
        {
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();

            this.lblInfo.Location = new System.Drawing.Point(20, 20);
            this.lblInfo.Size = new System.Drawing.Size(340, 40);

            this.btnXacNhan.Text = "Xác nhận"; this.btnXacNhan.Location = new System.Drawing.Point(40, 80); this.btnXacNhan.Size = new System.Drawing.Size(120, 36);
            this.btnXacNhan.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);

            this.btnHuy.Text = "Hủy"; this.btnHuy.Location = new System.Drawing.Point(200, 80); this.btnHuy.Size = new System.Drawing.Size(120, 36);
            this.btnHuy.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);

            this.ClientSize = new System.Drawing.Size(380, 140);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnHuy);
            this.Text = "Xóa tác giả";
        }
    }
}
