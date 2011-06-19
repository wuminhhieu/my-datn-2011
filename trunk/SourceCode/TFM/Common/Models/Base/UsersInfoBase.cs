using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class UsersInfoBase
	{
		#region Fields

		private int userid;
		private string username;
		private string password;
		private int roleid;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UsersInfoBase class.
		/// </summary>
		public UsersInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the UsersInfoBase class.
		/// </summary>
		public UsersInfoBase(string username, string password, int roleid)
		{
			this.username = username;
			this.password = password;
			this.roleid = roleid;
		}

		/// <summary>
		/// Initializes a new instance of the UsersInfoBase class.
		/// </summary>
		public UsersInfoBase(int userid, string username, string password, int roleid)
		{
			this.userid = userid;
			this.username = username;
			this.password = password;
			this.roleid = roleid;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Userid value.
		/// </summary>
		public int Userid
		{
			get { return userid; }
			set { userid = value; }
		}

		/// <summary>
		/// Gets or sets the Username value.
		/// </summary>
		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		/// <summary>
		/// Gets or sets the Password value.
		/// </summary>
		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		/// <summary>
		/// Gets or sets the Roleid value.
		/// </summary>
		public int Roleid
		{
			get { return roleid; }
			set { roleid = value; }
		}

		#endregion
	}
}
