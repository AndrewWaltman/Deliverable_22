#pragma checksum "C:\Users\Andrew\Desktop\Shtuff\Coding\Grand Circus\Unit 5\Deliverable_22\Deliverable_22\Views\Home\RResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebf46ef08ab76dc26856a0305b086de5acd1560"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_RResult), @"mvc.1.0.view", @"/Views/Home/RResult.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/RResult.cshtml", typeof(AspNetCore.Views_Home_RResult))]
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
#line 1 "C:\Users\Andrew\Desktop\Shtuff\Coding\Grand Circus\Unit 5\Deliverable_22\Deliverable_22\Views\_ViewImports.cshtml"
using Deliverable_22;

#line default
#line hidden
#line 2 "C:\Users\Andrew\Desktop\Shtuff\Coding\Grand Circus\Unit 5\Deliverable_22\Deliverable_22\Views\_ViewImports.cshtml"
using Deliverable_22.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebf46ef08ab76dc26856a0305b086de5acd1560", @"/Views/Home/RResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"005d04d2b6b8ed3db38fd9c3ac9db1d099262005", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_RResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Andrew\Desktop\Shtuff\Coding\Grand Circus\Unit 5\Deliverable_22\Deliverable_22\Views\Home\RResult.cshtml"
  
    ViewData["Title"] = "Completion Page";

#line default
#line hidden
            BeginContext(51, 63, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome ");
            EndContext();
            BeginContext(115, 10, false);
#line 6 "C:\Users\Andrew\Desktop\Shtuff\Coding\Grand Circus\Unit 5\Deliverable_22\Deliverable_22\Views\Home\RResult.cshtml"
                             Write(ViewBag.UN);

#line default
#line hidden
            EndContext();
            BeginContext(125, 152, true);
            WriteLiteral("!</h1>\r\n    <p>You are now a member of the Cool People Club! Great Job!</p>\r\n    <p>There\'s nothing else here, just enjoy your membership.</p>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
