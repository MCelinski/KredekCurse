#pragma checksum "C:\Users\michu\Documents\GitHub\michal_celinski_cpc2021-1\MichalCelinskiLab5\MichalCelinskiZadanieDomoweLab5\MichalCelinskiZadanieDomoweLab5\Views\Categories\CategoriesList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bd46b654b92de9c823470917a92b42b15ede8c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categories_CategoriesList), @"mvc.1.0.view", @"/Views/Categories/CategoriesList.cshtml")]
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
#line 1 "C:\Users\michu\Documents\GitHub\michal_celinski_cpc2021-1\MichalCelinskiLab5\MichalCelinskiZadanieDomoweLab5\MichalCelinskiZadanieDomoweLab5\Views\_ViewImports.cshtml"
using MichalCelinskiZadanieDomoweLab5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\michu\Documents\GitHub\michal_celinski_cpc2021-1\MichalCelinskiLab5\MichalCelinskiZadanieDomoweLab5\MichalCelinskiZadanieDomoweLab5\Views\_ViewImports.cshtml"
using MichalCelinskiZadanieDomoweLab5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd46b654b92de9c823470917a92b42b15ede8c3", @"/Views/Categories/CategoriesList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"374e64ae1db56579d50ebe062c25a8c85f7069a0", @"/Views/_ViewImports.cshtml")]
    public class Views_Categories_CategoriesList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MichalCelinskiZadanieDomoweLab5.Models.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\michu\Documents\GitHub\michal_celinski_cpc2021-1\MichalCelinskiLab5\MichalCelinskiZadanieDomoweLab5\MichalCelinskiZadanieDomoweLab5\Views\Categories\CategoriesList.cshtml"
  
    ViewData["Title"] = "CategoriesList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CategoriesList</h1>\r\n\r\n<p>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\michu\Documents\GitHub\michal_celinski_cpc2021-1\MichalCelinskiLab5\MichalCelinskiZadanieDomoweLab5\MichalCelinskiZadanieDomoweLab5\Views\Categories\CategoriesList.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\michu\Documents\GitHub\michal_celinski_cpc2021-1\MichalCelinskiLab5\MichalCelinskiZadanieDomoweLab5\MichalCelinskiZadanieDomoweLab5\Views\Categories\CategoriesList.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 25 "C:\Users\michu\Documents\GitHub\michal_celinski_cpc2021-1\MichalCelinskiLab5\MichalCelinskiZadanieDomoweLab5\MichalCelinskiZadanieDomoweLab5\Views\Categories\CategoriesList.cshtml"
           Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\michu\Documents\GitHub\michal_celinski_cpc2021-1\MichalCelinskiLab5\MichalCelinskiZadanieDomoweLab5\MichalCelinskiZadanieDomoweLab5\Views\Categories\CategoriesList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MichalCelinskiZadanieDomoweLab5.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591