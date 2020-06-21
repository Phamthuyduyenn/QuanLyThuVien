namespace QuanLyThuVien
{
    partial class GUIQuanLyMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUIQuanLyMuonTra));
            this.btXoa = new System.Windows.Forms.Button();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.cbDocGia = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSach = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btTraSach = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lvDanhSachPhieuMuon = new System.Windows.Forms.ListView();
            this.lvSachDaDuocMuon = new System.Windows.Forms.ListView();
            this.dtpNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btThemVaoGH = new System.Windows.Forms.Button();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.quảnLýTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mượnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.độcGiảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lvGioHang = new System.Windows.Forms.ListView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btChotDonHang = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.FlatAppearance.BorderSize = 0;
            this.btXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btXoa.Image = ((System.Drawing.Image)(resources.GetObject("btXoa.Image")));
            this.btXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btXoa.Location = new System.Drawing.Point(295, 214);
            this.btXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(88, 46);
            this.btXoa.TabIndex = 59;
            this.btXoa.Text = "Xóa";
            this.btXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btXoa.UseVisualStyleBackColor = false;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(112, 190);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(180, 21);
            this.dtpNgayTra.TabIndex = 57;
            this.dtpNgayTra.Value = new System.DateTime(2020, 3, 10, 22, 52, 39, 0);
            // 
            // cbDocGia
            // 
            this.cbDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDocGia.FormattingEnabled = true;
            this.cbDocGia.Location = new System.Drawing.Point(112, 109);
            this.cbDocGia.Margin = new System.Windows.Forms.Padding(2);
            this.cbDocGia.Name = "cbDocGia";
            this.cbDocGia.Size = new System.Drawing.Size(272, 23);
            this.cbDocGia.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lvSach);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Gold;
            this.groupBox1.Location = new System.Drawing.Point(4, 267);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(515, 149);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách sách";
            // 
            // lvSach
            // 
            this.lvSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSach.GridLines = true;
            this.lvSach.HideSelection = false;
            this.lvSach.Location = new System.Drawing.Point(4, 20);
            this.lvSach.Margin = new System.Windows.Forms.Padding(2);
            this.lvSach.Name = "lvSach";
            this.lvSach.Size = new System.Drawing.Size(503, 124);
            this.lvSach.TabIndex = 0;
            this.lvSach.UseCompatibleStateImageBehavior = false;
            this.lvSach.View = System.Windows.Forms.View.Details;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(15, 108);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 55;
            this.label5.Text = "Độc giả";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(15, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 54;
            this.label4.Text = "Ngày mượn";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(15, 190);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Ngày trả";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(15, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 52;
            this.label2.Text = "Tìm kiếm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btTraSach
            // 
            this.btTraSach.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTraSach.FlatAppearance.BorderSize = 0;
            this.btTraSach.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btTraSach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTraSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTraSach.Image = ((System.Drawing.Image)(resources.GetObject("btTraSach.Image")));
            this.btTraSach.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTraSach.Location = new System.Drawing.Point(203, 214);
            this.btTraSach.Margin = new System.Windows.Forms.Padding(2);
            this.btTraSach.Name = "btTraSach";
            this.btTraSach.Size = new System.Drawing.Size(88, 46);
            this.btTraSach.TabIndex = 51;
            this.btTraSach.Text = "Trả";
            this.btTraSach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btTraSach.UseVisualStyleBackColor = false;
            // 
            // listView1
            // 
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-374, -71);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(356, 114);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lvDanhSachPhieuMuon
            // 
            this.lvDanhSachPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDanhSachPhieuMuon.GridLines = true;
            this.lvDanhSachPhieuMuon.HideSelection = false;
            this.lvDanhSachPhieuMuon.Location = new System.Drawing.Point(4, 22);
            this.lvDanhSachPhieuMuon.Margin = new System.Windows.Forms.Padding(2);
            this.lvDanhSachPhieuMuon.Name = "lvDanhSachPhieuMuon";
            this.lvDanhSachPhieuMuon.Size = new System.Drawing.Size(246, 236);
            this.lvDanhSachPhieuMuon.TabIndex = 0;
            this.lvDanhSachPhieuMuon.UseCompatibleStateImageBehavior = false;
            this.lvDanhSachPhieuMuon.View = System.Windows.Forms.View.Details;
            // 
            // lvSachDaDuocMuon
            // 
            this.lvSachDaDuocMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvSachDaDuocMuon.GridLines = true;
            this.lvSachDaDuocMuon.HideSelection = false;
            this.lvSachDaDuocMuon.Location = new System.Drawing.Point(4, 20);
            this.lvSachDaDuocMuon.Margin = new System.Windows.Forms.Padding(2);
            this.lvSachDaDuocMuon.Name = "lvSachDaDuocMuon";
            this.lvSachDaDuocMuon.Size = new System.Drawing.Size(503, 84);
            this.lvSachDaDuocMuon.TabIndex = 0;
            this.lvSachDaDuocMuon.UseCompatibleStateImageBehavior = false;
            this.lvSachDaDuocMuon.View = System.Windows.Forms.View.Details;
            // 
            // dtpNgayMuon
            // 
            this.dtpNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayMuon.Location = new System.Drawing.Point(112, 164);
            this.dtpNgayMuon.Name = "dtpNgayMuon";
            this.dtpNgayMuon.Size = new System.Drawing.Size(180, 21);
            this.dtpNgayMuon.TabIndex = 58;
            this.dtpNgayMuon.Value = new System.DateTime(2020, 3, 10, 22, 52, 39, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.lvSachDaDuocMuon);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Gold;
            this.groupBox3.Location = new System.Drawing.Point(4, 421);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(515, 111);
            this.groupBox3.TabIndex = 49;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Từng Phiếu Mượn";
            // 
            // btThoat
            // 
            this.btThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThoat.FlatAppearance.BorderSize = 0;
            this.btThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThoat.Image = ((System.Drawing.Image)(resources.GetObject("btThoat.Image")));
            this.btThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThoat.Location = new System.Drawing.Point(295, 164);
            this.btThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(88, 46);
            this.btThoat.TabIndex = 48;
            this.btThoat.Text = "Thoát";
            this.btThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThoat.UseVisualStyleBackColor = false;
            // 
            // btThemVaoGH
            // 
            this.btThemVaoGH.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btThemVaoGH.FlatAppearance.BorderSize = 0;
            this.btThemVaoGH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btThemVaoGH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btThemVaoGH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btThemVaoGH.Image = ((System.Drawing.Image)(resources.GetObject("btThemVaoGH.Image")));
            this.btThemVaoGH.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btThemVaoGH.Location = new System.Drawing.Point(19, 214);
            this.btThemVaoGH.Margin = new System.Windows.Forms.Padding(2);
            this.btThemVaoGH.Name = "btThemVaoGH";
            this.btThemVaoGH.Size = new System.Drawing.Size(88, 46);
            this.btThemVaoGH.TabIndex = 46;
            this.btThemVaoGH.Text = "Thêm";
            this.btThemVaoGH.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btThemVaoGH.UseVisualStyleBackColor = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(109, 37);
            this.toolStripMenuItem1.Text = "Quản lý sách";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.Controls.Add(this.listView1);
            this.groupBox4.Controls.Add(this.lvDanhSachPhieuMuon);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Gold;
            this.groupBox4.Location = new System.Drawing.Point(524, 267);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(254, 265);
            this.groupBox4.TabIndex = 50;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Danh sách phiếu mượn";
            // 
            // quảnLýTrảToolStripMenuItem
            // 
            this.quảnLýTrảToolStripMenuItem.Enabled = false;
            this.quảnLýTrảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quảnLýTrảToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.quảnLýTrảToolStripMenuItem.Name = "quảnLýTrảToolStripMenuItem";
            this.quảnLýTrảToolStripMenuItem.Size = new System.Drawing.Size(26, 37);
            this.quảnLýTrảToolStripMenuItem.Text = "|";
            // 
            // mượnToolStripMenuItem
            // 
            this.mượnToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mượnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.mượnToolStripMenuItem.Name = "mượnToolStripMenuItem";
            this.mượnToolStripMenuItem.Size = new System.Drawing.Size(128, 37);
            this.mượnToolStripMenuItem.Text = "Quản lý độc giả";
            // 
            // sáchToolStripMenuItem
            // 
            this.sáchToolStripMenuItem.Enabled = false;
            this.sáchToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sáchToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sáchToolStripMenuItem.Name = "sáchToolStripMenuItem";
            this.sáchToolStripMenuItem.Size = new System.Drawing.Size(26, 37);
            this.sáchToolStripMenuItem.Text = "|";
            // 
            // độcGiảToolStripMenuItem
            // 
            this.độcGiảToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.độcGiảToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.độcGiảToolStripMenuItem.Name = "độcGiảToolStripMenuItem";
            this.độcGiảToolStripMenuItem.Size = new System.Drawing.Size(146, 37);
            this.độcGiảToolStripMenuItem.Text = "Quản lý nhân viên";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.độcGiảToolStripMenuItem,
            this.sáchToolStripMenuItem,
            this.mượnToolStripMenuItem,
            this.quảnLýTrảToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(783, 41);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(65, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 26);
            this.label1.TabIndex = 44;
            this.label1.Text = "QUẢN LÝ MƯỢN - TRẢ";
            // 
            // lvGioHang
            // 
            this.lvGioHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvGioHang.GridLines = true;
            this.lvGioHang.HideSelection = false;
            this.lvGioHang.Location = new System.Drawing.Point(4, 22);
            this.lvGioHang.Margin = new System.Windows.Forms.Padding(2);
            this.lvGioHang.Name = "lvGioHang";
            this.lvGioHang.Size = new System.Drawing.Size(374, 194);
            this.lvGioHang.TabIndex = 0;
            this.lvGioHang.UseCompatibleStateImageBehavior = false;
            this.lvGioHang.View = System.Windows.Forms.View.Details;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvGioHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gold;
            this.groupBox2.Location = new System.Drawing.Point(397, 43);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(382, 220);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Giỏ hàng (Tạm thời)";
            // 
            // btChotDonHang
            // 
            this.btChotDonHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btChotDonHang.FlatAppearance.BorderSize = 0;
            this.btChotDonHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btChotDonHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btChotDonHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChotDonHang.Image = ((System.Drawing.Image)(resources.GetObject("btChotDonHang.Image")));
            this.btChotDonHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btChotDonHang.Location = new System.Drawing.Point(111, 214);
            this.btChotDonHang.Margin = new System.Windows.Forms.Padding(2);
            this.btChotDonHang.Name = "btChotDonHang";
            this.btChotDonHang.Size = new System.Drawing.Size(88, 46);
            this.btChotDonHang.TabIndex = 47;
            this.btChotDonHang.Text = "Chốt";
            this.btChotDonHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btChotDonHang.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(112, 134);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(272, 26);
            this.txtTimKiem.TabIndex = 41;
            // 
            // GUIQuanLyMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 532);
            this.Controls.Add(this.btXoa);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.cbDocGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btTraSach);
            this.Controls.Add(this.dtpNgayMuon);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btThoat);
            this.Controls.Add(this.btThemVaoGH);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btChotDonHang);
            this.Controls.Add(this.txtTimKiem);
            this.Name = "GUIQuanLyMuonTra";
            this.Text = "GUIQuanLyMuonTra";
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btXoa;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.ComboBox cbDocGia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTraSach;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView lvDanhSachPhieuMuon;
        private System.Windows.Forms.ListView lvSachDaDuocMuon;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btThemVaoGH;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ToolStripMenuItem quảnLýTrảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mượnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sáchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem độcGiảToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lvGioHang;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btChotDonHang;
        private System.Windows.Forms.TextBox txtTimKiem;
    }
}