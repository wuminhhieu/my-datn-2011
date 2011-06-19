using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;

namespace TFM.Biz.Implements
{
	public class EvidenceService: IEvidenceService
	{
		/// <summary>
		/// Saves a record to the evidence table.
		/// </summary>
		public virtual void Insert(EvidenceInfo evidenceInfo)
		{
			try
			{
				new EvidenceTFM().Insert(evidenceInfo);
			}
			catch (Exception ex)
			{
                //Log error by TFM framwork here
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Evidence - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the evidence table.
		/// </summary>
		public virtual void Update(EvidenceInfo evidenceInfo)
		{
			try
			{
				new EvidenceTFM().Update(evidenceInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Evidence - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the evidence table.
		/// </summary>
		public virtual void Delete(int evidenceid)
		{
			try
			{
				new EvidenceTFM().Delete(evidenceid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Evidence - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the evidence table.
		/// </summary>
		public virtual EvidenceInfo Select(int evidenceid)
		{
			try
			{
				return new EvidenceTFM().Select(evidenceid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Evidence - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the evidence table.
		/// </summary>
		public CHRTList<EvidenceInfo> SelectAll()
		{
			try
			{
				return new EvidenceTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Evidence - SelectAll" + ex.Message);
				throw;
			}

		}

	}
}
