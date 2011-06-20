using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class UsersTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public UsersTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the users table.
		/// </summary>
		public virtual void Insert(UsersInfo usersInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@username", usersInfo.Username),
				new SqlParameter("@password", usersInfo.Password),
				new SqlParameter("@roleid", usersInfo.Roleid)
			};

			usersInfo.Userid = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "users_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the users table.
		/// </summary>
		public virtual void Update(UsersInfo usersInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", usersInfo.Userid),
				new SqlParameter("@username", usersInfo.Username),
				new SqlParameter("@password", usersInfo.Password),
				new SqlParameter("@roleid", usersInfo.Roleid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "users_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the users table by its primary key.
		/// </summary>
		public virtual void Delete(int userid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "users_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the users table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByRoleid(int roleid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@roleid", roleid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "users_DeleteAllByRoleid", parameters);
		}

		/// <summary>
		/// Selects a single record from the users table.
		/// </summary>
		public virtual UsersInfo Select(int userid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "users_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeUsersInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the users table.
		/// </summary>
		public CHRTList<UsersInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "users_SelectAll"))
			{
				CHRTList<UsersInfo> usersInfoList = new CHRTList<UsersInfo>();
				while (dataReader.Read())
				{
					UsersInfo usersInfo = MakeUsersInfo(dataReader);
					usersInfoList.Add(usersInfo);
				}

				return usersInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the users table by a foreign key.
		/// </summary>
		public virtual CHRTList<UsersInfo> SelectAllByRoleid(int roleid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@roleid", roleid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "users_SelectAllByRoleid", parameters))
			{
				CHRTList<UsersInfo> usersInfoList = new CHRTList<UsersInfo>();
				while (dataReader.Read())
				{
					UsersInfo usersInfo = MakeUsersInfo(dataReader);
					usersInfoList.Add(usersInfo);
				}

				return usersInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the users class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual UsersInfo MakeUsersInfo(SqlDataReader dataReader)
		{
			UsersInfo usersInfo = new UsersInfo();
			usersInfo.Userid = SqlClientUtility.GetInt32(dataReader,DbConstants.USERS.USERID, 0);
			usersInfo.Username = SqlClientUtility.GetString(dataReader,DbConstants.USERS.USERNAME, String.Empty);
			usersInfo.Password = SqlClientUtility.GetString(dataReader,DbConstants.USERS.PASSWORD, String.Empty);
			usersInfo.Roleid = SqlClientUtility.GetInt32(dataReader,DbConstants.USERS.ROLEID, 0);

			return usersInfo;
		}

		#endregion
	}
}
