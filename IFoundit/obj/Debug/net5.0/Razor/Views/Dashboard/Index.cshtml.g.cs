#pragma checksum "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a090a77314f81405e00a2b579e78e953795dfe2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\_ViewImports.cshtml"
using IFoundit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\_ViewImports.cshtml"
using IFoundit.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a090a77314f81405e00a2b579e78e953795dfe2b", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3542652ca8feeeafb12912a8a488759dccf6fb63", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    th {\r\n        color: #fff;\r\n    }\r\n</style>\r\n<div class=\"container\">\r\n");
#nullable restore
#line 7 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
     if (ViewBag.misreportes ==0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-12\">\r\n        <div class=\"col-md-12 text-right\">\r\n            <h5 style=\"color:#656363\">Hola, ");
#nullable restore
#line 11 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
                                       Write(ViewBag.Usuario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <br /></h5>
        </div>
        <div class=""col-md-12 text-center"">
            <br />
            <br /><br />
            <h2 style=""color:#808080""> Usted no tiene ning??n reporte</h2>
            <br />
            <br />

            <br />
            <br />
          
        </div>
        <div class=""col-md-12 text-center"">
            <a class=""btn btn-warning"" href=""/reporte/create"">??Encontr?? algo!</a>
            <a class=""btn btn-warning"" href=""/reporte/create"">!Estoy buscando algo!</a>
        </div>
    </div>
");
#nullable restore
#line 29 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
     if(ViewBag.misreportes>0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <div class=\"col-lg-12 text-right\">\r\n            Hola, ");
#nullable restore
#line 34 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
             Write(ViewBag.Usuario.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </div>\r\n        <h3 class=\"pb-3 mb-4 font-italic border-bottom\">\r\n             Mis reportes\r\n        </h3>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 40 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-md-6\">\r\n                    <div class=\"card flex-md-row mb-4 shadow-sm h-md-250\">\r\n                        <div class=\"card-body d-flex flex-column align-items-start\">\r\n");
            WriteLiteral("                            <h6 class=\"mb-0\">\r\n                                <a class=\"text-dark\" href=\"#\">");
#nullable restore
#line 47 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
                                                         Write(item.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            </h6>\r\n                            <div class=\"mb-1 text-muted small\">");
#nullable restore
#line 49 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
                                                          Write(item.FechaPublicacion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <p class=\"card-text mb-auto\">");
#nullable restore
#line 50 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
                                                    Write(item.Descripcion.Substring(0, 85));

#line default
#line hidden
#nullable disable
            WriteLiteral("...</p>\r\n");
#nullable restore
#line 51 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
                             if (item.Estado == "Perdido")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-outline-warning btn-sm\" role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 2008, "\"", 2042, 2);
            WriteAttributeValue("", 2015, "/Reporte/Change?id=", 2015, 19, true);
#nullable restore
#line 53 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2034, item.Id, 2034, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Perdido</a>\r\n");
#nullable restore
#line 54 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
                             if (item.Estado == "Encontrado")
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a class=\"btn btn-outline-warning btn-sm\" role=\"button\"");
            BeginWriteAttribute("href", " href=\"", 2269, "\"", 2303, 2);
            WriteAttributeValue("", 2276, "/reporte/Change?id=", 2276, 19, true);
#nullable restore
#line 57 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2295, item.Id, 2295, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Encontrado</a>\r\n");
#nullable restore
#line 58 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <img class=\"card-img-right flex-auto d-none d-lg-block\" alt=\"Thumbnail [200x250]\"");
            BeginWriteAttribute("src", " src=\"", 2489, "\"", 2516, 2);
            WriteAttributeValue("", 2495, "/PostImg/", 2495, 9, true);
#nullable restore
#line 60 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
WriteAttributeValue("", 2504, item.Imagen, 2504, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width: 200px;object-fit:cover\">\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 63 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 65 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Dashboard\Index.cshtml"

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
