using System;

namespace Framework.Constants
{
	[Flags]
	public enum UpdateFieldFlags
	{
		None = 0,
		All = 1,
		Self = 2,
		Owner = 4,
		Empath = 16,
		Party = 32,
		UnitAll = 64,
		ViewerDependet = 128,
		Urgent = 256,
		UrgentSelfOnly = 512
	}
}
