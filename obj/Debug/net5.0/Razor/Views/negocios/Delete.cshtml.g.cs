#pragma checksum "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d528e828503cd9bad269a7aca9cca0fe40d751f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_negocios_Delete), @"mvc.1.0.view", @"/Views/negocios/Delete.cshtml")]
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
#line 1 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\_ViewImports.cshtml"
using kairh_admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\_ViewImports.cshtml"
using kairh_admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d528e828503cd9bad269a7aca9cca0fe40d751f6", @"/Views/negocios/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35861eab807ced8690420396abcbf0dcdf9c7da6", @"/Views/_ViewImports.cshtml")]
    public class Views_negocios_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<kairh_admin.Models.negocio>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>negocio</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.idnegocio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.idnegocio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.calificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.calificacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.calle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.calle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ciudad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.colonia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.colonia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.cp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.domingoFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.domingoFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.domingoInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.domingoInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.domingock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.domingock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.especialidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.especialidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.estrellas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.estrellas));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.juevesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.juevesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.juevesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.juevesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 117 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.latitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 120 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.latitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 123 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.longitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 126 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.longitud));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 129 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.lunesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 132 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.lunesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 135 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.lunesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 138 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.lunesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 141 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.lunesck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 144 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.lunesck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 147 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.martesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 150 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.martesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 153 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.martesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 156 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.martesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 159 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.martesck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 162 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.martesck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 165 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.miercolesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 168 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.miercolesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 171 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.miercolesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 174 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.miercolesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 177 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.miercolesck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 180 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.miercolesck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 183 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 186 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.municipio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 189 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.nombreComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 192 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.nombreComercial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 195 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.numext));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 198 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.numext));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 201 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.numint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 204 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.numint));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 207 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.profileImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 210 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.profileImage));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 213 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 216 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.razonSocial));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 219 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.rfc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 222 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.rfc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 225 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.sabadoFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 228 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.sabadoFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 231 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.sabadoInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 234 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.sabadoInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 237 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.sabadock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 240 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.sabadock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 243 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 246 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.telefono));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 249 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 252 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.tipo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 255 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.viajes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 258 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.viajes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 261 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.viernesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 264 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.viernesFin));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 267 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.viernesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 270 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.viernesInicio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 273 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.viernesck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 276 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
       Write(Html.DisplayFor(model => model.viernesck));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d528e828503cd9bad269a7aca9cca0fe40d751f632692", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d528e828503cd9bad269a7aca9cca0fe40d751f632959", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 281 "C:\Users\Vicky\Desktop\DEVELOPER\kairh-admin\Views\negocios\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d528e828503cd9bad269a7aca9cca0fe40d751f634741", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<kairh_admin.Models.negocio> Html { get; private set; }
    }
}
#pragma warning restore 1591
