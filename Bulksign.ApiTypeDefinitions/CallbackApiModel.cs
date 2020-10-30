namespace Bulksign.Api
{
	public class CallbackApiModel
	{
		public string CallbackBundleStatusChangedUrl
		{
			get;
			set;
		}

		public string CallbackRecipientActionUrl
		{
			get;
			set;
		}

		public CallbackAuthenticationTypeApi AuthenticationType
		{
			get;
			set;
		}

		public CallbackBasicAuthentication BasicAuthenticationDetails
		{
			get;
			set;
		}

		public CallbackCustomHeaderAuthentication CustomHeaderAuthenticationDetails
		{
			get;
			set;
		}
	}


	public class CallbackBasicAuthentication
	{
		public string UserName
		{
			get;
			set;
		}

		public string Password
		{
			get;
			set;
		}
	}

	public class CallbackCustomHeaderAuthentication
	{
		public string HeaderName
		{
			get;
			set;
		}

		public string HeaderValue
		{
			get;
			set;
		}
	}

}