#pragma checksum "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Gateaway-To-The-World\Sistema Aduanero\Sistema Aduanero\Views\Facturacion\Facturar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16dfb411cd1f464e350ae18edcf5ca183f6fcd8c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Facturacion_Facturar), @"mvc.1.0.view", @"/Views/Facturacion/Facturar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Facturacion/Facturar.cshtml", typeof(AspNetCore.Views_Facturacion_Facturar))]
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
#line 1 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Gateaway-To-The-World\Sistema Aduanero\Sistema Aduanero\Views\_ViewImports.cshtml"
using Sistema_Aduanero;

#line default
#line hidden
#line 2 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Gateaway-To-The-World\Sistema Aduanero\Sistema Aduanero\Views\_ViewImports.cshtml"
using Sistema_Aduanero.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16dfb411cd1f464e350ae18edcf5ca183f6fcd8c", @"/Views/Facturacion/Facturar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29b5d6a8dadd03ff3cff59ce6c77a562d860a2de", @"/Views/_ViewImports.cshtml")]
    public class Views_Facturacion_Facturar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-md-6 col-md-offset-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\gp\Documents\ITLA\Administracion de  Proyectos de Software\Proyecto\Gateaway-To-The-World\Sistema Aduanero\Sistema Aduanero\Views\Facturacion\Facturar.cshtml"
  
    ViewData["Title"] = "Facturar";

#line default
#line hidden
            BeginContext(46, 182, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-md-5 col-md-offset-4\">\r\n        <h1>Facturar Solicitud.</h1>\r\n    </div>\r\n</div>\r\n<!-- Formulario nuevo envio. -->\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(228, 1516, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de204d1000394ce8b62104c5eb9021de", async() => {
                BeginContext(287, 1450, true);
                WriteLiteral(@"
        <div class=""col-md-6 columna_para_radio_buttons"">
            <div class=""col-group radio_button_importar"">
                <input type=""radio"" name=""pago_de_servicios"" id=""tarjeta_de_credito"">
                <label for=""servicios"">
                    <span class=""glyphicon glyphicon-credit-card""></span> Tarjeta
                </label>
            </div>
            <div class=""col-group Transferencia"">
                <input type=""radio"" name=""pago_de_servicios"" id=""cuenta_bancaria"">
                <label for=""servicios"">
                    <span class=""glyphicon glyphicon-piggy-bank""></span> Transferencia
                </label>
            </div>
        </div>

        <div class=""col-md-12"">
            <label for=""no_solicitud"">No. Solicitud:</label>
            <input type=""text"" name=""no_solicitud"" id="""" class=""form-control"" placeholder=""0000"">
        </div>

        <div class=""col-md-12"">
            <label for=""balance"">Balance:</label>
            <input type");
                WriteLiteral(@"=""number"" name=""balance"" id="""" class=""form-control"" placeholder=""000"">
        </div>


        <!-- Botón Facturar solicitud. -->
        <div class=""col-md-12"">
            <button type=""submit"" class=""btn btn-info btn-block btn_guardar_solicitud"">
                Pagar solicitud. <span class=""glyphicon glyphicon-send""></span>
            </button>
        </div>
        <!-- Botón Facturar solicitud. -->
    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1744, 8, true);
            WriteLiteral("\r\n</div>");
            EndContext();
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
