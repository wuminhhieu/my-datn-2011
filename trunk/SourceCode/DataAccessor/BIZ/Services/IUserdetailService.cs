using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface IUserdetailService
	{
		/// <summary>
		/// Saves a record to the user_detail table.
		/// </summary>
		void Insert(UserdetailInfo userdetailInfo);

		/// <summary>
		/// Saves a record to the user_detail table.
		/// </summary>
		void Update(UserdetailInfo userdetailInfo);

		/// <summary>
		/// Delete a record from the user_detail table.
		/// </summary>
		void Delete(int userid);

		/// <summary>
		/// Deletes all records from the user_detail table by foreign key value.
		/// </summary>
		void DeleteAllByUserid(int userid);

		/// <summary>
		/// Selects a single record from the user_detail table.
		/// </summary>
		UserdetailInfo Select(int userid);

		/// <summary>
		/// Selects all records from the user_detail table.
		/// </summary>
		CHRTList<UserdetailInfo> SelectAll();

		/// <summary>
		/// Selects all records from the user_detail table by foreign key value.
		/// </summary>
		CHRTList<UserdetailInfo> SelectAllByUserid(int userid);

	}
}
