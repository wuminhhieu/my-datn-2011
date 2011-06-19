using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class CargroupsInfoBase
	{
		#region Fields

		private int groupid;
		private string name;
		private string description;
		private string min_weight;
		private string max_weight;
		private string min_seat;
		private string max_seat;
		private string min_capacity;
		private string max_capacity;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the CargroupsInfoBase class.
		/// </summary>
		public CargroupsInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the CargroupsInfoBase class.
		/// </summary>
		public CargroupsInfoBase(int groupid, string name, string description, string min_weight, string max_weight, string min_seat, string max_seat, string min_capacity, string max_capacity)
		{
			this.groupid = groupid;
			this.name = name;
			this.description = description;
			this.min_weight = min_weight;
			this.max_weight = max_weight;
			this.min_seat = min_seat;
			this.max_seat = max_seat;
			this.min_capacity = min_capacity;
			this.max_capacity = max_capacity;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Groupid value.
		/// </summary>
		public int Groupid
		{
			get { return groupid; }
			set { groupid = value; }
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
		/// Gets or sets the Description value.
		/// </summary>
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		/// <summary>
		/// Gets or sets the Min_weight value.
		/// </summary>
		public string Min_weight
		{
			get { return min_weight; }
			set { min_weight = value; }
		}

		/// <summary>
		/// Gets or sets the Max_weight value.
		/// </summary>
		public string Max_weight
		{
			get { return max_weight; }
			set { max_weight = value; }
		}

		/// <summary>
		/// Gets or sets the Min_seat value.
		/// </summary>
		public string Min_seat
		{
			get { return min_seat; }
			set { min_seat = value; }
		}

		/// <summary>
		/// Gets or sets the Max_seat value.
		/// </summary>
		public string Max_seat
		{
			get { return max_seat; }
			set { max_seat = value; }
		}

		/// <summary>
		/// Gets or sets the Min_capacity value.
		/// </summary>
		public string Min_capacity
		{
			get { return min_capacity; }
			set { min_capacity = value; }
		}

		/// <summary>
		/// Gets or sets the Max_capacity value.
		/// </summary>
		public string Max_capacity
		{
			get { return max_capacity; }
			set { max_capacity = value; }
		}

		#endregion
	}
}
