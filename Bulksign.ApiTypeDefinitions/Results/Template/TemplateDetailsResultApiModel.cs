using System;

namespace Bulksign.Api
{
	public class TemplateDetailsResultApiModel
	{
		public RecipientApiModel[] Recipients
		{
			get;
			set;
		}

		public DocumentResultApiModel[] Documents
		{
			get;
			set;
		}

		public DateTime LastUpdateDateUTC
		{
			get;
			set;
		}

		public DateTime CreationDateUTC
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

		public bool IsSharedTemplate
		{
			get;
			set;
		}
	}
}