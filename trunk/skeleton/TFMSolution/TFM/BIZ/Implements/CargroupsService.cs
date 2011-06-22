using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;

namespace TFM.Biz.Implements
{
	public class CargroupsService: ICargroupsService
	{
		/// <summary>
		/// Saves a record to the car_groups table.
		/// </summary>
		public virtual void Insert(CargroupsInfo cargroupsInfo)
		{
			try
			{
				new CargroupsTFM().Insert(cargroupsInfo);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cargroups - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the car_groups table.
		/// </summary>
		public virtual void Update(CargroupsInfo cargroupsInfo)
		{
			try
			{
				new CargroupsTFM().Update(cargroupsInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cargroups - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the car_groups table.
		/// </summary>
		public virtual void Delete(int groupid)
		{
			try
			{
				new CargroupsTFM().Delete(groupid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cargroups - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the car_groups table.
		/// </summary>
		public virtual CargroupsInfo Select(int groupid)
		{
			try
			{
				return new CargroupsTFM().Select(groupid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cargroups - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the car_groups table.
		/// </summary>
		public CHRTList<CargroupsInfo> SelectAll()
		{
			try
			{
				return new CargroupsTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Cargroups - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
