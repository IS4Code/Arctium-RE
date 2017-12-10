using System;

namespace Framework.Constants.Authentication
{
	public enum AuthResult : byte
	{
		GlobalSuccess,
		BadLoginInformation = 104,
		InvalidProgram = 109,
		InvalidPlatform,
		InvalidLocale,
		InvalidGameVersion,
		AlreadyLoggedIn = 205
	}
}
