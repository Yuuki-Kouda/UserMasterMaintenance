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

	public partial class UserMasterMaintenance_InputDisplay : Form
	{
		public UserMasterMaintenance_InputDisplay(PropertiesClass propertiesSent)
		{
			InitializeComponent();

			properties = propertiesSent;
			
		}

		public enum Screens
		{
			AddScreen,
			UpdateScreen,
			DeleteScreen,
		}

		/// <summary>
		/// 画面パラメータ
		/// </summary>
		public Screens ScreenParam { get; set; }

		/// <summary>
		/// PropertiesClassのインスタンス
		/// </summary>
		public PropertiesClass properties = new PropertiesClass();

		private void UserMasterMaintenance_InputDisplay_Load(object sender, EventArgs e)
		{
			//初期画面設定
			SetScreen();
		}

		/// <summary>
		/// OKボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			//未入力チェック、同IDチェック
			if(!ConfirmEntry() || !ConfirmId())
			{
				ErrorDisplay errorDisplay = new ErrorDisplay(properties);
				return;
			}

			if (ScreenParam != Screens.AddScreen)
			{
				//確認画面表示処理
				OutputConfirmationDiialog();
				return;
			}

			//データ追加処理
			AddDataToList();

			UserMasterMaintenance_ListDisplay userMasterMaintenance_ListDisplay = new UserMasterMaintenance_ListDisplay();
			userMasterMaintenance_ListDisplay.Show();
			return;
		}
		
		/// <summary>
		/// キャンセルボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			//このフォームを閉じたい
		}

		/// <summary>
		/// 出力画面設定
		/// </summary>
		public void SetScreen()
		{
			//コンボボックスの設定
			foreach(var departMentsDataList in properties.DepartmentsList)
			{
				comboBox1.Items.Add(departMentsDataList);
			}

			switch (properties.JudgeButtonPressed)
			{
				case PropertiesClass.Buttons.AddButton:
					//追加画面作成
					ScreenParam = Screens.AddScreen;
					properties.IsDecisionScreenTransition = PropertiesClass.Screens.AddDisplay;

					break;

				case PropertiesClass.Buttons.UpdateButton:
					//更新画面作成
					ScreenParam = Screens.UpdateScreen;
					properties.IsDecisionScreenTransition = PropertiesClass.Screens.UpdateDisplay;

					textBox6.Text = properties.PropertyId;
					textBox7.Text = properties.PropertyName;
					textBox8.Text = properties.PropertyAge;
					if (properties.PropertyGender)
					{
						radioButton1.Checked = true;
						radioButton2.Checked = false;
					}
					else
					{
						radioButton1.Checked = false;
						radioButton2.Checked = true;
					}
					comboBox1.Text = properties.PropertyAffiliation;

					break;

				case PropertiesClass.Buttons.DeleteButton:
					//削除画面設定
					ScreenParam = Screens.DeleteScreen;
					properties.IsDecisionScreenTransition = PropertiesClass.Screens.DeleteDisplay;

					textBox6.Text = properties.PropertyId;
					textBox7.Text = properties.PropertyName;
					textBox8.Text = properties.PropertyAge;
					if (properties.PropertyGender)
					{
						radioButton1.Checked = true;
						radioButton2.Checked = false;
					}
					else
					{
						radioButton1.Checked = false;
						radioButton2.Checked = true;
					}
					comboBox1.Text = properties.PropertyAffiliation;

					textBox6.ReadOnly = true;
					textBox7.ReadOnly = true;
					textBox8.ReadOnly = true;
					radioButton1.AutoCheck = false;
					radioButton2.AutoCheck = false;
					comboBox1.Enabled = false;

					break;
			}
			return;
		}

		/// <summary>
		/// 確認画面表示処理
		/// </summary>
		public void OutputConfirmationDiialog()
		{
			switch (ScreenParam)
			{
				case Screens.AddScreen:
					//何もしない
					break;

				case Screens.UpdateScreen:
					//確認ポップへ
					break;

				case Screens.DeleteScreen:
					//確認ポップへ
					break;
			}
		}

		/// <summary>
		/// 未入力チェック
		/// </summary>
		/// <returns></returns>
		public bool ConfirmEntry()
		{
			if(string.IsNullOrEmpty(textBox6.Text) || 
				string.IsNullOrEmpty(textBox7.Text) || 
				string.IsNullOrEmpty(textBox8.Text) || 
				string.IsNullOrEmpty(comboBox1.Text))
			{
				return false;
			}
			return true;
		}

		/// <summary>
		/// 同IDチェック
		/// </summary>
		/// <returns></returns>
		public bool ConfirmId()
		{
			var comfirmationSameId = true;

			//IDがあったら
			foreach(var usersData in properties.UsersDataList)
			{
				if (textBox6.Text == usersData.DataId)
				{
					comfirmationSameId = false;
					break;
				}			
			}
			return comfirmationSameId;
		}

		/// <summary>
		/// データの追加
		/// </summary>
		public void AddDataToList()
		{
			PropertiesClass.UsersData usersData = new PropertiesClass.UsersData();

			usersData.DataId = textBox6.Text;
			usersData.DataName = textBox7.Text;
			usersData.DataAge = textBox8.Text;
			if (radioButton1.Checked) usersData.DataGender = "男性";
			else usersData.DataGender = "女性";
			usersData.DataAffiliation = comboBox1.SelectedItem.ToString();

			properties.UsersDataList.Add(usersData);

			////インスタンス生成
			//PropertiesClass.UsersData usersObject = new PropertiesClass.UsersData();
			//PropertiesClass.DepartmentsData departmentsObject = new PropertiesClass.DepartmentsData();

			////値の取得
			//usersObject.DataId = textBox6.Text;
			//usersObject.DataName = textBox7.Text;
			//usersObject.DataAge = textBox8.Text;
			//if (radioButton1.Checked)
			//{
			//	usersObject.DataGender = true;
			//}
			//else
			//{
			//	usersObject.DataGender = false;
			//}

			//departmentsObject.DataAffiliation = comboBox1.Text;

			////シリアライズ化
			//var serializedUsersObject = JsonConvert.SerializeObject(usersObject, Formatting.Indented);
			//var serializedDepartmentsObject = JsonConvert.SerializeObject(departmentsObject, Formatting.Indented);

			////ファイルへ書き込み
			//using (StreamWriter streamWriter = 
			//	new StreamWriter(@"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\users.json", true))
			//{
			//	streamWriter.Write(serializedUsersObject);
			//}
			//using (StreamWriter streamWriter =
			//	new StreamWriter(@"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\departments.json", true))
			//{
			//	streamWriter.Write(serializedDepartmentsObject);
			//}
			return;
		}
	}
}
