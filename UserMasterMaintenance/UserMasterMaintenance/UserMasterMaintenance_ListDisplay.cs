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
		/// Usersリスト（一覧）
		/// </summary>
		private List<Users> UsersList { get; set; }

		/// <summary>
		/// 所属リスト（コンボボックス一覧）
		/// </summary>
		private List<Departments> DepartmentsList { get; set; }

		/// <summary>
		/// jsonファイルタイプパラメータ
		/// </summary>
		private JsonFileType JsonFileTypeParam { get; set; }

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
			usersBindingSource.DataSource = UsersList;
		}

		/// <summary>
		/// 追加ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			var selectUsers = new Users();

			//一覧からすべてのユーザー情報を取得
			UsersList = usersBindingSource.DataSource as List<Users>;

			ShowEditScreen(selectUsers, UsersMasterMaintenance_InputDisplay.ClickButtonType.AddButton);

			//一覧データ画面設定
			usersBindingSource.DataSource = UsersList;
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

			//一覧から選択ユーザー情報を取得
			var selectUsers = AcquireSelectUserDataFromDisplay();

			//一覧からすべてのユーザー情報を取得
			UsersList = usersBindingSource.DataSource as List<Users>;

			ShowEditScreen(selectUsers, UsersMasterMaintenance_InputDisplay.ClickButtonType.UpdateButton);

			//一覧データ画面設定
			usersBindingSource.DataSource = UsersList;
		}

		/// <summary>
		/// 削除ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			//チェックボックス判定
			if (!DetermineChecBox())
			{
				ShowErrorDialog(ErrorType.CheckBoxError);
				return;
			}

			//一覧から選択ユーザー情報を取得
			var selectUsers = AcquireSelectUserDataFromDisplay();

			//一覧からすべてのユーザー情報を取得
			UsersList = usersBindingSource.DataSource as List<Users>;

			ShowEditScreen(selectUsers, UsersMasterMaintenance_InputDisplay.ClickButtonType.DeleteButton);

			//一覧データ画面設定
			usersBindingSource.DataSource = UsersList;
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
			var JsonFilePath = "";
			var DataListJsonText = "";

			switch (JsonFileTypeParam)
			{
				case JsonFileType.UserJsonType:
					JsonFilePath = @"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\users.json";
					break;

				case JsonFileType.DepartmentsJsonType:
					JsonFilePath = @"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\departments.json";
					break;

				default:
					break;
			}

			using (StreamReader streamReader = new StreamReader(JsonFilePath, Encoding.GetEncoding("shift_jis")))
			{
				//デシリアライズ前テキスト
				DataListJsonText = streamReader.ReadToEnd();
			}
			return DataListJsonText;
		}

		/// <summary>
		/// デシリアライズ処理
		/// </summary>
		/// <param name="jsonText"></param>
		public void Deselialize(string jsonText)
		{
			switch (JsonFileTypeParam)
			{
				case JsonFileType.UserJsonType:

					//デシリアライズ
					UsersList = JsonConvert.DeserializeObject<List<Users>>(jsonText);
					break;

				case JsonFileType.DepartmentsJsonType:

					//デシリアライズ
					DepartmentsList = JsonConvert.DeserializeObject<List<Departments>>(jsonText);
					break;

				default:
					break;
			}
			return;
		}

		/// <summary>
		/// 編集画面表示処理
		/// </summary>
		public void ShowEditScreen(Users selectUsers)
		{
			UsersMasterMaintenance_InputDisplay inputDisplay
				= new UsersMasterMaintenance_InputDisplay(selectUsers, UsersList, DepartmentsList, ClickedButtonTypeParam);
			
			UsersList = inputDisplay.ShowDialog();
			inputDisplay.Dispose();

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

				if (dataGridView1[0, i].Value.ToString() == "true") CheckCount += 1;
			}

			if (CheckCount == 1) return true;
			return false;
		}

		/// <summary>
		/// 選択されたユーザーデータを一覧から取得する
		/// </summary>
		public Users AcquireSelectUserDataFromDisplay()
		{
			Users selectionUser = new Users();
			int row = 0;

			for (row = 0; dataGridView1.Rows.Count > row; row++)
			{
				if (dataGridView1[0, row].Value == null) continue;

				if (dataGridView1[0, row].Value.ToString() == "true") break;
			}

			selectionUser.UserId = dataGridView1[1, row].Value.ToString();
			selectionUser.UserName = dataGridView1[2, row].Value.ToString();
			selectionUser.UserAge = dataGridView1[3, row].Value.ToString();
			selectionUser.UserGender = dataGridView1[4, row].Value.ToString();
			selectionUser.UserAffiliation = dataGridView1[5, row].Value.ToString();

			return selectionUser;
		}

		/// <summary>
		/// エラーダイアログ表示処理
		/// </summary>
		public void ShowErrorDialog()
		{
			ErrorDisplay errorDisplay = new ErrorDisplay(ErrorTypeParam);
			errorDisplay.ShowDialog();
			errorDisplay.Dispose();
			return;
		}

		/// <summary>
		/// シリアライズ処理
		/// </summary>
		/// <param name="DataList"></param>
		/// <returns></returns>
		public string Selialize()
		{
			var serializedJsonText = "";

			switch (JsonFileTypeParam)
			{
				case JsonFileType.UserJsonType:

					//シリアライズ化
					serializedJsonText = JsonConvert.SerializeObject(UsersList, Formatting.Indented);
					break;

				case JsonFileType.DepartmentsJsonType:

					//シリアライズ化
					serializedJsonText = JsonConvert.SerializeObject(DepartmentsList, Formatting.Indented);
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
		public void SaveFile(string jsonText)
		{
			var jsonFilePath = "";

			switch (JsonFileTypeParam)
			{
				case JsonFileType.UserJsonType:
					jsonFilePath = @"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\users.json";
					break;

				case JsonFileType.DepartmentsJsonType:
					jsonFilePath = @"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\departments.json";
					break;

				default:
					break;
			}

			//ファイルへ書き込み
			using (StreamWriter streamWriter =
				new StreamWriter(jsonFilePath, false, Encoding.UTF8))
			{
				streamWriter.Write(jsonText);
			}
			return;
		}

	}
}
