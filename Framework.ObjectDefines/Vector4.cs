using System;
using System.Runtime.Serialization;

namespace Framework.ObjectDefines
{
	[DataContract]
	[Serializable]
	public class Vector4
	{
		[DataMember]
		public float X
		{
			get;
			set;
		}

		[DataMember]
		public float Y
		{
			get;
			set;
		}

		[DataMember]
		public float Z
		{
			get;
			set;
		}

		[DataMember]
		public float O
		{
			get;
			set;
		}
	}
}
