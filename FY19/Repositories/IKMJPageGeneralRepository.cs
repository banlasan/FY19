using System;
using CMS.DocumentEngine.Types.KMJPage;

namespace FY19.Repositories
{
    public interface IKMJPageGeneralRepository : IRepository
    {
        General GetGeneral();
    }
}