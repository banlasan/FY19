//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.KMJPage;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(ITGMasterPage.CLASS_NAME, typeof(ITGMasterPage))]

namespace CMS.DocumentEngine.Types.KMJPage
{
	/// <summary>
	/// Represents a content item of type ITGMasterPage.
	/// </summary>
	public partial class ITGMasterPage : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "KMJPage.ITGMasterPage";


		/// <summary>
		/// The instance of the class that provides extended API for working with ITGMasterPage fields.
		/// </summary>
		private readonly ITGMasterPageFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// ITGMasterPageID.
		/// </summary>
		[DatabaseIDField]
		public int ITGMasterPageID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("ITGMasterPageID"), 0);
			}
			set
			{
				SetValue("ITGMasterPageID", value);
			}
		}


		/// <summary>
		/// og:image.
		/// </summary>
		[DatabaseField]
		public string OgImage
		{
			get
			{
				return ValidationHelper.GetString(GetValue("OgImage"), @"");
			}
			set
			{
				SetValue("OgImage", value);
			}
		}


		/// <summary>
		/// Text.
		/// </summary>
		[DatabaseField]
		public string Text
		{
			get
			{
				return ValidationHelper.GetString(GetValue("Text"), @"");
			}
			set
			{
				SetValue("Text", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with ITGMasterPage fields.
		/// </summary>
		[RegisterProperty]
		public ITGMasterPageFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with ITGMasterPage fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class ITGMasterPageFields : AbstractHierarchicalObject<ITGMasterPageFields>
		{
			/// <summary>
			/// The content item of type ITGMasterPage that is a target of the extended API.
			/// </summary>
			private readonly ITGMasterPage mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="ITGMasterPageFields" /> class with the specified content item of type ITGMasterPage.
			/// </summary>
			/// <param name="instance">The content item of type ITGMasterPage that is a target of the extended API.</param>
			public ITGMasterPageFields(ITGMasterPage instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// ITGMasterPageID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.ITGMasterPageID;
				}
				set
				{
					mInstance.ITGMasterPageID = value;
				}
			}


			/// <summary>
			/// og:image.
			/// </summary>
			public string OgImage
			{
				get
				{
					return mInstance.OgImage;
				}
				set
				{
					mInstance.OgImage = value;
				}
			}


			/// <summary>
			/// Text.
			/// </summary>
			public string Text
			{
				get
				{
					return mInstance.Text;
				}
				set
				{
					mInstance.Text = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="ITGMasterPage" /> class.
		/// </summary>
		public ITGMasterPage() : base(CLASS_NAME)
		{
			mFields = new ITGMasterPageFields(this);
		}

		#endregion
	}
}