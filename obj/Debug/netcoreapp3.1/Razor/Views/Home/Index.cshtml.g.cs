#pragma checksum "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f191bbe98a35494d4c18565d65c579306157b432"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\_ViewImports.cshtml"
using Crudelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\_ViewImports.cshtml"
using Crudelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f191bbe98a35494d4c18565d65c579306157b432", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c0db40c4c91a29aacfb134c187d6cf7f912d39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n\r\n    <div class =\"Welcome\">\r\n        <h1>Welcome to CRUDelicious</h1>\r\n            <a href=\"/CreateDish\">Add a Dish</a>\r\n        <h3>Check out some recent dishes!</h3>\r\n        <ul>\r\n");
#nullable restore
#line 13 "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\Home\Index.cshtml"
             foreach(Dish d in ViewBag.AllDishes)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li><a");
            BeginWriteAttribute("href", " href=\"", 359, "\"", 383, 2);
            WriteAttributeValue("", 366, "oneDish/", 366, 8, true);
#nullable restore
#line 15 "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 374, d.DishID, 374, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\Home\Index.cshtml"
                                           Write(d.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a> by ");
#nullable restore
#line 15 "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\Home\Index.cshtml"
                                                          Write(d.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 16 "C:\Users\marth\Documents\coding\csharpDojo\Crudelicious\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
