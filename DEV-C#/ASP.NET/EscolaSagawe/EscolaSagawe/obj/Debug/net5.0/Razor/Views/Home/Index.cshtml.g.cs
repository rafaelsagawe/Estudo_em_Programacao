#pragma checksum "D:\Projetos de Desenvolvimento\Estudo_em_Programacao\DEV-C#\ASP.NET\EscolaSagawe\EscolaSagawe\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f48337622beae31495754107824e6234cb896b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Projetos de Desenvolvimento\Estudo_em_Programacao\DEV-C#\ASP.NET\EscolaSagawe\EscolaSagawe\Views\_ViewImports.cshtml"
using EscolaSagawe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos de Desenvolvimento\Estudo_em_Programacao\DEV-C#\ASP.NET\EscolaSagawe\EscolaSagawe\Views\_ViewImports.cshtml"
using EscolaSagawe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f48337622beae31495754107824e6234cb896b2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d488cb5078977fc0e42cec8aac6114f760c53fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Projetos de Desenvolvimento\Estudo_em_Programacao\DEV-C#\ASP.NET\EscolaSagawe\EscolaSagawe\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- A página home customizei da forma que mais me interessou, para o melhor visual, ou não  -->

<div class=""alert alert-primary"">
    <h1 class=""text-center"">Escola Sagawe</h1>
</div>

<div class=""container-fluid"">
    <div class=""card-deck"">
        <div class=""card rounded"">
            <h2 class=""card-header text-center"">Bem-Vindo</h2>
            <div class=""card-body text-justify"">
                A Escola Sagawe é um projeto de estudos usando o ASP.NET Cores, Entity Framework Core, SQLServer entre outras tecnologias da Microsoft
            </div>
            <div class=""card-footer text-center"">O projeto tambem será em portugues (com alguns erros 😅 )</div>
        </div>

        <div class=""card rounded list-group"">
            <h2 class=""card-header text-center"">Fonte</h2>
            <div class=""card-body "">
                <a target=""_blank"" href=""https://docs.microsoft.com/pt-br/aspnet/core/data/ef-mvc/?view=aspnetcore-5.0"" class=""list-group list-group-item list-group-item-");
            WriteLiteral(@"action"">Tutorial Base</a>
                
                <a target=""_blank"" href=""https://developer.mozilla.org/pt-BR/docs/Web/HTML""class=""list-group list-group-item list-group-item-action"">Material sobre HTML</a>
                
                <a target=""_blank"" href=""https://getbootstrap.com.br/docs/4.1/getting-started/introduction/""class=""list-group list-group-item list-group-item-action"">Material sobre Bootstrap</a>
            </div>
        </div>

        <div class=""card rounded"">
            <h2 class=""card-header text-center"">Extras usados</h2>

            <ul class=""list-group list-group-flush"">
                <li class=""list-group-item"">Atom One Dark Theme</li>
      
                <li class=""list-group-item"">Power Mode</li>

                <li class=""list-group-item""><a target=""_blank"" href=""https://datatables.net"">DataTables, Classificação, filtragem e paginação</a></li>

                <li class=""list-group-item""><a target=""_blank"" href=""https://fonts.google.com/spec");
            WriteLiteral(@"imen/Fira+Code"">Fonte firacode</a></li>
                </ul>
        </div>
    </div>
</div>
<br/>

<div class=""alert alert-primary text-center"">
    <label> Estatisticas </label>
</div>


<div class=""card-deck"">

    <div class=""card bg-secondary text-white"">
        <div class=""card-header text-center"">
            Quantidade de Alunos
        </div>

        <div class=""card-body"">
            Numero de alunos gedado do banco de dados
        </div>
    </div>


    <div class=""card bg-primary text-white"">
        <div class="" card-header text-center"">
            Quantidade de Cursos
        </div>

        <div class=""card-body"">
            Numero de cursos gedado do banco de dados
        </div>
    </div>

    <div class=""card bg-success text-white"">
        <div class="" card-header text-center"">
            Quantidade de Instrutores
        </div>

        <div class=""card-body"">
            Numero de Instrutores gedado do banco de dados
        </div>
   ");
            WriteLiteral(" </div>\r\n</div>\r\n   \r\n");
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
