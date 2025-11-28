namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtEventsSchema

	/// <exclude/>
	public class UsrYachtEventsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtEventsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtEventsSchema(UsrYachtEventsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0821d0c4-f6c1-4b90-89c2-bafc6da418eb");
			Name = "UsrYachtEvents";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("62ec4902-3b5e-4e7d-ae9b-aa62ddb06d51");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,141,82,93,107,220,48,16,124,118,32,255,97,241,147,13,135,72,94,155,54,144,187,92,74,32,180,165,246,5,74,232,131,78,222,243,169,232,195,104,229,75,175,37,255,189,178,100,187,161,77,75,12,150,144,118,118,118,102,181,134,107,164,142,11,132,26,157,227,100,119,158,173,172,217,201,182,119,220,75,107,78,79,78,79,126,14,75,214,147,52,45,84,71,242,168,47,158,221,60,79,212,218,154,127,197,28,178,181,241,210,75,164,87,64,216,250,128,198,143,200,135,120,123,140,87,119,50,8,48,232,138,74,236,81,243,15,193,0,188,131,124,67,238,11,23,123,159,151,95,99,74,215,111,149,20,32,20,39,130,24,121,129,3,222,192,146,19,190,16,137,28,201,247,68,101,15,65,169,108,16,14,86,54,240,209,84,252,16,244,23,118,251,13,133,7,66,211,160,91,64,226,90,226,46,152,137,140,87,174,37,192,50,81,141,140,217,54,84,101,51,197,148,139,229,197,24,79,44,112,28,116,7,119,69,58,151,9,56,129,26,20,82,115,5,157,147,98,232,65,68,179,247,232,235,99,135,205,202,170,94,155,123,174,122,124,59,34,47,139,161,77,159,6,120,62,151,146,59,40,18,195,37,156,159,197,111,20,59,171,205,144,221,210,138,27,129,10,155,80,200,187,30,99,250,20,39,239,134,167,12,163,68,188,197,26,117,167,184,31,36,25,124,132,59,43,184,146,63,248,86,97,21,113,69,18,186,33,116,97,212,76,232,94,152,51,246,25,201,246,78,4,140,117,129,100,49,113,103,243,211,166,137,200,23,144,255,69,73,44,26,189,165,218,218,165,108,211,41,47,89,109,199,146,229,127,244,6,157,233,130,221,88,167,185,47,254,240,17,10,158,67,104,75,252,55,213,245,239,222,101,126,239,236,99,116,185,254,46,176,27,140,76,217,51,232,41,237,105,139,235,211,47,241,194,92,159,118,3,0,0 };
		}

		protected override void InitializeLocalizableStrings() {
			base.InitializeLocalizableStrings();
			SetLocalizableStringsDefInheritance();
			LocalizableStrings.Add(CreateValueIsTooBigLocalizableString());
		}

		protected virtual SchemaLocalizableString CreateValueIsTooBigLocalizableString() {
			SchemaLocalizableString localizableString = new SchemaLocalizableString() {
				UId = new Guid("0b6941db-9e9f-e359-8108-e29076e2767f"),
				Name = "ValueIsTooBig",
				CreatedInPackageId = new Guid("62ec4902-3b5e-4e7d-ae9b-aa62ddb06d51"),
				CreatedInSchemaUId = new Guid("0821d0c4-f6c1-4b90-89c2-bafc6da418eb"),
				ModifiedInSchemaUId = new Guid("0821d0c4-f6c1-4b90-89c2-bafc6da418eb")
			};
			return localizableString;
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0821d0c4-f6c1-4b90-89c2-bafc6da418eb"));
		}

		#endregion

	}

	#endregion

}

