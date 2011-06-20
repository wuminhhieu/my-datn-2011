using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class TickettypeInfoBase
	{
		#region Fields

		private int ticket_type_id;
		private string name;
		private int created_date;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TickettypeInfoBase class.
		/// </summary>
		public TickettypeInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the TickettypeInfoBase class.
		/// </summary>
		public TickettypeInfoBase(string name, int created_date)
		{
			this.name = name;
			this.created_date = created_date;
		}

		/// <summary>
		/// Initializes a new instance of the TickettypeInfoBase class.
		/// </summary>
		public TickettypeInfoBase(int ticket_type_id, string name, int created_date)
		{
			this.ticket_type_id = ticket_type_id;
			this.name = name;
			this.created_date = created_date;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Ticket_type_id value.
		/// </summary>
		public int Ticket_type_id
		{
			get { return ticket_type_id; }
			set { ticket_type_id = value; }
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
		/// Gets or sets the Created_date value.
		/// </summary>
		public int Created_date
		{
			get { return created_date; }
			set { created_date = value; }
		}

		#endregion
	}
}
