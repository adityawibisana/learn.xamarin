using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogspotXamarin.Services
{
    public sealed class RSSService
    {
        private static volatile RSSService instance;
        private static Object syncRoot = new Object();

        public String Link { get; set; }

        private RSSService()
        {

        }

        public static RSSService Instance
        {
            get
            {
                if (instance==null)
                {
                    lock(syncRoot)
                    {
                        if (instance == null)
                            instance = new RSSService();
                    }
                }
                return instance;
            }
        }
    }
}
