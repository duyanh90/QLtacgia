using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace duyanh
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            // apply rounded style to buttons created in Designer
            UIHelper.MakeRounded(btnThem, 14);
            UIHelper.MakeRounded(btnSua, 14);
            UIHelper.MakeRounded(btnXoa, 14);
            UIHelper.MakeRounded(btnHienThi, 14);
            UIHelper.MakeRounded(btnTimKiem, 14);

            UIHelper.SetPlaceholderBehavior(txtTimKiem, "Tên tác giả...");

            LoadData();
        }

        private void LoadData()
        {
            try
            {
                dgvTacGia.DataSource = Database.GetData("SELECT * FROM TacGia");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
            }
        }

        private void btnHienThi_Click(object sender, EventArgs e) => LoadData();

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (var f = new FormAdd())
            {
                f.ShowDialog();
            }
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn một tác giả để sửa.");
                return;
            }
            var row = dgvTacGia.SelectedRows[0];
            string ma = row.Cells[0].Value?.ToString();
            string ten = row.Cells[1].Value?.ToString();
            string lien = row.Cells[2].Value?.ToString();

            using (var f = new FormEdit(ma, ten, lien))
            {
                f.ShowDialog();
            }
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvTacGia.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chọn một tác giả để xóa.");
                return;
            }
            var row = dgvTacGia.SelectedRows[0];
            string ma = row.Cells[0].Value?.ToString();
            using (var f = new FormDelete(ma))
            {
                f.ShowDialog();
            }
            LoadData();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string key = txtTimKiem.Text;
                if (key == (string)txtTimKiem.Tag) key = ""; // placeholder active
                var dt = Database.GetData("SELECT * FROM TacGia WHERE TenTacGia LIKE @s",
                    new SqlParameter("@s", "%" + key + "%"));
                dgvTacGia.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message);
            }
        }

        private void dgvTacGia_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // double-click to edit
            if (e.RowIndex >= 0)
            {
                var row = dgvTacGia.Rows[e.RowIndex];
                string ma = row.Cells[0].Value?.ToString();
                string ten = row.Cells[1].Value?.ToString();
                string lien = row.Cells[2].Value?.ToString();

                using (var f = new FormEdit(ma, ten, lien))
                {
                    f.ShowDialog();
                }
                LoadData();
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // simple placeholder: show message or open another form
            MessageBox.Show("Về trang chủ (nếu có form Home, mở ở đây).");
        }

        private void dgvTacGia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(835, 531);
            this.Name = "FormMain";
            this.ResumeLayout(false);

        }
    }
}
