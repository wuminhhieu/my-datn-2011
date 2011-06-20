using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class TransactionInfoBase
	{
		#region Fields

		private int transactionid;
		private int station;
		private int time;
		private int userid;
		private string price;
		private string car;
		private int evidence;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the TransactionInfoBase class.
		/// </summary>
		public TransactionInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the TransactionInfoBase class.
		/// </summary>
		public TransactionInfoBase(int transactionid, int station, int time, int userid, string price, string car, int evidence)
		{
			this.transactionid = transactionid;
			this.station = station;
			this.time = time;
			this.userid = userid;
			this.price = price;
			this.car = car;
			this.evidence = evidence;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Transactionid value.
		/// </summary>
		public int Transactionid
		{
			get { return transactionid; }
			set { transactionid = value; }
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
		/// Gets or sets the Time value.
		/// </summary>
		public int Time
		{
			get { return time; }
			set { time = value; }
		}

		/// <summary>
		/// Gets or sets the Userid value.
		/// </summary>
		public int Userid
		{
			get { return userid; }
			set { userid = value; }
		}

		/// <summary>
		/// Gets or sets the Price value.
		/// </summary>
		public string Price
		{
			get { return price; }
			set { price = value; }
		}

		/// <summary>
		/// Gets or sets the Car value.
		/// </summary>
		public string Car
		{
			get { return car; }
			set { car = value; }
		}

		/// <summary>
		/// Gets or sets the Evidence value.
		/// </summary>
		public int Evidence
		{
			get { return evidence; }
			set { evidence = value; }
		}

		#endregion
	}
}
