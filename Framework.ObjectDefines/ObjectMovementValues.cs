using Framework.Constants;
using Framework.Constants.Movement;
using System;

namespace Framework.ObjectDefines
{
	public class ObjectMovementValues
	{
		public bool HasAnimKits;

		public bool HasUnknown;

		public uint BitCounter;

		public bool Bit0;

		public bool HasUnknown2;

		public bool IsVehicle;

		public bool Bit2;

		public bool HasUnknown3;

		public bool HasStationaryPosition;

		public bool HasGoTransportPosition;

		public bool IsSelf;

		public bool IsAlive;

		public uint BitCounter2;

		public bool Bit3;

		public bool HasUnknown4;

		public bool HasTarget;

		public bool Bit1;

		public bool HasRotation;

		public bool IsTransport;

		public bool HasMovementFlags;

		public bool HasMovementFlags2;

		public bool IsFallingOrJumping;

		public bool HasJumpData;

		public bool IsAreaTrigger;

		public bool IsSceneObject;

		public MovementFlag MovementFlags;

		public MovementFlag2 MovementFlags2;

		public uint Time;

		public float JumpVelocity;

		public float Cos;

		public float Sin;

		public float CurrentSpeed;

		public uint FallTime;

		public ObjectMovementValues()
		{
		}

		public ObjectMovementValues(UpdateFlag updateflags)
		{
			this.IsSelf = ((updateflags & UpdateFlag.Self) > (UpdateFlag)0);
			this.IsAlive = ((updateflags & UpdateFlag.Alive) > (UpdateFlag)0);
			this.HasRotation = ((updateflags & UpdateFlag.Rotation) > (UpdateFlag)0);
			this.HasStationaryPosition = ((updateflags & UpdateFlag.StationaryPosition) > (UpdateFlag)0);
			this.HasTarget = ((updateflags & UpdateFlag.Target) > (UpdateFlag)0);
			this.IsTransport = ((updateflags & UpdateFlag.Transport) > (UpdateFlag)0);
			this.HasGoTransportPosition = ((updateflags & UpdateFlag.GoTransportPosition) > (UpdateFlag)0);
			this.HasAnimKits = ((updateflags & UpdateFlag.AnimKits) > (UpdateFlag)0);
			this.IsVehicle = ((updateflags & UpdateFlag.Vehicle) > (UpdateFlag)0);
		}
	}
}
