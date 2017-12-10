using System;

namespace Framework.ObjectDefines
{
	public class Quaternion
	{
		public readonly float X;

		public readonly float Y;

		public readonly float Z;

		public readonly float W;

		private const float multiplier = 9.536743E-07f;

		public Quaternion(long compressedQuaternion)
		{
			while (true)
			{
				IL_12F:
				uint arg_103_0 = 825594213u;
				while (true)
				{
					uint num;
					switch ((num = (arg_103_0 ^ 174999553u)) % 8u)
					{
					case 0u:
						this.W = (float)Quaternion.smethod_1((double)(1f - this.W));
						arg_103_0 = (num * 3584623628u ^ 653656716u);
						continue;
					case 2u:
						this.Z = (float)compressedQuaternion * 9.536743E-07f;
						arg_103_0 = (num * 2070995609u ^ 53811480u);
						continue;
					case 3u:
						this.W = this.X * this.X + this.Y * this.Y + this.Z * this.Z;
						arg_103_0 = (((Quaternion.smethod_0(this.W - 1f) >= 9.536743E-07f) ? 2796236138u : 2503607803u) ^ num * 2087592569u);
						continue;
					case 4u:
						this.X = (float)(compressedQuaternion >> 42) * 4.76837158E-07f;
						arg_103_0 = (num * 3123293855u ^ 3927614322u);
						continue;
					case 5u:
						return;
					case 6u:
						goto IL_12F;
					case 7u:
						this.Y = (float)(compressedQuaternion >> 21) * 9.536743E-07f;
						arg_103_0 = (num * 928188314u ^ 2892027333u);
						continue;
					}
					goto Block_2;
				}
			}
			Block_2:
			this.W = 0f;
		}

		public static long GetCompressed(float orientation)
		{
			long num = (long)((double)((float)Quaternion.smethod_2((double)orientation / 1.9999945)) / Quaternion.smethod_4(Quaternion.smethod_3(2.0, -20.0)));
			while (true)
			{
				IL_81:
				uint arg_65_0 = 3686931106u;
				while (true)
				{
					uint num2;
					switch ((num2 = (arg_65_0 ^ 3731480515u)) % 4u)
					{
					case 0u:
						goto IL_81;
					case 1u:
						arg_65_0 = ((((double)orientation >= 3.1415926535897931) ? 249273569u : 1146087880u) ^ num2 * 1020797425u);
						continue;
					case 3u:
						goto IL_8A;
					}
					return num;
				}
			}
			return num;
			IL_8A:
			return (1048576L - num << 1) + num;
		}

		static float smethod_0(float float_0)
		{
			return Math.Abs(float_0);
		}

		static double smethod_1(double double_0)
		{
			return Math.Sqrt(double_0);
		}

		static double smethod_2(double double_0)
		{
			return Math.Sin(double_0);
		}

		static double smethod_3(double double_0, double double_1)
		{
			return Math.Pow(double_0, double_1);
		}

		static double smethod_4(double double_0)
		{
			return Math.Atan(double_0);
		}
	}
}
