namespace Bulksign.Api
{
	public class NewCheckBoxApiModel
	{
		public string Id
		{
			get;
			set;
		}

		public int Height
		{
			get;
			set;
		}

		public int Width
		{
			get;
			set;
		}

		public int Top
		{
			get;
			set;
		}

		public int Left
		{
			get;
			set;
		}

		public int PageIndex
		{
			get;
			set;
		}

		public string AssignedToRecipientEmail
		{
			get;
			set;
		}
		
		public bool IsChecked
		{
			get;
			set;
		}

		public bool IsRequired
		{
			get;
			set;
		}

	}
}