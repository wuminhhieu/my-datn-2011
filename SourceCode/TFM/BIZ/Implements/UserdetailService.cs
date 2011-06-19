using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;

namespace TFM.Biz.Implements
{
	public class UserdetailService: IUserdetailService
	{
		/// <summary>
		/// Saves a record to the user_detail table.
		/// </summary>
		public virtual void Insert(UserdetailInfo userdetailInfo)
		{
			try
			{
				new UserdetailTFM().Insert(userdetailInfo);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Userdetail - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the user_detail table.
		/// </summary>
		public virtual void Update(UserdetailInfo userdetailInfo)
		{
			try
			{
				new UserdetailTFM().Update(userdetailInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Userdetail - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the user_detail table.
		/// </summary>
		public virtual void Delete(int userid)
		{
			try
			{
				new UserdetailTFM().Delete(userid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Userdetail - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the user_detail table by foreign key value.
		/// </summary>
		public void DeleteAllByUserid(int userid)
		{
			try
			{
				new UserdetailTFM().DeleteAllByUserid(userid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Userdetail - DeleteAllByUserid" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the user_detail table.
		/// </summary>
		public virtual UserdetailInfo Select(int userid)
		{
			try
			{
				return new UserdetailTFM().Select(userid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Userdetail - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the user_detail table.
		/// </summary>
		public CHRTList<UserdetailInfo> SelectAll()
		{
			try
			{
				return new UserdetailTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Userdetail - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the user_detail table.
		/// </summary>
		public CHRTList<UserdetailInfo> SelectAllByUserid(int userid)
		{
			try
			{
				return new UserdetailTFM().SelectAllByUserid(userid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Userdetail - SelectAllByUserid()" + ex.Message);
				throw;
			}

		}

	}
}
