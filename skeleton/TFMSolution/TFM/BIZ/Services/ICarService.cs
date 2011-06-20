using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface ICarService
	{
		/// <summary>
		/// Saves a record to the car table.
		/// </summary>
		void Insert(CarInfo carInfo);

		/// <summary>
		/// Saves a record to the car table.
		/// </summary>
		void Update(CarInfo carInfo);

		/// <summary>
		/// Delete a record from the car table.
		/// </summary>
		void Delete(string number_plate);

		/// <summary>
		/// Deletes all records from the car table by foreign key value.
		/// </summary>
		void DeleteAllByCar_type(int car_type);

		/// <summary>
		/// Selects a single record from the car table.
		/// </summary>
		CarInfo Select(string number_plate);

		/// <summary>
		/// Selects all records from the car table.
		/// </summary>
		CHRTList<CarInfo> SelectAll();

		/// <summary>
		/// Selects all records from the car table by foreign key value.
		/// </summary>
		CHRTList<CarInfo> SelectAllByCar_type(int car_type);

	}
}
