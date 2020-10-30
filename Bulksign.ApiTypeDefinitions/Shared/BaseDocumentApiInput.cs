using System.ComponentModel;
using Newtonsoft.Json;

namespace Bulksign.Api
{
	public class BaseDocumentApiInput
	{
		public DocumentApiModel[] Documents
		{
			get;
			set;
		}

		public RecipientApiModel[] Recipients
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

		public bool DisableSignersShouldReceiveFinishedDocument
		{
			get;
			set;
		}

		public CallbackApiModel OverwriteCallbackUrls
		{
			get;
			set;
		}

		public bool AllowRecipientDelegation
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

		[DefaultValue(1)]
		[JsonProperty(PropertyName = "FileAccessMode", DefaultValueHandling = DefaultValueHandling.Populate)]
		public FileAccessModeApi FileAccessMode
		{
			get;
			set;
		}

		public CustomFileAccessApiModel[] CustomFileAccess
		{
			get;
			set;
		}

		public bool EnableBatchSign
		{
			get;
			set;
		}

	}
}