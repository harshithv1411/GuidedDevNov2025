namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UsrYachtServiceSchema

	/// <exclude/>
	public class UsrYachtServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UsrYachtServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UsrYachtServiceSchema(UsrYachtServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f4176f8-f3df-4d3c-8231-09e7ba98dbc9");
			Name = "UsrYachtService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("62ec4902-3b5e-4e7d-ae9b-aa62ddb06d51");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,4,0,21,137,187,13,128,48,12,5,107,144,216,225,198,97,13,236,87,196,65,2,41,38,251,227,116,247,57,175,145,45,190,134,155,209,57,118,165,103,247,130,45,229,197,18,196,114,184,9,77,224,125,180,62,193,68,86,145,31,204,49,230,114,70,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f4176f8-f3df-4d3c-8231-09e7ba98dbc9"));
		}

		#endregion

	}

	#endregion

}

