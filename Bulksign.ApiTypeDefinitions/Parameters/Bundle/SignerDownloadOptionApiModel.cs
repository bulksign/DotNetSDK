namespace Bulksign.Api
{
	public class SignerDocumentDownloadApiModel
	{
		public SignerDownloadDocumentActionTypeApi DocumentDownload
		{
			get;
			set;
		}

		public string RedirectUrl
		{
			get;
			set;
		}
	}
}