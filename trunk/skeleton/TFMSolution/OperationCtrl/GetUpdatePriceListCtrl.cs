using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TFM.Common.Models;

namespace OperationCtrl
{
    public partial class GetUpdatePriceListCtrl : Form
    {
        #region event
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fareInfo"></param>
        public delegate void UpdatePriceLsit(FareInfo fareInfo);

        /// <summary>
        /// 
        /// </summary>
        public event UpdatePriceLsit UpdateCurrenPriceList;
        #endregion

        #region public member


        public FareInfo fareInfo;
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fareInfo"></param>
        public void SetCurrentFareInfo(FareInfo fareInfo)
        {
            this.fareInfo = fareInfo;
        }
        public GetUpdatePriceListCtrl()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fareInfo.Apply_date = 1;
            fareInfo.Car_group = 2;
            fareInfo.Created_date = 3;

        }
}
}
