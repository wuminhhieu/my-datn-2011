using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class TickettypeTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public TickettypeTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the ticket_type table.
		/// </summary>
		public virtual void Insert(TickettypeInfo tickettypeInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@name", tickettypeInfo.Name),
				new SqlParameter("@created_date", tickettypeInfo.Created_date),
				new SqlParameter("@description", tickettypeInfo.Description)
			};

			tickettypeInfo.Ticket_type_id = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "ticket_type_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the ticket_type table.
		/// </summary>
		public virtual void Update(TickettypeInfo tickettypeInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticket_type_id", tickettypeInfo.Ticket_type_id),
				new SqlParameter("@name", tickettypeInfo.Name),
				new SqlParameter("@created_date", tickettypeInfo.Created_date),
				new SqlParameter("@description", tickettypeInfo.Description)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ticket_type_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the ticket_type table by its primary key.
		/// </summary>
		public virtual void Delete(int ticket_type_id)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticket_type_id", ticket_type_id)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ticket_type_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the ticket_type table.
		/// </summary>
		public virtual TickettypeInfo Select(int ticket_type_id)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticket_type_id", ticket_type_id)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ticket_type_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeTickettypeInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the ticket_type table.
		/// </summary>
		public CHRTList<TickettypeInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ticket_type_SelectAll"))
			{
				CHRTList<TickettypeInfo> tickettypeInfoList = new CHRTList<TickettypeInfo>();
				while (dataReader.Read())
				{
					TickettypeInfo tickettypeInfo = MakeTickettypeInfo(dataReader);
					tickettypeInfoList.Add(tickettypeInfo);
				}

				return tickettypeInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the ticket_type class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual TickettypeInfo MakeTickettypeInfo(SqlDataReader dataReader)
		{
			TickettypeInfo tickettypeInfo = new TickettypeInfo();
			tickettypeInfo.Ticket_type_id = SqlClientUtility.GetInt32(dataReader,DbConstants.TICKET_TYPE.TICKET_TYPE_ID, 0);
			tickettypeInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.TICKET_TYPE.NAME, String.Empty);
			tickettypeInfo.Created_date = SqlClientUtility.GetInt32(dataReader,DbConstants.TICKET_TYPE.CREATED_DATE, 0);
			tickettypeInfo.Description = SqlClientUtility.GetString(dataReader,DbConstants.TICKET_TYPE.DESCRIPTION, String.Empty);

			return tickettypeInfo;
		}

		#endregion
	}
}
