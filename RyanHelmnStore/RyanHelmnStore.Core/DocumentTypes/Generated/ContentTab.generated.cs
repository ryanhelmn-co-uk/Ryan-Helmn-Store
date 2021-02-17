//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.11.1
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder.Embedded;

namespace RyanHelmnStore.Core.DocumentTypes
{
	// Mixin Content Type with alias "contentTab"
	/// <summary>Content Tab</summary>
	public partial interface IContentTab : IPublishedContent
	{
		/// <summary>Main Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		global::Umbraco.Core.Models.Blocks.BlockListModel MainContent { get; }
	}

	/// <summary>Content Tab</summary>
	[PublishedModel("contentTab")]
	public partial class ContentTab : PublishedContentModel, IContentTab
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const string ModelTypeAlias = "contentTab";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContentTab, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public ContentTab(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Main Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		[ImplementPropertyType("mainContent")]
		public global::Umbraco.Core.Models.Blocks.BlockListModel MainContent => GetMainContent(this);

		/// <summary>Static getter for Main Content</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.11.1")]
		public static global::Umbraco.Core.Models.Blocks.BlockListModel GetMainContent(IContentTab that) => that.Value<global::Umbraco.Core.Models.Blocks.BlockListModel>("mainContent");
	}
}