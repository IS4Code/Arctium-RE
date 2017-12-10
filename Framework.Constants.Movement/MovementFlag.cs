using System;

namespace Framework.Constants.Movement
{
	[Flags]
	public enum MovementFlag
	{
		Forward = 1,
		Backward = 2,
		StrafeLeft = 4,
		StrafeRight = 8,
		TurnLeft = 16,
		TurnRight = 32,
		PitchUp = 64,
		PitchDown = 128,
		RunMode = 256,
		Gravity = 512,
		Root = 1024,
		Falling = 2048,
		FallReset = 4096,
		PendingStop = 8192,
		PendingStrafeStop = 16384,
		PendingForward = 32768,
		PendingBackward = 65536,
		PendingStrafeLeft = 131072,
		PendingStrafeRight = 262144,
		PendingRoot = 524288,
		Swim = 1048576,
		Ascension = 2097152,
		Descension = 4194304,
		CanFly = 8388608,
		Flight = 16777216,
		IsSteppingUp = 33554432,
		WalkOnWater = 67108864,
		FeatherFall = 134217728,
		HoverMove = 268435456,
		Collision = 536870912,
		DoubleJump = 1073741824
	}
}
