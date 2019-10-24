using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMasterMaintenance
{

	/// <summary>
	/// Usersクラス（users.json）
	/// </summary>
	public class Users
	{
		/// <summary>
		/// ID
		/// </summary>
		public string UserId { get; set; }

		/// <summary>
		/// 名前
		/// </summary>
		public string UserName { get; set; }

		/// <summary>
		/// 年齢
		/// </summary>
		public string UserAge { get; set; }

		/// <summary>
		/// 性別
		/// </summary>
		public string UserGender { get; set; }

		/// <summary>
		/// 所属
		/// </summary>
		public string UserAffiliation { get; set; }
	}
}
