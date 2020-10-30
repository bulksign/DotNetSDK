namespace Bulksign.Api
{
	public class TeamHierarchicalApiModel
	{
		public string Name
		{
			get;
			set;
		}

		public HierarchicalTeamMember[] Members
		{
			get;
			set;
		}

	}


	public class HierarchicalTeamMember
	{
		public int Index
		{
			get;
			set;
		}

		public string Email
		{
			get;
			set;
		}
	}
}