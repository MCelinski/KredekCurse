#pragma checksum "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a71c56cae0f060d9bf866b83b878dd2d1560bb6b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetRandomMovie), @"mvc.1.0.view", @"/Views/Home/GetRandomMovie.cshtml")]
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
#line 1 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\_ViewImports.cshtml"
using ZadanieDomowe4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\_ViewImports.cshtml"
using ZadanieDomowe4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a71c56cae0f060d9bf866b83b878dd2d1560bb6b", @"/Views/Home/GetRandomMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a1e58935a8a10ffb8d04a1b62e32a5ec1f10e1a", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetRandomMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MovieViewModell>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml"
 foreach (var Movie in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        <h2>");
#nullable restore
#line 7 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml"
       Write(Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n        <h4>Reżyser: ");
#nullable restore
#line 8 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml"
                Write(Movie.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>Rok Wydania: ");
#nullable restore
#line 9 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml"
                    Write(Movie.YearOfPublish);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <h4>Ocena: ");
#nullable restore
#line 10 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml"
              Write(Movie.Rate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 254, "\"", 285, 1);
#nullable restore
#line 11 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml"
WriteAttributeValue("", 260, Url.Content(Movie.Photo), 260, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 286, "\"", 304, 1);
#nullable restore
#line 11 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml"
WriteAttributeValue("", 292, Movie.Title, 292, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n        <hr />\r\n    </div>\r\n");
#nullable restore
#line 14 "C:\Users\michu\source\repos\ZadanieDomowe4\ZadanieDomowe4\Views\Home\GetRandomMovie.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MovieViewModell>> Html { get; private set; }
    }
}
#pragma warning restore 1591