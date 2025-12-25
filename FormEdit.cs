using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace duyanh
{
    public partial class FormEdit : Form
    {
        private string _ma;
        public FormEdit(string ma, string ten, string lien)
        {
            InitializeComponent();
            _ma = ma;
            txtMa.Text = ma;
            txtTen.Text = ten;
            txtLL.Text = lien;
            txtMa.Enabled = false;

            UIHelper.MakeRounded(btnLuu, 14);
            UIHelper.MakeRounded(btnHuy, 14);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                Database.ExecStoredProc("sp_SuaTacGia",
                    new SqlParameter("@MaTacGia", _ma),
                    new SqlParameter("@TenTacGia", txtTen.Text.Trim()),
                    new SqlParameter("@LienLac", txtLL.Text.Trim())
                );
                MessageBox.Show("Sửa thành công!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e) => this.Close();
    }
}
