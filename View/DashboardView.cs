using BloodBankManagement.Controller;
using BloodBankManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagement.View
{
    public partial class DashboardView : Form, IView
    {
        private DonorController donorController;
        private EmployeeController employeeController;
        private BloodTransferController bloodTransferController;
        private BloodController bloodController;
        private BindingList<DonorModel> donorList;
        private BindingList<BloodTransferModel> bloodTransferList;
        private BindingList<EmployeeModel> employeeList;
        private BindingList<BloodModel> bloodList;

        public DashboardView()
        {
            InitializeComponent();
            donorController = new DonorController();
            bloodTransferController = new BloodTransferController();
            employeeController = new EmployeeController();
            bloodController = new BloodController();
            donorList = new BindingList<DonorModel>();
            bloodTransferList = new BindingList<BloodTransferModel>();
            employeeList = new BindingList<EmployeeModel>();
            bloodList = new BindingList<BloodModel>();
            LoadDatas();
        }

        public void GetDataFromText()
        {
            throw new NotImplementedException();
        }

        public void SetDataToText()
        {
            throw new NotImplementedException();
        }

        private void DashboardView_Load(object sender, EventArgs e)
        {
            UpdateCounts();
        }

        private void LoadDatas()
        {
            donorController.Load();
            donorList = new BindingList<DonorModel>(donorController.Items.Cast<DonorModel>().ToList());

            bloodTransferController.Load();
            bloodTransferList = new BindingList<BloodTransferModel>(bloodTransferController.Items.Cast<BloodTransferModel>().ToList());

            employeeController.Load();
            employeeList = new BindingList<EmployeeModel>(employeeController.Items.Cast<EmployeeModel>().ToList());

            bloodController.Load();
            bloodList = new BindingList<BloodModel>(bloodController.Items.Cast<BloodModel>().ToList());
        }

        private void UpdateCounts()
        {
            int totalDonors = donorList.Count;
            donorlbl.Text = totalDonors.ToString();

            int totalBloodTransfers = bloodTransferList.Count;
            bloodtransferlbl.Text = totalBloodTransfers.ToString();

            int totalEmployees = employeeList.Count;
            employeelbl.Text = totalEmployees.ToString();

            int totalBloods = bloodList.Count;
            total.Text = totalBloods.ToString();

            UpdateBloodTypeCounts();
        }

        private void UpdateBloodTypeCounts()
        {
            if (!bloodController.Load())
            {
                Console.WriteLine("Không thể tải dữ liệu nhóm máu.");
                return;
            }

            var bloodItems = bloodController.Items.OfType<BloodModel>().ToList();

            int oPlusQuantity = bloodItems.FirstOrDefault(b => b.NhomMau == "O+")?.SoLuongMau ?? 0;
            int oMinusQuantity = bloodItems.FirstOrDefault(b => b.NhomMau == "O-")?.SoLuongMau ?? 0;
            int abPlusQuantity = bloodItems.FirstOrDefault(b => b.NhomMau == "AB+")?.SoLuongMau ?? 0;
            int abMinusQuantity = bloodItems.FirstOrDefault(b => b.NhomMau == "AB-")?.SoLuongMau ?? 0;

            int totalBloodQuantity = bloodItems.Sum(b => b.SoLuongMau);

            double oPlusPercentage = totalBloodQuantity > 0 ? (double)oPlusQuantity / totalBloodQuantity * 100 : 0;
            double oMinusPercentage = totalBloodQuantity > 0 ? (double)oMinusQuantity / totalBloodQuantity * 100 : 0;
            double abPlusPercentage = totalBloodQuantity > 0 ? (double)abPlusQuantity / totalBloodQuantity * 100 : 0;
            double abMinusPercentage = totalBloodQuantity > 0 ? (double)abMinusQuantity / totalBloodQuantity * 100 : 0;

            OPlusProgress.Value = Math.Min((int)oPlusPercentage, 100);
            OMinusProgres.Value = Math.Min((int)oMinusPercentage, 100);
            ABPlusProgress.Value = Math.Min((int)abPlusPercentage, 100);
            ABMinusProgress.Value = Math.Min((int)abMinusPercentage, 100);

            OPlusNumlbl.Text = oPlusQuantity.ToString();
            Ominus.Text = oMinusQuantity.ToString();
            ABPlusNumlbl.Text = abPlusQuantity.ToString();
            ABminus.Text = abMinusQuantity.ToString();
        }

        private void OPlusNumlbl_Click(object sender, EventArgs e)
        {
            // 
        }

        private void Ominus_Click(object sender, EventArgs e)
        {
            // 
        }

        private void OPlusProgress_ValueChanged(object sender, EventArgs e)
        {
            // 
        }
    }
}