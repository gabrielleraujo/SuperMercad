#pragma checksum "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\SystemError.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae254d7454d96a26ed6ca7412cde0c76ba55a8d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Erro_SystemError), @"mvc.1.0.view", @"/Views/Erro/SystemError.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae254d7454d96a26ed6ca7412cde0c76ba55a8d4", @"/Views/Erro/SystemError.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76cba9fcd18fb7f9b573dc30795c28f703f8a2b2", @"/Views/_ViewImports.cshtml")]
    public class Views_Erro_SystemError : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Exception>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\SystemError.cshtml"
  
    ViewData["Title"] = "System Error";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<div class=\"text-center\">\n    <div>\n        <h3>ERRO 501</h3>\n        <h5>");
#nullable restore
#line 10 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\SystemError.cshtml"
       Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n        <h5>Ops, no momento estamos com problemas no nosso sistema. :c</h5>\n\n");
#nullable restore
#line 13 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\SystemError.cshtml"
         if (@Model.InnerException != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h6>Inner exception: </h6>\n            <p>");
#nullable restore
#line 16 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\SystemError.cshtml"
          Write(Model.InnerException.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 17 "C:\SistemasPessoais\EmAndamento\SupermercadoComFuncionalidadeEstendida\Supermercado\Supermercado\Views\Erro\SystemError.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Exception> Html { get; private set; }
    }
}
#pragma warning restore 1591
