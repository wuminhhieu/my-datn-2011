using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface IRolesService
	{
		/// <summary>
		/// Saves a record to the roles table.
		/// </summary>
		void Insert(RolesInfo rolesInfo);

		/// <summary>
		/// Saves a record to the roles table.
		/// </summary>
		void Update(RolesInfo rolesInfo);

		/// <summary>
		/// Delete a record from the roles table.
		/// </summary>
		void Delete(int roleid);

		/// <summary>
		/// Selects a single record from the roles table.
		/// </summary>
		RolesInfo Select(int roleid);

		/// <summary>
		/// Selects all records from the roles table.
		/// </summary>
		CHRTList<RolesInfo> SelectAll();

	}
}
