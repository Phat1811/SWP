#pragma checksum "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca13b8df42bde66a179e8e9a85a2b88c02a2e21a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Containers_Admin_CustomerManage), @"mvc.1.0.view", @"/Views/Containers/Admin/CustomerManage.cshtml")]
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
#line 1 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\_ViewImports.cshtml"
using MedicalStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
using MedicalStore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
using MedicalStore.Utils.Common;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca13b8df42bde66a179e8e9a85a2b88c02a2e21a", @"/Views/Containers/Admin/CustomerManage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fea9c2665feea2b81506cf7b17c6880d5f451533", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Containers_Admin_CustomerManage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 3 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
  
    var reportNums = (List<int>)this.ViewData["reportNums"];
    var orderNums = (List<int>)this.ViewData["orderNums"];
    var totals = (List<float>)this.ViewData["totals"];
    var listCustomer = (List<User>)this.ViewData["listCustomer"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"flex-1 min-h-screen px-2 py-2 xl:px-8 xl:py-6\">\r\n    <div class=\"flex\">\r\n        ");
#nullable restore
#line 12 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
   Write(await Html.PartialAsync("../../Components/Navbar/NavbarSide.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <div class=""container"">
            <div class=""mt-5 intro-y box"">
                <div class=""flex flex-col items-center p-5 border-b border-gray-200 sm:flex-row"">
                    <h2 class=""mr-auto text-base font-medium"">
                        All Customer
                    </h2>
                </div>
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca13b8df42bde66a179e8e9a85a2b88c02a2e21a4984", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 21 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
               Write(await Html.PartialAsync("../../Components/Form/FormHidden.cshtml",
                    new { Name = "pageSize", Value = (string)this.Context.Request.Query["pageSize"] ?? "12" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 23 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
               Write(await Html.PartialAsync("../../Components/Form/FormHidden.cshtml",
                    new { Name = "pageIndex", Value = (string)this.Context.Request.Query["pageIndex"] ?? "0" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
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
                <div class=""p-5"" id=""hoverable-table"">
                    <div class=""preview"">
                        <div class=""overflow-x-auto"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">#</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Name</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Order Number</th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">
                                            Bought Amount
                                            <a href=""/admin/customer?sortBy=buyIncreasing""
                                                title=""Sort by increasing Bought Amount"">▲</a>
                   ");
            WriteLiteral(@"                         <a href=""/admin/customer?sortBy=buyDecreasing""
                                                title=""Sort by descending Bought Amount"">▼</a>    
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">
                                            Report Number
                                            <a href=""/admin/customer?sortBy=reportIncreasing""
                                                title=""Sort by increasing Report time"">▲</a>
                                            <a href=""/admin/customer?sortBy=reportDecreasing""
                                                title=""Sort by descending Report time"">▼</a>    
                                        </th>
                                        <th class=""border border-b-2 dark:border-dark-5 whitespace-nowrap"">Status</th>
                                        <th class=""border border-b-2 dark:border-dark-5");
            WriteLiteral(" whitespace-nowrap\">Profile</th>\r\n                                    </tr>\r\n                                </thead>\r\n                                <tbody>\r\n");
#nullable restore
#line 54 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                                     for (int i = 0; i < listCustomer.Count; i++)
                                    {
                                        var link = $"{Routers.UserProfile.Link}?userId={listCustomer[i].UserId}";
                                        var linkReport = $"{Routers.Report.Link}?userId={listCustomer[i].UserId}";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr class=\"hover:bg-gray-200\">\r\n                                            <td class=\"border\">");
#nullable restore
#line 59 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                                                           Write(i+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 60 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                                                          Write(listCustomer[i].Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 61 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                                                          Write(orderNums[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 62 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                                                          Write(totals[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 4353, "\"", 4371, 1);
#nullable restore
#line 64 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
WriteAttributeValue("", 4360, linkReport, 4360, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""inline-flex items-center px-2.5 py-1.5 border border-transparent text-xs font-medium rounded text-indigo-700 bg-indigo-100 hover:bg-indigo-200 focus:outline-none focus:ring-2 focus:ring-offset-2 focus:ring-indigo-500"">
                                                    ");
#nullable restore
#line 65 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                                               Write(reportNums[i]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                </a>\r\n                                            </td>\r\n                                            <td class=\"border\">");
#nullable restore
#line 68 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                                                          Write(await Html.PartialAsync("../../Components/Table/Status.cshtml", listCustomer[i].Status == UserStatus.ACTIVE));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td class=\"border\">\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 5067, "\"", 5079, 1);
#nullable restore
#line 70 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
WriteAttributeValue("", 5074, link, 5074, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""mb-2 mr-1 btn btn-primary"">
                                                    <i data-feather=""shopping-bag"" class=""w-5 h-5""></i>
                                                </a>
                                            </td>
                                        </tr>
");
#nullable restore
#line 75 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                            ");
#nullable restore
#line 78 "F:\Trả Nợ\SWP391\Code\Deverlop\Views\Containers\Admin\CustomerManage.cshtml"
                       Write(await Html.PartialAsync("../../Components/Common/Pagination.cshtml",
                            new
                                 {
                                     PageIndex = (string)this.Context.Request.Query["pageIndex"] ?? "0",
                                     PageSize =
                            (string)
                            this.Context.Request.Query["pageSize"] ?? "12",
                                     Total = listCustomer.Count
                                 }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
