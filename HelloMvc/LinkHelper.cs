using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace HelloMvc
{
    [HtmlTargetElement("li", Attributes = ATTR)]
    public class NavHelper : TagHelper
    {
        public const string ATTR="active-action";
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var pageController = ViewContext.RouteData.Values["action"].ToString();
            var attrValue = context.AllAttributes[ATTR].Value.ToString();

            if (String.Compare(pageController, attrValue, true) == 0)
            {
                output.Attributes.Add("class", "active");
            }
            else
            {
                output.Attributes.Remove("class");
            }
            output.Attributes.Remove(ATTR);
        }
    }
}