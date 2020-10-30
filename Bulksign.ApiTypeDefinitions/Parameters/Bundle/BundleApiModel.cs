namespace Bulksign.Api
{
	public class BundleApiModel : DraftApiModel
	{
		public int DaysUntilExpire
		{
			get;
			set;
		}

		public bool DisableNotifications     //disables sending the notification emails (aka enables PointOfSale mode)
		{
			get;
			set;
		}

		public SignerDocumentDownloadApiModel OverwriteDocumentDownloadOption
		{
			get;
			set;
		}


	}
}