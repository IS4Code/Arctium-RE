using System;

namespace Framework.ObjectDefines
{
	[Serializable]
	public class SmartGuid
	{
		public ulong Guid
		{
			get;
			set;
		}

		public ulong HighGuid
		{
			get;
			set;
		}

		public ushort RealmId
		{
			get
			{
				return (ushort)(this.HighGuid >> 42 & 8191uL);
			}
			set
			{
				this.HighGuid |= (ulong)value << 42;
			}
		}

		public ulong CreationBits
		{
			get
			{
				return this.Guid & 18446744073709551615uL;
			}
			set
			{
				this.Guid |= value;
			}
		}

		public GuidType Type
		{
			get
			{
				return (GuidType)(this.HighGuid >> 58);
			}
			set
			{
				this.HighGuid |= (ulong)value << 58;
			}
		}

		public SmartGuid()
		{
		}

		public SmartGuid(ulong guid, int id, GuidType highType, ulong mapId = 0uL)
		{
			if (highType == GuidType.Creature)
			{
				this.Guid |= guid;
				this.HighGuid |= 4398046511104uL;
				this.HighGuid |= mapId << 29;
			}
			else
			{
				this.Guid = guid;
			}
			this.HighGuid = ((ulong)highType << 58 | (ulong)((ulong)((long)id) << 6));
		}

		public static GuidType GetGuidType(ulong guid)
		{
			return (GuidType)(guid >> 58);
		}

		public static int GetId(ulong guid)
		{
			return (int)(guid >> 6 & 4294967295uL);
		}
	}
}
