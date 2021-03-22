using FY19.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;
using System.Xml.Linq;

namespace FY19.Helpers
{
    public class clsSitemap
    {
        public static string SetSitemap(UrlHelper urlHelper, string path)
        {
            string xml = GetSitemapDocument(GetNode(urlHelper));
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);
            doc.Save(path);
            return xml;
        }

        public static List<SitemapNode> GetNode(UrlHelper urlHelper)
        {
            List<SitemapNode> nodes = new List<SitemapNode>();
            string Domain = urlHelper.RequestContext.HttpContext.Request.Url.Scheme + "://" + urlHelper.RequestContext.HttpContext.Request.Url;
            //string xml = GetSitemapDocument(GetNode(urlHelper));

            nodes.Add(
                new SitemapNode()
                {
                    Url = Domain + urlHelper.Action("Index", "Home"),
                    Priority = 1
                });
            nodes.Add(
                new SitemapNode()
                {
                    Url = Domain + urlHelper.Action("Research", "Home"),
                    Priority = 1
                });
            nodes.Add(
                new SitemapNode()
                {
                    Url = Domain + urlHelper.Action("Contact", "Home"),
                    Priority = 1
                });

            return nodes;
        }

        public static string GetSitemapDocument(List<SitemapNode> sitemapNodes)
        {
            XNamespace xmlns = "http://www.sitemaps.org/schemas/sitemap/0.9";
            XElement root = new XElement(xmlns + "urlset");

            foreach (SitemapNode sitemapNode in sitemapNodes)
            {
                XElement urlElemant = new XElement(
                    xmlns + "url",
                    new XElement(xmlns + "loc", Uri.EscapeDataString(sitemapNode.Url)),
                    sitemapNode.LastModified == null ? null : new XElement(
                        xmlns + "lastmod",
                        sitemapNode.LastModified.Value.ToLocalTime().ToString("yyyy-MM-ddTHH:mm:sszzzz")),
                    sitemapNode.Frequency == null ? null : new XElement(
                        xmlns + "changefreq",
                        sitemapNode.Frequency.Value.ToString().ToLowerInvariant()),
                    sitemapNode.Priority == null ? null : new XElement(
                        xmlns + "priority",
                        sitemapNode.Priority.Value.ToString("F1", CultureInfo.InvariantCulture)));
                root.Add(urlElemant);
            }

            XDocument document = new XDocument(root);
            return document.ToString();
        }
    }
}