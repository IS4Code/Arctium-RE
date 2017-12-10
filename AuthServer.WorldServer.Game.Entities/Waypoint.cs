using Framework.ObjectDefines;
using System;

namespace AuthServer.WorldServer.Game.Entities
{
	public class Waypoint
	{
		public ulong CreatureGuid
		{
			get;
			set;
		}

		public Vector4 Point
		{
			get;
			set;
		}

		public int Index
		{
			get;
			set;
		}

		public int WaitTime
		{
			get;
			set;
		}
	}
}
