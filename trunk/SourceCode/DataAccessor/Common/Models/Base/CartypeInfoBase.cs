using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class CartypeInfoBase
	{
		#region Fields

		private int typeid;
		private string name;
		private string note;
		private string weight;
		private string seat;
		private string capacity;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CartypeInfoBase class.
		/// </summary>
		public CartypeInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CartypeInfoBase class.
		/// </summary>
		public CartypeInfoBase(string name, string note, string weight, string seat, string capacity)
		{
			this.name = name;
			this.note = note;
			this.weight = weight;
			this.seat = seat;
			this.capacity = capacity;
		}

		/// <summary>
		/// Initializes a new instance of the CartypeInfoBase class.
		/// </summary>
		public CartypeInfoBase(int typeid, string name, string note, string weight, string seat, string capacity)
		{
			this.typeid = typeid;
			this.name = name;
			this.note = note;
			this.weight = weight;
			this.seat = seat;
			this.capacity = capacity;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Typeid value.
		/// </summary>
		public int Typeid
		{
			get { return typeid; }
			set { typeid = value; }
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
		/// Gets or sets the Note value.
		/// </summary>
		public string Note
		{
			get { return note; }
			set { note = value; }
		}

		/// <summary>
		/// Gets or sets the Weight value.
		/// </summary>
		public string Weight
		{
			get { return weight; }
			set { weight = value; }
		}

		/// <summary>
		/// Gets or sets the Seat value.
		/// </summary>
		public string Seat
		{
			get { return seat; }
			set { seat = value; }
		}

		/// <summary>
		/// Gets or sets the Capacity value.
		/// </summary>
		public string Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}

		#endregion
	}
}
