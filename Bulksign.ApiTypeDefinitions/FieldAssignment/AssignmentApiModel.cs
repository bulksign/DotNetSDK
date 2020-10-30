namespace Bulksign.Api
{
	public class AssignmentApiModel
	{
		public string AssignedToRecipientEmail
		{
			get;
			set;
		}

		public FieldAssignmentApiModel[] Fields
		{
			get;
			set;
		}

		public SignatureAssignmentApiModel[] Signatures
		{
			get;
			set;
		}
	}
}
