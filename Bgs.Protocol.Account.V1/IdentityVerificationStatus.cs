using System;

namespace Bgs.Protocol.Account.V1
{
	public enum IdentityVerificationStatus
	{
		IDENT_NO_DATA,
		IDENT_PENDING,
		IDENT_FAILED = 4,
		IDENT_SUCCESS,
		IDENT_SUCC_MNL,
		IDENT_UNKNOWN
	}
}
