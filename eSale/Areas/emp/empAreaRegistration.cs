using System.Web.Mvc;

namespace eSale.Areas.emp
{
    public class empAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "emp";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "emp_default",
                "emp/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}