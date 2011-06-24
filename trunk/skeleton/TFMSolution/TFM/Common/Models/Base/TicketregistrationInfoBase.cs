using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class TicketregistrationInfoBase
	{
		#region Fields

		private int ticketid;
		private string number_plate;
		private int ticket_type;
		private int start_date;
		private int end_date;
		private int station;
		private string customer;
		private string staff;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TicketregistrationInfoBase class.
		/// </summary>
		public TicketregistrationInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the TicketregistrationInfoBase class.
		/// </summary>
		public TicketregistrationInfoBase(int ticketid, string number_plate, int ticket_type, int start_date, int end_date, int station, string customer, string staff)
		{
			this.ticketid = ticketid;
			this.number_plate = number_plate;
			this.ticket_type = ticket_type;
			this.start_date = start_date;
			this.end_date = end_date;
			this.station = station;
			this.customer = customer;
			this.staff = staff;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Ticketid value.
		/// </summary>
		public int Ticketid
		{
			get { return ticketid; }
			set { ticketid = value; }
		}

		/// <summary>
		/// Gets or sets the Number_plate value.
		/// </summary>
		public string Number_plate
		{
			get { return number_plate; }
			set { number_plate = value; }
		}

		/// <summary>
		/// Gets or sets the Ticket_type value.
		/// </summary>
		public int Ticket_type
		{
			get { return ticket_type; }
			set { ticket_type = value; }
		}

		/// <summary>
		/// Gets or sets the Start_date value.
		/// </summary>
		public int Start_date
		{
			get { return start_date; }
			set { start_date = value; }
		}

		/// <summary>
		/// Gets or sets the End_date value.
		/// </summary>
		public int End_date
		{
			get { return end_date; }
			set { end_date = value; }
		}

		/// <summary>
		/// Gets or sets the Station value.
		/// </summary>
		public int Station
		{
			get { return station; }
			set { station = value; }
		}

		/// <summary>
		/// Gets or sets the Customer value.
		/// </summary>
		public string Customer
		{
			get { return customer; }
			set { customer = value; }
		}

		/// <summary>
		/// Gets or sets the Staff value.
		/// </summary>
		public string Staff
		{
			get { return staff; }
			set { staff = value; }
		}

		#endregion
	}
}
