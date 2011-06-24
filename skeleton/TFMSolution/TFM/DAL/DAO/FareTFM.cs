using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using TFM.DAL.Base;
using TFM.DAL.Utils;
using TFM.Common.Models;
namespace TFM.DAL
{
	public class FareTFM : FareTFMBase
	{
		#region Constructors

		public FareTFM()
			: base(Constants.CONNECTION_STRING_NAME)
		{
		}

		#endregion

		#region Methods
        public List<FareInfo> GetActiveFareInfo() 
        {
            List<FareInfo> activeFare = new List<FareInfo>();
            return activeFare;
        }

		#endregion
	}
}
