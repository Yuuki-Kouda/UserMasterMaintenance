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
		public UserMasterMaintenance_InputDisplay()
		{
			InitializeComponent();
			
			//初期画面設定
			SetScreen();
		}

		/// <summary>
		/// 出力画面設定
		/// </summary>
		public void SetScreen()
		{
			PropertiesClass properties = new PropertiesClass();

			switch (properties.JudgeButtonPressed)
			{
				case PropertiesClass.Buttons.AddButton:
					//追加画面作成

					break;

				case PropertiesClass.Buttons.UpdateButton:
					//更新画面作成
					textBox1.Text = properties.DataId;
					textBox2.Text = properties.DataName;
					textBox3.Text = properties.DataAge;
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
					textBox1.Text = properties.DataId;
					textBox2.Text = properties.DataName;
					textBox3.Text = properties.DataAge;
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

					textBox1.ReadOnly = true;
					textBox2.ReadOnly = true;
					textBox3.ReadOnly = true;
					radioButton1.AutoCheck = false;
					radioButton2.AutoCheck = false;
					comboBox1.Enabled = false;

					break;
			}
			return;
		}
	}
}
