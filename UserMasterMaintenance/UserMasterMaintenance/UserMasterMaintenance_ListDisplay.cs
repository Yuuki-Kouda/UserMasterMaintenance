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
		}

		enum Buttons
		{
			AddButton,
			UpdateButton,
			DeleteButton,
		}

		//チェックボックス判定
		private bool IsPutCheckMarkOnlyOnce { get; set; } = false;
		//押下ボタン判定
		private string IsDecisionPressButton { get; set; } = "";

		private void UserMasterMaintenance_ListDisplay_Load(object sender, EventArgs e)
		{
			//初期表示
			PropertiesClass properties = new PropertiesClass();

			//一覧データ取得
			//一覧データ表示

		}

		/// <summary>
		/// 追加ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			//画面遷移
			TransitionScreen(SetPushButton(Buttons.AddButton));
		}

		/// <summary>
		/// 更新ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
			//チェックボックス判定
			//if (!IsPutCheckMarkOnlyOnce) return;

			//画面遷移
			TransitionScreen(SetPushButton(Buttons.UpdateButton));

		}

		/// <summary>
		/// 削除ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button3_Click(object sender, EventArgs e)
		{
			//チェックボックス判定
			//if (!IsPutCheckMarkOnlyOnce) return;

			//画面遷移
			TransitionScreen(SetPushButton(Buttons.DeleteButton));
		}

		/// <summary>
		/// 一覧データ取得処理
		/// </summary>
		private void GetListData()
		{
			var usersJsonFilePath = @"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\users.json";
			var departmentsJsonFilePath = @"C:\Users\Kouda\Desktop\幸田有生_研修\ユーザマスタメンテ\UserMasterMaintenance\UserMasterMaintenance\UserMasterMaintenance\departments.json";


		}

		/// <summary>
		/// 一覧データ表示処理
		/// </summary>
		private void ShowListData()
		{

		}

		/// <summary>
		/// 画面遷移処理
		/// </summary>
		private void TransitionScreen(PropertiesClass properties)
		{
			UserMasterMaintenance_InputDisplay inputDisplay = new UserMasterMaintenance_InputDisplay(properties);
			//listDisplay.Hide();
			inputDisplay.ShowDialog();
			return;
		}

		/// <summary>
		/// クリックボタン設定
		/// </summary>
		/// <param name="button"></param>
		private PropertiesClass SetPushButton(Buttons button)
		{
			PropertiesClass properties = new PropertiesClass();

			switch (button)
			{
				case Buttons.AddButton:
					properties.JudgeButtonPressed = PropertiesClass.Buttons.AddButton;
					break;

				case Buttons.UpdateButton:
					properties.JudgeButtonPressed = PropertiesClass.Buttons.UpdateButton;
					break;

				case Buttons.DeleteButton:
					properties.JudgeButtonPressed = PropertiesClass.Buttons.DeleteButton;
					break;
			}
			return properties;
		}

	}
}
