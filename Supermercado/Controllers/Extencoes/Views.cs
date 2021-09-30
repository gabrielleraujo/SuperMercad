using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Supermercado.Controllers.Extencoes
{
    /// <summary>
    /// 
    /// Funcionalidade Estendida
    ///
    /// </summary>
    public static class Views
    {
        public static string BuscarSubPasta(this ControllerContext context, string nomeSubPastaDaView)
        {
            string actionName = context.RouteData.Values["action"].ToString();
            string controllerName = context.RouteData.Values["controller"].ToString();

            return $"/Views/{controllerName}/{nomeSubPastaDaView}/{actionName}.cshtml";
        }
    }
}
