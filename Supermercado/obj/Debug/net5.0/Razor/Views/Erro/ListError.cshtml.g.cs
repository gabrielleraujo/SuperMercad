#pragma checksum "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\ListError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c08fa94c4705f661e0c8b55b1bcaedfa86e71ed6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Erro_ListError), @"mvc.1.0.view", @"/Views/Erro/ListError.cshtml")]
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
#line 1 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\_ViewImports.cshtml"
using Supermercado;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\_ViewImports.cshtml"
using Supermercado.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\_ViewImports.cshtml"
using Supermercado.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\_ViewImports.cshtml"
using Supermercado.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\_ViewImports.cshtml"
using Supermercado.Models.ViewModels.ErrorViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c08fa94c4705f661e0c8b55b1bcaedfa86e71ed6", @"/Views/Erro/ListError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76cba9fcd18fb7f9b573dc30795c28f703f8a2b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Erro_ListError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ListErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\ListError.cshtml"
  
    ViewData["Title"] = "List Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-center\">\n    <div>\n        <h3>ERRO 401</h3>\n");
#nullable restore
#line 10 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\ListError.cshtml"
         foreach (var erro in @Model.Erros)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6>");
#nullable restore
#line 12 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\ListError.cshtml"
           Write(erro);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n");
#nullable restore
#line 13 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\ListError.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ListErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
