using System;

namespace TFM.Common.Models.Base
{
	[Serializable]
	public class EvidenceInfoBase
	{
		#region Fields

		private int evidenceid;
		private string name;
		private string image_uri;
		private string note;

		#endregion

		#region Constructors

		/// <summary>
		/// Initializes a new instance of the EvidenceInfoBase class.
		/// </summary>
		public EvidenceInfoBase()
		{
		}

		/// <summary>
		/// Initializes a new instance of the EvidenceInfoBase class.
		/// </summary>
		public EvidenceInfoBase(string name, string image_uri, string note)
		{
			this.name = name;
			this.image_uri = image_uri;
			this.note = note;
		}

		/// <summary>
		/// Initializes a new instance of the EvidenceInfoBase class.
		/// </summary>
		public EvidenceInfoBase(int evidenceid, string name, string image_uri, string note)
		{
			this.evidenceid = evidenceid;
			this.name = name;
			this.image_uri = image_uri;
			this.note = note;
		}

		#endregion

		#region Properties
		/// <summary>
		/// Gets or sets the Evidenceid value.
		/// </summary>
		public int Evidenceid
		{
			get { return evidenceid; }
			set { evidenceid = value; }
		}

		/// <summary>
		/// Gets or sets the Name value.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Gets or sets the Image_uri value.
		/// </summary>
		public string Image_uri
		{
			get { return image_uri; }
			set { image_uri = value; }
		}

		/// <summary>
		/// Gets or sets the Note value.
		/// </summary>
		public string Note
		{
			get { return note; }
			set { note = value; }
		}

		#endregion
	}
}
