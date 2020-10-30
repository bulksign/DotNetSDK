namespace Bulksign.Api
{
	public class SendBundleResultApiModel
	{
		public string BundleId
		{
			get;
			set;
		}

		public RecipientAccessApiModel[] RecipientAccess
		{
			get;
			set;
		}
	}
}