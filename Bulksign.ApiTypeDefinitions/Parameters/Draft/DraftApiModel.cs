namespace Bulksign.Api
{
	public class DraftApiModel : BaseDocumentApiInput
	{
		public string Subject
		{
			get;
			set;
		}

		public string Message
		{
			get;
			set;
		}

		public string Metadata
		{
			get;
			set;
		}

		public bool EnableEditIncognitoMode
		{
			get;
			set;
		}
	}
}