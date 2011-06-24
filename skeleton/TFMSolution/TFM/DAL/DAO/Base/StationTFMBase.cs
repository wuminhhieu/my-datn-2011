using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class StationTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public StationTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the station table.
		/// </summary>
		public virtual void Insert(StationInfo stationInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@stationid", stationInfo.Stationid),
				new SqlParameter("@name", stationInfo.Name),
				new SqlParameter("@province", stationInfo.Province),
				new SqlParameter("@company", stationInfo.Company),
				new SqlParameter("@description", stationInfo.Description)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "station_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the station table.
		/// </summary>
		public virtual void Update(StationInfo stationInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@stationid", stationInfo.Stationid),
				new SqlParameter("@name", stationInfo.Name),
				new SqlParameter("@province", stationInfo.Province),
				new SqlParameter("@company", stationInfo.Company),
				new SqlParameter("@description", stationInfo.Description)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "station_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the station table by its primary key.
		/// </summary>
		public virtual void Delete(int stationid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@stationid", stationid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "station_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the station table.
		/// </summary>
		public virtual StationInfo Select(int stationid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@stationid", stationid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "station_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeStationInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the station table.
		/// </summary>
		public CHRTList<StationInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "station_SelectAll"))
			{
				CHRTList<StationInfo> stationInfoList = new CHRTList<StationInfo>();
				while (dataReader.Read())
				{
					StationInfo stationInfo = MakeStationInfo(dataReader);
					stationInfoList.Add(stationInfo);
				}

				return stationInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the station class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual StationInfo MakeStationInfo(SqlDataReader dataReader)
		{
			StationInfo stationInfo = new StationInfo();
			stationInfo.Stationid = SqlClientUtility.GetInt32(dataReader,DbConstants.STATION.STATIONID, 0);
			stationInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.STATION.NAME, String.Empty);
			stationInfo.Province = SqlClientUtility.GetString(dataReader,DbConstants.STATION.PROVINCE, String.Empty);
			stationInfo.Company = SqlClientUtility.GetString(dataReader,DbConstants.STATION.COMPANY, String.Empty);
			stationInfo.Description = SqlClientUtility.GetString(dataReader,DbConstants.STATION.DESCRIPTION, String.Empty);

			return stationInfo;
		}

		#endregion
	}
}
