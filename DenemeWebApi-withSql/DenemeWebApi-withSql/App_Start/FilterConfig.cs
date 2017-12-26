using System.Web;
using System.Web.Mvc;

namespace DenemeWebApi_withSql
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
