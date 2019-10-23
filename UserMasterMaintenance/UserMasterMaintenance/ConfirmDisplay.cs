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
	public partial class ConfirmDisplay : Form
	{
		public ConfirmDisplay()
		{
			InitializeComponent();

			//初期画面設定
			DialogResult dialogResult = SetScreen();

			//Yes,No判定
			if (dialogResult == DialogResult.No) return;

			//データ変更処理
			UpdateData();
		}

		public enum Screens
		{
			UpdateScreen,
			DeleteScreen,
		}

		/// <summary>
		/// 画面パラメータ
		/// </summary>
		public Screens ScreenParam { get; set; }

		/// <summary>
		/// 初期画面設定
		/// </summary>
		/// <param name="properties"></param>
		public DialogResult SetScreen()
		{
			DialogResult dialogResult = new DialogResult();

			return dialogResult;
		}

		/// <summary>
		/// データ変更処理
		/// </summary>
		public void UpdateData()
		{
			switch (ScreenParam)
			{

				case Screens.UpdateScreen:
					//更新処理

					break;

				case Screens.DeleteScreen:
					//削除処理

					break;
			}
			return;

		}
	}
}
