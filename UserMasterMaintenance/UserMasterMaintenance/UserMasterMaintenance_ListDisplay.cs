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
		public UserMasterMaintenance_ListDisplay()
		{
			InitializeComponent();

			//一覧データ取得
			GetListData();

			//一覧データ表示
			ShowListData();

		}

		public enum ScreenTransutionTarget
		{
			NoneScreen,
			AddScreen,
			UpdateScreen,
			DeleteScreen,
			ErrorScreen,
		}

		/// <summary>
		/// 押下ボタン判定
		/// </summary>
		public string IsDecisionPressButton { get; set; } = "";

		/// <summary>
		/// 遷移先画面パラメータ(Error)
		/// </summary>
		public ScreenTransutionTarget TargetErrorScreen { get; set; } = ScreenTransutionTarget.NoneScreen;

		/// <summary>
		/// PropertiesClassのインスタンス
		/// </summary>
		public PropertiesClass properties = new PropertiesClass();

		private List<UsersDataClass> usersDataList = new List<UsersDataClass>();

		/// <summary>
		/// ロード
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void UserMasterMaintenance_ListDisplay_Load(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 追加ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			//画面遷移
			TransitionScreen(SetPushButton(ScreenTransutionTarget.AddScreen));
		}

		/// <summary>
		/// 更新ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			//チェックボックス判定
			if (!IsPutChekckMarkOnlyOnce())
			{
				//画面遷移
				TargetErrorScreen = ScreenTransutionTarget.ErrorScreen;
				TransitionScreen(SetPushButton(ScreenTransutionTarget.ErrorScreen));
				TargetErrorScreen = ScreenTransutionTarget.NoneScreen;
				return;
			}

			//画面遷移
			TransitionScreen(SetPushButton(ScreenTransutionTarget.UpdateScreen));

		}

		/// <summary>
		/// 削除ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			//チェックボックス判定
			if (!IsPutChekckMarkOnlyOnce())
			{
				//画面遷移
				TargetErrorScreen = ScreenTransutionTarget.ErrorScreen;
				TransitionScreen(SetPushButton(ScreenTransutionTarget.ErrorScreen));
				TargetErrorScreen = ScreenTransutionTarget.NoneScreen;
				return;
			}

			//画面遷移
			TransitionScreen(SetPushButton(ScreenTransutionTarget.DeleteScreen));
		
		}

		/// <summary>
		/// 一覧データ取得処理
		/// </summary>
		public void GetListData()
		{
			var usersJsonFilePath = @"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\users.json";
			var departmentsJsonFilePath = @"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\departments.json";
			string usersDataListJsonText = "";
			string departmentsDataListJsonText = "";

			using (StreamReader streamReader = new StreamReader(usersJsonFilePath, Encoding.GetEncoding("shift_jis")))
			{
				usersDataListJsonText = streamReader.ReadToEnd();
			}
			using (StreamReader streamReader = new StreamReader(departmentsJsonFilePath, Encoding.GetEncoding("shift_jis")))
			{
				departmentsDataListJsonText = streamReader.ReadToEnd();
			}

			//デシリアライズ
			properties.UsersDataList = JsonConvert.DeserializeObject<List<PropertiesClass.UsersData>>(usersDataListJsonText);
			properties.DepartmentsList = JsonConvert.DeserializeObject<List<PropertiesClass.DepartmentsData>>(departmentsDataListJsonText);

			return;
		}

		/// <summary>
		/// 一覧データ表示処理
		/// </summary>
		public void ShowListData()
		{

			foreach(var usersData in properties.UsersDataList)
			{
				UsersDataClass usersDataClass = new UsersDataClass();

				usersDataClass.CheckBox = false;
				usersDataClass.DataId = usersData.DataId;
				usersDataClass.DataName = usersData.DataName;
				usersDataClass.DataAge = int.Parse(usersData.DataAge);
				usersDataClass.DataGender = usersData.DataGender;
				usersDataClass.DataAffiliation = usersData.DataAffiliation;

				usersDataList.Add(usersDataClass);
			}

			usersDataClassBindingSource.DataSource = usersDataList;

			var gender = "";
			
			//foreach (var usersData in properties.UsersDataList)
			//{
			//	if (usersData.DataGender)
			//	{
			//		gender = "男性";
			//	}
			//	else
			//	{
			//		gender = "女性";
			//	}

			//	dataGridView1.Rows.Add(false,
			//							usersData.DataId,
			//							usersData.DataName,
			//							usersData.DataAge,
			//							gender,
			//							usersData.DataAffiliation);
			//}
			return;
		}

		/// <summary>
		/// 画面遷移処理
		/// </summary>
		public void TransitionScreen(PropertiesClass properties)
		{
			properties.IsDecisionScreenTransition = PropertiesClass.Screens.ListDisplay;

			if(TargetErrorScreen == ScreenTransutionTarget.ErrorScreen)
			{
				ErrorDisplay errorDisplay = new ErrorDisplay(properties);
			}
			else
			{
				UserMasterMaintenance_InputDisplay inputDisplay = new UserMasterMaintenance_InputDisplay(properties);
				inputDisplay.Show();
			}
			return;
		}

		/// <summary>
		/// クリックボタン設定
		/// </summary>
		/// <param name="button"></param>
		public PropertiesClass SetPushButton(ScreenTransutionTarget targetScreen)
		{
			switch (targetScreen)
			{
				case ScreenTransutionTarget.AddScreen:
					properties.JudgeButtonPressed = PropertiesClass.Buttons.AddButton;
					break;

				case ScreenTransutionTarget.UpdateScreen:
					properties.JudgeButtonPressed = PropertiesClass.Buttons.UpdateButton;
					break;

				case ScreenTransutionTarget.DeleteScreen:
					properties.JudgeButtonPressed = PropertiesClass.Buttons.DeleteButton;
					break;

				case ScreenTransutionTarget.ErrorScreen:
					break;
			}
			return properties;
		}

		/// <summary>
		/// チェックボックス判定
		/// </summary>
		/// <returns></returns>
		public bool IsPutChekckMarkOnlyOnce()
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

		private void UserMasterMaintenance_ListDisplay_FormClosing(object sender, FormClosingEventArgs e)
		{
			//properties.UsersDataList.Remove(null);

			//シリアライズ化
			var serializedUsersObject = JsonConvert.SerializeObject(properties.UsersDataList, Formatting.Indented);
			var serializedDepartmentsObject = JsonConvert.SerializeObject(properties.DepartmentsList, Formatting.Indented);

			//ファイルへ書き込み
			using (StreamWriter streamWriter =
				new StreamWriter(@"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\users.json", false, Encoding.UTF8))
			{
				streamWriter.Write(serializedUsersObject);
			}
			using (StreamWriter streamWriter =
				new StreamWriter(@"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\departments.json", false, Encoding.UTF8))
			{
				streamWriter.Write(serializedDepartmentsObject);
			}
		}
	}
}
