using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace LetsFlip.Class
{

    public class ChildActionOutputCacheAttribute : OutputCacheAttribute
    {
        /// <summary>
        /// This class is use for using outputcache on childactiononly. 
        /// How to use [ChildActionOutputCacheAttribute(CacheProfile = "1MinCache")]
        /// </summary>
        /// <param name="cacheProfile"></param>
        public ChildActionOutputCacheAttribute(string cacheProfile)
        {
            
            var settings = (OutputCacheSettingsSection)WebConfigurationManager.GetSection("system.web/caching/outputCacheSettings");
            var profile = settings.OutputCacheProfiles[cacheProfile];
            Duration = profile.Duration;
            VaryByParam = profile.VaryByParam;
            VaryByCustom = profile.VaryByCustom;
        }
    }
}