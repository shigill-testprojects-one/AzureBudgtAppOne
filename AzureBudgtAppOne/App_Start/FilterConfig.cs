using System.Web;
using System.Web.Mvc;

namespace AzureBudgtAppOne
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
