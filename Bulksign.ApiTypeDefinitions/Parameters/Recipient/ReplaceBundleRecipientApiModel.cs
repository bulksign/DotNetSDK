namespace Bulksign.Api
{
	public class ReplaceBundleRecipientApiModel
	{



		public string BundlePublicId
		{
			get;
			set;
		}
		
		public FindRecipientByIndexApiModel ByIndex
		{
			get;
			set;
		}

		public FindRecipientByEmailApiModel ByEmail
		{
			get;
			set;
		}
		
		public string Email
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string PhoneNumber
		{
			get;
			set;
		}

		public string PersonalMessage
		{
			get;
			set;
		}

		public RecipientAuthenticationApiModel[] RecipientAuthenticationMethods
		{
			get;
			set;
		}

		public string AutomaticSignerProfileIdentifier
		{
			get;
			set;
		}

	}
}