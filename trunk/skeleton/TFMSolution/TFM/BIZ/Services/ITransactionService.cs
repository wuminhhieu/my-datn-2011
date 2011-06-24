using System;
using System.Collections.Generic;

using TFM.Common.Models;

namespace TFM.Biz.Services
{
	public interface ITransactionService
	{
		/// <summary>
		/// Saves a record to the transaction table.
		/// </summary>
		void Insert(TransactionInfo transactionInfo);

		/// <summary>
		/// Saves a record to the transaction table.
		/// </summary>
		void Update(TransactionInfo transactionInfo);

		/// <summary>
		/// Delete a record from the transaction table.
		/// </summary>
		void Delete(int transactionid);

		/// <summary>
		/// Deletes all records from the transaction table by foreign key value.
		/// </summary>
		void DeleteAllByNumber_plate(string number_plate);

		/// <summary>
		/// Deletes all records from the transaction table by foreign key value.
		/// </summary>
		void DeleteAllByEvidence(int evidence);

		/// <summary>
		/// Deletes all records from the transaction table by foreign key value.
		/// </summary>
		void DeleteAllByStation(int station);

		/// <summary>
		/// Deletes all records from the transaction table by foreign key value.
		/// </summary>
		void DeleteAllByUserid(int userid);

		/// <summary>
		/// Selects a single record from the transaction table.
		/// </summary>
		TransactionInfo Select(int transactionid);

		/// <summary>
		/// Selects all records from the transaction table.
		/// </summary>
		CHRTList<TransactionInfo> SelectAll();

		/// <summary>
		/// Selects all records from the transaction table by foreign key value.
		/// </summary>
		CHRTList<TransactionInfo> SelectAllByNumber_plate(string number_plate);

		/// <summary>
		/// Selects all records from the transaction table by foreign key value.
		/// </summary>
		CHRTList<TransactionInfo> SelectAllByEvidence(int evidence);

		/// <summary>
		/// Selects all records from the transaction table by foreign key value.
		/// </summary>
		CHRTList<TransactionInfo> SelectAllByStation(int station);

		/// <summary>
		/// Selects all records from the transaction table by foreign key value.
		/// </summary>
		CHRTList<TransactionInfo> SelectAllByUserid(int userid);

	}
}
