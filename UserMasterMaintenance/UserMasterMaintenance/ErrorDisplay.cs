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
	public partial class ErrorDisplay : Form
	{
		public ErrorDisplay()
		{
			InitializeComponent();

			//メッセージ出力
			OutputMessage();
		}

		/// <summary>
		/// メッセージ出力処理
		/// </summary>
		public void OutputMessage ()
		{
			var dialogResult = MessageBox.Show("未入力項目または既に同じIDで登録済みです", 
				"エラー", 
				MessageBoxButtons.OK, 
				MessageBoxIcon.Error);
			return;
		}
	}
}
