#pragma checksum "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "929eb0b3b5c4d678a3dd5a832a95289d3bc68a32"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Create), @"mvc.1.0.view", @"/Views/Product/Create.cshtml")]
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
#line 1 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\_ViewImports.cshtml"
using HandsOnAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\_ViewImports.cshtml"
using HandsOnAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929eb0b3b5c4d678a3dd5a832a95289d3bc68a32", @"/Views/Product/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4a35e71fa6f30129285e3f94b60822fc2a8d7f32", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HandsOnAssignment.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 8 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
     using (Html.BeginForm())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <table class=\"container\">\r\n            <tr>\r\n                <td>Product Id</td>\r\n                <td>");
#nullable restore
#line 13 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(m=>m.Pid));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 14 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
               Write(Html.ValidationMessageFor(m=>m.Pid));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Product Name</td>\r\n                <td>");
#nullable restore
#line 18 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(m=>m.Pname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
               Write(Html.ValidationMessageFor(m=>m.Pname));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Price</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(m => m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
               Write(Html.ValidationMessageFor(m=>m.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td>Stock</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
               Write(Html.TextBoxFor(m => m.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
               Write(Html.ValidationMessageFor(m=>m.Stock));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr>\r\n                <td colspan=\"2\"><input type=\"submit\" value=\"SAVE\"/></td>\r\n            </tr>\r\n        </table>\r\n");
#nullable restore
#line 35 "C:\Users\Naman\source\repos\HandsOnAssignment\HandsOnAssignment\Views\Product\Create.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HandsOnAssignment.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
