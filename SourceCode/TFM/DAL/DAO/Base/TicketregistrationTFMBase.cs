using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class TicketregistrationTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public TicketregistrationTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the ticket_registration table.
		/// </summary>
		public virtual void Insert(TicketregistrationInfo ticketregistrationInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticketid", ticketregistrationInfo.Ticketid),
				new SqlParameter("@number_plate", ticketregistrationInfo.Number_plate),
				new SqlParameter("@ticket_type", ticketregistrationInfo.Ticket_type),
				new SqlParameter("@start_date", ticketregistrationInfo.Start_date),
				new SqlParameter("@end_date", ticketregistrationInfo.End_date),
				new SqlParameter("@station", ticketregistrationInfo.Station)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ticket_registration_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the ticket_registration table.
		/// </summary>
		public virtual void Update(TicketregistrationInfo ticketregistrationInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticketid", ticketregistrationInfo.Ticketid),
				new SqlParameter("@number_plate", ticketregistrationInfo.Number_plate),
				new SqlParameter("@ticket_type", ticketregistrationInfo.Ticket_type),
				new SqlParameter("@start_date", ticketregistrationInfo.Start_date),
				new SqlParameter("@end_date", ticketregistrationInfo.End_date),
				new SqlParameter("@station", ticketregistrationInfo.Station)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ticket_registration_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the ticket_registration table by its primary key.
		/// </summary>
		public virtual void Delete(int ticketid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticketid", ticketid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ticket_registration_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the ticket_registration table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByStation(int station)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@station", station)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ticket_registration_DeleteAllByStation", parameters);
		}

		/// <summary>
		/// Deletes a record from the ticket_registration table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByTicket_type(int ticket_type)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticket_type", ticket_type)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "ticket_registration_DeleteAllByTicket_type", parameters);
		}

		/// <summary>
		/// Selects a single record from the ticket_registration table.
		/// </summary>
		public virtual TicketregistrationInfo Select(int ticketid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticketid", ticketid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ticket_registration_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeTicketregistrationInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the ticket_registration table.
		/// </summary>
		public CHRTList<TicketregistrationInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ticket_registration_SelectAll"))
			{
				CHRTList<TicketregistrationInfo> ticketregistrationInfoList = new CHRTList<TicketregistrationInfo>();
				while (dataReader.Read())
				{
					TicketregistrationInfo ticketregistrationInfo = MakeTicketregistrationInfo(dataReader);
					ticketregistrationInfoList.Add(ticketregistrationInfo);
				}

				return ticketregistrationInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the ticket_registration table by a foreign key.
		/// </summary>
		public virtual CHRTList<TicketregistrationInfo> SelectAllByStation(int station)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@station", station)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ticket_registration_SelectAllByStation", parameters))
			{
				CHRTList<TicketregistrationInfo> ticketregistrationInfoList = new CHRTList<TicketregistrationInfo>();
				while (dataReader.Read())
				{
					TicketregistrationInfo ticketregistrationInfo = MakeTicketregistrationInfo(dataReader);
					ticketregistrationInfoList.Add(ticketregistrationInfo);
				}

				return ticketregistrationInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the ticket_registration table by a foreign key.
		/// </summary>
		public virtual CHRTList<TicketregistrationInfo> SelectAllByTicket_type(int ticket_type)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@ticket_type", ticket_type)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "ticket_registration_SelectAllByTicket_type", parameters))
			{
				CHRTList<TicketregistrationInfo> ticketregistrationInfoList = new CHRTList<TicketregistrationInfo>();
				while (dataReader.Read())
				{
					TicketregistrationInfo ticketregistrationInfo = MakeTicketregistrationInfo(dataReader);
					ticketregistrationInfoList.Add(ticketregistrationInfo);
				}

				return ticketregistrationInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the ticket_registration class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual TicketregistrationInfo MakeTicketregistrationInfo(SqlDataReader dataReader)
		{
			TicketregistrationInfo ticketregistrationInfo = new TicketregistrationInfo();
			ticketregistrationInfo.Ticketid = SqlClientUtility.GetInt32(dataReader,DbConstants.TICKET_REGISTRATION.TICKETID, 0);
			ticketregistrationInfo.Number_plate = SqlClientUtility.GetString(dataReader,DbConstants.TICKET_REGISTRATION.NUMBER_PLATE, String.Empty);
			ticketregistrationInfo.Ticket_type = SqlClientUtility.GetInt32(dataReader,DbConstants.TICKET_REGISTRATION.TICKET_TYPE, 0);
			ticketregistrationInfo.Start_date = SqlClientUtility.GetInt32(dataReader,DbConstants.TICKET_REGISTRATION.START_DATE, 0);
			ticketregistrationInfo.End_date = SqlClientUtility.GetInt32(dataReader,DbConstants.TICKET_REGISTRATION.END_DATE, 0);
			ticketregistrationInfo.Station = SqlClientUtility.GetInt32(dataReader,DbConstants.TICKET_REGISTRATION.STATION, 0);

			return ticketregistrationInfo;
		}

		#endregion
	}
}
