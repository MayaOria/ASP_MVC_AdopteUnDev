#pragma checksum "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_itLangsList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f4e217909ae4e327d70ec75ad4434ff1a9970dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__itLangsList), @"mvc.1.0.view", @"/Views/Shared/_itLangsList.cshtml")]
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
#nullable restore
#line 1 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_itLangsList.cshtml"
using Projet_ASP.Models.ItLangViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_itLangsList.cshtml"
using Projet_BLL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f4e217909ae4e327d70ec75ad4434ff1a9970dd", @"/Views/Shared/_itLangsList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162e6691378abe576dff2bf120fadc8dc246de6d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__itLangsList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ItLangListItem>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n    <h2>IT LANG</h2>\r\n\t\t\t\t\t\t\t<div class=\"brands-name\">\r\n\t\t\t\t\t\t\t\t<ul class=\"nav nav-pills nav-stacked\">\r\n\r\n");
#nullable restore
#line 10 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_itLangsList.cshtml"
                                     foreach (ItLangListItem itLang in Model)
									{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t    <li><a href=\"#\">\r\n\t\t\t\t\t\t\t\t\t        ");
#nullable restore
#line 13 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_itLangsList.cshtml"
                                       Write(itLang.ItLabel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n\t\t\t\t\t\t\t\t\t    </li>\r\n");
#nullable restore
#line 15 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_itLangsList.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t\t</div>\r\n    \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ItLangListItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
