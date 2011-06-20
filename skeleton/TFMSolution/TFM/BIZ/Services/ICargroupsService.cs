using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface ICargroupsService
	{
		/// <summary>
		/// Saves a record to the car_groups table.
		/// </summary>
		void Insert(CargroupsInfo cargroupsInfo);

		/// <summary>
		/// Saves a record to the car_groups table.
		/// </summary>
		void Update(CargroupsInfo cargroupsInfo);

		/// <summary>
		/// Delete a record from the car_groups table.
		/// </summary>
		void Delete(int groupid);

		/// <summary>
		/// Selects a single record from the car_groups table.
		/// </summary>
		CargroupsInfo Select(int groupid);

		/// <summary>
		/// Selects all records from the car_groups table.
		/// </summary>
		CHRTList<CargroupsInfo> SelectAll();

	}
}
