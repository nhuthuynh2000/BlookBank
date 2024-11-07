namespace BloodBankManagement.View
{
    partial class BloodTransferView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            label3 = new Label();
            panel1 = new Panel();
            txtgroup = new TextBox();
            cboPatientID = new Guna.UI2.WinForms.Guna2ComboBox();
            availble = new Label();
            btntransfer = new Guna.UI2.WinForms.Guna2Button();
            Availableornot = new Label();
            txtname = new TextBox();
            label10 = new Label();
            label9 = new Label();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(0, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(1517, 74);
            panel3.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(663, 17);
            label3.Name = "label3";
            label3.Size = new Size(252, 39);
            label3.TabIndex = 12;
            label3.Text = "Chuyển Giao Máu";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(txtgroup);
            panel1.Controls.Add(cboPatientID);
            panel1.Controls.Add(availble);
            panel1.Controls.Add(btntransfer);
            panel1.Controls.Add(Availableornot);
            panel1.Controls.Add(txtname);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(37, 136);
            panel1.Name = "panel1";
            panel1.Size = new Size(1431, 429);
            panel1.TabIndex = 36;
            // 
            // txtgroup
            // 
            txtgroup.Font = new Font("Calibri", 12F);
            txtgroup.Location = new Point(720, 168);
            txtgroup.Multiline = true;
            txtgroup.Name = "txtgroup";
            txtgroup.Size = new Size(236, 32);
            txtgroup.TabIndex = 30;
            // 
            // cboPatientID
            // 
            cboPatientID.BackColor = Color.Transparent;
            cboPatientID.CustomizableEdges = customizableEdges1;
            cboPatientID.DrawMode = DrawMode.OwnerDrawFixed;
            cboPatientID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPatientID.FocusedColor = Color.FromArgb(94, 148, 255);
            cboPatientID.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cboPatientID.Font = new Font("Segoe UI", 10F);
            cboPatientID.ForeColor = Color.FromArgb(68, 88, 112);
            cboPatientID.ItemHeight = 30;
            cboPatientID.Location = new Point(720, 86);
            cboPatientID.Name = "cboPatientID";
            cboPatientID.ShadowDecoration.CustomizableEdges = customizableEdges2;
            cboPatientID.Size = new Size(236, 36);
            cboPatientID.TabIndex = 29;
            // 
            // availble
            // 
            availble.AutoSize = true;
            availble.BackColor = Color.Transparent;
            availble.Font = new Font("Calibri", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            availble.ForeColor = Color.IndianRed;
            availble.Location = new Point(674, 231);
            availble.Name = "availble";
            availble.Size = new Size(175, 28);
            availble.TabIndex = 28;
            availble.Text = "Có sẵn hay không";
            availble.Visible = false;
            // 
            // btntransfer
            // 
            btntransfer.AutoRoundedCorners = true;
            btntransfer.BackColor = Color.Transparent;
            btntransfer.BorderColor = SystemColors.ButtonShadow;
            btntransfer.BorderRadius = 15;
            btntransfer.BorderThickness = 1;
            btntransfer.CustomizableEdges = customizableEdges3;
            btntransfer.DisabledState.BorderColor = Color.DarkGray;
            btntransfer.DisabledState.CustomBorderColor = Color.DarkGray;
            btntransfer.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btntransfer.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btntransfer.FillColor = SystemColors.ButtonFace;
            btntransfer.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btntransfer.ForeColor = Color.Black;
            btntransfer.Location = new Point(674, 272);
            btntransfer.Name = "btntransfer";
            btntransfer.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btntransfer.Size = new Size(186, 32);
            btntransfer.TabIndex = 27;
            btntransfer.Text = "Chuyển giao";
            btntransfer.Click += btntransfer_Click;
            // 
            // Availableornot
            // 
            Availableornot.AutoSize = true;
            Availableornot.Font = new Font("Calibri", 12F);
            Availableornot.Location = new Point(507, 176);
            Availableornot.Name = "Availableornot";
            Availableornot.Size = new Size(104, 24);
            Availableornot.TabIndex = 10;
            Availableornot.Text = "Nhóm Máu";
            // 
            // txtname
            // 
            txtname.Font = new Font("Calibri", 12F);
            txtname.Location = new Point(720, 128);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(236, 32);
            txtname.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(507, 136);
            label10.Name = "label10";
            label10.Size = new Size(198, 24);
            label10.TabIndex = 2;
            label10.Text = "Họ Và Tên Người Nhận";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(507, 98);
            label9.Name = "label9";
            label9.Size = new Size(135, 24);
            label9.TabIndex = 0;
            label9.Text = "Mã Bệnh Nhân";
            // 
            // BloodTransferView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 644);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "BloodTransferView";
            Text = "ChuyenGiaoMau";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel3;
        private Label label3;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btntransfer;
        private Label Availableornot;
        private TextBox txtname;
        private Label label10;
        private Label label9;
        private Label availble;
        private Guna.UI2.WinForms.Guna2ComboBox cboPatientID;
        private TextBox txtgroup;
    }
}