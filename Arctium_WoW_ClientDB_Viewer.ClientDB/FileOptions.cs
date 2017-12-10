using System;

namespace Arctium_WoW_ClientDB_Viewer.ClientDB
{
	[Flags]
	internal enum FileOptions
	{
		None = 0,
		DataOffset = 1,
		Unknown = 2,
		Index = 4
	}
}
