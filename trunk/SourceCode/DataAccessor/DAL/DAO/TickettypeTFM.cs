using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Base;
using TFM.DAL.Utils;

namespace TFM.DAL
{
	public class TickettypeTFM : TickettypeTFMBase
	{
		#region Constructors

		public TickettypeTFM()
			: base(Constants.CONNECTION_STRING_NAME)
		{
		}

		#endregion

		#region Methods


		#endregion
	}
}
