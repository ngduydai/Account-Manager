using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

public class Common
{
	public static int id; // id của user

	public static string username;

	public static string password;

	public static int index;

	public static bool close;

	public static string[] tab = { "Mạng Xã Hội", "Game", "Website", "Khác..." };

	public static string[] typeName = { "Mạng Xã Hội", "Game", "Website", "Tên" };

	public static void DataEncrypt(string fileInput, string fileOutput, string text, byte number, int type)
	{
		/* Ở đây sẽ làm như sau:
		 * type = 1 sẽ là tạo 1 file gọi là file A, sau đó thì mã hóa dữ liệu file A sang file B, xong thì xóa file A
		 * type = 2 sẽ là mở 1 file có sẵn (file B), sau đó thì giải mã dữ liệu file B sang file A, việc xóa file A sẽ phải làm sau khi đọc file A */
		if (type == 1)
		{
			File.WriteAllText(fileInput, text);
		}

		// fileInput gọi là file A khi type = 1, gọi là file B khi type = 2
		// fileOutput gọi là file A khi type = 2, gọi là file B khi type = 1
		FileStream fis = new FileStream(fileInput, FileMode.Open); // Mở 1 file sẵn có.
		FileStream fos = new FileStream(fileOutput, FileMode.Create); // Tạo 1 file khác.

		for (long i = 0; i < fis.Length; i++)
		{
			byte temp = (byte)fis.ReadByte();
			temp = (type == 1) ? (byte)(temp + number) : (byte)(temp - number); // Cộng sẽ là mã hóa, trừ sẽ là giải mã (trừ đi đúng số vừa cộng)
			fos.WriteByte(temp); // Lưu vào file vừa tạo.
		}
		// Đóng và giải phóng bộ nhớ các file vừa làm.
		fos.Close();
		fos.Dispose();
		fis.Close();
		fis.Dispose();

		if (type == 1)
		{
			File.Delete(fileInput);
		}
	}

	public static string[] ReadData(string fileInput, string fileOutput, byte number)
	{
		DataEncrypt(fileInput, fileOutput, null, number, 2); // Giải mã hóa fileInput (file B) sang fileOutput (file A).
		string[] file = File.ReadAllLines(fileOutput); // Đọc dữ liệu từng dòng fileOutput.
		File.Delete(fileOutput); // Xóa fileOutput.
		return file;
	}

	public static string Hash(string text)
	{
		MD5 md5 = MD5.Create();
		byte[] hash = md5.ComputeHash(Encoding.UTF8.GetBytes(text));
		StringBuilder hashSb = new StringBuilder();
		foreach (byte b in hash)
		{
			hashSb.Append(b.ToString("X2"));
		}
		return hashSb.ToString();
	}

	public static void DeleteFile_MessageBox(string file, string text, MessageBoxButtons button, MessageBoxIcon icon)
	{
		if (File.Exists(file))
		{
			File.Delete(file);
		}
		MessageBox.Show(text, string.Empty, button, icon);
	}

	public static void LoadData(DataGridView data, string tabName)
	{
		if (File.Exists(Config.fileData))
		{
			data.Rows.Clear();
			string[] dataFile = ReadData(Config.fileData, Config.fileData_Input, 21);
			for (int i = 0; i < dataFile.Length; i++)
			{
				string[] read = dataFile[i].ToString().Split('★');
				if (int.Parse(read[1]) == id && read[2] == tabName)
				{
					data.Rows.Add(read[0], read[3], read[4], read[5], read[6]);
				}
			}
		}
	}

	public static void LoadData(DataGridView data, RadioButton rAcc, RadioButton rName, RadioButton rNote, TextBox acc, TextBox name, TextBox note, string tabName)
	{
		if (File.Exists(Config.fileData))
		{
			data.Rows.Clear();
			string[] dataFile = ReadData(Config.fileData, Config.fileData_Input, 21);
			string searchAcc = acc.Text.ToLower();
			string searchName = name.Text.ToLower();
			string searchNote = note.Text.ToLower();
			for (int i = 0; i < dataFile.Length; i++)
			{
				string[] read = dataFile[i].ToString().Split('★');
				bool checkAcc = read[3].ToLower().Contains(searchAcc);
				bool checkName = read[5].ToLower().Contains(searchName);
				bool checkNote = read[6].ToLower().Contains(searchNote);
				bool check = (rAcc.Checked && checkAcc) || (rName.Checked && checkName) || (rNote.Checked && checkNote);

				if (int.Parse(read[1]) == id && read[2] == tabName && check)
				{
					data.Rows.Add(read[0], read[3], read[4], read[5], read[6]);
				}
			}
		}
	}

	public static void CellClick(DataGridView data, DataGridViewCellEventArgs e, TextBox acc, TextBox pass, TextBox name, TextBox note)
	{
		if (e.RowIndex >= 0)
		{
			index = int.Parse(data.Rows[e.RowIndex].Cells[0].Value.ToString());
			acc.Text = data.Rows[e.RowIndex].Cells[1].Value.ToString();
			pass.Text = data.Rows[e.RowIndex].Cells[2].Value.ToString();
			name.Text = data.Rows[e.RowIndex].Cells[3].Value.ToString();
			note.Text = data.Rows[e.RowIndex].Cells[4].Value.ToString();
		}
	}

	public static void TextBoxEmpty(TextBox acc, TextBox pass, TextBox name, TextBox note)
	{
		index = 0;
		acc.Text = string.Empty;
		pass.Text = string.Empty;
		name.Text = string.Empty;
		note.Text = string.Empty;
	}

	public static string WriteData(TextBox acc, TextBox pass, TextBox name, TextBox note, string tabName, int stt, int type)
	{
		// tabName sẽ được lấy theo biến tab, stt sẽ được lấy theo column STT của dataGridView, type là kiểu dữ liệu.
		if (File.Exists(Config.fileData) && !string.IsNullOrWhiteSpace(File.ReadAllText(Config.fileData)))
		{
			string text = string.Empty;
			string[] dataFile = ReadData(Config.fileData, Config.fileData_Input, 21);
			for (int i = 0; i < dataFile.Length; i++)
			{
				// Đọc dữ liệu từng cột của mỗi dòng trong file Data-Input.
				string[] read = dataFile[i].ToString().Split('★');

				/* Lấy dữ liệu từng dòng trong file Data-Input.
				 * read[0] là số thứ tự (stt)
				 * read[1] là id của user
				 * read[2] là tên của danh sách tab (Mạng Xã Hội, Game, Website, Khác...)
				 * read[3] là tài khoản
				 * read[4] là mật khẩu
				 * read[5] là tên loại ứng dụng
				 * read[6] là ghi chú */
				string write = "★" + read[1] + "★" + read[2] + "★" + read[3] + "★" + read[4] + "★" + read[5] + "★" + read[6];

				// Add/Update dữ liệu mới.
				string writeUpdate = "★" + id + "★" + tabName + "★" + acc.Text + "★" + pass.Text + "★" + name.Text + "★" + note.Text;

				// Cứ xong 1 dòng là phải xuống dòng nhưng nếu là dòng cuối thì không cần xuống dòng nữa (file.Length - 1 là dòng cuối)
				string line = (i == dataFile.Length - 1) ? string.Empty : "\n";

				if (type == 0) // Nếu type = 0 thì là Add.
				{
					// Nếu là dòng cuối thì viết thêm 1 dòng nữa để có thể thêm mới.
					// Vì cái này là cái mình cần phải thêm (không phải tự động tăng) nên phải setup i + 2.
					string newWrite = (i == dataFile.Length - 1) ? ("\n" + (i + 2) + writeUpdate + line) : string.Empty;
					text += (i + 1) + write + line + newWrite;
				}
				if (type == 1) // Nếu type = 1 thì là Update.
				{
					// Nếu stt = read[0] thì update, còn không thì chỉ viết các dữ liệu sẵn có.
					string newWrite = (stt == int.Parse(read[0])) ? writeUpdate : write;
					text += (i + 1) + newWrite + line; 
				}
				if (type == 2 && stt != int.Parse(read[0]))
				{
					// Nếu type = 2 thì là Delete. Xóa bằng cách kiểm tra nếu stt != read[0] thì sẽ viết các dữ liệu đó ra.
					int newSTT = ((i + 1) >= stt) ? i : (i + 1);
					text += newSTT + write + line;
				}
			}
			return text;
		}
		return 1 + "★" + id + "★" + tabName + "★" + acc.Text + "★" + pass.Text + "★" + name.Text + "★" + note.Text;
	}

	public static void Add(DataGridView data, TextBox acc, TextBox pass, TextBox name, TextBox note, string typeName, string tabName, int stt)
	{
		if (ValidateForm.CheckAdd(acc, pass, name, note, typeName, stt))
		{
			string text = WriteData(acc, pass, name, note, tabName, stt, 0);
			DataEncrypt(Config.fileData_Input, Config.fileData, text, 21, 1);
			MessageBox.Show("Thêm tài khoản thành công!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
			LoadData(data, tabName);
			TextBoxEmpty(acc, pass, name, note);
		}
	}

	public static void Update(DataGridView data, TextBox acc, TextBox pass, TextBox name, TextBox note, string typeName, string tabName, int stt)
	{
		if (data.Rows.Count > 0 && stt > 0 && ValidateForm.CheckUpdate(acc, pass, name, note, typeName, stt))
		{
			string text = WriteData(acc, pass, name, note, tabName, stt, 1);
			DataEncrypt(Config.fileData_Input, Config.fileData, text, 21, 1);
			MessageBox.Show("Đã sửa thông tin Tài Khoản!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
			LoadData(data, tabName);
			TextBoxEmpty(acc, pass, name, note);
		}
	}

	public static void Delete(DataGridView data, TextBox acc, TextBox pass, TextBox name, TextBox note, string tabName, int stt)
	{
		if (data.Rows.Count > 0 && stt > 0)
		{
			string dataAcc = data.Rows[data.CurrentRow.Index].Cells[1].Value.ToString();
			string dataName = data.Rows[data.CurrentRow.Index].Cells[3].Value.ToString();
			if (MessageBox.Show("Hãy chắc chắn rằng bạn muốn xóa Tài Khoản:\n" + dataAcc + " (" + dataName + ")" + "\nkhỏi danh sách?", string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				string text = WriteData(acc, pass, name, note, tabName, stt, 2);
				DataEncrypt(Config.fileData_Input, Config.fileData, text, 21, 1);
				MessageBox.Show("Đã xóa Tài Khoản khỏi danh sách!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
				LoadData(data, tabName);
				TextBoxEmpty(acc, pass, name, note);
			}
		}
	}

	public static void Search(DataGridView data, TextBox acc, TextBox pass, TextBox name, TextBox note, RadioButton rAcc, RadioButton rName, RadioButton rNote, string typeName, string tabName)
	{
		if (ValidateForm.CheckTextBox(rAcc, rName, rNote, acc, name, note, typeName))
		{
			LoadData(data, rAcc, rName, rNote, acc, name, note, tabName);
			TextBoxEmpty(acc, pass, name, note);
		}
	}

	public static string TextUser(TextBox newPass)
	{
		string text = string.Empty;
		if (File.Exists(Config.fileUser))
		{
			string[] dataFile = ReadData(Config.fileUser, Config.fileUser_Input, 19);
			for (int i = 0; i < dataFile.Length; i++)
			{
				string[] read = dataFile[i].ToString().Split('★');

				string pass = (int.Parse(read[0]) == id) ? Hash(newPass.Text) : read[2];
				string write = read[0] + "★" + read[1] + "★" + pass;
				string line = (i == dataFile.Length - 1) ? string.Empty : "\n";

				text += write + line;
			}
			password = Hash(newPass.Text);
		}
		return text;
	}

	public static void ChangePassword(TextBox currentPass, TextBox newPass, TextBox newPass2)
	{
		if (ValidateForm.CheckChangePassword(currentPass, newPass, newPass2))
		{
			if (MessageBox.Show("Hãy chắc chắn rằng bạn muốn đổi mật khẩu!?", string.Empty, MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				string text = TextUser(newPass);
				DataEncrypt(Config.fileUser_Input, Config.fileUser, text, 19, 1);
				MessageBox.Show("Đổi mật khẩu thành công!", string.Empty, MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
	}
}