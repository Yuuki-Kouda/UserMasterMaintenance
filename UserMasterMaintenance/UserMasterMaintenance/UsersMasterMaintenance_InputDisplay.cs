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
	public partial class UsersMasterMaintenance_InputDisplay : Form
	{
		public UsersMasterMaintenance_InputDisplay(UserMasterMaintenance_ListDisplay.Users users,
												   List<UserMasterMaintenance_ListDisplay.Users> usersList,
												   List<UserMasterMaintenance_ListDisplay.Departments> departmentsList,
												   UserMasterMaintenance_ListDisplay.ClickButtonType clickButtonTypeParam)
		{
			InitializeComponent();

			comboBox1.Items.AddRange(departmentsList.ToArray());

			IsClickedButtonTypeDecision(clickButtonTypeParam);

			DisplayToUser(users);

		}

		public enum ClickButtonType
		{
			AddButton,
			UpdateButton,
			DeleteButton,
		}

		/// <summary>
		/// クリックボタンタイプパラメータ
		/// </summary>
		public ClickButtonType ClickedButtonTypeParam { get; set; }

		/// <summary>
		/// OKボタンクリック時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button1_Click(object sender, EventArgs e)
		{
			switch (ClickedButtonTypeParam)
			{
				case ClickButtonType.AddButton:
					break;
				case ClickButtonType.UpdateButton:
					break;
				case ClickButtonType.DeleteButton:
					break;

				default:
					break;
			}
		}

		/// <summary>
		/// キャンセルボタンクリック時
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void button2_Click(object sender, EventArgs e)
		{
		}

		/// <summary>
		/// 画面設定処理
		/// </summary>
		/// <param name="users"></param>
		/// <param name="clickButtonTypeParam"></param>
		public void DisplayToUser(UserMasterMaintenance_ListDisplay.Users users)
		{
			switch (ClickedButtonTypeParam)
			{
				case ClickButtonType.AddButton:

					break;

				case ClickButtonType.UpdateButton:

					textBox1.Text = users.UserId;
					textBox2.Text = users.UserName;
					textBox3.Text = users.UserAge;
					if (users.UserGender == "男性")
					{
						radioButton1.Checked = true;
						radioButton2.Checked = false;
					}
					else
					{
						radioButton1.Checked = false;
						radioButton2.Checked = true;
					}
					comboBox1.Text = users.UserAffiliation;

					break;

				case ClickButtonType.ClickButtonType.DeleteButton:

					MakeInputDepartmentReadOnly();

					textBox1.Text = users.UserId;
					textBox2.Text = users.UserName;
					textBox3.Text = users.UserAge;
					if (users.UserGender == "男性")
					{
						radioButton1.Checked = true;
						radioButton2.Checked = false;
					}
					else
					{
						radioButton1.Checked = false;
						radioButton2.Checked = true;
					}
					comboBox1.Text = users.UserAffiliation;

					break;

				default:
					break;
			}
			return;
		}

		/// <summary>
		/// 一覧画面押下ボタン判定
		/// </summary>
		/// <param name="clickButtonTypeParam"></param>
		public void IsClickedButtonTypeDecision(UserMasterMaintenance_ListDisplay.ClickButtonType clickButtonTypeParam)
		{
			switch (clickButtonTypeParam)
			{
				case UserMasterMaintenance_ListDisplay.ClickButtonType.AddButton:

					ClickedButtonTypeParam = ClickButtonType.AddButton;
					break;

				case UserMasterMaintenance_ListDisplay.ClickButtonType.UpdateButton:

					ClickedButtonTypeParam = ClickButtonType.UpdateButton;
					break;

				case UserMasterMaintenance_ListDisplay.ClickButtonType.DeleteButton:

					ClickedButtonTypeParam = ClickButtonType.DeleteButton;
					break;

				default:
					break;
			}
			return;
		}

		/// <summary>
		/// 入力項目入力不可処理
		/// </summary>
		public void MakeInputDepartmentReadOnly()
		{
			textBox1.ReadOnly = true;
			textBox2.ReadOnly = true;
			textBox3.ReadOnly = true;
			radioButton1.Enabled = false;
			radioButton1.Enabled = false;
			comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
		}

	}
}
