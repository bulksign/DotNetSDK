namespace Bulksign.Api
{
	public class DeleteDraftRecipientApiModel
	{
		public string DraftPublicId
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