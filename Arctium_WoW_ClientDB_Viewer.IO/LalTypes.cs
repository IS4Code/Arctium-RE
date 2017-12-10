using System;
using System.Collections.Generic;

namespace Arctium_WoW_ClientDB_Viewer.IO
{
	internal class LalTypes
	{
		public class LalGroup
		{
			public string Name
			{
				get;
				set;
			}

			public int Count
			{
				get;
				set;
			}

			public Dictionary<string, LalField> Fields
			{
				get;
				set;
			}
		}

		public class LalList
		{
			public Dictionary<string, LalField> Fields
			{
				get;
				set;
			}

			public List<Dictionary<string, LalField>> Values
			{
				get;
				set;
			}

			public LalList()
			{
				this.Fieldsk__BackingField = new Dictionary<string, LalField>();
				this.Valuesk__BackingField = new List<Dictionary<string, LalField>>();
				base..ctor();
			}
		}

		public class Bit
		{
			public int Count
			{
				get;
				set;
			}

			public int Value
			{
				get;
				set;
			}
		}
	}
}
