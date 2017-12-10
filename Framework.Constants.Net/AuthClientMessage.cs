using System;

namespace Framework.Constants.Net
{
	public enum AuthClientMessage : ushort
	{
		Ping,
		ProofResponse = 2,
		InformationRequest = 9,
		RealmUpdate = 0,
		JoinRequest = 8
	}
}
