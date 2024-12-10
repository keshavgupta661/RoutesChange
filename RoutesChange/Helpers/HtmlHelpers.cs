using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RoutesChange.Helpers
{
    public static class HtmlHelpers
    {
        public static string RemoveString(this HtmlHelper htmlHelpers, string text, int length)
        {
            if(text.Length < length)
            {
                return text;
            }
            else
                return text.Substring(0, length);
        }
    }
}