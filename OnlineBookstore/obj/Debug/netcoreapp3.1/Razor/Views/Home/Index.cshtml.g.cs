#pragma checksum "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85a0008a3a6701315c1e156b35b148d63abe26b8"
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
#line 1 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85a0008a3a6701315c1e156b35b148d63abe26b8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc8334d051a2e18116ddfdcf75a4a36e58453fa8", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IQueryable<Book>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<header>\n    <h1>Welcome to Trevor Schmidt\'s Bookstore</h1>\n</header>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "85a0008a3a6701315c1e156b35b148d63abe26b83327", async() => {
                WriteLiteral("\n\n");
#nullable restore
#line 12 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
     foreach (var b in Model)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"card card-outline-primary m-1 p-1\">\n            <div class=\"bg-faded p-1\">\n                <h4>\n                    ");
#nullable restore
#line 17 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
               Write(b.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </h4>\n                <h4>\n                    <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\n                        <small>$");
#nullable restore
#line 21 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                           Write(b.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\n                    </span>\n                </h4>\n                <h7>\n                    Author: ");
#nullable restore
#line 25 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                       Write(b.AuthorFirstName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 25 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                          Write(b.AuthorLastName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br />\n                    Category and Classification: ");
#nullable restore
#line 26 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                            Write(b.Category);

#line default
#line hidden
#nullable disable
                WriteLiteral(" / ");
#nullable restore
#line 26 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                                                          Write(b.Classification);

#line default
#line hidden
#nullable disable
                WriteLiteral("<br />\n                    Publisher: ");
#nullable restore
#line 27 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
                          Write(b.Publisher);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                </h7>\n            </div>\n        </div>\n");
#nullable restore
#line 31 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookstore/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IQueryable<Book>> Html { get; private set; }
    }
}
#pragma warning restore 1591
