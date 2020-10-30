namespace Bulksign.Api
{
	public class BulksignResult<T>
	{
		public BulksignResult()
		{
		}

		public BulksignResult(T response, string message, bool isSuccessful, int errorCode)
		{
			Response = response;
			ErrorMessage = message;
			IsSuccessful = isSuccessful;
			ErrorCode = errorCode;
		}

		public string ErrorMessage
		{
			get;
			set;
		}

		public bool IsSuccessful
		{
			get;
			set;
		}

		public T Response
		{
			get;
			set;
		}

		public int ErrorCode
		{
			get;
			set;
		}

		public string RequestId
		{
			get;
			set;
		}
	}
}