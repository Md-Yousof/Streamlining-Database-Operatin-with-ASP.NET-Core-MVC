#pragma checksum "C:\Users\Yousuf\Desktop\CoreMonEvi_08\FinalEvi_08\Views\Customer\CustomerStats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093fc3b4186b63fce49c50d1ac3e8ff61880514f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerStats), @"mvc.1.0.view", @"/Views/Customer/CustomerStats.cshtml")]
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
#line 1 "C:\Users\Yousuf\Desktop\CoreMonEvi_08\FinalEvi_08\Views\_ViewImports.cshtml"
using FinalEvi_08;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yousuf\Desktop\CoreMonEvi_08\FinalEvi_08\Views\_ViewImports.cshtml"
using FinalEvi_08.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093fc3b4186b63fce49c50d1ac3e8ff61880514f", @"/Views/Customer/CustomerStats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab62cd595b08c039510c59814e3aa9bb25c9617d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customer_CustomerStats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Yousuf\Desktop\CoreMonEvi_08\FinalEvi_08\Views\Customer\CustomerStats.cshtml"
  
    ViewData["Title"] = "CountEmployee";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h4>Total Employees</h4>\r\n<hr />\r\n<h4>");
#nullable restore
#line 6 "C:\Users\Yousuf\Desktop\CoreMonEvi_08\FinalEvi_08\Views\Customer\CustomerStats.cshtml"
Write(ViewBag.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<hr />\r\n<h4>Average Age</h4>\r\n<hr />\r\n<h4>");
#nullable restore
#line 10 "C:\Users\Yousuf\Desktop\CoreMonEvi_08\FinalEvi_08\Views\Customer\CustomerStats.cshtml"
Write(ViewBag.AvgAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<hr />\r\n<h4>Most Junior</h4>\r\n<hr />\r\n<h4>");
#nullable restore
#line 14 "C:\Users\Yousuf\Desktop\CoreMonEvi_08\FinalEvi_08\Views\Customer\CustomerStats.cshtml"
Write(ViewBag.MinAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n<hr />\r\n<h4>Most Senior</h4>\r\n<hr />\r\n<h4>");
#nullable restore
#line 18 "C:\Users\Yousuf\Desktop\CoreMonEvi_08\FinalEvi_08\Views\Customer\CustomerStats.cshtml"
Write(ViewBag.MaxAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
