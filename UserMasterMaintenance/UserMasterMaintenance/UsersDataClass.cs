using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMasterMaintenance
{
	class UsersDataClass
	{
		/// <summary>
		/// チェックボックス
		/// </summary>
		public bool CheckBox { get; set; }

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
		public int DataAge { get; set; }

		/// <summary>
		/// 性別
		/// </summary>
		public string DataGender { get; set; }

		/// <summary>
		/// 所属
		/// </summary>
		public string DataAffiliation { get; set; }
	}
}
