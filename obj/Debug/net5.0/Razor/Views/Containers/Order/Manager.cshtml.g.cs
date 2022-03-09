#pragma checksum "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48c7e61bd402fada37f46c7ba770c93ef2474dd7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Order_Manager), @"mvc.1.0.view", @"/Views/Containers/Order/Manager.cshtml")]
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
#line 1 "F:\Trả Nợ\SWP391\Code\Phat\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Trả Nợ\SWP391\Code\Phat\Views\_ViewImports.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48c7e61bd402fada37f46c7ba770c93ef2474dd7", @"/Views/Containers/Order/Manager.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Containers_Order_Manager : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("formFilter"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
  
    this.ViewData["Title"] = Routers.Category.Title;
    var orders = (List<Order>)this.ViewData["orders"];
    var total = (int)this.ViewData["total"];
    var search = (string)this.Context.Request.Query["search"];
    var endDate = (string)this.Context.Request.Query["endDate"];
    var startDate = (string)this.Context.Request.Query["startDate"];
    double totalOri = 0;
    double totalPro = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6 \">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 17 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""content"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">
                        Order Management
                    </h2>
                </div>
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">

                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48c7e61bd402fada37f46c7ba770c93ef2474dd75195", async() => {
                WriteLiteral("\r\n                        <div class=\"flex items-end space-x-2\">\r\n                            <div class=\"space-y-2\">\r\n                                <label>Name</label>\r\n                                ");
#nullable restore
#line 31 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                           Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml", new {Label="Name",
                                Field="search",Type="text", Value=search}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"space-y-2\">\r\n                                <label>Start Date</label>\r\n                                ");
#nullable restore
#line 37 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                           Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml", new {Label="Start Date",Field="startDate", Type="date", Value=startDate}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n                            <div class=\"space-y-2\">\r\n                                <label>End Date</label>\r\n                                ");
#nullable restore
#line 41 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                           Write(await Html.PartialAsync("../../Components/Form/TextField.cshtml", new {Label="End Date", Field="endDate",Type="date", Value=endDate}));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                            </div>
                            <div class=""flex items-end"">
                                <button class=""mb-2 btn btn-primary"">
                                    <i data-feather=""search"" class=""w-5 h-5""></i>
                                </button>

                            </div>
                        </div>
                        ");
#nullable restore
#line 50 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/FormHidden.cshtml",
                        new { Name = "pageSize", Value = (string) this.Context.Request.Query["pageSize"] ?? "12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        ");
#nullable restore
#line 52 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                   Write(await Html.PartialAsync("../../Components/Form/FormHidden.cshtml",
                        new { Name = "pageIndex",Value = (string) this.Context.Request.Query["pageIndex"] ?? "0" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>

                <div class=""p-5"" id=""hoverable-table"">
                    <div class=""preview"">
                        <div class=""overflow-x-auto"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">#
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Customer Name
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Total
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Profit
                                        </th>
                                        <th class=""border b");
            WriteLiteral(@"order-b-2 dark:border-dark-5 whitespace-nowrap"">Create Date
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Payment
                                            Method
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Stauts</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">View Detail</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 81 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                     for (int i = 0; i < orders.Count; i++)
                                    {   
                                        var item = orders[i];
                                        var link = $"{Routers.OrderDetail.Link}?orderId={item.OrderId}";
                                        totalOri += item.Total;
                                        totalPro += item.Profit;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"hover:bg-gray-200\">\r\n                                            <td class=\"border\">");
#nullable restore
#line 88 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                                           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 89 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                                          Write(item.Customer.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">$");
#nullable restore
#line 90 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                                           Write(item.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">$");
#nullable restore
#line 91 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                                           Write(item.Profit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 92 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                                          Write(item.CreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 93 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                                          Write(item.PaymentMethod);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">\r\n                                                ");
#nullable restore
#line 95 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                           Write(await Html.PartialAsync("../../Components/Table/Status.cshtml", item.Status
                                            == OrderStatus.ACTIVE ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td class=\"border\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 6048, "\"", 6060, 1);
#nullable restore
#line 99 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
WriteAttributeValue("", 6055, link, 6055, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"mb-2 mr-1 btn btn-primary\"> <i\r\n                                                    data-feather=\"shopping-bag\" class=\"w-5 h-5\"></i> </a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 103 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                                      <tr class=""hover:bg-gray-200"">
                                            <td class=""border""></td>
                                            <td class=""border"">Total</td>
                                            <td class=""border"">$");
#nullable restore
#line 110 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                                           Write(totalOri);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">$");
#nullable restore
#line 111 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                                                           Write(totalPro);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
                                            <td class=""border""></td>
                                            <td class=""border""></td>
                                            <td class=""border"">
                             
                                            </td>
                                            <td class=""border"">
                                              
                                            </td>
                                        </tr>
                                </tbody>
                            </table>
                              ");
#nullable restore
#line 123 "F:\Trả Nợ\SWP391\Code\Phat\Views\Containers\Order\Manager.cshtml"
                         Write(await Html.PartialAsync("../../Components/Common/Pagination.cshtml",
                            new { PageIndex = (string) this.Context.Request.Query["pageIndex"] ?? "0", PageSize =
                            (string)
                            this.Context.Request.Query["pageSize"]?? "12", Total = total }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n<script src=\"/js/pagination.js\"></script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
