#pragma checksum "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Division\DivResults.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d833d0ff6f929a2a6e7f2c26598ba3ff07410de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Division_DivResults), @"mvc.1.0.view", @"/Views/Division/DivResults.cshtml")]
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
#line 1 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\_ViewImports.cshtml"
using MVC_CoreLab;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\_ViewImports.cshtml"
using MVC_CoreLab.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d833d0ff6f929a2a6e7f2c26598ba3ff07410de", @"/Views/Division/DivResults.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba55783523e01922485f92a88d499c17c51935b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Division_DivResults : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Divide>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Division\DivResults.cshtml"
  
    ViewData["Title"] = "Divison Results";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h1>Divison Results</h1>\r\n");
#nullable restore
#line 9 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Division\DivResults.cshtml"
Write(Model.Dividend);

#line default
#line hidden
#nullable disable
            WriteLiteral(" divided by ");
#nullable restore
#line 9 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Division\DivResults.cshtml"
                      Write(Model.Divisor);

#line default
#line hidden
#nullable disable
            WriteLiteral(" equals ");
#nullable restore
#line 9 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Division\DivResults.cshtml"
                                            Write(Model.GetQuotient());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\nwith a remainder of ");
#nullable restore
#line 10 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Division\DivResults.cshtml"
               Write(Model.GetRemainder());

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Divide> Html { get; private set; }
    }
}
#pragma warning restore 1591