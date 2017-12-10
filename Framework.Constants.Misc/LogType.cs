using System;

namespace Framework.Constants.Misc
{
	[Flags]
	public enum LogType
	{
		None = 0,
		Init = 1,
		Normal = 2,
		Error = 4,
		Debug = 8,
		Packet = 16,
		Database = 32,
		Info = 64
	}
}
