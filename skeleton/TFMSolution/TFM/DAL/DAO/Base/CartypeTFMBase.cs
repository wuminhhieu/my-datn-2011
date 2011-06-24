using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class CartypeTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public CartypeTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the car_type table.
		/// </summary>
		public virtual void Insert(CartypeInfo cartypeInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@name", cartypeInfo.Name),
				new SqlParameter("@note", cartypeInfo.Note),
				new SqlParameter("@weight", cartypeInfo.Weight),
				new SqlParameter("@seat", cartypeInfo.Seat),
				new SqlParameter("@capacity", cartypeInfo.Capacity),
				new SqlParameter("@priority_property", cartypeInfo.Priority_property)
			};

			cartypeInfo.Typeid = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "car_type_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the car_type table.
		/// </summary>
		public virtual void Update(CartypeInfo cartypeInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@typeid", cartypeInfo.Typeid),
				new SqlParameter("@name", cartypeInfo.Name),
				new SqlParameter("@note", cartypeInfo.Note),
				new SqlParameter("@weight", cartypeInfo.Weight),
				new SqlParameter("@seat", cartypeInfo.Seat),
				new SqlParameter("@capacity", cartypeInfo.Capacity),
				new SqlParameter("@priority_property", cartypeInfo.Priority_property)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_type_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the car_type table by its primary key.
		/// </summary>
		public virtual void Delete(int typeid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@typeid", typeid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_type_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the car_type table.
		/// </summary>
		public virtual CartypeInfo Select(int typeid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@typeid", typeid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "car_type_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCartypeInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the car_type table.
		/// </summary>
		public CHRTList<CartypeInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "car_type_SelectAll"))
			{
				CHRTList<CartypeInfo> cartypeInfoList = new CHRTList<CartypeInfo>();
				while (dataReader.Read())
				{
					CartypeInfo cartypeInfo = MakeCartypeInfo(dataReader);
					cartypeInfoList.Add(cartypeInfo);
				}

				return cartypeInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the car_type class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual CartypeInfo MakeCartypeInfo(SqlDataReader dataReader)
		{
			CartypeInfo cartypeInfo = new CartypeInfo();
			cartypeInfo.Typeid = SqlClientUtility.GetInt32(dataReader,DbConstants.CAR_TYPE.TYPEID, 0);
			cartypeInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.CAR_TYPE.NAME, String.Empty);
			cartypeInfo.Note = SqlClientUtility.GetString(dataReader,DbConstants.CAR_TYPE.NOTE, String.Empty);
			cartypeInfo.Weight = SqlClientUtility.GetString(dataReader,DbConstants.CAR_TYPE.WEIGHT, String.Empty);
			cartypeInfo.Seat = SqlClientUtility.GetString(dataReader,DbConstants.CAR_TYPE.SEAT, String.Empty);
			cartypeInfo.Capacity = SqlClientUtility.GetString(dataReader,DbConstants.CAR_TYPE.CAPACITY, String.Empty);
			cartypeInfo.Priority_property = SqlClientUtility.GetString(dataReader,DbConstants.CAR_TYPE.PRIORITY_PROPERTY, String.Empty);

			return cartypeInfo;
		}

		#endregion
	}
}
