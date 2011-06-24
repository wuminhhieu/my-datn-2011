using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class FareInfoBase
	{
		#region Fields

		private int fareid;
		private int car_group;
		private int ticket_type;
		private int station;
		private int price;
		private int apply_date;
		private int created_date;
		private int is_active;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the FareInfoBase class.
		/// </summary>
		public FareInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the FareInfoBase class.
		/// </summary>
		public FareInfoBase(int car_group, int ticket_type, int station, int price, int apply_date, int created_date, int is_active)
		{
			this.car_group = car_group;
			this.ticket_type = ticket_type;
			this.station = station;
			this.price = price;
			this.apply_date = apply_date;
			this.created_date = created_date;
			this.is_active = is_active;
		}

		/// <summary>
		/// Initializes a new instance of the FareInfoBase class.
		/// </summary>
		public FareInfoBase(int fareid, int car_group, int ticket_type, int station, int price, int apply_date, int created_date, int is_active)
		{
			this.fareid = fareid;
			this.car_group = car_group;
			this.ticket_type = ticket_type;
			this.station = station;
			this.price = price;
			this.apply_date = apply_date;
			this.created_date = created_date;
			this.is_active = is_active;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Fareid value.
		/// </summary>
		public int Fareid
		{
			get { return fareid; }
			set { fareid = value; }
		}

		/// <summary>
		/// Gets or sets the Car_group value.
		/// </summary>
		public int Car_group
		{
			get { return car_group; }
			set { car_group = value; }
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
		/// Gets or sets the Station value.
		/// </summary>
		public int Station
		{
			get { return station; }
			set { station = value; }
		}

		/// <summary>
		/// Gets or sets the Price value.
		/// </summary>
		public int Price
		{
			get { return price; }
			set { price = value; }
		}

		/// <summary>
		/// Gets or sets the Apply_date value.
		/// </summary>
		public int Apply_date
		{
			get { return apply_date; }
			set { apply_date = value; }
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
		/// Gets or sets the Is_active value.
		/// </summary>
		public int Is_active
		{
			get { return is_active; }
			set { is_active = value; }
		}

		#endregion
	}
}
