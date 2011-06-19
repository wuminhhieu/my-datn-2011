using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Base;
using TFM.DAL.Utils;

namespace TFM.DAL
{
	public class TransactionTFM : TransactionTFMBase
	{
		#region Constructors

		public TransactionTFM()
			: base(Constants.CONNECTION_STRING_NAME)
		{
		}

		#endregion

		#region Methods


		#endregion
	}
}
