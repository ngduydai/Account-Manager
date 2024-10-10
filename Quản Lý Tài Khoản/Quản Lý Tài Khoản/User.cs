using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Quản_Lý_Tài_Khoản
{
	public partial class User : Form
	{
		public User()
		{
			InitializeComponent();
		}

		private bool CheckTextBox(string type)
		{
			if (string.IsNullOrWhiteSpace(txtUser.Text))
			{
				txtUser.Focus();
				MessageBox.Show("Xin vui lòng nhập Tài Khoản.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (string.IsNullOrEmpty(txtPass.Text))
			{
				txtPass.Focus();
				MessageBox.Show("Xin vui lòng nhập Mật Khẩu.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (type == "Register" && !Regex.IsMatch(txtUser.Text, "^[a-zA-Z][\\w._]{2,14}$"))
			{
				txtUser.Focus();
				MessageBox.Show("Tên người dùng phải bắt đầu bằng chữ và có từ 3-15 ký tự. Tên người dùng chỉ chứa các ký tự: chữ in hoa, chữ in thường, số, dấu gạch dưới và dấu chấm.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			if (type == "Register" && !Regex.IsMatch(txtPass.Text, "^[A-Z](?=.*[`~!@#$%^&*()-=_+\\[\\]{}|;:,.<>\\/?\\\"'])[\\w`~!@#$%^&*()-=_+\\[\\]{}|;:,.<>\\/?\\\"']{5,29}$"))
			{
				txtPass.Focus();
				MessageBox.Show("Mật khẩu phải bắt đầu bằng chữ in hoa và có từ 6-30 ký tự. Mật khẩu có ít nhất 1 ký tự đặc biệt.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return false;
			}
			return true;
		}

		public void Register_Login(string type)
		{
			int temp = 0;
			string read = string.Empty;
			string add = 1 + "★" + txtUser.Text.ToLower() + "★" + Common.Hash(txtPass.Text);
			if (File.Exists(Config.fileUser))
			{
				Common.DataEncrypt(Config.fileUser, Config.fileUser_Input, null, 19, 2);
				read = File.ReadAllText(Config.fileUser_Input) + "\n";
				string[] file = File.ReadAllLines(Config.fileUser_Input);
				add = file.Length + 1 + "★" + txtUser.Text.ToLower() + "★" + Common.Hash(txtPass.Text);
				for (int i = 0; i < file.Length; i++)
				{
					string[] acc = file[i].ToString().Split('★');
					if (txtUser.Text.ToLower() == acc[1])
					{
						if (type == "Register")
						{
							Common.DeleteFile_MessageBox(Config.fileUser_Input, "Tên người dùng đã tồn tại.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						}
						if (type == "Login")
						{
							if (Common.Hash(txtPass.Text) == acc[2])
							{
								Common.id = int.Parse(acc[0]);
								Common.username = acc[1];
								Common.password = acc[2];
								File.Delete(Config.fileUser_Input);
								new AccountManage().Show();
								Hide();
							}
							else
							{
								Common.DeleteFile_MessageBox(Config.fileUser_Input, "Mật khẩu không chính xác.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							}
						}
						temp = 1;
					}
				}
			}
			if (type == "Register" && temp == 0)
			{
				string text = read + add;
				Common.DataEncrypt(Config.fileUser_Input, Config.fileUser, text, 19, 1);
				MessageBox.Show("Đăng ký tài khoản thành công!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			if (type == "Login" && temp == 0)
			{
				Common.DeleteFile_MessageBox(Config.fileUser_Input, "Tên người dùng không tồn tại.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void btnRegister_Click(object sender, EventArgs e)
		{
			if (CheckTextBox("Register"))
			{
				Register_Login("Register");
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (CheckTextBox(null))
			{
				Register_Login("Login");
			}
		}

		private void txtUser_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}

		private void txtPass_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}

		private void Login_FormClosing(object sender, FormClosingEventArgs e)
		{
			Common.close = true;
		}
	}
}