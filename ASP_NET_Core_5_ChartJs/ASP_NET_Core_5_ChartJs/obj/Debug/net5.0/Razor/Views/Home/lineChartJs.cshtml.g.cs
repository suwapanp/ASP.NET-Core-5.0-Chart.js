#pragma checksum "C:\MYSTART-UP2020\GitHub\ASP.NET-Core-5.0-Chart.js\ASP_NET_Core_5_ChartJs\ASP_NET_Core_5_ChartJs\Views\Home\lineChartJs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87dde95634ddf5882c1f9e66ecd3b5cfd7a01d4e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_lineChartJs), @"mvc.1.0.view", @"/Views/Home/lineChartJs.cshtml")]
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
#line 1 "C:\MYSTART-UP2020\GitHub\ASP.NET-Core-5.0-Chart.js\ASP_NET_Core_5_ChartJs\ASP_NET_Core_5_ChartJs\Views\_ViewImports.cshtml"
using ASP_NET_Core_5_ChartJs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MYSTART-UP2020\GitHub\ASP.NET-Core-5.0-Chart.js\ASP_NET_Core_5_ChartJs\ASP_NET_Core_5_ChartJs\Views\_ViewImports.cshtml"
using ASP_NET_Core_5_ChartJs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87dde95634ddf5882c1f9e66ecd3b5cfd7a01d4e", @"/Views/Home/lineChartJs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ad055bfada9af8f6973f8cf3baaaa7d9eae5216", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_lineChartJs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\MYSTART-UP2020\GitHub\ASP.NET-Core-5.0-Chart.js\ASP_NET_Core_5_ChartJs\ASP_NET_Core_5_ChartJs\Views\Home\lineChartJs.cshtml"
  
    ViewData["Title"] = "lineChartJs";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"py-5\">\r\n    <canvas id=\"LineChartJs\"></canvas>\r\n</div>\r\n\r\n");
#nullable restore
#line 11 "C:\MYSTART-UP2020\GitHub\ASP.NET-Core-5.0-Chart.js\ASP_NET_Core_5_ChartJs\ASP_NET_Core_5_ChartJs\Views\Home\lineChartJs.cshtml"
  
    ChartJSCore.Models.Chart chart = (ChartJSCore.Models.Chart)ViewData["LineChartJs"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        ");
#nullable restore
#line 18 "C:\MYSTART-UP2020\GitHub\ASP.NET-Core-5.0-Chart.js\ASP_NET_Core_5_ChartJs\ASP_NET_Core_5_ChartJs\Views\Home\lineChartJs.cshtml"
   Write(Html.Raw(chart.CreateChartCode("LineChartJs")));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
