#pragma checksum "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49acdfff7c6a2d3fb79e064ce4c43a3bf909050"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reporte_Create), @"mvc.1.0.view", @"/Views/Reporte/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49acdfff7c6a2d3fb79e064ce4c43a3bf909050", @"/Views/Reporte/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3542652ca8feeeafb12912a8a488759dccf6fb63", @"/Views/_ViewImports.cshtml")]
    public class Views_Reporte_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/gridReportes.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Perdido", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Encontrado", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/reporte/create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a49acdfff7c6a2d3fb79e064ce4c43a3bf9090506294", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br/>
<div class=""container shadow-lg"" style="" -webkit-box-shadow: 5px 30px 30px 5px rgb(128 128 128);border-radius:8px"">
   <div class=""row"">
       <div class=""col-md-12 text-center"">
           <h4 style=""color:#808080"">¿Qué ha encontrado o perdido?</h4>
       </div>
   </div>
    <div class=""container"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49acdfff7c6a2d3fb79e064ce4c43a3bf9090507745", async() => {
                WriteLiteral("\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6\">\r\n                    <div>\r\n                        <span>Nombre</span>\r\n                        <input class=\"form-control\" type=\"text\" name=\"Nombre\"");
                BeginWriteAttribute("value", " value=\"", 724, "\"", 745, 1);
#nullable restore
#line 19 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
WriteAttributeValue("", 732, Model.Nombre, 732, 13, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Mochila Verde\" />\r\n                        <p style=\"font-size:11px;color:#808080\">");
#nullable restore
#line 20 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                           Write(Html.ValidationMessage("Nombre"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    </div>\r\n                    <div>\r\n                        <span>Categoría</span>\r\n                        <select class=\"form-control\" name=\"Categoria\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49acdfff7c6a2d3fb79e064ce4c43a3bf9090509226", async() => {
                    WriteLiteral("--Seleccione--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 26 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                             foreach (var item in ViewBag.categorias)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49acdfff7c6a2d3fb79e064ce4c43a3bf90905010781", async() => {
#nullable restore
#line 28 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                        Write(item.Nombre);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                   WriteLiteral(item.Nombre);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 29 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </select>
                    </div>
                    <div>
                        <span>Descripción</span>
                        <textarea name=""Descripcion"" class=""form-control""></textarea>
                        <p style=""font-size:11px;color:#808080"">");
#nullable restore
#line 35 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                           Write(Html.ValidationMessage("Descripcion"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                        <p style=\"font-size:11px;color:#808080\">");
#nullable restore
#line 36 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                           Write(Html.ValidationMessage("DescripcionCaracteres"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div>
                        <div>
                            <span>Recompensa</span>
                            <input class=""form-control"" type=""text"" name=""Recompensa""");
                BeginWriteAttribute("value", " value=\"", 2085, "\"", 2110, 1);
#nullable restore
#line 43 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
WriteAttributeValue("", 2093, Model.Recompensa, 2093, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <p style=\"font-size:11px;color:#808080\">");
#nullable restore
#line 44 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                               Write(Html.ValidationMessage("Recompensa"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>  \r\n                        </div>\r\n                        <div>\r\n                            <span>Estado</span>\r\n                            <select class=\"form-control\" name=\"Estado\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49acdfff7c6a2d3fb79e064ce4c43a3bf90905015148", async() => {
                    WriteLiteral("--Seleccione--");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49acdfff7c6a2d3fb79e064ce4c43a3bf90905016412", async() => {
                    WriteLiteral("Perdido");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a49acdfff7c6a2d3fb79e064ce4c43a3bf90905017669", async() => {
                    WriteLiteral("Encontrado");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                <p style=\"font-size:11px;color:#808080\">");
#nullable restore
#line 52 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                                   Write(Html.ValidationMessage("Estado"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                            </select>
                        </div>
                        <span>Imagen</span>
                        <input class=""form-control-file"" type=""file"" name=""photos"" />
                       <p style=""font-size:11px;color:#808080"">");
#nullable restore
#line 57 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                          Write(Html.ValidationMessage("ImageNull"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                    </div>
                </div>

                <div class=""col-md-6"">

                    <div class=""text-center"">
                        <h6 style=""color:#808080 ""></h6>
                        <div style=""display:inline; color:#808080"">
                            ");
#nullable restore
#line 66 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                       Write(ViewBag.tieneWhatsapp);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 67 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                             if (ViewBag.tieneWhatsapp == 1)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input style=\"display:inline\" type=\"checkbox\"  value=\"1\" name=\"miWhatsapp\">\r\n                                <p style=\"display:inline\">Usar el número de whatsapp de mi perfil para que los interesados me contacten </p>\r\n");
#nullable restore
#line 71 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                <br />
                                <input style=""display:inline"" type=""checkbox""  name=""miCorreo"">
                                <p style=""display:inline"">Usar el correo de mi perfil para que los interesados se contacten a ese correo</p>
");
#nullable restore
#line 78 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p style=\"font-size:11px;color:#808080\">");
#nullable restore
#line 79 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                               Write(Html.ValidationMessage("erroreligaUno"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                        </div>
                    </div>
                </div>
                <div class=""col-md-6"">
                    <fieldset>
                        <input style=""display:inline"" type=""checkbox"" name=""otroNumero"">
                        <p style=""display:inline"">Contacteme a otro número</p>

                        <input name=""nuevoCelular"" />
                        <p style=""font-size:11px;color:#808080"">");
#nullable restore
#line 89 "C:\Users\ndiaz\source\repos\IFoundit\IFoundit\Views\Reporte\Create.cshtml"
                                                           Write(Html.ValidationMessage("errorNumNoAdmin"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p> 
                    </fieldset>
                </div>
                <hr />
                <div class=""col-md-12"">
                    <div class=""text-center"">
                        <button class=""button"">Crear</button>
                    </div>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""text-center"">
                    <a style=""color:#808080"" href=""/reporte/"">Volver</a>
                </div>
            </div>
        </div>
    </div>
</div>

");
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
