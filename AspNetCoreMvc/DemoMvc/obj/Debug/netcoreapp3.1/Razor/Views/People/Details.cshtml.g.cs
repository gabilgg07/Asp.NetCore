#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/People/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd2943159c2e4a2150a229326694d1f0c9b4330d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Details), @"mvc.1.0.view", @"/Views/People/Details.cshtml")]
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
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/_ViewImports.cshtml"
using DemoMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd2943159c2e4a2150a229326694d1f0c9b4330d", @"/Views/People/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa1668eeecaa0e900621a09cdedcade0428bc23", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_People_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Person>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n");
#nullable restore
#line 4 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/People/Details.cshtml"
  
    ViewBag.Title = "People Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container mt-5\">\n    <div class=\"d-flex justify-content-between mb-3\">\n        <h1 class=\"text-info m-0\">");
#nullable restore
#line 10 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/People/Details.cshtml"
                             Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n");
            WriteLiteral("    </div>\n\n    <div class=\"w-50\">\n        <h2>");
#nullable restore
#line 15 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/People/Details.cshtml"
       Write(Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n        <p>Profession: <strong>");
#nullable restore
#line 16 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/People/Details.cshtml"
                          Write(Model.Profession?.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></p>\n    </div>\n</div>\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Person> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
