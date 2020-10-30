using System;

namespace Bulksign.Api
{
	public class BundleDetailsResultApiModel
	{

		public RecipientResultApiModel[] Recipients
		{
			get;
			set;
		}

		public DocumentResultApiModel[] Documents
		{
			get;
			set;
		}

		public int Status
		{
			get;
			set;
		}

		public DateTime SentDateUTC
		{
			get;
			set;
		}

		public DateTime ExpirationDateUTC
		{
			get;
			set;
		}

		public DateTime LastModifiedDateUTC
		{
			get;
			set;
		}
		
		public string PublicId
		{
			get;
			set;
		}

		public bool IsBulk
		{
			get;
			set;
		}

		public ReminderOptionsApiModel ReminderOptions
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public string NotificationLanguage
		{
			get;
			set;
		}

		public bool SignersShouldReceiveFinishedDocument
		{
			get;
			set;
		}

		public string Metadata
		{
			get;
			set;
		}

		public bool CertifyDocumentsBeforeSending
		{
			get;
			set;
		}

		public bool PreventFormFieldEditOnBundleCompletion
		{
			get;
			set;
		}
	}

}