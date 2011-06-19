using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface IStationService
	{
		/// <summary>
		/// Saves a record to the station table.
		/// </summary>
		void Insert(StationInfo stationInfo);

		/// <summary>
		/// Saves a record to the station table.
		/// </summary>
		void Update(StationInfo stationInfo);

		/// <summary>
		/// Delete a record from the station table.
		/// </summary>
		void Delete(int stationid);

		/// <summary>
		/// Selects a single record from the station table.
		/// </summary>
		StationInfo Select(int stationid);

		/// <summary>
		/// Selects all records from the station table.
		/// </summary>
		CHRTList<StationInfo> SelectAll();

	}
}
