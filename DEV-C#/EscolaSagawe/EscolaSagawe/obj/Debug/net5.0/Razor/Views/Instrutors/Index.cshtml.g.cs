#pragma checksum "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76a14f599e6e1bad0bf813ffe83ab9c247c4739e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Instrutors_Index), @"mvc.1.0.view", @"/Views/Instrutors/Index.cshtml")]
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
#line 1 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\_ViewImports.cshtml"
using EscolaSagawe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\_ViewImports.cshtml"
using EscolaSagawe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76a14f599e6e1bad0bf813ffe83ab9c247c4739e", @"/Views/Instrutors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d488cb5078977fc0e42cec8aac6114f760c53fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Instrutors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EscolaSagawe.Models.EscolaViewModels.InstrutorIndexDados>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
  
    ViewData["Title"] = "Instructors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Instrutores</h2>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a14f599e6e1bad0bf813ffe83ab9c247c4739e6414", async() => {
                WriteLiteral("Adcionar novo Inscrutor");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th>Last Name</th>
            <th>First Name</th>
            <th>Hire Date</th>
            <th>Office</th>
            <th>Courses</th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
         foreach (var item in Model.Instrutors)
        {
            string selectedRow = "";
            if (item.ID == (int?)ViewData["InstrutorID"])
            {
                selectedRow = "table-primary";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 728, "\"", 748, 1);
#nullable restore
#line 31 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
WriteAttributeValue("", 736, selectedRow, 736, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 33 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 36 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.SobreNome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DataAdmicacao));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
#nullable restore
#line 42 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                     if (item.Sala != null)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                   Write(item.Sala.Localizacao);

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                                              
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n");
#nullable restore
#line 48 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                     foreach (var curso in item.CursoAdministrados)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                   Write(curso.Curso.CursoID);

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                                        Write(curso.Curso.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 51 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </td>\r\n                <td>\r\n                    <div class=\"btn-group\" role=\"group\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a14f599e6e1bad0bf813ffe83ab9c247c4739e11729", async() => {
                WriteLiteral("Selecionar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                                                                                WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a14f599e6e1bad0bf813ffe83ab9c247c4739e14043", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                                                                                 WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a14f599e6e1bad0bf813ffe83ab9c247c4739e16354", async() => {
                WriteLiteral("Detalhes");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                                                                                  WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "76a14f599e6e1bad0bf813ffe83ab9c247c4739e18668", async() => {
                WriteLiteral("Excluir");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 58 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
                                                                                WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 62 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n<!--Bloco do botão de seleção-->\r\n<!-- Cursos do instrutor-->\r\n");
#nullable restore
#line 68 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
 if (Model.Cursos != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Cursos Administrados</h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th></th>\r\n            <th>Codigo</th>\r\n            <th>Titulo</th>\r\n            <th>Departamento</th>\r\n        </tr>\r\n\r\n");
#nullable restore
#line 79 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
         foreach (var item in Model.Cursos)
        {
            string selectedRow = "";
            if (item.CursoID == (int?)ViewData["CursoID"])
            {
                selectedRow = "alert-primary";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr");
            BeginWriteAttribute("class", " class=\"", 2698, "\"", 2718, 1);
#nullable restore
#line 86 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
WriteAttributeValue("", 2706, selectedRow, 2706, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <td>\r\n            <button class=\"btn  btn-outline-primary\">\r\n                ");
#nullable restore
#line 89 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
           Write(Html.ActionLink("Select", "Index", new { CursoID = item.CursoID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </button>\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 93 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
       Write(item.CursoID);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 96 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
       Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n        <td>\r\n            ");
#nullable restore
#line 99 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
       Write(item.Departamento.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 103 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
#nullable restore
#line 106 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Estudantes da Instrutor -->\r\n");
#nullable restore
#line 109 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
 if (Model.Matriculas != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>\r\n        Estudantes matriculados no curso\r\n    </h3>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Grade</th>\r\n        </tr>\r\n");
#nullable restore
#line 119 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
         foreach (var item in Model.Matriculas)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 123 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
               Write(item.Estudante.NomeCompleto);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 126 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Grade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 129 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 131 "C:\git\Estudo_em_Programacao\DEV-C#\EscolaSagawe\EscolaSagawe\Views\Instrutors\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EscolaSagawe.Models.EscolaViewModels.InstrutorIndexDados> Html { get; private set; }
    }
}
#pragma warning restore 1591
