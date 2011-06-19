using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;

namespace TFM.Biz.Implements
{
	public class RolepermissionsService: IRolepermissionsService
	{
		/// <summary>
		/// Selects all records from the role_permissions table.
		/// </summary>
		public CHRTList<RolepermissionsInfo> SelectAll()
		{
			try
			{
				return new RolepermissionsTFM().SelectAll();
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Rolepermissions - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
