namespace Bulksign.Api
{
	
	public class AutomaticSigningProfileApiModel
	{
		public string Name
		{
			get;
			set;
		}

		public string SignatureImageBase64
		{
			get;
			set;
		}


		public string SignatureImprintName
		{
			get;
			set;
		}

		public AutomaticSigningProfileCertificateTypeApi CertificateTypeApi
		{
			get;
			set;
		}

		public ProfileStoredCertificateApiModel StoredCertificate
		{
			get;
			set;
		}

	}


	public class ProfileStoredCertificateApiModel
	{
		public string CertificateBase64
		{
			get;
			set;
		}

		public string CertificatePassword
		{
			get;
			set;
		}
	}
}