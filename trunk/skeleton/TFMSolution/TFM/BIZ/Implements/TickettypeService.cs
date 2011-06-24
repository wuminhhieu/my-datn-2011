using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;


namespace TFM.Biz.Implements
{
	public class TickettypeService: ITickettypeService
	{
		/// <summary>
		/// Saves a record to the ticket_type table.
		/// </summary>
		public virtual void Insert(TickettypeInfo tickettypeInfo)
		{
			try
			{
				new TickettypeTFM().Insert(tickettypeInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Tickettype - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the ticket_type table.
		/// </summary>
		public virtual void Update(TickettypeInfo tickettypeInfo)
		{
			try
			{
				new TickettypeTFM().Update(tickettypeInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Tickettype - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the ticket_type table.
		/// </summary>
		public virtual void Delete(int ticket_type_id)
		{
			try
			{
				new TickettypeTFM().Delete(ticket_type_id);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Tickettype - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the ticket_type table.
		/// </summary>
		public virtual TickettypeInfo Select(int ticket_type_id)
		{
			try
			{
				return new TickettypeTFM().Select(ticket_type_id);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Tickettype - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the ticket_type table.
		/// </summary>
		public CHRTList<TickettypeInfo> SelectAll()
		{
			try
			{
				return new TickettypeTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Tickettype - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
