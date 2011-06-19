using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;

namespace TFM.Biz.Implements
{
	public class CarService: ICarService
	{
		/// <summary>
		/// Saves a record to the car table.
		/// </summary>
		public virtual void Insert(CarInfo carInfo)
		{
			try
			{
				new CarTFM().Insert(carInfo);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Car - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the car table.
		/// </summary>
		public virtual void Update(CarInfo carInfo)
		{
			try
			{
				new CarTFM().Update(carInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Car - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the car table.
		/// </summary>
		public virtual void Delete(string number_plate)
		{
			try
			{
				new CarTFM().Delete(number_plate);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Car - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the car table by foreign key value.
		/// </summary>
		public void DeleteAllByCar_type(int car_type)
		{
			try
			{
				new CarTFM().DeleteAllByCar_type(car_type);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Car - DeleteAllByCar_type" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the car table.
		/// </summary>
		public virtual CarInfo Select(string number_plate)
		{
			try
			{
				return new CarTFM().Select(number_plate);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Car - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the car table.
		/// </summary>
		public CHRTList<CarInfo> SelectAll()
		{
			try
			{
				return new CarTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Car - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the car table.
		/// </summary>
		public CHRTList<CarInfo> SelectAllByCar_type(int car_type)
		{
			try
			{
				return new CarTFM().SelectAllByCar_type(car_type);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Car - SelectAllByCar_type()" + ex.Message);
				throw;
			}

		}

	}
}
