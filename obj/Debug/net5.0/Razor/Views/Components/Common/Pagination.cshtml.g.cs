#pragma checksum "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc4de4bb789f5b03a8d6696059ff9d6ee9b25c1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_Common_Pagination), @"mvc.1.0.view", @"/Views/Components/Common/Pagination.cshtml")]
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
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc4de4bb789f5b03a8d6696059ff9d6ee9b25c1f", @"/Views/Components/Common/Pagination.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_Common_Pagination : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
  
    decimal pageIndex = Decimal.Parse(Model.PageIndex) ?? 0;
    decimal pageSize = Decimal.Parse(Model.PageSize) ?? 12;
    decimal total = Model.Total;

    var totalPage = (int)Math.Ceiling(total / pageSize);

    var totalRender = totalPage < 3 ? totalPage : 3;

    var pageRange = (((int)pageIndex - 1) < 0) ? 0 : ((int)pageIndex - 1);

    if (totalPage > 3 && pageIndex > totalPage - 3)
    {
        pageRange = totalPage - 3;
    }

    // Fix pageRange when totalPage = 2 or 3
    if (totalPage - pageRange < totalRender)
    {
        pageRange = 0;
    }

    var previousPage = pageIndex - 1;
    if (previousPage < 0)
    {
        previousPage = 0;
    }

    var nextPage = pageIndex + 1;
    if (nextPage > totalPage - 1)
    {
        nextPage = pageIndex;
    }

    var lastPage = totalPage - 1;
    if (lastPage < 0)
    {
        lastPage = 0;
    }

    var showMax = (pageIndex + 1) * pageSize;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""flex flex-wrap items-center col-span-12 py-2 intro-y sm:flex-row sm:flex-nowrap"">
    <ul class=""pagination"" id=""pagination-btn"">
        <li>
            <button data-index=""0"" class=""pagination__link""> <svg xmlns=""http://www.w3.org/2000/svg"" width=""24""
                    height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""1.5""
                    stroke-linecap=""round"" stroke-linejoin=""round"" class=""w-4 h-4 feather feather-chevrons-left"">
                    <polyline points=""11 17 6 12 11 7""></polyline>
                    <polyline points=""18 17 13 12 18 7""></polyline>
                </svg> </button>
        </li>
        <li>
            <button data-index=""");
#nullable restore
#line 56 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
                           Write(previousPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""pagination__link""> <svg xmlns=""http://www.w3.org/2000/svg""
                    width=""24"" height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""1.5""
                    stroke-linecap=""round"" stroke-linejoin=""round"" class=""w-4 h-4 feather feather-chevron-left"">
                    <polyline points=""15 18 9 12 15 6""></polyline>
                </svg> </button>
        </li>

");
#nullable restore
#line 63 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
         for (int i = pageRange; i < pageRange + totalRender; i++)
        {
            var display = i + 1;

            if (i == pageIndex)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"mx-2\">\r\n\r\n                    <button data-index=\"");
#nullable restore
#line 71 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"button\" class=\"p-2 font-semibold text-blue-500\" aria-current=\"page\">\r\n                        ");
#nullable restore
#line 72 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
                   Write(display);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                </li>\r\n");
#nullable restore
#line 75 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li class=\"mx-2\">\r\n                    <button data-index=\"");
#nullable restore
#line 79 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"button\" class=\"p-2 font-medium\" aria-current=\"page\">\r\n                        ");
#nullable restore
#line 80 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
                   Write(display);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </button>\r\n                </li>\r\n");
#nullable restore
#line 83 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"

            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <li>\r\n            <button data-index=\"");
#nullable restore
#line 89 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
                           Write(nextPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""pagination__link""> <svg xmlns=""http://www.w3.org/2000/svg"" width=""24""
                    height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""1.5""
                    stroke-linecap=""round"" stroke-linejoin=""round"" class=""w-4 h-4 feather feather-chevron-right"">
                    <polyline points=""9 18 15 12 9 6""></polyline>
                </svg> </button>
        </li>
        <li>
            <button data-index=""");
#nullable restore
#line 96 "C:\Users\LENOVO-PC\Desktop\SWP\pagination\SWP\Views\Components\Common\Pagination.cshtml"
                           Write(lastPage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" class=""pagination__link""> <svg xmlns=""http://www.w3.org/2000/svg"" width=""24""
                    height=""24"" viewBox=""0 0 24 24"" fill=""none"" stroke=""currentColor"" stroke-width=""1.5""
                    stroke-linecap=""round"" stroke-linejoin=""round"" class=""w-4 h-4 feather feather-chevrons-right"">
                    <polyline points=""13 17 18 12 13 7""></polyline>
                    <polyline points=""6 17 11 12 6 7""></polyline>
                </svg> </button>
        </li>
    </ul>

</div>");
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
