#pragma checksum "C:\Users\a2331\Downloads\PROG123-6\PROG123\PROG123\Views\Lin\OneClickBuy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dace006ac17c5fbe2b933c975a3c12ec6c407d35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Lin_OneClickBuy), @"mvc.1.0.view", @"/Views/Lin/OneClickBuy.cshtml")]
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
#line 1 "C:\Users\a2331\Downloads\PROG123-6\PROG123\PROG123\Views\_ViewImports.cshtml"
using PROG123;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\a2331\Downloads\PROG123-6\PROG123\PROG123\Views\_ViewImports.cshtml"
using PROG123.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dace006ac17c5fbe2b933c975a3c12ec6c407d35", @"/Views/Lin/OneClickBuy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44210dcadf1d9e0ad4e7680409e555499df7622", @"/Views/_ViewImports.cshtml")]
    public class Views_Lin_OneClickBuy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PROG123.Models.PurchaseModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\a2331\Downloads\PROG123-6\PROG123\PROG123\Views\Lin\OneClickBuy.cshtml"
  
    ViewData["Title"] = "OneClickBuy";
    Layout = "~/Views/Shared/_Lin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"margin-left:2cm\">One Click Buy</h1>\r\n\r\n\r\n<div style=\"margin-left:2cm\">\r\n    <h3>\r\n        Hi ");
#nullable restore
#line 13 "C:\Users\a2331\Downloads\PROG123-6\PROG123\PROG123\Views\Lin\OneClickBuy.cshtml"
      Write(Model.PersonModel.FName);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n        <br /><br />\r\n        Thanks for buying the ");
#nullable restore
#line 15 "C:\Users\a2331\Downloads\PROG123-6\PROG123\PROG123\Views\Lin\OneClickBuy.cshtml"
                         Write(Model.ProductModel.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n        Your credit card will be charged ");
#nullable restore
#line 16 "C:\Users\a2331\Downloads\PROG123-6\PROG123\PROG123\Views\Lin\OneClickBuy.cshtml"
                                    Write(Model.ProductModel.Price.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" and\r\n        shipped to ");
#nullable restore
#line 17 "C:\Users\a2331\Downloads\PROG123-6\PROG123\PROG123\Views\Lin\OneClickBuy.cshtml"
              Write(Model.PersonModel.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral(".\r\n        <br />\r\n        Please come back again. We love your money.\r\n    </h3>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PROG123.Models.PurchaseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
