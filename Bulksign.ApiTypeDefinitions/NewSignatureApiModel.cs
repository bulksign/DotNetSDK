namespace Bulksign.Api
{
	public class NewSignatureApiModel
	{
		public int Height
		{
			get;
			set;
		}

		public int Width
		{
			get;
			set;
		}

		public int Top
		{
			get;
			set;
		}

		public int Left
		{
			get;
			set;
		}

		public string AssignedToRecipientEmail
		{
			get;
			set;
		}
		
		public int PageIndex
		{
			get;
			set;
		}

		public SignatureTypeApi SignatureType
		{
			get;
			set;
		}

		public bool EnableTimestamp
		{
			get;
			set;
		}

	}
}