#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/SendPersons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddca4d2f4e7f70b5f0686465e156e6819f63425f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SendPersons), @"mvc.1.0.view", @"/Views/Home/SendPersons.cshtml")]
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
using DemoMvc.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddca4d2f4e7f70b5f0686465e156e6819f63425f", @"/Views/Home/SendPersons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f648d996098db281861c4d0178dc35521b3113e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SendPersons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Person>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/SendPersons.cshtml"
  
    ViewBag.Title = "Send Person";
    Person per = ViewBag.Person as Person;

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 style=\"margin: 20px 10px; color: darkkhaki; font-size: 32px; \">\n    ");
#nullable restore
#line 10 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/SendPersons.cshtml"
Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
</h1>

<div class=""container"">
    <div class=""wrapper"">
        <ul style=""margin: 20px 10px;"">
            <li style=""color:darkolivegreen; font-size:28px; margin-bottom: 10px;"">Links</li>
            <li>
                <a href=""index"">Index</a>
            </li>
            <li>
                <a href=""About"">About</a>
            </li>
            <li>
                <a href=""SendPerson"">Send Person</a>
            </li>
        </ul>
        <ul style=""margin: 20px 10px;"">
            <li style=""color:darkgoldenrod; font-size:28px; margin-bottom: 10px;"">Persons</li>

");
#nullable restore
#line 30 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/SendPersons.cshtml"
             foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li>\n                        ");
#nullable restore
#line 33 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/SendPersons.cshtml"
                   Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                    </li>\n");
#nullable restore
#line 35 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/SendPersons.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\n    </div>\n</div>\n\n\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Person>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
