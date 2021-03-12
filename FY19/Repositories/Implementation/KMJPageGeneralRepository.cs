using CMS.SiteProvider;
using CMS.DocumentEngine;
using CMS.DocumentEngine.Types.KMJPage;
using System.Linq;
using CMS.EventLog;

namespace FY19.Repositories.Implementation
{
    public class KMJPageGeneralRepository : IKMJPageGeneralRepository
    {

        private readonly string mCultureName;
        private readonly bool mLatestVersionEnabled;

        public KMJPageGeneralRepository(string cultureName, bool latestVersionEnabled)
        {
            mCultureName = cultureName;
            mLatestVersionEnabled = latestVersionEnabled;
        }

        public General GetGeneral()
        {
            return GeneralProvider.GetGenerals()
                   .LatestVersion(mLatestVersionEnabled)
                   .OnSite(SiteContext.CurrentSiteName)
                   .Culture(mCultureName)
                   .CombineWithDefaultCulture()
                   .Path("/business/service/it-guardians/", PathTypeEnum.Children)
                   .TopN(1);
        }
    }
}