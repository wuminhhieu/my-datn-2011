using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class RolesInfoBase
	{
		#region Fields

		private int roleid;
		private string name;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the RolesInfoBase class.
		/// </summary>
		public RolesInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the RolesInfoBase class.
		/// </summary>
		public RolesInfoBase(string name)
		{
			this.name = name;
		}

		/// <summary>
		/// Initializes a new instance of the RolesInfoBase class.
		/// </summary>
		public RolesInfoBase(int roleid, string name)
		{
			this.roleid = roleid;
			this.name = name;
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
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		#endregion
	}
}
