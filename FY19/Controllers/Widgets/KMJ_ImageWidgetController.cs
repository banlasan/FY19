using System;
using System.Linq;
using System.Web.Mvc;

using CMS.MediaLibrary;
using CMS.SiteProvider;

using FY19.Controllers.Widgets;
using FY19.Infrastructure;
using FY19.Models.Widgets;
using FY19.Repositories;
using NLog;
using CMS.EventLog;

using Kentico.PageBuilder.Web.Mvc;

//[assembly: RegisterWidget("FY19.Image", typeof(KMJ_ImageWidgetController), "Image", Description = "KMJ Image", IconClass = "icon-id-card")]

namespace FY19.Controllers.Widgets
{
    public class KMJ_ImageWidgetController : WidgetController<KMJ_ImageProperties>
    {


        #region Logger

        private static readonly Logger log = LogManager.GetLogger("CLog");

        #endregion

        private readonly IMediaFileRepository mediaFileRepo;
        private readonly IOutputCacheDependencies outputCacheDependencies;

        public KMJ_ImageWidgetController(IMediaFileRepository mediaFileRepository, IOutputCacheDependencies outputCacheDependencies)
        {
            EventLogProvider.LogEvent(EventType.INFORMATION, "Entering KMJ_ImageWidgetController", "Image_Widget", eventDescription: "Success");
            this.mediaFileRepo = mediaFileRepository;
            this.outputCacheDependencies = outputCacheDependencies;
        }

        public ActionResult Index()
        {
            try
            {
                EventLogProvider.LogEvent(EventType.INFORMATION, "Entering Image Controller", "Image_Widget", eventDescription: "Success");
                var properties = GetProperties();
                var image = GetImage(properties);
                var imageSP = GetImageSP(properties);

                outputCacheDependencies.AddDependencyOnInfoObject<MediaFileInfo>(image?.FileGUID ?? Guid.Empty);
                outputCacheDependencies.AddDependencyOnInfoObject<MediaFileInfo>(imageSP?.FileGUID ?? Guid.Empty);

                log.Info("Entering Image Controller");

                return PartialView("Widgets/ImageView", new KMJ_ImageViewModel
                {
                    Image = image,
                    ImageSP = imageSP,
                    Alt = properties.Alt,
                    Id = properties.Id,
                    Image_class = properties.Image_class
                });
            }
            catch (Exception ex)
            {
                EventLogProvider.LogEvent(EventType.INFORMATION, "Entering Image Controller", "Image_Widget", eventDescription: ex.ToString());
                log.Error(ex.ToString());
                return PartialView("Widgets/ImageView", new KMJ_ImageViewModel
                {
                    Image = null,
                    ImageSP = null,
                    Alt = "",
                    Id = "",
                    Image_class = ""
                });
            }
        }

        private MediaFileInfo GetImage(KMJ_ImageProperties properties)
        {
            var imageGuid = properties.Image?.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            if (imageGuid == Guid.Empty)
            {
                return null;
            }

            return mediaFileRepo.GetMediaFile(imageGuid, SiteContext.CurrentSiteName);
        }
        private MediaFileInfo GetImageSP(KMJ_ImageProperties properties)
        {
            var imageGuid = properties.ImageSP?.FirstOrDefault()?.FileGuid ?? Guid.Empty;
            if (imageGuid == Guid.Empty)
            {
                return null;
            }

            return mediaFileRepo.GetMediaFile(imageGuid, SiteContext.CurrentSiteName);
        }
    }
}