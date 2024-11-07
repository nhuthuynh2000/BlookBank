namespace BloodBankManagement.View
{
    partial class Test
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel3 = new Panel();
            label3 = new Label();
            splitContainer1 = new SplitContainer();
            panel4 = new Panel();
            txtgender = new ComboBox();
            label9 = new Label();
            btndelete = new Guna.UI2.WinForms.Guna2Button();
            txtid = new TextBox();
            btnedit = new Guna.UI2.WinForms.Guna2Button();
            label10 = new Label();
            btncreate = new Guna.UI2.WinForms.Guna2Button();
            txtname = new TextBox();
            txtgroup = new ComboBox();
            label11 = new Label();
            label15 = new Label();
            txtage = new TextBox();
            txtaddress = new TextBox();
            label12 = new Label();
            label14 = new Label();
            label13 = new Label();
            txtphone = new TextBox();
            splitContainer2 = new SplitContainer();
            guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            txtsearch = new TextBox();
            btnback = new Guna.UI2.WinForms.Guna2Button();
            guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            MaNguoiHien = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            Tuoi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            SoDienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            NhomMau = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1500, 61);
            panel3.TabIndex = 9;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Calibri", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(633, 6);
            label3.Name = "label3";
            label3.Size = new Size(239, 39);
            label3.TabIndex = 12;
            label3.Text = "Người Hiến Tặng";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 61);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel4);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1500, 707);
            splitContainer1.SplitterDistance = 500;
            splitContainer1.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.Controls.Add(txtgender);
            panel4.Controls.Add(label9);
            panel4.Controls.Add(btndelete);
            panel4.Controls.Add(txtid);
            panel4.Controls.Add(btnedit);
            panel4.Controls.Add(label10);
            panel4.Controls.Add(btncreate);
            panel4.Controls.Add(txtname);
            panel4.Controls.Add(txtgroup);
            panel4.Controls.Add(label11);
            panel4.Controls.Add(label15);
            panel4.Controls.Add(txtage);
            panel4.Controls.Add(txtaddress);
            panel4.Controls.Add(label12);
            panel4.Controls.Add(label14);
            panel4.Controls.Add(label13);
            panel4.Controls.Add(txtphone);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(497, 707);
            panel4.TabIndex = 29;
            // 
            // txtgender
            // 
            txtgender.Anchor = AnchorStyles.None;
            txtgender.Font = new Font("Calibri", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtgender.FormattingEnabled = true;
            txtgender.Items.AddRange(new object[] { "Nam", "Nữ" });
            txtgender.Location = new Point(194, 298);
            txtgender.Name = "txtgender";
            txtgender.Size = new Size(236, 32);
            txtgender.TabIndex = 81;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F);
            label9.Location = new Point(52, 192);
            label9.Name = "label9";
            label9.Size = new Size(136, 24);
            label9.TabIndex = 65;
            label9.Text = "Mã Người Hiến";
            // 
            // btndelete
            // 
            btndelete.Anchor = AnchorStyles.None;
            btndelete.AutoRoundedCorners = true;
            btndelete.BackColor = Color.Transparent;
            btndelete.BorderColor = SystemColors.ButtonShadow;
            btndelete.BorderRadius = 15;
            btndelete.BorderThickness = 1;
            btndelete.CustomizableEdges = customizableEdges1;
            btndelete.DisabledState.BorderColor = Color.DarkGray;
            btndelete.DisabledState.CustomBorderColor = Color.DarkGray;
            btndelete.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btndelete.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btndelete.FillColor = SystemColors.ButtonFace;
            btndelete.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btndelete.ForeColor = Color.Black;
            btndelete.Image = (Image)resources.GetObject("btndelete.Image");
            btndelete.Location = new Point(300, 478);
            btndelete.Name = "btndelete";
            btndelete.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btndelete.Size = new Size(110, 32);
            btndelete.TabIndex = 80;
            btndelete.Text = "Xóa";
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.None;
            txtid.Font = new Font("Calibri", 12F);
            txtid.Location = new Point(194, 184);
            txtid.Multiline = true;
            txtid.Name = "txtid";
            txtid.Size = new Size(236, 32);
            txtid.TabIndex = 66;
            // 
            // btnedit
            // 
            btnedit.Anchor = AnchorStyles.None;
            btnedit.AutoRoundedCorners = true;
            btnedit.BackColor = Color.Transparent;
            btnedit.BorderColor = SystemColors.ButtonShadow;
            btnedit.BorderRadius = 15;
            btnedit.BorderThickness = 1;
            btnedit.CustomizableEdges = customizableEdges3;
            btnedit.DisabledState.BorderColor = Color.DarkGray;
            btnedit.DisabledState.CustomBorderColor = Color.DarkGray;
            btnedit.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnedit.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnedit.FillColor = SystemColors.ButtonFace;
            btnedit.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnedit.ForeColor = Color.Black;
            btnedit.Image = (Image)resources.GetObject("btnedit.Image");
            btnedit.Location = new Point(184, 478);
            btnedit.Name = "btnedit";
            btnedit.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnedit.Size = new Size(110, 32);
            btnedit.TabIndex = 79;
            btnedit.Text = "Sửa";
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.None;
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F);
            label10.Location = new Point(52, 230);
            label10.Name = "label10";
            label10.Size = new Size(92, 24);
            label10.TabIndex = 67;
            label10.Text = "Họ Và Tên";
            // 
            // btncreate
            // 
            btncreate.Anchor = AnchorStyles.None;
            btncreate.AutoRoundedCorners = true;
            btncreate.BackColor = Color.Transparent;
            btncreate.BorderColor = SystemColors.ButtonShadow;
            btncreate.BorderRadius = 15;
            btncreate.BorderThickness = 1;
            btncreate.CustomizableEdges = customizableEdges5;
            btncreate.DisabledState.BorderColor = Color.DarkGray;
            btncreate.DisabledState.CustomBorderColor = Color.DarkGray;
            btncreate.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btncreate.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btncreate.FillColor = SystemColors.ButtonFace;
            btncreate.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btncreate.ForeColor = Color.Black;
            btncreate.Image = (Image)resources.GetObject("btncreate.Image");
            btncreate.Location = new Point(68, 478);
            btncreate.Name = "btncreate";
            btncreate.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btncreate.Size = new Size(110, 32);
            btncreate.TabIndex = 78;
            btncreate.Text = "Thêm";
            // 
            // txtname
            // 
            txtname.Anchor = AnchorStyles.None;
            txtname.Font = new Font("Calibri", 12F);
            txtname.Location = new Point(194, 222);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(236, 32);
            txtname.TabIndex = 68;
            // 
            // txtgroup
            // 
            txtgroup.Anchor = AnchorStyles.None;
            txtgroup.Font = new Font("Calibri", 12F);
            txtgroup.FormattingEnabled = true;
            txtgroup.Items.AddRange(new object[] { "A+", "O+", "B+", "AB+", "A-", "O-", "B-", "AB-" });
            txtgroup.Location = new Point(194, 412);
            txtgroup.Name = "txtgroup";
            txtgroup.Size = new Size(236, 32);
            txtgroup.TabIndex = 77;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F);
            label11.Location = new Point(52, 268);
            label11.Name = "label11";
            label11.Size = new Size(46, 24);
            label11.TabIndex = 69;
            label11.Text = "Tuổi";
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.None;
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 12F);
            label15.Location = new Point(52, 420);
            label15.Name = "label15";
            label15.Size = new Size(103, 24);
            label15.TabIndex = 76;
            label15.Text = "Nhóm máu";
            // 
            // txtage
            // 
            txtage.Anchor = AnchorStyles.None;
            txtage.Font = new Font("Calibri", 12F);
            txtage.Location = new Point(194, 260);
            txtage.Multiline = true;
            txtage.Name = "txtage";
            txtage.Size = new Size(236, 32);
            txtage.TabIndex = 70;
            // 
            // txtaddress
            // 
            txtaddress.Anchor = AnchorStyles.None;
            txtaddress.Font = new Font("Calibri", 12F);
            txtaddress.Location = new Point(194, 374);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(236, 32);
            txtaddress.TabIndex = 75;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.None;
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F);
            label12.Location = new Point(52, 306);
            label12.Name = "label12";
            label12.Size = new Size(87, 24);
            label12.TabIndex = 71;
            label12.Text = "Giới Tính";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.None;
            label14.AutoSize = true;
            label14.Font = new Font("Calibri", 12F);
            label14.Location = new Point(52, 382);
            label14.Name = "label14";
            label14.Size = new Size(69, 24);
            label14.TabIndex = 74;
            label14.Text = "Địa Chỉ";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.None;
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F);
            label13.Location = new Point(52, 344);
            label13.Name = "label13";
            label13.Size = new Size(125, 24);
            label13.TabIndex = 72;
            label13.Text = "Số Điện Thoại";
            // 
            // txtphone
            // 
            txtphone.Anchor = AnchorStyles.None;
            txtphone.Font = new Font("Calibri", 12F);
            txtphone.Location = new Point(194, 336);
            txtphone.Multiline = true;
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(236, 32);
            txtphone.TabIndex = 73;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(guna2Button4);
            splitContainer2.Panel1.Controls.Add(txtsearch);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnback);
            splitContainer2.Panel2.Controls.Add(guna2DataGridView1);
            splitContainer2.Size = new Size(996, 707);
            splitContainer2.SplitterDistance = 129;
            splitContainer2.TabIndex = 0;
            // 
            // guna2Button4
            // 
            guna2Button4.AutoRoundedCorners = true;
            guna2Button4.BackColor = Color.Transparent;
            guna2Button4.BorderColor = SystemColors.ButtonShadow;
            guna2Button4.BorderRadius = 15;
            guna2Button4.BorderThickness = 1;
            guna2Button4.CustomizableEdges = customizableEdges7;
            guna2Button4.DisabledState.BorderColor = Color.DarkGray;
            guna2Button4.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2Button4.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2Button4.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2Button4.FillColor = SystemColors.ButtonFace;
            guna2Button4.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            guna2Button4.ForeColor = Color.Black;
            guna2Button4.Image = (Image)resources.GetObject("guna2Button4.Image");
            guna2Button4.Location = new Point(859, 80);
            guna2Button4.Name = "guna2Button4";
            guna2Button4.ShadowDecoration.CustomizableEdges = customizableEdges8;
            guna2Button4.Size = new Size(78, 32);
            guna2Button4.TabIndex = 56;
            // 
            // txtsearch
            // 
            txtsearch.Font = new Font("Calibri", 12F);
            txtsearch.Location = new Point(587, 80);
            txtsearch.Multiline = true;
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(255, 32);
            txtsearch.TabIndex = 55;
            // 
            // btnback
            // 
            btnback.AutoRoundedCorners = true;
            btnback.BackColor = Color.Transparent;
            btnback.BorderColor = SystemColors.ButtonShadow;
            btnback.BorderRadius = 15;
            btnback.BorderThickness = 1;
            btnback.CustomizableEdges = customizableEdges9;
            btnback.DisabledState.BorderColor = Color.DarkGray;
            btnback.DisabledState.CustomBorderColor = Color.DarkGray;
            btnback.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnback.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnback.FillColor = SystemColors.ButtonFace;
            btnback.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnback.ForeColor = Color.Black;
            btnback.Image = (Image)resources.GetObject("btnback.Image");
            btnback.Location = new Point(859, 470);
            btnback.Name = "btnback";
            btnback.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnback.Size = new Size(78, 32);
            btnback.TabIndex = 57;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.IndianRed;
            dataGridViewCellStyle2.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            guna2DataGridView1.ColumnHeadersHeight = 30;
            guna2DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaNguoiHien, HoVaTen, Tuoi, GioiTinh, SoDienThoai, DiaChi, NhomMau });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            guna2DataGridView1.Dock = DockStyle.Right;
            guna2DataGridView1.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView1.Location = new Point(0, 0);
            guna2DataGridView1.Name = "guna2DataGridView1";
            guna2DataGridView1.RowHeadersVisible = false;
            guna2DataGridView1.RowHeadersWidth = 51;
            guna2DataGridView1.Size = new Size(996, 574);
            guna2DataGridView1.TabIndex = 32;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            guna2DataGridView1.ThemeStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.GridColor = Color.FromArgb(224, 224, 224);
            guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = Color.IndianRed;
            guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new Font("Calibri", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 30;
            guna2DataGridView1.ThemeStyle.ReadOnly = false;
            guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = Color.White;
            guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            guna2DataGridView1.ThemeStyle.RowsStyle.Font = new Font("Calibri", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            guna2DataGridView1.ThemeStyle.RowsStyle.Height = 29;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = Color.Coral;
            guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = SystemColors.ActiveCaption;
            // 
            // MaNguoiHien
            // 
            MaNguoiHien.DataPropertyName = "MaNguoiHien";
            MaNguoiHien.FillWeight = 116.605217F;
            MaNguoiHien.HeaderText = "Mã người hiến";
            MaNguoiHien.MinimumWidth = 6;
            MaNguoiHien.Name = "MaNguoiHien";
            // 
            // HoVaTen
            // 
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 101.705666F;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 6;
            HoVaTen.Name = "HoVaTen";
            // 
            // Tuoi
            // 
            Tuoi.DataPropertyName = "Tuoi";
            Tuoi.FillWeight = 74.86629F;
            Tuoi.HeaderText = "Tuổi";
            Tuoi.MinimumWidth = 6;
            Tuoi.Name = "Tuoi";
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.FillWeight = 101.705666F;
            GioiTinh.HeaderText = "Giới tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            // 
            // SoDienThoai
            // 
            SoDienThoai.DataPropertyName = "SoDienThoai";
            SoDienThoai.FillWeight = 101.705666F;
            SoDienThoai.HeaderText = "Số điện thoại";
            SoDienThoai.MinimumWidth = 6;
            SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.FillWeight = 101.705666F;
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            // 
            // NhomMau
            // 
            NhomMau.DataPropertyName = "NhomMau";
            NhomMau.FillWeight = 101.705666F;
            NhomMau.HeaderText = "Nhóm máu";
            NhomMau.MinimumWidth = 6;
            NhomMau.Name = "NhomMau";
            // 
            // Test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 768);
            Controls.Add(splitContainer1);
            Controls.Add(panel3);
            Name = "Test";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Test";
            Load += Test_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)guna2DataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label3;
        private SplitContainer splitContainer1;
        private Panel panel4;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private TextBox txtsearch;
        private Guna.UI2.WinForms.Guna2Button btnback;
        private SplitContainer splitContainer2;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn MaNguoiHien;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn Tuoi;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn SoDienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn NhomMau;
        private ComboBox txtgender;
        private Label label9;
        private Guna.UI2.WinForms.Guna2Button btndelete;
        private TextBox txtid;
        private Guna.UI2.WinForms.Guna2Button btnedit;
        private Label label10;
        private Guna.UI2.WinForms.Guna2Button btncreate;
        private TextBox txtname;
        private ComboBox txtgroup;
        private Label label11;
        private Label label15;
        private TextBox txtage;
        private TextBox txtaddress;
        private Label label12;
        private Label label14;
        private Label label13;
        private TextBox txtphone;
    }
}