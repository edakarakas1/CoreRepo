#pragma checksum "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "541c025d26c61ba40d1ca89b0a5350412ee87ade"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Egitmen_Detay), @"mvc.1.0.view", @"/Views/Egitmen/Detay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"541c025d26c61ba40d1ca89b0a5350412ee87ade", @"/Views/Egitmen/Detay.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"326c840b8e821aa3067733c3ebf15da7dbc38f34", @"/Views/_ViewImports.cshtml")]
    public class Views_Egitmen_Detay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreRepo.Models.Entity.COURSEMODEL>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
  
    ViewData["Title"] = "Detay";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detay</h1>\r\n\r\n<div>\r\n    <h4>Egitmen</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.egitmen.İsim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
       Write(Html.DisplayFor(model => model.egitmen.İsim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.egitmen.Soyisim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
       Write(Html.DisplayFor(model => model.egitmen.Soyisim));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.egitmen.Adres.Sehir));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
       Write(Html.DisplayFor(model => model.egitmen.Adres.Sehir));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
       Write(Html.DisplayNameFor(model => model.egitmen.Adres.Ülke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
       Write(Html.DisplayFor(model => model.egitmen.Adres.Ülke));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 40 "C:\Users\SC-303 1\Desktop\CoreRepo\CoreRepo\Views\Egitmen\Detay.cshtml"
Write(Html.ActionLink("Güncelle", "Guncelle", new { id = Model.egitmen.Id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "541c025d26c61ba40d1ca89b0a5350412ee87ade6579", async() => {
                WriteLiteral("Listeye Geri Dön");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreRepo.Models.Entity.COURSEMODEL> Html { get; private set; }
    }
}
#pragma warning restore 1591