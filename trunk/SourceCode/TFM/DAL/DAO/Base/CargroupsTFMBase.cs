using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class CargroupsTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public CargroupsTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the car_groups table.
		/// </summary>
		public virtual void Insert(CargroupsInfo cargroupsInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@groupid", cargroupsInfo.Groupid),
				new SqlParameter("@name", cargroupsInfo.Name),
				new SqlParameter("@description", cargroupsInfo.Description),
				new SqlParameter("@min_weight", cargroupsInfo.Min_weight),
				new SqlParameter("@max_weight", cargroupsInfo.Max_weight),
				new SqlParameter("@min_seat", cargroupsInfo.Min_seat),
				new SqlParameter("@max_seat", cargroupsInfo.Max_seat),
				new SqlParameter("@min_capacity", cargroupsInfo.Min_capacity),
				new SqlParameter("@max_capacity", cargroupsInfo.Max_capacity)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_groups_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the car_groups table.
		/// </summary>
		public virtual void Update(CargroupsInfo cargroupsInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@groupid", cargroupsInfo.Groupid),
				new SqlParameter("@name", cargroupsInfo.Name),
				new SqlParameter("@description", cargroupsInfo.Description),
				new SqlParameter("@min_weight", cargroupsInfo.Min_weight),
				new SqlParameter("@max_weight", cargroupsInfo.Max_weight),
				new SqlParameter("@min_seat", cargroupsInfo.Min_seat),
				new SqlParameter("@max_seat", cargroupsInfo.Max_seat),
				new SqlParameter("@min_capacity", cargroupsInfo.Min_capacity),
				new SqlParameter("@max_capacity", cargroupsInfo.Max_capacity)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_groups_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the car_groups table by its primary key.
		/// </summary>
		public virtual void Delete(int groupid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@groupid", groupid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "car_groups_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the car_groups table.
		/// </summary>
		public virtual CargroupsInfo Select(int groupid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@groupid", groupid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "car_groups_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeCargroupsInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the car_groups table.
		/// </summary>
		public CHRTList<CargroupsInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "car_groups_SelectAll"))
			{
				CHRTList<CargroupsInfo> cargroupsInfoList = new CHRTList<CargroupsInfo>();
				while (dataReader.Read())
				{
					CargroupsInfo cargroupsInfo = MakeCargroupsInfo(dataReader);
					cargroupsInfoList.Add(cargroupsInfo);
				}

				return cargroupsInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the car_groups class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual CargroupsInfo MakeCargroupsInfo(SqlDataReader dataReader)
		{
			CargroupsInfo cargroupsInfo = new CargroupsInfo();
			cargroupsInfo.Groupid = SqlClientUtility.GetInt32(dataReader,DbConstants.CAR_GROUPS.GROUPID, 0);
			cargroupsInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.CAR_GROUPS.NAME, String.Empty);
			cargroupsInfo.Description = SqlClientUtility.GetString(dataReader,DbConstants.CAR_GROUPS.DESCRIPTION, String.Empty);
			cargroupsInfo.Min_weight = SqlClientUtility.GetString(dataReader,DbConstants.CAR_GROUPS.MIN_WEIGHT, String.Empty);
			cargroupsInfo.Max_weight = SqlClientUtility.GetString(dataReader,DbConstants.CAR_GROUPS.MAX_WEIGHT, String.Empty);
			cargroupsInfo.Min_seat = SqlClientUtility.GetString(dataReader,DbConstants.CAR_GROUPS.MIN_SEAT, String.Empty);
			cargroupsInfo.Max_seat = SqlClientUtility.GetString(dataReader,DbConstants.CAR_GROUPS.MAX_SEAT, String.Empty);
			cargroupsInfo.Min_capacity = SqlClientUtility.GetString(dataReader,DbConstants.CAR_GROUPS.MIN_CAPACITY, String.Empty);
			cargroupsInfo.Max_capacity = SqlClientUtility.GetString(dataReader,DbConstants.CAR_GROUPS.MAX_CAPACITY, String.Empty);

			return cargroupsInfo;
		}

		#endregion
	}
}
