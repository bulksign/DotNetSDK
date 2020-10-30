using System;

namespace Bulksign.Api
{
	public class TemplateItemResultApiModel 
	{
		public bool IsSharedTemplate
		{
			get;
			set;
		}

		public string Id
		{
			get;
			set;
		}

		public string Name
		{
			get;
			set;
		}

		public DateTime LastUpdatedDateUTC
		{
			get;
			set;
		}

		public string[] Files
		{
			get;
			set;
		}
	}
}