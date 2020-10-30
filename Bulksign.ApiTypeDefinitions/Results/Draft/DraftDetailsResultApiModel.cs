using System;

namespace Bulksign.Api
{
	public class DraftDetailsResultApiModel 
	{

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

		public DateTime CreationDateUTC
		{
			get;
			set;
		}

		public DateTime LastUpdateDateUTC
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

		public DocumentResultApiModel[] Documents
		{
			get;
			set;
		}

		public RecipientApiModel[] Recipients
		{
			get;
			set;
		}

		public FileAccessModeApi FileAccessMode
		{
			get;
			set;
		}
	}

}