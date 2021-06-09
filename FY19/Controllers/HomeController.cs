using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CMS.DocumentEngine;
using CMS.MediaLibrary;
using CMS.SiteProvider;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using Kentico.Web.Mvc;
using KMVCHelper;

namespace FY19.Controllers
{
    [KMVCRouteOverPathPriority]
    public class HomeController : PageTemplateController
    {
        // GET: Home
        public ActionResult Index()
        {

            var folderName = "FY19";

            var sss = MediaLibraryInfoProvider.GetMediaLibraryInfo(folderName, SiteContext.CurrentSiteName);

            // Gets the media library
            MediaLibraryInfo library = MediaLibraryInfoProvider.GetMediaLibraryInfo(folderName, SiteContext.CurrentSiteName);

            if (library != null)
            {
                // Creates the "NewFolder" folder within the media library
               // MediaLibraryInfoProvider.CreateMediaLibraryFolder(SiteContext.CurrentSiteName, library.LibraryID, "NewFolder");
            }
            else
            {
                // Creates a new media library object
                MediaLibraryInfo newLibrary = new MediaLibraryInfo();

                // Sets the library properties
                newLibrary.LibraryDisplayName = folderName;
                newLibrary.LibraryName = folderName;
                newLibrary.LibraryDescription = "This media library was created through the API.";
                newLibrary.LibraryFolder = folderName;
                newLibrary.LibrarySiteID = SiteContext.CurrentSiteID;
                // Saves the new media library to the database
                MediaLibraryInfoProvider.SetMediaLibraryInfo(newLibrary);
            }
       
            TreeNode page = DocumentHelper.GetDocuments().Path("/business/service/it-guardians/Home").OnCurrentSite().TopN(1).FirstOrDefault();
            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            // Use template if it has one.
            if (KMVCDynamicHttpHandler.PageHasTemplate(page))
            {
                return new TemplateResult(page.DocumentID);
            }
            else
            {
                return View();
            }
        }
    }
}