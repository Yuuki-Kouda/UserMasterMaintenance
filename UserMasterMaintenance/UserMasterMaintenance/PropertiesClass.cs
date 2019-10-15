using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMasterMaintenance
{
	public class PropertiesClass
	{
		public enum Screens
		{
			ListDisplay,
			AddDisplay,
			UpdateDisplay,
			DeleteDisplay,
			ErrorPopDisplay,
			ConfirmationPopDisplay,
		}

		public enum Buttons
		{
			AddButton,
			UpdateButton,
			DeleteButton,
		}

		/// <summary>
		/// 画面遷移判定プロパティ
		/// </summary>
		public Screens IsDecisionScreenTransition { get; set; }

		/// <summary>
		/// 押下ボタン判定プロパティ
		/// </summary>
		public Buttons JudgeButtonPressed { get; set; }

		public class AccountData
		{
			/// <summary>
			/// ID
			/// </summary>
			public string DataId { get; set; }

			/// <summary>
			/// 名前
			/// </summary>
			public string DataName { get; set; }

			/// <summary>
			/// 年齢
			/// </summary>
			public string DataAge { get; set; }

			/// <summary>
			/// 性別
			/// </summary>
			public bool DataGender { get; set; }

			/// <summary>
			/// 所属
			/// </summary>
			public string DataAffiliation { get; set; }
		}
	}
}
