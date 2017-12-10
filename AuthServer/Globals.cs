using System;

namespace AuthServer
{
	internal class Globals
	{
		public static byte[] SessionKey;

		public static byte[] ServerSalt;

		public static byte[] ClientSalt;

		public static byte[] Secret;

		public static byte[] JoinSecret;

		public static byte[] CertData = Globals.smethod_0(Module.smethod_35<string>(1140403124u));

		static byte[] smethod_0(string string_0)
		{
			return Convert.FromBase64String(string_0);
		}
	}
}
