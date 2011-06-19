using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class RolepermissionsInfoBase
	{
		#region Fields

		private int roleid;
		private string permission;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RolepermissionsInfoBase class.
		/// </summary>
		public RolepermissionsInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the RolepermissionsInfoBase class.
		/// </summary>
		public RolepermissionsInfoBase(string permission)
		{
			this.permission = permission;
		}

		/// <summary>
		/// Initializes a new instance of the RolepermissionsInfoBase class.
		/// </summary>
		public RolepermissionsInfoBase(int roleid, string permission)
		{
			this.roleid = roleid;
			this.permission = permission;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Roleid value.
		/// </summary>
		public int Roleid
		{
			get { return roleid; }
			set { roleid = value; }
		}

		/// <summary>
		/// Gets or sets the Permission value.
		/// </summary>
		public string Permission
		{
			get { return permission; }
			set { permission = value; }
		}

		#endregion
	}
}
