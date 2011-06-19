using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface IUsersService
	{
		/// <summary>
		/// Saves a record to the users table.
		/// </summary>
		void Insert(UsersInfo usersInfo);

		/// <summary>
		/// Saves a record to the users table.
		/// </summary>
		void Update(UsersInfo usersInfo);

		/// <summary>
		/// Delete a record from the users table.
		/// </summary>
		void Delete(int userid);

		/// <summary>
		/// Deletes all records from the users table by foreign key value.
		/// </summary>
		void DeleteAllByRoleid(int roleid);

		/// <summary>
		/// Selects a single record from the users table.
		/// </summary>
		UsersInfo Select(int userid);

		/// <summary>
		/// Selects all records from the users table.
		/// </summary>
		CHRTList<UsersInfo> SelectAll();

		/// <summary>
		/// Selects all records from the users table by foreign key value.
		/// </summary>
		CHRTList<UsersInfo> SelectAllByRoleid(int roleid);

	}
}
