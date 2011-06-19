using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class CarTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public CarTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the car table.
		/// </summary>
		public virtual void Insert(CarInfo carInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@number_plate", carInfo.Number_plate),
				new SqlParameter("@car_type", carInfo.Car_type),
				new SqlParameter("@brand", carInfo.Brand),
				new SqlParameter("@province", carInfo.Province)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the car table.
		/// </summary>
		public virtual void Update(CarInfo carInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@number_plate", carInfo.Number_plate),
				new SqlParameter("@car_type", carInfo.Car_type),
				new SqlParameter("@brand", carInfo.Brand),
				new SqlParameter("@province", carInfo.Province)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the car table by its primary key.
		/// </summary>
		public virtual void Delete(string number_plate)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@number_plate", number_plate)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the car table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByCar_type(int car_type)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@car_type", car_type)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_DeleteAllByCar_type", parameters);
		}

		/// <summary>
		/// Selects a single record from the car table.
		/// </summary>
		public virtual CarInfo Select(string number_plate)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@number_plate", number_plate)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "car_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCarInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the car table.
		/// </summary>
		public CHRTList<CarInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "car_SelectAll"))
			{
				CHRTList<CarInfo> carInfoList = new CHRTList<CarInfo>();
				while (dataReader.Read())
				{
					CarInfo carInfo = MakeCarInfo(dataReader);
					carInfoList.Add(carInfo);
				}

				return carInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the car table by a foreign key.
		/// </summary>
		public virtual CHRTList<CarInfo> SelectAllByCar_type(int car_type)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@car_type", car_type)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "car_SelectAllByCar_type", parameters))
			{
				CHRTList<CarInfo> carInfoList = new CHRTList<CarInfo>();
				while (dataReader.Read())
				{
					CarInfo carInfo = MakeCarInfo(dataReader);
					carInfoList.Add(carInfo);
				}

				return carInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the car class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual CarInfo MakeCarInfo(SqlDataReader dataReader)
		{
			CarInfo carInfo = new CarInfo();
			carInfo.Number_plate = SqlClientUtility.GetString(dataReader,DbConstants.CAR.NUMBER_PLATE, String.Empty);
			carInfo.Car_type = SqlClientUtility.GetInt32(dataReader,DbConstants.CAR.CAR_TYPE, 0);
			carInfo.Brand = SqlClientUtility.GetString(dataReader,DbConstants.CAR.BRAND, String.Empty);
			carInfo.Province = SqlClientUtility.GetString(dataReader,DbConstants.CAR.PROVINCE, String.Empty);

			return carInfo;
		}

		#endregion
	}
}
