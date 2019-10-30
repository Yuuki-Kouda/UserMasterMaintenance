using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace UserMasterMaintenance
{
	public partial class UserMasterMaintenance_ListDisplay : Form
	{
		public enum ErrorType
		{
			CheckBoxError
		}

		public enum JsonFileType
		{
			UserJsonType,
			DepartmentsJsonType
		}

		/// <summary>
		/// エラータイプパラメータ
		/// </summary>
		public ErrorType ErrorTypeParam { get; set; }

		/// <summary>
		/// jsonファイルタイプパラメータ
		/// </summary>
		private JsonFileType JsonFileTypeParam { get; set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public UserMasterMaintenance_ListDisplay()
		{
			InitializeComponent();

			//一覧データ取得
			JsonFileTypeParam = JsonFileType.UserJsonType;
			Deselialize(RoadFile());

			JsonFileTypeParam = JsonFileType.DepartmentsJsonType;
			Deselialize(RoadFile());
		}

		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UserMasterMaintenance_ListDisplay_Load(object sender, EventArgs e)
		{
			//一覧データ画面設定
			dataGridView1.DataSource = Users.UsersList;
		}

		/// <summary>
		/// 追加ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			var selectUsers = new Users();

			ShowEditScreen(selectUsers, UsersMasterMaintenance_InputDisplay.ClickButtonType.AddButton);
		}

		/// <summary>
		/// 更新ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			//チェックボックス判定
			if (!DetermineChecBox())
			{
				ShowErrorDialog(ErrorType.CheckBoxError);
				return;
			}
			var selectUsers = AcquireSelectUserDataFromDisplay();

			ShowEditScreen(selectUsers, UsersMasterMaintenance_InputDisplay.ClickButtonType.UpdateButton);
		}

		/// <summary>
		/// 削除ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			if (!DetermineChecBox())
			{
				ShowErrorDialog(ErrorType.CheckBoxError);
				return;
			}
			var selectUsers = AcquireSelectUserDataFromDisplay();

			ShowEditScreen(selectUsers, UsersMasterMaintenance_InputDisplay.ClickButtonType.DeleteButton);
		}

		/// <summary>
		/// 閉じるボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OnFromClosed(object sender, FormClosedEventArgs e)
		{
			//jsonファイルに保存
			JsonFileTypeParam = JsonFileType.UserJsonType;
			SaveFile(Selialize());

			JsonFileTypeParam = JsonFileType.DepartmentsJsonType;
			SaveFile(Selialize());
		}

		/// <summary>
		/// jsonファイルの読み込み
		/// </summary>
		/// <returns></returns>
		private string RoadFile()
		{
			var filePath = "";
			var DataListJsonText = "";
			System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();

			switch (JsonFileTypeParam)
			{
				case JsonFileType.UserJsonType:

					filePath = Path.GetFullPath("..\\users.json");
					using (StreamReader streamReader = new StreamReader(filePath, Encoding.GetEncoding("shift_jis")))
					{
						//デシリアライズ前テキスト
						DataListJsonText = streamReader.ReadToEnd();
					}
					break;

				case JsonFileType.DepartmentsJsonType:

					filePath = Path.GetFullPath(@"..\\departments.json");
					using (StreamReader streamReader = new StreamReader(filePath, Encoding.GetEncoding("shift_jis")))
					{
						//デシリアライズ前テキスト
						DataListJsonText = streamReader.ReadToEnd();
					}
					break;

				default:
					break;
			}
			return DataListJsonText;
		}

		/// <summary>
		/// デシリアライズ処理
		/// </summary>
		/// <param name="jsonText"></param>
		private void Deselialize(string jsonText)
		{
			switch (JsonFileTypeParam)
			{
				case JsonFileType.UserJsonType:

					//デシリアライズ
					Users.UsersList = JsonConvert.DeserializeObject<BindingList<Users>>(jsonText);
					break;

				case JsonFileType.DepartmentsJsonType:

					//デシリアライズ
					Departments.DepartmentsList = JsonConvert.DeserializeObject<List<Departments>>(jsonText);
					break;

				default:
					break;
			}
			return;
		}

		/// <summary>
		/// 編集画面表示処理
		/// </summary>
		private void ShowEditScreen(Users selectUsers, UsersMasterMaintenance_InputDisplay.ClickButtonType clickedButton)
		{
			UsersMasterMaintenance_InputDisplay inputDisplay
				= new UsersMasterMaintenance_InputDisplay(selectUsers, clickedButton);

			var result = inputDisplay.ShowDialog();
			return;
		}

		/// <summary>
		/// チェックボックス判定（チェックボックスを一つのみチェックの場合のみtrue）
		/// </summary>
		/// <returns></returns>
		public bool DetermineChecBox()
		{
			int CheckCount = 0;

			for (int i = 0; dataGridView1.Rows.Count > i; i++)
			{
				if (dataGridView1[0, i].Value == null) continue;

				if ((bool)dataGridView1[0, i].Value) CheckCount += 1;
			}
			if (CheckCount == 1) return true;
			return false;
		}

		/// <summary>
		/// 選択されたユーザーデータを一覧から取得する
		/// </summary>
		private Users AcquireSelectUserDataFromDisplay()
		{
			Users selectionUser = new Users();
			int row = new int();

			for (row = 0; dataGridView1.Rows.Count > row; row++)
			{
				if (dataGridView1[0, row].Value == null) continue;

				if ((bool)dataGridView1[0, row].Value) break;
			}
			selectionUser.UserId = (string)dataGridView1[1, row].Value;
			selectionUser.UserName = (string)dataGridView1[2, row].Value;
			selectionUser.UserAge = (int)dataGridView1[3, row].Value;
			selectionUser.UserGender = (string)dataGridView1[4, row].Value;
			selectionUser.UserAffiliation = (string)dataGridView1[5, row].Value;

			return selectionUser;
		}

		/// <summary>
		/// エラーダイアログ表示処理
		/// </summary>
		private void ShowErrorDialog(ErrorType errorTypeParam)
		{
			var messageText = "";

			switch (errorTypeParam)
			{
				case ErrorType.CheckBoxError:
					messageText = "データを一つのみ選択してください";
					break;

				default:
					break;
			}
			MessageBox.Show(messageText, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
			return;
		}

		/// <summary>
		/// シリアライズ処理
		/// </summary>
		/// <param name="DataList"></param>
		/// <returns></returns>
		private string Selialize()
		{
			var serializedJsonText = "";

			switch (JsonFileTypeParam)
			{
				case JsonFileType.UserJsonType:

					//シリアライズ化
					serializedJsonText = JsonConvert.SerializeObject(Users.UsersList, Formatting.Indented);
					break;

				case JsonFileType.DepartmentsJsonType:

					//シリアライズ化
					serializedJsonText = JsonConvert.SerializeObject(Departments.DepartmentsList, Formatting.Indented);
					break;

				default:
					break;
			}
			return serializedJsonText;
		}

		/// <summary>
		/// jsonファイルに保存処理
		/// </summary>
		/// <param name="jsonText"></param>
		private void SaveFile(string jsonText)
		{
			var filePath = "";

			switch (JsonFileTypeParam)
			{
				case JsonFileType.UserJsonType:

					filePath = Path.GetFullPath("..\\users.json");
					using (StreamWriter streamWriter = new StreamWriter(filePath, false, Encoding.UTF8))
					{
						streamWriter.Write(jsonText);
					}
					break;

				case JsonFileType.DepartmentsJsonType:

					filePath = Path.GetFullPath(@"..\\departments.json");
					using (StreamWriter streamWriter = new StreamWriter(filePath, false, Encoding.UTF8))
					{
						streamWriter.Write(jsonText);
					}
					break;

				default:
					break;
			}
			return;
		}
	}
}
