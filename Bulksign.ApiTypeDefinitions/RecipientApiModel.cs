namespace Bulksign.Api
{
	public class RecipientApiModel
	{
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

		//this is not used for bulk recipients
		public int Index
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

		public RecipientTypeApi RecipientType
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