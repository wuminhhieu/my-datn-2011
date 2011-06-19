using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;

namespace TFM.Biz.Implements
{
	public class StationService: IStationService
	{
		/// <summary>
		/// Saves a record to the station table.
		/// </summary>
		public virtual void Insert(StationInfo stationInfo)
		{
			try
			{
				new StationTFM().Insert(stationInfo);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Station - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the station table.
		/// </summary>
		public virtual void Update(StationInfo stationInfo)
		{
			try
			{
				new StationTFM().Update(stationInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Station - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the station table.
		/// </summary>
		public virtual void Delete(int stationid)
		{
			try
			{
				new StationTFM().Delete(stationid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Station - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the station table.
		/// </summary>
		public virtual StationInfo Select(int stationid)
		{
			try
			{
				return new StationTFM().Select(stationid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Station - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the station table.
		/// </summary>
		public CHRTList<StationInfo> SelectAll()
		{
			try
			{
				return new StationTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Station - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
