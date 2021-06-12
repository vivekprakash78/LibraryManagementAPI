using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Options;
using System;

namespace Common
{
    public static class AppSettingsHelper
    {
        static IServiceProvider services = null;

        public static IServiceProvider Services
        {
            get { return services; }
            set
            {
                if (services != null)
                {
                    throw new Exception("Can't set once a value has already been set.");
                }
                services = value;
            }
        }

        public static AppSettings Config
        {
            get
            {
                var s = services.GetService(typeof(IOptionsMonitor<AppSettings>)) as IOptionsMonitor<AppSettings>;
                AppSettings config = s.CurrentValue;

                return config;
            }
        }

        public static IWebHostEnvironment HostingEnvironment
        {
            get
            {
                return services.GetService(typeof(IWebHostEnvironment)) as IWebHostEnvironment;
            }
        }
    }
}
