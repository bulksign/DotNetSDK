using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Bulksign.Api
{
	public class BulkSignApi
	{
		private const string ENDPOINT_ADD_USER_AUTOMATIC_SIGNING_PROFILE = "AddUserAutomaticSigningProfile";
		private const string ENDPOINT_ADD_ORGANIZATION_AUTOMATIC_SIGNING_PROFILE = "AddOrganizationAutomaticSigningProfile";
		private const string ENDPOINT_ADD_CONTACT = "AddContact";
		private const string ENDPOINT_ADD_USER_TO_ORGANIZATION = "AddUserToOrganization";
		private const string ENDPOINT_INVITE_USER_TO_ORGANIZATION = "InviteUserToOrganization";
		private const string ENDPOINT_GET_CONTACTS = "GetContacts";
		private const string ENDPOINT_REPLACE_RECIPIENT = "ReplaceBundleRecipient";
		private const string ENDPOINT_ANALYZE_FILE = "AnalyzeFile";
		private const string ENDPOINT_CANCEL_BUNDLE = "CancelBundle";
		private const string ENDPOINT_DELETE_BUNDLE = "DeleteBundle";
		private const string ENDPOINT_DELETE_DRAFT = "DeleteDraft";
		private const string ENDPOINT_DELETE_TEMPLATE = "DeleteTemplate";
		private const string ENDPOINT_DELETE_BUNDLE_RECIPIENT = "DeleteBundleRecipient";
		private const string ENDPOINT_GET_SIGNATURE_IMPRINTS = "GetSignatureImprints";
		private const string ENDPOINT_GET_USER_AUTOMATIC_SIGNING_PROFILES = "GetUserAutomaticSigningProfiles";
		private const string ENDPOINT_GET_ORGANIZATION_AUTOMATIC_SIGNING_PROFILES = "GetOrganizationAutomaticSigningProfiles";
		private const string ENDPOINT_GET_ORGANIZATION_USERS = "GetOrganizationUsers";
		private const string ENDPOINT_SEND_BUNDLE_REMINDER = "SendBundleReminder";
		private const string ENDPOINT_GET_DRAFTS_COUNT = "GetDraftsCount";
		private const string ENDPOINT_GET_TEMPLATES_COUNT = "GetTemplatesCount";
		private const string ENDPOINT_GET_DRAFTS = "GetDrafts";
		private const string ENDPOINT_GET_DRAFT_DETAILS = "GetDraftDetails";
		private const string ENDPOINT_GET_BUNDLE_DETAILS = "GetBundleDetails";
		private const string ENDPOINT_GET_TEMPLATE_DETAILS = "GetTemplateDetails";
		private const string ENDPOINT_CREATE_BULK_TEMPLATE = "CreateBulkTemplate";
		private const string ENDPOINT_CREATE_TEMPLATE = "CreateTemplate";
		private const string ENDPOINT_BUNDLE_STATUS = "GetBundleStatus";
		private const string ENDPOINT_BUNDLE_BY_STATUS = "GetBundlesByStatus";
		private const string ENDPOINT_GET_TEMPLATES = "GetTemplates";
		private const string ENDPOINT_CREATE_BULK_DRAFT = "CreateBulkDraft";
		private const string ENDPOINT_SEND_BULK_BUNDLE = "SendBulkBundle";
		private const string ENDPOINT_SEND_BUNDLE_FROM_TEMPLATE = "SendBundleFromTemplate";
		private const string ENDPOINT_CREATE_DRAFT = "CreateDraft";
		private const string ENDPOINT_SEND_BUNDLE_FROM_DRAFT= "SendBundleFromDraft";
		private const string ENDPOINT_SEND_BUNDLE = "SendBundle";
		private const string ENDPOINT_ANALYZE_FILE_BASE64 = "AnalyzeFileBase64";
		private const string ENDPOINT_GET_VERSION = "GetVersion";
		private const string ENDPOINT_GET_FINISHED_DOCUMENTS = "GetCompletedDocuments";
		private const string ENDPOINT_SEND_BUNDLE_FROM_TEMPLATE_WITH_CONTEXT = "SendBundleFromTemplateWithContext";
		private const string ENDPOINT_CREATE_SHARE_TEAM = "CreateShareTeam";
		private const string ENDPOINT_CREATE_HIERARCHICAL_TEAM = "CreateHierarchicalTeam";
		private const string ENDPOINT_CREATE_DRAFT_FROM_FILE_BASE64 = "CreateDraftFromFileBase64";
		private const string ENDPOINT_CREATE_DRAFT_FROM_FILE = "CreateDraftFromFile";



		private const string PARAMETER_BUNDLE_ID = "bundlePublicId";
		private const string PARAMETER_DRAFT_ID = "draftPublicId";
		private const string PARAMETER_TEMPLATE_ID = "templatePublicId";
		private const string PARAMETER_STATUS = "status";
		private const string PARAMETER_FILE_NAME = "fileName";

		private string restAPIEndpointUrl;

		private int? timeout;

		public BulkSignApi()
		{
		}

		public BulkSignApi(int timeoutInSeconds)
		{
			timeout = timeoutInSeconds;
		}

		public BulkSignApi(string restAPIEndpointUrl, int timeoutInSeconds)
		{
			this.restAPIEndpointUrl = restAPIEndpointUrl;
			this.timeout = timeoutInSeconds;
		}

		public BulkSignApi(string restAPIEndpointUrl)
		{
			this.restAPIEndpointUrl = restAPIEndpointUrl;
		}


		public BulksignResult<string> AddUserAutomaticSigningProfile(AuthorizationApiModel authorization, AutomaticSigningProfileApiModel model)
		{
			return ExecuteSynchronousRequest<string, AutomaticSigningProfileApiModel>(ENDPOINT_ADD_USER_AUTOMATIC_SIGNING_PROFILE, authorization, model);
		}

		public async Task<BulksignResult<string>> AddUserAutomaticSigningProfileAsync(AuthorizationApiModel authorization, AutomaticSigningProfileApiModel model)
		{
			return await ExecuteAsyncRequest<string, AutomaticSigningProfileApiModel>(ENDPOINT_ADD_USER_AUTOMATIC_SIGNING_PROFILE, authorization, model);
		}
		
		public BulksignResult<string> AddOrganizationAutomaticSigningProfile(AuthorizationApiModel authorization, AutomaticSigningProfileApiModel model)
		{
			return ExecuteSynchronousRequest<string, AutomaticSigningProfileApiModel>(ENDPOINT_ADD_ORGANIZATION_AUTOMATIC_SIGNING_PROFILE, authorization, model);
		}

		public async Task<BulksignResult<string>> AddOrganizationAutomaticSigningProfileAsync(AuthorizationApiModel authorization, AutomaticSigningProfileApiModel model)
		{
			return await ExecuteAsyncRequest<string, AutomaticSigningProfileApiModel>(ENDPOINT_ADD_ORGANIZATION_AUTOMATIC_SIGNING_PROFILE, authorization, model);
		}

		public BulksignResult<string> AddContact(AuthorizationApiModel authorization, NewContactApiModel model)
		{
			return ExecuteSynchronousRequest<string, NewContactApiModel>(ENDPOINT_ADD_CONTACT, authorization, model);
		}

		public async Task<BulksignResult<string>> AddContactAsync(AuthorizationApiModel authorization, NewContactApiModel model)
		{
			return await ExecuteAsyncRequest<string, NewContactApiModel>(ENDPOINT_ADD_CONTACT, authorization, model);
		}

		public BulksignResult<ContactResultApiModel[]> GetContacts(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<ContactResultApiModel[]>(ENDPOINT_GET_CONTACTS, authorization);
		}

		public async Task<BulksignResult<ContactResultApiModel[]>> GetContactsAsync(AuthorizationApiModel authorization)
		{
			return await ExecuteAsyncRequest<ContactResultApiModel[]>(ENDPOINT_GET_CONTACTS, authorization);
		}

		public BulksignResult<string> AddUserToOrganization(AuthorizationApiModel authorization, NewUserApiModel model)
		{
			return ExecuteSynchronousRequest<string, NewUserApiModel>(ENDPOINT_ADD_USER_TO_ORGANIZATION, authorization, model);
		}

		public async Task<BulksignResult<string>> AddUserToOrganizationAsync(AuthorizationApiModel authorization, NewUserApiModel model)
		{
			return await ExecuteAsyncRequest<string, NewUserApiModel>(ENDPOINT_ADD_USER_TO_ORGANIZATION, authorization, model);
		}

		public BulksignResult<string> InviteUserToOrganization(AuthorizationApiModel authorization, UserInvitationApiModel model)
		{
			return ExecuteSynchronousRequest<string, UserInvitationApiModel>(ENDPOINT_INVITE_USER_TO_ORGANIZATION, authorization, model);
		}

		public async Task<BulksignResult<string>> InviteUserToOrganizationAsync(AuthorizationApiModel authorization, UserInvitationApiModel model)
		{
			return await ExecuteAsyncRequest<string, UserInvitationApiModel>(ENDPOINT_INVITE_USER_TO_ORGANIZATION, authorization, model);
		}

		public BulksignResult<string> ReplaceBundleRecipient(AuthorizationApiModel authorization, ReplaceBundleRecipientApiModel model)
		{
			return ExecuteSynchronousRequest<string, ReplaceBundleRecipientApiModel>(ENDPOINT_REPLACE_RECIPIENT, authorization, model);
		}

		public async Task<BulksignResult<string>> ReplaceBundleRecipientAsync(AuthorizationApiModel authorization, ReplaceBundleRecipientApiModel model)
		{
			return await ExecuteAsyncRequest<string, ReplaceBundleRecipientApiModel>(ENDPOINT_REPLACE_RECIPIENT, authorization, model);
		}
		
		public BulksignResult<string> DeleteBundle(AuthorizationApiModel authorization, string bundleId)
		{
			return ExecuteSynchronousRequest<string>(ENDPOINT_DELETE_BUNDLE + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}

		public async Task<BulksignResult<string>> DeleteBundleAsync(AuthorizationApiModel authorization, string bundleId)
		{
			return await ExecuteAsyncRequest<string>(ENDPOINT_DELETE_BUNDLE + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}
		

		public BulksignResult<string> CancelBundle(AuthorizationApiModel authorization, string bundleId)
		{
			return ExecuteSynchronousRequest<string>(ENDPOINT_CANCEL_BUNDLE + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}

		public async Task<BulksignResult<string>> CancelBundleAsync(AuthorizationApiModel authorization, string bundleId)
		{
			return await ExecuteAsyncRequest<string>(ENDPOINT_CANCEL_BUNDLE + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}

		public BulksignResult<string> DeleteDraft(AuthorizationApiModel authorization, string draftId)
		{
			return ExecuteSynchronousRequest<string>(ENDPOINT_DELETE_DRAFT + $"?{PARAMETER_DRAFT_ID}=" + HttpUtility.UrlEncode(draftId), authorization);
		}

		public async Task<BulksignResult<string>> DeleteDraftAsync(AuthorizationApiModel authorization, string bundleId)
		{
			return await ExecuteAsyncRequest<string>(ENDPOINT_DELETE_DRAFT + $"?{PARAMETER_DRAFT_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}

		public BulksignResult<string> DeleteTemplate(AuthorizationApiModel authorization, string templateId)
		{
			return ExecuteSynchronousRequest<string>(ENDPOINT_DELETE_TEMPLATE + $"?{PARAMETER_TEMPLATE_ID}=" + HttpUtility.UrlEncode(templateId), authorization);
		}

		public async Task<BulksignResult<string>> DeleteTemplateAsync(AuthorizationApiModel authorization, string templateId)
		{
			return await ExecuteAsyncRequest<string>(ENDPOINT_DELETE_TEMPLATE + $"?{PARAMETER_TEMPLATE_ID}=" + HttpUtility.UrlEncode(templateId), authorization);
		}
		
		public BulksignResult<string> DeleteBundleRecipient(AuthorizationApiModel authorization, DeleteBundleRecipientApiModel model)
		{
			return ExecuteSynchronousRequest<string, DeleteBundleRecipientApiModel>(ENDPOINT_DELETE_BUNDLE_RECIPIENT, authorization, model);
		}

		public async Task<BulksignResult<string>> DeleteBundleRecipientAsync(AuthorizationApiModel authorization, DeleteBundleRecipientApiModel model)
		{
			return await ExecuteAsyncRequest<string, DeleteBundleRecipientApiModel>(ENDPOINT_DELETE_BUNDLE_RECIPIENT, authorization, model);
		}
		
		public BulksignResult<string[]> GetSignatureImprints(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<string[]>(ENDPOINT_GET_SIGNATURE_IMPRINTS, authorization);
		}

		public async Task<BulksignResult<string[]>> GetSignatureImprintsAsync(AuthorizationApiModel authorization)
		{
			return  await ExecuteAsyncRequest<string[]>(ENDPOINT_GET_SIGNATURE_IMPRINTS, authorization);
		}

		public BulksignResult<AutomaticSigningProfileResultApiModel[]> GetUserAutomaticSigningProfiles(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<AutomaticSigningProfileResultApiModel[]>(ENDPOINT_GET_USER_AUTOMATIC_SIGNING_PROFILES, authorization);
		}

		public async Task<BulksignResult<AutomaticSigningProfileResultApiModel[]>> GetUserAutomaticSigningProfilesAsync(AuthorizationApiModel authorization)
		{
			return await ExecuteAsyncRequest<AutomaticSigningProfileResultApiModel[]>(ENDPOINT_GET_USER_AUTOMATIC_SIGNING_PROFILES, authorization);
		}
		
		public BulksignResult<AutomaticSigningProfileResultApiModel[]> GetOrganizationAutomaticSigningProfiles(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<AutomaticSigningProfileResultApiModel[]>(ENDPOINT_GET_ORGANIZATION_AUTOMATIC_SIGNING_PROFILES, authorization);
		}

		public async Task<BulksignResult<AutomaticSigningProfileResultApiModel[]>> GetOrganizationAutomaticSigningProfilesAsync(AuthorizationApiModel authorization)
		{
			return await ExecuteAsyncRequest<AutomaticSigningProfileResultApiModel[]>(ENDPOINT_GET_ORGANIZATION_AUTOMATIC_SIGNING_PROFILES, authorization);
		}

		public BulksignResult<string> CreateShareTeam(AuthorizationApiModel authorization, TeamShareApiModel model)
		{
			return ExecuteSynchronousRequest<string, TeamShareApiModel>(ENDPOINT_CREATE_SHARE_TEAM, authorization, model);
		}

		public async Task<BulksignResult<string>> CreateShareTeamAsync(AuthorizationApiModel authorization, TeamShareApiModel model)
		{
			return await ExecuteAsyncRequest<string, TeamShareApiModel>(ENDPOINT_CREATE_SHARE_TEAM, authorization, model);
		}


		public BulksignResult<string> CreateHierarchicalTeam(AuthorizationApiModel authorization, TeamHierarchicalApiModel model)
		{
			return ExecuteSynchronousRequest<string, TeamHierarchicalApiModel>(ENDPOINT_CREATE_HIERARCHICAL_TEAM, authorization, model);
		}

		public Task<BulksignResult<string>> CreateHierarchicalTeamAsync(AuthorizationApiModel authorization, TeamHierarchicalApiModel model)
		{
			return ExecuteAsyncRequest<string, TeamHierarchicalApiModel>(ENDPOINT_CREATE_HIERARCHICAL_TEAM, authorization, model);
		}





		public BulksignResult<OrganizationUserApiModel[]> GetOrganizationUsers(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<OrganizationUserApiModel[]>(ENDPOINT_GET_ORGANIZATION_USERS, authorization);
		}

		public async Task<BulksignResult<OrganizationUserApiModel[]>> GetOrganizationUsersAsync(AuthorizationApiModel authorization)
		{
			return await ExecuteAsyncRequest<OrganizationUserApiModel[]>(ENDPOINT_GET_ORGANIZATION_USERS, authorization);
		}

		public BulksignResult<string> SendBundleReminder(AuthorizationApiModel authorization, string bundleId)
		{
			return ExecuteSynchronousRequest<string>(ENDPOINT_SEND_BUNDLE_REMINDER + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}

		public async Task<BulksignResult<string>> SendBundleReminderAsync(AuthorizationApiModel authorization, string bundleId)
		{
			return await ExecuteAsyncRequest<string>(ENDPOINT_SEND_BUNDLE_REMINDER + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}
		
		public BulksignResult<int> GetDraftsCount(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<int>(ENDPOINT_GET_DRAFTS_COUNT, authorization);
		}
		
		public async Task<BulksignResult<int>> GetDraftsCountAsync(AuthorizationApiModel authorization)
		{
			return await ExecuteAsyncRequest<int>(ENDPOINT_GET_DRAFTS_COUNT, authorization);
		}

		public BulksignResult<int> GetTemplatesCount(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<int>(ENDPOINT_GET_TEMPLATES_COUNT, authorization);
		}

		public async Task<BulksignResult<int>> GetTemplatesCountAsync(AuthorizationApiModel authorization)
		{
			return await ExecuteAsyncRequest<int>(ENDPOINT_GET_TEMPLATES_COUNT, authorization);
		}


		public BulksignResult<ItemResultApiModel[]> GetDrafts(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<ItemResultApiModel[]>(ENDPOINT_GET_DRAFTS, authorization);
		}

		public async Task<BulksignResult<ItemResultApiModel[]>> GetDraftsAsync(AuthorizationApiModel authorization)
		{
			return await ExecuteAsyncRequest<ItemResultApiModel[]>(ENDPOINT_GET_DRAFTS, authorization);
		}

		
		public BulksignResult<DraftDetailsResultApiModel> GetDraftDetails(AuthorizationApiModel authorization, string draftId)
		{
			return ExecuteSynchronousRequest<DraftDetailsResultApiModel>(ENDPOINT_GET_DRAFT_DETAILS + $"?{PARAMETER_DRAFT_ID}=" + HttpUtility.UrlEncode(draftId), authorization);
		}

		public async Task<BulksignResult<DraftDetailsResultApiModel>> GetDraftDetailsAsync(AuthorizationApiModel authorization, string draftId)
		{
			return await ExecuteAsyncRequest<DraftDetailsResultApiModel>(ENDPOINT_GET_DRAFT_DETAILS + $"?{PARAMETER_DRAFT_ID}=" + HttpUtility.UrlEncode(draftId), authorization);
		}


		public BulksignResult<BundleDetailsResultApiModel> GetBundleDetails(AuthorizationApiModel authorization, string bundleId)
		{
			return ExecuteSynchronousRequest<BundleDetailsResultApiModel>(ENDPOINT_GET_BUNDLE_DETAILS + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}
		
		public async Task<BulksignResult<BundleDetailsResultApiModel>> GetBundleDetailsAsync(AuthorizationApiModel authorization, string bundleId)
		{
			return await ExecuteAsyncRequest<BundleDetailsResultApiModel>(ENDPOINT_GET_BUNDLE_DETAILS + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}

		public BulksignResult<TemplateDetailsResultApiModel> GetTemplateDetails(AuthorizationApiModel authorization, string templateId)
		{
			return ExecuteSynchronousRequest<TemplateDetailsResultApiModel>(ENDPOINT_GET_TEMPLATE_DETAILS + $"?{PARAMETER_TEMPLATE_ID}=" + HttpUtility.UrlEncode(templateId), authorization);
		}

		public async Task<BulksignResult<TemplateDetailsResultApiModel>> GetTemplateDetailsAsync(AuthorizationApiModel authorization, string templateId)
		{
			return await ExecuteAsyncRequest<TemplateDetailsResultApiModel>(ENDPOINT_GET_TEMPLATE_DETAILS + $"?{PARAMETER_TEMPLATE_ID}=" + HttpUtility.UrlEncode(templateId), authorization);
		}
		
		public BulksignResult<string> CreateBulkTemplate(AuthorizationApiModel authorization, TemplateApiModel model)
		{
			return ExecuteSynchronousRequest<string, TemplateApiModel>(ENDPOINT_CREATE_BULK_TEMPLATE, authorization, model);
		}

		public async Task<BulksignResult<string>> CreateBulkTemplateAsync(AuthorizationApiModel authorization, TemplateApiModel model)
		{
			return await ExecuteAsyncRequest<string, TemplateApiModel>(ENDPOINT_CREATE_BULK_TEMPLATE, authorization, model);
		}
		

		public BulksignResult<string> CreateTemplate(AuthorizationApiModel authorization, TemplateApiModel model)
		{
			return ExecuteSynchronousRequest<string, TemplateApiModel>(ENDPOINT_CREATE_TEMPLATE, authorization, model);
		}

		public async Task<BulksignResult<string>> CreateTemplateAsync(AuthorizationApiModel authorization, TemplateApiModel model)
		{
			return await ExecuteAsyncRequest<string, TemplateApiModel>(ENDPOINT_CREATE_TEMPLATE, authorization, model);
		}


		public BulksignResult<BundleStatusApi> GetBundleStatus(AuthorizationApiModel authorization, string bundleId)
		{
			return ExecuteSynchronousRequest<BundleStatusApi>(ENDPOINT_BUNDLE_STATUS + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}

		public async Task<BulksignResult<BundleStatusApi>> GetBundleStatusAsync(AuthorizationApiModel authorization, string bundleId)
		{
			return await ExecuteAsyncRequest<BundleStatusApi>(ENDPOINT_BUNDLE_STATUS + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundleId), authorization);
		}


		public BulksignResult<ItemResultApiModel[]> GetBundlesByStatus(AuthorizationApiModel authorization, BundleStatusApi status)
		{
			return ExecuteSynchronousRequest<ItemResultApiModel[]>(ENDPOINT_BUNDLE_BY_STATUS + $"/?{PARAMETER_STATUS}=" + ((int)status).ToString(), authorization);
		}

		public async Task<BulksignResult<ItemResultApiModel[]>> GetBundlesByStatusAsync(AuthorizationApiModel authorization, BundleStatusApi status)
		{
			return await ExecuteAsyncRequest<ItemResultApiModel[]>(ENDPOINT_BUNDLE_BY_STATUS + $"/?{PARAMETER_STATUS}=" +  ((int)status).ToString() , authorization);
		}
		
		public BulksignResult<TemplateItemResultApiModel[]> GetTemplates(AuthorizationApiModel authorization)
		{
			return ExecuteSynchronousRequest<TemplateItemResultApiModel[]>(ENDPOINT_GET_TEMPLATES, authorization);
		}

		public async Task<BulksignResult<TemplateItemResultApiModel[]>> GetTemplatesAsync(AuthorizationApiModel authorization)
		{
			return await ExecuteAsyncRequest<TemplateItemResultApiModel[]>(ENDPOINT_GET_TEMPLATES, authorization);
		}

		public BulksignResult<string> CreateBulkDraft(AuthorizationApiModel authorization, DraftApiModel model)
		{
			return ExecuteSynchronousRequest<string, DraftApiModel>(ENDPOINT_CREATE_BULK_DRAFT, authorization, model);
		}

		public async Task<BulksignResult<string>> CreateBulkDraftAsync(AuthorizationApiModel authorization, DraftApiModel model)
		{
			return await ExecuteAsyncRequest<string, DraftApiModel>(ENDPOINT_CREATE_BULK_DRAFT, authorization, model);
		}

		public BulksignResult<SendBundleResultApiModel> SendBundleFromTemplate(AuthorizationApiModel authorization, string templateId)
		{
			return ExecuteSynchronousRequest<SendBundleResultApiModel>(ENDPOINT_SEND_BUNDLE_FROM_TEMPLATE + $"?{PARAMETER_TEMPLATE_ID}=" + HttpUtility.UrlEncode(templateId), authorization);
		}
		
		public async Task<BulksignResult<SendBundleResultApiModel>> SendBundleFromTemplateAsync(AuthorizationApiModel authorization, string templateId)
		{
			return await ExecuteAsyncRequest<SendBundleResultApiModel>(ENDPOINT_SEND_BUNDLE_FROM_TEMPLATE + $"?{PARAMETER_TEMPLATE_ID}=" + HttpUtility.UrlEncode(templateId), authorization);
		}

		public BulksignResult<string> CreateDraft(AuthorizationApiModel authorization, DraftApiModel model)
		{
			return ExecuteSynchronousRequest<string,DraftApiModel>(ENDPOINT_CREATE_DRAFT, authorization, model);
		}

		public async Task<BulksignResult<string>> CreateDraftAsync(AuthorizationApiModel authorization, DraftApiModel model)
		{
			return await ExecuteAsyncRequest<string,DraftApiModel>(ENDPOINT_CREATE_DRAFT, authorization, model);
		}

		public BulksignResult<SendBundleResultApiModel> SendBundleFromDraft(AuthorizationApiModel authorization, string draftId)
		{
			return ExecuteSynchronousRequest<SendBundleResultApiModel>(ENDPOINT_SEND_BUNDLE_FROM_DRAFT + $"/?{PARAMETER_DRAFT_ID}=" + HttpUtility.UrlEncode(draftId), authorization);
		}

		public async Task<BulksignResult<SendBundleResultApiModel>> SendBundleFromDraftAsync(AuthorizationApiModel authorization, string draftId)
		{
			return await ExecuteAsyncRequest<SendBundleResultApiModel>(ENDPOINT_SEND_BUNDLE_FROM_DRAFT + $"/?{PARAMETER_DRAFT_ID}=" + HttpUtility.UrlEncode(draftId), authorization);
		}

		public BulksignResult<SendBundleResultApiModel> SendBundle(AuthorizationApiModel authorization, BundleApiModel model)
		{
			return ExecuteSynchronousRequest<SendBundleResultApiModel, BundleApiModel>(ENDPOINT_SEND_BUNDLE, authorization, model);
		}

		public async Task<BulksignResult<SendBundleResultApiModel>> SendBundleAsync(AuthorizationApiModel authorization, BundleApiModel model)
		{
			return await ExecuteAsyncRequest<SendBundleResultApiModel, BundleApiModel>(ENDPOINT_SEND_BUNDLE, authorization, model);
		}


		public BulksignResult<SendBundleResultApiModel> SendBundleFromTemplateWithContext(AuthorizationApiModel authorization, BundleFromTemplateContextApiModel model)
		{
			return ExecuteSynchronousRequest<SendBundleResultApiModel, BundleFromTemplateContextApiModel>(ENDPOINT_SEND_BUNDLE_FROM_TEMPLATE_WITH_CONTEXT, authorization, model);
		}

		public async Task<BulksignResult<SendBundleResultApiModel>> SendBundleFromTemplateWithContextAsync(AuthorizationApiModel authorization, BundleFromTemplateContextApiModel model)
		{
			return await ExecuteAsyncRequest<SendBundleResultApiModel, BundleFromTemplateContextApiModel>(ENDPOINT_SEND_BUNDLE_FROM_TEMPLATE_WITH_CONTEXT, authorization, model);
		}


		public BulksignResult<SendBundleResultApiModel> SendBulkBundle(AuthorizationApiModel authorization, BundleApiModel model)
		{
			return ExecuteSynchronousRequest<SendBundleResultApiModel, BundleApiModel>(ENDPOINT_SEND_BULK_BUNDLE, authorization, model);
		}

		public async Task<BulksignResult<SendBundleResultApiModel>> SendBulkBundleAsync(AuthorizationApiModel authorization, BundleApiModel model)
		{
			return await ExecuteAsyncRequest<SendBundleResultApiModel, BundleApiModel>(ENDPOINT_SEND_BULK_BUNDLE, authorization, model);
		}
		
		public BulksignResult<AnalyzedFileResultApiModel> AnalyzeFile(AuthorizationApiModel authorization, byte[] pdfFileContent)
		{
			return ExecuteSynchronousRequest<AnalyzedFileResultApiModel>(ENDPOINT_ANALYZE_FILE, authorization, pdfFileContent);
		}

		public async Task<BulksignResult<AnalyzedFileResultApiModel>> AnalyzeFileAsync(AuthorizationApiModel authorization, byte[] pdfFileContent)
		{
			return await ExecuteAsyncRequest<AnalyzedFileResultApiModel>(ENDPOINT_ANALYZE_FILE, authorization, pdfFileContent);
		}
		
		public BulksignResult<AnalyzedFileResultApiModel> AnalyzeFileBase64(AuthorizationApiModel authorization, string base64FileContent)
		{
			return ExecuteSynchronousRequest<AnalyzedFileResultApiModel>(ENDPOINT_ANALYZE_FILE_BASE64, authorization, base64FileContent);
		}

		public async Task<BulksignResult<AnalyzedFileResultApiModel>> AnalyzeFileBase64Async(AuthorizationApiModel authorization, string base64FileContent)
		{
			return await ExecuteAsyncRequest<AnalyzedFileResultApiModel>(ENDPOINT_ANALYZE_FILE_BASE64, authorization, base64FileContent);
		}

		public BulksignResult<string> CreateDraftFromFileBase64(AuthorizationApiModel authorization, string fileContentBase64, string fileName)
		{
			return ExecuteSynchronousRequest<string>($"{ENDPOINT_CREATE_DRAFT_FROM_FILE_BASE64}?{PARAMETER_FILE_NAME}=" + WebUtility.UrlEncode(fileName ?? ""), authorization, fileContentBase64);
		}

		public async Task<BulksignResult<string>> CreateDraftFromFileBase64Async(AuthorizationApiModel authorization, string fileContentBase64, string fileName)
		{
			return await ExecuteAsyncRequest<string>($"{ENDPOINT_CREATE_DRAFT_FROM_FILE_BASE64}?{PARAMETER_FILE_NAME}=" + WebUtility.UrlEncode(fileName ?? ""), authorization, fileContentBase64);
		}

		public BulksignResult<string> CreateDraftFromFile(AuthorizationApiModel authorization, byte[] fileContent, string fileName)
		{
			return ExecuteSynchronousRequest<string>($"{ENDPOINT_CREATE_DRAFT_FROM_FILE}?{PARAMETER_FILE_NAME}=" + WebUtility.UrlEncode(fileName ?? ""), authorization, fileContent);
		}

		public async Task<BulksignResult<string>> CreateDraftFromFileAsync(AuthorizationApiModel authorization, byte[] fileContent, string fileName)
		{
			return await ExecuteAsyncRequest<string>($"{ENDPOINT_CREATE_DRAFT_FROM_FILE}?{PARAMETER_FILE_NAME}=" + WebUtility.UrlEncode(fileName ?? ""), authorization, fileContent);
		}

		public BulksignResult<byte[]> GetIncompleteDocuments(AuthorizationApiModel authorization, string bundlePublicId)
		{
			string response = string.Empty;
			try
			{
				RestClient rc = CreateRestClientInstance();
				response = rc.SendRequest(authorization, $"GetPartiallySignedDocuments?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundlePublicId), string.Empty);
				BulksignResult<byte[]> result = rc.Deserialize<BulksignResult<byte[]>>(response);
				return result;
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

		public async Task<BulksignResult<byte[]>> GetIncompleteDocumentsAsync(AuthorizationApiModel authorizationToken, string bundlePublicId)
		{
			string response = string.Empty;
			try
			{
				RestClient rc = CreateRestClientInstance();
				response = await rc.SendRequestAsync(authorizationToken, $"GetPartiallySignedDocuments?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundlePublicId), string.Empty);
				return await Task.FromResult(rc.Deserialize<BulksignResult<byte[]>>(response));
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}


		public BulksignResult<byte[]> GetCompletedDocuments(AuthorizationApiModel authorization, string bundlePublicId)
		{
			string response = string.Empty;
			try
			{
				RestClient rc = CreateRestClientInstance();
				response = rc.SendRequest(authorization, ENDPOINT_GET_FINISHED_DOCUMENTS + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundlePublicId), string.Empty);
				BulksignResult<byte[]> result = rc.Deserialize<BulksignResult<byte[]>>(response);
				return result;
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

		public async Task<BulksignResult<byte[]>> GetCompletedDocumentsAsync(AuthorizationApiModel authorization, string bundlePublicId)
		{
			string response = string.Empty;
			try
			{
				RestClient rc = CreateRestClientInstance();
				response = await rc.SendRequestAsync(authorization, ENDPOINT_GET_FINISHED_DOCUMENTS + $"?{PARAMETER_BUNDLE_ID}=" + HttpUtility.UrlEncode(bundlePublicId), string.Empty);
				return await Task.FromResult(rc.Deserialize<BulksignResult<byte[]>>(response));
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

		
		public string GetVersion()
		{
			string response = string.Empty;
			try
			{
				RestClient rc = CreateRestClientInstance();
				response = rc.SendRequest(new AuthorizationApiModel(), ENDPOINT_GET_VERSION, string.Empty);
				return response;
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

		public async Task<string> GetVersionAsync()
		{
			string response = string.Empty;
			try
			{
				RestClient rc = CreateRestClientInstance();
				return await rc.SendRequestAsync(new AuthorizationApiModel(), ENDPOINT_GET_VERSION, string.Empty);
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

		public string DefaultRestApiEndpoint => !string.IsNullOrEmpty(this.restAPIEndpointUrl) ? restAPIEndpointUrl : Constants.DEFAULT_REST_API_URL;

		public int Timeout => timeout ?? Constants.DEFAULT_TIMEOUT_SECONDS;

		private BulksignException GetException(Exception ex, string response)
		{
			BulksignException be = new BulksignException(ex.Message, ex);
			be.Response = response;
			return be;
		}

		private RestClient CreateRestClientInstance()
		{
			return new RestClient(this.DefaultRestApiEndpoint, this.Timeout);
		}

		private BulksignResult<R> ExecuteSynchronousRequest<R,T>(string name, AuthorizationApiModel authorization, T model)
		{
			string response = string.Empty;

			try
			{
				RestClient rc = CreateRestClientInstance();
				response = rc.SendRequest(authorization, name, rc.Serialize(model));
				return rc.Deserialize<BulksignResult<R>>(response);
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

		private BulksignResult<T> ExecuteSynchronousRequest<T>(string name, AuthorizationApiModel authorization)
		{
			string response = string.Empty;

			try
			{
				RestClient rc = CreateRestClientInstance();
				response = rc.SendRequest(authorization, name, string.Empty);
				return rc.Deserialize<BulksignResult<T>>(response);
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

		private BulksignResult<T> ExecuteSynchronousRequest<T>(string name, AuthorizationApiModel authorization, byte[] body)
		{
			string response = string.Empty;

			try
			{
				RestClient rc = CreateRestClientInstance();
				response = rc.SendRequest(authorization, name, body);
				return rc.Deserialize<BulksignResult<T>>(response);
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

		private BulksignResult<T> ExecuteSynchronousRequest<T>(string name, AuthorizationApiModel authorization, string body)
		{
			string response = string.Empty;

			try
			{
				RestClient rc = CreateRestClientInstance();
				response = rc.SendRequest(authorization, name, body);
				return rc.Deserialize<BulksignResult<T>>(response);
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}


		private async Task<BulksignResult<T>> ExecuteAsyncRequest<T>(string name, AuthorizationApiModel authorization)
		{
			string response = string.Empty;

			try
			{
				RestClient rc = CreateRestClientInstance();
				response = await rc.SendRequestAsync(authorization, name, string.Empty);
				return await Task.FromResult(rc.Deserialize<BulksignResult<T>>(response));
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}


		private async Task<BulksignResult<T>> ExecuteAsyncRequest<T>(string name, AuthorizationApiModel authorization, byte[] body)
		{
			string response = string.Empty;

			try
			{
				RestClient rc = CreateRestClientInstance();
				response = await rc.SendRequestAsync(authorization, name, body);
				return await Task.FromResult(rc.Deserialize<BulksignResult<T>>(response));
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}


		private async Task<BulksignResult<T>> ExecuteAsyncRequest<T>(string name, AuthorizationApiModel authorization, string body)
		{
			string response = string.Empty;

			try
			{
				RestClient rc = CreateRestClientInstance();
				response = await rc.SendRequestAsync(authorization, name, body);
				return await Task.FromResult(rc.Deserialize<BulksignResult<T>>(response));
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}


		private async Task<BulksignResult<R>> ExecuteAsyncRequest<R,T>(string name, AuthorizationApiModel authorization, T model)
		{
			string response = string.Empty;

			try
			{
				RestClient rc = CreateRestClientInstance();
				response = await rc.SendRequestAsync(authorization, name,rc.Serialize(model));
				return await Task.FromResult(rc.Deserialize<BulksignResult<R>>(response));
			}
			catch (Exception ex)
			{
				throw GetException(ex, response);
			}
		}

	}
}