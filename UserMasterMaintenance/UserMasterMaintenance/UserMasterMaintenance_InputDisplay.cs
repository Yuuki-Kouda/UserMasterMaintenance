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
		public UserMasterMaintenance_InputDisplay(PropertiesClass properties)
		{
			InitializeComponent();
			
			//初期画面設定
			SetScreen(properties);
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
		/// OKボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			//未入力チェック、同IDチェック
			if(!ConfirmEntry())
			{
				ErrorDisplay errorDisplay = new ErrorDisplay();
				return;
			}

			if (ScreenParam != Screens.AddScreen)
			{
				//確認画面表示処理
				OutputConfirmationDiialog();
				return;
			}

			//データ追加処理
			AddDataToJson();
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
		public void SetScreen(PropertiesClass properties)
		{
			switch (properties.JudgeButtonPressed)
			{
				case PropertiesClass.Buttons.AddButton:
					//追加画面作成
					ScreenParam = Screens.AddScreen;

					break;

				case PropertiesClass.Buttons.UpdateButton:
					//更新画面作成
					ScreenParam = Screens.UpdateScreen;
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
		public bool ConfirmId(PropertiesClass properties)
		{
			var comfirmationSameId = false;

			//IDがあったら
			foreach(var usersData in properties.UsersDataList)
			{
				if (textBox6.Text == usersData.DataId)
				{
					comfirmationSameId = true;
					break;
				}			
			}
			return comfirmationSameId;
		}

		/// <summary>
		/// jsonファイルへ書き込み
		/// </summary>
		public void AddDataToJson()
		{
			//インスタンス生成
			PropertiesClass.UsersData usersObject = new PropertiesClass.UsersData();
			PropertiesClass.DepartmentsData departmentsObject = new PropertiesClass.DepartmentsData();

			//値の取得
			usersObject.DataId = textBox6.Text;
			usersObject.DataName = textBox7.Text;
			usersObject.DataAge = textBox8.Text;
			if (radioButton1.Checked)
			{
				usersObject.DataGender = true;
			}
			else
			{
				usersObject.DataGender = false;
			}

			departmentsObject.DataAffiliation = comboBox1.Text;

			//シリアライズ化
			var serializedUsersObject = JsonConvert.SerializeObject(usersObject, Formatting.Indented);
			var serializedDepartmentsObject = JsonConvert.SerializeObject(departmentsObject, Formatting.Indented);

			//ファイルへ書き込み
			using (StreamWriter streamWriter = 
				new StreamWriter(@"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\users.json", true))
			{
				streamWriter.Write(serializedUsersObject);
			}
			using (StreamWriter streamWriter =
				new StreamWriter(@"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\departments.json", true))
			{
				streamWriter.Write(serializedDepartmentsObject);
			}
			return;
		}

		//public void GetDepartmentsList()
		//{
		//	var departmentsList = new List<PropertiesClass.DepartmentsData>();

		//	try
		//	{
		//		using (StreamReader streamReader = new StreamReader(@"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\departments.json"))
		//		{
		//			var jsonDepartmentsData = streamReader.ReadToEnd();
		//		}
		//	}
		
	}
}
