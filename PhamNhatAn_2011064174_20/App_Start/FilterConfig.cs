﻿using System.Web;
using System.Web.Mvc;

namespace PhamNhatAn_2011064174_20
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
