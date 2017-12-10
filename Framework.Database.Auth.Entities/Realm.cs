using System;

namespace Framework.Database.Auth.Entities
{
	public class Realm
	{
		public int Id
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string IP
		{
			get;
			set;
		}

		public ushort Port
		{
			get;
			set;
		}

		public byte Type
		{
			get;
			set;
		}

		public byte Status
		{
			get;
			set;
		}

		public byte Flags
		{
			get;
			set;
		}
	}
}
