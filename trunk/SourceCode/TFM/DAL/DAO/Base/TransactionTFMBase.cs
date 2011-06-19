using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class TransactionTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public TransactionTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the transaction table.
		/// </summary>
		public virtual void Insert(TransactionInfo transactionInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@transactionid", transactionInfo.Transactionid),
				new SqlParameter("@station", transactionInfo.Station),
				new SqlParameter("@time", transactionInfo.Time),
				new SqlParameter("@userid", transactionInfo.Userid),
				new SqlParameter("@price", transactionInfo.Price),
				new SqlParameter("@car", transactionInfo.Car),
				new SqlParameter("@evidence", transactionInfo.Evidence)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "transaction_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the transaction table.
		/// </summary>
		public virtual void Update(TransactionInfo transactionInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@transactionid", transactionInfo.Transactionid),
				new SqlParameter("@station", transactionInfo.Station),
				new SqlParameter("@time", transactionInfo.Time),
				new SqlParameter("@userid", transactionInfo.Userid),
				new SqlParameter("@price", transactionInfo.Price),
				new SqlParameter("@car", transactionInfo.Car),
				new SqlParameter("@evidence", transactionInfo.Evidence)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "transaction_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the transaction table by its primary key.
		/// </summary>
		public virtual void Delete(int transactionid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@transactionid", transactionid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "transaction_Delete", parameters);
		}

		/// <summary>
		/// Deletes a record from the transaction table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByCar(string car)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@car", car)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "transaction_DeleteAllByCar", parameters);
		}

		/// <summary>
		/// Deletes a record from the transaction table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByEvidence(int evidence)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@evidence", evidence)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "transaction_DeleteAllByEvidence", parameters);
		}

		/// <summary>
		/// Deletes a record from the transaction table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByStation(int station)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@station", station)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "transaction_DeleteAllByStation", parameters);
		}

		/// <summary>
		/// Deletes a record from the transaction table by a foreign key.
		/// </summary>
		public virtual void DeleteAllByUserid(int userid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "transaction_DeleteAllByUserid", parameters);
		}

		/// <summary>
		/// Selects a single record from the transaction table.
		/// </summary>
		public virtual TransactionInfo Select(int transactionid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@transactionid", transactionid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "transaction_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeTransactionInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the transaction table.
		/// </summary>
		public CHRTList<TransactionInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "transaction_SelectAll"))
			{
				CHRTList<TransactionInfo> transactionInfoList = new CHRTList<TransactionInfo>();
				while (dataReader.Read())
				{
					TransactionInfo transactionInfo = MakeTransactionInfo(dataReader);
					transactionInfoList.Add(transactionInfo);
				}

				return transactionInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the transaction table by a foreign key.
		/// </summary>
		public virtual CHRTList<TransactionInfo> SelectAllByCar(string car)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@car", car)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "transaction_SelectAllByCar", parameters))
			{
				CHRTList<TransactionInfo> transactionInfoList = new CHRTList<TransactionInfo>();
				while (dataReader.Read())
				{
					TransactionInfo transactionInfo = MakeTransactionInfo(dataReader);
					transactionInfoList.Add(transactionInfo);
				}

				return transactionInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the transaction table by a foreign key.
		/// </summary>
		public virtual CHRTList<TransactionInfo> SelectAllByEvidence(int evidence)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@evidence", evidence)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "transaction_SelectAllByEvidence", parameters))
			{
				CHRTList<TransactionInfo> transactionInfoList = new CHRTList<TransactionInfo>();
				while (dataReader.Read())
				{
					TransactionInfo transactionInfo = MakeTransactionInfo(dataReader);
					transactionInfoList.Add(transactionInfo);
				}

				return transactionInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the transaction table by a foreign key.
		/// </summary>
		public virtual CHRTList<TransactionInfo> SelectAllByStation(int station)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@station", station)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "transaction_SelectAllByStation", parameters))
			{
				CHRTList<TransactionInfo> transactionInfoList = new CHRTList<TransactionInfo>();
				while (dataReader.Read())
				{
					TransactionInfo transactionInfo = MakeTransactionInfo(dataReader);
					transactionInfoList.Add(transactionInfo);
				}

				return transactionInfoList;
			}
		}

		/// <summary>
		/// Selects all records from the transaction table by a foreign key.
		/// </summary>
		public virtual CHRTList<TransactionInfo> SelectAllByUserid(int userid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@userid", userid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "transaction_SelectAllByUserid", parameters))
			{
				CHRTList<TransactionInfo> transactionInfoList = new CHRTList<TransactionInfo>();
				while (dataReader.Read())
				{
					TransactionInfo transactionInfo = MakeTransactionInfo(dataReader);
					transactionInfoList.Add(transactionInfo);
				}

				return transactionInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the transaction class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual TransactionInfo MakeTransactionInfo(SqlDataReader dataReader)
		{
			TransactionInfo transactionInfo = new TransactionInfo();
			transactionInfo.Transactionid = SqlClientUtility.GetInt32(dataReader,DbConstants.TRANSACTION.TRANSACTIONID, 0);
			transactionInfo.Station = SqlClientUtility.GetInt32(dataReader,DbConstants.TRANSACTION.STATION, 0);
			transactionInfo.Time = SqlClientUtility.GetInt32(dataReader,DbConstants.TRANSACTION.TIME, 0);
			transactionInfo.Userid = SqlClientUtility.GetInt32(dataReader,DbConstants.TRANSACTION.USERID, 0);
			transactionInfo.Price = SqlClientUtility.GetString(dataReader,DbConstants.TRANSACTION.PRICE, String.Empty);
			transactionInfo.Car = SqlClientUtility.GetString(dataReader,DbConstants.TRANSACTION.CAR, String.Empty);
			transactionInfo.Evidence = SqlClientUtility.GetInt32(dataReader,DbConstants.TRANSACTION.EVIDENCE, 0);

			return transactionInfo;
		}

		#endregion
	}
}
