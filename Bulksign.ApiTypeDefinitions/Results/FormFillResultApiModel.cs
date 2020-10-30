namespace Bulksign.Api
{
	public class FormFillResultApiModel
	{
		public string FormFieldId
		{
			get;
			set;
		}

		public FormFieldTypeApi FieldType
		{
			get;
			set;
		}

		//Only if FieldType = Signature
		public FormFillSignatureType SignatureType
		{
			get;
			set;
		}

		public string Value
		{
			get;
			set;
		}

		public string FileName
		{
			get;
			set;
		}

	}
}