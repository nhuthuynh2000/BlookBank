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
    public partial class BloodStockView : Form, IView
    {
        private BloodStockController controller;
        private BloodModel bloodstock;
        private BindingList<BloodModel> bloodstockList;

        public BloodStockView()
        {

            InitializeComponent();
            controller = new BloodStockController();
            bloodstock = new BloodModel();
            bloodstockList = new BindingList<BloodModel>();

            this.Load += new EventHandler(BloodStockView_Load);
        }

        public void GetDataFromText()
        {

            bloodstock.NhomMau = txtgroup.Text.Trim();
            bloodstock.SoLuongMau = int.Parse(txtstock.Text.Trim());

        }

        public void SetDataToText()
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];

                bloodstock = new BloodModel
                {
                    NhomMau = selectedRow.Cells["NhomMau"].Value.ToString(),
                    SoLuongMau = Convert.ToInt32(selectedRow.Cells["SoLuongMau"].Value)
                };

                txtgroup.SelectedItem = bloodstock.NhomMau;
                txtstock.Text = bloodstock.SoLuongMau.ToString();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                SetDataToText();
            }
        }

        private void BloodStockView_Load(object sender, EventArgs e)
        {
            LoadBloodStocks();
        }
        private void LoadBloodStocks()
        {
            try
            {
                if (controller.Load())
                {
                    var BloodStockData = controller.Items.Cast<BloodModel>().Select(bloodstock => new
                    {


                        NhomMau = bloodstock.NhomMau,
                        SoLuongMau = bloodstock.SoLuongMau
                    }).ToList();

                    guna2DataGridView1.DataSource = BloodStockData;


                    guna2DataGridView1.Columns["NhomMau"].HeaderText = "Nhóm Máu";
                    guna2DataGridView1.Columns["SoLuongMau"].HeaderText = "Số Lượng Máu";
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

        private void guna2DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                SetDataToText();
            }
        }

        public void SearchBloodStockById(string id)
        {

            if (controller.Load(id))
            {
                UpdateDataGridView();
            }
            else
            {
                MessageBox.Show("Không tìm thấy nhóm máu với ID đã cho.");
            }
        }

        public void UpdateDataGridView()
        {
            bloodstockList.Clear();

            foreach (var bloodstock in controller.Items.Cast<BloodModel>())
            {
                bloodstockList.Add(bloodstock);
            }

            guna2DataGridView1.DataSource = bloodstockList;
        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            LoadBloodStocks();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                string id = txtsearch.Text;
                SearchBloodStockById(id);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncreate_Click(object sender, EventArgs e)
        {

        }

        private void btnedit_Click(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {

        }
    }
}
