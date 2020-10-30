namespace Bulksign.Api
{
	public class NewUserApiModel 
	{
		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}

		public string Email
		{
			get;
			set;
		}

		public bool IsAdministrator
		{
			get;
			set;
		}

		public string TimeZoneId
		{
			get;
			set;
		}

		public int DateTimeFormatId
		{
			get;
			set;
		}

		public string SignatureImage
		{
			get;
			set;
		}


		public string Picture
		{
			get;
			set;
		}


		public string PhoneNumber
		{
			get;
			set;
		}


		public string JobTitle
		{
			get;
			set;
		}


		public string DefaultDraftLanguage
		{
			get;
			set;
		}

		public string UILanguage
		{
			get;
			set;
		}


		public bool NotificationBundleCompleted
		{
			get;
			set;
		}
		
		public bool NotificationRecipientRejected
		{
			get;
			set;
		}


		public bool NotificationRecipientOpenedBundle
		{
			get;
			set;
		}
		
		public bool NotificationRecipientSigned
		{
			get;
			set;
		}

	}
}