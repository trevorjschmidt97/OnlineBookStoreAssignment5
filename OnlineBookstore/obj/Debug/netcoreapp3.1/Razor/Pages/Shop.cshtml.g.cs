#pragma checksum "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53688cc84182c4d236facd943400b1e09364bb7c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OnlineBookstore.Pages.Pages_Shop), @"mvc.1.0.razor-page", @"/Pages/Shop.cshtml")]
namespace OnlineBookstore.Pages
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
#line 2 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/_ViewImports.cshtml"
using OnlineBookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/_ViewImports.cshtml"
using OnlineBookstore.Infrastructure;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53688cc84182c4d236facd943400b1e09364bb7c", @"/Pages/Shop.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c85b9a8ed441b20fd154a217217e0f59d6fa1da", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shop : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Remove", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h2>Your Cart</h2>

<table class=""table table-bordered table-striped"">
    <thead>
        <tr>
            <th class=""text-center"">Book</th>
            <th class=""text-left"">Quantity</th>
            <th class=""text-right"">Price</th>
            <th class=""text-right"">Subtotal</th>
            <th class=""text-center"">Edit</th>
        </tr>
    </thead>

    <tbody>
");
#nullable restore
#line 21 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
         foreach (var line in Model.Cart.Lines)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\n                <td class=\"text-center\">");
#nullable restore
#line 24 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
                                   Write(line.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-left\">");
#nullable restore
#line 25 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
                                 Write(line.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">$");
#nullable restore
#line 26 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
                                   Write(line.Book.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                <td class=\"text-right\">$");
#nullable restore
#line 27 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
                                    Write((line.Quantity * line.Book.Price).ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                <td class=\"text-center\">\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53688cc84182c4d236facd943400b1e09364bb7c6144", async() => {
                WriteLiteral("\n                        <input type=\"hidden\" name=\"bookId\"");
                BeginWriteAttribute("value", " value=\"", 940, "\"", 965, 1);
#nullable restore
#line 31 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
WriteAttributeValue("", 948, line.Book.BookId, 948, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <input type=\"hidden\" name=\"returnUrl\"");
                BeginWriteAttribute("value", " value=\"", 1031, "\"", 1055, 1);
#nullable restore
#line 32 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
WriteAttributeValue("", 1039, Model.ReturnUrl, 1039, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\n                        <button type=\"submit\" class=\"btn btn-sm btn-danger\">\n                            Remove\n                        </button>\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                </td>\n            </tr>\n");
#nullable restore
#line 39 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n\n    <tfoot>\n        <tr>\n            <td class=\"text-right\" colspan=\"4\">Total:</td>\n            <td class=\"text-right\">$");
#nullable restore
#line 45 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
                               Write(Model.Cart.ComputeTotalSum().ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n    </tfoot>\n</table>\n\n<div class=\"text-center\">\n    <a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1557, "\"", 1580, 1);
#nullable restore
#line 51 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Pages/Shop.cshtml"
WriteAttributeValue("", 1564, Model.ReturnUrl, 1564, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Shopping</a>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineBookstore.Pages.ShopModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBookstore.Pages.ShopModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OnlineBookstore.Pages.ShopModel>)PageContext?.ViewData;
        public OnlineBookstore.Pages.ShopModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
