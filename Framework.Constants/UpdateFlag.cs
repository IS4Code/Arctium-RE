using System;

namespace Framework.Constants
{
	[Flags]
	public enum UpdateFlag
	{
		Self = 1,
		Alive = 2,
		Rotation = 4,
		StationaryPosition = 8,
		Target = 16,
		Transport = 32,
		GoTransportPosition = 64,
		AnimKits = 128,
		Vehicle = 256
	}
}
