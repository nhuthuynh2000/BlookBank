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
using System.Xml.Linq;



namespace BloodBankManagement.View
{

    public partial class PatientView : Form, IView
    {
        private PatientController controller;
        private PatientModel patient;
        private BindingList<PatientModel> patientList;
        public PatientView()
        {
            InitializeComponent();
            controller = new PatientController();
            patient = new PatientModel();
            patientList = new BindingList<PatientModel>();

            this.Load += new EventHandler(PatientView_Load);

        }

        public void GetDataFromText()
        {

            patient.MaBenhNhan = int.Parse(txtid.Text.Trim());
            patient.HoVaTen = txtname.Text.Trim();
            patient.Tuoi = int.Parse(txtage.Text.Trim());
            patient.GioiTinh = txtgender.Text.Trim();
            patient.SoDienThoai = txtphone.Text.Trim();
            patient.NhomMau = txtgroup.Text.Trim();
            patient.DiaChi = txtaddress.Text.Trim();
            patient.BenhVien = txthopital.Text.Trim();
        }

        public void SetDataToText()
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                patient = new PatientModel
                {
                    MaBenhNhan = Convert.ToInt32(selectedRow.Cells["MaBenhNhan"].Value),
                    HoVaTen = selectedRow.Cells["HoVaTen"].Value.ToString(),
                    Tuoi = Convert.ToInt32(selectedRow.Cells["Tuoi"].Value),
                    GioiTinh = selectedRow.Cells["GioiTinh"].Value.ToString(),
                    SoDienThoai = selectedRow.Cells["SoDienThoai"].Value.ToString(),
                    NhomMau = selectedRow.Cells["NhomMau"].Value.ToString(),
                    DiaChi = selectedRow.Cells["DiaChi"].Value.ToString(),
                    BenhVien = selectedRow.Cells["BenhVien"].Value.ToString()
                };


                txtid.Text = patient.MaBenhNhan.ToString();
                txtname.Text = patient.HoVaTen;
                txtage.Text = patient.Tuoi.ToString();
                txtgender.SelectedItem = patient.GioiTinh;
                txtphone.Text = patient.SoDienThoai;
                txtgroup.SelectedItem = patient.NhomMau;
                txtaddress.Text = patient.DiaChi;
                txthopital.Text = patient.BenhVien;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientView_Load(object sender, EventArgs e)
        {
            LoadPatients();
            ClearForm();
        }

        private void LoadPatients()
        {
            try
            {
                if (controller.Load())
                {
                    var PatientData = controller.Items.Cast<PatientModel>().Select(patient => new
                    {
                        MaBenhNhan = patient.MaBenhNhan,
                        HoVaTen = patient.HoVaTen,
                        Tuoi = patient.Tuoi,
                        GioiTinh = patient.GioiTinh,
                        SoDienThoai = patient.SoDienThoai,
                        NhomMau = patient.NhomMau,
                        DiaChi = patient.DiaChi,
                        BenhVien = patient.BenhVien
                    }).ToList();

                    guna2DataGridView1.DataSource = PatientData;

                    guna2DataGridView1.Columns["MaBenhNhan"].HeaderText = "Mã Bệnh Nhân";
                    guna2DataGridView1.Columns["HoVaTen"].HeaderText = "Họ Và Tên";
                    guna2DataGridView1.Columns["Tuoi"].HeaderText = "Tuổi";
                    guna2DataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
                    guna2DataGridView1.Columns["SoDienThoai"].HeaderText = "Số Điện thoại";
                    guna2DataGridView1.Columns["NhomMau"].HeaderText = "Nhóm Máu";
                    guna2DataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
                    guna2DataGridView1.Columns["BenhVien"].HeaderText = "Bệnh Viện";
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
        public void SearchPatientById(string id)
        {

            if (controller.Load(id))
            {
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy bệnh nhân với ID đã cho.");
            }
        }

        public void UpdateDataGridView()
        {
            patientList.Clear();

            foreach (var patient in controller.Items.Cast<PatientModel>())
            {
                patientList.Add(patient);
            }

            guna2DataGridView1.DataSource = patientList;
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
            txthopital.Text = string.Empty;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint_3(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                string id = txtsearch.Text;
                SearchPatientById(id);
            }
        }

        private void btnback_Click_1(object sender, EventArgs e)
        {
            LoadPatients();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (patient.IsValidate())
            {
                try
                {

                    if (controller.Delete(patient))
                    {
                        MessageBox.Show("Bệnh nhân đã được xóa thành công!");
                        ClearForm();
                        LoadPatients();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi xóa bệnh nhân.");
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

        private void btnedit_Click(object sender, EventArgs e)
        {
            GetDataFromText();

            if (patient.IsValidate())
            {
                try
                {
                    if (controller.Update(patient))
                    {
                        MessageBox.Show("Bệnh nhân đã được cập nhật thành công!");
                        ClearForm();
                        LoadPatients();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi cập nhật bệnh nhân.");
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

            if (patient.IsValidate())
            {
                try
                {
                    if (controller.Create(patient))
                    {
                        MessageBox.Show("Bệnh nhân đã được thêm thành công!");
                        ClearForm();
                        LoadPatients();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra khi thêm bệnh nhân.");
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

        private void splitContainer1_Panel2_Paint_4(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint_2(object sender, PaintEventArgs e)
        {

        }
    }
}
