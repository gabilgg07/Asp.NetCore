#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4296dc8b2c4e194ac256f2d4a126673d7535da40"
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
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/_ViewImports.cshtml"
using DemoMvc.Models.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4296dc8b2c4e194ac256f2d4a126673d7535da40", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f648d996098db281861c4d0178dc35521b3113e6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1 style=\"margin: 20px 10px; color: darkkhaki; font-size: 32px; \">\n    ");
#nullable restore
#line 6 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
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
                <a href=""About"">About</a>
            </li>
            <li>
                <a href=""SendPerson"">Send Person</a>
            </li>
            <li>
                <a href=""SendPersons"">Send Persons</a>
            </li>
        </ul>
        <ul style=""margin: 20px 10px;"">
            <li style=""color:darkgoldenrod; font-size:28px; margin-bottom: 10px;"">ViewBag</li>
            <li>
                group: >> ");
#nullable restore
#line 26 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                     Write(ViewBag.group);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                userName: >> ");
#nullable restore
#line 29 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                        Write(ViewBag.userName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                NumberA: >> ");
#nullable restore
#line 32 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                       Write(ViewBag.numA);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                NumberB: >> ");
#nullable restore
#line 35 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                       Write(ViewBag.numB);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                NumberA + NumberB: >> ");
#nullable restore
#line 38 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                                  Write(ViewBag.numA + ViewBag.numB);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                Keys sensetive deyil: <br />\n                Numbera + Numberb: >> ");
#nullable restore
#line 42 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                                  Write(ViewBag.numa + ViewBag.numb);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                Olmayan bir ViewBag Key-inde error qaytarmir: <br />\n                Number(teyin edilmiyib): >> ");
#nullable restore
#line 46 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                                       Write(ViewBag.num);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                NaN qayidir ve NaN uzerine eded gelsek de NaN qayidir.<br />\n                Number(yoxdu) + Numberb: >> ");
#nullable restore
#line 50 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                                        Write(ViewBag.num + ViewBag.numb);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n        </ul>\n\n        <ul style=\"margin: 20px 10px;\">\n            <li style=\"color: teal; font-size: 28px; margin-bottom: 10px;\">ViewData</li>\n            <li>\n                value1: >> ");
#nullable restore
#line 57 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                      Write(ViewData["value1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                value2: >> ");
#nullable restore
#line 60 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                      Write(ViewData["value2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                valueA: >> ");
#nullable restore
#line 63 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                      Write(ViewData["valueA"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                Keys sensetive deyil: <br />\n                valueb: >> ");
#nullable restore
#line 67 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                      Write(ViewData["valueb"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                valueA + valueB: >> ");
#nullable restore
#line 70 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                                Write(Convert.ToInt32(ViewData["valueA"]) + Convert.ToInt32(ViewData["valueb"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n            <li>\n                ViewData ile yazdigimizi ViewBagle oxuya bilirik, ve ya eksine: <br />\n                valueA -> ViewBag.valueA: >> ");
#nullable restore
#line 74 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/Home/Index.cshtml"
                                        Write(ViewBag.valueA);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <<\n            </li>\n        </ul>\n    </div>\n</div>\n\n\n");
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
