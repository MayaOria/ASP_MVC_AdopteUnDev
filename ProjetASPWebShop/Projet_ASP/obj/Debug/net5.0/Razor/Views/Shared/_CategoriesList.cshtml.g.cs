#pragma checksum "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_CategoriesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b528591d970964882d17e2eff9c0fdf6e382115"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__CategoriesList), @"mvc.1.0.view", @"/Views/Shared/_CategoriesList.cshtml")]
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
#line 1 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_CategoriesList.cshtml"
using Projet_ASP.Models.CategoriesViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_CategoriesList.cshtml"
using Projet_BLL.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b528591d970964882d17e2eff9c0fdf6e382115", @"/Views/Shared/_CategoriesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"162e6691378abe576dff2bf120fadc8dc246de6d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__CategoriesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CategoriesListItem>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Category</h2>\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_CategoriesList.cshtml"
  foreach (CategoriesListItem categorie in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""panel panel-default"">
							<div class=""panel-heading"">
									<h4 class=""panel-title"">
										<a data-toggle=""collapse"" data-parent=""#accordian"" href=""#sportswear"">
											<span class=""badge pull-right""><i class=""fa fa-plus""></i></span>
											");
#nullable restore
#line 16 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_CategoriesList.cshtml"
                                       Write(categorie.CategLabel);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</h4>\r\n\t\t\t\t\t\t\t\t</div>\r\n            \r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 22 "C:\xampp\htdocs\REPOS\ASP_MVC_AdopteUnDev\ProjetASPWebShop\Projet_ASP\Views\Shared\_CategoriesList.cshtml"
        
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CategoriesListItem>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
