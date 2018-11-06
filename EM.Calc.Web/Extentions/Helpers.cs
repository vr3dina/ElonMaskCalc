using System;
using System.Web.Mvc;

namespace EM.Calc.Web.Extentions
{
    public static class Helpers
    {
        public static MvcHtmlString SuperButton(this HtmlHelper html)
        {
            return new MvcHtmlString("< input type\"button\" value =\"Super\" />");
        }

        public static DateTime Now(this HtmlHelper html)
        {
            return DateTime.Now;
        }
    }
}