using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class StationInfoBase
	{
		#region Fields

		private int stationid;
		private string name;
		private string province;
		private string company;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the StationInfoBase class.
		/// </summary>
		public StationInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the StationInfoBase class.
		/// </summary>
		public StationInfoBase(int stationid, string name, string province, string company)
		{
			this.stationid = stationid;
			this.name = name;
			this.province = province;
			this.company = company;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Stationid value.
		/// </summary>
		public int Stationid
		{
			get { return stationid; }
			set { stationid = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Province value.
		/// </summary>
		public string Province
		{
			get { return province; }
			set { province = value; }
		}

		/// <summary>
		/// Gets or sets the Company value.
		/// </summary>
		public string Company
		{
			get { return company; }
			set { company = value; }
		}

		#endregion
	}
}
