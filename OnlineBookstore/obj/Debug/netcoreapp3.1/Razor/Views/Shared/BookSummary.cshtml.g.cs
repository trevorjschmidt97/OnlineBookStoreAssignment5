#pragma checksum "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa1435f9d87af32186aefdee234c81d9e16e5ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BookSummary), @"mvc.1.0.view", @"/Views/Shared/BookSummary.cshtml")]
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
#line 1 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/_ViewImports.cshtml"
using OnlineBookstore.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa1435f9d87af32186aefdee234c81d9e16e5ec", @"/Views/Shared/BookSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"757d9d002e23348a2adc58d3f41d0e74920f3827", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BookSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card card-outline-primary m-1 p-1\">\n    <div class=\"bg-faded p-1\">\n        <h4>\n            ");
#nullable restore
#line 6 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n            ");
#nullable restore
#line 7 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml"
       Write(Model.Pages);

#line default
#line hidden
#nullable disable
            WriteLiteral(" pages\n        </h4>\n        <h4>\n            <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\n                <small>$");
#nullable restore
#line 11 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml"
                   Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\n            </span>\n        </h4>\n        <h7>\n            Author: ");
#nullable restore
#line 15 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml"
               Write(Model.AuthorFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 15 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml"
                                      Write(Model.AuthorLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <br />\n            Category and Classification: ");
#nullable restore
#line 16 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml"
                                    Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 16 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml"
                                                      Write(Model.Classification);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\n            Publisher: ");
#nullable restore
#line 17 "/Users/trevorschmidt/Projects/OnlineBookstore/OnlineBookStoreAssignment5/OnlineBookstore/Views/Shared/BookSummary.cshtml"
                  Write(Model.Publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </h7>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
