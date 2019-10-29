using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace UserMasterMaintenance
{
	/// <summary>
	/// Usersクラス（users.json）
	/// </summary>
	public class Users : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		/// <summary>
		/// Userリスト
		/// </summary>
		public static BindingList<Users> UsersList { get; set; }

		private string _UserId;
		private string _UserName;
		private int _UserAge;
		private string _UserGender;
		private string _UserAffiliation;

		/// <summary>
		/// ID
		/// </summary>
		public string UserId
		{
			get
			{
				return _UserId;
			}
			set
			{
				if (_UserId == value) return;
				_UserId = value;
				NotifyPropertyChanged(nameof(UserId));
			}
		}

		/// <summary>
		/// 名前
		/// </summary>
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if (_UserName == value) return;
				_UserName = value;
				NotifyPropertyChanged(nameof(UserName));
			}
		}

		/// <summary>
		/// 年齢
		/// </summary>
		public int UserAge
		{
			get
			{
				return _UserAge;
			}
			set
			{
				if (_UserAge == value) return;
				_UserAge = value;
				NotifyPropertyChanged(nameof(UserAge));
			}
		}

		/// <summary>
		/// 性別
		/// </summary>
		public string UserGender
		{
			get
			{
				return _UserGender;
			}
			set
			{
				if (_UserGender == value) return;
				_UserGender = value;
				NotifyPropertyChanged(nameof(UserGender));
			}
		}

		/// <summary>
		/// 所属
		/// </summary>
		public string UserAffiliation
		{
			get
			{
				return _UserAffiliation;
			}
			set
			{
				if (_UserAffiliation == value) return;
				_UserAffiliation = value;
				NotifyPropertyChanged(nameof(UserAffiliation));
			}
		}
	}
}
