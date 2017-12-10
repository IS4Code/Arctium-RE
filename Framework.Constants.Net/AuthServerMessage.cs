using System;

namespace Framework.Constants.Net
{
	public enum AuthServerMessage : ushort
	{
		Pong,
		Complete = 0,
		ProofRequest = 2,
		RealmUpdate = 2,
		JoinResponse = 8
	}
}
