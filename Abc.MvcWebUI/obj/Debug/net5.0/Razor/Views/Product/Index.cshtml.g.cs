#pragma checksum "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "feb37b7a55ed60336ad8652f5d8aa27228c9ca63"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\_ViewImports.cshtml"
using Abc.MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"feb37b7a55ed60336ad8652f5d8aa27228c9ca63", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91eb04f02d09a3f9bc2078e8f9412b0ed005c9c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
  
    Layout = "_Layout";
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <table class=\"table\">\r\n        <tr>\r\n            <td>Product Name</td>\r\n            <td>Unit Price</td>\r\n            <td>Unit In Stock</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
         foreach (var item in Model.Products)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 19 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
               Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 20 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
               Write(item.UnitPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
               Write(item.UnitsInStock);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 23 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n\r\n<product-list-pager");
            BeginWriteAttribute("page-size", " page-size=\"", 590, "\"", 617, 1);
#nullable restore
#line 27 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 602, Model.PageSize, 602, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("page-count", "\r\n                    page-count=\"", 618, "\"", 668, 1);
#nullable restore
#line 28 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 652, Model.PageCount, 652, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("current-category", "\r\n                    current-category=\"", 669, "\"", 731, 1);
#nullable restore
#line 29 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 709, Model.CurrentCategory, 709, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("current-page", "\r\n                    current-page=\"", 732, "\"", 786, 1);
#nullable restore
#line 30 "C:\Users\mcelebi\Desktop\Course\Abc\Abc.MvcWebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 768, Model.CurrentPage, 768, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></product-list-pager>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
