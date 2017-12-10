using System;

namespace Arctium_WoW_ClientDB_Viewer.IO
{
	internal class LalField
	{
		public string Name
		{
			get;
			set;
		}

		public Type Type
		{
			get;
			set;
		}

		public int Bits
		{
			get;
			set;
		}

		public int Count
		{
			get;
			set;
		}

		public string CountField
		{
			get;
			set;
		}

		public object Value
		{
			get;
			set;
		}

		public LalField()
		{
			this.<Bits>k__BackingField = -1;
			this.<Count>k__BackingField = -1;
			base..ctor();
		}
	}
}
