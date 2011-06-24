using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface IFareService
	{
		/// <summary>
		/// Saves a record to the fare table.
		/// </summary>
		void Insert(FareInfo fareInfo);

		/// <summary>
		/// Saves a record to the fare table.
		/// </summary>
		void Update(FareInfo fareInfo);

		/// <summary>
		/// Delete a record from the fare table.
		/// </summary>
		void Delete(int fareid);

		/// <summary>
		/// Deletes all records from the fare table by foreign key value.
		/// </summary>
		void DeleteAllByCar_group(int car_group);

		/// <summary>
		/// Deletes all records from the fare table by foreign key value.
		/// </summary>
		void DeleteAllByStation(int station);

		/// <summary>
		/// Deletes all records from the fare table by foreign key value.
		/// </summary>
		void DeleteAllByTicket_type(int ticket_type);

		/// <summary>
		/// Selects a single record from the fare table.
		/// </summary>
		FareInfo Select(int fareid);

		/// <summary>
		/// Selects all records from the fare table.
		/// </summary>
		CHRTList<FareInfo> SelectAll();

		/// <summary>
		/// Selects all records from the fare table by foreign key value.
		/// </summary>
		CHRTList<FareInfo> SelectAllByCar_group(int car_group);

		/// <summary>
		/// Selects all records from the fare table by foreign key value.
		/// </summary>
		CHRTList<FareInfo> SelectAllByStation(int station);

		/// <summary>
		/// Selects all records from the fare table by foreign key value.
		/// </summary>
		CHRTList<FareInfo> SelectAllByTicket_type(int ticket_type);

	}
}
