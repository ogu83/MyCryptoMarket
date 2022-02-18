#pragma checksum "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "805f2fd5f5b733b7b3a2bb174f3c777058885510"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyCryptoMarket.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace MyCryptoMarket.Pages
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
#line 2 "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/_ViewImports.cshtml"
using MyCryptoMarket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/_ViewImports.cshtml"
using MyCryptoMarket.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"805f2fd5f5b733b7b3a2bb174f3c777058885510", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f3aaf4c230c4fff7d341361b52a2df40abaeadf", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 7 "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 11 "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/Index.cshtml"
 if (!SignInManager.IsSignedIn(User))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Welcome to MyCryptoMarket</h1>\r\n    </div>\r\n");
#nullable restore
#line 16 "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/Index.cshtml"
}
else 
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div");
            BeginWriteAttribute("class", " class=\"", 374, "\"", 382, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n        <h1>Market Data</h1>\r\n        <div id=\"gridContainer\"></div>\r\n    </div>\r\n");
#nullable restore
#line 23 "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(function() {\r\n            function isNotEmpty(value) {\r\n                return value !== undefined && value !== null && value !== \"\";\r\n            }\r\n\r\n            var obj = ");
#nullable restore
#line 32 "/Users/oguzkoroglu/Documents/Projects/MyCryptoMarket/Pages/Index.cshtml"
                 Write(Html.Raw(ViewData["Tickers"]));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

            $(""#gridContainer"").dxDataGrid({
                dataSource: obj,
                showBorders: true,
                paging: {
                    pageSize: 10
                },
                pager: {
                    showPageSizeSelector: true,
                    allowedPageSizes: [5, 10, 25, 50, 100]
                },
                columns: [{
                    dataField: ""Symbol"",
                    caption: ""Symbol"",
                    dataType: ""string""
                }, {
                    dataField: ""WeightedAvgPrice"",
                    caption: ""Price"",
                    dataType: ""number""
                }, {
                    dataField: ""PriceChangePercent"",
                    caption: ""24h Change"",
                    dataType: ""number""
                }, {
                    dataField: ""HighPrice"",
                    caption: ""24h High"",
                    dataType: ""number""
                }, {
                    dataField: """);
                WriteLiteral(@"LowPrice"",
                    caption: ""24h Low"",
                    dataType: ""number""
                }, {
                    dataField: ""Volume"",
                    caption: ""24h Volume"",
                    dataType: ""number""
                }]
            }).dxDataGrid(""instance"");
        })
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
