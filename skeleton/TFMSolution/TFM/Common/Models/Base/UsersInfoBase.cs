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
		private int created_date;
		private int last_login;
		private int last_logout;

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
		public UsersInfoBase(string username, string password, int roleid, int created_date, int last_login, int last_logout)
		{
			this.username = username;
			this.password = password;
			this.roleid = roleid;
			this.created_date = created_date;
			this.last_login = last_login;
			this.last_logout = last_logout;
		}

		/// <summary>
		/// Initializes a new instance of the UsersInfoBase class.
		/// </summary>
		public UsersInfoBase(int userid, string username, string password, int roleid, int created_date, int last_login, int last_logout)
		{
			this.userid = userid;
			this.username = username;
			this.password = password;
			this.roleid = roleid;
			this.created_date = created_date;
			this.last_login = last_login;
			this.last_logout = last_logout;
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

		/// <summary>
		/// Gets or sets the Created_date value.
		/// </summary>
		public int Created_date
		{
			get { return created_date; }
			set { created_date = value; }
		}

		/// <summary>
		/// Gets or sets the Last_login value.
		/// </summary>
		public int Last_login
		{
			get { return last_login; }
			set { last_login = value; }
		}

		/// <summary>
		/// Gets or sets the Last_logout value.
		/// </summary>
		public int Last_logout
		{
			get { return last_logout; }
			set { last_logout = value; }
		}

		#endregion
	}
}
