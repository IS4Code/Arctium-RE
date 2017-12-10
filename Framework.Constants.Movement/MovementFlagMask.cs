using System;

namespace Framework.Constants.Movement
{
	[Flags]
	public enum MovementFlagMask
	{
		FreeLook = 0,
		MovePlayer = 3,
		StrafePlayer = 12,
		TurnPlayer = 48,
		PitchPlayer = 192
	}
}
