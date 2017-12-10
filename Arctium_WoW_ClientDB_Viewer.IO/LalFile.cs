using Arctium_WoW_ClientDB_Viewer.ClientDB;
using System;
using System.Collections.Generic;

namespace Arctium_WoW_ClientDB_Viewer.IO
{
	internal class LalFile
	{
		public string TypeName
		{
			get;
			set;
		}

		public FileOptions FileOptions
		{
			get;
			set;
		}

		public Dictionary<string, LalField> Fields
		{
			get;
			set;
		}

		public LalFile()
		{
			this.Fieldsk__BackingField = new Dictionary<string, LalField>();
			base..ctor();
		}
	}
}
