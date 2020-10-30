using System;

namespace Bulksign.Api
{
	public class LicenseResultApiModel
	{
		public DateTime ExpirationDateUTC
		{
			get;
			set;
		}

		public int BundlesTotal
		{
			get;
			set;
		}

		public int BundlesUsed
		{
			get;
			set;
		}

		public int UsersTotal
		{
			get;
			set;
		}

		public int UsersUsed
		{
			get;
			set;
		}

	}
}