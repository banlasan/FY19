﻿//--------------------------------------------------------------------------------------------------
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

[assembly: RegisterDocumentType(General.CLASS_NAME, typeof(General))]

namespace CMS.DocumentEngine.Types.KMJPage
{
	/// <summary>
	/// Represents a content item of type General.
	/// </summary>
	public partial class General : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "KMJPage.General";


		/// <summary>
		/// The instance of the class that provides extended API for working with General fields.
		/// </summary>
		private readonly GeneralFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// GuardiansID.
		/// </summary>
		[DatabaseIDField]
		public int GuardiansID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("GuardiansID"), 0);
			}
			set
			{
				SetValue("GuardiansID", value);
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
		/// Gets an object that provides extended API for working with General fields.
		/// </summary>
		[RegisterProperty]
		public GeneralFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with General fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class GeneralFields : AbstractHierarchicalObject<GeneralFields>
		{
			/// <summary>
			/// The content item of type General that is a target of the extended API.
			/// </summary>
			private readonly General mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="GeneralFields" /> class with the specified content item of type General.
			/// </summary>
			/// <param name="instance">The content item of type General that is a target of the extended API.</param>
			public GeneralFields(General instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// GuardiansID.
			/// </summary>
			public int GuardiansID
			{
				get
				{
					return mInstance.GuardiansID;
				}
				set
				{
					mInstance.GuardiansID = value;
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
		/// Initializes a new instance of the <see cref="General" /> class.
		/// </summary>
		public General() : base(CLASS_NAME)
		{
			mFields = new GeneralFields(this);
		}

		#endregion
	}
}