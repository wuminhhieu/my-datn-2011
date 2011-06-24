using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface ITicketregistrationService
	{
		/// <summary>
		/// Saves a record to the ticket_registration table.
		/// </summary>
		void Insert(TicketregistrationInfo ticketregistrationInfo);

		/// <summary>
		/// Saves a record to the ticket_registration table.
		/// </summary>
		void Update(TicketregistrationInfo ticketregistrationInfo);

		/// <summary>
		/// Delete a record from the ticket_registration table.
		/// </summary>
		void Delete(int ticketid);

		/// <summary>
		/// Deletes all records from the ticket_registration table by foreign key value.
		/// </summary>
		void DeleteAllByNumber_plate(string number_plate);

		/// <summary>
		/// Deletes all records from the ticket_registration table by foreign key value.
		/// </summary>
		void DeleteAllByStation(int station);

		/// <summary>
		/// Deletes all records from the ticket_registration table by foreign key value.
		/// </summary>
		void DeleteAllByTicket_type(int ticket_type);

		/// <summary>
		/// Selects a single record from the ticket_registration table.
		/// </summary>
		TicketregistrationInfo Select(int ticketid);

		/// <summary>
		/// Selects all records from the ticket_registration table.
		/// </summary>
		CHRTList<TicketregistrationInfo> SelectAll();

		/// <summary>
		/// Selects all records from the ticket_registration table by foreign key value.
		/// </summary>
		CHRTList<TicketregistrationInfo> SelectAllByNumber_plate(string number_plate);

		/// <summary>
		/// Selects all records from the ticket_registration table by foreign key value.
		/// </summary>
		CHRTList<TicketregistrationInfo> SelectAllByStation(int station);

		/// <summary>
		/// Selects all records from the ticket_registration table by foreign key value.
		/// </summary>
		CHRTList<TicketregistrationInfo> SelectAllByTicket_type(int ticket_type);

	}
}
