using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

using TFM.DAL.Utils;
using TFM.Common.Models;

namespace TFM.DAL.Base
{
	public class EvidenceTFMBase
	{
		#region Fields

		protected string connectionStringName;

		#endregion

		#region Constructors

		public EvidenceTFMBase(string connectionStringName)
		{
			this.connectionStringName = connectionStringName;
		}

		#endregion

		#region Methods

		/// <summary>
		/// Saves a record to the evidence table.
		/// </summary>
		public virtual void Insert(EvidenceInfo evidenceInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@name", evidenceInfo.Name),
				new SqlParameter("@image_uri", evidenceInfo.Image_uri),
				new SqlParameter("@note", evidenceInfo.Note)
			};

			evidenceInfo.Evidenceid = (int) SqlClientUtility.ExecuteScalar(connectionStringName, CommandType.StoredProcedure, "evidence_Insert", parameters);
		}

		/// <summary>
		/// Updates a record in the evidence table.
		/// </summary>
		public virtual void Update(EvidenceInfo evidenceInfo)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@evidenceid", evidenceInfo.Evidenceid),
				new SqlParameter("@name", evidenceInfo.Name),
				new SqlParameter("@image_uri", evidenceInfo.Image_uri),
				new SqlParameter("@note", evidenceInfo.Note)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "evidence_Update", parameters);
		}

		/// <summary>
		/// Deletes a record from the evidence table by its primary key.
		/// </summary>
		public virtual void Delete(int evidenceid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@evidenceid", evidenceid)
			};

			SqlClientUtility.ExecuteNonQuery(connectionStringName, CommandType.StoredProcedure, "evidence_Delete", parameters);
		}

		/// <summary>
		/// Selects a single record from the evidence table.
		/// </summary>
		public virtual EvidenceInfo Select(int evidenceid)
		{
			SqlParameter[] parameters = new SqlParameter[]
			{
				new SqlParameter("@evidenceid", evidenceid)
			};

			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "evidence_Select", parameters))
			{
				if (dataReader.Read())
				{
					return MakeEvidenceInfo(dataReader);
				}
				else
				{
					return null;
				}
			}
		}

		/// <summary>
		/// Selects all records from the evidence table.
		/// </summary>
		public CHRTList<EvidenceInfo> SelectAll()
		{
			using (SqlDataReader dataReader = SqlClientUtility.ExecuteReader(connectionStringName, CommandType.StoredProcedure, "evidence_SelectAll"))
			{
				CHRTList<EvidenceInfo> evidenceInfoList = new CHRTList<EvidenceInfo>();
				while (dataReader.Read())
				{
					EvidenceInfo evidenceInfo = MakeEvidenceInfo(dataReader);
					evidenceInfoList.Add(evidenceInfo);
				}

				return evidenceInfoList;
			}
		}

		/// <summary>
		/// Creates a new instance of the evidence class and populates it with data from the specified SqlDataReader.
		/// </summary>
		protected virtual EvidenceInfo MakeEvidenceInfo(SqlDataReader dataReader)
		{
			EvidenceInfo evidenceInfo = new EvidenceInfo();
			evidenceInfo.Evidenceid = SqlClientUtility.GetInt32(dataReader,DbConstants.EVIDENCE.EVIDENCEID, 0);
			evidenceInfo.Name = SqlClientUtility.GetString(dataReader,DbConstants.EVIDENCE.NAME, String.Empty);
			evidenceInfo.Image_uri = SqlClientUtility.GetString(dataReader,DbConstants.EVIDENCE.IMAGE_URI, String.Empty);
			evidenceInfo.Note = SqlClientUtility.GetString(dataReader,DbConstants.EVIDENCE.NOTE, String.Empty);

			return evidenceInfo;
		}

		#endregion
	}
}
