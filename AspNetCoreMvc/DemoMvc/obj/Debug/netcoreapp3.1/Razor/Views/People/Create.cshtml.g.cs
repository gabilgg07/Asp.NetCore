#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/People/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f9e5d7f091215f8460aeb224ca66ff9044ce6fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_People_Create), @"mvc.1.0.view", @"/Views/People/Create.cshtml")]
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
#line 5 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/_ViewImports.cshtml"
using DemoMvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f9e5d7f091215f8460aeb224ca66ff9044ce6fe", @"/Views/People/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9887b4088c3087b1385ee89b02161e1d1b83837", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_People_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/People/Create.cshtml"
  
    ViewBag.Title = "People Create";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div class=\"container mt-5\">\n\n    <h1 class=\"text-info m-0 mb-4\">");
#nullable restore
#line 9 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/Asp.Net/Asp.NetCore/AspNetCoreMvc/DemoMvc/Views/People/Create.cshtml"
                              Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    <form method=""post"" class=""w-50"">
        <fieldset>
            <legend>Create New Person</legend>

            <div class=""mb-3"">
                <label for=""name"" class=""form-label"">Name</label>
                <input type=""text"" class=""form-control"" id=""name"" name=""name"">
            </div>
            <div class=""mb-3"">
                <label for=""surname"" class=""form-label"">Surname</label>
                <input type=""text"" class=""form-control"" id=""surname"" name=""surname"">
            </div>
            <button type=""submit"" class=""btn btn-primary"">Create</button>
        </fieldset>
    </form>
</div>
");
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
