#pragma checksum "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "352033b276061ec466fa8057d6310290864c0f98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Estudios_CrearEstudio), @"mvc.1.0.view", @"/Views/Estudios/CrearEstudio.cshtml")]
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
#line 1 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\_ViewImports.cshtml"
using ConsultorioMedico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\_ViewImports.cshtml"
using ConsultorioMedico.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"352033b276061ec466fa8057d6310290864c0f98", @"/Views/Estudios/CrearEstudio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a479e3114fcf48987fecc467ba96b9bc24b6ba82", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Estudios_CrearEstudio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsultorioMedico.Models.EstudioCreacionDTO>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 style=\"margin-bottom:40px;\">Creá un Estudio Nuevo</h2>\r\n");
#nullable restore
#line 5 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
  
    if (ViewBag.Alerta != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-danger\">\r\n            ");
#nullable restore
#line 9 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
       Write(ViewBag.Alerta);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>       \r\n");
#nullable restore
#line 11 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
 using (Html.BeginForm("CrearEstudio", "Estudios", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div>\r\n                ");
#nullable restore
#line 18 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.LabelFor(d => d.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 19 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.TextBoxFor(d => d.Nombre, "", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 20 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.ValidationMessageFor(d => d.Nombre, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"dropdown\">\r\n                ");
#nullable restore
#line 23 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.LabelFor(d => d.MedicosAsociados));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 24 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.DropDownListFor(x => x.MedicosAsociados, (IEnumerable<SelectListItem>)ViewBag.Medicos, new { @multiple = true, @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 25 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.ValidationMessageFor(d => d.MedicosAsociados, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 28 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.LabelFor(d => d.FechayHora));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 29 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.TextBoxFor(d => d.FechayHora, "", new { @class = "form-control", @type = "datetime-local", @id = "fecha", onchange="validarfecha(e)"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 30 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.ValidationMessageFor(d => d.FechayHora, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 33 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.LabelFor(d => d.Resultado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 34 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.TextBoxFor(d => d.Resultado, "", new { @class = "form-control", @id = "resultado" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 35 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.ValidationMessageFor(d => d.Resultado, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"dropdown\">\r\n                ");
#nullable restore
#line 38 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.LabelFor(d => d.PacienteId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 39 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.DropDownListFor(x => x.PacienteId, (IEnumerable<SelectListItem>)ViewBag.Pacientes, new {@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 40 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
           Write(Html.ValidationMessageFor(d => d.PacienteId, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div style=\"text-align:right;\">\r\n                <input value=\"Guardar\" class=\"btn btn-primary\" type=\"submit\" />\r\n            </div>\r\n        </div>\r\n    </div>   \r\n");
#nullable restore
#line 48 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Estudios\CrearEstudio.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-primary\" role=\"button\" href=\"/estudios\">Volver</a>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsultorioMedico.Models.EstudioCreacionDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
