#pragma checksum "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8edf72b93101af7bbf0f6fa94b8600cc4fa989ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SiteConsumoAPINasa.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SiteConsumoAPINasa.Pages
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
#line 1 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\_ViewImports.cshtml"
using SiteConsumoAPINasa;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8edf72b93101af7bbf0f6fa94b8600cc4fa989ab", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79ab58cc4f5472de0cfc02411480e663827ac934", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
  
    var dataConsulta = $"{Model.DataConsulta:dd/MM/yyyy}";
    ViewData["Title"] = $"Imagem de {dataConsulta}";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2 style=\"text-align:center;\">\n    ");
#nullable restore
#line 9 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
Write(Model.Saudacao);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    Resultado do acesso à API REST da NASA -\n    Imagem do dia ");
#nullable restore
#line 11 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
             Write(dataConsulta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</h2>\n\n<h3 style=\"text-align:center;\">");
#nullable restore
#line 14 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
                          Write(Model.ImagemDiariaNASA.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n\n<div style=\"text-align: center;\">\n");
#nullable restore
#line 17 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
     if (Model.ImagemDiariaNASA.Media_type == "image")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <img");
            BeginWriteAttribute("src", " src=\"", 452, "\"", 485, 1);
#nullable restore
#line 19 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
WriteAttributeValue("", 458, Model.ImagemDiariaNASA.Url, 458, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height: 60%; width: 60%\" />\n");
#nullable restore
#line 20 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <iframe id=\"apod_vid_id\" type=\"text/html\"");
            BeginWriteAttribute("src", " src=\"", 592, "\"", 625, 1);
#nullable restore
#line 23 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
WriteAttributeValue("", 598, Model.ImagemDiariaNASA.Url, 598, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\n                width=\"640\" height=\"385\" frameborder=\"0\"></iframe>\n");
#nullable restore
#line 25 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n\n<p style=\"margin-top: 15px; margin-left: 20%; width: 60%;\">\n    ");
#nullable restore
#line 29 "D:\Users\Raphael\Downloads\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\ASPNETCore5-Razor-Redis-Refit_ImagensNASA-main\SiteConsumoAPINasa\Pages\Index.cshtml"
Write(Model.ImagemDiariaNASA.Explanation);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591