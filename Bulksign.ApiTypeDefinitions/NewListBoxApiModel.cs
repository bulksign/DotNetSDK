namespace Bulksign.Api
{
	public class NewListBoxApiModel
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

		public bool AllowMultipleItemSelection
		{
			get;
			set;
		}

		public string[] SelectedItems
		{
			get;
			set;
		}
		
		public string[] Items
		{
			get;
			set;
		}

	}
}