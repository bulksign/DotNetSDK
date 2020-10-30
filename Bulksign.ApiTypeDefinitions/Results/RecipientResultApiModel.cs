namespace Bulksign.Api
{
	public class RecipientResultApiModel
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

		public RecipientStatusApi Status
		{
			get;
			set;
		}

		public string AccessCode
		{
			get;
			set;
		}

		public string SigningUrl
		{
			get;
			set;
		}

		public bool HasBeenDelegated
		{
			get;
			set;
		}

		public string RejectionMessage
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
