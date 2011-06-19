using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface ICartypeService
	{
		/// <summary>
		/// Saves a record to the car_type table.
		/// </summary>
		void Insert(CartypeInfo cartypeInfo);

		/// <summary>
		/// Saves a record to the car_type table.
		/// </summary>
		void Update(CartypeInfo cartypeInfo);

		/// <summary>
		/// Delete a record from the car_type table.
		/// </summary>
		void Delete(int typeid);

		/// <summary>
		/// Selects a single record from the car_type table.
		/// </summary>
		CartypeInfo Select(int typeid);

		/// <summary>
		/// Selects all records from the car_type table.
		/// </summary>
		CHRTList<CartypeInfo> SelectAll();

	}
}
