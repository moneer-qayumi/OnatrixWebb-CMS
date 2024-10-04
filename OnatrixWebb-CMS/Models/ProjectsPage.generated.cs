//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Our Projects Page</summary>
	[PublishedModel("projectsPage")]
	public partial class ProjectsPage : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "projectsPage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ProjectsPage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ProjectsPage(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Projects - Annual Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsAnnualButton")]
		public virtual string ProjectsAnnualButton => this.Value<string>(_publishedValueFallback, "projectsAnnualButton");

		///<summary>
		/// Projects - Annual Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsAnnualHeadline")]
		public virtual string ProjectsAnnualHeadline => this.Value<string>(_publishedValueFallback, "projectsAnnualHeadline");

		///<summary>
		/// Projects - Annual Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsAnnualImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectsAnnualImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectsAnnualImage");

		///<summary>
		/// Projects - Annual Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsAnnualText")]
		public virtual string ProjectsAnnualText => this.Value<string>(_publishedValueFallback, "projectsAnnualText");

		///<summary>
		/// Projects - Annual Time
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsAnnualTime")]
		public virtual string ProjectsAnnualTime => this.Value<string>(_publishedValueFallback, "projectsAnnualTime");

		///<summary>
		/// Projects - Budget Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBudgetButton")]
		public virtual string ProjectsBudgetButton => this.Value<string>(_publishedValueFallback, "projectsBudgetButton");

		///<summary>
		/// Projects - Budget Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBudgetHeadline")]
		public virtual string ProjectsBudgetHeadline => this.Value<string>(_publishedValueFallback, "projectsBudgetHeadline");

		///<summary>
		/// Projects - Budget Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBudgetImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectsBudgetImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectsBudgetImage");

		///<summary>
		/// Projects - Budget Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBudgetText")]
		public virtual string ProjectsBudgetText => this.Value<string>(_publishedValueFallback, "projectsBudgetText");

		///<summary>
		/// Projects - Budget Time
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBudgetTime")]
		public virtual string ProjectsBudgetTime => this.Value<string>(_publishedValueFallback, "projectsBudgetTime");

		///<summary>
		/// Projects - Business Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBusinessButton")]
		public virtual string ProjectsBusinessButton => this.Value<string>(_publishedValueFallback, "projectsBusinessButton");

		///<summary>
		/// Projects - Business Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBusinessHeadline")]
		public virtual string ProjectsBusinessHeadline => this.Value<string>(_publishedValueFallback, "projectsBusinessHeadline");

		///<summary>
		/// Projects - Business Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBusinessImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectsBusinessImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectsBusinessImage");

		///<summary>
		/// Projects - Business Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBusinessText")]
		public virtual string ProjectsBusinessText => this.Value<string>(_publishedValueFallback, "projectsBusinessText");

		///<summary>
		/// Projects - Business Time
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsBusinessTime")]
		public virtual string ProjectsBusinessTime => this.Value<string>(_publishedValueFallback, "projectsBusinessTime");

		///<summary>
		/// Projects - Financial Button
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsFinancialButton")]
		public virtual string ProjectsFinancialButton => this.Value<string>(_publishedValueFallback, "projectsFinancialButton");

		///<summary>
		/// Projects - Financial Headline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsFinancialHeadline")]
		public virtual string ProjectsFinancialHeadline => this.Value<string>(_publishedValueFallback, "projectsFinancialHeadline");

		///<summary>
		/// Projects - Financial Image
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsFinancialImage")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ProjectsFinancialImage => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "projectsFinancialImage");

		///<summary>
		/// Projects - Financial Text
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsFinancialText")]
		public virtual string ProjectsFinancialText => this.Value<string>(_publishedValueFallback, "projectsFinancialText");

		///<summary>
		/// Projects - Financial Time
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("projectsFinancialTime")]
		public virtual string ProjectsFinancialTime => this.Value<string>(_publishedValueFallback, "projectsFinancialTime");
	}
}
