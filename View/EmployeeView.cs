using BloodBankManagement.Controller;
using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BloodBankManagement.View
{
    public partial class EmployeeView : Form, IView
    {
        private EmployeeController controller;
        private EmployeeModel employee;
        private BindingList<EmployeeModel> employeeList;

        public EmployeeView()
        {
            InitializeComponent();
            controller = new EmployeeController();
            employee = new EmployeeModel();
            employeeList = new BindingList<EmployeeModel>();
            this.Load += new EventHandler(Employee_Load);
        }

        public void GetDataFromText()
        {
            employee.MaNhanVien = int.Parse(txtid.Text.Trim());

            employee.TenDangNhap = txtuser.Text.Trim();
            employee.MatKhau = txtpassword.Text.Trim();
            employee.Role = txtrole.Text.Trim();
        }

        public void SetDataToText()
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                employee = new EmployeeModel
                {
                    MaNhanVien = Convert.ToInt32(selectedRow.Cells["MaNhanVien"].Value),
                    TenDangNhap = selectedRow.Cells["TenDangNhap"].Value.ToString(),
                    MatKhau = selectedRow.Cells["MatKhau"].Value.ToString(),
                    Role = selectedRow.Cells["Role"].Value.ToString()
                };

                txtid.Text = employee.MaNhanVien.ToString();
                txtuser.Text = employee.TenDangNhap;
                txtpassword.Text = employee.MatKhau;
                txtrole.Text = employee.Role;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            ClearForm();
        }
        public void SearchEmployeeById(string id)
        {

            if (controller.Load(id))
            {
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy người hiến với ID đã cho.");
            }
        }
        public void UpdateDataGridView()
        {
            employeeList.Clear();

            foreach (var employee in controller.Items.Cast<EmployeeModel>())
            {
                employeeList.Add(employee);
            }

            guna2DataGridView1.DataSource = employeeList;
        }

        private void LoadEmployees()
        {
            try
            {
                if (controller.Load())
                {
                    var employeeData = controller.Items.Cast<EmployeeModel>().Select(employee => new
                    {
                        MaNhanVien = employee.MaNhanVien,
                        TenDangNhap = employee.TenDangNhap,
                        MatKhau = employee.MatKhau,
                        Role = employee.Role

                    }).ToList();

                    guna2DataGridView1.DataSource = employeeData;

                    guna2DataGridView1.Columns["MaNhanVien"].HeaderText = "Mã Nhân Viên";
                    guna2DataGridView1.Columns["TenDangNhap"].HeaderText = "Tên Đăng Nhập";
                    guna2DataGridView1.Columns["MatKhau"].HeaderText = "Mật khẩu";
                    guna2DataGridView1.Columns["Role"].HeaderText = "Vai trò";
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu để hiển thị.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi tải dữ liệu: {ex.Message}");
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                string id = txtsearch.Text;
                SearchEmployeeById(id);
            }
        }



        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText();
            }
        }

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                SetDataToText();
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (employee.IsValidate())
            {
                try
                {
                    if (controller.Update(employee))
                    {
                        MessageBox.Show("Nhân viên đã được cập nhật thành công!");
                        ClearForm();
                        LoadEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật nhân viên.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
            ClearForm();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (employee.IsValidate())
            {
                try
                {

                    if (controller.Delete(employee))
                    {
                        MessageBox.Show("Nhân viên đã được xóa thành công!");
                        ClearForm();
                        LoadEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa nhân viên.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
            ClearForm();
        }

        private void btncreate_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (employee.IsValidate())
            {
                try
                {

                    if (controller.Create(employee))
                    {
                        MessageBox.Show("Nhân viên đã được thêm thành công!");
                        ClearForm();
                        LoadEmployees();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm nhân viên.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Có lỗi xảy ra: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không hợp lệ. Vui lòng kiểm tra lại.");
            }
            ClearForm();
        }
        private void ClearForm()
        {
            txtid.Text = string.Empty;
            txtuser.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtrole.SelectedIndex = -1;
            txtrole.Text = string.Empty;

        }
    }
}
