namespace Bulksign.Api
{
	public class NewAnnotationApiModel
	{
		public int Height
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

		public int FontSize
		{
			get;
			set;
		}

		public AnnotationTypeApi Type
		{
			get;
			set;
		}

		public string CustomText
		{
			get;
			set;
		}

	}
}