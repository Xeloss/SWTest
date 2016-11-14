using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace SWTest.Utils
{
    public class OutputCacheProfile : OutputCacheAttribute
    {
        private const string sectionPath = "system.web/caching/outputCacheSettings";

        protected static OutputCacheProfileCollection profiles
        {
            get
            {
                var section = (OutputCacheSettingsSection)WebConfigurationManager.GetSection(sectionPath);
                if (section != null)
                {
                    return section.OutputCacheProfiles;
                }
                return null;
            }
        }

        public OutputCacheProfile(string CacheProfile)
            : base()
        {
            this.CacheProfile = CacheProfile;

            if (!string.IsNullOrEmpty(this.CacheProfile))
                this.VaryByParam = profiles[this.CacheProfile].VaryByParam;
        }

    }
}