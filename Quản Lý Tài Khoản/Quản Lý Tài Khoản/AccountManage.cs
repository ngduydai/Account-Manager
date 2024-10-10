using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Quản_Lý_Tài_Khoản
{
	public partial class AccountManage : Form
	{
		public AccountManage()
		{
			InitializeComponent();
			Text += " (" + Common.username + ")";
		}

		private void LoadData(object sender, EventArgs e)
		{
			ChangedTabs(tabPage1, 0);
			Common.LoadData(data, Common.tab[tabControl.SelectedIndex]);
		}
		
		#region Menu strip
		private void openFolderApp_Click(object sender, EventArgs e)
		{
			Process.Start(".\\");
		}

		private void resetSecurity_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc rằng muốn cài lại mật khẩu Bảo Mật chứ?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				File.Delete(Config.filePassword);
				MessageBox.Show("Xin vui lòng tắt ứng dụng và mở lại để thiết lập mật khẩu mới.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void exportData_Click(object sender, EventArgs e)
		{
			if (File.Exists(Config.fileUser) && File.Exists(Config.fileData))
			{
				if (!Directory.Exists(Config.folderData))
				{
					Directory.CreateDirectory(Config.folderData);
				}
				if (Directory.Exists(Config.folderData))
				{
					File.Copy(Config.fileUser, Config.exportUser, true);
					File.Copy(Config.fileData, Config.exportData, true);
					string text = "Xuất dữ liệu thành công.\n" +
						"Các tệp dữ liệu được lưu trong thư mục của ứng dụng.\n" +
						"Để có thể nhập dữ liệu cho máy khác thì hãy cứ ĐĂNG KÝ tài khoản mới sau đó nhập dữ liệu và dùng như bình thường.";
					MessageBox.Show(text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("Không có tệp dữ liệu.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void importData_Click(object sender, EventArgs e)
		{
			string question = "LƯU Ý: Nếu nhập dữ liệu vào thì các tài khoản đăng nhập và các tài khoản đang quản lý sẽ bị mất vì khi nhập dữ liệu thì dữ liệu đó sẽ được dán đè lên dữ liệu cũ. Hãy chắc rằng bạn muốn nhập dữ liệu khác?";
			if (MessageBox.Show(question, string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				if (File.Exists(Config.exportUser) && File.Exists(Config.exportData))
				{
					File.Copy(Config.exportUser, Config.fileUser, true);
					File.Copy(Config.exportData, Config.fileData, true);
					File.Delete(Config.exportUser);
					File.Delete(Config.exportData);
					MessageBox.Show("Nhập dữ liệu thành công.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					string text = "Không có tệp dữ liệu.\nNếu có tệp dữ liệu xin vui lòng để các tệp dữ liệu (tệp User và Data) vào thư mục Data của ứng dụng.";
					MessageBox.Show(text, string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}

		private void facebook_Click(object sender, EventArgs e)
		{
			Process.Start(Config.facebook);
		}

		private void youtube_Click(object sender, EventArgs e)
		{
			Process.Start(Config.youtube);
		}

		private void zalo_Click(object sender, EventArgs e)
		{
			Process.Start(Config.zalo);
		}

		private void discord_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Đang cập nhật Server", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void phoneNumber_Click(object sender, EventArgs e)
		{
			Clipboard.SetText("0986720021");
			MessageBox.Show("Đã sao chép số điện thoại.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void userDiscord_Click(object sender, EventArgs e)
		{
			Clipboard.SetText("buzinbun");
			MessageBox.Show("Đã sao chép tên người dùng Discord.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		#endregion
		
		#region Acts
		private void View_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			Common.CellClick(data, e, txtAcc, txtPass, txtName, txtNote);
		}

		private void View_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			View_CellClick(sender, e);
		}

		private void hidePass_CheckedChanged(object sender, EventArgs e)
		{
			txtPass.PasswordChar = hidePass.Checked ? '•' : '\0';
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Common.Add(data, txtAcc, txtPass, txtName, txtNote, Common.typeName[tabControl.SelectedIndex], Common.tab[tabControl.SelectedIndex], Common.index);
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			Common.Update(data, txtAcc, txtPass, txtName, txtNote, Common.typeName[tabControl.SelectedIndex], Common.tab[tabControl.SelectedIndex], Common.index);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			Common.Delete(data, txtAcc, txtPass, txtName, txtNote, Common.tab[tabControl.SelectedIndex], Common.index);
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			Common.LoadData(data, Common.tab[tabControl.SelectedIndex]);
			Common.TextBoxEmpty(txtAcc, txtPass, txtName, txtNote);
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			Common.Search(data, txtAcc, txtPass, txtName, txtNote, rbtAcc, rbtName, rbtNote, Common.typeName[tabControl.SelectedIndex], Common.tab[tabControl.SelectedIndex]);
		}

		private void ChangedTabs(TabPage tabPage, int selected)
		{
			if (tabControl.SelectedIndex == selected)
			{
				tabPage.Controls.Add(rbtNote);
				tabPage.Controls.Add(rbtName);
				tabPage.Controls.Add(rbtAcc);
				tabPage.Controls.Add(btnSearch);
				tabPage.Controls.Add(btnLoad);
				tabPage.Controls.Add(btnDelete);
				tabPage.Controls.Add(btnUpdate);
				tabPage.Controls.Add(btnAdd);
				tabPage.Controls.Add(txtNote);
				tabPage.Controls.Add(label4);
				tabPage.Controls.Add(txtName);
				tabPage.Controls.Add(label3);
				tabPage.Controls.Add(hidePass);
				tabPage.Controls.Add(txtPass);
				tabPage.Controls.Add(label2);
				tabPage.Controls.Add(txtAcc);
				tabPage.Controls.Add(label1);
				tabPage.Controls.Add(data);
				Column4.HeaderText = Common.typeName[tabControl.SelectedIndex];
				label3.Text = Common.typeName[tabControl.SelectedIndex] + ":";
				rbtName.Text = Common.typeName[tabControl.SelectedIndex];
				Common.LoadData(data, Common.tab[tabControl.SelectedIndex]);
			}
		}
		
		private void ChangeTab(object sender, EventArgs e)
		{
			ChangedTabs(tabPage1, 0);
			ChangedTabs(tabPage2, 1);
			ChangedTabs(tabPage3, 2);
			ChangedTabs(tabPage4, 3);
		}
		#endregion

		#region Đổi mật khẩu
		private void hideChangePass_CheckedChanged(object sender, EventArgs e)
		{
			txtCurrentPass.PasswordChar = hideChangePass.Checked ? '•' : '\0';
			txtNewPass.PasswordChar = hideChangePass.Checked ? '•' : '\0';
			txtNewPass2.PasswordChar = hideChangePass.Checked ? '•' : '\0';
		}

		private void btnChangePass_Click(object sender, EventArgs e)
		{
			Common.ChangePassword(txtCurrentPass, txtNewPass, txtNewPass2);
		}
		#endregion

		private void AccountManage_FormClosing(object sender, FormClosingEventArgs e)
		{
			e.Cancel = true;
			if (MessageBox.Show("Bạn có muốn Đăng Xuất?", string.Empty, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				e.Cancel = false;
				new User().Show();
			}
		}
	}
}