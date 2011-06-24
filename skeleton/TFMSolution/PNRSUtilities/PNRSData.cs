using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TFM.Common.Models;
namespace PNRSUtilities
{
    public sealed class PNRSData
    {
        public static PNRSData PNRSDataObj = new PNRSData();

        private PNRSData() 
        {
            data = string.Empty;
            priceList = null;
        }

        public List<FareInfo> priceList;

        public string data;
        
    }
}
