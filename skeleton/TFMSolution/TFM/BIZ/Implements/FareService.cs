using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;

namespace TFM.Biz.Implements
{
	public class FareService: IFareService
	{
		/// <summary>
		/// Saves a record to the fare table.
		/// </summary>
		public virtual void Insert(FareInfo fareInfo)
		{
			try
			{
				new FareTFM().Insert(fareInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the fare table.
		/// </summary>
		public virtual void Update(FareInfo fareInfo)
		{
			try
			{
				new FareTFM().Update(fareInfo);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the fare table.
		/// </summary>
		public virtual void Delete(int fareid)
		{
			try
			{
				new FareTFM().Delete(fareid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the fare table by foreign key value.
		/// </summary>
		public void DeleteAllByCar_group(int car_group)
		{
			try
			{
				new FareTFM().DeleteAllByCar_group(car_group);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - DeleteAllByCar_group" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the fare table by foreign key value.
		/// </summary>
		public void DeleteAllByTicket_type(int ticket_type)
		{
			try
			{
				new FareTFM().DeleteAllByTicket_type(ticket_type);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - DeleteAllByTicket_type" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the fare table.
		/// </summary>
		public virtual FareInfo Select(int fareid)
		{
			try
			{
				return new FareTFM().Select(fareid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the fare table.
		/// </summary>
		public CHRTList<FareInfo> SelectAll()
		{
			try
			{
				return new FareTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the fare table.
		/// </summary>
		public CHRTList<FareInfo> SelectAllByCar_group(int car_group)
		{
			try
			{
				return new FareTFM().SelectAllByCar_group(car_group);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - SelectAllByCar_group()" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the fare table.
		/// </summary>
		public CHRTList<FareInfo> SelectAllByTicket_type(int ticket_type)
		{
			try
			{
				return new FareTFM().SelectAllByTicket_type(ticket_type);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Fare - SelectAllByTicket_type()" + ex.Message);
				throw;
			}

		}

	}
}
