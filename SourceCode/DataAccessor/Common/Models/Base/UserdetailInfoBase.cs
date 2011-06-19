using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class UserdetailInfoBase
	{
		#region Fields

		private int userid;
		private string fullname;
		private string email;
		private string address;
		private string phone;
		private string company;
		private string title;
		private string cmnd;
		private string station;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the UserdetailInfoBase class.
		/// </summary>
		public UserdetailInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the UserdetailInfoBase class.
		/// </summary>
		public UserdetailInfoBase(string fullname, string email, string address, string phone, string company, string title, string cmnd, string station)
		{
			this.fullname = fullname;
			this.email = email;
			this.address = address;
			this.phone = phone;
			this.company = company;
			this.title = title;
			this.cmnd = cmnd;
			this.station = station;
		}

		/// <summary>
		/// Initializes a new instance of the UserdetailInfoBase class.
		/// </summary>
		public UserdetailInfoBase(int userid, string fullname, string email, string address, string phone, string company, string title, string cmnd, string station)
		{
			this.userid = userid;
			this.fullname = fullname;
			this.email = email;
			this.address = address;
			this.phone = phone;
			this.company = company;
			this.title = title;
			this.cmnd = cmnd;
			this.station = station;
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
		/// Gets or sets the Fullname value.
		/// </summary>
		public string Fullname
		{
			get { return fullname; }
			set { fullname = value; }
		}

		/// <summary>
		/// Gets or sets the Email value.
		/// </summary>
		public string Email
		{
			get { return email; }
			set { email = value; }
		}

		/// <summary>
		/// Gets or sets the Address value.
		/// </summary>
		public string Address
		{
			get { return address; }
			set { address = value; }
		}

		/// <summary>
		/// Gets or sets the Phone value.
		/// </summary>
		public string Phone
		{
			get { return phone; }
			set { phone = value; }
		}

		/// <summary>
		/// Gets or sets the Company value.
		/// </summary>
		public string Company
		{
			get { return company; }
			set { company = value; }
		}

		/// <summary>
		/// Gets or sets the Title value.
		/// </summary>
		public string Title
		{
			get { return title; }
			set { title = value; }
		}

		/// <summary>
		/// Gets or sets the Cmnd value.
		/// </summary>
		public string Cmnd
		{
			get { return cmnd; }
			set { cmnd = value; }
		}

		/// <summary>
		/// Gets or sets the Station value.
		/// </summary>
		public string Station
		{
			get { return station; }
			set { station = value; }
		}

		#endregion
	}
}
