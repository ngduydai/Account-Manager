namespace Quản_Lý_Tài_Khoản
{
	partial class AccountManage
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountManage));
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFolderApp = new System.Windows.Forms.ToolStripMenuItem();
			this.toolMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.resetSecurity = new System.Windows.Forms.ToolStripMenuItem();
			this.exportData = new System.Windows.Forms.ToolStripMenuItem();
			this.importData = new System.Windows.Forms.ToolStripMenuItem();
			this.contactMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facebook = new System.Windows.Forms.ToolStripMenuItem();
			this.youtube = new System.Windows.Forms.ToolStripMenuItem();
			this.zalo = new System.Windows.Forms.ToolStripMenuItem();
			this.discord = new System.Windows.Forms.ToolStripMenuItem();
			this.phoneNumber = new System.Windows.Forms.ToolStripMenuItem();
			this.userDiscord = new System.Windows.Forms.ToolStripMenuItem();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.data = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtAcc = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.hidePass = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNote = new System.Windows.Forms.TextBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnLoad = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.rbtAcc = new System.Windows.Forms.RadioButton();
			this.rbtName = new System.Windows.Forms.RadioButton();
			this.rbtNote = new System.Windows.Forms.RadioButton();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.tabPage5 = new System.Windows.Forms.TabPage();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtCurrentPass = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtNewPass = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtNewPass2 = new System.Windows.Forms.TextBox();
			this.hideChangePass = new System.Windows.Forms.CheckBox();
			this.btnChangePass = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.menuStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPage5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.fileMenuItem, this.toolMenuItem, this.contactMenuItem });
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(984, 24);
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip";
			// 
			// fileMenuItem
			// 
			this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.openFolderApp });
			this.fileMenuItem.Name = "fileMenuItem";
			this.fileMenuItem.Size = new System.Drawing.Size(38, 20);
			this.fileMenuItem.Text = "Tệp";
			// 
			// openFolderApp
			// 
			this.openFolderApp.Name = "openFolderApp";
			this.openFolderApp.Size = new System.Drawing.Size(195, 22);
			this.openFolderApp.Text = "Mở thư mục ứng dụng";
			this.openFolderApp.Click += new System.EventHandler(this.openFolderApp_Click);
			// 
			// toolMenuItem
			// 
			this.toolMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.exportData, this.importData, this.resetSecurity });
			this.toolMenuItem.Name = "toolMenuItem";
			this.toolMenuItem.Size = new System.Drawing.Size(64, 20);
			this.toolMenuItem.Text = "Công cụ";
			// 
			// exportData
			// 
			this.exportData.Name = "exportData";
			this.exportData.Size = new System.Drawing.Size(202, 22);
			this.exportData.Text = "Xuất dữ liệu";
			this.exportData.Click += new System.EventHandler(this.exportData_Click);
			// 
			// importData
			// 
			this.importData.Name = "importData";
			this.importData.Size = new System.Drawing.Size(202, 22);
			this.importData.Text = "Nhập dữ liệu";
			this.importData.Click += new System.EventHandler(this.importData_Click);
			// 
			// resetSecurity
			// 
			this.resetSecurity.Name = "resetSecurity";
			this.resetSecurity.Size = new System.Drawing.Size(202, 22);
			this.resetSecurity.Text = "Reset mật khẩu Bảo Mật";
			this.resetSecurity.Click += new System.EventHandler(this.resetSecurity_Click);
			// 
			// contactMenuItem
			// 
			this.contactMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.facebook, this.youtube, this.zalo, this.discord });
			this.contactMenuItem.Name = "contactMenuItem";
			this.contactMenuItem.Size = new System.Drawing.Size(57, 20);
			this.contactMenuItem.Text = "Liên hệ";
			// 
			// facebook
			// 
			this.facebook.Name = "facebook";
			this.facebook.Size = new System.Drawing.Size(180, 22);
			this.facebook.Text = "Facebook";
			this.facebook.Click += new System.EventHandler(this.facebook_Click);
			// 
			// youtube
			// 
			this.youtube.Name = "youtube";
			this.youtube.Size = new System.Drawing.Size(180, 22);
			this.youtube.Text = "Youtube";
			this.youtube.Click += new System.EventHandler(this.youtube_Click);
			// 
			// zalo
			// 
			this.zalo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.phoneNumber });
			this.zalo.Name = "zalo";
			this.zalo.Size = new System.Drawing.Size(180, 22);
			this.zalo.Text = "Zalo";
			this.zalo.Click += new System.EventHandler(this.zalo_Click);
			// 
			// discord
			// 
			this.discord.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.userDiscord });
			this.discord.Name = "discord";
			this.discord.Size = new System.Drawing.Size(180, 22);
			this.discord.Text = "Discord";
			this.discord.Click += new System.EventHandler(this.discord_Click);
			// 
			// phoneNumber
			// 
			this.phoneNumber.Name = "phoneNumber";
			this.phoneNumber.Size = new System.Drawing.Size(209, 22);
			this.phoneNumber.Text = "Số điện thoại: 0986720021";
			this.phoneNumber.Click += new System.EventHandler(this.phoneNumber_Click);
			// 
			// userDiscord
			// 
			this.userDiscord.Name = "userDiscord";
			this.userDiscord.Size = new System.Drawing.Size(213, 22);
			this.userDiscord.Text = "Tên người dùng: buzinbun";
			this.userDiscord.Click += new System.EventHandler(this.userDiscord_Click);
			// 
			// tabControl
			// 
			this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Controls.Add(this.tabPage3);
			this.tabControl.Controls.Add(this.tabPage4);
			this.tabControl.Controls.Add(this.tabPage5);
			this.tabControl.Cursor = System.Windows.Forms.Cursors.Hand;
			this.tabControl.Location = new System.Drawing.Point(12, 27);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(960, 522);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.ChangeTab);
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabPage1.Location = new System.Drawing.Point(4, 40);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Size = new System.Drawing.Size(952, 478);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Mạng Xã Hội";
			// 
			// data
			// 
			this.data.AllowUserToAddRows = false;
			this.data.AllowUserToDeleteRows = false;
			this.data.AllowUserToResizeColumns = false;
			this.data.AllowUserToResizeRows = false;
			this.data.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
			this.data.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.data.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.data.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.Column1,
			this.Column2,
			this.Column3,
			this.Column4,
			this.Column5,
			this.Column6});
			this.data.Cursor = System.Windows.Forms.Cursors.Cross;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.data.DefaultCellStyle = dataGridViewCellStyle2;
			this.data.Location = new System.Drawing.Point(6, 6);
			this.data.Name = "data";
			this.data.ReadOnly = true;
			this.data.RowHeadersVisible = false;
			this.data.Size = new System.Drawing.Size(940, 235);
			this.data.TabIndex = 0;
			this.data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_CellClick);
			this.data.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.View_CellEnter);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "STT";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			this.Column1.Visible = false;
			// 
			// Column2
			// 
			this.Column2.FillWeight = 44.18357F;
			this.Column2.HeaderText = "Tài Khoản";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			this.Column2.Width = 500;
			// 
			// Column3
			// 
			this.Column3.HeaderText = "Mật Khẩu";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			this.Column3.Visible = false;
			// 
			// Column4
			// 
			this.Column4.FillWeight = 127.7542F;
			this.Column4.HeaderText = "Mạng Xã Hội";
			this.Column4.Name = "Column4";
			this.Column4.ReadOnly = true;
			this.Column4.Width = 220;
			// 
			// Column5
			// 
			this.Column5.FillWeight = 128.0623F;
			this.Column5.HeaderText = "Ghi Chú";
			this.Column5.Name = "Column5";
			this.Column5.ReadOnly = true;
			this.Column5.Width = 200;
			// 
			// Column6
			// 
			this.Column6.HeaderText = "None";
			this.Column6.Name = "Column6";
			this.Column6.ReadOnly = true;
			this.Column6.Visible = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(6, 264);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 30);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tài khoản:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtAcc
			// 
			this.txtAcc.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtAcc.Location = new System.Drawing.Point(165, 262);
			this.txtAcc.Name = "txtAcc";
			this.txtAcc.Size = new System.Drawing.Size(399, 34);
			this.txtAcc.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(6, 320);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(153, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Mật khẩu:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtPass
			// 
			this.txtPass.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtPass.Location = new System.Drawing.Point(165, 318);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '•';
			this.txtPass.Size = new System.Drawing.Size(333, 34);
			this.txtPass.TabIndex = 4;
			// 
			// hidePass
			// 
			this.hidePass.AutoSize = true;
			this.hidePass.Checked = true;
			this.hidePass.CheckState = System.Windows.Forms.CheckState.Checked;
			this.hidePass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hidePass.Location = new System.Drawing.Point(507, 320);
			this.hidePass.Name = "hidePass";
			this.hidePass.Size = new System.Drawing.Size(57, 32);
			this.hidePass.TabIndex = 5;
			this.hidePass.Text = "Ẩn";
			this.hidePass.UseVisualStyleBackColor = true;
			this.hidePass.CheckedChanged += new System.EventHandler(this.hidePass_CheckedChanged);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(6, 376);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(153, 30);
			this.label3.TabIndex = 6;
			this.label3.Text = "Mạng Xã Hội:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtName
			// 
			this.txtName.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtName.Location = new System.Drawing.Point(165, 374);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(399, 34);
			this.txtName.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 432);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(153, 30);
			this.label4.TabIndex = 8;
			this.label4.Text = "Ghi Chú:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNote
			// 
			this.txtNote.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtNote.Location = new System.Drawing.Point(165, 430);
			this.txtNote.Name = "txtNote";
			this.txtNote.Size = new System.Drawing.Size(399, 34);
			this.txtNote.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAdd.Location = new System.Drawing.Point(570, 262);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(180, 40);
			this.btnAdd.TabIndex = 10;
			this.btnAdd.Text = "Thêm";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUpdate.Location = new System.Drawing.Point(766, 262);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(180, 40);
			this.btnUpdate.TabIndex = 11;
			this.btnUpdate.Text = "Sửa";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnDelete.Location = new System.Drawing.Point(570, 318);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(180, 40);
			this.btnDelete.TabIndex = 12;
			this.btnDelete.Text = "Xóa";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnLoad
			// 
			this.btnLoad.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLoad.Location = new System.Drawing.Point(766, 318);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(180, 40);
			this.btnLoad.TabIndex = 13;
			this.btnLoad.Text = "Load Data";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSearch.Location = new System.Drawing.Point(570, 374);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(180, 90);
			this.btnSearch.TabIndex = 14;
			this.btnSearch.Text = "Tìm kiếm";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// rbtAcc
			// 
			this.rbtAcc.AutoSize = true;
			this.rbtAcc.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbtAcc.Location = new System.Drawing.Point(766, 364);
			this.rbtAcc.Name = "rbtAcc";
			this.rbtAcc.Size = new System.Drawing.Size(121, 32);
			this.rbtAcc.TabIndex = 15;
			this.rbtAcc.Text = "Tài khoản";
			this.rbtAcc.UseVisualStyleBackColor = true;
			// 
			// rbtName
			// 
			this.rbtName.AutoSize = true;
			this.rbtName.Checked = true;
			this.rbtName.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbtName.Location = new System.Drawing.Point(766, 402);
			this.rbtName.Name = "rbtName";
			this.rbtName.Size = new System.Drawing.Size(153, 32);
			this.rbtName.TabIndex = 16;
			this.rbtName.TabStop = true;
			this.rbtName.Text = "Mạng Xã Hội";
			this.rbtName.UseVisualStyleBackColor = true;
			// 
			// rbtNote
			// 
			this.rbtNote.AutoSize = true;
			this.rbtNote.Cursor = System.Windows.Forms.Cursors.Hand;
			this.rbtNote.Location = new System.Drawing.Point(766, 440);
			this.rbtNote.Name = "rbtNote";
			this.rbtNote.Size = new System.Drawing.Size(104, 32);
			this.rbtNote.TabIndex = 17;
			this.rbtNote.Text = "Ghi Chú";
			this.rbtNote.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabPage2.Location = new System.Drawing.Point(4, 40);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Size = new System.Drawing.Size(952, 478);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = " Game";
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabPage3.Location = new System.Drawing.Point(4, 40);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Size = new System.Drawing.Size(952, 478);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Website";
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabPage4.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabPage4.Location = new System.Drawing.Point(4, 40);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Size = new System.Drawing.Size(952, 478);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Khác...";
			// 
			// tabPage5
			// 
			this.tabPage5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.tabPage5.Controls.Add(this.label9);
			this.tabPage5.Controls.Add(this.btnChangePass);
			this.tabPage5.Controls.Add(this.hideChangePass);
			this.tabPage5.Controls.Add(this.txtNewPass2);
			this.tabPage5.Controls.Add(this.label8);
			this.tabPage5.Controls.Add(this.txtNewPass);
			this.tabPage5.Controls.Add(this.label7);
			this.tabPage5.Controls.Add(this.txtCurrentPass);
			this.tabPage5.Controls.Add(this.label6);
			this.tabPage5.Controls.Add(this.label5);
			this.tabPage5.Cursor = System.Windows.Forms.Cursors.Default;
			this.tabPage5.Location = new System.Drawing.Point(4, 40);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Size = new System.Drawing.Size(952, 478);
			this.tabPage5.TabIndex = 5;
			this.tabPage5.Text = "Đổi Mật Khẩu";
			// 
			// label5
			// 
			this.label5.ForeColor = System.Drawing.Color.Navy;
			this.label5.Location = new System.Drawing.Point(3, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(946, 80);
			this.label5.TabIndex = 0;
			this.label5.Text = "LƯU Ý: Đổi mật khẩu này là đổi cho tài khoản đăng nhập\n(Không phải mật khẩu bảo mật - Mật khẩu Bảo Mật chỉ có thể reset ở công cụ).";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(212, 93);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(185, 28);
			this.label6.TabIndex = 1;
			this.label6.Text = "Mật khẩu hiện tại:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtCurrentPass
			// 
			this.txtCurrentPass.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtCurrentPass.Location = new System.Drawing.Point(403, 90);
			this.txtCurrentPass.Name = "txtCurrentPass";
			this.txtCurrentPass.PasswordChar = '•';
			this.txtCurrentPass.Size = new System.Drawing.Size(333, 34);
			this.txtCurrentPass.TabIndex = 2;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(247, 173);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(150, 28);
			this.label7.TabIndex = 3;
			this.label7.Text = "Mật khẩu mới:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNewPass
			// 
			this.txtNewPass.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtNewPass.Location = new System.Drawing.Point(403, 170);
			this.txtNewPass.Name = "txtNewPass";
			this.txtNewPass.PasswordChar = '•';
			this.txtNewPass.Size = new System.Drawing.Size(333, 34);
			this.txtNewPass.TabIndex = 4;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(155, 253);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(242, 28);
			this.label8.TabIndex = 5;
			this.label8.Text = "Xác nhận mật khẩu mới:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNewPass2
			// 
			this.txtNewPass2.ForeColor = System.Drawing.Color.RoyalBlue;
			this.txtNewPass2.Location = new System.Drawing.Point(403, 250);
			this.txtNewPass2.Name = "txtNewPass2";
			this.txtNewPass2.PasswordChar = '•';
			this.txtNewPass2.Size = new System.Drawing.Size(333, 34);
			this.txtNewPass2.TabIndex = 6;
			// 
			// hideChangePass
			// 
			this.hideChangePass.AutoSize = true;
			this.hideChangePass.Checked = true;
			this.hideChangePass.CheckState = System.Windows.Forms.CheckState.Checked;
			this.hideChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.hideChangePass.Location = new System.Drawing.Point(742, 172);
			this.hideChangePass.Name = "hideChangePass";
			this.hideChangePass.Size = new System.Drawing.Size(57, 32);
			this.hideChangePass.TabIndex = 7;
			this.hideChangePass.Text = "Ẩn";
			this.hideChangePass.UseVisualStyleBackColor = true;
			this.hideChangePass.CheckedChanged += new System.EventHandler(this.hideChangePass_CheckedChanged);
			// 
			// btnChangePass
			// 
			this.btnChangePass.BackColor = System.Drawing.Color.CornflowerBlue;
			this.btnChangePass.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnChangePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChangePass.ForeColor = System.Drawing.Color.Transparent;
			this.btnChangePass.Location = new System.Drawing.Point(403, 330);
			this.btnChangePass.Name = "btnChangePass";
			this.btnChangePass.Size = new System.Drawing.Size(333, 80);
			this.btnChangePass.TabIndex = 8;
			this.btnChangePass.Text = "Đổi mật khẩu";
			this.btnChangePass.UseVisualStyleBackColor = false;
			this.btnChangePass.Click += new System.EventHandler(this.btnChangePass_Click);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(3, 420);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(946, 47);
			this.label9.TabIndex = 8;
			this.label9.Text = "Copyright © 2023 Buzinbun";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// AccountManage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ClientSize = new System.Drawing.Size(984, 561);
			this.Controls.Add(this.menuStrip);
			this.Controls.Add(this.tabControl);
			this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
			this.ForeColor = System.Drawing.Color.RoyalBlue;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip;
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.MaximizeBox = false;
			this.Name = "AccountManage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quản Lý Tài Khoản";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AccountManage_FormClosing);
			this.Load += new System.EventHandler(this.LoadData);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openFolderApp;
		private System.Windows.Forms.ToolStripMenuItem toolMenuItem;
		private System.Windows.Forms.ToolStripMenuItem resetSecurity;
		private System.Windows.Forms.ToolStripMenuItem exportData;
		private System.Windows.Forms.ToolStripMenuItem importData;
		private System.Windows.Forms.ToolStripMenuItem contactMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facebook;
		private System.Windows.Forms.ToolStripMenuItem youtube;
		private System.Windows.Forms.ToolStripMenuItem zalo;
		private System.Windows.Forms.ToolStripMenuItem discord;
		private System.Windows.Forms.ToolStripMenuItem phoneNumber;
		private System.Windows.Forms.ToolStripMenuItem userDiscord;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage5;
		private System.Windows.Forms.DataGridView data;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtAcc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.CheckBox hidePass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNote;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnLoad;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.RadioButton rbtAcc;
		private System.Windows.Forms.RadioButton rbtName;
		private System.Windows.Forms.RadioButton rbtNote;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtCurrentPass;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtNewPass;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtNewPass2;
		private System.Windows.Forms.CheckBox hideChangePass;
		private System.Windows.Forms.Button btnChangePass;
		private System.Windows.Forms.Label label9;
	}
}