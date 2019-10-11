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

		/// <summary>
		/// 出力画面設定
		/// </summary>
		public void SetScreen(PropertiesClass properties)
		{
			switch (properties.JudgeButtonPressed)
			{
				case PropertiesClass.Buttons.AddButton:
					//追加画面作成

					break;

				case PropertiesClass.Buttons.UpdateButton:
					//更新画面作成
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
	}
}
