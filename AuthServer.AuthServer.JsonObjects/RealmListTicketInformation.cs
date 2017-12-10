using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace AuthServer.AuthServer.JsonObjects
{
	[DataContract]
	public class RealmListTicketInformation
	{
		[DataMember(Name = "platform")]
		public int Platform
		{
			get;
			set;
		}

		[DataMember(Name = "currentTime")]
		public int CurrentTime
		{
			get;
			set;
		}

		[DataMember(Name = "buildVariant")]
		public string BuildVariant
		{
			get;
			set;
		}

		[DataMember(Name = "timeZone")]
		public string Timezone
		{
			get;
			set;
		}

		[DataMember(Name = "versionDataBuild")]
		public int VersionDataBuild
		{
			get;
			set;
		}

		[DataMember(Name = "audioLocale")]
		public int AudioLocale
		{
			get;
			set;
		}

		[DataMember(Name = "version")]
		public ClientVersion ClientVersion
		{
			get;
			set;
		}

		[DataMember(Name = "secret")]
		public List<int> Secret
		{
			get;
			set;
		}

		[DataMember(Name = "type")]
		public int Type
		{
			get;
			set;
		}

		[DataMember(Name = "textLocale")]
		public int TextLocale
		{
			get;
			set;
		}
	}
}
