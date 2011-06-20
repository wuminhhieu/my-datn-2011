using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;
namespace TFM.Biz.Implements
{
	public class UsersService: IUsersService
	{
		/// <summary>
		/// Saves a record to the users table.
		/// </summary>
		public virtual void Insert(UsersInfo usersInfo)
		{
			try
			{
				new UsersTFM().Insert(usersInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Users - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the users table.
		/// </summary>
		public virtual void Update(UsersInfo usersInfo)
		{
			try
			{
				new UsersTFM().Update(usersInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Users - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the users table.
		/// </summary>
		public virtual void Delete(int userid)
		{
			try
			{
				new UsersTFM().Delete(userid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Users - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the users table by foreign key value.
		/// </summary>
		public void DeleteAllByRoleid(int roleid)
		{
			try
			{
				new UsersTFM().DeleteAllByRoleid(roleid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Users - DeleteAllByRoleid" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the users table.
		/// </summary>
		public virtual UsersInfo Select(int userid)
		{
			try
			{
				return new UsersTFM().Select(userid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Users - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the users table.
		/// </summary>
		public CHRTList<UsersInfo> SelectAll()
		{
			try
			{
				return new UsersTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Users - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the users table.
		/// </summary>
		public CHRTList<UsersInfo> SelectAllByRoleid(int roleid)
		{
			try
			{
				return new UsersTFM().SelectAllByRoleid(roleid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Users - SelectAllByRoleid()" + ex.Message);
				throw;
			}

		}

	}
}
