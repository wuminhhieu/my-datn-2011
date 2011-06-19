using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface IRolepermissionsService
	{
		/// <summary>
		/// Selects all records from the role_permissions table.
		/// </summary>
		CHRTList<RolepermissionsInfo> SelectAll();

	}
}
