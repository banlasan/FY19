using Kentico.PageBuilder.Web.Mvc;
using FY19.Models.Widgets;
using FY19.Models.Sections;
using SeventyeightDigital.CKEditor4_Wysiwyg;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using FY19.Controllers.PageTemplates;

//Widgets
[assembly: RegisterWidget("FY19.Image", "Image", typeof(KMJ_Image), "Widgets/ImageView", Description = "Kentico Image", IconClass = "icon-pictures")]
[assembly: RegisterWidget("FY19.H2Header", "H2Header", typeof(KMJ_H2HeadingProperties), "Widgets/H2View", Description = "H2 Header", IconClass = "icon-l-header-text")]
[assembly: RegisterWidget("FY19.H3Header", "H3Header", typeof(KMJ_H3HeadingProperties), "Widgets/H3View", Description = "H3 Header", IconClass = "icon-l-header-text")]
[assembly: RegisterWidget("FY19.H4Header", "H4Header", typeof(KMJ_H4HeadingProperties), "Widgets/H4View", Description = "H4 Header", IconClass = "icon-l-header-text")]
[assembly: RegisterWidget("FY19.BodyText", "BodyText", typeof(KMJ_TextContentProperties), "Widgets/BodyTextView", Description = "Body Text", IconClass = "icon-l-text")]
[assembly: RegisterWidget("FY19.StaticText", "StaticText", typeof(StaticTextModelProperties), "Widgets/StaticTextView", Description = "Static Text", IconClass = "icon-w-static-text")]
[assembly: RegisterWidget("FY19.DownloadItem", "DownloadItem", typeof(KMJ_DownloadItemProperties), "Widgets/DownloadItemView", Description = "Download Item", IconClass = "icon-w-static-html")]
[assembly: RegisterWidget("FY19.AnnotationList", "AnnotationList", typeof(KMJ_AnnotationListProperties), "Widgets/AnnotationListView", Description = "Annotation List", IconClass = "icon-list")]
[assembly: RegisterWidget("FY19.LinkList", "LinkList", typeof(KMJ_LinkListProperties), "Widgets/LinkListView", Description = "Link List", IconClass = "icon-list")]
[assembly: RegisterWidget("FY19.BreadCrumbs", "BreadCrumbs", typeof(BreadCrumbsProperties), "Widgets/BreadCrumbsView", Description = "BreadCrumbs", IconClass = "icon-list")]
[assembly: RegisterWidget("FY19.List", "List", typeof(KMJ_ListProperties), "Widgets/ListView", Description = "Link", IconClass = "icon-list")]
[assembly: RegisterWidget("FY19.AnchorList", "AnchorList", typeof(KMJ_AnchorLinkListProperties), "Widgets/AnchorLinkList", Description = "Link List", IconClass = "icon-list")]
[assembly: RegisterWidget("FY19.LinkButton", "LinkButton", typeof(KMJ_LinkButtonProperties), "Widgets/LinkButtonView", Description = "Link Button", IconClass = "icon-list")]
[assembly: RegisterWidget("FY19.HeadHTML", "HeadHTML", typeof(KMJ_HeadHTMLProperties), "Widgets/HeadHTMLView", Description = "HeadHTML", IconClass = "icon-l-header-text")]
[assembly: RegisterWidget("FY19.FreeHTML", "Free HTML", typeof(CKEditor4_WysiwygWidgetProperties), "Widgets/FreeHTMLView", Description = "WYSIWYG Editor", IconClass = "icon-l-header-text")]
[assembly: RegisterWidget("FY19.Table", "Table", typeof(CKEditor4_WysiwygWidgetProperties), "Widgets/TableView", IconClass = "icon-l-header-text")]
[assembly: RegisterWidget("FY19.Placeholder", "Placeholder", typeof(KMJ_PlaceholderProperties), "Widgets/PlaceholderView", Description = "Placeholder", IconClass = "icon-l-header-text")]

//Sections
[assembly: RegisterSection("FY19.SingColSec", "Single Column", typeof(SingleSectionProperties), "Sections/_SingleColumnView")]
[assembly: RegisterSection("FY19.IndexSection", "Index Section", typeof(IndexSectionProperties), "Sections/_IndexSectionView", IconClass = "icon-i-circle")]
[assembly: RegisterSection("FY19.TwoColumnSection", "Two Columns", typeof(KMJ_1_2ColumnProperties), "Sections/TwoColumnView", IconClass = "icon-l-cols-2")]
[assembly: RegisterSection("FY19.ThreeColumnSection", "Three Columns", typeof(KMJ_1_3ColumnProperties), "Sections/ThreeColumnView", IconClass = "icon-l-cols-3")]
[assembly: RegisterSection("FY19.TwoThirdsColumnSection", "2/3 Columns", typeof(KMJ_2_3ColumnProperties), "Sections/TwoThirdsColumnView", IconClass = "icon-2-cols-3")]
[assembly: RegisterSection("FY19.ColumnZone", "Column Zone", typeof(KMJ_ColumnZoneProperties), "Sections/ColumnZoneView", IconClass = "icon-2-cols-3")]