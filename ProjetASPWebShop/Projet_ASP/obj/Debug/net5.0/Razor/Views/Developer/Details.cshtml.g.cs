#pragma checksum "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1673fc66551177502f2ea03ba0be73685934736"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Developer_Details), @"mvc.1.0.view", @"/Views/Developer/Details.cshtml")]
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
#line 1 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\_ViewImports.cshtml"
using Projet_ASP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\_ViewImports.cshtml"
using Projet_ASP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1673fc66551177502f2ea03ba0be73685934736", @"/Views/Developer/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162e6691378abe576dff2bf120fadc8dc246de6d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Developer_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Projet_ASP.Models.DeveloperViewModel.DeveloperDetails>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_DevLangList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>DeveloperDetails</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevBirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevBirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevPicture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevHourCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevHourCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevDayCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevDayCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevMonthCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevMonthCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevMail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DevCategPrincipal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
       Write(Html.DisplayFor(model => model.DevCategPrincipal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <h2>");
#nullable restore
#line 70 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
   Write(Html.DisplayNameFor(model => model.DevLang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a1673fc66551177502f2ea03ba0be7368593473610872", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 71 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DevLang);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 74 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Developer\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a1673fc66551177502f2ea03ba0be7368593473612857", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Projet_ASP.Models.DeveloperViewModel.DeveloperDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
