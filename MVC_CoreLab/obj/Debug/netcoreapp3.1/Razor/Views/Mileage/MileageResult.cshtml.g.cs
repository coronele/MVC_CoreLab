#pragma checksum "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14bdca760d96b032d8611ded54c57fee696c5827"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mileage_MileageResult), @"mvc.1.0.view", @"/Views/Mileage/MileageResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14bdca760d96b032d8611ded54c57fee696c5827", @"/Views/Mileage/MileageResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba55783523e01922485f92a88d499c17c51935b7", @"/Views/_ViewImports.cshtml")]
    public class Views_Mileage_MileageResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
  
    ViewData["Title"] = "Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
   Mileage mileage = Model; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Mileage Result</h1>\r\n\r\nAt ");
#nullable restore
#line 10 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
Write(mileage.Gallons);

#line default
#line hidden
#nullable disable
            WriteLiteral(" gallons remaining and ");
#nullable restore
#line 10 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
                                     Write(mileage.Mpg);

#line default
#line hidden
#nullable disable
            WriteLiteral(" mpg, \r\nyou can travel ");
#nullable restore
#line 11 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
          Write(mileage.RemainingRange());

#line default
#line hidden
#nullable disable
            WriteLiteral(" more miles.\r\n\r\nIf you\'re traveling ");
#nullable restore
#line 13 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
               Write(mileage.Distance);

#line default
#line hidden
#nullable disable
            WriteLiteral(" more miles,\r\n");
#nullable restore
#line 14 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
 if (mileage.EnoughGas())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"color:green\">you have enough gas.</p>\r\n");
#nullable restore
#line 17 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p style=\"color:red\">you need more gas.</p>\r\n");
#nullable restore
#line 21 "C:\Users\coronele\source\repos\MVC_CoreLab\MVC_CoreLab\Views\Mileage\MileageResult.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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