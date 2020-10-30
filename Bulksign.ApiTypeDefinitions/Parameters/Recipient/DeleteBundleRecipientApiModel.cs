namespace Bulksign.Api
{
	public class DeleteBundleRecipientApiModel
	{
		public string BundlePublicId
		{
			get;
			set;
		}

		public FindRecipientByIndexApiModel ByIndex
		{
			get;
			set;
		}

		public FindRecipientByEmailApiModel ByEmail
		{
			get;
			set;
		}


	}
}