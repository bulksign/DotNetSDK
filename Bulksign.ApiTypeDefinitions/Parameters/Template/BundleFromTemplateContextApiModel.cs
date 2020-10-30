namespace Bulksign.Api
{
	public class BundleFromTemplateContextApiModel
	{

		public string TemplateId
		{
			get;
			set;
		}

		public TemplateReplaceRecipientApiModel[] ReplaceRecipients
		{
			get;
			set;
		}

		public TemplateReplaceFormFieldsApiModel[] ReplaceFormFields
		{
			get;
			set;
		}
	}
}