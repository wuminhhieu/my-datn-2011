using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface IEvidenceService
	{
		/// <summary>
		/// Saves a record to the evidence table.
		/// </summary>
		void Insert(EvidenceInfo evidenceInfo);

		/// <summary>
		/// Saves a record to the evidence table.
		/// </summary>
		void Update(EvidenceInfo evidenceInfo);

		/// <summary>
		/// Delete a record from the evidence table.
		/// </summary>
		void Delete(int evidenceid);

		/// <summary>
		/// Selects a single record from the evidence table.
		/// </summary>
		EvidenceInfo Select(int evidenceid);

		/// <summary>
		/// Selects all records from the evidence table.
		/// </summary>
		CHRTList<EvidenceInfo> SelectAll();

	}
}
