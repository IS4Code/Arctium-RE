using System;

namespace Framework.Constants
{
	public class MovementSpeed
	{
		public static float WalkSpeed = 2.5f;

		public static float RunSpeed;

		public static float SwimSpeed;

		public static float SwimBackSpeed;

		public static float RunBackSpeed;

		public static float TurnSpeed;

		public static float FlySpeed;

		public static float FlyBackSpeed;

		public static float PitchSpeed;

		static MovementSpeed()
		{
			// Note: this type is marked as 'beforefieldinit'.
			while (true)
			{
				IL_A5:
				uint arg_85_0 = 1377445228u;
				while (true)
				{
					uint num;
					switch ((num = (arg_85_0 ^ 666437950u)) % 5u)
					{
					case 0u:
						MovementSpeed.FlySpeed = 14f;
						MovementSpeed.FlyBackSpeed = 7.5f;
						arg_85_0 = (num * 1434968285u ^ 3018105970u);
						continue;
					case 1u:
						MovementSpeed.RunSpeed = 7f;
						MovementSpeed.SwimSpeed = 4.72222f;
						MovementSpeed.SwimBackSpeed = 4.5f;
						arg_85_0 = (num * 2967240446u ^ 395457572u);
						continue;
					case 2u:
						MovementSpeed.RunBackSpeed = 2.5f;
						MovementSpeed.TurnSpeed = 3.14159274f;
						arg_85_0 = (num * 3144033859u ^ 2199932753u);
						continue;
					case 4u:
						goto IL_A5;
					}
					goto Block_1;
				}
			}
			Block_1:
			MovementSpeed.PitchSpeed = 3.14159274f;
		}
	}
}
