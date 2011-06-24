using System;
using System.Collections.Generic;

using TFM.DAL;
using TFM.Common.Models;
using TFM.Biz.Services;


namespace TFM.Biz.Implements
{
	public class TransactionService: ITransactionService
	{
		/// <summary>
		/// Saves a record to the transaction table.
		/// </summary>
		public virtual void Insert(TransactionInfo transactionInfo)
		{
			try
			{
				new TransactionTFM().Insert(transactionInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - Insert" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Saves a record to the transaction table.
		/// </summary>
		public virtual void Update(TransactionInfo transactionInfo)
		{
			try
			{
				new TransactionTFM().Update(transactionInfo);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - Update" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Delete a record from the transaction table.
		/// </summary>
		public virtual void Delete(int transactionid)
		{
			try
			{
				new TransactionTFM().Delete(transactionid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - Delete" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the transaction table by foreign key value.
		/// </summary>
		public void DeleteAllByNumber_plate(string number_plate)
		{
			try
			{
				new TransactionTFM().DeleteAllByNumber_plate(number_plate);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - DeleteAllByNumber_plate" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the transaction table by foreign key value.
		/// </summary>
		public void DeleteAllByEvidence(int evidence)
		{
			try
			{
				new TransactionTFM().DeleteAllByEvidence(evidence);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - DeleteAllByEvidence" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the transaction table by foreign key value.
		/// </summary>
		public void DeleteAllByStation(int station)
		{
			try
			{
				new TransactionTFM().DeleteAllByStation(station);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - DeleteAllByStation" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Deletes all records from the transaction table by foreign key value.
		/// </summary>
		public void DeleteAllByUserid(int userid)
		{
			try
			{
				new TransactionTFM().DeleteAllByUserid(userid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - DeleteAllByUserid" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects a single record from the transaction table.
		/// </summary>
		public virtual TransactionInfo Select(int transactionid)
		{
			try
			{
				return new TransactionTFM().Select(transactionid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - Select" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the transaction table.
		/// </summary>
		public CHRTList<TransactionInfo> SelectAll()
		{
			try
			{
				return new TransactionTFM().SelectAll();
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - SelectAll" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the transaction table.
		/// </summary>
		public CHRTList<TransactionInfo> SelectAllByNumber_plate(string number_plate)
		{
			try
			{
				return new TransactionTFM().SelectAllByNumber_plate(number_plate);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - SelectAllByNumber_plate()" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the transaction table.
		/// </summary>
		public CHRTList<TransactionInfo> SelectAllByEvidence(int evidence)
		{
			try
			{
				return new TransactionTFM().SelectAllByEvidence(evidence);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - SelectAllByEvidence()" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the transaction table.
		/// </summary>
		public CHRTList<TransactionInfo> SelectAllByStation(int station)
		{
			try
			{
				return new TransactionTFM().SelectAllByStation(station);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - SelectAllByStation()" + ex.Message);
				throw;
			}

		}

		/// <summary>
		/// Selects all records from the transaction table.
		/// </summary>
		public CHRTList<TransactionInfo> SelectAllByUserid(int userid)
		{
			try
			{
				return new TransactionTFM().SelectAllByUserid(userid);
			}
			catch (Exception ex)
			{
				//Provider.Log.Error(ex, "TFM.Biz.Implements.Transaction - SelectAllByUserid()" + ex.Message);
				throw;
			}

		}

	}
}
