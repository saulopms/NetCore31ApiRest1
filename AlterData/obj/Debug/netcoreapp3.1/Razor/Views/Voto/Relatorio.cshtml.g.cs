#pragma checksum "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851c2f2d3d10d10c56ea559f5a9caff99a4937ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Voto_Relatorio), @"mvc.1.0.view", @"/Views/Voto/Relatorio.cshtml")]
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
#line 1 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/_ViewImports.cshtml"
using AlterData;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/_ViewImports.cshtml"
using AlterData.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"851c2f2d3d10d10c56ea559f5a9caff99a4937ff", @"/Views/Voto/Relatorio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"972ccd40d75ffafc78f04683568887d3bae3aff1", @"/Views/_ViewImports.cshtml")]
    public class Views_Voto_Relatorio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AlterData.Models.VwVotoListagem>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
  
    ViewData["Title"] = "Relatório";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Relatório de votos</h1>\r\n\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 14 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.idvoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.dt_voto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.hr_voto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.recurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayNameFor(model => model.comentario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 36 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 39 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.idvoto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 42 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.dt_voto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 45 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.hr_voto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.funcionario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 51 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.recurso));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 54 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
           Write(Html.DisplayFor(modelItem => item.comentario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 59 "/Users/saulomendes/Documents/AlterData/AlterData/AlterData/Views/Voto/Relatorio.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AlterData.Models.VwVotoListagem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
