namespace Bulksign.Api
{
	public class FindRecipientByEmailApiModel
	{
		public string RecipientEmail
		{
			get;
			set;
		}

		public RecipientTypeApi RecipientType
		{
			get;
			set;
		}

	}
}
