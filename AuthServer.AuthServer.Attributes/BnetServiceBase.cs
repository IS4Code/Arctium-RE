using System;

namespace AuthServer.AuthServer.Attributes
{
	public abstract class BnetServiceBase
	{
		[AttributeUsage(AttributeTargets.Method)]
		public sealed class BnetMethodAttribute : Attribute
		{
			public uint MethodId
			{
				get;
				set;
			}

			public BnetMethodAttribute(uint methodId)
			{
				while (true)
				{
					IL_39:
					uint arg_21_0 = 1108325121u;
					while (true)
					{
						uint num;
						switch ((num = (arg_21_0 ^ 219534909u)) % 3u)
						{
						case 0u:
							goto IL_39;
						case 2u:
							this.MethodId = methodId;
							arg_21_0 = (num * 2797406976u ^ 3517954148u);
							continue;
						}
						return;
					}
				}
			}
		}
	}
}
