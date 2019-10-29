using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserMasterMaintenance
{
	public partial class UsersMasterMaintenance_InputDisplay : Form
	{
		public enum ErrorType
		{
			NotInputError,
			NotNumberError,
			SameIdError
		}

		public enum ClickButtonType
		{
			AddButton,
			UpdateButton,
			DeleteButton,
		}

		/// <summary>
		/// エラータイプパラメータ
		/// </summary>
		public ErrorType ErrorTypeParam { get; set; }

		/// <summary>
		/// クリックボタンタイプパラメータ
		/// </summary>
		public ClickButtonType ClickedButtonTypeParam { get; set; }

		/// <summary>
		/// 選択Userデータ
		/// </summary>
		private Users SelectedUsers { get; set; }

		/// <summary>
		/// 編集Userデータ
		/// </summary>
		public Users InputUsers { get; set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="selectedusers"></param>
		/// <param name="usersList"></param>
		/// <param name="departmentsList"></param>
		/// <param name="clickButtonTypeParam"></param>
		public UsersMasterMaintenance_InputDisplay(Users selectedusers,
												   ClickButtonType clickButtonTypeParam)
		{
			InitializeComponent();

			//初期設定
			SelectedUsers = selectedusers;
			ClickedButtonTypeParam = clickButtonTypeParam;

			StoreComboboxFromDepartmentsList();
		}

		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UsersMasterMaintenance_InputDisplay_Load(object sender, EventArgs e)
		{
			switch (ClickedButtonTypeParam)
			{
				case ClickButtonType.AddButton:

					break;

				case ClickButtonType.UpdateButton:

					InputDisplayFromUser();
					break;

				case ClickButtonType.DeleteButton:

					InputDisplayFromUser();
					MakeInputDepartmentReadOnly();
					break;
			}
		}

		/// <summary>
		/// OKボタンクリック時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void button1_Click(object sender, EventArgs e)
		{
			switch (ClickedButtonTypeParam)
			{
				case ClickButtonType.AddButton:

					if (!ConfirmInput())
					{
						ShowErrorDialog(ErrorType.NotInputError);
						return;
					}
					if(!ConfirmInputId())
					{
						ShowErrorDialog(ErrorType.SameIdError);
						return;
					}
					if ( !ConfirmInputNumber(textBox3.Text))
					{
						ShowErrorDialog(ErrorType.NotNumberError);
						return;
					}
					break;

				case ClickButtonType.UpdateButton:

					if (!ConfirmInput())
					{
						ShowErrorDialog(ErrorType.NotInputError);
						return;
					}
					if (!ConfirmInputId())
					{
						ShowErrorDialog(ErrorType.SameIdError);
						return;
					}
					if (!ConfirmInputNumber(textBox3.Text))
					{
						ShowErrorDialog(ErrorType.NotNumberError);
						return;
					}
					break;

				case ClickButtonType.DeleteButton:

					break;

				default:
					break;
			}

			//確認画面へ
			if (!(ClickedButtonTypeParam == ClickButtonType.AddButton))
			{
				var result = ShowConfirmDialog();

				if (result == DialogResult.Cancel) return;
			}

			SaveUsersFromInputText();

			EditList();

			Close();
		}

		/// <summary>
		/// キャンセルボタンクリック時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		public void button2_Click(object sender, EventArgs e)
		{
			DialogResult = DialogResult.Cancel;
			Close();
		}

		/// <summary>
		/// コンボボックス項目設定
		/// </summary>
		private void StoreComboboxFromDepartmentsList()
		{
			foreach (var departmentsList in Departments.DepartmentsList)
			{
				comboBox1.Items.Add(departmentsList.Department);
			}
			//初期値
			comboBox1.SelectedIndex = 0;
			return;
		}

		/// <summary>
		/// ユーザー情報画面設定処理
		/// </summary>
		private void InputDisplayFromUser()
		{
			textBox1.Text = SelectedUsers.UserId;
			textBox2.Text = SelectedUsers.UserName;
			textBox3.Text = SelectedUsers.UserAge.ToString();
			if (SelectedUsers.UserGender == "男性")
			{
				radioButton1.Checked = true;
				radioButton2.Checked = false;
			}
			else
			{
				radioButton1.Checked = false;
				radioButton2.Checked = true;
			}
			comboBox1.Text = SelectedUsers.UserAffiliation;
			return;
		}

		/// <summary>
		/// 入力項目入力不可処理
		/// </summary>
		private void MakeInputDepartmentReadOnly()
		{
			textBox1.ReadOnly = true;
			textBox2.ReadOnly = true;
			textBox3.ReadOnly = true;
			radioButton1.Enabled = false;
			radioButton2.Enabled = false;
			comboBox1.Enabled = false;
		}

		/// <summary>
		/// 未入力チェック
		/// </summary>
		/// <returns></returns>
		private bool ConfirmInput()
		{
			if (string.IsNullOrEmpty(textBox1.Text)) return false;
			if (string.IsNullOrEmpty(textBox2.Text)) return false;
			if (string.IsNullOrEmpty(textBox3.Text)) return false;
			if (string.IsNullOrEmpty(comboBox1.Text)) return false;

			return true;
		}

		/// <summary>
		/// 数値入力チェック
		/// </summary>
		/// <param name="inputText"></param>
		/// <returns></returns>
		private bool ConfirmInputNumber(string inputText)
		{
			if (!int.TryParse(inputText, out var numberText)) return false;
			if(numberText < 0 || numberText > 999) return false;
			if (inputText.Contains(".")) return false;

			return true;
		}

		/// <summary>
		/// 同IDチェック
		/// </summary>
		/// <returns></returns>
		private bool ConfirmInputId()
		{
			if(ClickedButtonTypeParam == ClickButtonType.UpdateButton)
			{
				//更新時にもともとのIDと入力IDが同じ場合はtrue
				if (SelectedUsers.UserId == textBox1.Text) return true;
			}

			foreach(var usersList in Users.UsersList)
			{
				if (usersList.UserId == textBox1.Text) return false;
			}
			return true;
		}
		/// <summary>
		/// 入力項目を保持
		/// </summary>
		private void SaveUsersFromInputText()
		{
			Users users = new Users();

			users.UserId = textBox1.Text;
			users.UserName = textBox2.Text;
			users.UserAge = int.Parse(textBox3.Text);
			if (radioButton1.Checked) users.UserGender = "男性";
			else users.UserGender = "女性";
			users.UserAffiliation = comboBox1.Text;

			InputUsers = users;
			return;
		}

		/// <summary>
		/// リスト内編集処理
		/// </summary>
		private void EditList()
		{
			switch (ClickedButtonTypeParam)
			{
				case ClickButtonType.AddButton:

					Users.UsersList.Add(InputUsers);
					break;

				case ClickButtonType.UpdateButton:

					var users = Users.UsersList.Single(user => user.UserId == SelectedUsers.UserId);					
					users.UserId = InputUsers.UserId;
					users.UserName = InputUsers.UserName;
					users.UserAge = InputUsers.UserAge;
					users.UserGender = InputUsers.UserGender;
					users.UserAffiliation = InputUsers.UserAffiliation;
					
					break;

				case ClickButtonType.DeleteButton:

					users = Users.UsersList.Single(user => user.UserId == SelectedUsers.UserId);
					Users.UsersList.Remove(users);
					break;
			}
			return;
		}

		/// <summary>
		/// エラーダイアログ表示処理
		/// </summary>
		private void ShowErrorDialog(ErrorType errorTypeParam)
		{
			var messageText = "";

			switch (errorTypeParam)
			{
				case ErrorType.NotInputError:
					messageText = "すべての項目を入力してからOKボタンをクリックしてください";
					break;

				case ErrorType.SameIdError:
					messageText = "既に登録済みのIDは使用できません";
					break;

				case ErrorType.NotNumberError:
					messageText = "年齢の欄には数字のみ入力してください";
					break;

				default:
					break;
			}
			MessageBox.Show(messageText, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		/// <summary>
		/// 確認ダイアログ表示処理
		/// </summary>
		/// <returns></returns>
		private DialogResult ShowConfirmDialog()
		{
			var messageText = "";

			switch (ClickedButtonTypeParam)
			{
				case ClickButtonType.UpdateButton:
					messageText = "更新してもよろしいですか？";
					break;

				case ClickButtonType.DeleteButton:
					messageText = "削除してもよろしいですか？";
					break;

				default:
					break;
			}
			var result = MessageBox.Show(messageText, "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
			return result;
		}
	}
}
