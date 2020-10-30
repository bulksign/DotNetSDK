namespace Bulksign.Api
{
	public class NewComboBoxApiModel
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


		public string SelectedItem
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