using System;
using System.IO;
using System.Windows.Forms;

namespace Quản_Lý_Tài_Khoản
{
	public partial class Password : Form
	{
		public Password()
		{
			InitializeComponent();
			if (!Directory.Exists(Config.AccountManager))
			{
				Directory.CreateDirectory(Config.AccountManager);
			}
			if (!File.Exists(Config.filePassword))
			{
				btnLogin.Text = "Đăng ký";
				MessageBox.Show("Hãy nhập để tạo mật khẩu cho ứng dụng.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txtPass.Text))
			{
				txtPass.Focus();
				MessageBox.Show("Xin vui lòng nhập Mật Khẩu.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			else
			{
				if (File.Exists(Config.filePassword))
				{
					Common.DataEncrypt(Config.filePassword, Config.filePassword_Input, null, 9, 2);
					if (Common.Hash(txtPass.Text) == File.ReadAllText(Config.filePassword_Input))
					{
						new User().Show();
						Hide();
					}
					else
					{
						Common.DeleteFile_MessageBox(Config.filePassword_Input, "Mật khẩu không chính xác.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					}
					File.Delete(Config.filePassword_Input);
				}
				else
				{
					Common.DataEncrypt(Config.filePassword_Input, Config.filePassword, Common.Hash(txtPass.Text), 9, 1);
					MessageBox.Show("Đã đăng ký thành công.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
					new User().Show();
					Hide();
				}
			}
		}

		private void txtPass_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				btnLogin_Click(sender, e);
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			if (Common.close)
			{
				Close();
			}
		}
	}
}