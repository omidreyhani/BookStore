using System.Web.Mvc;

namespace BookStore.WebSite.Areas.CustomerSite
{
    public class CustomerSiteAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CustomerSite";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CustomerSite_default",
                "CustomerSite/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}