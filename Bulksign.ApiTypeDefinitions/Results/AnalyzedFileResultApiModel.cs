using System.Collections.Generic;

namespace Bulksign.Api
{
	public class AnalyzedFileResultApiModel
	{
		public string FileIdentifier
		{
			get;
			set;
		}

		public List<FormFieldResultApiModel> Fields
		{
			get;
			set;
		}

		public int NumberOfPages
		{
			get;
			set;
		}
	}
}