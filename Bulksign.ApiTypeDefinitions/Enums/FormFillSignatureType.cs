namespace Bulksign.Api
{

	//this should have the same value as internal AuditTrailSignatureType
	public enum FormFillSignatureType
	{
		None = -1,
		DrawTypeToSign = 0,
		ClickToSign = 1,
		OTPSign = 2,
		AutomaticSignature = 3
	}
}