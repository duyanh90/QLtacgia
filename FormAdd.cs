using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace duyanh
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
            UIHelper.MakeRounded(btnLuu, 14);
            UIHelper.MakeRounded(btnHuy, 14);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Database.ExecStoredProc("sp_ThemTacGia",
                    new SqlParameter("@MaTacGia", txtMa.Text.Trim()),
                    new SqlParameter("@TenTacGia", txtTen.Text.Trim()),
                    new SqlParameter("@LienLac", txtLL.Text.Trim())
                );
                MessageBox.Show("Thêm thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) => this.Close();
    }
}
