
namespace Bulksign.Api
{
	public class DocumentApiModel
	{
		public FileIdentifier FileIdentifier
		{
			get;
			set;
		}

		public FileContentByteArray FileContentByteArray
		{
			get;
			set;
		}
		
		public FileContentBase64String FileContentBase64String
		{
			get;
			set;
		}


		public FileNetworkShare FileNetworkShare
		{
			get;
			set;
		}

		public string FileName
		{
			get;
			set;
		}

		public int Index
		{
			get;
			set;
		}

		public AssignmentApiModel[] FieldAssignments
		{
			get;
			set;
		}

		public NewSignatureApiModel[] NewSignatures
		{
			get;
			set;
		}

		public NewAnnotationApiModel[] NewAnnotations
		{
			get;
			set;
		}
		
		public NewTextBoxApiModel[] NewTextBoxes
		{
			get;
			set;
		}

		public NewComboBoxApiModel[] NewComboBoxes
		{
			get;
			set;
		}

		public NewCheckBoxApiModel[] NewCheckBoxes
		{
			get;
			set;
		}

		public OverwriteFieldValueApiModel[] OverwriteValues
		{
			get;
			set;
		}
	}
}