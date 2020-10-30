
namespace Bulksign.DomainLogic.Api
{
	public static class ApiErrorCode
	{
		public const int API_CODE_SUCCESS = 0;

		public const int API_ERROR_CODE_INTERNAL = -1;
		public const string API_MESSAGE_INTERNAL = "Internal error";

		public const int API_ERROR_CODE_NOT_ALLOWED_TO_CALL_API = 1;
		public const string API_MESSAGE_NOT_ALLOWED_TO_CALL_API = "Your license does not allows you to call the api";

		public const int API_ERROR_CODE_MISSING_AUTHENTICATION = 2;
		public const string API_MESSAGE_MISSING_AUTHENTICATION = "Missing authentication details";

		public const int API_ERROR_CODE_INVALID_AUTHENTICATION = 3;
		public const string API_MESSAGE_INVALID_AUTHENTICATION = "Invalid authentication details provided. If credentials are correct, please make sure the email address is validated";
		
		public const int API_ERROR_CODE_INVALID_INPUT = 4;
		public const string API_MESSAGE_INVALID_INPUT = "Input is invalid. Please check all passed values to make sure they are correct. ";
		
		public const int API_ERROR_CODE_OPERATION_FAILED = 5;
		public const string API_MESSAGE_OPERATION_FAILED = "Operation failed";
		
		public const int API_ERROR_CODE_NO_ACCESS = 6;
		public const string API_MESSAGE_NO_ACCESS = "No access to ";
		
		public const int API_ERROR_CODE_INVALID_PARAMETER = 7;
		public const string API_MESSAGE_INVALID_PARAMETER = "Parameter {0} has invalid/empty value";

		public const int API_ERROR_FILE_TYPE_NOT_SUPPORTED = 8;

		public const int API_ERROR_CODE_BUNDLE_DOES_NOT_CONTAIN_SIGNATURE_FIELDS = 9;

		public const int API_ERROR_CODE_TOO_MANY_OTPS = 10;

		public const int API_ERROR_CODE_FIELD_ASSIGNED_UNREACHABLE_FILE = 11; //custom file share but recipient has field assigned in file to which it does not have access to
		
		public const int API_ERROR_CODE_CUSTOM_FILE_SHARE_NORECIPIENT = 12; //custom file share but recipient has no files assigned

		public const int API_ERROR_CODE_CUSTOM_FILE_SHARE_UNUSED = 13;
		
		public const int API_ERROR_CODE_NO_FILE_SHARE_SET = 14;
		public const string API_ERROR_MESSAGE_NO_FILE_SHARE_SET = "Bundle file access is set to Custom, but no values are set";

		
		public const int API_ERROR_CODE_NO_DOCUMENTS_OR_RECIPIENTS = 15;
		public const string API_ERROR_MESSAGE_NO_DOCUMENTS_OR_RECIPIENTS = "No documents or recipients specified. At least 1 document or recipients are required";
		
		public const int API_ERROR_CODE_NO_SIGNATURE_FIELD_BULK = 16;

		public const int API_ERROR_CODE_ONE_SIGNER = 17;
		
		public const int API_ERROR_CODE_NO_RECIPIENTS = 18;
		
		public const int API_ERROR_CODE_NO_DOCUMENTS = 19;
		
		public const int API_ERROR_CODE_NEW_DRAFT_TEMPLATE_LICENSE = 20;
		public const string API_MESSAGE_NEW_DRAFT_TEMPLATE_LICENSE = "Your subscription doesn't allow you to create new drafts/templates. Please upgrade your subscription to create new drafts/templates";

		public const int API_ERROR_CODE_NEW_BUNDLE_LICENSE = 21;
		public const string API_MESSAGE_NEW_BUNDLE_LICENSE = "Your subscription doesn't allow you to create new bundles. Please upgrade your subscription to send new bundles";

		public const int API_ERROR_CODE_NO_REDIRECTION_URL = 22;
		public const string API_MESSAGE_NO_REDIRECTION_URL = "Your subscription doesn\'t allow you to have client redirection urls. Please upgrade your subscription to have access to this feature";

		public const int API_ERROR_CODE_EMAIL_BODY_LENGTH = 23;
		public const string API_ERROR_MESSAGE_EMAIL_BODY_LENGTH = "Maximum email body length is 1000 chars";

		public const int API_ERROR_CODE_EMAIL_SUBJECT_LENGTH = 24;
		public const string API_ERROR_MESSAGE_EMAIL_SUBJECT_LENGTH = "Maximum email subject length is 150 chars";

		public const int API_ERROR_CODE_INVALID_FILE_NAME = 25;
		public const string API_MESSAGE_INVALID_FILE_NAME = "Document filename is required";


		public const int API_ERROR_CODE_BUNDLE_MUST_BE_COMPLETED_STATE = 26;
		public const string API_MESSAGE_BUNDLE_MUST_BE_COMPLETED_STATE = "Specified bundle must be in completed state";


		public const int API_ERROR_CODE_RECIPIENT_EMAIL_NOT_FOUND = 27;
		public const string API_MESSAGE_RECIPIENT_EMAIL_NOT_FOUND = "Recipient with specified email was not found in bundle with id ";


		public const int API_ERROR_CODE_SIGN_STEP_RECIPIENT_EMAIL_NOT_FOUND = 28;
		public const string API_MESSAGE_SIGN_STEP_RECIPIENT_EMAIL_NOT_FOUND = "Sign step not found for recipient with email ";


		public const int API_ERROR_CODE_BUNDLE_MUST_BE_INPROGRESS_STATE = 29;
		public const string API_MESSAGE_BUNDLE_MUST_BE_INPROGRESS_STATE = "The specified bundle must have status InProgress to perform the required action";


		public const int API_ERROR_CODE_INVALID_CONTENT_FILE = 30;
		public const string API_MESSAGE_INVALID_CONTENT_FILE = "Invalid file, content is empty";


		public const int API_ERROR_CODE_BULK_BUNDLE_INVALID_NUMBER_RECIPIENTS = 31;
		public const string API_MESSAGE_BULK_BUNDLE_INVALID_NUMBER_RECIPIENTS = "Bulk bundles must have at least 2 recipients. If you want to send a bundle to a single recipient please call the SendBundle API method.";

		public const int API_ERROR_CODE_BULK_NON_SIGNING_RECIPIENTS = 32;
		public const string API_MESSAGE_BULK_NON_SIGNING_RECIPIENTS = "Cannot have non signing recipients in bulk bundle";


		public const int API_ERROR_CODE_MULTIPLE_RECIPIENTS_SAME_INDEX = 33;
		public const string API_MESSAGE_MULTIPLE_RECIPIENTS_SAME_INDEX = "Multiple recipients in serial bundle have the same index";


		public const int API_ERROR_CODE_NO_RECIPIENT_AUTH_PASSWORD = 34;
		public const string API_MESSAGE_NO_RECIPIENT_AUTH_PASSWORD = "No authorization password set for recipient ";

		public const int API_ERROR_CODE_PASSWORD_TOO_LONG = 35;
		public const string API_MESSAGE_PASSWORD_TOO_LONG = "Password for recipient {0} is too long. Max length is {1}";

		public const int API_ERROR_CODE_INVALID_LANGUAGE = 36;
		public const string API_MESSAGE_INVALID_LANGUAGE = "Language {0} not found, is not among the usable notification languages in your organization. Either leave field empty for default language or pass a valid language (en-US for example)";

		public const int API_ERROR_CODE_INVALID_FINAL_WARNING_REMINDER_DAY = 37;
		public const string API_MESSAGE_INVALID_FINAL_WARNING_REMINDER_DAY = "FinalWarningReminderDay expiration day value must be between 1 and 5";

		public const int API_ERROR_CODE_INVALID_RECURRENT_REMINDER = 38;
		public const string API_MESSAGE_INVALID_RECURRENT_REMINDER = "Reminder recurrent days value must be between 1 and {0}";

		public const int API_ERROR_CODE_INVALID_EXPIRATION_DATE = 39;
		public const string API_MESSAGE_INVALID_EXPIRATION_DATE = "Invalid expiration date. Can't be bigger than {0} days";

		public const int API_ERROR_CODE_ANALYZE_FILE_GENERIC = 40;
		public const string API_MESSAGE_ANALYZE_FILE_GENERIC = "Error occurred while analyzing the file. Make sure file is not password protected";

		public const int API_ERROR_CODE_FILE_BASE64_ENCODING = 41;
		public const string API_MESSAGE_FILE_BASE64_ENCODING = "Invalid input. Must be base64 encoded file content";

		public const int API_ERROR_CODE_NOTIFICATION_DISABLED_REMINDERS_ENABLED = 42;
		public const string API_MESSAGE_NOTIFICATION_DISABLED_REMINDERS_ENABLED = "Both DisableNotifications and RemindersEnabled are true. Reminders are not sent if notifications are disabled. Please choose one of them";

		public const int API_ERROR_CODE_INVALID_FIELD_ID = 43;
		
		public const int API_ERROR_CODE_FILE_CONTENT_EMPTY = 44;
		public const string API_MESSAGE_FILE_CONTENT_EMPTY = "File with index '{0}' has no content specified. Please use FileContentByteArray, FileContentBase64String or FileIdentifier to set the file's content";

		public const int API_ERROR_CODE_INVALID_FILE_IDENTIFIER = 45;
		public const string API_MESSAGE_INVALID_FILE_IDENTIFIER = "'{0}' is a invalid file identifier";

		public const int API_ERROR_CODE_INVALID_PHONE_NUMBER = 46;

		public const int API_ERROR_CODE_RECIPIENT_NO_SIGN_FIELDS_ASSIGNED = 47;  //no signature fields assigned for recipient

		public const int API_ERROR_CODE_FIELD_ASSIGNMENT_INVALID_RECIPIENT_IDENTIFIER = 48;

		public const int API_ERROR_CODE_FIELD_ASSIGNMENT_INVALID_BULK_ASSIGNMENT = 49;
		

		public const int API_ERROR_CODE_INVALID_FIELD_SIZE = 50;

		public const int API_ERROR_CODE_INVALID_BUNDLE_STATUS = 51;

		public const int API_ERROR_CODE_CANNOT_REPLACE_RECIPIENT_ALREADY_HAS_SIGN_STEP = 52;

		public const int API_ERROR_CODE_MANY_RECIPIENTS_SAME_INDEX = 53;

		public const int API_ERROR_DELETE_RECIPIENT_RECEIVE_COPY_CANNOT_BE_DELETED  = 54;

		public const int API_ERROR_DELETE_RECIPIENT_RECIPIENT_ALREADY_SIGNED_REJECTED = 55;

		public const int API_ERROR_RECIPIENT_ID_BUNDLE_ID_MAPPING_INVALID = 56;

		public const int API_ERROR_RECIPIENT_NO_EDIT_WITH_PENDING_DELEGATION = 57;

		public const int API_ERROR_CODE_AD_ENABLED = 58;
		public const string API_ERROR_MESSAGE_AD_ENABLED = "InviteUserToOrganization api method cannot be used when ActiveDirectory synchronization is enabled.";

		public const int API_ERROR_CODE_SPECIFIED_ID_NOT_BUNDLE = 59;
		public const string API_ERROR_MESSAGE_SPECIFIED_ID_NOT_BUNDLE = "Specified id {0} is invalid, does not belong to a bundle";

		public const int API_ERROR_CODE_LICENSE_ADD_NEW_USER = 60;
		public const string API_MESSAGE_LICENSE_ADD_NEW_USER = "The current license prevents adding new users";

		public const int API_ERROR_CODE_INVALID_RECIPIENT_FOR_CUSTOM_ACCESS = 61;
		public const string API_MESSAGE_INVALID_RECIPIENT_FOR_CUSTOM_ACCESS = "No recipient found with email ";

		public const int API_ERROR_CODE_INVALID_FILE_NAME_FOR_CUSTOM_ACCESS = 62;
		public const string API_MESSAGE_INVALID_FILE_NAME_FOR_CUSTOM_ACCESS = "No file found with index ";

		public const int API_ERROR_CODE_INVALID_FILE_ACCESS_MODE_STRUCTURE = 63;
		public const string API_MESSAGE_INVALID_FILE_ACCESS_MODE_STRUCTURE = "CustomFileAccess can be used only when FileAccessMode = 2";

		public const int API_ERROR_CODE_FIELD_VALUE_FAILED_OVERWRITE = 64; //thrown where overwriting the form field value fails

		public const int API_ERROR_CODE_INVALID_FORM_FIELD_POSITION = 65;


		public const int API_ERROR_CODE_BUNDLE_IS_COMPLETED_STATE = 66;
		public const string API_MESSAGE_BUNDLE_IS_COMPLETED_STATE = "Specified bundle is in completed state, please invoke GetFinishedDocuments ";

		public const int API_ERROR_CODE_FILE_IS_TOO_LARGE = 67;
		public const string API_MESSAGE_FILE_IS_TOO_LARGE = "File is too large";


		public const int API_ERROR_CODE_FIELD_MARKED_REQUIRED = 68;

		public const int API_ERROR_CODE_INVALID_FORM_FIELD_PAGE_INDEX = 69;


		public const int API_ERROR_CODE_MULTIPLE_FILE_SOURCES_SPECIFIED = 70;
		public const string API_ERROR_MESSAGE_MULTIPLE_FILE_SOURCES_SPECIFIED = "Multiple file sources were specified for document '{0}'. Please specify only one : FileIdentifier, FileContentByteArray or FileContentBase64String";

		public const int API_ERROR_CODE_FILE_NETWORK_SHARE = 71;
		public const string API_ERROR_MESSAGE_FILE_NETWORK_SHARE = "Failed to read file's content from NetworkShare. ";

		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_USED = 72;
		public const string API_ERROR_MESSAGE_AUTOMATIC_PROFILE_USED = "AutomaticSigningProfile '{0}' is in use, it cannot be deleted";

		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_NO_IMAGE_SET = 73;
		public const string API_ERROR_MESSAGE_AUTOMATIC_NO_IMAGE_SET = "AutomaticSigningProfile requires either a default signature image or a signature imprint";

		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_INVALID_IMAGE = 74;
		public const string API_ERROR_MESSAGE_AUTOMATIC_PROFILE_INVALID_IMAGE = "The provided image is invalid";

		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_INVALID_CERTIFICATE = 75;
		public const string API_ERROR_MESSAGE_AUTOMATIC_PROFILE_INVALID_CERTIFICATE = "The provided certificate is invalid";
		
		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_CERTIFICATE_NO_PRIVATE_KEY = 76;
		public const string API_ERROR_MESSAGE_AUTOMATIC_PROFILE_CERTIFICATE_NO_PRIVATE_KEY = "The provided certificate is unusable, it does not have a private key";

		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_CERTIFICATE_BAD_PASSWORD = 77;
		public const string API_ERROR_MESSAGE_AUTOMATIC_PROFILE_CERTIFICATE_BAD_PASSWORD = "The provided certificate password is invalid";
		
		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_IMPRINT_NAME = 78;
		public const string API_ERROR_MESSAGE_AUTOMATIC_PROFILE_IMPRINT_NAME = "No signature imprint with name '{0}' can be found";

		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_INVALID = 79;
		public const string API_ERROR_MESSAGE_AUTOMATIC_PROFILE_INVALID = "Automatic signing profile with identifier '{0}' was not found";

		public const int API_ERROR_CODE_AUTOMATIC_PROFILE_EMPTY = 80;
		public const string API_ERROR_MESSAGE_AUTOMATIC_PROFILE_EMPTY = "AutomaticSignerProfileIdentifier is not set for recipient with index '{0}'";

		public const int API_ERROR_CODE_TEAM_NAME_EMPTY = 81;
		public const string API_ERROR_MESSAGE_TEAM_NAME_EMPTY = "Team name is empty, please set a valid name";

		public const int API_ERROR_CODE_TEAM_NO_MEMBER_EMAILS = 82;
		public const string API_ERROR_MESSAGE_TEAM_NO_MEMBER_EMAILS = "A team requires at least 2 members, please add at least 2 email addresses";

		public const int API_ERROR_CODE_TEAM_NO_EMAILS_FOUND = 82;
		public const string API_ERROR_MESSAGE_TEAM_NO_EMAILS_FOUND = "Following email address '{0}' were not found in your organization";
		
		public const int API_ERROR_CODE_NEW_EXPIRED_LICENSE = 83;
		public const string API_MESSAGE_NEW_EXPIRED_LICENSE = "License is expired, please update the license to send new bundles. Contact us at contact@bulksign.com";
		
		public const int API_ERROR_CODE_REMINDER_CANNOT_BE_SCHEDULED = 84;
		public const string API_MESSAGE_REMINDER_CANNOT_BE_SCHEDULED = "Reminder cannot be scheduled to sent, a new reminder can only be sent after 24h passed since last reminder";


		public const int API_ERROR_CODE_POLICY_REQUIRED_RECIPIENT_AUTHENTICATION = 85;
		public const string API_MESSAGE_POLICY_REQUIRED_RECIPIENT_AUTHENTICATION = "Add authentication for all signers. The organization policy 'Do not allow sending documents to signing without recipient authentication' is enabled and prevents sending the bundle without having authentication for each signer";



		public const int API_ERROR_CODE_VALIDATION_FAILED = 99;

		public const int API_ERROR_CODE_CANNOT_OBTAIN_LICENSE = 100;

	}
}