using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BloodBankManagement.Model;
using BloodBankManagement.Controller;

using System.Data.SqlClient;
using System.Xml.Linq;

namespace BloodBankManagement.View
{
    public partial class DonorView : Form, IView
    {
        private DonorController controller;
        private DonorModel donor;
        private BindingList<DonorModel> donorList;
        public DonorView()
        {
            InitializeComponent();
            controller = new DonorController();
            donor = new DonorModel();
            donorList = new BindingList<DonorModel>();

            this.Load += new EventHandler(DonorView_Load);


        }


        private void DonorView_Load(object sender, EventArgs e)
        {
            LoadDonors();
            ClearForm();
        }

        public void SetDataToText()
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                donor = new DonorModel
                {
                    MaNguoiHien = Convert.ToInt32(selectedRow.Cells["MaNguoiHien"].Value),
                    HoVaTen = selectedRow.Cells["HoVaTen"].Value.ToString(),
                    Tuoi = Convert.ToInt32(selectedRow.Cells["Tuoi"].Value),
                    GioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString(),
                    SoDienThoai = selectedRow.Cells["SoDienThoai"].Value.ToString(),
                    DiaChi = selectedRow.Cells["DiaChi"].Value.ToString(),
                    NhomMau = selectedRow.Cells["NhomMau"].Value.ToString()
                };


                txtid.Text = donor.MaNguoiHien.ToString();
                txtname.Text = donor.HoVaTen;
                txtage.Text = donor.Tuoi.ToString();
                txtgender.SelectedItem = donor.GioiTinh;
                txtphone.Text = donor.SoDienThoai;
                txtaddress.Text = donor.DiaChi;
                txtgroup.SelectedItem = donor.NhomMau;
            }
        }

        public void GetDataFromText()
        {
            donor.MaNguoiHien = int.Parse(txtid.Text.Trim());

            donor.HoVaTen = txtname.Text.Trim();
            donor.Tuoi = int.Parse(txtage.Text.Trim());
            donor.GioiTinh = txtgender.Text.Trim();
            donor.SoDienThoai = txtphone.Text.Trim();
            donor.DiaChi = txtaddress.Text.Trim();
            donor.NhomMau = txtgroup.Text.Trim();
        }
        private void LoadDonors()
        {
            try
            {
                if (controller.Load())
                {
                    var DonorData = controller.Items.Cast<DonorModel>().Select(donor => new
                    {
                        MaNguoiHien = donor.MaNguoiHien,
                        HoVaTen = donor.HoVaTen,
                        Tuoi = donor.Tuoi,
                        GioiTinh = donor.GioiTinh,
                        SoDienThoai = donor.SoDienThoai,
                        DiaChi = donor.DiaChi,
                        NhomMau = donor.NhomMau
                    }).ToList();

                    guna2DataGridView1.DataSource = DonorData;

                    guna2DataGridView1.Columns["MaNguoiHien"].HeaderText = "Mã Người Hiến";
                    guna2DataGridView1.Columns["HoVaTen"].HeaderText = "Họ Và Tên";
                    guna2DataGridView1.Columns["Tuoi"].HeaderText = "Tuổi";
                    guna2DataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
                    guna2DataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện thoại";
                    guna2DataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    guna2DataGridView1.Columns["NhomMau"].HeaderText = "Nhóm Máu";
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



        public void SearchDonorById(string id)
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
            donorList.Clear();

            foreach (var donor in controller.Items.Cast<DonorModel>())
            {
                donorList.Add(donor);
            }

            guna2DataGridView1.DataSource = donorList;
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {

        }




        private void ClearForm()
        {
            txtid.Text = string.Empty;
            txtname.Text = string.Empty;
            txtage.Text = string.Empty;
            txtgender.SelectedIndex = -1;
            txtgender.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtgroup.SelectedIndex = -1;
            txtgroup.Text = string.Empty;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText();
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                string id = txtsearch.Text;
                SearchDonorById(id);
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            LoadDonors();
        }

        private void btndelete_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (donor.IsValidate())
            {
                try
                {

                    if (controller.Delete(donor))
                    {
                        MessageBox.Show("Người hiến đã được xóa thành công!");
                        ClearForm();
                        LoadDonors();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa người hiến.");
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

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            GetDataFromText();

            if (donor.IsValidate())
            {
                try
                {
                    if (controller.Update(donor))
                    {
                        MessageBox.Show("Người hiến đã được cập nhật thành công!");
                        ClearForm();
                        LoadDonors();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật người hiến.");
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

            if (donor.IsValidate())
            {
                try
                {

                    if (controller.Create(donor))
                    {
                        MessageBox.Show("Người hiến đã được thêm thành công!");
                        ClearForm();
                        LoadDonors();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm người hiến.");
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

        private void guna2DataGridView1_SelectionChanged_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                SetDataToText();
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}

