#pragma checksum "C:\Users\Diego\Documents\Projects\GitHub\testaltudo\TesteAltudo\Views\Home\ErrorPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbd6e205bc8987fa04e922f8b14a1f0433a31d8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ErrorPartial), @"mvc.1.0.view", @"/Views/Home/ErrorPartial.cshtml")]
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
#line 1 "C:\Users\Diego\Documents\Projects\GitHub\testaltudo\TesteAltudo\Views\_ViewImports.cshtml"
using TesteAltudo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Diego\Documents\Projects\GitHub\testaltudo\TesteAltudo\Views\_ViewImports.cshtml"
using TesteAltudo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbd6e205bc8987fa04e922f8b14a1f0433a31d8b", @"/Views/Home/ErrorPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36255d7162e047ea97bfe7a395a7a2288f6a5777", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ErrorPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TesteAltudo.Models.PageContentsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">    \r\n    <div class=\"alert alert-danger\" role=\"alert\">\r\n        <p>Something went wrong :(</p>\r\n        <p>");
#nullable restore
#line 6 "C:\Users\Diego\Documents\Projects\GitHub\testaltudo\TesteAltudo\Views\Home\ErrorPartial.cshtml"
      Write(Model.ErrorMsg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TesteAltudo.Models.PageContentsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
