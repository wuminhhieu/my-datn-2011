using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class RolesTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public RolesTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the roles table.
		/// </summary>
		public virtual void Insert(RolesInfo rolesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@name", rolesInfo.Name)
			};

			rolesInfo.Roleid = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "roles_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the roles table.
		/// </summary>
		public virtual void Update(RolesInfo rolesInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@roleid", rolesInfo.Roleid),
				new SqlParameter("@name", rolesInfo.Name)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "roles_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the roles table by its primary key.
		/// </summary>
		public virtual void Delete(int roleid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@roleid", roleid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "roles_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the roles table.
		/// </summary>
		public virtual RolesInfo Select(int roleid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@roleid", roleid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "roles_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeRolesInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the roles table.
		/// </summary>
		public CHRTList<RolesInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "roles_SelectAll"))
			{
				CHRTList<RolesInfo> rolesInfoList = new CHRTList<RolesInfo>();
				while (dataReader.Read())
				{
					RolesInfo rolesInfo = MakeRolesInfo(dataReader);
					rolesInfoList.Add(rolesInfo);
				}

				return rolesInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the roles class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual RolesInfo MakeRolesInfo(SqlDataReader dataReader)
		{
			RolesInfo rolesInfo = new RolesInfo();
			rolesInfo.Roleid = SqlClientUtility.GetInt32(dataReader,DbConstants.ROLES.ROLEID, 0);
			rolesInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.ROLES.NAME, String.Empty);

			return rolesInfo;
		}

		#endregion
	}
}
