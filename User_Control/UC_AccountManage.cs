using Ktra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeHouseABC.User_Control
{
    public partial class UC_AccountManage : UserControl
    {
        public UC_AccountManage()
        {
            InitializeComponent();
        }

        private void UC_AccountManage_Load(object sender, EventArgs e)
        {
            // Get account's data 
            DataTable dt = DataProcess.ReadTable("SELECT MaKH, TenTaiKhoan, MatKhau, VaiTro, NgayTao FROM KHACHHANG");
            dgvAccountList.DataSource = dt;
        }

        private void lblAdd_Click(object sender, EventArgs e)
        {
            using (var form = new FormAddAccount())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ form nhập
                    string username = form.Username;
                    string password = form.Password;
                    string role = form.Role;

                    // Gọi hàm thêm vào database
                    DataProcess.UpdateData(
                        $"INSERT INTO KHACHHANG (TenTaiKhoan, MatKhau, VaiTro, NgayTao) " +
                        $"VALUES (N'{username}', N'{password}', N'{role}', GETDATE())"
                    );

                    // Thêm luôn vào ListView cho hiển thị
                    ListViewItem item = new ListViewItem(username);
                    item.SubItems.Add(password);
                    item.SubItems.Add(role);
                    dgvAccountList.DataSource = DataProcess.ReadTable("SELECT MaKH, TenTaiKhoan, MatKhau, VaiTro, NgayTao Role FROM KHACHHANG");

                    MessageBox.Show("Thêm tài khoản thành công!");
                }
            }
        }

        private void lblEdit_Click(object sender, EventArgs e)
        {
            if (dgvAccountList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa!");
                return;
            }
            // Lấy thông tin tài khoản hiện tại
            DataGridViewRow selectedRow = dgvAccountList.SelectedRows[0];
            string currentUserId = selectedRow.Cells["MaKH"].Value.ToString();
            string currentUsername = selectedRow.Cells["TenTaiKhoan"].Value.ToString();
            string currentPassword = selectedRow.Cells["MatKhau"].Value.ToString();
            string currentRole = selectedRow.Cells["VaiTro"].Value.ToString();
            using (var form = new FormAddAccount(currentUsername, currentPassword, currentRole))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    // Lấy dữ liệu từ form nhập
                    string newUsername = form.Username;
                    string newPassword = form.Password;
                    string newRole = form.Role;
                    // Cập nhật vào database
                    DataProcess.UpdateData(
                        $"UPDATE KHACHHANG SET " +
                        $"TenTaiKhoan = N'{newUsername}', " +
                        $"MatKhau = N'{newPassword}', " +
                        $"VaiTro = N'{newRole}' " +
                        $"WHERE MaKH = {currentUserId}"
                    );
                    // Cập nhật luôn vào ListView cho hiển thị
                    dgvAccountList.DataSource = DataProcess.ReadTable("SELECT MaKH, TenTaiKhoan, MatKhau, VaiTro, NgayTao FROM KHACHHANG");
                    MessageBox.Show("Cập nhật tài khoản thành công!");
                }
            }
        }

        private void lblDelete_Click(object sender, EventArgs e)
        {
            if (dgvAccountList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa!");
                return;
            }
            DataGridViewRow selectedRow = dgvAccountList.SelectedRows[0];
            string currentUserId = selectedRow.Cells["MaKH"].Value.ToString();
            DataProcess.UpdateData(
                $"DELETE FROM KHACHHANG WHERE MaKH = {currentUserId}"
            );
            dgvAccountList.DataSource = DataProcess.ReadTable("SELECT MaKH, TenTaiKhoan, MatKhau, VaiTro, NgayTao FROM KHACHHANG");
            MessageBox.Show("Xóa tài khoản thành công!");
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            string txt = tbSearch.Text.Trim();
            string sql = "SELECT MaKH, TenTaiKhoan, MatKhau, VaiTro, NgayTao FROM KHACHHANG " +
                 $"WHERE TenTaiKhoan LIKE '%{txt}%'";
            dgvAccountList.DataSource = DataProcess.ReadTable(sql);
        }
    }
}
