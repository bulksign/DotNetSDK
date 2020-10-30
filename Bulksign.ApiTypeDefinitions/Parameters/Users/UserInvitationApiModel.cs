namespace Bulksign.Api
{
	public class UserInvitationApiModel
	{
		public string FirstName
		{
			get;
			set;
		}

		public string LastName
		{
			get;
			set;
		}
		
		public string Email
		{
			get;
			set;
		}
		
		public bool IsAdministrator
		{
			get;
			set;
		}
	}
}
