using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class RolepermissionsTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public RolepermissionsTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Deletes a record from the role_permissions table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByRoleid(int roleid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@roleid", roleid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "role_permissions_DeleteAllByRoleid", parameters);
		}

		/// <summary>
		/// Selects all records from the role_permissions table.
		/// </summary>
		public CHRTList<RolepermissionsInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "role_permissions_SelectAll"))
			{
				CHRTList<RolepermissionsInfo> rolepermissionsInfoList = new CHRTList<RolepermissionsInfo>();
				while (dataReader.Read())
				{
					RolepermissionsInfo rolepermissionsInfo = MakeRolepermissionsInfo(dataReader);
					rolepermissionsInfoList.Add(rolepermissionsInfo);
				}

				return rolepermissionsInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the role_permissions table by a foreign key.
		/// </summary>
		public virtual CHRTList<RolepermissionsInfo> SelectAllByRoleid(int roleid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@roleid", roleid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "role_permissions_SelectAllByRoleid", parameters))
			{
				CHRTList<RolepermissionsInfo> rolepermissionsInfoList = new CHRTList<RolepermissionsInfo>();
				while (dataReader.Read())
				{
					RolepermissionsInfo rolepermissionsInfo = MakeRolepermissionsInfo(dataReader);
					rolepermissionsInfoList.Add(rolepermissionsInfo);
				}

				return rolepermissionsInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the role_permissions class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual RolepermissionsInfo MakeRolepermissionsInfo(SqlDataReader dataReader)
		{
			RolepermissionsInfo rolepermissionsInfo = new RolepermissionsInfo();
			rolepermissionsInfo.Roleid = SqlClientUtility.GetInt32(dataReader,DbConstants.ROLE_PERMISSIONS.ROLEID, 0);
			rolepermissionsInfo.Permission = SqlClientUtility.GetString(dataReader,DbConstants.ROLE_PERMISSIONS.PERMISSION, String.Empty);

			return rolepermissionsInfo;
		}

		#endregion
	}
}
