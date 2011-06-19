using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;


namespace TFM.Biz.Implements
{
	public class CartypeService: ICartypeService
	{
		/// <summary>
		/// Saves a record to the car_type table.
		/// </summary>
		public virtual void Insert(CartypeInfo cartypeInfo)
		{
			try
			{
				new CartypeTFM().Insert(cartypeInfo);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cartype - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the car_type table.
		/// </summary>
		public virtual void Update(CartypeInfo cartypeInfo)
		{
			try
			{
				new CartypeTFM().Update(cartypeInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cartype - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the car_type table.
		/// </summary>
		public virtual void Delete(int typeid)
		{
			try
			{
				new CartypeTFM().Delete(typeid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cartype - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the car_type table.
		/// </summary>
		public virtual CartypeInfo Select(int typeid)
		{
			try
			{
				return new CartypeTFM().Select(typeid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cartype - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the car_type table.
		/// </summary>
		public CHRTList<CartypeInfo> SelectAll()
		{
			try
			{
				return new CartypeTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cartype - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
