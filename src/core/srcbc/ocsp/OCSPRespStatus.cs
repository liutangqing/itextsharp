using System;

namespace Org.BouncyCastle.Ocsp
{
	[Obsolete("Use version with correct spelling 'OcspRespStatus'")]
	public abstract class OcscpRespStatus : OcspRespStatus
	{
	}

	[Obsolete("For internal use only. If you want to use iText, please use a dependency on iText 7. ")]
    public abstract class OcspRespStatus
	{
		/**
		 * note 4 is not used.
		 */
		public const int Successful = 0;		// --Response has valid confirmations
		public const int MalformedRequest = 1;	// --Illegal confirmation request
		public const int InternalError = 2;		// --Internal error in issuer
		public const int TryLater = 3;			// --Try again later
		public const int SigRequired = 5;		// --Must sign the request
		public const int Unauthorized = 6;		//  --Request unauthorized
	}
}
