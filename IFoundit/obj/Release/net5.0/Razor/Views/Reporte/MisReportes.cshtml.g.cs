#pragma checksum "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c1758c7023c312c78bebb1d3d9b319e6ac728d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reporte_MisReportes), @"mvc.1.0.view", @"/Views/Reporte/MisReportes.cshtml")]
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
#line 1 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\_ViewImports.cshtml"
using IFoundit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\_ViewImports.cshtml"
using IFoundit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c1758c7023c312c78bebb1d3d9b319e6ac728d4", @"/Views/Reporte/MisReportes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3542652ca8feeeafb12912a8a488759dccf6fb63", @"/Views/_ViewImports.cshtml")]
    public class Views_Reporte_MisReportes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
  
    ViewData["Title"] = "MisReportes";

#line default
#line hidden
#nullable disable
            WriteLiteral("<style>\r\n    th {\r\n        color:#fff;    \r\n    }\r\n</style>\r\n<div class=\"container\">\r\n");
#nullable restore
#line 10 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
     if (Model == null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1>Usted no tiene ningún reporte</h1>\r\n");
#nullable restore
#line 13 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <h3 class=\"pb-3 mb-4 font-italic border-bottom\">\r\n            Mis reportes\r\n        </h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-md-6"">
                    <div class=""card flex-md-row mb-4 shadow-sm h-md-250"">
                        <div class=""card-body d-flex flex-column align-items-start"">
                            <strong class=""d-inline-block mb-2 text-primary"">");
#nullable restore
#line 26 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
                                                                        Write(item.Categoria);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                            <h6 class=\"mb-0\">\r\n                                <a class=\"text-dark\" href=\"#\">");
#nullable restore
#line 28 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
                                                         Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h6>\r\n                            <div class=\"mb-1 text-muted small\">");
#nullable restore
#line 30 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
                                                          Write(item.FechaPublicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <p class=\"card-text mb-auto\">");
#nullable restore
#line 31 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
                                                    Write(item.Descripcion.Substring(0, 85));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n                            <a class=\"btn btn-outline-primary btn-sm\" role=\"button\" href=\"#\">");
#nullable restore
#line 32 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
                                                                                        Write(item.Estado);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                        </div>\r\n                        <img class=\"card-img-right flex-auto d-none d-lg-block\" alt=\"Thumbnail [200x250]\"");
            BeginWriteAttribute("src", " src=\"", 1344, "\"", 1371, 2);
            WriteAttributeValue("", 1350, "/PostImg/", 1350, 9, true);
#nullable restore
#line 34 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
WriteAttributeValue("", 1359, item.Imagen, 1359, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 200px;object-fit:cover\">\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 37 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 39 "C:\Users\Neiser Díaz\source\repos\IFoundit\IFoundit\Views\Reporte\MisReportes.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591