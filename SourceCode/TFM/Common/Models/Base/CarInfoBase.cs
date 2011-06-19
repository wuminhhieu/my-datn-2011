using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class CarInfoBase
	{
		#region Fields

		private string number_plate;
		private int car_type;
		private string brand;
		private string province;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CarInfoBase class.
		/// </summary>
		public CarInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CarInfoBase class.
		/// </summary>
		public CarInfoBase(string number_plate, int car_type, string brand, string province)
		{
			this.number_plate = number_plate;
			this.car_type = car_type;
			this.brand = brand;
			this.province = province;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Number_plate value.
		/// </summary>
		public string Number_plate
		{
			get { return number_plate; }
			set { number_plate = value; }
		}

		/// <summary>
		/// Gets or sets the Car_type value.
		/// </summary>
		public int Car_type
		{
			get { return car_type; }
			set { car_type = value; }
		}

		/// <summary>
		/// Gets or sets the Brand value.
		/// </summary>
		public string Brand
		{
			get { return brand; }
			set { brand = value; }
		}

		/// <summary>
		/// Gets or sets the Province value.
		/// </summary>
		public string Province
		{
			get { return province; }
			set { province = value; }
		}

		#endregion
	}
}
