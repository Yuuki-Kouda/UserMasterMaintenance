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
	public partial class UserMasterMaintenance_ListDisplay : Form
	{
		public UserMasterMaintenance_ListDisplay()
		{
			InitializeComponent();
		}

		enum Buttons
		{
			AddButton,
			UpdataButton,
			DeleteButton,
		}

		//チェックボックス判定
		private bool IsPutCheckMarkOnlyOnce { get; set; } = false;
		//押下ボタン判定
		private string IsDecisionPressButton { get; set; } = "";

		//初期表示
		//一覧データ取得
		//一覧データ表示

		/// <summary>
		/// 追加ボタンクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			//クリックボタン設定
			SetPushButton(Buttons.UpdataButton);

			//画面遷移
			TransitionScreen();
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

			//クリックボタン設定
			PropertiesClass properties = SetPushButton(Buttons.UpdataButton);

			//画面遷移
			TransitionScreen();

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

			//クリックボタン設定
			SetPushButton(Buttons.DeleteButton);

			//画面遷移
			TransitionScreen();
		}

		/// <summary>
		/// 一覧データ取得処理
		/// </summary>
		private void GetListData()
		{

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
		private void TransitionScreen()
		{
			using (var InputDisplay = new UserMasterMaintenance_InputDisplay())
			{
				InputDisplay.ShowDialog();
				return;
			}
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

				case Buttons.UpdataButton:
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
