using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace duyanh
{
    public partial class FormDelete : Form
    {
        private string _ma;
        public FormDelete(string ma)
        {
            InitializeComponent();
            _ma = ma;
            lblInfo.Text = "Bạn có chắc muốn xóa tác giả: " + ma + " ?";
            UIHelper.MakeRounded(btnXacNhan, 14);
            UIHelper.MakeRounded(btnHuy, 14);
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                Database.ExecStoredProc("sp_XoaTacGia",
                    new SqlParameter("@MaTacGia", _ma)
                );
                MessageBox.Show("Xóa thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) => this.Close();
    }
}
