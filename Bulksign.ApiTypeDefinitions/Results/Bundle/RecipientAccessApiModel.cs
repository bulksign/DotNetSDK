namespace Bulksign.Api
{
	public class RecipientAccessApiModel
	{
		public string AccessCode
		{
			get;
			set;
		}

		public string RecipientEmail
		{
			get;
			set;
		}

		public string SigningUrl
		{
			get;
			set;
		}
	}
}