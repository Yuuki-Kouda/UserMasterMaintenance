using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMasterMaintenance
{
	/// <summary>
	/// Departmentsクラス（departments.json）
	/// </summary>
	public class Departments
	{
		/// <summary>
		/// 所属リスト
		/// </summary>
		public static List<Departments> DepartmentsList { get; set; }

		/// <summary>
		/// 所属
		/// </summary>
		public string Department { get; set; }
	}
}
