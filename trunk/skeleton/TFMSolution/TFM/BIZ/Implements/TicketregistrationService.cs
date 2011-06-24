using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;


namespace TFM.Biz.Implements
{
	public class TicketregistrationService: ITicketregistrationService
	{
		/// <summary>
		/// Saves a record to the ticket_registration table.
		/// </summary>
		public virtual void Insert(TicketregistrationInfo ticketregistrationInfo)
		{
			try
			{
				new TicketregistrationTFM().Insert(ticketregistrationInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the ticket_registration table.
		/// </summary>
		public virtual void Update(TicketregistrationInfo ticketregistrationInfo)
		{
			try
			{
				new TicketregistrationTFM().Update(ticketregistrationInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the ticket_registration table.
		/// </summary>
		public virtual void Delete(int ticketid)
		{
			try
			{
				new TicketregistrationTFM().Delete(ticketid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the ticket_registration table by foreign key value.
		/// </summary>
		public void DeleteAllByNumber_plate(string number_plate)
		{
			try
			{
				new TicketregistrationTFM().DeleteAllByNumber_plate(number_plate);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - DeleteAllByNumber_plate" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the ticket_registration table by foreign key value.
		/// </summary>
		public void DeleteAllByStation(int station)
		{
			try
			{
				new TicketregistrationTFM().DeleteAllByStation(station);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - DeleteAllByStation" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the ticket_registration table by foreign key value.
		/// </summary>
		public void DeleteAllByTicket_type(int ticket_type)
		{
			try
			{
				new TicketregistrationTFM().DeleteAllByTicket_type(ticket_type);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - DeleteAllByTicket_type" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the ticket_registration table.
		/// </summary>
		public virtual TicketregistrationInfo Select(int ticketid)
		{
			try
			{
				return new TicketregistrationTFM().Select(ticketid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the ticket_registration table.
		/// </summary>
		public CHRTList<TicketregistrationInfo> SelectAll()
		{
			try
			{
				return new TicketregistrationTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the ticket_registration table.
		/// </summary>
		public CHRTList<TicketregistrationInfo> SelectAllByNumber_plate(string number_plate)
		{
			try
			{
				return new TicketregistrationTFM().SelectAllByNumber_plate(number_plate);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - SelectAllByNumber_plate()" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the ticket_registration table.
		/// </summary>
		public CHRTList<TicketregistrationInfo> SelectAllByStation(int station)
		{
			try
			{
				return new TicketregistrationTFM().SelectAllByStation(station);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - SelectAllByStation()" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the ticket_registration table.
		/// </summary>
		public CHRTList<TicketregistrationInfo> SelectAllByTicket_type(int ticket_type)
		{
			try
			{
				return new TicketregistrationTFM().SelectAllByTicket_type(ticket_type);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Ticketregistration - SelectAllByTicket_type()" + ex.Message);
				throw;
			}

		}

	}
}
