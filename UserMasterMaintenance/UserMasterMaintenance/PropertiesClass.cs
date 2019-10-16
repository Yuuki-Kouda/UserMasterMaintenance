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
		/// 画面遷移判定
		/// </summary>
		public Screens IsDecisionScreenTransition { get; set; }

		/// <summary>
		/// 押下ボタン判定
		/// </summary>
		public Buttons JudgeButtonPressed { get; set; }

			/// <summary>
			/// ID
			/// </summary>
			public string PropertyId { get; set; }

			/// <summary>
			/// 名前
			/// </summary>
			public string PropertyName { get; set; }

			/// <summary>
			/// 年齢
			/// </summary>
			public string PropertyAge { get; set; }

			/// <summary>
			/// 性別
			/// </summary>
			public bool PropertyGender { get; set; }

			/// <summary>
			/// 所属
			/// </summary>
			public string PropertyAffiliation { get; set; }

		/// <summary>
		/// users.jsonデータ
		/// </summary>
		public class UsersData
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

		/// <summary>
		/// departments.jsonデータ
		/// </summary>
		public class DepartmentsData
		{
			/// <summary>
			/// 所属
			/// </summary>
			public string DataAffiliation { get; set; }
		}

		/// <summary>
		/// ユーザー情報リスト
		/// </summary>
		public List<UsersData> UsersDataList { get; set; }

		/// <summary>
		/// 所属情報リスト
		/// </summary>
		public List<DepartmentsData> DepartmentsList { get; set; }
	}
}
