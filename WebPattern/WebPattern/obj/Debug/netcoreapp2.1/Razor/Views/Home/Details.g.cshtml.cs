#pragma checksum "C:\project\WebPattern\WebPattern\WebPattern\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aae34ddc9ef0b73aa95330388ca6e687ca54bd69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Details.cshtml", typeof(AspNetCore.Views_Home_Details))]
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
#line 1 "C:\project\WebPattern\WebPattern\WebPattern\Views\_ViewImports.cshtml"
using WebPattern.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aae34ddc9ef0b73aa95330388ca6e687ca54bd69", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"635980d910aea77719e3fb91ad767024ac8856c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EmployeeView>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\project\WebPattern\WebPattern\WebPattern\Views\Home\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(62, 33, true);
            WriteLiteral("\r\n<table>\r\n    <tr>\r\n        <td>");
            EndContext();
            BeginContext(96, 8, false);
#line 9 "C:\project\WebPattern\WebPattern\WebPattern\Views\Home\Details.cshtml"
       Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(104, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(124, 15, false);
#line 10 "C:\project\WebPattern\WebPattern\WebPattern\Views\Home\Details.cshtml"
       Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(139, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(159, 9, false);
#line 11 "C:\project\WebPattern\WebPattern\WebPattern\Views\Home\Details.cshtml"
       Write(Model.Age);

#line default
#line hidden
            EndContext();
            BeginContext(168, 32, true);
            WriteLiteral("</td>\r\n    </tr>    \r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EmployeeView> Html { get; private set; }
    }
}
#pragma warning restore 1591
