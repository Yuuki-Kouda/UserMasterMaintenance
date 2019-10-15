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
			if(!ConfirmEntry() || !ConfirmId())
			{
				ErrorDisplay errorDisplay = new ErrorDisplay();
				return;
			}
		
			//確認画面表示処理
			OutputConfirmationDiialog();
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
					textBox6.Text = properties.DataId;
					textBox7.Text = properties.DataName;
					textBox8.Text = properties.DataAge;
					if (properties.DataGender)
					{
						radioButton1.Checked = true;
						radioButton2.Checked = false;
					}
					else
					{
						radioButton1.Checked = false;
						radioButton2.Checked = true;
					}
					comboBox1.Text = properties.DataAffiliation;

					break;

				case PropertiesClass.Buttons.DeleteButton:
					//削除画面設定
					ScreenParam = Screens.DeleteScreen;
					textBox6.Text = properties.DataId;
					textBox7.Text = properties.DataName;
					textBox8.Text = properties.DataAge;
					if (properties.DataGender)
					{
						radioButton1.Checked = true;
						radioButton2.Checked = false;
					}
					else
					{
						radioButton1.Checked = false;
						radioButton2.Checked = true;
					}
					comboBox1.Text = properties.DataAffiliation;

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
			//IDがjsonにあったら
			return false;

			//IDがなかったら
			return true;
		}
	}
}
