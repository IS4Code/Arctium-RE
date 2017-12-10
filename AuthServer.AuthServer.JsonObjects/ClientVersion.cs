using System;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class ClientVersion
	{
		[DataMember(Name = "versionMajor")]
		public int Major
		{
			get;
			set;
		}

		[DataMember(Name = "versionBuild")]
		public int Build
		{
			get;
			set;
		}

		[DataMember(Name = "versionMinor")]
		public int Minor
		{
			get;
			set;
		}

		[DataMember(Name = "versionRevision")]
		public int Revision
		{
			get;
			set;
		}
	}
}
