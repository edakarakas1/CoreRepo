#pragma checksum "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6b4a8a4a19d4d3d4247da27b3b31a640c83c6e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Liste), @"mvc.1.0.view", @"/Views/Home/Liste.cshtml")]
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
#line 1 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\_ViewImports.cshtml"
using CoreRepo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\_ViewImports.cshtml"
using CoreRepo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6b4a8a4a19d4d3d4247da27b3b31a640c83c6e0", @"/Views/Home/Liste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"326c840b8e821aa3067733c3ebf15da7dbc38f34", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreRepo.Models.Entity.Request>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml"
  
    ViewData["Title"] = "Liste";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Liste</h1>

<div class=""bg-success text-white"">İstek Listesi</div>
<table class=""table table-bordered table table-hover table table-striped"">
    <thead>
        <tr>
            <th>ID</th>
            <th>İsim</th>
            <th>Email</th>
            <th>Telefon</th>
            <th>Mesaj</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 20 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml"
               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml"
               Write(item.Ad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml"
               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml"
               Write(item.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml"
               Write(item.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 29 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Home\Liste.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreRepo.Models.Entity.Request>> Html { get; private set; }
    }
}
#pragma warning restore 1591
