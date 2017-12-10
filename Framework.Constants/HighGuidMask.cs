using System;

namespace Framework.Constants
{
	[Flags]
	public enum HighGuidMask
	{
		None = 0,
		Object = 1,
		Item = 2,
		Container = 4,
		Unit = 8,
		Player = 16,
		GameObject = 32,
		DynamicObject = 64,
		Corpse = 128,
		Guild = 256
	}
}
