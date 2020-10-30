namespace Bulksign.Api
{
	public class TemplateReplaceFormFieldsApiModel
	{
		public int FindDocumentByIndex
		{
			get;
			set;
		}

		public string FindDocumentByName
		{
			get;
			set;
		}
		
		public OverwriteFieldValueApiModel[] FormFieldValues
		{
			get;
			set;
		}
	}
}
