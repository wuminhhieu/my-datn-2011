using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class UserdetailTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public UserdetailTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the user_detail table.
		/// </summary>
		public virtual void Insert(UserdetailInfo userdetailInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@fullname", userdetailInfo.Fullname),
				new SqlParameter("@picture", userdetailInfo.Picture),
				new SqlParameter("@email", userdetailInfo.Email),
				new SqlParameter("@address", userdetailInfo.Address),
				new SqlParameter("@phone", userdetailInfo.Phone),
				new SqlParameter("@company", userdetailInfo.Company),
				new SqlParameter("@title", userdetailInfo.Title),
				new SqlParameter("@cmnd", userdetailInfo.Cmnd),
				new SqlParameter("@station", userdetailInfo.Station)
			};

			userdetailInfo.Userid = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "user_detail_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the user_detail table.
		/// </summary>
		public virtual void Update(UserdetailInfo userdetailInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userdetailInfo.Userid),
				new SqlParameter("@fullname", userdetailInfo.Fullname),
				new SqlParameter("@picture", userdetailInfo.Picture),
				new SqlParameter("@email", userdetailInfo.Email),
				new SqlParameter("@address", userdetailInfo.Address),
				new SqlParameter("@phone", userdetailInfo.Phone),
				new SqlParameter("@company", userdetailInfo.Company),
				new SqlParameter("@title", userdetailInfo.Title),
				new SqlParameter("@cmnd", userdetailInfo.Cmnd),
				new SqlParameter("@station", userdetailInfo.Station)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "user_detail_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the user_detail table by its primary key.
		/// </summary>
		public virtual void Delete(int userid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "user_detail_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the user_detail table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByUserid(int userid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "user_detail_DeleteAllByUserid", parameters);
		}

		/// <summary>
		/// Selects a single record from the user_detail table.
		/// </summary>
		public virtual UserdetailInfo Select(int userid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "user_detail_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeUserdetailInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the user_detail table.
		/// </summary>
		public CHRTList<UserdetailInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "user_detail_SelectAll"))
			{
				CHRTList<UserdetailInfo> userdetailInfoList = new CHRTList<UserdetailInfo>();
				while (dataReader.Read())
				{
					UserdetailInfo userdetailInfo = MakeUserdetailInfo(dataReader);
					userdetailInfoList.Add(userdetailInfo);
				}

				return userdetailInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the user_detail table by a foreign key.
		/// </summary>
		public virtual CHRTList<UserdetailInfo> SelectAllByUserid(int userid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "user_detail_SelectAllByUserid", parameters))
			{
				CHRTList<UserdetailInfo> userdetailInfoList = new CHRTList<UserdetailInfo>();
				while (dataReader.Read())
				{
					UserdetailInfo userdetailInfo = MakeUserdetailInfo(dataReader);
					userdetailInfoList.Add(userdetailInfo);
				}

				return userdetailInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the user_detail class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual UserdetailInfo MakeUserdetailInfo(SqlDataReader dataReader)
		{
			UserdetailInfo userdetailInfo = new UserdetailInfo();
			userdetailInfo.Userid = SqlClientUtility.GetInt32(dataReader,DbConstants.USER_DETAIL.USERID, 0);
			userdetailInfo.Fullname = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.FULLNAME, String.Empty);
			userdetailInfo.Picture = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.PICTURE, String.Empty);
			userdetailInfo.Email = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.EMAIL, String.Empty);
			userdetailInfo.Address = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.ADDRESS, String.Empty);
			userdetailInfo.Phone = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.PHONE, String.Empty);
			userdetailInfo.Company = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.COMPANY, String.Empty);
			userdetailInfo.Title = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.TITLE, String.Empty);
			userdetailInfo.Cmnd = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.CMND, String.Empty);
			userdetailInfo.Station = SqlClientUtility.GetString(dataReader,DbConstants.USER_DETAIL.STATION, String.Empty);

			return userdetailInfo;
		}

		#endregion
	}
}
