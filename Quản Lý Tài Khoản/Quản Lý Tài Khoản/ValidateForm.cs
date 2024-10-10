using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

public class ValidateForm
{
	public static string notification;

	public static bool CheckTextBox(TextBox acc, TextBox pass, TextBox name, TextBox note, string typeName)
	{
		if (string.IsNullOrWhiteSpace(acc.Text))
		{
			acc.Focus();
			MessageBox.Show("Xin vui lòng nhập Tài Khoản.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (string.IsNullOrWhiteSpace(pass.Text))
		{
			pass.Focus();
			MessageBox.Show("Xin vui lòng nhập Mật Khẩu.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (string.IsNullOrWhiteSpace(name.Text))
		{
			name.Focus();
			MessageBox.Show("Xin vui lòng nhập " + typeName + ".", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (acc.Text.Contains("★") || pass.Text.Contains("★") || name.Text.Contains("★") || note.Text.Contains("★"))
		{
			MessageBox.Show("Xin vui lòng không nhập ký tự ★ vào ô trống để tránh trường hợp xảy ra lỗi!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		return true;
	}

	public static bool CheckTextBox(RadioButton rAcc, RadioButton rName, RadioButton rNote, TextBox acc, TextBox name, TextBox note, string typeName)
	{
		if (rAcc.Checked && string.IsNullOrWhiteSpace(acc.Text))
		{
			acc.Focus();
			MessageBox.Show("Xin vui lòng nhập Tài Khoản để Tìm Kiếm.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (rName.Checked && string.IsNullOrWhiteSpace(name.Text))
		{
			name.Focus();
			MessageBox.Show("Xin vui lòng nhập " + typeName + " để Tìm Kiếm.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (rNote.Checked && string.IsNullOrWhiteSpace(note.Text))
		{
			note.Focus();
			MessageBox.Show("Xin vui lòng nhập Ghi Chú để Tìm Kiếm.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		return true;
	}

	public static bool CheckAccount(TextBox acc, TextBox pass, TextBox name, TextBox note, int stt, int type)
	{
		if (File.Exists(Config.fileData))
		{
			string[] dataFile = Common.ReadData(Config.fileData, Config.fileData_Input, 21);
			for (int i = 0; i < dataFile.Length; i++)
			{
				// Đọc dữ liệu từng cột của mỗi dòng trong file Data-Input.
				string[] read = dataFile[i].ToString().Split('★');
				
				bool check1 = Common.id == int.Parse(read[1]);
				// Check Add
				if (type == 1)
				{
					bool check2 = acc.Text.ToLower() == read[3].ToLower();
					bool check3 = name.Text.ToLower() == read[5].ToLower();
					if (check1 && check2 && check3)
					{
						MessageBox.Show("Tài khoản " + read[3] + " (" + read[5] + ") đã tồn tại trong tab " + read[2] + "!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
				}

				// Check Update
				if (type == 2)
				{
					bool check2 = stt == int.Parse(read[0]) && acc.Text == read[3] && pass.Text == read[4] && name.Text == read[5] && note.Text == read[6];
					bool check3 = stt != int.Parse(read[0]) && acc.Text.ToLower() == read[3].ToLower() && name.Text.ToLower() == read[5].ToLower();
					bool check4 = stt == int.Parse(read[0]) && (acc.Text != read[3] || pass.Text != read[4] || name.Text != read[5] || note.Text != read[6]);
					if (check2)
					{
						return false;
					}
					if (check1 && check3)
					{
						MessageBox.Show("Tài khoản " + read[3] + " (" + read[5] + ") đã tồn tại trong tab " + read[2] + "!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return false;
					}
					if (check1 && check4)
					{
						notification = read[3] + "\n" + read[4] + "\n" + read[5] + "\n" + read[6] + "\n\n" +
									"Sau khi thay đổi:" + "\n\n" +
									acc.Text + "\n" + pass.Text + "\n" + name.Text + "\n" + note.Text;
					}
				}
			}
		}
		return true;
	}

	public static bool CheckAdd(TextBox acc, TextBox pass, TextBox name, TextBox note, string typeName, int stt)
	{
		if (CheckTextBox(acc, pass, name, note, typeName) && CheckAccount(acc, pass, name, note, stt, 1))
		{
			return true;
		}
		return false;
	}

	public static bool CheckUpdate(TextBox acc, TextBox pass, TextBox name, TextBox note, string typeName, int stt)
	{
		if (CheckTextBox(acc, pass, name, note, typeName) && CheckAccount(acc, pass, name, note, stt, 2))
		{
			if (MessageBox.Show(notification, string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				return true;
			}
		}
		return false;
	}

	public static bool CheckChangePassword(TextBox currentPass, TextBox newPass, TextBox newPass2)
	{
		if (string.IsNullOrEmpty(currentPass.Text))
		{
			currentPass.Focus();
			MessageBox.Show("Xin vui lòng nhập Mật Khẩu hiện tại.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (string.IsNullOrEmpty(newPass.Text))
		{
			newPass.Focus();
			MessageBox.Show("Xin vui lòng nhập Mật Khẩu mới.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (string.IsNullOrEmpty(newPass2.Text))
		{
			newPass2.Focus();
			MessageBox.Show("Xin vui lòng xác nhận Mật Khẩu mới.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (!Common.Hash(currentPass.Text).Equals(Common.password))
		{
			currentPass.Focus();
			MessageBox.Show("Mật khẩu không chính xác!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (!Regex.IsMatch(newPass.Text, "^[A-Z](?=.*[`~!@#$%^&*()-=_+\\[\\]{}|;:,.<>\\/?\\\"'])[\\w`~!@#$%^&*()-=_+\\[\\]{}|;:,.<>\\/?\\\"']{5,29}$"))
		{
			newPass.Focus();
			MessageBox.Show("Mật khẩu phải bắt đầu bằng chữ in hoa và có từ 6-30 ký tự. Mật khẩu có ít nhất 1 ký tự đặc biệt.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (!newPass2.Text.Equals(newPass.Text))
		{
			newPass2.Focus();
			MessageBox.Show("Mật khẩu mới không trùng khớp!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		if (newPass.Text.Equals(currentPass.Text))
		{
			newPass.Focus();
			MessageBox.Show("Mật khẩu mới phải khác với Mật Khẩu hiện tại.", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return false;
		}
		return true;
	}
}