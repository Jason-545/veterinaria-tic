#pragma checksum "C:\Users\Pablo\veterinaria-tic\Trabajo_individual\Alejandro\Veterinaria.App\Veterinaria.App.Presentacion\Pages\LoginCliente\LoginCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2cc4a491916bfae34aa1721cad279724bd616b77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Veterinaria.App.Presentacion.Pages.LoginCliente.Pages_LoginCliente_LoginCliente), @"mvc.1.0.razor-page", @"/Pages/LoginCliente/LoginCliente.cshtml")]
namespace Veterinaria.App.Presentacion.Pages.LoginCliente
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
#line 1 "C:\Users\Pablo\veterinaria-tic\Trabajo_individual\Alejandro\Veterinaria.App\Veterinaria.App.Presentacion\Pages\_ViewImports.cshtml"
using Veterinaria.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2cc4a491916bfae34aa1721cad279724bd616b77", @"/Pages/LoginCliente/LoginCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e0b5ca209e941241f3a7d6f6fefe42ca98442af", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoginCliente_LoginCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("px-4 py-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div style=\"width: fit-content\">\r\n    <h1>Iniciar sesion Dueño Mascota</h1>\r\n\r\n    <div class=\"menu-cliente\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2cc4a491916bfae34aa1721cad279724bd616b773771", async() => {
                WriteLiteral(@"
            <div class=""form-group"">
                <label for=""exampleDropdownFormEmail1"">Correo Electronico</label>
                <input type=""email"" class=""form-control"" id=""exampleDropdownFormEmail1"" placeholder=""email@example.com"">
            </div>
            <div class=""form-group"">
                <label for=""exampleDropdownFormPassword1"">Contraseña</label>
                <input type=""password"" class=""form-control"" id=""exampleDropdownFormPassword1"" placeholder=""Password"">
            </div>
            <div class=""form-group"">
                <div class=""form-check"">
                    <input type=""checkbox"" class=""form-check-input"" id=""dropdownCheck"">
                    <label class=""form-check-label"" for=""dropdownCheck"">
                        No recuerdo mi Contraseña
                    </label>
                </div>
            </div>
            <button type=""submit"" class=""btn btn-primary"">Iniciar sesion</button>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        <div class=""dropdown-divider""></div>
        <a class=""dropdown-item"" href=""#"">No tienes cuenta? Inscribete ya</a>
        <a class=""dropdown-item"" href=""#"">Olvidaste tu contraseña?</a>
    </div>
</div>

<div class=""accordion"" id=""accordionExample"">
  <div class=""card"">
    <div class=""card-header"" id=""headingOne"">
      <h2 class=""mb-0"">
        <button class=""btn btn-link btn-block text-left"" type=""button"" data-toggle=""collapse"" data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
          Collapsible Group Item #1
        </button>
      </h2>
    </div>

    <div id=""collapseOne"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
      <div class=""card-body"">
        Some placeholder content for the first accordion panel. This panel is shown by default, thanks to the <code>.show</code> class.
      </div>
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"" id=""headingTwo"">
      <h2 class=""mb-0"">");
            WriteLiteral(@"
        <button class=""btn btn-link btn-block text-left collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseTwo"" aria-expanded=""false"" aria-controls=""collapseTwo"">
          Collapsible Group Item #2
        </button>
      </h2>
    </div>
    <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
      <div class=""card-body"">
        Some placeholder content for the second accordion panel. This panel is hidden by default.
      </div>
    </div>
  </div>
  <div class=""card"">
    <div class=""card-header"" id=""headingThree"">
      <h2 class=""mb-0"">
        <button class=""btn btn-link btn-block text-left collapsed"" type=""button"" data-toggle=""collapse"" data-target=""#collapseThree"" aria-expanded=""false"" aria-controls=""collapseThree"">
          Collapsible Group Item #3
        </button>
      </h2>
    </div>
    <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
      <div c");
            WriteLiteral("lass=\"card-body\">\r\n        And lastly, the placeholder content for the third and final accordion panel. This panel is hidden by default.\r\n      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Veterinaria.App.Presentacion.Pages.LoginClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.LoginClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Veterinaria.App.Presentacion.Pages.LoginClienteModel>)PageContext?.ViewData;
        public Veterinaria.App.Presentacion.Pages.LoginClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591