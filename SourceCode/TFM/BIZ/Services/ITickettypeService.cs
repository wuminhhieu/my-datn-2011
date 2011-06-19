using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface ITickettypeService
	{
		/// <summary>
		/// Saves a record to the ticket_type table.
		/// </summary>
		void Insert(TickettypeInfo tickettypeInfo);

		/// <summary>
		/// Saves a record to the ticket_type table.
		/// </summary>
		void Update(TickettypeInfo tickettypeInfo);

		/// <summary>
		/// Delete a record from the ticket_type table.
		/// </summary>
		void Delete(int ticket_type_id);

		/// <summary>
		/// Selects a single record from the ticket_type table.
		/// </summary>
		TickettypeInfo Select(int ticket_type_id);

		/// <summary>
		/// Selects all records from the ticket_type table.
		/// </summary>
		CHRTList<TickettypeInfo> SelectAll();

	}
}
