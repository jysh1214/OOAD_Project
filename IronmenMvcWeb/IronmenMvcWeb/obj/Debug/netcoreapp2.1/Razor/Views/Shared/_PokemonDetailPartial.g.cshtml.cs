#pragma checksum "C:\Users\cg\source\repos\IronmenMvcWeb\IronmenMvcWeb\Views\Shared\_PokemonDetailPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50f0177ae0c61615f5bcf4749e8b8ca6ee4eab2e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PokemonDetailPartial), @"mvc.1.0.view", @"/Views/Shared/_PokemonDetailPartial.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_PokemonDetailPartial.cshtml", typeof(AspNetCore.Views_Shared__PokemonDetailPartial))]
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
#line 1 "C:\Users\cg\source\repos\IronmenMvcWeb\IronmenMvcWeb\Views\_ViewImports.cshtml"
using IronmenMvcWeb;

#line default
#line hidden
#line 2 "C:\Users\cg\source\repos\IronmenMvcWeb\IronmenMvcWeb\Views\_ViewImports.cshtml"
using IronmenMvcWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50f0177ae0c61615f5bcf4749e8b8ca6ee4eab2e", @"/Views/Shared/_PokemonDetailPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f588048230aefc1f80450b7b57d6df573d6ceab8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PokemonDetailPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IronmenMvcWeb.Models.Pokemon>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(74, 91, true);
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt> Title </dt>\r\n        <dd>");
            EndContext();
            BeginContext(166, 11, false);
#line 9 "C:\Users\cg\source\repos\IronmenMvcWeb\IronmenMvcWeb\Views\Shared\_PokemonDetailPartial.cshtml"
       Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(177, 60, true);
            WriteLiteral("</dd>\r\n        <dt> Author </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(238, 12, false);
#line 12 "C:\Users\cg\source\repos\IronmenMvcWeb\IronmenMvcWeb\Views\Shared\_PokemonDetailPartial.cshtml"
       Write(Model.Author);

#line default
#line hidden
            EndContext();
            BeginContext(250, 61, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt> PublishDate </dt>\r\n        <dd>");
            EndContext();
            BeginContext(312, 17, false);
#line 15 "C:\Users\cg\source\repos\IronmenMvcWeb\IronmenMvcWeb\Views\Shared\_PokemonDetailPartial.cshtml"
       Write(Model.PublishDate);

#line default
#line hidden
            EndContext();
            BeginContext(329, 46, true);
            WriteLiteral("</dd>\r\n        <dt> Source </dt>\r\n        <dd>");
            EndContext();
            BeginContext(376, 12, false);
#line 17 "C:\Users\cg\source\repos\IronmenMvcWeb\IronmenMvcWeb\Views\Shared\_PokemonDetailPartial.cshtml"
       Write(Model.Source);

#line default
#line hidden
            EndContext();
            BeginContext(388, 24, true);
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IronmenMvcWeb.Models.Pokemon> Html { get; private set; }
    }
}
#pragma warning restore 1591
