using System;

namespace Bulksign.Api 
{
	public class BulksignException : Exception
	 {
		public BulksignException (string message, Exception innerException) : base (message, innerException) { }

		public string Response
		{
			get;
			set;
		}

	}
}