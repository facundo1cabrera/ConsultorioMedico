#pragma checksum "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db23b01fbcc1e2360073f7bce847368d5127638b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pacientes_CrearPaciente), @"mvc.1.0.view", @"/Views/Pacientes/CrearPaciente.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db23b01fbcc1e2360073f7bce847368d5127638b", @"/Views/Pacientes/CrearPaciente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a479e3114fcf48987fecc467ba96b9bc24b6ba82", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Pacientes_CrearPaciente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ConsultorioMedico.Models.PacienteCreacionDTO>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h2 style=\"margin-bottom:40px;\">Creá un paciente</h2>\r\n");
#nullable restore
#line 5 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
 using (Html.BeginForm("CrearPaciente", "Pacientes", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div>\r\n                ");
#nullable restore
#line 10 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.LabelFor(d => d.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 11 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.TextBoxFor(d => d.Nombre, "", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 12 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.ValidationMessageFor(d => d.Nombre, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 15 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.LabelFor(d => d.Apellido));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 16 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.TextBoxFor(d => d.Apellido, "", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 17 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.ValidationMessageFor(d => d.Apellido, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 20 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.LabelFor(d => d.DNI));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 21 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.TextBoxFor(d => d.DNI, "", new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 22 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.ValidationMessageFor(d => d.DNI, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div>\r\n                ");
#nullable restore
#line 25 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.LabelFor(d => d.FechaNacimiento));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.TextBoxFor(d => d.FechaNacimiento, "", new { @class = "form-control", @type="date"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 27 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
           Write(Html.ValidationMessageFor(d => d.FechaNacimiento, null, new { @style = "color:red;"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <br />\r\n            <div style=\"text-align:right;\">\r\n                <input value=\"Guardar\" class=\"btn btn-primary\" type=\"submit\" />\r\n            </div>\r\n        </div>\r\n    </div>   \r\n");
#nullable restore
#line 35 "D:\facu\ort\PNT1\ConsultorioMedico\ConsultorioMedico\Views\Pacientes\CrearPaciente.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ConsultorioMedico.Models.PacienteCreacionDTO> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591