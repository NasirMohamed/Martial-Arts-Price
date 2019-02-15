using System.Web;
using System.Web.Mvc;

namespace Martial_Arts_Price
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
