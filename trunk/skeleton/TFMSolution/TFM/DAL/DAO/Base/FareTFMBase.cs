using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class FareTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public FareTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the fare table.
		/// </summary>
		public virtual void Insert(FareInfo fareInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@car_group", fareInfo.Car_group),
				new SqlParameter("@ticket_type", fareInfo.Ticket_type),
				new SqlParameter("@station", fareInfo.Station),
				new SqlParameter("@price", fareInfo.Price),
				new SqlParameter("@apply_date", fareInfo.Apply_date),
				new SqlParameter("@created_date", fareInfo.Created_date),
				new SqlParameter("@is_active", fareInfo.Is_active)
			};

			fareInfo.Fareid = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "fare_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the fare table.
		/// </summary>
		public virtual void Update(FareInfo fareInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@fareid", fareInfo.Fareid),
				new SqlParameter("@car_group", fareInfo.Car_group),
				new SqlParameter("@ticket_type", fareInfo.Ticket_type),
				new SqlParameter("@station", fareInfo.Station),
				new SqlParameter("@price", fareInfo.Price),
				new SqlParameter("@apply_date", fareInfo.Apply_date),
				new SqlParameter("@created_date", fareInfo.Created_date),
				new SqlParameter("@is_active", fareInfo.Is_active)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "fare_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the fare table by its primary key.
		/// </summary>
		public virtual void Delete(int fareid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@fareid", fareid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "fare_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the fare table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByCar_group(int car_group)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@car_group", car_group)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "fare_DeleteAllByCar_group", parameters);
		}

		/// <summary>
		/// Deletes a record from the fare table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByStation(int station)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@station", station)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "fare_DeleteAllByStation", parameters);
		}

		/// <summary>
		/// Deletes a record from the fare table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByTicket_type(int ticket_type)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticket_type", ticket_type)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "fare_DeleteAllByTicket_type", parameters);
		}

		/// <summary>
		/// Selects a single record from the fare table.
		/// </summary>
		public virtual FareInfo Select(int fareid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@fareid", fareid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "fare_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeFareInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the fare table.
		/// </summary>
		public CHRTList<FareInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "fare_SelectAll"))
			{
				CHRTList<FareInfo> fareInfoList = new CHRTList<FareInfo>();
				while (dataReader.Read())
				{
					FareInfo fareInfo = MakeFareInfo(dataReader);
					fareInfoList.Add(fareInfo);
				}

				return fareInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the fare table by a foreign key.
		/// </summary>
		public virtual CHRTList<FareInfo> SelectAllByCar_group(int car_group)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@car_group", car_group)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "fare_SelectAllByCar_group", parameters))
			{
				CHRTList<FareInfo> fareInfoList = new CHRTList<FareInfo>();
				while (dataReader.Read())
				{
					FareInfo fareInfo = MakeFareInfo(dataReader);
					fareInfoList.Add(fareInfo);
				}

				return fareInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the fare table by a foreign key.
		/// </summary>
		public virtual CHRTList<FareInfo> SelectAllByStation(int station)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@station", station)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "fare_SelectAllByStation", parameters))
			{
				CHRTList<FareInfo> fareInfoList = new CHRTList<FareInfo>();
				while (dataReader.Read())
				{
					FareInfo fareInfo = MakeFareInfo(dataReader);
					fareInfoList.Add(fareInfo);
				}

				return fareInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the fare table by a foreign key.
		/// </summary>
		public virtual CHRTList<FareInfo> SelectAllByTicket_type(int ticket_type)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticket_type", ticket_type)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "fare_SelectAllByTicket_type", parameters))
			{
				CHRTList<FareInfo> fareInfoList = new CHRTList<FareInfo>();
				while (dataReader.Read())
				{
					FareInfo fareInfo = MakeFareInfo(dataReader);
					fareInfoList.Add(fareInfo);
				}

				return fareInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the fare class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual FareInfo MakeFareInfo(SqlDataReader dataReader)
		{
			FareInfo fareInfo = new FareInfo();
			fareInfo.Fareid = SqlClientUtility.GetInt32(dataReader,DbConstants.FARE.FAREID, 0);
			fareInfo.Car_group = SqlClientUtility.GetInt32(dataReader,DbConstants.FARE.CAR_GROUP, 0);
			fareInfo.Ticket_type = SqlClientUtility.GetInt32(dataReader,DbConstants.FARE.TICKET_TYPE, 0);
			fareInfo.Station = SqlClientUtility.GetInt32(dataReader,DbConstants.FARE.STATION, 0);
			fareInfo.Price = SqlClientUtility.GetInt32(dataReader,DbConstants.FARE.PRICE, 0);
			fareInfo.Apply_date = SqlClientUtility.GetInt32(dataReader,DbConstants.FARE.APPLY_DATE, 0);
			fareInfo.Created_date = SqlClientUtility.GetInt32(dataReader,DbConstants.FARE.CREATED_DATE, 0);
			fareInfo.Is_active = SqlClientUtility.GetInt32(dataReader,DbConstants.FARE.IS_ACTIVE, 0);

			return fareInfo;
		}

		#endregion
	}
}
