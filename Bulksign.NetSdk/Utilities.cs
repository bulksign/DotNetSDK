using System;

namespace Bulksign.Api
{
	public class Utilities
	{
		public string GetUrlForDraftEditInIncognitoMode(string rootApplicationUrl, string draftId)
		{
			if (string.IsNullOrWhiteSpace(draftId))
			{
				throw new ArgumentException("The draftId is empty");
			}

			if (string.IsNullOrEmpty(rootApplicationUrl))
			{
				return Constants.BULKSIGN_URL + Constants.OPEN_DRAFT_INCOGNITO_REDIRECT_URL_PART + draftId;
			}

			return rootApplicationUrl + Constants.OPEN_DRAFT_INCOGNITO_REDIRECT_URL_PART + draftId;
		}

	}
}