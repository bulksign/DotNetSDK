namespace Bulksign.Api
{
	public class SignatureAssignmentApiModel
	{
		public string FieldId
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
