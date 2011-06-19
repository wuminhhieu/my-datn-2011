using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;


namespace TFM.Biz.Implements
{
	public class RolesService: IRolesService
	{
		/// <summary>
		/// Saves a record to the roles table.
		/// </summary>
		public virtual void Insert(RolesInfo rolesInfo)
		{
			try
			{
				new RolesTFM().Insert(rolesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Roles - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the roles table.
		/// </summary>
		public virtual void Update(RolesInfo rolesInfo)
		{
			try
			{
				new RolesTFM().Update(rolesInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Roles - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the roles table.
		/// </summary>
		public virtual void Delete(int roleid)
		{
			try
			{
				new RolesTFM().Delete(roleid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Roles - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the roles table.
		/// </summary>
		public virtual RolesInfo Select(int roleid)
		{
			try
			{
				return new RolesTFM().Select(roleid);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Roles - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the roles table.
		/// </summary>
		public CHRTList<RolesInfo> SelectAll()
		{
			try
			{
				return new RolesTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Roles - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
